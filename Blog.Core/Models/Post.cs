using Blog.Infrastructure.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Core.Models;

public class Post(string id) : Entity(id)
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
}