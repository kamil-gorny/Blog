using Blog.Domain.Models.Dtos;

namespace Blog.Domain.Services.Interfaces;

public interface ICommentService
{
    Task CreateComment(CreateCommentDto comment);
}