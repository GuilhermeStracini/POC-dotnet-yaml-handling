namespace POCYamlHandling.Serializers;

public class SharpYamlSerializer : ISerializer
{
    public string Serialize<T>(T obj)
    {
        var serializer = new SharpYaml.Serialization.Serializer();

        var yaml = new StringWriter();
        serializer.Serialize(yaml, obj);
        return yaml.ToString();
    }

    public T Deserialize<T>(string yaml)
    {
        var serializer = new SharpYaml.Serialization.Serializer();
        return serializer.Deserialize<T>(new StringReader(yaml));
    }
}
