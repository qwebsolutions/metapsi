using Metapsi.Syntax;
using System;
using System.Drawing;
using System.Xml.Linq;

namespace Metapsi.Html;

/// <summary>
/// The Event interface represents an event which takes place on an EventTarget.
/// </summary>
public interface Event
{
    /// <summary>
    /// The bubbles read-only property of the Event interface indicates whether the event bubbles up through the DOM tree or not.
    /// </summary>
    public bool bubbles { get; set; }

    /// <summary>
    /// The cancelable read-only property of the Event interface indicates whether the event can be canceled, and therefore prevented as if the event never happened.
    /// </summary>
    public bool cancelable { get; set; }

    /// <summary>
    /// The read-only composed property of the Event interface returns a boolean value which indicates whether or not the event will propagate across the shadow DOM boundary into the standard DOM
    /// </summary>
    public bool composed { get; set; }

    /// <summary>
    /// The currentTarget read-only property of the Event interface identifies the element to which the event handler has been attached.
    /// </summary>
    public EventTarget currentTarget { get; set; }

    /// <summary>
    /// The defaultPrevented read-only property of the Event interface returns a boolean value indicating whether or not the call to Event.preventDefault() canceled the event.
    /// </summary>
    public bool defaultPrevented { get; set; }

    /// <summary>
    /// The read-only target property of the Event interface is a reference to the object onto which the event was dispatched. It is different from Event.currentTarget when the event handler is called during the bubbling or capturing phase of the event.
    /// </summary>
    public EventTarget target { get; set; }

    /// <summary>
    /// The type read-only property of the Event interface returns a string containing the event's type. It is set when the event is constructed and is the name commonly used to refer to the specific event, such as click, load, or error.
    /// </summary>
    public string type { get; set; }
}

/// <summary>
/// Event options
/// </summary>
public interface EventOptions
{
    /// <summary>
    /// A boolean value indicating whether the event bubbles. The default is false.
    /// </summary>
    public bool bubbles { get; set; }

    /// <summary>
    /// A boolean value indicating whether the event can be cancelled. The default is false.
    /// </summary>
    public bool cancelable { get; set; }

    /// <summary>
    /// A boolean value indicating whether the event will trigger listeners outside of a shadow root. The default is false.
    /// </summary>
    public bool composed { get; set; }
}

public static partial class EventExtensions
{
    /// <summary>
    /// Creates new event
    /// </summary>
    /// <param name="b"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Var<Event> NewEvent(this SyntaxBuilder b, Var<string> type)
    {
        return b.New<Event>(type);
    }

    /// <summary>
    /// Creates new event
    /// </summary>
    /// <param name="b"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static Var<Event> NewEvent(this SyntaxBuilder b, string type)
    {
        return b.NewEvent(b.Const(type));
    }

    /// <summary>
    /// Creates new event
    /// </summary>
    /// <param name="b"></param>
    /// <param name="type"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Event> NewEvent(this SyntaxBuilder b, Var<string> type, Action<PropsBuilder<EventOptions>> setOptions)
    {
        return b.New<Event>(type, b.SetProps(b.NewObj<object>(), setOptions));
    }

    /// <summary>
    /// Creates new event
    /// </summary>
    /// <param name="b"></param>
    /// <param name="type"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Event> NewEvent(this SyntaxBuilder b, string type, Action<PropsBuilder<EventOptions>> setOptions)
    {
        return b.NewEvent(b.Const(type), setOptions);
    }

    /// <summary>
    /// The preventDefault() method of the Event interface tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    public static void PreventDefault<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        b.CallOnObject(e, "preventDefault");
    }

    /// <summary>
    /// The stopImmediatePropagation() method of the Event interface prevents other listeners of the same event from being called.
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    public static void StopImmediatePropagation<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        b.CallOnObject(e, "stopImmediatePropagation");
    }

    /// <summary>
    /// The stopPropagation() method of the Event interface prevents further propagation of the current event in the capturing and bubbling phases. 
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    public static void StopPropagation<TEvent>(this SyntaxBuilder b, Var<TEvent> e)
        where TEvent : Event
    {
        b.CallOnObject(e, "stopPropagation");
    }
}
