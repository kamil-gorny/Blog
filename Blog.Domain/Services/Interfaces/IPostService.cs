using Blog.Domain.Models;
using Blog.Domain.Models.Dtos;
using Blog.Domain.Models.Entities;

namespace Blog.Domain.Services.Interfaces;

public interface IPostService
{
    Task<List<Post>> GetPosts();
    Task<Post> GetPostById(string id);
    Task CreatePost(CreatePostDto post);
}