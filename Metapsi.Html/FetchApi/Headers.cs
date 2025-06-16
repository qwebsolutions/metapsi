using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

/// <summary>
/// The Headers interface of the Fetch API allows you to perform various actions on HTTP request and response headers. These actions include retrieving, setting, adding to, and removing headers from the list of the request's headers.
/// </summary>
public interface Headers
{

}

/// <summary>
/// An object containing any HTTP headers that you want to pre-populate your Headers object with. 
/// </summary>
public interface HeadersInit
{

}

/// <summary>
/// 
/// </summary>
public static class HeadersExtensions
{
    /// <summary>
    /// The Headers() constructor creates a new Headers object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setHeaders"></param>
    /// <returns></returns>
    public static Var<Headers> NewHeaders(this SyntaxBuilder b, Action<PropsBuilder<HeadersInit>> setHeaders)
    {
        return b.New<Headers>(b.SetProps(b.NewObj<object>(), setHeaders));
    }

    /// <summary>
    /// Add headers to the HeadersInit object
    /// </summary>
    /// <param name="b"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public static void AddHeaders(this PropsBuilder<HeadersInit> b, Var<string> name, Var<string> value)
    {
        b.SetProperty(b.Props, name, value);
    }

    /// <summary>
    /// Add headers to the HeadersInit object
    /// </summary>
    /// <param name="b"></param>
    /// <param name="name"></param>
    /// <param name="value"></param>
    public static void AddHeaders(this PropsBuilder<HeadersInit> b, string name, string value)
    {
        b.AddHeaders(b.Const(name), b.Const(value));
    }

    /// <summary>
    /// Adds "Content-Type" "application/json" headers
    /// </summary>
    /// <param name="b"></param>
    public static void AddContentTypeJson(this PropsBuilder<HeadersInit> b)
    {
        b.AddHeaders("Content-Type", "application/json");
    }

    /// <summary>
    /// The append() method of the Headers interface appends a new value onto an existing header inside a Headers object, or adds the header if it does not already exist.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <param name="name">The name of the HTTP header you want to add to the Headers object.</param>
    /// <param name="value">The value of the HTTP header you want to add.</param>
    public static void HeadersAppend(this SyntaxBuilder b, Var<Headers> headers, Var<string> name, Var<string> value)
    {
        b.CallOnObject(headers, "append", name, value);
    }

    /// <summary>
    /// The delete() method of the Headers interface deletes a header from the current Headers object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <param name="name">The name of the HTTP header you want to delete from the Headers object.</param>
    public static void HeadersDelete(this SyntaxBuilder b, Var<Headers> headers, Var<string> name)
    {
        b.CallOnObject(headers, "delete", name);
    }

    /// <summary>
    /// The Headers.entries() method returns an iterator allowing to go through all key/value pairs contained in this object. Both the key and value of each pair are String objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    public static Var<object> HeadersEntries(this SyntaxBuilder b, Var<Headers> headers)
    {
        return b.CallOnObject<object>(headers, "entries");
    }

    /// <summary>
    /// The Headers.forEach() method executes a callback function once per each key/value pair in the Headers object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <param name="callbackFn">Function to execute for each entry in the map. It takes the following arguments:
    /// <para>value Value of the currently visited header entry.</para>
    /// <para>key Name of the currently visited header entry.</para>
    /// </param>
    public static void HeadersForEach(this SyntaxBuilder b, Var<Headers> headers, Var<Action<string,string>> callbackFn)
    {
        b.CallOnObject(headers, "forEach", callbackFn);
    }

    /// <summary>
    /// The get() method of the Headers interface returns a string of all the values of a header within a Headers object with a given name. If the requested header doesn't exist in the Headers object, it returns null.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <param name="name">The name of the HTTP header whose values you want to retrieve from the Headers object. If the given name is not the name of an HTTP header, this method throws a TypeError. The name is case-insensitive.</param>
    /// <returns></returns>
    public static Var<string> HeadersGet(this SyntaxBuilder b, Var<Headers> headers, Var<string> name)
    {
        return b.CallOnObject<string>(headers, "get", name);
    }

    /// <summary>
    /// The has() method of the Headers interface returns a boolean stating whether a Headers object contains a certain header.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <param name="name">The name of the HTTP header you want to test for. If the given name is not a valid HTTP header name, this method throws a TypeError.</param>
    /// <returns>A boolean value.</returns>
    public static Var<bool> HeadersHas(this SyntaxBuilder b, Var<Headers> headers, Var<string> name)
    {
        return b.CallOnObject<bool>(headers, "has", name);
    }

    /// <summary>
    /// The Headers.keys() method returns an iterator allowing to go through all keys contained in this object. The keys are String objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> HeadersKeys(this SyntaxBuilder b, Var<Headers> headers)
    {
        return b.CallOnObject<object>(headers, "keys");
    }

    /// <summary>
    /// The set() method of the Headers interface sets a new value for an existing header inside a Headers object, or adds the header if it does not already exist.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <param name="name">The name of the HTTP header you want to set to a new value. If the given name is not the name of an HTTP header, this method throws a TypeError.</param>
    /// <param name="value">The new value you want to set.</param>
    public static void HeadersSet(this SyntaxBuilder b, Var<Headers> headers, Var<string> name, Var<string> value)
    {
        b.CallOnObject(headers, "set", name, value);
    }

    /// <summary>
    /// The Headers.values() method returns an iterator allowing to go through all values contained in this object. The values are String objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> HeadersValues(this SyntaxBuilder b, Var<Headers> headers)
    {
        return b.CallOnObject<object>(headers, "values");
    }
}