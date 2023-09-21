using Metapsi.Syntax;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Hyperapp
{
    public class ClickTarget
    {
    }

    public class DomEvent<TTarget>
    {
        public TTarget target { get; set; }
    }

    public class InputTarget
    {
        public string value { get; set; }
    }

    public class KeyboardEvent
    {
        public string key { get; set; }
    }

    public class CustomEvent<TDetail>
    {
        public TDetail detail { get; set; }
    }

    public static class EventExtensions
    {
        public static void SetOnInput<TState>(this BlockBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState, string>> onInput)
        {
            var extractInputValue = b.MakeAction<TState, DomEvent<InputTarget>, string>((BlockBuilder b, Var<TState> state, Var<DomEvent<InputTarget>> @event) =>
            {
                var target = b.Get(@event, x => x.target);
                var value = b.Get(target, x => x.value);
                return b.MakeActionDescriptor<TState, string>(onInput, value);
            });

            b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<InputTarget>>>("oninput"), extractInputValue);
        }

        public static void SetOnEnter<TState>(this BlockBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState>> onEnter)
        {
            b.SetOnKey(control, "Enter", onEnter);
        }

        public static void SetOnEscape<TState>(this BlockBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState>> onEscape)
        {
            b.SetAttr(control, Html.tabindex, 1);// Otherwise keywboard events are not triggered
            b.SetOnKey(control, "Escape", onEscape);
        }

        public static void SetOnKey<TState>(this BlockBuilder b, Var<HyperNode> control, string keyName, Var<HyperType.Action<TState>> onKey)
        {
            var onKeyEvent = b.MakeAction((BlockBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.If(
                    b.Get(@event, b.Const(keyName), (@event, @keyName) => @event.key == keyName),
                    b => onKey,
                    b => b.MakeAction((BlockBuilder b, Var<TState> state) => state));
            });

            b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static void SetOnKeyDown<TState>(this BlockBuilder b, Var<HyperNode> control, Var<HyperType.Action<TState, string>> onKey)
        {
            var onKeyEvent = b.MakeAction((BlockBuilder b, Var<TState> state, Var<KeyboardEvent> @event) =>
            {
                return b.MakeActionDescriptor(onKey, b.Get(@event, x => x.key));
            });

            b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, KeyboardEvent>>("onkeydown"), onKeyEvent);
        }

        public static Var<HyperType.Action<T>> NoAction<T>(this BlockBuilder b)
        {
            return b.MakeAction((BlockBuilder b, Var<T> state) => state);
        }

        public static Var<HyperType.Action<TState, TPayload>> NoAction<TState, TPayload>(this BlockBuilder b)
        {
            return b.MakeAction((BlockBuilder b, Var<TState> state, Var<TPayload> payload) => state);
        }



        public static void SetOnClick<TState, TPayload>(
            this BlockBuilder b,
            Var<HyperNode> control,
            Var<HyperType.Action<TState, TPayload>> onClick,
            Var<TPayload> payload)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>, TPayload>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.CallExternal(nameof(Core), "stopPropagation", @event);
                return b.MakeActionDescriptor<TState, TPayload>(onClick, payload);
            });

            b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void SetOnClick<TState>(
            this BlockBuilder b,
            Var<HyperNode> control,
            Var<HyperType.Action<TState>> onClick)
        {
            var clickEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.CallExternal(nameof(Core), "stopPropagation", @event);
                return onClick;
            });

            b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onclick"), clickEvent);
        }

        public static void SetOnBlur<TState>(
            this BlockBuilder b,
            Var<HyperNode> control,
            Var<HyperType.Action<TState>> onBlur)
        {
            var blurEvent = b.MakeAction<TState, DomEvent<ClickTarget>>((BlockBuilder b, Var<TState> state, Var<DomEvent<ClickTarget>> @event) =>
            {
                b.CallExternal(nameof(Core), "stopPropagation", @event);
                return onBlur;
            });

            b.SetAttr(control, new DynamicProperty<HyperType.Action<TState, DomEvent<ClickTarget>>>("onblur"), blurEvent);
        }

        public class EventSubscriptionProps<TState, TPayload>
        {
            public string EventType { get; set; }
            public HyperType.Action<TState, TPayload> Action { get; set; }
            public CustomEvent<TPayload> Event { get; set; }
        }

        public static Var<HyperType.Cleanup> ListenToEvent<TState, TPayload>(BlockBuilder b, Var<HyperType.Dispatcher<TState, TPayload>> dispatch, Var<EventSubscriptionProps<TState, TPayload>> props)
        {
            var listener = b.Def((BlockBuilder b, Var<CustomEvent<TPayload>> @event) =>
            {
                b.CallExternal(nameof(Core), "RequestAnimationFrame", b.Def((BlockBuilder b) =>
                {
                    b.Dispatch(dispatch, b.Get(props, x => x.Action), b.Get(@event, x => x.detail));
                }));
            });

            b.CallExternal(nameof(Core), "AddEventListener", b.Get(props, x => x.EventType), listener);

            return b.Def((BlockBuilder b) => b.CallExternal(nameof(Core), "RemoveEventListener", b.Get(props, x => x.EventType), listener)).As<HyperType.Cleanup>();
        }

        public static Var<HyperType.Subscription> Listen<TState, TPayload>(this BlockBuilder b, Var<string> eventType, Var<HyperType.Action<TState, TPayload>> action)
        {
            var subscriber = b.MakeSubscriber<TState, TPayload, EventSubscriptionProps<TState, TPayload>>(ListenToEvent);
            Var<EventSubscriptionProps<TState, TPayload>> subscriptionProps = b.NewObj<EventSubscriptionProps<TState, TPayload>>();
            b.Set(subscriptionProps, x => x.EventType, eventType);
            b.Set(subscriptionProps, x => x.Action, action);
            return b.MakeSubscription<EventSubscriptionProps<TState, TPayload>>(subscriber, subscriptionProps);
        }

        public static Var<HyperType.Subscription> Unsubscribe(this BlockBuilder b)
        {
            return b.Const(false).As<HyperType.Subscription>();
        }

        public class IntervalProps<TState>
        {
            public HyperType.Action<TState> OnIntervalAction { get; set; }
            public int IntervalMilliseconds { get; set; }
        }

        public static Var<HyperType.Cleanup> Interval<TState>(BlockBuilder b, Var<HyperType.Dispatcher<TState>> dispatch, Var<IntervalProps<TState>> props)
        {
            var id = b.CallExternal<int>(
                nameof(Core),
                "SetInterval",
                b.Def((BlockBuilder b) =>
                {
                    b.Dispatch(dispatch, b.Get(props, x => x.OnIntervalAction));
                }),
                b.Get(props, x => x.IntervalMilliseconds));

            return b.Def((BlockBuilder b) => b.CallExternal(nameof(Core), "ClearInterval", id)).As<HyperType.Cleanup>();
        }

        public static Var<HyperType.Subscription> Every<TState>(this BlockBuilder b, Var<int> intervalMilliseconds, Var<HyperType.Action<TState>> action)
        {
            var subscriber = b.MakeSubscriber<TState, IntervalProps<TState>>(Interval);
            Var<IntervalProps<TState>> intervalProps = b.NewObj<IntervalProps<TState>>();
            b.Set(intervalProps, x => x.IntervalMilliseconds, intervalMilliseconds);
            b.Set(intervalProps, x => x.OnIntervalAction, action);
            return b.MakeSubscription<IntervalProps<TState>>(subscriber, intervalProps);
        }
    }
}
