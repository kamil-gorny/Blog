using Blog.Core.Models;

namespace Blog.Core.Services.Interfaces;

public interface IPostService
{
    Task<List<Post>> GetPosts();
    Task<Post> GetPostById(string id);
    Task CreatePost(string title, string description, string content);
}