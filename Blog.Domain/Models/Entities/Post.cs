namespace Blog.Domain.Models.Entities;

public class Post()
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public List<string> Comments { get; set; } = new();
}