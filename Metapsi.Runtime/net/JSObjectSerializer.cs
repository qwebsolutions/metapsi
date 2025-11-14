using System;
using System.Text.Json;

namespace Metapsi.Syntax
{
    /// <summary>
    /// One way serializer that outputs an object with all its public properties, including read-only, to JavaScript code
    /// </summary>
    public class JSObjectSerializer : IJsonSerializer, IAutoLoader
    {
        public string Name => "to-js";

        public Lazy<System.Text.Json.JsonSerializerOptions> options = new Lazy<System.Text.Json.JsonSerializerOptions>(() =>
        {
            var newOptions = new JsonSerializerOptions()
            {
                MaxDepth = 256,
                WriteIndented = true,
                IgnoreReadOnlyFields = true,
                IgnoreReadOnlyProperties = false,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
            return newOptions;
        });

        public T FromJson<T>(string json)
        {
            throw new NotSupportedException();
        }

        public object FromJson(Type type, string json)
        {
            throw new NotSupportedException();
        }

        public string ToJson(object obj)
        {
            string jsonContent = JsonSerializer.Serialize(obj, options.Value);
            return jsonContent;
        }
    }
}

