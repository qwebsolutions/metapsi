using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The CustomEvent interface represents events initialized by an application for any purpose.
/// </summary>
public interface CustomEvent : Event
{
    /// <summary>
    /// The read-only detail property of the CustomEvent interface returns any data passed when initializing the event.
    /// </summary>
    public object detail { get; set; }
}

/// <summary>
/// An object that, in addition of the properties defined in EventOptions, can have an event detail object
/// </summary>
public interface CustomEventOptions : EventOptions
{
    /// <summary>
    /// An event-dependent value associated with the event. This value is then available to the handler using the CustomEvent.detail property. It defaults to null.
    /// </summary>
    public object detail { get; set; }
}

/// <summary>
/// The CustomEvent interface represents events initialized by an application for any purpose.
/// </summary>
/// <typeparam name="TDetail">Event detail type</typeparam>
public interface CustomEvent<TDetail> : Event
{
    /// <summary>
    /// The read-only detail property of the CustomEvent interface returns any data passed when initializing the event.
    /// </summary>
    public TDetail detail { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class CustomEventExtensions
{
    /// <summary>
    /// Creates a new custom event
    /// </summary>
    /// <param name="b"></param>
    /// <param name="type"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<CustomEvent> NewCustomEvent(
        this SyntaxBuilder b,
        Var<string> type,
        System.Action<PropsBuilder<CustomEventOptions>> setOptions)
    {
        return b.New<CustomEvent>(type, b.SetProps(b.NewObj<object>(), setOptions));
    }

    /// <summary>
    /// Creates a new custom event of <paramref name="type"/> with <paramref name="detail"/>
    /// </summary>
    /// <typeparam name="TDetail"></typeparam>
    /// <param name="b"></param>
    /// <param name="type"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    public static Var<CustomEvent<TDetail>> NewCustomEvent<TDetail>(
        this SyntaxBuilder b,
        Var<string> type,
        Var<TDetail> detail)
    {
        return b.New<CustomEvent>(
            type,
            b.SetProps(
                b.NewObj<object>(),
                (PropsBuilder<CustomEventOptions> b) =>
                {
                    b.Set(x => x.detail, detail.As<object>());
                })).As<CustomEvent<TDetail>>();
    }

    /// <summary>
    /// Creates a new custom event with <paramref name="detail"/> and type set to detail class name
    /// </summary>
    /// <typeparam name="TDetail"></typeparam>
    /// <param name="b"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    public static Var<CustomEvent<TDetail>> NewCustomEvent<TDetail>(
        this SyntaxBuilder b,
        Var<TDetail> detail)
    {
        return b.New<CustomEvent>(
            b.Const(typeof(TDetail).Name),
            b.SetProps(
                b.NewObj<object>(),
                (PropsBuilder<CustomEventOptions> b) =>
                {
                    b.Set(x => x.detail, detail.As<object>());
                })).As<CustomEvent<TDetail>>();
    }
}