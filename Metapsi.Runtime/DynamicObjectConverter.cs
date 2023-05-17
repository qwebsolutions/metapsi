using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Metapsi
{
    public class DynamicObjectConverter : JsonConverter<DynamicObject>
    {
        private static Dictionary<string, Type> RegisteredTypes { get; set; } = new Dictionary<string, Type>();

        public static string RegisterType(Type type)
        {
            string typeCode = type.Name;
            RegisteredTypes[typeCode] = type;
            return typeCode;
        }

        public static Type GetType(string typeCode)
        {
            return RegisteredTypes[typeCode];
        }

        public override DynamicObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            DynamicObject dynamicObject = new DynamicObject();
            reader.Read(); // Start dynamic object array

            // It seems that sometimes the first token is already consumed? If array is empty, first read goes directly to ']'
            if (reader.TokenType == JsonTokenType.EndArray) 
                return dynamicObject;

            while (true)
            {
                reader.Read(); // next property array

                // There is no next property
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;

                // There is another property, start reading it
                if (reader.TokenType == JsonTokenType.StartArray)
                    reader.Read();

                var propertyName = reader.GetString();
                reader.Read(); // base64 of property type
                var propertyType = reader.GetString();
                reader.Read();

                Type objectType = GetType(propertyType);

                object obj = System.Text.Json.JsonSerializer.Deserialize(ref reader, objectType, options);

                dynamicObject.Set(
                    new DynamicProperty()
                    {
                        PropertyName = propertyName,
                        Type = objectType
                    },
                    obj);

                // End property array
                reader.Read();
            }

            return dynamicObject;
        }

        public override void Write(System.Text.Json.Utf8JsonWriter writer, DynamicObject value, System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            foreach (var dynValue in value.Values)
            {
                var typeCode = DynamicObjectConverter.RegisterType(dynValue.Value.Type);
                writer.WriteStartArray();
                writer.WriteRawValue($"\"{dynValue.Key}\"");
                writer.WriteRawValue($"\"{typeCode}\"");
                var s = System.Text.Json.JsonSerializer.Serialize(dynValue.Value.Value, options: options);
                writer.WriteRawValue(s);
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
        }
    }
}
