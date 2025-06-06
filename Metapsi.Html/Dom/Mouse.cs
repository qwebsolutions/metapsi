using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public static partial class EventExtensionsClick
{
    // Click with no payload

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        Var<HyperType.Action<TState>> onClick)
    {
        b.OnEventAction("click", onClick);
    }

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        System.Func<SyntaxBuilder, Var<TState>, Var<TState>> onClick)
    {
        b.OnClickAction(b.MakeAction(onClick));
    }

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        System.Func<SyntaxBuilder, Var<TState>, Var<HyperType.StateWithEffects>> onClick)
    {
        b.OnClickAction(b.MakeAction(onClick));
    }

    // Click with event

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        Var<HyperType.Action<TState, PointerEvent>> onClick)
    {
        b.OnClickAction(onClick);
    }

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        System.Func<SyntaxBuilder, Var<TState>, Var<PointerEvent>, Var<TState>> onClick)
    {
        b.OnClickAction(b.MakeAction(onClick));
    }

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        Var<HyperType.Action<TState, Html.Event>> onClick)
    {
        b.OnClickAction(onClick);
    }

    public static void OnClickAction<TState, TControl>(
        this PropsBuilder<TControl> b,
        System.Func<SyntaxBuilder, Var<TState>, Var<Html.Event>, Var<TState>> onClick)
    {
        b.OnClickAction(b.MakeAction(onClick));
    }

    // Click with data payload


    //public static void OnClickAction<TState, TControl>(
    //    this PropsBuilder<TControl> b,
    //    Var<HyperType.Action<TState, DomEvent>> onClick)
    //    where TControl : new()
    //{
    //    b.OnEventAction("click", onClick);
    //}

    //public static void OnClickAction<TState, TPayload>(
    //    this PropsBuilder b,
    //    Var<object> props,
    //    Var<HyperType.Action<TState, TPayload>> onClick)
    //{
    //    var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
    //    {
    //        b.StopPropagation(@event);
    //        var target = b.Get(@event, x => x.target);
    //        var value = b.GetDynamic(target, new DynamicProperty<TPayload>("value"));
    //        return b.MakeActionDescriptor<TState, TPayload>(onClick, value);
    //    });

    //    b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
    //}

    //public static void OnClickAction<TState>(
    //    this PropsBuilder b,
    //    Var<object> props,
    //    Var<HyperType.Action<TState>> onClick)
    //{
    //    var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
    //    {
    //        b.StopPropagation(@event);
    //        return onClick;
    //    });

    //    b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
    //}

    //public static void OnClickAction<TState>(
    //    this PropsBuilder b,
    //    Var<object> props,
    //    System.Func<SyntaxBuilder, Var<TState>, Var<TState>> onClick)
    //{
    //    b.OnClickAction(props, b.MakeAction(onClick));
    //}

    //public static void OnClickAction<TState, TControl>(
    //    this PropsBuilder<TControl> b,
    //    Var<HyperType.Action<TState>> onClick)
    //    where TControl : new()
    //{
    //    var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
    //    {
    //        //b.StopPropagation(@event);
    //        return onClick;
    //    });

    //    b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
    //}

}
