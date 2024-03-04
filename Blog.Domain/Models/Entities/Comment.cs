namespace Blog.Domain.Models.Entities;

public class Comment
{
    
    public string PostId { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Content { get; set; } = null!;
}