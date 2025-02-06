using Metapsi.Syntax;
using System;
using System.Xml.Linq;

namespace Metapsi.Html;

/// <summary>
/// The EventTarget interface is implemented by objects that can receive events and may have listeners for them.
/// </summary>
public interface EventTarget
{

}

/// <summary>
/// An object that specifies characteristics about the event listener.
/// </summary>
public interface AddEventListenerOptions
{
    /// <summary>
    /// A boolean value indicating that events of this type will be dispatched to the registered listener before being dispatched to any EventTarget beneath it in the DOM tree. If not specified, defaults to false.
    /// </summary>
    public bool capture { get; set; }

    /// <summary>
    /// A boolean value indicating that the listener should be invoked at most once after being added. If true, the listener would be automatically removed when invoked. If not specified, defaults to false.
    /// </summary>
    public bool once { get; set; }

    /// <summary>
    /// A boolean value that, if true, indicates that the function specified by listener will never call preventDefault(). If a passive listener calls preventDefault(), nothing will happen and a console warning may be generated.
    /// </summary>
    public bool passive { get; set; }

    /// <summary>
    /// An AbortSignal. The listener will be removed when the abort() method of the AbortController which owns the AbortSignal is called. If not specified, no AbortSignal is associated with the listener.
    /// </summary>
    public AbortSignal signal { get; set; }
}
/// <summary>
/// EventTarget extensions
/// </summary>
public static class EventTargetExtensions
{
    /// <summary>
    /// The addEventListener() method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="eventName"></param>
    /// <param name="handler"></param>
    /// <param name="options"></param>
    public static void AddEventListener<TEventTarget, TEvent>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> eventName,
        Var<System.Action<TEvent>> handler,
        Var<AddEventListenerOptions> options)
        where TEventTarget : EventTarget
        where TEvent : Event
    {
        b.CallOnObject(target, "addEventListener", eventName, handler, options);
    }

    /// <summary>
    /// The addEventListener() method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="eventName"></param>
    /// <param name="handler"></param>
    /// <param name="options"></param>
    public static void AddEventListener<TEventTarget>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> eventName,
        Var<System.Action> handler,
        Var<AddEventListenerOptions> options)
        where TEventTarget : EventTarget
    {
        b.CallOnObject(target, "addEventListener", eventName, handler, options);
    }

    /// <summary>
    /// The addEventListener() method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="eventName"></param>
    /// <param name="handler"></param>
    public static void AddEventListener<TEventTarget, TEvent>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> eventName,
        Var<System.Action<TEvent>> handler)
        where TEventTarget : EventTarget
        where TEvent : Event
    {
        b.CallOnObject(target, "addEventListener", eventName, handler);
    }


    /// <summary>
    /// The addEventListener() method of the EventTarget interface sets up a function that will be called whenever the specified event is delivered to the target.
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="eventName"></param>
    /// <param name="handler"></param>
    public static void AddEventListener<TEventTarget>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> eventName,
        Var<System.Action> handler)
        where TEventTarget : EventTarget
    {
        b.CallOnObject(target, "addEventListener", eventName, handler);
    }

    /// <summary>
    /// The dispatchEvent() method of the EventTarget sends an Event to the object, (synchronously) invoking the affected event listeners in the appropriate order. 
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="e"></param>
    /// <returns>false if event is cancelable, and at least one of the event handlers which received event called Event.preventDefault(). Otherwise true.</returns>
    public static Var<bool> DispatchEvent<TEventTarget, TEvent>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<TEvent> e)
        where TEventTarget : EventTarget
        where TEvent : Event
    {
        return b.CallOnObject<bool>(target, "dispatchEvent", e);
    }

    /// <summary>
    /// Creates and dispatches an event with type <paramref name="eventType"/>
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="eventType"></param>
    /// <returns>false if event is cancelable, and at least one of the event handlers which received event called Event.preventDefault(). Otherwise true.</returns>
    public static Var<bool> DispatchEvent<TEventTarget>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> eventType)
        where TEventTarget : EventTarget
    {
        return b.DispatchEvent(target, b.NewEvent(eventType));
    }

    /// <summary>
    /// The removeEventListener() method of the EventTarget interface removes an event listener previously registered with EventTarget.addEventListener() from the target. 
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="type"></param>
    /// <param name="listener"></param>
    public static void RemoveEventListener<TEventTarget, TEvent>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> type,
        Var<Action<TEvent>> listener)
        where TEventTarget : EventTarget
        where TEvent : Event
    {
        b.CallOnObject(target, "removeEventListener", type, listener);
    }

    /// <summary>
    /// The removeEventListener() method of the EventTarget interface removes an event listener previously registered with EventTarget.addEventListener() from the target.
    /// </summary>
    /// <typeparam name="TEventTarget"></typeparam>
    /// <param name="b"></param>
    /// <param name="target"></param>
    /// <param name="type"></param>
    /// <param name="listener"></param>
    public static void RemoveEventListener<TEventTarget>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> type,
        Var<Action> listener)
        where TEventTarget : EventTarget
    {
        b.CallOnObject(target, "removeEventListener", type, listener);
    }
}