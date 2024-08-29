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

        var line = new string('-', 60);

        Console.WriteLine(line);
        Console.WriteLine("Sharp YAML");
        Console.WriteLine(line);
        var sharpYaml = new SharpYamlSerializer();
        var sharpYamlContent = sharpYaml.Deserialize<Person>(yaml);
        var sharpYamlResult = sharpYaml.Serialize(sharpYamlContent);
        Console.WriteLine(sharpYamlContent);
        Console.WriteLine(sharpYamlResult);
        Console.WriteLine("\r\n");

        Console.WriteLine(line);
        Console.WriteLine("YAML DotNet");
        Console.WriteLine(line);
        var yamlDotNet = new YamlDotNetSerializer();
        var yamlDotNetContent = yamlDotNet.Deserialize<Person>(yaml);
        var yamlDotNetResult = yamlDotNet.Serialize(yamlDotNetContent);
        Console.WriteLine(yamlDotNetContent);
        Console.WriteLine(yamlDotNetResult);
        Console.WriteLine("\r\n");
    }
}
