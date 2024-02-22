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
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] PostRequestModel post)
    {
        await postService.CreatePost(post.Title, post.Description, post.Content);
        return CreatedAtAction(nameof(Get), new {id = Entity.Id}, post);
    }
    
}