using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi
{
    public interface IJsonSerializer
    {
        string Name { get; }
        string ToJson(object obj);
        T FromJson<T>(string json);
        object FromJson(Type type, string json);
    }

    public static class Serialize
    {
        private static Lazy<Dictionary<string, IJsonSerializer>> jsonSerializers = new Lazy<Dictionary<string, IJsonSerializer>>(() =>
        {
            var allSerializers = AutoLoader.FindAllLoaded<IJsonSerializer>();
            Dictionary<string, IJsonSerializer> serializers = new Dictionary<string, IJsonSerializer>();
            foreach (var serializer in allSerializers)
            {
                serializers[serializer.Name] = serializer;
            }
            return serializers;
        });

        public static IJsonSerializer GetSerializer(string name)
        {
            var serializers = jsonSerializers.Value;
            if (!serializers.ContainsKey(name))
            {
                throw new ArgumentException($"Serializer {name} not found");
            }
            return serializers[name];
        }

        public static string ToJson(object o, string serializerName = "default")
        {
            string jsonContent = GetSerializer(serializerName).ToJson(o);
            return jsonContent;
        }

        public static T FromJson<T>(string json, string serializerName = "default")
        {
            T deserialized = GetSerializer(serializerName).FromJson<T>(json);
            return deserialized;
        }

        public static object FromJson(Type t, string json, string serializerName = "default")
        {
            object deserialized = GetSerializer(serializerName).FromJson(t, json);
            return deserialized;
        }

        //public static string ToTypedJson(object o)
        //{
        //    ObjectTypeWrapper untypedTypeWrapper = new ObjectTypeWrapper();
        //    untypedTypeWrapper.Set(o);

        //    return System.Text.Json.JsonSerializer.Serialize(untypedTypeWrapper, options: ToTypedJsonOptions);
        //}

        //public static object FromTypedJson(string serializedJson)
        //{
        //    var typeProperty = System.Text.Json.JsonSerializer.Deserialize<ObjectTypeWrapper>(serializedJson, FromTypedJsonOptions);
        //    Type contentObjectType = Type.GetType(typeProperty.TypeName);

        //    if (contentObjectType == null)
        //    {
        //        var allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes());
        //        contentObjectType = allTypes.FirstOrDefault(x => x.FullName == typeProperty.TypeName);
        //    }

        //    var genericWrapperType = typeof(GenericTypedWrapper<>).MakeGenericType(contentObjectType);

        //    object wrapperObject = System.Text.Json.JsonSerializer.Deserialize(serializedJson, genericWrapperType, FromTypedJsonOptions);
        //    ITypeWrapper objectAccessor = wrapperObject as ITypeWrapper;
        //    return objectAccessor.Get();
        //}
    }
    public static class Locate
    {
        public static object DataItemInCollection(object dataModel, string collectionName, System.Guid itemId)
        {
            dynamic collection = dataModel.GetType().GetProperty(collectionName).GetValue(dataModel);
            foreach (dynamic item in collection)
            {
                if (item.Id == itemId)
                {
                    return item;
                }
            }

            throw new System.Exception($"Cannot locate item with id {itemId} in {collectionName}");
        }
    }
}