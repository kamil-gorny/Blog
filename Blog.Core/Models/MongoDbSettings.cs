namespace Blog.Core.Models;

public class MongoDbSettings
{
    public string ConnectionUrl { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string CollectionName { get; set; } = null!;
}