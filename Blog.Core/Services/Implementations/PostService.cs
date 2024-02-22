using Blog.Core.Models;
using Blog.Core.Services.Interfaces;
using Blog.Infrastructure.Services;

namespace Blog.Core.Services.Implementations;

public class PostService(MongoDbService<Post> mongoDbService) : IPostService
{
    public Task<List<Post>> GetPosts()
    {
        return mongoDbService.GetAsync();
    }
    
    public Task<Post> GetPostById(string id)
    {
        return mongoDbService.GetByIdAsync(id);
    }
   
    public Task CreatePost(string title, string description, string content)
    {
        var post = new Post
        {
            Title = title,
            Description = description,
            Content = content
        };
        return mongoDbService.CreateAsync(post);
    }
}