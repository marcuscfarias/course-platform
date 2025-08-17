using Domain.ValueObjects;

namespace UnitTests.Domain.ValueObjectTests;

public class ValueObjectTestClass(
    string? value1,
    string? value2) : ValueObject
{
    public string? Value1 { get; init; } = value1;
    public string? Value2 { get; init; } = value2;

    protected
        override
        IEnumerable<object?> GetAtomicValues()
    {
        yield return Value1;
        yield return Value2;
    }
}