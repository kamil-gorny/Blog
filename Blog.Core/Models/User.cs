using Blog.Infrastructure.Models;

namespace Blog.Core.Models;

public class User : Entity
{
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string RoleId { get; set; }
    public virtual Role Role { get; set; }
}