using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static class MutationObserverExtensions
{
    /// <summary>
    /// Mutation observer class reference
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<MutationObserver>> MutationObserver(this SyntaxBuilder b)
    {
        return b.GetProperty<ClassDef<MutationObserver>>(b.Window(), nameof(MutationObserver));
    }

    /// <summary>
    /// The DOM MutationObserver() constructor — part of the MutationObserver interface — creates and returns a new observer which invokes a specified callback when DOM events occur.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">A function which will be called on each DOM change that qualifies given the observed node or subtree and options.
    /// The callback function takes as input two parameters:
    /// <para>An array of MutationRecord objects, describing each change that occurred.</para>
    /// <para>The MutationObserver which invoked the callback.This is most often used to disconnect the observer using MutationObserver.disconnect().</para>
    /// </param>
    /// <returns>A new MutationObserver object, configured to call the specified callback when DOM mutations occur.</returns>
    public static ObjBuilder<MutationObserver> New(
        this ObjBuilder<ClassDef<MutationObserver>> b,
        Var<System.Action<List<MutationRecord>, MutationObserver>> callback)
    {
        return b.New<MutationObserver>(callback);
    }

    /// <summary>
    /// The DOM MutationObserver() constructor — part of the MutationObserver interface — creates and returns a new observer which invokes a specified callback when DOM events occur.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="callback">A function which will be called on each DOM change that qualifies given the observed node or subtree and options.
    /// The callback function takes as input two parameters:
    /// <para>An array of MutationRecord objects, describing each change that occurred.</para>
    /// <para>The MutationObserver which invoked the callback.This is most often used to disconnect the observer using MutationObserver.disconnect().</para>
    /// </param>
    /// <returns>A new MutationObserver object, configured to call the specified callback when DOM mutations occur.</returns>
    public static ObjBuilder<MutationObserver> New(
        this ObjBuilder<ClassDef<MutationObserver>> b,
        Var<System.Action<List<MutationRecord>>> callback)
    {
        return b.New<MutationObserver>(callback);
    }

    /// <summary>
    /// The MutationObserver method disconnect() tells the observer to stop watching for mutations.
    /// The observer can be reused by calling its observe() method again.
    /// </summary>
    /// <param name="b"></param>
    public static void disconnect(this ObjBuilder<MutationObserver> b)
    {
        b.Call(nameof(disconnect));
    }

    /// <summary>
    /// The MutationObserver method observe() configures the MutationObserver callback to begin receiving notifications of changes to the DOM that match the given options.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="target">A DOM Node (which may be an Element) within the DOM tree to watch for changes, or to be the root of a subtree of nodes to be watched.</param>
    /// <param name="options">An object providing options that describe which DOM mutations should be reported to mutationObserver's callback. At a minimum, one of childList, attributes, and/or characterData must be true when you call observe(). Otherwise, a TypeError exception will be thrown.</param>
    public static void observe<T>(this ObjBuilder<MutationObserver> b, Var<T> target, Var<MutationObserver.ObserveOptions> options)
        where T: Node
    {
        b.Call(nameof(observe), target, options);
    }

    /// <summary>
    /// The MutationObserver method observe() configures the MutationObserver callback to begin receiving notifications of changes to the DOM that match the given options.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="target">A DOM Node (which may be an Element) within the DOM tree to watch for changes, or to be the root of a subtree of nodes to be watched.</param>
    /// <param name="options">An object providing options that describe which DOM mutations should be reported to mutationObserver's callback. At a minimum, one of childList, attributes, and/or characterData must be true when you call observe(). Otherwise, a TypeError exception will be thrown.</param>
    public static void observe<T>(this ObjBuilder<MutationObserver> b, Var<T> target, MutationObserver.ObserveOptions options)
        where T : Node
    {
        b.observe(target, b.Const(options));
    }

    /// <summary>
    /// The MutationObserver method takeRecords() returns a list of all matching DOM changes that have been detected but not yet processed by the observer's callback function, leaving the mutation queue empty.
    /// The most common use case for this is to immediately fetch all pending mutation records immediately prior to disconnecting the observer, so that any pending mutations can be processed when shutting down the observer.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>An array of MutationRecord objects, each describing one change applied to the observed portion of the document's DOM tree.</returns>
    public static ObjBuilder<List<MutationRecord>> takeRecords(this ObjBuilder<MutationObserver> b)
    {
        return b.Call<List<MutationRecord>>(nameof(takeRecords));
    }
}

//public interface MutationRecord
//{

//}