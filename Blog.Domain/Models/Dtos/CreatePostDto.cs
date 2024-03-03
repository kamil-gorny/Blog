using System.ComponentModel.DataAnnotations;

namespace Blog.Domain.Models.Dtos;

public class CreatePostDto
{
    [Required]
    public string Title { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
    [Required]
    public string Content { get; set; } = null!;
}