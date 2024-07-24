using FluentAssertions;
using YamlDotNet.Serialization;

namespace POCTemplate.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
public class Person { public string Name { get; set; } = string.Empty; public int Age { get; set; } }

    [Fact]
    public void ShouldDeserializeYaml()
    {
        const string yaml = "name: Jane Doe\nage: 25";
        var deserializer = new DeserializerBuilder().Build();

        var person = deserializer.Deserialize<Person>(yaml);

        person.Name.Should().Be("Jane Doe");
        person.Age.Should().Be(25);
    }

    [Fact]
    public void ShouldSerializeToYaml()
    {
        var person = new Person { Name = "Jane Doe", Age = 25 };
        var serializer = new SerializerBuilder().Build();

        var yaml = serializer.Serialize(person);

        yaml.Should().Contain("name: Jane Doe");
        yaml.Should().Contain("age: 25");
    }
    {
        // Arrange
        const bool expected = true;

        // Act

        // Assert
        expected.Should().BeTrue();
    }
}
