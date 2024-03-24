using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

public static class HExtensions
{
    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TControl>> buildProps,
        Var<List<IVNode>> children)
        where TControl : new()
    {
        var propsBuilder = new PropsBuilder<TControl>(b);
        buildProps(propsBuilder);
        return b.H(tag, propsBuilder.Props.As<DynamicObject>(), children);
    }

    public static Var<IVNode> H<TControl>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TControl>> buildProps,
        params Var<IVNode>[] children)
        where TControl: new()
    {
        return b.H(tag, buildProps, b.List(children));
    }
}

public static class EventExtensions
{
    public static void OnEventAction<TControl, TState, TDetail>(
        this PropsBuilder<TControl> b,
        string eventName,
        Var<HyperType.Action<TState, TDetail>> action,
        params string[] payloadPath)
        where TControl : new()
    {
        if (!eventName.StartsWith("on"))
            eventName = "on" + eventName;

        b.SetDynamic(
            b.Props,
            new DynamicProperty<HyperType.Action<TState, IDomEvent>>(eventName),
            b.Call(OnDetailAction, action, b.Const(new List<string>(payloadPath))));
    }

    public static Var<HyperType.Action<TState, IDomEvent>> OnDetailAction<TState, TDetail>(
        this SyntaxBuilder b,
        Var<HyperType.Action<TState, TDetail>> action,
        Var<List<string>> properties)
    {
        return b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<IDomEvent> @event) =>
        {
            b.StopPropagation(@event);
            var detail = b.Call(NavigateProperties<IDomEvent, TDetail>, @event, properties);
            return b.MakeActionDescriptor(action, detail);
        });
    }

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
}