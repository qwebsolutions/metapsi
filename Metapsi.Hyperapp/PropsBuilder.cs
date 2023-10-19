using Metapsi.Dom;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public class PropsBuilder : BlockBuilder
    {
        public PropsBuilder() { }

        public PropsBuilder(ModuleBuilder moduleBuilder, Block block) : base(moduleBuilder, block)
        {
        }

        public PropsBuilder(BlockBuilder b) : this(b.ModuleBuilder, b.Block) { }
    }

    public static class PropsBuilderExtensions
    {
        public static Var<DynamicObject> EditProps(this LayoutBuilder b, Var<DynamicObject> props, Action<PropsBuilder, Var<DynamicObject>> action)
        {
            var propsBuilder = new PropsBuilder(b);
            action(propsBuilder, props);
            return props;
        }

        public static void EditProps<TData>(this ControlDefinition<TData> builder, Action<PropsBuilder, Var<TData>, Var<DynamicObject>> propsAction)
        {
            builder.PropsActions.Add(propsAction);
        }

        public static void EditProps<TData>(this ControlDefinition<TData> builder, Action<PropsBuilder, Var<DynamicObject>> propsAction)
        {
            builder.PropsActions.Add((b, data, props) => propsAction(b, props));
        }

        public static void SetClass(this PropsBuilder b, Var<DynamicObject> props, Var<string> @class)
        {
            b.SetDynamic(props, Html.@class, @class);
        }

        public static void SetClass(this PropsBuilder b, Var<DynamicObject> props, string @class)
        {
            b.SetClass(props, b.Const(@class));
        }

        public static void AddClass(this PropsBuilder b, Var<DynamicObject> props, Var<string> @class)
        {
            var currentClass = b.GetDynamic(props, Html.@class);
            b.SetDynamic(props, Html.@class, b.Concat(currentClass, b.Const(" "), @class));
        }

        public static void AddClass(this PropsBuilder b, Var<DynamicObject> props, string @class)
        {
            b.AddClass(props, b.Const(@class));
        }

        public static void OnInputAction<TState>(this PropsBuilder b, Var<DynamicObject> props, Var<HyperType.Action<TState, string>> onInput)
        {
            var extractInputValue = b.MakeAction<TState, DomEvent<InputTarget>, string>((BlockBuilder b, Var<TState> state, Var<DomEvent<InputTarget>> @event) =>
            {
                var target = b.Get(@event, x => x.target);
                var value = b.Get(target, x => x.value);
                return b.MakeActionDescriptor<TState, string>(onInput, value);
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<InputTarget>>>("oninput"), extractInputValue);
        }

        public static void OnEnterAction<TState>(this PropsBuilder b, Var<DynamicObject> props, Var<HyperType.Action<TState>> onEnter)
        {
            b.OnKeyAction(props, "Enter", onEnter);
        }

        public static void OnEscapeAction<TState>(this PropsBuilder b, Var<DynamicObject> props, Var<HyperType.Action<TState>> onEscape)
        {
            b.SetDynamic(props, Html.tabindex, b.Const(1));// Otherwise keywboard events are not triggered
            b.OnKeyAction(props, "Escape", onEscape);
        }

        public static void OnKeyAction<TState>(this PropsBuilder b, Var<DynamicObject> props, string keyName, Var<HyperType.Action<TState>> onKey)
        {
            var onKeyEvent = b.MakeAction((BlockBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.If(
                    b.Get(@event, b.Const(keyName), (@event, @keyName) => @event.key == keyName),
                    b => onKey,
                    b => b.MakeAction((BlockBuilder b, Var<TState> state) => state));
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static void OnKeyDownAction<TState>(this PropsBuilder b, Var<DynamicObject> props, Var<HyperType.Action<TState, string>> onKey)
        {
            var onKeyEvent = b.MakeAction((BlockBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.MakeActionDescriptor(onKey, b.Get(@event, x => x.key));
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
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
            Var<DynamicObject> props,
            Var<HyperType.Action<TState, TPayload>> onClick,
            Var<TPayload> payload)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>, TPayload>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return b.MakeActionDescriptor<TState, TPayload>(onClick, payload);
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void OnClickAction<TState>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            Var<HyperType.Action<TState>> onClick)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return onClick;
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void OnClickAction<TState>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            System.Func<BlockBuilder, Var<TState>, Var<TState>> onClick)
        {
            b.OnClickAction(props, b.MakeAction(onClick));
        }


        public static void SetOnBlur<TState>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            Var<HyperType.Action<TState>> onBlur)
        {
            var blurEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return onBlur;
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onblur"), blurEvent);
        }
    }
}
