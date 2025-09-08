using FluentAssertions;

namespace UnitTests.Domain.ValueObjectTests;

public class ValueObjectTests
{
    [Fact]
    public void EqualsValueObject_NullArgument_ShouldReturnFalse()
    {
        //arrange
        ValueObjectTestClass valueObject1 = new("value1", "value2");
        ValueObjectTestClass? valueObject2 = null;

        //act
        var result = valueObject1.Equals(valueObject2);

        //assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(null, null, null, null)]
    [InlineData("value1", null, "value1", null)]
    [InlineData(null, "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", "value2")]
    public void EqualsValueObject_EqualValues_ShouldReturnTrue(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var result = valueObject1.Equals(valueObject2);

        //assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("value1", "value2", "different1", "value2")]
    [InlineData("value1", "value2", "value1", "different2")]
    [InlineData("value1", "value2", "different1", "different2")]
    [InlineData("value1", "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", null)]
    [InlineData(null, "value2", "value1", "value2")]
    [InlineData("value1", null, "value1", "value2")]
    public void EqualsValueObject_DifferentValues_ShouldReturnFalse(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var result = valueObject1.Equals(valueObject2);

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void EqualsObject_NullArgument_ShouldReturnFalse()
    {
        //arrange
        ValueObjectTestClass valueObject = new("value1", "value2");
        object? obj = null;

        //act
        var result = valueObject.Equals(obj);

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void EqualsObject_DifferentType_ShouldReturnFalse()
    {
        //arrange
        ValueObjectTestClass valueObject = new("value1", "value2");
        object obj = "not a value object";

        //act
        var result = valueObject.Equals(obj);

        //assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(null, null, null, null)]
    [InlineData("value1", null, "value1", null)]
    [InlineData(null, "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", "value2")]
    public void EqualsObject_EqualValues_ShouldReturnTrue(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        object valueObject2 = new ValueObjectTestClass(value3, value4);

        //act
        var result = valueObject1.Equals(valueObject2);

        //assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("value1", "value2", "different1", "value2")]
    [InlineData("value1", "value2", "value1", "different2")]
    [InlineData("value1", "value2", "different1", "different2")]
    [InlineData("value1", "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", null)]
    [InlineData(null, "value2", "value1", "value2")]
    [InlineData("value1", null, "value1", "value2")]
    public void EqualsObject_DifferentValues_ShouldReturnFalse(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        object valueObject2 = new ValueObjectTestClass(value3, value4);

        //act
        var result = valueObject1.Equals(valueObject2);

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void GetHashCode_SameValues_ShouldReturnSameHashCode()
    {
        //arrange
        ValueObjectTestClass valueObject1 = new("value1", "value2");
        ValueObjectTestClass valueObject2 = new("value1", "value2");

        //act
        var hashCode1 = valueObject1.GetHashCode();
        var hashCode2 = valueObject2.GetHashCode();

        //assert
        hashCode1.Should().Be(hashCode2);
    }

    [Theory]
    [InlineData("value1", "value2", "different1", "value2")]
    [InlineData("value1", "value2", "value1", "different2")]
    [InlineData("value1", "value2", "different1", "different2")]
    [InlineData("value1", "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", null)]
    [InlineData(null, "value2", "value1", "value2")]
    [InlineData("value1", null, "value1", "value2")]
    public void GetHashCode_DifferentValues_ShouldReturnDifferentHashCode(string? value1, string? value2,
        string? value3, string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var hashCode1 = valueObject1.GetHashCode();
        var hashCode2 = valueObject2.GetHashCode();

        //assert
        hashCode1.Should().NotBe(hashCode2);
    }

    [Fact]
    public void GetHashCode_WithNullValues_ShouldNotThrow()
    {
        //arrange
        ValueObjectTestClass valueObject = new(null, null);

        //act & assert
        valueObject.Invoking(vo => vo.GetHashCode())
            .Should().NotThrow();
    }

    [Fact]
    public void GetHashCode_WithNullValues_ShouldReturnValidHashCode()
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(null, null);
        ValueObjectTestClass valueObject2 = new(null, null);

        //act
        var hashCode1 = valueObject1.GetHashCode();
        var hashCode2 = valueObject2.GetHashCode();

        //assert
        hashCode1.Should().Be(hashCode2);
    }

    [Fact]
    public void OperatorEquals_BothNull_ShouldReturnTrue()
    {
        //arrange
        ValueObjectTestClass? valueObject1 = null;
        ValueObjectTestClass? valueObject2 = null;

        //act
        var result = valueObject1 == valueObject2;

        //assert
        result.Should().BeTrue();
    }

    [Fact]
    public void OperatorEquals_FirstNull_ShouldReturnFalse()
    {
        //arrange
        ValueObjectTestClass? valueObject1 = null;
        ValueObjectTestClass valueObject2 = new("value1", "value2");

        //act
        var result = valueObject1 == valueObject2;

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void OperatorEquals_SecondNull_ShouldReturnFalse()
    {
        //arrange
        ValueObjectTestClass valueObject1 = new("value1", "value2");
        ValueObjectTestClass? valueObject2 = null;

        //act
        var result = valueObject1 == valueObject2;

        //assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData(null, null, null, null)]
    [InlineData("value1", null, "value1", null)]
    [InlineData(null, "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", "value2")]
    public void OperatorEquals_EqualValues_ShouldReturnTrue(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var result = valueObject1 == valueObject2;

        //assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("value1", "value2", "different1", "value2")]
    [InlineData("value1", "value2", "value1", "different2")]
    [InlineData("value1", "value2", "different1", "different2")]
    [InlineData("value1", "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", null)]
    [InlineData(null, "value2", "value1", "value2")]
    [InlineData("value1", null, "value1", "value2")]
    public void OperatorEquals_DifferentValues_ShouldReturnFalse(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var result = valueObject1 == valueObject2;

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void OperatorNotEquals_BothNull_ShouldReturnFalse()
    {
        //arrange
        ValueObjectTestClass? valueObject1 = null;
        ValueObjectTestClass? valueObject2 = null;

        //act
        var result = valueObject1 != valueObject2;

        //assert
        result.Should().BeFalse();
    }

    [Fact]
    public void OperatorNotEquals_FirstNull_ShouldReturnTrue()
    {
        //arrange
        ValueObjectTestClass? valueObject1 = null;
        ValueObjectTestClass valueObject2 = new("value1", "value2");

        //act
        var result = valueObject1 != valueObject2;

        //assert
        result.Should().BeTrue();
    }

    [Fact]
    public void OperatorNotEquals_SecondNull_ShouldReturnTrue()
    {
        //arrange
        ValueObjectTestClass valueObject1 = new("value1", "value2");
        ValueObjectTestClass? valueObject2 = null;

        //act
        var result = valueObject1 != valueObject2;

        //assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(null, null, null, null)]
    [InlineData("value1", null, "value1", null)]
    [InlineData(null, "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", "value2")]
    public void OperatorNotEquals_EqualValues_ShouldReturnFalse(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var result = valueObject1 != valueObject2;

        //assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("value1", "value2", "different1", "value2")]
    [InlineData("value1", "value2", "value1", "different2")]
    [InlineData("value1", "value2", "different1", "different2")]
    [InlineData("value1", "value2", null, "value2")]
    [InlineData("value1", "value2", "value1", null)]
    [InlineData(null, "value2", "value1", "value2")]
    [InlineData("value1", null, "value1", "value2")]
    public void OperatorNotEquals_DifferentValues_ShouldReturnTrue(string? value1, string? value2, string? value3,
        string? value4)
    {
        //arrange
        ValueObjectTestClass valueObject1 = new(value1, value2);
        ValueObjectTestClass valueObject2 = new(value3, value4);

        //act
        var result = valueObject1 != valueObject2;

        //assert
        result.Should().BeTrue();
    }
}