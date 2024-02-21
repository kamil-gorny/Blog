using Blog.Core.Models;
using MongoDB.Driver;

namespace Blog.Core.Services;

public class MongoDbService
{
    private readonly IMongoCollection<Post> _postsCollection;
    
    public MongoDbService(MongoDbSettings settings)
    {
        var client = new MongoClient(settings.ConnectionUrl);
        var database = client.GetDatabase(settings.DatabaseName);
        _postsCollection = database.GetCollection<Post>(settings.CollectionName);
    }   
}