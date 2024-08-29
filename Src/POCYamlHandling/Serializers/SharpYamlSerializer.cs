namespace POCYamlHandling.Serializers;

public class SharpYamlSerializer : ISerializer
{
    /// <summary>
    /// Serializes an object of type <typeparamref name="T"/> into a YAML formatted string.
    /// </summary>
    /// <typeparam name="T">The type of the object to be serialized.</typeparam>
    /// <param name="obj">The object to be serialized into YAML format.</param>
    /// <returns>A string representation of the serialized object in YAML format.</returns>
    /// <remarks>
    /// This method utilizes the SharpYaml library to convert an object of any specified type into a YAML string.
    /// The serialization process involves creating a new instance of the serializer, writing the serialized output to a StringWriter,
    /// and then returning the resulting string. This is useful for persisting data in a human-readable format or for configuration files.
    /// The method assumes that the object provided can be serialized by the SharpYaml serializer without any issues.
    /// </remarks>
    public string Serialize<T>(T obj)
    {
        var serializer = new SharpYaml.Serialization.Serializer();

        var yaml = new StringWriter();
        serializer.Serialize(yaml, obj);
        return yaml.ToString();
    }

    /// <summary>
    /// Deserializes a YAML string into an object of the specified type.
    /// </summary>
    /// <typeparam name="T">The type of the object to deserialize the YAML string into.</typeparam>
    /// <param name="yaml">The YAML string to be deserialized.</param>
    /// <returns>An object of type <typeparamref name="T"/> that represents the deserialized data.</returns>
    /// <remarks>
    /// This method utilizes the SharpYaml library to convert a YAML formatted string into a .NET object.
    /// The deserialization process reads the provided YAML string and maps its structure to the properties of the specified type <typeparamref name="T"/>.
    /// It is important that the structure of the YAML matches the properties of the target type for successful deserialization.
    /// If the YAML string is not well-formed or does not match the expected structure, an exception may be thrown during the deserialization process.
    /// </remarks>
    public T Deserialize<T>(string yaml)
    {
        var serializer = new SharpYaml.Serialization.Serializer();
        return serializer.Deserialize<T>(new StringReader(yaml));
    }
}
