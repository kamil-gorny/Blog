using Blog.Core.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[Controller]
[Route("api/[controller]")]
public class PostController(MongoDbService<Post> postService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var posts = await postService.GetAsync();
        return Ok(posts);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Post post)
    {
        await postService.CreateAsync(post);
        return CreatedAtAction(nameof(Get), new {id = post.Id}, post);
    }
    
}