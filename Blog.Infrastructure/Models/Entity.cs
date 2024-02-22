using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Infrastructure.Models;

public abstract class Entity(string id)
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = id;

    public DateTime CreationDate { get; set; }
}