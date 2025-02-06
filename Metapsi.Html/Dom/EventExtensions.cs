using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

public static partial class EventExtensions
{
    public static Var<TOut> NavigateProperties<TIn, TOut>(this SyntaxBuilder b, Var<TIn> input, Var<List<string>> nestedProperties)
    {
        var outRef = b.Ref(input.As<object>());
        b.Foreach(nestedProperties, (b, currentProperty) =>
        {
            var nextValue = b.GetProperty<object>(b.GetRef(outRef), currentProperty);
            b.SetRef(outRef, nextValue);
        });

        return b.GetRef(outRef).As<TOut>();
    }

    public static Var<TOut> NavigateProperties<TIn, TOut>(this SyntaxBuilder b, Var<TIn> input, params string[] properties)
    {
        return b.NavigateProperties<TIn, TOut>(input, b.Const(new List<string>(properties)));
    }

    public static void OnEventAction<TControl, TState, TDetail>(
        this PropsBuilder<TControl> b,
        string eventName,
        Var<HyperType.Action<TState, TDetail>> action,
        Var<Func<Event, TDetail>> getDetail)
    {
        if (!eventName.StartsWith("on"))
            eventName = "on" + eventName;

        b.SetDynamic(
            b.Props,
            new DynamicProperty<HyperType.Action<TState, Event>>(eventName),
            b.Call(OnDetailAction, action, getDetail));
    }

    public static void OnEventAction<TControl, TState>(
        this PropsBuilder<TControl> b,
        string eventName,
        Var<HyperType.Action<TState>> action)
    {
        if (!eventName.StartsWith("on"))
            eventName = "on" + eventName;

        b.SetDynamic(
            b.Props,
            new DynamicProperty<HyperType.Action<TState>>(eventName),
            action);
    }

    public static void OnEventAction<TControl, TState, TDetail>(
        this PropsBuilder<TControl> b,
        string eventName,
        Var<HyperType.Action<TState, TDetail>> action,
        params string[] payloadPath)
    {
        var getDetail = b.Def((SyntaxBuilder b, Var<Event> @event) => b.NavigateProperties<Event, TDetail>(@event, payloadPath));
        b.OnEventAction(eventName, action, getDetail);
    }

    private static Var<HyperType.Action<TState, Event>> OnDetailAction<TState, TDetail>(
        this SyntaxBuilder b,
        Var<HyperType.Action<TState, TDetail>> action,
        Var<Func<Event, TDetail>> getDetail)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<Event> @event) =>
        {
            //b.StopPropagation(@event);
            var detail = b.Call(getDetail, @event);
            return b.MakeActionDescriptor(action, detail);
        });
    }
}
