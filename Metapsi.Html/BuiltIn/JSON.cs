using Metapsi.Syntax;

namespace Metapsi.Html;

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
    /// <returns>A JSON string representing the given value, or undefined.</returns>
    public static Var<string> JsonStringify(this SyntaxBuilder b, IVariable value)
    {
        return b.CallOnObject<string>(
            b.GetProperty<DynamicObject>(b.Self(), "JSON"),
            "stringify",
            value);
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
