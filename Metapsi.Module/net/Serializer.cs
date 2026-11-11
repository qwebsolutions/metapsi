using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Metapsi
{
    public class Serializer : IJsonSerializer
    {
        private static readonly JsonSerializerOptions toLiteralOptions = new JsonSerializerOptions()
        {
            // The actual difference
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,

            MaxDepth = 256,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            IncludeFields = false, // default, but explicitly set to false as reference for custom serializers
            IgnoreReadOnlyProperties = false,// default, but explicitly set as reference for custom serializers
            WriteIndented = true,
            PropertyNamingPolicy = null,   // default, names exactly as declared in C#
            DictionaryKeyPolicy = null,    // default, dictionary keys unchanged
        };

        public string ToLiteral(object obj)
        {
            string jsonContent = System.Text.Json.JsonSerializer.Serialize(obj, toLiteralOptions);
            return jsonContent;
        }

        private static readonly JsonSerializerOptions toJsonOptions = new JsonSerializerOptions()
        {
            MaxDepth = 256,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            IncludeFields = false, // default, but explicitly set to false as reference for custom serializers
            IgnoreReadOnlyProperties = false,// default, but explicitly set as reference for custom serializers
            WriteIndented = true,
            PropertyNamingPolicy = null,   // default, names exactly as declared in C#
            DictionaryKeyPolicy = null,    // default, dictionary keys unchanged
        };

        public string ToJson(object o)
        {
            string jsonContent = System.Text.Json.JsonSerializer.Serialize(o, toJsonOptions);
            return jsonContent;
        }

        private static readonly JsonSerializerOptions fromJsonOptions = new JsonSerializerOptions()
        {
            MaxDepth = 256,
            PropertyNameCaseInsensitive = false
        };

        public object FromJson(Type t, string json)
        {
            object deserialized = System.Text.Json.JsonSerializer.Deserialize(json, t, fromJsonOptions);
            return deserialized;
        }
    }
}