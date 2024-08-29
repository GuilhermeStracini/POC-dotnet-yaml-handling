using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace POCYamlHandling.Serializers;

public class YamlDotNetSerializer : ISerializer
{
    public string Serialize<T>(T obj)
    {
        var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();

        return serializer.Serialize(obj);
    }

    public T Deserialize<T>(string yaml)
    {
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
        return deserializer.Deserialize<T>(yaml);
    }
}
