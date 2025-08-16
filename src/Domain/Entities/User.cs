using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Entities;

public class User : BaseEntity
{

    public string Cpf { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    //TODO: add role enum, email and address value objects
    // public Enum Role { get; private set; }
    // public Email Email { get; private set; } //EmailAddress from system.net.email
    public string Password { get; private set; }
    public bool IsActive { get; private set; }
    public DateOnly BirthDate { get; private set; }
    public Address Address { get; private set; }
    
    //TODO: property validation
    public User(string cpf, string firstName, string lastName, string password, bool isActive, DateOnly birthDate,
        Address address)
    {
        Cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
        FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        Password = password ?? throw new ArgumentNullException(nameof(password));
        IsActive = isActive;
        BirthDate = birthDate;
        Address = address ?? throw new ArgumentNullException(nameof(address));
    }
    
    public void Deactivate()
    {
        IsActive = false;
    }
}