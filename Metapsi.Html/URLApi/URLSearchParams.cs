using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The URLSearchParams interface defines utility methods to work with the query string of a URL.
/// </summary>
public interface URLSearchParams
{
    /// <summary>
    /// The size read-only property of the URLSearchParams interface indicates the total number of search parameter entries.
    /// </summary>
    public int size { get; }
}

/// <summary>
/// 
/// </summary>
public static class URLSearchParamsExtensions
{
    /// <summary>
    /// The append() method of the URLSearchParams interface appends a specified key/value pair as a new search parameter.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameter to append.</param>
    /// <param name="value">The value of the parameter to append.</param>
    public static void URLSearchParamsAppend(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name, Var<string> value)
    {
        b.CallOnObject(p, "append", name, value);
    }

    /// <summary>
    /// The delete() method of the URLSearchParams interface deletes specified parameters and their associated value(s) from the list of all search parameters.
    /// <para> A parameter name and optional value are used to match parameters.If only a parameter name is specified, then all search parameters that match the name are deleted, along with their associated values.If both a parameter name and value are specified, then all search parameters that match both the parameter name and value are deleted.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameters to be deleted.</param>
    /// <param name="value">The value that parameters must match, along with the given name, to be deleted.</param>
    public static void URLSearchParamsDelete(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name, Var<string> value)
    {
        b.CallOnObject(p, "delete", name, value);
    }

    /// <summary>
    /// The delete() method of the URLSearchParams interface deletes specified parameters and their associated value(s) from the list of all search parameters.
    /// <para> A parameter name and optional value are used to match parameters.If only a parameter name is specified, then all search parameters that match the name are deleted, along with their associated values.If both a parameter name and value are specified, then all search parameters that match both the parameter name and value are deleted.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameters to be deleted.</param>
    public static void URLSearchParamsDelete(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name)
    {
        b.CallOnObject(p, "delete", name);
    }

    /// <summary>
    /// The entries() method of the URLSearchParams interface returns an iterator allowing iteration through all key/value pairs contained in this object. The iterator returns key/value pairs in the same order as they appear in the query string. The key and value of each pair are strings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> URLSearchParamsEntries(this SyntaxBuilder b, Var<URLSearchParams> p)
    {
        return b.CallOnObject<object>(p, "entries");
    }

    /// <summary>
    /// The forEach() method of the URLSearchParams interface allows iteration through all values contained in this object via a callback function.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="callback">Function to execute on each element, which is passed the following arguments:
    /// <para> value - The value of the current entry being processed in the URLSearchParams object.</para>
    /// <para> key - The key of the current entry being processed in the URLSearchParams object.</para>
    /// <para> searchParams - The URLSearchParams object the forEach() was called upon.</para>
    /// </param>
    /// <param name="thisArg">Value to use as this when executing callback.</param>
    public static void URLSearchParamsForEach(this SyntaxBuilder b, Var<URLSearchParams> p, Var<Func<string, string, URLSearchParams>> callback, IVariable thisArg)
    {
        b.CallOnObject(p, "forEach", callback, thisArg);
    }

    /// <summary>
    /// The forEach() method of the URLSearchParams interface allows iteration through all values contained in this object via a callback function.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="callback">Function to execute on each element, which is passed the following arguments:
    /// <para> value - The value of the current entry being processed in the URLSearchParams object.</para>
    /// <para> key - The key of the current entry being processed in the URLSearchParams object.</para>
    /// </param>
    public static void URLSearchParamsForEach(this SyntaxBuilder b, Var<URLSearchParams> p, Var<Func<string, string>> callback)
    {
        b.CallOnObject(p, "forEach", callback);
    }

    /// <summary>
    /// The forEach() method of the URLSearchParams interface allows iteration through all values contained in this object via a callback function.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="callback">Function to execute on each element, which is passed the following arguments:
    /// <para> value - The value of the current entry being processed in the URLSearchParams object.</para>
    /// </param>
    public static void URLSearchParamsForEach(this SyntaxBuilder b, Var<URLSearchParams> p, Var<Func<string>> callback)
    {
        b.CallOnObject(p, "forEach", callback);
    }

    /// <summary>
    /// The get() method of the URLSearchParams interface returns the first value associated to the given search parameter.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameter to return.</param>
    /// <returns>A string if the given search parameter is found; otherwise, null.</returns>
    public static Var<string> URLSearchParamsGet(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name)
    {
        return b.CallOnObject<string>(p, "get", name);
    }

    /// <summary>
    /// The getAll() method of the URLSearchParams interface returns all the values associated with a given search parameter as an array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameter to return.</param>
    /// <returns>An array of strings, which may be empty if no values for the given parameter are found.</returns>
    public static Var<List<string>> URLSearchParamsGetAll(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name)
    {
        return b.CallOnObject<List<string>>(p, "getAll", name);
    }

    /// <summary>
    /// The has() method of the URLSearchParams interface returns a boolean value that indicates whether the specified parameter is in the search parameters.
    /// <para>A parameter name and optional value are used to match parameters.If only a parameter name is specified, then the method will return true if any parameters in the query string match the name, and false otherwise.If both a parameter name and value are specified, then the method will return true if a parameter matches both the name and value.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameter to match.</param>
    /// <param name="value">The value of the parameter, along with the given name, to match.</param>
    /// <returns>A boolean value.</returns>
    public static Var<bool> URLSearchParamsHas(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name, Var<string> value)
    {
        return b.CallOnObject<bool>(p, "has", name, value);
    }

    /// <summary>
    /// The has() method of the URLSearchParams interface returns a boolean value that indicates whether the specified parameter is in the search parameters.
    /// <para>A parameter name and optional value are used to match parameters.If only a parameter name is specified, then the method will return true if any parameters in the query string match the name, and false otherwise.If both a parameter name and value are specified, then the method will return true if a parameter matches both the name and value.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameter to match.</param>
    /// <returns>A boolean value.</returns>
    public static Var<bool> URLSearchParamsHas(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name)
    {
        return b.CallOnObject<bool>(p, "has", name);
    }

    /// <summary>
    /// The keys() method of the URLSearchParams interface returns an iterator allowing iteration through all keys contained in this object. The keys are strings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> URLSearchParamsKeys(this SyntaxBuilder b, Var<URLSearchParams> p)
    {
        return b.CallOnObject<object>(p, "keys");
    }

    /// <summary>
    /// The set() method of the URLSearchParams interface sets the value associated with a given search parameter to the given value. If there were several matching values, this method deletes the others. If the search parameter doesn't exist, this method creates it.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <param name="name">The name of the parameter to set.</param>
    /// <param name="value">The value of the parameter to set.</param>
    public static void URLSearchParamsSet(this SyntaxBuilder b, Var<URLSearchParams> p, Var<string> name, Var<string> value)
    {
        b.CallOnObject(p, "set", name, value);
    }

    /// <summary>
    /// The URLSearchParams.sort() method sorts all key/value pairs contained in this object in place and returns undefined. The sort order is according to unicode code points of the keys. This method uses a stable sorting algorithm (i.e., the relative order between key/value pairs with equal keys will be preserved).
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    public static void URLSearchParamsSort(this SyntaxBuilder b, Var<URLSearchParams> p)
    {
        b.CallOnObject(p, "sort");
    }

    /// <summary>
    /// The toString() method of the URLSearchParams interface returns a query string suitable for use in a URL.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <returns>A string, without the question mark. Returns an empty string if no search parameters have been set. Characters in the application/x-www-form-urlencoded percent-encode set (which contains all code points except ASCII alphanumeric, *, -, ., and _) are percent-encoded, and U+0020 SPACE is encoded as +.</returns>
    public static Var<string> URLSearchParamsToString(this SyntaxBuilder b, Var<URLSearchParams> p)
    {
        return b.CallOnObject<string>(p, "toString");
    }

    /// <summary>
    /// The values() method of the URLSearchParams interface returns an iterator allowing iteration through all values contained in this object. The values are strings.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="p"></param>
    /// <returns>Returns an iterator.</returns>
    public static Var<object> URLSearchParamsValues(this SyntaxBuilder b, Var<URLSearchParams> p)
    {
        return b.CallOnObject<object>(p, "values");
    }
}