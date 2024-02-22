using Blog.Infrastructure.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Core.Models;

public class Comment : Entity
{
    public string PostId { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Content { get; set; } = null!;
}