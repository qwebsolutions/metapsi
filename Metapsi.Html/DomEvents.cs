using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

public interface IEvent
{
    public string type { get; set; }
}

public class Event : IEvent
{
    public string type { get; set; }

    public Event()
    {
        this.type = this.GetType().Name;
    }
}

public class CustomEvent<TDetail> : IEvent
{
    public string type { get; set; }
    public TDetail detail { get; set; }
}

public class EventOptions
{
    public bool bubbles { get; set; }
    public bool cancelable { get; set; }
    public bool composed { get; set; }
}

public class CustomEventOptions<T> : EventOptions
{
    public T detail { get; set; }
}

public static partial class EventExtensions
{
    public static void AddEventListener(this SyntaxBuilder b, IVariable element, Var<string> eventName, Var<Action> handler)
    {
        b.CallOnObject(element, "addEventListener", eventName, handler);
    }

    public static void AddEventListener<TPayload>(this SyntaxBuilder b, IVariable element, Var<string> eventName, Var<Action<CustomEvent<TPayload>>> handler)
    {
        b.CallOnObject(element, "addEventListener", eventName, handler);
    }

    public static void AddEventListener<TEvent>(this SyntaxBuilder b, IVariable element, Var<string> eventName, Var<Action<TEvent>> handler)
    {
        b.CallOnObject(element, "addEventListener", eventName, handler);
    }

    public static void RemoveEventListener(this SyntaxBuilder b, IVariable domElement, Var<string> eventName, Var<Action> handler)
    {
        b.CallOnObject(domElement, "removeEventListener", eventName, handler);
    }

    public static void RemoveEventListener<TPayload>(this SyntaxBuilder b, IVariable element, Var<string> eventName, Var<Action<CustomEvent<TPayload>>> handler)
    {
        b.CallOnObject(element, "removeEventListener", eventName, handler);
    }

    public static void RemoveEventListener<TEvent>(this SyntaxBuilder b, IVariable element, Var<string> eventName, Var<Action<TEvent>> handler)
    {
        b.CallOnObject(element, "removeEventListener", eventName, handler);
    }

    public static Var<CustomEvent<T>> CreateCustomEvent<T>(this SyntaxBuilder b, Var<string> eventName, Action<PropsBuilder<CustomEventOptions<T>>> setOptions)
    {
        var customEventOptions = b.SetProps(b.NewObj<DynamicObject>(), setOptions);
        var constructor = b.GetProperty<object>(b.Self(), "CustomEvent");
        return b.New<CustomEvent<T>>(constructor, eventName, customEventOptions);
    }

    public static Var<CustomEvent<T>> CreateCustomEvent<T>(this SyntaxBuilder b, Var<string> eventName, Var<T> detail)
    {
        var customEventOptions = b.SetProps<CustomEventOptions<T>>(b.NewObj<DynamicObject>(), b => b.Set(x => x.detail, detail));
        var constructor = b.GetProperty<object>(b.Self(), "CustomEvent");
        return b.New<CustomEvent<T>>(constructor, eventName, customEventOptions);
    }

    public static Var<Event> CreateEvent(this SyntaxBuilder b, Var<string> eventName, Action<PropsBuilder<EventOptions>> setOptions = null)
    {
        var constructor = b.GetProperty<object>(b.Self(), "Event");
        if (setOptions != null)
        {
            var eventOptions = b.SetProps(b.NewObj<DynamicObject>(), setOptions);
            return b.New<Event>(constructor, eventName, eventOptions);
        }
        else
        {
            return b.New<Event>(constructor, eventName);
        }
    }

    public static void DispatchEvent<T>(this SyntaxBuilder b, Var<T> e)
        where T : IEvent
    {
        b.CallOnObject(b.Self(), "dispatchEvent", e);
    }

    public static void DispatchEvent(this SyntaxBuilder b, Var<string> eventName)
    {
        var e = b.CreateEvent(eventName);
        b.DispatchEvent(e);
    }

    public static void DispatchCustomEvent<T>(this SyntaxBuilder b, Var<string> eventName, Action<PropsBuilder<CustomEventOptions<T>>> setProps)
    {
        var customEvent = b.CreateCustomEvent(eventName, setProps);
        b.DispatchEvent(customEvent);
    }

    public static void DispatchCustomEvent<T>(this SyntaxBuilder b, Var<string> eventName, Var<T> detail)
    {
        b.DispatchCustomEvent<T>(
            eventName,
            b =>
            {
                b.Set(x => x.detail, detail);
            });
    }

    public static void DispatchCustomEvent<T>(this SyntaxBuilder b, Var<string> eventName, Action<PropsBuilder<T>> buildDetail)
        where T : new()
    {
        var detail = b.NewObj<T>(buildDetail);
        b.DispatchCustomEvent<T>(
            eventName,
            b =>
            {
                b.Set(x => x.detail, detail);
            });
    }

    public static void DispatchCustomEvent<T>(this SyntaxBuilder b, Action<PropsBuilder<T>> buildDetail)
        where T : new()
    {
        var eventType = typeof(T).Name;
        b.DispatchCustomEvent<T>(b.Const(eventType), buildDetail);
    }

    public static void DispatchCustomEvent<T>(this SyntaxBuilder b, Var<T> detail)
    {
        var eventType = typeof(T).Name;
        b.DispatchCustomEvent(b.Const(eventType), detail);
    }
}
