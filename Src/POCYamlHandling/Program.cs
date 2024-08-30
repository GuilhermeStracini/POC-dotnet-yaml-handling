using System.Diagnostics.CodeAnalysis;
using POCYamlHandling.Serializers;

namespace POCYamlHandling;

/// <summary>
/// Class Program.
/// </summary>
[ExcludeFromCodeCoverage]
internal static class Program
{
    /// <summary>
    /// The entry point of the application that demonstrates the usage of YAML serialization and deserialization.
    /// </summary>
    /// <remarks>
    /// This method performs the following actions:
    /// 1. Prints "Hello, World!" to the console.
    /// 2. Defines a YAML string representing a person's name and age.
    /// 3. Separates sections in the console output with a line of dashes.
    /// 4. Demonstrates serialization and deserialization using the SharpYaml library:
    ///    - Deserializes the YAML string into a <see cref="Person"/> object.
    ///    - Serializes the <see cref="Person"/> object back into a YAML string.
    ///    - Prints both the deserialized object and the serialized string to the console.
    /// 5. Separates sections in the console output with another line of dashes.
    /// 6. Demonstrates serialization and deserialization using the YamlDotNet library:
    ///    - Deserializes the same YAML string into a <see cref="Person"/> object.
    ///    - Serializes the <see cref="Person"/> object back into a YAML string.
    ///    - Prints both the deserialized object and the serialized string to the console.
    /// This method does not return any value and does not throw any exceptions.
    /// </remarks>
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
