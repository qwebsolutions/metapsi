using Metapsi.Syntax;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public class JsonStringifyOptions
{
    /// <summary>
    /// 
    /// </summary>
    public object Replacer { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public object Space { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class JsonExtensions
{

    /// <summary>
    /// The JSON.stringify() static method converts a JavaScript value to a JSON string
    /// </summary>
    /// <param name="b"></param>
    /// <param name="value"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<string> JsonStringify(this SyntaxBuilder b, IVariable value, Action<PropsBuilder<JsonStringifyOptions>> setOptions = null)
    {
        var options = b.SetProps(b.NewObj(), setOptions);
        return b.CallOnObject<string>(
            b.GetProperty<DynamicObject>(b.Self(), "JSON"),
            "stringify",
            value,
            b.Get(options, x => x.Replacer),
            b.Get(options, x => x.Space));
    }
    /// <summary>
    /// A function that alters the behavior of the stringification process, or an array of strings and numbers that specifies properties of value to be included in the output. If replacer is an array, all elements in this array that are not strings or numbers (either primitives or wrapper objects), including Symbol values, are completely ignored. If replacer is anything other than a function or an array (e.g., null or not provided), all string-keyed properties of the object are included in the resulting JSON string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="replacer"></param>
    public static void SetReplacer(this PropsBuilder<JsonStringifyOptions> b, Func<SyntaxBuilder, Var<string>, Var<object>, Var<string>> replacer)
    {
        b.Set(x => x.Replacer, b.Def(replacer));
    }

    /// <summary>
    /// A function that alters the behavior of the stringification process, or an array of strings and numbers that specifies properties of value to be included in the output. If replacer is an array, all elements in this array that are not strings or numbers (either primitives or wrapper objects), including Symbol values, are completely ignored. If replacer is anything other than a function or an array (e.g., null or not provided), all string-keyed properties of the object are included in the resulting JSON string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="replacer"></param>
    public static void SetReplacer(this PropsBuilder<JsonStringifyOptions> b, Var<List<string>> replacer)
    {
        b.Set(x => x.Replacer, replacer);
    }

    /// <summary>
    /// A string or number that's used to insert white space (including indentation, line break characters, etc.) into the output JSON string for readability purposes.
    /// <para> If this is a number, it indicates the number of space characters to be used as indentation, clamped to 10 (that is, any number greater than 10 is treated as if it were 10). Values less than 1 indicate that no space should be used.</para>
    /// <para> If this is a string, the string (or the first 10 characters of the string, if it's longer than that) is inserted before every nested object or array.</para>
    /// <para> If space is anything other than a string or number(can be either a primitive or a wrapper object) — for example, is null or not provided — no white space is used.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="space"></param>
    public static void SetSpace(this PropsBuilder<JsonStringifyOptions> b, Var<int> space)
    {
        b.Set(x => x.Space, space);
    }

    /// <summary>
    /// A string or number that's used to insert white space (including indentation, line break characters, etc.) into the output JSON string for readability purposes.
    /// <para> If this is a number, it indicates the number of space characters to be used as indentation, clamped to 10 (that is, any number greater than 10 is treated as if it were 10). Values less than 1 indicate that no space should be used.</para>
    /// <para> If this is a string, the string (or the first 10 characters of the string, if it's longer than that) is inserted before every nested object or array.</para>
    /// <para> If space is anything other than a string or number(can be either a primitive or a wrapper object) — for example, is null or not provided — no white space is used.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <param name="space"></param>
    public static void SetSpace(this PropsBuilder<JsonStringifyOptions> b, Var<string> space)
    {
        b.Set(x => x.Space, space);
    }

    private static Var<string> JsonStringify(SyntaxBuilder b, IVariable value, IVariable replacer = null, IVariable space = null)
    {
        if (replacer != null && space != null)
        {
            return b.CallOnObject<string>(
                b.GetProperty<DynamicObject>(b.Self(), "JSON"),
                "stringify",
                value,
                replacer,
                space);
        }
        else if (replacer != null && space == null)
        {
            return b.CallOnObject<string>(
                b.GetProperty<DynamicObject>(b.Self(), "JSON"),
                "stringify",
                value,
                replacer);
        }
        else
        {
            return b.CallOnObject<string>(
            b.GetProperty<DynamicObject>(b.Self(), "JSON"),
            "stringify",
            value);
        }
    }

    /// <summary>
    /// The JSON.parse() static method parses a JSON string, constructing the JavaScript value or object described by the string.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="text">The string to parse as JSON.</param>
    /// <returns>The Object, Array, string, number, boolean, or null value corresponding to the given JSON text.</returns>
    public static Var<DynamicObject> JsonParse(this SyntaxBuilder b, Var<string> text)
    {
        return b.CallOnObject<DynamicObject>(
            b.GetProperty<DynamicObject>(b.Self(), "JSON"),
            "parse",
            text);
    }
}
