using Blog.Core.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Blog.Core.Services;

public class MongoDbService<T> where T : class
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

    public async Task<List<T>> GetAsync()
    {
        return await _collection.Find(new BsonDocument()).ToListAsync();
    }
}
