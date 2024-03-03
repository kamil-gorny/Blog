using Blog.Domain.Models.Dtos;
using Blog.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Api.Controllers;

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