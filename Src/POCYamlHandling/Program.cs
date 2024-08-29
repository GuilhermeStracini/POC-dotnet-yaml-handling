using POCYamlHandling.Serializers;

namespace POCYamlHandling;

/// <summary>
/// Class Program.
/// </summary>
internal static class Program
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        var yaml =
            @"
        name: John Doe
        age: 30
        ";

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("Sharp YAML");
        Console.WriteLine("---------------------------------------------------------------");
        var sharpYaml = new SharpYamlSerializer();
        var sharpYamlContent = sharpYaml.Deserialize<Person>(yaml);
        var sharpYamlResult = sharpYaml.Serialize(sharpYamlContent);
        Console.WriteLine(sharpYamlContent);
        Console.WriteLine(sharpYamlResult);
        Console.WriteLine("\r\n");

        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("YAML DotNet");
        Console.WriteLine("---------------------------------------------------------------");
        var yamlDotNet = new YamlDotNetSerializer();
        var yamlDotNetContent = yamlDotNet.Deserialize<Person>(yaml);
        var yamlDotNetResult = yamlDotNet.Serialize(yamlDotNetContent);
        Console.WriteLine(yamlDotNetContent);
        Console.WriteLine(yamlDotNetResult);
        Console.WriteLine("\r\n");
    }
}
