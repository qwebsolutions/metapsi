using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public static class Event
{
    public static void SetOnSlChange<TState>(
       this BlockBuilder b,
       Var<HyperNode> control,
       Var<HyperType.Action<TState, string>> onChange)
    {
        var onChangeEvent = b.MakeAction<TState, DomEvent<Hyperapp.Controls.ClickTarget>, string>(
            (BlockBuilder b, Var<TState> state, Var<DomEvent<Hyperapp.Controls.ClickTarget>> @event) =>
            {
                b.CallExternal(nameof(Native), "stopPropagation", @event);
                b.Comment("SetOnSlChange");
                b.Log(@event);
                return b.MakeActionDescriptor<TState, string>(
                    onChange,
                    b.Get(
                        b.Get(@event, x => x.target).As<DynamicObject>(),
                        new DynamicProperty<string>("value")));
            });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<Hyperapp.Controls.ClickTarget>>>("onsl-change"), onChangeEvent);
    }

    public static void SetOnSlChange<TState>(
       this BlockBuilder b,
       Var<HyperNode> control,
       Var<HyperType.Action<TState, bool>> onChange)
    {
        var onChangeEvent = b.MakeAction<TState, DomEvent<Hyperapp.Controls.ClickTarget>, bool>(
            (BlockBuilder b, Var<TState> state, Var<DomEvent<Hyperapp.Controls.ClickTarget>> @event) =>
            {
                b.CallExternal(nameof(Native), "stopPropagation", @event);
                b.Comment("SetOnSlChange");
                b.Log(@event);
                return b.MakeActionDescriptor<TState, bool>(
                    onChange,
                    b.Get(
                        b.Get(@event, x => x.target).As<DynamicObject>(),
                        new DynamicProperty<bool>("checked")));
            });

        b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<Hyperapp.Controls.ClickTarget>>>("onsl-change"), onChangeEvent);
    }
}
