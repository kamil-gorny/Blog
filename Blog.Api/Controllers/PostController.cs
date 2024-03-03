using Blog.Domain.Models.Dtos;
using Blog.Domain.Services.Interfaces;
using Blog.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

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
        await postService.CreatePost(post);
        return CreatedAtAction(nameof(Get), new {id = Entity.Id}, post);
    }
    
}