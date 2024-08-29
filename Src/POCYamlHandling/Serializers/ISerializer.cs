namespace POCYamlHandling.Serializers;

/// <summary>
/// Interface ISerializer
/// </summary>
public interface ISerializer
{
    /// <summary>
    /// Serializes the specified object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="obj">The object.</param>
    /// <returns>System.String.</returns>
    public string Serialize<T>(T obj);

    /// <summary>
    /// Deserializes the specified yaml.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="yaml">The yaml.</param>
    /// <returns>T.</returns>
    public T Deserialize<T>(string yaml);
}
