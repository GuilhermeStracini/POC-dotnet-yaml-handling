using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace POCYamlHandling.Serializers;

public class YamlDotNetSerializer : ISerializer
{
    /// <summary>
    /// Serializes an object of type <typeparamref name="T"/> into a JSON string.
    /// </summary>
    /// <typeparam name="T">The type of the object to be serialized.</typeparam>
    /// <param name="obj">The object to serialize.</param>
    /// <returns>A JSON string representation of the specified object <paramref name="obj"/>.</returns>
    /// <remarks>
    /// This method utilizes the SerializerBuilder from the YamlDotNet library to create a serializer configured with a camel case naming convention.
    /// The serialization process converts the provided object into a JSON format, making it suitable for storage or transmission.
    /// This method is particularly useful for converting complex objects into a string format that can be easily shared or stored.
    /// </remarks>
    public string Serialize<T>(T obj)
    {
        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        return serializer.Serialize(obj);
    }

    /// <summary>
    /// Deserializes a YAML string into an object of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the object to deserialize the YAML string into.</typeparam>
    /// <param name="yaml">The YAML string to be deserialized.</param>
    /// <returns>An object of type <typeparamref name="T"/> that represents the deserialized data from the YAML string.</returns>
    /// <remarks>
    /// This method uses a deserializer built with a camel case naming convention to convert the provided YAML string into an instance of the specified type <typeparamref name="T"/>.
    /// The deserialization process involves parsing the YAML format and mapping it to the properties of the target object type, allowing for easy conversion of structured data into usable objects in C#.
    /// Ensure that the structure of the YAML string matches the properties of the target type for successful deserialization.
    /// </remarks>
    public T Deserialize<T>(string yaml)
    {
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
        return deserializer.Deserialize<T>(yaml);
    }
}
