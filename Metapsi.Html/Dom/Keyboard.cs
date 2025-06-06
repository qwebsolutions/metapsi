using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public static partial class EventExtensions
{
    //public static void OnInputAction<TState, TControl>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, string>> onInput)
    //    where TControl : IHasInputTextEvent
    //{
    //    b.OnEventAction("input", onInput, b.Def((SyntaxBuilder b, Var<DomEvent> input) => b.NavigateProperties<DomEvent, string>(input, "target", "value")));
    //}

    public static void OnKeyDown<TState, TControl>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, KeyboardEvent>> onKeyDown)
    {
        b.OnEventAction("keydown", onKeyDown);
    }

    public static void OnKeyDown<TState, TControl>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState, string>> onKeyDown)
    {
        b.OnKeyDown(b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
        {
            return b.MakeActionDescriptor(onKeyDown, b.Get(@event, x => x.key));
        }));
    }

    public static void OnKeyDown<TState, TControl>(this PropsBuilder<TControl> b, Var<string> key, Var<HyperType.Action<TState>> onKeyDown)
    {
        b.OnKeyDown(b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
        {
            return b.If(
                b.AreEqual(b.Get(@event, x => x.key), key),
                b => onKeyDown,
                b => b.MakeAction((SyntaxBuilder b, Var<TState> state) => state));
        }));
    }

    public static void OnKeyDown<TState, TControl>(this PropsBuilder<TControl> b, string key, Var<HyperType.Action<TState>> onKeyDown)
    {
        b.OnKeyDown(b.Const(key), onKeyDown);
    }

    public static void OnEnterKey<TState, TControl>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState>> onKeyDown)
    {
        b.OnKeyDown("Enter", onKeyDown);
    }

    public static void OnEscapeKey<TState, TControl>(this PropsBuilder<TControl> b, Var<HyperType.Action<TState>> onKeyDown)
    {
        b.SetAttribute("tabindex", 1);// Otherwise keywboard events are not triggered
        b.OnKeyDown("Escape", onKeyDown);
    }
}
