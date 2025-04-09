using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static partial class FetchExtensions
{
    /// <summary>
    /// The fetch() method starts the process of fetching a resource from the network, returning a promise that is fulfilled once the response is available.
    /// The promise resolves to the Response object representing the response to your request.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="resource">This defines the resource that you wish to fetch.</param>
    /// <returns>A Promise that resolves to a Response object.</returns>
    public static Var<Promise> Fetch(this SyntaxBuilder b, Var<string> resource)
    {
        return b.CallOnObject<Promise>(b.Self(), "fetch", resource);
    }

    /// <summary>
    /// The fetch() method starts the process of fetching a resource from the network, returning a promise that is fulfilled once the response is available.
    /// The promise resolves to the Response object representing the response to your request.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="resource">This defines the resource that you wish to fetch.</param>
    /// <returns>A Promise that resolves to a Response object.</returns>
    public static Var<Promise> Fetch(this SyntaxBuilder b, Var<Request> resource)
    {
        return b.CallOnObject<Promise>(b.Self(), "fetch", resource);
    }

    /// <summary>
    /// The fetch() method starts the process of fetching a resource from the network, returning a promise that is fulfilled once the response is available.
    /// The promise resolves to the Response object representing the response to your request.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="resource">This defines the resource that you wish to fetch.</param>
    /// <param name="setOptions">A RequestInit builder containing any custom settings that you want to apply to the request.</param>
    /// <returns>A Promise that resolves to a Response object.</returns>
    public static Var<Promise> Fetch(this SyntaxBuilder b, Var<string> resource, Action<PropsBuilder<RequestInit>> setOptions)
    {
        return b.CallOnObject<Promise>(b.Self(), "fetch", resource, b.SetProps(b.NewObj<DynamicObject>(), setOptions));
    }

    /// <summary>
    /// The fetch() method starts the process of fetching a resource from the network, returning a promise that is fulfilled once the response is available.
    /// The promise resolves to the Response object representing the response to your request.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="resource">This defines the resource that you wish to fetch.</param>
    /// <param name="setOptions">A RequestInit builder containing any custom settings that you want to apply to the request.</param>
    /// <returns>A Promise that resolves to a Response object.</returns>
    public static Var<Promise> Fetch(this SyntaxBuilder b, Var<Request> resource, Action<PropsBuilder<RequestInit>> setOptions)
    {
        return b.CallOnObject<Promise>(b.Self(), "fetch", resource, b.SetProps(b.NewObj(), setOptions));
    }
}