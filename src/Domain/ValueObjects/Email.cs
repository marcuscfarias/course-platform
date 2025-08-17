namespace Domain.ValueObjects;

public sealed class Email : ValueObject
{
    //TODO: propety validation
    public Email(string value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Value { get; init; }
    
    protected override IEnumerable<object?> GetAtomicValues()
    {
        yield return Value;
    }
}