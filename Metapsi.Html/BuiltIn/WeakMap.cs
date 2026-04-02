using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// A WeakMap is a collection of key/value pairs whose keys must be objects or non-registered symbols, 
/// with values of any arbitrary JavaScript type, and which does not create strong references to its keys. 
/// That is, an object's presence as a key in a WeakMap does not prevent the object from being garbage collected.
/// </summary>
public interface WeakMap
{

}

/// <summary>
/// 
/// </summary>
public static class WeakMapExtensions
{
    /// <summary>
    /// WeakMap class reference
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<WeakMap>> WeakMap(this SyntaxBuilder b)
    {
        return b.GetProperty<ClassDef<WeakMap>>(b.Window(), "WeakMap");
    }

    /// <summary>
    /// The delete() method of WeakMap instances removes the entry specified by the key from this WeakMap.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="key">The key of the entry to remove from the WeakMap object. Object keys are compared by reference, not by value.</param>
    /// <returns>true if an entry in the WeakMap object has been removed successfully. false if the key is not found in the WeakMap. Always returns false if key is not an object or a non-registered symbol.</returns>
    public static ObjBuilder<bool> delete(this ObjBuilder<WeakMap> b, IVariable key)
    {
        return b.Call<bool>(nameof(delete), key);
    }

    /// <summary>
    /// The get() method of WeakMap instances returns the value corresponding to the key in this WeakMap, or undefined if there is none. Object values are returned as the same reference that was originally stored, not as a copy, so mutations to the returned object will be reflected anywhere that reference is held, including inside the WeakMap.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="key">The key of the value to return from the WeakMap object. Object keys are compared by reference, not by value.</param>
    /// <returns>The value associated with the specified key in the WeakMap object. If the key can't be found, undefined is returned. Always returns undefined if key is not an object or a non-registered symbol.</returns>
    public static ObjBuilder<T> get<T>(this ObjBuilder<WeakMap> b, IVariable key)
    {
        return b.Call<T>(nameof(get), key);
    }

    /// <summary>
    /// The getOrInsert() method of WeakMap instances returns the value corresponding to the specified key in this WeakMap. If the key is not present, it inserts a new entry with the key and a given default value, and returns the inserted value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="key">The key of the value to return from the WeakMap object. Must be either an object or a non-registered symbol. Object keys are compared by reference, not by value.</param>
    /// <param name="defaultValue">The value to insert and return if the key is not already present in the WeakMap object.</param>
    /// <returns>The value associated with the specified key in the WeakMap object. If the key can't be found, defaultValue is inserted and returned.</returns>
    public static ObjBuilder<T> getOrInsert<T>(this ObjBuilder<WeakMap> b, IVariable key, Var<T> defaultValue)
    {
        return b.Call<T>(nameof(getOrInsert), key, defaultValue);
    }

    /// <summary>
    /// The getOrInsertComputed() method of WeakMap instances returns the value corresponding to the specified key in this WeakMap. If the key is not present, it inserts a new entry with the key and a default value computed from a given callback, and returns the inserted value.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="key">The key of the element to return from the Map object. Must be either an object or a non-registered symbol. Object keys are compared by reference, not by value.</param>
    /// <param name="callback">A function that returns the value to insert and return if the key is not already present in the Map object. The function is called with the following argument:
    /// <para> key - The same key that was passed to getOrInsertComputed().</para>
    /// </param>
    /// <returns>The value associated with the specified key in the WeakMap object. If the key can't be found, the result of callback(key) is inserted and returned.</returns>
    public static ObjBuilder<T> getOrInsertComputed<T>(this ObjBuilder<WeakMap> b, IVariable key, Var<System.Func<object,T>> callback)
    {
        return b.Call<T>(nameof(getOrInsertComputed), key, callback);
    }

    /// <summary>
    /// The has() method of WeakMap instances returns a boolean indicating whether an entry with the specified key exists in this WeakMap or not.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="key">The key of the entry to test for presence in the WeakMap object. Object keys are compared by reference, not by value.</param>
    /// <returns>Returns true if an entry with the specified key exists in the WeakMap object; otherwise false. Always returns false if key is not an object or a non-registered symbol.</returns>
    public static ObjBuilder<bool> has(this ObjBuilder<WeakMap> b, IVariable key)
    {
        return b.Call<bool>(nameof(has), key);
    }

    /// <summary>
    /// The set() method of WeakMap instances adds a new entry with a specified key and value to this WeakMap, or updates an existing entry if the key already exists.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="key">The key of the entry to add to or modify within the WeakMap object. Must be either an object or a non-registered symbol. Object keys are compared by reference, not by value.</param>
    /// <param name="value">The value of the entry to add to or modify within the WeakMap object. Can be any value.</param>
    /// <returns>The WeakMap object.</returns>
    public static ObjBuilder<WeakMap> set<T>(this ObjBuilder<WeakMap> b, IVariable key, Var<T> value)
    {
        return b.Call<WeakMap>(nameof(set), key, value);
    }
}