using Blog.Core.Models.Dtos;
using Blog.Core.Services.Interfaces;
using Blog.Infrastructure.Models;
using Blog.Infrastructure.Services;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[Controller]
[Route("api/[controller]")]
public class PostController(IPostService postService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var posts = await postService.GetPosts();
        return Ok(posts);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] string id)
    {
        var post = await postService.GetPostById(id);
        return Ok(post);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreatePostDto post)
    {
        await postService.CreatePost(post.Title, post.Description, post.Content);
        return CreatedAtAction(nameof(Get), new {id = Entity.Id}, post);
    }
    
}