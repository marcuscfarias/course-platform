namespace Domain.ValueObjects;

public sealed class Cpf : ValueObject
{
    //TODO: property validation
    public Cpf(string value)
    {
        Value = value;
    }
    public string Value { get; init; }
    protected override IEnumerable<object?> GetAtomicValues()
    {
        yield return Value;
    }
}