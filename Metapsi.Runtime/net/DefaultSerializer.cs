using System;

namespace Metapsi
{
    public class DefaultSerializer : IJsonSerializer, IAutoLoader
    {
        public string Name { get; } = "default";

        private static Lazy<System.Text.Json.JsonSerializerOptions> options = new Lazy<System.Text.Json.JsonSerializerOptions>(() =>
        {
            return new System.Text.Json.JsonSerializerOptions()
            {
                WriteIndented = true,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
        });

        public string ToJson(object o)
        {
            string jsonContent = System.Text.Json.JsonSerializer.Serialize(o, options.Value);
            return jsonContent;
        }

        public T FromJson<T>(string json)
        {
            T deserialized = System.Text.Json.JsonSerializer.Deserialize<T>(json, options.Value);
            return deserialized;
        }

        public object FromJson(Type t, string json)
        {
            object deserialized = System.Text.Json.JsonSerializer.Deserialize(json, t, options.Value);
            return deserialized;
        }
    }
}