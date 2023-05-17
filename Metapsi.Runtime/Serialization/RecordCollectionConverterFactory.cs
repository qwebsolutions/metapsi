using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Metapsi
{
    public class RecordCollectionConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.Name.Contains("RecordCollection");
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var recordType = typeToConvert.GenericTypeArguments[0];
            var typedDeserializer = typeof(RecordCollectionDeserializer<>).MakeGenericType(recordType);
            object converter = Activator.CreateInstance(typedDeserializer);
            return converter as JsonConverter;
        }
    }
}
