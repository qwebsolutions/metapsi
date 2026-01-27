using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// IntersectionObserverExtensions
/// </summary>
public static class IntersectionObserverExtensions
{
    /// <summary>
    /// IntersectionObserver class reference
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<IntersectionObserver>> IntersectionObserver(this SyntaxBuilder b)
    {
        b.On(
            b.IntersectionObserver(),
            b =>
            {

            });

        return b.GetProperty<ClassDef<IntersectionObserver>>(b.Window(), "IntersectionObserver");
    }

    /// <summary>
    /// The IntersectionObserver() constructor creates and returns a new IntersectionObserver object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">
    /// A function which is called when the percentage of the target element is visible crosses a threshold.The callback receives as input two parameters:
    /// <para> entries - An array of IntersectionObserverEntry objects, each representing one threshold which was crossed, either becoming more or less visible than the percentage specified by that threshold.You should not assume the number of entries, because multiple threshold-crossing events may be reported in a single callback invocation. The entries are dispatched using a queue, so they should be ordered by the time they were generated, but you should preferably use IntersectionObserverEntry.time to correctly order them.</para>
    /// <para> observer - The IntersectionObserver for which the callback is being invoked.</para>
    /// </param>
    /// <returns>A new IntersectionObserver which can be used to watch for the visibility of a target element within the specified root crossing through any of the specified visibility thresholds.
    /// Call its observe() method to begin watching for the visibility changes on a given target.
    /// </returns>
    public static Var<IntersectionObserver> New(
        this ObjBuilder<ClassDef<IntersectionObserver>> b,
        Var<Action<List<IntersectionObserverEntry>, IntersectionObserver>> callback)
    {
        return b.New(callback);
    }

    /// <summary>
    /// The IntersectionObserver() constructor creates and returns a new IntersectionObserver object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">
    /// A function which is called when the percentage of the target element is visible crosses a threshold.The callback receives as input two parameters:
    /// <para> entries - An array of IntersectionObserverEntry objects, each representing one threshold which was crossed, either becoming more or less visible than the percentage specified by that threshold.You should not assume the number of entries, because multiple threshold-crossing events may be reported in a single callback invocation. The entries are dispatched using a queue, so they should be ordered by the time they were generated, but you should preferably use IntersectionObserverEntry.time to correctly order them.</para>
    /// <para> observer - The IntersectionObserver for which the callback is being invoked.</para>
    /// </param>
    /// <returns>A new IntersectionObserver which can be used to watch for the visibility of a target element within the specified root crossing through any of the specified visibility thresholds.
    /// Call its observe() method to begin watching for the visibility changes on a given target.
    /// </returns>
    public static Var<IntersectionObserver> New(
        this ObjBuilder<ClassDef<IntersectionObserver>> b,
        Var<Action<List<IntersectionObserverEntry>>> callback)
    {
        return b.New(callback);
    }

    /// <summary>
    /// The IntersectionObserver() constructor creates and returns a new IntersectionObserver object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">
    /// A function which is called when the percentage of the target element is visible crosses a threshold.The callback receives as input two parameters:
    /// <para> entries - An array of IntersectionObserverEntry objects, each representing one threshold which was crossed, either becoming more or less visible than the percentage specified by that threshold.You should not assume the number of entries, because multiple threshold-crossing events may be reported in a single callback invocation. The entries are dispatched using a queue, so they should be ordered by the time they were generated, but you should preferably use IntersectionObserverEntry.time to correctly order them.</para>
    /// <para> observer - The IntersectionObserver for which the callback is being invoked.</para>
    /// </param>
    /// <param name="options">An optional object which customizes the observer.</param>
    /// <returns>A new IntersectionObserver which can be used to watch for the visibility of a target element within the specified root crossing through any of the specified visibility thresholds.
    /// Call its observe() method to begin watching for the visibility changes on a given target.
    /// </returns>
    public static Var<IntersectionObserver> New(
        this ObjBuilder<ClassDef<IntersectionObserver>> b,
        Var<Action<List<IntersectionObserverEntry>, IntersectionObserver>> callback,
        Var<IntersectionObserverOptions> options)
    {
        return b.New(callback);
    }

    /// <summary>
    /// The IntersectionObserver() constructor creates and returns a new IntersectionObserver object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">
    /// A function which is called when the percentage of the target element is visible crosses a threshold.The callback receives as input two parameters:
    /// <para> entries - An array of IntersectionObserverEntry objects, each representing one threshold which was crossed, either becoming more or less visible than the percentage specified by that threshold.You should not assume the number of entries, because multiple threshold-crossing events may be reported in a single callback invocation. The entries are dispatched using a queue, so they should be ordered by the time they were generated, but you should preferably use IntersectionObserverEntry.time to correctly order them.</para>
    /// <para> observer - The IntersectionObserver for which the callback is being invoked.</para>
    /// </param>
    /// <param name="options">An optional object which customizes the observer.</param>
    /// <returns>A new IntersectionObserver which can be used to watch for the visibility of a target element within the specified root crossing through any of the specified visibility thresholds.
    /// Call its observe() method to begin watching for the visibility changes on a given target.
    /// </returns>
    public static Var<IntersectionObserver> New(
        this ObjBuilder<ClassDef<IntersectionObserver>> b,
        Var<Action<List<IntersectionObserverEntry>>> callback,
        Var<IntersectionObserverOptions> options)
    {
        return b.New(callback);
    }

    /// <summary>
    /// The disconnect() method of the IntersectionObserver interface stops the observer watching all of its target elements for visibility changes.
    /// </summary>
    /// <param name="b"></param>
    public static void disconnect(this ObjBuilder<IntersectionObserver> b)
    {
        b.Call(nameof(disconnect));
    }

    /// <summary>
    /// The observe() method of the IntersectionObserver interface adds an element to the set of target elements being watched by the IntersectionObserver. One observer has one set of thresholds and one root, but can watch multiple target elements for visibility changes in keeping with those.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="targetElement">An element whose visibility within the root is to be monitored. This element must be a descendant of the root element (or contained within the current document, if the root is the document's viewport).</param>
    public static void observe(this ObjBuilder<IntersectionObserver> b, Var<Element> targetElement)
    {
        b.Call(nameof(observe), targetElement);
    }

    /// <summary>
    /// The takeRecords() method of the IntersectionObserver interface returns an array of IntersectionObserverEntry objects, one for each targeted element which has experienced an intersection change since the last time the intersections were checked, either explicitly through a call to this method or implicitly by an automatic call to the observer's callback.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>An array of IntersectionObserverEntry objects, one for each target element whose intersection with the root has changed since the last time the intersections were checked.</returns>
    /// <remarks>If you use the callback to monitor these changes, you don't need to call this method. Calling this method clears the pending intersection list, so the callback will not be run.</remarks>
    public static ObjBuilder<List<IntersectionObserverEntry>> takeRecords(this ObjBuilder<IntersectionObserver> b)
    {
        return b.Call<List<IntersectionObserverEntry>>(nameof(takeRecords));
    }

    /// <summary>
    /// The unobserve() method of the IntersectionObserver interface instructs the IntersectionObserver to stop observing the specified target element.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="target">The Element to cease observing. If the specified element isn't being observed, this method does nothing and no exception is thrown.</param>
    public static void unobserve(this ObjBuilder<IntersectionObserver> b, Var<Element> target)
    {
        b.Call(nameof(unobserve), target);
    }
}
