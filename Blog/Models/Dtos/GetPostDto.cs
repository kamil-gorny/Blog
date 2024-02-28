namespace Blog.Models.Dtos;

public class GetPostDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public List<string> Comments { get; set; } = new();
    public DateTime CreationDate { get; set; } 
    public static string Id { get; set; }
}