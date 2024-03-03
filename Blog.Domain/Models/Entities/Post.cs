using Blog.Infrastructure.Models;

namespace Blog.Domain.Models.Entities;

public class Post() : Entity()
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public List<string> Comments { get; set; } = new();
}