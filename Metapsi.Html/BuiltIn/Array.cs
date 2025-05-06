using Metapsi.Syntax;
using System;
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
        return b.CallOnObject<List<T>>(b.GetProperty<object>(b.Self(), "Array"), "from", arrayLike);
    }

    public static Var<List<T>> ArrayFilter<T>(this SyntaxBuilder b, Var<List<T>> collection, Var<Func<T, int, List<T>, bool>> filter)
    {
        return b.CallOnObject<List<T>>(collection, "filter", filter);
    }

    public static Var<List<T>> ArrayFilter<T>(this SyntaxBuilder b, Var<List<T>> collection, Func<SyntaxBuilder, Var<T>, Var<int>, Var<List<T>>, Var<bool>> filter)
    {
        return b.CallOnObject<List<T>>(collection, "filter", b.Def(filter));
    }
}