using Blog.Core.Models;
using Blog.Core.Models.Entities;
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

    public async Task AddComment(string id, string comment)
    {
        var post = await GetPostById(id);
        post.Comments.Add(comment);
        await mongoDbService.UpdateAsync(id, post);
    }

}