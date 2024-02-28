using Blog.Core.Models.Dtos;

namespace Blog.Core.Services.Interfaces;

public interface ICommentService
{
    Task CreateComment(CreateCommentDto comment);
}