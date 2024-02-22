using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Core.Models;

public class Post
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public DateTime CreationDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
}