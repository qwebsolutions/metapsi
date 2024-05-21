using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

public class Promise
{

}

public static class PromiseExtensions
{
    public static Var<Promise> NewPromise(this SyntaxBuilder b, Var<System.Action<System.Action<object>, System.Action<object>>> callback)
    {
        StaticFiles.Add(typeof(PromiseExtensions).Assembly, "Metapsi.Html.js");
        return b.CallExternal<Promise>("Metapsi.Html", "NewPromise", callback);
    }

    public static Var<object> Promise(this SyntaxBuilder b)
    {
        StaticFiles.Add(typeof(PromiseExtensions).Assembly, "Metapsi.Html.js");
        return b.CallExternal<object>("Metapsi.Html", "GetStaticPromise");
    }

    public static Var<Promise> Then(this SyntaxBuilder b, Var<Promise> promise, Var<System.Action<object>> onSuccess, Var<System.Action<object>> onFailure)
    {
        return b.CallOnObject<Promise>(promise, "then", onSuccess, onFailure);
    }

    public static Var<Promise> Then(this SyntaxBuilder b, Var<Promise> promise, Var<System.Func<object, Promise>> onSuccess, Var<System.Action<object>> onFailure)
    {
        return b.CallOnObject<Promise>(promise, "then", onSuccess, onFailure);
    }

    public static Var<Promise> Then<T>(this SyntaxBuilder b, Var<Promise> promise, Var<System.Action<T>> onSuccess)
    {
        return b.CallOnObject<Promise>(promise, "then", onSuccess);
    }

    public static Var<Promise> Then(this SyntaxBuilder b, Var<Promise> promise, Var<System.Func<object, Promise>> onSuccess)
    {
        return b.CallOnObject<Promise>(promise, "then", onSuccess);
    }

    public static Var<Promise> Catch(this SyntaxBuilder b, Var<Promise> promise, Var<System.Action<ClientSideException>> onFailure)
    {
        return b.CallOnObject<Promise>(promise, "catch", onFailure);
    }

    public static Var<Promise> PromiseAll(this SyntaxBuilder b, Var<List<Promise>> promises)
    {
        return b.CallOnObject<Promise>(b.Promise(), "all", promises);
    }
}
