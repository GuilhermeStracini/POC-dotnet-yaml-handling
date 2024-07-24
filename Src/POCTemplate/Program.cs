namespace POCTemplate;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
internal class Person { public string Name { get; set; } = string.Empty; public int Age { get; set; } }

internal static class Program
{
    public static void Main()
    {
        var yaml = @"
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
        // This is a placeholder for the main entry point of the application.
        Console.WriteLine("Hello, World!");
    }
}
