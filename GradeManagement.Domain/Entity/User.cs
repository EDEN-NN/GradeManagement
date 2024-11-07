using GradeManagement.Domain.Enums;

namespace GradeManagement.Domain.Entity;

public class User
{

    public User()
    {
        CreatedAt = DateTimeOffset.UtcNow;
        UpdatedAt = DateTimeOffset.UtcNow;
    }

    public Guid Id { get; init; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string PasswordSalt { get; set; }
    public UserType UserType { get; set; }
    public string Email { get; set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset UpdatedAt { get; private set; }

    public void UpdateEmail(string email)
    {
        Email = email;
        UpdatedAt = DateTimeOffset.UtcNow;
    }

}