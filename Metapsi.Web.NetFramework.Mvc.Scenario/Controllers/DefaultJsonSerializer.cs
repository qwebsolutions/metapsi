using System;

namespace Metapsi.Web.NetFramework.Mvc.Scenario.Controllers
{
    public class DefaultJsonSerializer : IJsonSerializer, IAutoLoader
    {
        public string Name => "default";

        public T FromJson<T>(string json)
        {
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return serializer.Deserialize<T>(json);
        }

        public object FromJson(Type type, string json)
        {
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return serializer.Deserialize(json, type);
        }

        public string ToJson(object obj)
        {
            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return serializer.Serialize(obj);
        }
    }
    /// <summary>
    /// One way serializer that outputs an object with all its public properties, including read-only, to JavaScript code
    /// </summary>
    public class JSObjectSerializer : IJsonSerializer, IAutoLoader
    {
        public string Name => "to-js";

        private static Lazy<System.Text.Json.JsonSerializerOptions> options = new Lazy<System.Text.Json.JsonSerializerOptions>(() =>
        {
            var newOptions = new System.Text.Json.JsonSerializerOptions()
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
            string jsonContent = System.Text.Json.JsonSerializer.Serialize(obj, options.Value);
            return jsonContent;
        }
    }
}