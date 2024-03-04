using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Persistance;

internal class BlogDbContext : DbContext
{
    internal DbSet<Comment> Comments { get; set; } = null!;
    internal DbSet<Post> Posts { get; set; } = null!;
}