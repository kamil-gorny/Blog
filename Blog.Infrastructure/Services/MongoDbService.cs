using Blog.Core.Models;
using Blog.Infrastructure.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Blog.Infrastructure.Services;

public class MongoDbService<T> where T : Entity
{
    private readonly IMongoCollection<T> _collection;
    
    public MongoDbService(IOptions<MongoDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionUrl);
        var database = client.GetDatabase(settings.Value.DatabaseName);
        _collection = database.GetCollection<T>(settings.Value.CollectionName);
    }   
    
    public async Task CreateAsync(T entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public Task<List<T>> GetAsync()
    {
        return _collection.Find(new BsonDocument()).ToListAsync();
    }
    
    public Task<T> GetByIdAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("Id", id);
        return _collection.Find(filter).FirstOrDefaultAsync();
    }
    
    public Task UpdateAsync(string id, T entity)
    {
        var filter = Builders<T>.Filter.Eq("Id", id);
         return _collection.ReplaceOneAsync(filter, entity);
    }
    
    public Task DeleteAsync(string id)
    {
        var filter = Builders<T>.Filter.Eq("Id", id);
        return  _collection.DeleteOneAsync(filter);
    }
}
