namespace Domain.ValueObjects;

//https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects
//https://www.milanjovanovic.tech/blog/value-objects-in-dotnet-ddd-fundamentals
public abstract class ValueObject : IEquatable<ValueObject>
{
    public static bool operator ==(ValueObject? a, ValueObject? b)
    {
        if (a is null && b is null)
            return true;
    
        if (a is null || b is null)
            return false;
    
        return a.Equals(b);
    }
    
    public static bool operator !=(ValueObject? a, ValueObject? b) =>
        !(a == b);

    public bool Equals(ValueObject? other) =>
        other is not null
        && ValuesAreEqual(other);

    public override bool Equals(object? obj) =>
        obj is ValueObject valueObject //checks null too
        && ValuesAreEqual(valueObject);

    private bool ValuesAreEqual(ValueObject valueObject) =>
        GetAtomicValues().SequenceEqual(valueObject.GetAtomicValues());

    protected abstract IEnumerable<object?> GetAtomicValues();

    public override int GetHashCode() =>
        GetAtomicValues().Aggregate(
            0,
            (hashcode, value) =>
                HashCode.Combine(hashcode, value?.GetHashCode() ?? 0));
}