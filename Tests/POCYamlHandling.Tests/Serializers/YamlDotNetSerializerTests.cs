using FluentAssertions;
using POCYamlHandling.Serializers;

namespace POCYamlHandling.Tests.Serializers;

public class YamlDotNetSerializerTests
{
    private readonly YamlDotNetSerializer _serializer = new();

    // [Fact]
    // public void ShouldDeserializeYamlCaseSensitive()
    // {
    //     // Arrange
    //     const string yaml = "Name: Jane\nFullName: Jane Doe\nAge: 25";

    //     // Act
    //     var person = _serializer.Deserialize<Person>(yaml);

    //     // Assert
    //     person.Name.Should().Be("Jane");
    //     person.FullName.Should().Be("Jane Doe");
    //     person.Age.Should().Be(25);
    // }

    [Fact]
    public void ShouldDeserializeYamlCaseInsensitive()
    {
        // Arrange
        const string yaml = "name: Jane\nfullName: Jane Doe\nage: 25";

        // Act
        var person = _serializer.Deserialize<Person>(yaml);

        // Assert
        person.Name.Should().Be("Jane");
        person.FullName.Should().Be("Jane Doe");
        person.Age.Should().Be(25);
    }

    // [Fact]
    // public void ShouldSerializeToYamlCaseSensitive()
    // {
    //     // Arrange
    //     var person = new Person
    //     {
    //         Name = "Jane",
    //         FullName = "Jane Doe",
    //         Age = 25,
    //     };

    //     // Act
    //     var yaml = _serializer.Serialize(person);

    //     // Assert
    //     yaml.Should().Contain("Name: Jane");
    //     yaml.Should().Contain("FullName: Jane Doe");
    //     yaml.Should().Contain("Age: 25");
    // }

    [Fact]
    public void ShouldSerializeToYamlCaseInsensitive()
    {
        // Arrange
        var person = new Person
        {
            Name = "Jane Doe",
            FullName = "Jane Doe",
            Age = 25,
        };

        // Act
        var yaml = _serializer.Serialize(person);

        // Assert
        yaml.Should().Contain("name: Jane");
        yaml.Should().Contain("fullName: Jane Doe");
        yaml.Should().Contain("age: 25");
    }
}
