using FluentAssertions;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace POCYamlHandling.Tests;

public class UnitTest1
{
    [Fact]
    public void ShouldDeserializeYamlCaseSensitive()
    {
        const string yaml = "Name: Jane Doe\nAge: 25";
        var deserializer = new DeserializerBuilder().Build();

        var person = deserializer.Deserialize<Person>(yaml);

        person.Name.Should().Be("Jane Doe");
        person.Age.Should().Be(25);
    }

    [Fact]
    public void ShouldDeserializeYamlCaseInsensitive()
    {
        const string yaml = "name: Jane Doe\nage: 25";
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var person = deserializer.Deserialize<Person>(yaml);

        person.Name.Should().Be("Jane Doe");
        person.Age.Should().Be(25);
    }

    [Fact]
    public void ShouldSerializeToYamlCaseSensitive()
    {
        var person = new Person { Name = "Jane Doe", Age = 25 };
        var serializer = new SerializerBuilder().Build();

        var yaml = serializer.Serialize(person);

        yaml.Should().Contain("Name: Jane Doe");
        yaml.Should().Contain("Age: 25");

        // Arrange
        const bool expected = true;

        // Act

        // Assert
        expected.Should().BeTrue();
    }

    [Fact]
    public void ShouldSerializeToYamlCaseInsensitive()
    {
        var person = new Person { Name = "Jane Doe", Age = 25 };
        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var yaml = serializer.Serialize(person);

        yaml.Should().Contain("name: Jane Doe");
        yaml.Should().Contain("age: 25");

        // Arrange
        const bool expected = true;

        // Act

        // Assert
        expected.Should().BeTrue();
    }
}