using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The AbortController interface represents a controller object that allows you to abort one or more Web requests as and when desired.
/// </summary>
public interface AbortController
{
    /// <summary>
    /// The signal read-only property of the AbortController interface returns an AbortSignal object instance, which can be used to communicate with/abort an asynchronous operation as desired.
    /// </summary>
    AbortSignal signal { get; }
}

/// <summary>
/// 
/// </summary>
public static partial class AbortControllerExtensions
{
    /// <summary>
    /// AbortController class reference
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<AbortController>> AbortController(this SyntaxBuilder b)
    {
        return b.GetProperty<ClassDef<AbortController>>(b.Window(), "AbortController");
    }

    /// <summary>
    /// The AbortController() constructor creates a new AbortController object instance.
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ObjBuilder<AbortController> New(
        this ObjBuilder<ClassDef<AbortController>> b)
    {
        return b.New<AbortController>();
    }

    /// <summary>
    /// The abort() method of the AbortController interface aborts an asynchronous operation before it has completed. This is able to abort fetch requests, the consumption of any response bodies, or streams.
    /// </summary>
    /// <param name="b"></param>
    public static void abort(this ObjBuilder<AbortController> b)
    {
        b.Call(nameof(abort));
    }

    /// <summary>
    /// The abort() method of the AbortController interface aborts an asynchronous operation before it has completed. This is able to abort fetch requests, the consumption of any response bodies, or streams.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="reason">The reason why the operation was aborted, which can be any JavaScript value. If not specified, the reason is set to "AbortError" DOMException.</param>
    public static void abort(this ObjBuilder<AbortController> b, IVariable reason)
    {
        b.Call(nameof(abort), reason);
    }
}

