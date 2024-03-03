namespace Blog.Domain.Models.Dtos;

public class CommentDto
{
    public string PostId { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Content { get; set; } = null!;
}