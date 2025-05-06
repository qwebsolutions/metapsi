using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;



public static class ObjectExtensions
{
    private static Var<object> StaticObject(this SyntaxBuilder b)
    {
        return b.GetProperty<object>(b.Self(), "Object");
    }

    /// <summary>
    /// The Object.assign() static method copies all enumerable own properties from one or more source objects to a target object. It returns the modified target object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="target">The target object — what to apply the sources' properties to, which is returned after it is modified.</param>
    /// <param name="source">The source object(s) — objects containing the properties you want to apply.</param>
    /// <returns>The target object.</returns>
    public static Var<T> ObjectAssign<T>(this SyntaxBuilder b, Var<T> target, params IVariable[] source)
    {
        return b.CallOnObject<T>(b.StaticObject(), "assign", source.Prepend(target).ToArray());
    }

    /// <summary>
    /// The Object.keys() static method returns an array of a given object's own enumerable string-keyed property names.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="obj">An object.</param>
    /// <returns>An array of strings representing the given object's own enumerable string-keyed property keys.</returns>
    public static Var<List<string>> ObjectKeys(this SyntaxBuilder b, IVariable obj)
    {
        return b.CallOnObject<List<string>>(b.StaticObject(), "keys", obj);
    }

    /// <summary>
    /// The Object.values() static method returns an array of a given object's own enumerable string-keyed property values.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="obj">An object.</param>
    /// <returns>An array containing the given object's own enumerable string-keyed property values.</returns>
    public static Var<List<object>> ObjectValues(this SyntaxBuilder b, IVariable obj)
    {
        return b.CallOnObject<List<object>>(b.StaticObject(), "values", obj);
    }
}