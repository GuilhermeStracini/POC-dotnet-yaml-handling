using YamlDotNet.Serialization;
using SharpYaml.Serialization;
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
        var yamlSharp = @"
        firstName: John
        lastName: Doe
        ";

        var input = new StringReader(yamlSharp);
        var yamlStream = new SharpYaml.Serialization.Serializer();
        var yamlObject = yamlStream.Deserialize(input);

        var output = new StringWriter();
        yamlStream.Serialize(output, yamlObject);
        var yamlResult = output.ToString();

        Console.WriteLine(yamlResult);

        var sharpSerializer = new SharpYaml.Serialization.Serializer();
        var sharpPerson = sharpSerializer.Deserialize<Person>(new StringReader(yamlSharp));

        var sharpYamlString = new StringWriter();
        sharpSerializer.Serialize(sharpYamlString, sharpPerson);
        Console.WriteLine(sharpYamlString.ToString());

        var person = deserializer.Deserialize<Person>(yaml);

        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        var yamlString = serializer.Serialize(person);
        Console.WriteLine(yamlString);
    }
}
