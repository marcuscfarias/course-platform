using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{
    //TODO: property validation
    public User(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public string Name { get; private set; }

    //TODO: create value object for email
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public UserRoleEnum Role { get; private set; }
    public bool IsActive { get; private set; }
    public DateTimeOffset CreatedAt { get; private set; }
    public DateTimeOffset UpdatedAt { get; private set; }

    public void ChangeName(string name)
    {
        Name = name;
        UpdatedAt = DateTimeOffset.UtcNow;
    }
    
    public void Deactivate()
    {
        IsActive = false;
        UpdatedAt = DateTimeOffset.UtcNow;
    }
}