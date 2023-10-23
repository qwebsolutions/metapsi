﻿using Metapsi.Dom;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public static class EventExtensions
{
    public static void SetOnSlChange<TState>(
       this LayoutBuilder b,
       Var<HyperNode> control,
       Var<HyperType.Action<TState, string>> onChange)
    {
        var onChangeEvent = b.MakeAction<TState, DomEvent<ClickTarget>, string>(
            (SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                b.Comment("SetOnSlChange");
                b.Log(@event);
                return b.MakeActionDescriptor<TState, string>(
                    onChange,
                    b.GetDynamic(
                        b.Get(@event, x => x.target).As<DynamicObject>(),
                        new DynamicProperty<string>("value")));
            });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onsl-change"), onChangeEvent);
    }

    public static void SetOnSlChange<TState>(
       this LayoutBuilder b,
       Var<HyperNode> control,
       Var<HyperType.Action<TState, bool>> onChange)
    {
        var onChangeEvent = b.MakeAction<TState, DomEvent<ClickTarget>, bool>(
            (SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                b.Comment("SetOnSlChange");
                b.Log(@event);
                return b.MakeActionDescriptor<TState, bool>(
                    onChange,
                    b.GetDynamic(
                        b.Get(@event, x => x.target).As<DynamicObject>(),
                        new DynamicProperty<bool>("checked")));
            });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onsl-change"), onChangeEvent);
    }
}
