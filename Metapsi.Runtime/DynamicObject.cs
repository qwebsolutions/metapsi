using System;
using System.Collections.Generic;

namespace Metapsi
{
    public interface IDynamicProperty
    {
        Type Type { get; }
        string PropertyName { get; set; }
    }

    public class DynamicProperty
    {
        public Type Type { get; set; }
        public string PropertyName { get; set; }

        public static DynamicProperty<string> String(string name)
        {
            return new DynamicProperty<string>(name);
        }

        public static DynamicProperty<bool> Bool(string name)
        {
            return new DynamicProperty<bool>(name);
        }

        public static DynamicProperty<int> Int(string name)
        {
            return new DynamicProperty<int>(name);
        }
    }

    public class DynamicProperty<T> : IDynamicProperty
    {
        public Type Type => typeof(T);
        public string PropertyName { get; set; }

        public DynamicProperty(string name)
        {
            this.PropertyName = name;
        }
    }

    public class DynamicValue
    {
        public Type Type { get; set; }
        public object Value { get; set; }
    }

    public interface IDynamicObject
    {

    }

    //public class DynamicObject : IDynamicObject
    //{
        //public Dictionary<string, DynamicValue> Values { get; set; } = new Dictionary<string, DynamicValue>();

        //public T Get<T>(DynamicProperty<T> dynamicProperty)
        //{
        //    if (!Values.ContainsKey(dynamicProperty.PropertyName))
        //        return GetDefault<T>();

        //    return (T)(object)Values[dynamicProperty.PropertyName].Value;
        //}

        //public object Get(DynamicProperty dynamicProperty)
        //{
        //    if (!Values.ContainsKey(dynamicProperty.PropertyName))
        //        return GetDefault(dynamicProperty.Type);

        //    return Values[dynamicProperty.PropertyName].Value;
        //}

        //public void Set<T>(DynamicProperty<T> dynamicProperty, T value)
        //{
        //    Values[dynamicProperty.PropertyName] = new DynamicValue()
        //    {
        //        Type = typeof(T),
        //        Value = value
        //    };
        //}

        //public void Set(DynamicProperty dynamicProperty, object value)
        //{
        //    Values[dynamicProperty.PropertyName] = new DynamicValue()
        //    {
        //        Type = dynamicProperty.Type,
        //        Value = value
        //    };
        //}

        //private T GetDefault<T>()
        //{
        //    if (typeof(T) == typeof(string))
        //        return (T)(object)string.Empty;

        //    return default(T);
        //}

        //private object GetDefault(Type t)
        //{
        //    if (t == typeof(string))
        //        return string.Empty;

        //    if (t.IsValueType)
        //        return Activator.CreateInstance(t);

        //    return null;
        //}
    //}
}
