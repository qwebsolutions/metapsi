﻿using Metapsi.Dom;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{

    public class PropsBuilder : SyntaxBuilder
    {
        public PropsBuilder(SyntaxBuilder b) : base(b) { }
    }

    public class PropsBuilder<TProps> : SyntaxBuilder
        where TProps : new()
    {
        public Var<TProps> Props { get; private set; }
        public PropsBuilder(SyntaxBuilder b) : base(b)
        {
            this.Props = b.NewObj<TProps>();
        }

        public PropsBuilder(SyntaxBuilder b, Var<TProps> props) : base(b)
        {
            this.Props = props;
        }
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

        public static void AddStyle(this PropsBuilder b, Var<DynamicObject> props, string property, Var<string> value)
        {
            var styleProperty = new DynamicProperty<object>("style");

            var currentStyle = b.GetDynamic(props, styleProperty);
            b.If(
                b.Not(b.HasObject(currentStyle)),
                b =>
                {
                    b.SetDynamic(props, styleProperty, b.NewObj<object>());
                });

            currentStyle = b.GetDynamic(props, styleProperty);
            b.SetDynamic(currentStyle, new DynamicProperty<string>(property), value);
        }

        public static void AddStyle(this PropsBuilder b, Var<DynamicObject> props, string property, string value)
        {
            b.AddStyle(props, property, b.Const(value));
        }

        public static void AddClass(this PropsBuilder b, Var<DynamicObject> props, string @class)
        {
            b.AddClass(props, b.Const(@class));
        }

        public static void OnInputAction<TState>(this PropsBuilder b, Var<DynamicObject> props, Var<HyperType.Action<TState, string>> onInput)
        {
            var extractInputValue = b.MakeAction<TState, DomEvent<InputTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<InputTarget>> @event) =>
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
            var onKeyEvent = b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.If(
                    b.Get(@event, b.Const(keyName), (@event, @keyName) => @event.key == keyName),
                    b => onKey,
                    b => b.MakeAction((SyntaxBuilder b, Var<TState> state) => state));
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static void OnKeyDownAction<TState>(this PropsBuilder b, Var<DynamicObject> props, Var<HyperType.Action<TState, string>> onKey)
        {
            var onKeyEvent = b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.MakeActionDescriptor(onKey, b.Get(@event, x => x.key));
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static Var<HyperType.Action<T>> NoAction<T>(this SyntaxBuilder b)
        {
            return b.MakeAction((SyntaxBuilder b, Var<T> state) => state);
        }

        public static Var<HyperType.Action<TState, TPayload>> NoAction<TState, TPayload>(this SyntaxBuilder b)
        {
            return b.MakeAction((SyntaxBuilder b, Var<TState> state, Var<TPayload> payload) => state);
        }

        public static void OnClickAction<TState, TPayload>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            Var<HyperType.Action<TState, TPayload>> onClick)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                var target = b.Get(@event, x => x.target);
                var value = b.GetDynamic(target, new DynamicProperty<TPayload>("value"));
                return b.MakeActionDescriptor<TState, TPayload>(onClick, value);
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void OnClickAction<TState>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            Var<HyperType.Action<TState>> onClick)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return onClick;
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void OnClickAction<TState>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            System.Func<SyntaxBuilder, Var<TState>, Var<TState>> onClick)
        {
            b.OnClickAction(props, b.MakeAction(onClick));
        }

        public static void OnClickAction<TState, TControl>(
            this PropsBuilder<TControl> b,
            Var<HyperType.Action<TState>> onClick)
            where TControl : new()
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                //b.StopPropagation(@event);
                return onClick;
            });

            b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        //public static void OnClickAction<TState, TControl>(
        //    this PropsBuilder<TControl> b,
        //    Var<HyperType.StateWithEffects> onClick)
        //    where TControl : new()
        //{
        //    var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
        //    {
        //        //b.StopPropagation(@event);
        //        return onClick;
        //    });

        //    b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        //}

        //public static void OnClickAction<TState>(
        //    this PropsBuilder b,
        //    Var<DynamicObject> props,
        //    System.Func<SyntaxBuilder, Var<TState>, Var<HyperType.StateWithEffects>> onClick)
        //{
        //    b.OnClickAction(props, b.MakeAction(onClick));
        //}

        public static void OnClickAction<TState, TControl>(
            this PropsBuilder<TControl> b,
            Func<SyntaxBuilder, Var<TState>, Var<TState>> onClick)
            where TControl : new()
        {
            b.OnClickAction(b.MakeAction(onClick));
        }


        public static void SetOnBlur<TState>(
            this PropsBuilder b,
            Var<DynamicObject> props,
            Var<HyperType.Action<TState>> onBlur)
        {
            var blurEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((SyntaxBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.StopPropagation(@event);
                return onBlur;
            });

            b.SetDynamic(props, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onblur"), blurEvent);
        }
    }
}
