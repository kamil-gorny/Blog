using Blog.Core.Models.Dtos;
using Blog.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers;

[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentService _commentService;
    [HttpPost]
    public ActionResult CreateComment([FromBody] CreateCommentDto dto)
    {
        if(ModelState.IsValid == false)
        {
            return BadRequest(ModelState);
        }
        var id = _commentService.CreateComment(dto);
        return Created($"/api/comment/{id}", null);
    }
}