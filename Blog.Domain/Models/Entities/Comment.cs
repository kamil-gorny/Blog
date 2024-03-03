using Blog.Infrastructure.Models;

namespace Blog.Domain.Models.Entities;

public class Comment : Entity
{
    public string PostId { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Content { get; set; } = null!;
}