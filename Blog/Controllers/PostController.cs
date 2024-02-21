using Blog.Core.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[Controller]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    private readonly MongoDbService _mongoDbService;

    public PostController(MongoDbService mongoDbService)
    {
        _mongoDbService = mongoDbService;
    }
    
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var posts = await _mongoDbService.GetAsync();
        return Ok(posts);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Post post)
    {
        await _mongoDbService.CreateAsync(post);
        return CreatedAtAction(nameof(Get), new {id = post.Id}, post);
    }
    
}