using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace POCYamlHandling;

internal static class Program
{
    public static void Main()
    {
        var yaml =
            @"
        name: John Doe
        age: 30
        ";

        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var person = deserializer.Deserialize<Person>(yaml);

        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var yamlString = serializer.Serialize(person);
        Console.WriteLine(yamlString);
    }
}
