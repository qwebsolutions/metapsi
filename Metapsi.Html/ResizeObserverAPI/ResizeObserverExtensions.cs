using Metapsi.Syntax;
using System.Collections.Generic;


namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static class ResizeObserverExtensions
{
    /// <summary>
    /// ResizeObserver class reference
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<ResizeObserver>> ResizeObserver(this SyntaxBuilder b)
    {
        return b.GetProperty<ClassDef<ResizeObserver>>(b.Window(), "ResizeObserver");
    }

    /// <summary>
    /// The ResizeObserver constructor creates a new ResizeObserver object, which can be used to report changes to the content or border box of an Element or the bounding box of an SVGElement.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">The function called whenever an observed resize occurs. The function is called with two parameters:
    /// <para> entries - An array of ResizeObserverEntry objects that can be used to access the new dimensions of the element after each change. </para>
    /// <para>observer - A reference to the ResizeObserver itself, so it will definitely be accessible from inside the callback, should you need it.This could be used for example to automatically unobserve the observer when a certain condition is reached, but you can omit it if you don't need it.</para>
    /// </param>
    /// <returns></returns>
    public static ObjBuilder<ResizeObserver> New(
        this ObjBuilder<ClassDef<ResizeObserver>> b,
        Var<System.Action<List<ResizeObserverEntry>>> callback)
    {
        return b.New<ResizeObserver>(callback);
    }

    /// <summary>
    /// The ResizeObserver constructor creates a new ResizeObserver object, which can be used to report changes to the content or border box of an Element or the bounding box of an SVGElement.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">The function called whenever an observed resize occurs. The function is called with two parameters:
    /// <para> entries - An array of ResizeObserverEntry objects that can be used to access the new dimensions of the element after each change. </para>
    /// <para>observer - A reference to the ResizeObserver itself, so it will definitely be accessible from inside the callback, should you need it.This could be used for example to automatically unobserve the observer when a certain condition is reached, but you can omit it if you don't need it.</para>
    /// </param>
    /// <returns></returns>
    public static ObjBuilder<ResizeObserver> New(
        this ObjBuilder<ClassDef<ResizeObserver>> b,
        Var<System.Action<List<ResizeObserverEntry>, ResizeObserver>> callback)
    {
        return b.New<ResizeObserver>(callback);
    }

    /// <summary>
    /// The disconnect() method of the ResizeObserver interface unobserves all observed Element or SVGElement targets.
    /// </summary>
    /// <param name="b"></param>
    public static void disconnect(this ObjBuilder<ResizeObserver> b)
    {
        b.Call(nameof(disconnect));
    }

    /// <summary>
    /// The observe() method of the ResizeObserver interface starts observing the specified Element or SVGElement.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="target">A reference to an Element or SVGElement to be observed.</param>
    public static void observe(this ObjBuilder<ResizeObserver> b, Var<Element> target)
    {
        b.Call(nameof(observe), target);
    }

    /// <summary>
    /// The observe() method of the ResizeObserver interface starts observing the specified Element or SVGElement.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="target">A reference to an Element or SVGElement to be observed.</param>
    /// <param name="options">(optional) An options object allowing you to set options for the observation.</param>
    public static void observe(this ObjBuilder<ResizeObserver> b, Var<Element> target, Var<ResizeObserverOptions> options)
    {
        b.Call(nameof(observe), target, options);
    }

    /// <summary>
    /// The unobserve() method of the ResizeObserver interface ends the observing of a specified Element or SVGElement.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="target">A reference to an Element or SVGElement to be unobserved.</param>
    public static void unobserve(this ObjBuilder<ResizeObserver> b, Var<Element> target)
    {
        b.Call(nameof(unobserve), target);
    }
}