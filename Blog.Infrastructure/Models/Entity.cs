using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blog.Infrastructure.Models;

public abstract class Entity()
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public static string Id { get; set; } = new ObjectId().ToString();

    public DateTime CreationDate { get; set; } = DateTime.Now;
}
