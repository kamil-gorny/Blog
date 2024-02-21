using Blog.Core.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Blog.Core.Services;

public class MongoDbService
{
    private readonly IMongoCollection<Post> _postsCollection;
    
    public MongoDbService(IOptions<MongoDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionUrl);
        var database = client.GetDatabase(settings.Value.DatabaseName);
        _postsCollection = database.GetCollection<Post>(settings.Value.CollectionName);
    }   
    
    public async Task CreateAsync(Post post)
    {
        await _postsCollection.InsertOneAsync(post);
    }

    public async Task<List<Post>> GetAsync()
    {
        return await _postsCollection.Find(new BsonDocument()).ToListAsync();
    }
}