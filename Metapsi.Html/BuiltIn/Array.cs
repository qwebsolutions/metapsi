using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static class ArrayExtensions
{
    /// <summary>
    /// The Array.from() static method creates a new, shallow-copied Array instance from an iterable or array-like object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="arrayLike"></param>
    /// <returns></returns>
    public static Var<List<T>> ArrayFrom<T>(this SyntaxBuilder b, IVariable arrayLike)
    {
        return b.CallOnObject<List<T>>(b.GetProperty<DynamicObject>(b.Self(), "Array"), "from", arrayLike);
    }
}