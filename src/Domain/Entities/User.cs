using Domain.Entities;
using Domain.Enums;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{
    //TODO: property validation
    public User(string name)
    {
        // Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
        Name = name ?? throw new ArgumentNullException(nameof(name));
        // LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        // Role = role;
        // Email = email ?? throw new ArgumentNullException(nameof(email));
        // Password = password ?? throw new ArgumentNullException(nameof(password));
        // IsActive = isActive;
        // BirthDate = birthDate;
        // Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    // public Cpf Cpf { get; private set; }
    public string Name { get; private set; }
    // public string LastName { get; private set; }
    // public UserRoleEnum Role { get; private set; }
    // public Email Email { get; private set; }
    // public string Password { get; private set; }
    // public bool IsActive { get; private set; }
    // public DateOnly BirthDate { get; private set; }
    // public Address Address { get; private set; }
    //
    // public void Deactivate()
    // {
    //     IsActive = false;
    // }
}