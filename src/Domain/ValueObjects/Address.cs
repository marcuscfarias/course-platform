
namespace Domain.ValueObjects;

public sealed class Address : ValueObject
{
    public string Cep { get; init; }
    public string Street { get; init; }
    public int Number { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string Complement { get; init; }
    
    //TODO: property validation
    public Address(string cep, string street, int number, string city, string state, string complement)
    {
        Cep = cep ?? throw new ArgumentNullException(nameof(cep));
        Street = street ?? throw new ArgumentNullException(nameof(street));
        Number = number;
        City = city ?? throw new ArgumentNullException(nameof(city));
        State = state ?? throw new ArgumentNullException(nameof(state));
        Complement = complement ?? throw new ArgumentNullException(nameof(complement));
    }
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return Cep;
        yield return Street;
        yield return Number;
        yield return City;
        yield return State;
        yield return Complement;
    }
}