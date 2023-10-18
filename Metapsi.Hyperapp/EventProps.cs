using Metapsi.Dom;
using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class EventProps
    {
        public static void SetProp<T>(this PropsBuilder b, DynamicProperty<T> prop, Var<T> value)
        {
            b.SetDynamic(b.Props, prop, value);
        }

        public static void SetProp<T>(this PropsBuilder b, DynamicProperty<T> prop, T value)
        {
            b.SetDynamic(b.Props, prop, b.Const(value));
        }

        public static void OnInputAction<TState>(this PropsBuilder b, Var<HyperType.Action<TState, string>> onInput)
        {
            var extractInputValue = b.MakeAction<TState, DomEvent<InputTarget>, string>((BlockBuilder b, Var<TState> state, Var<DomEvent<InputTarget>> @event) =>
            {
                var target = b.Get(@event, x => x.target);
                var value = b.Get(target, x => x.value);
                return b.MakeActionDescriptor<TState, string>(onInput, value);
            });

            b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TState, DomEvent<InputTarget>>>("oninput"), extractInputValue);
        }

        public static void OnEnterAction<TState>(this PropsBuilder b, Var<HyperType.Action<TState>> onEnter)
        {
            b.OnKeyAction("Enter", onEnter);
        }

        public static void OnEscapeAction<TState>(this PropsBuilder b, Var<HyperType.Action<TState>> onEscape)
        {
            b.SetProp(Html.tabindex, 1);// Otherwise keywboard events are not triggered
            b.OnKeyAction("Escape", onEscape);
        }

        public static void OnKeyAction<TState>(this PropsBuilder b, string keyName, Var<HyperType.Action<TState>> onKey)
        {
            var onKeyEvent = b.MakeAction((BlockBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.If(
                    b.Get(@event, b.Const(keyName), (@event, @keyName) => @event.key == keyName),
                    b => onKey,
                    b => b.MakeAction((BlockBuilder b, Var<TState> state) => state));
            });

            b.SetProp(new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static void OnKeyDownAction<TState>(this PropsBuilder b, Var<HyperType.Action<TState, string>> onKey)
        {
            var onKeyEvent = b.MakeAction((BlockBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.MakeActionDescriptor(onKey, b.Get(@event, x => x.key));
            });

            b.SetProp(new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static Var<HyperType.Action<T>> NoAction<T>(this BlockBuilder b)
        {
            return b.MakeAction((BlockBuilder b, Var<T> state) => state);
        }

        public static Var<HyperType.Action<TState, TPayload>> NoAction<TState, TPayload>(this BlockBuilder b)
        {
            return b.MakeAction((BlockBuilder b, Var<TState> state, Var<TPayload> payload) => state);
        }



        public static void OnClickAction<TState, TPayload>(
            this PropsBuilder b,
            Var<HyperType.Action<TState, TPayload>> onClick,
            Var<TPayload> payload)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>, TPayload>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return b.MakeActionDescriptor<TState, TPayload>(onClick, payload);
            });

            b.SetProp(new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void OnClickAction<TState>(
            this PropsBuilder b,
            Var<HyperType.Action<TState>> onClick)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return onClick;
            });

            b.SetProp(new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void OnClickAction<TState>(
            this PropsBuilder b,
            System.Func<BlockBuilder, Var<TState>, Var<TState>> onClick)
        {
            b.OnClickAction(b.MakeAction(onClick));
        }


        public static void SetOnBlur<TState>(
            this PropsBuilder b,
            Var<HyperType.Action<TState>> onBlur)
        {
            var blurEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return onBlur;
            });

            b.SetProp(new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onblur"), blurEvent);
        }
    }
}
