using Metapsi.Syntax;
using Metapsi.Html;
using System.Security.Cryptography.X509Certificates;

namespace Metapsi.Hyperapp;

public static class EventExtensions
{
    //public class EventSubscriptionProps<TState, TPayload>
    //{
    //    public string EventType { get; set; }
    //    public HyperType.Action<TState, TPayload> Action { get; set; }
    //    public CustomEvent<TPayload> Event { get; set; }
    //}

    //public class EventSubscriptionProps<TState>
    //{
    //    public string EventType { get; set; }
    //    public HyperType.Action<TState> Action { get; set; }
    //}

    /// <summary>
    /// 
    /// </summary>
    public class EventSubscriptionProps<TModel, TEventTarget, TEvent>
        where TEventTarget: EventTarget
        where TEvent : Event
    {
        /// <summary>
        /// Event target
        /// </summary>
        public TEventTarget Target { get; set; }

        /// <summary>
        /// Event type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HyperType.Action<TModel, TEvent> Action { get; set; }
    }

    public static Var<System.Action> ListenToEvent<TModel, TEventTarget, TEvent>(
        SyntaxBuilder b,
        Var<HyperType.Dispatcher> dispatch,
        Var<EventSubscriptionProps<TModel, TEventTarget, TEvent>> props)
        where TEventTarget: EventTarget
        where TEvent : Event
    {
        var listener = b.Def((SyntaxBuilder b, Var<TEvent> @event) =>
        {
            b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
            {
                b.Dispatch(dispatch, b.MakeActionDescriptor(b.Get(props, x => x.Action), @event));
            }));
        });

        b.AddEventListener(
            b.Get(props, x => x.Target),
            b.Get(props, x => x.Type),
            listener);

        // Return cleanup function
        return b.Def(
            (SyntaxBuilder b) =>
            b.RemoveEventListener(
                b.Get(props, x => x.Target),
                b.Get(props, x => x.Type), listener));
    }


    public static Var<HyperType.Subscription> Listen<TModel, TEventTarget, TEvent>(
        this SyntaxBuilder b,
        Var<TEventTarget> target,
        Var<string> eventType,
        Var<HyperType.Action<TModel, TEvent>> action)
        where TEventTarget : EventTarget
        where TEvent : Event
    {
        Var<EventSubscriptionProps<TModel, TEventTarget, TEvent>> subscriptionProps = b.NewObj<EventSubscriptionProps<TModel, TEventTarget, TEvent>>(
            b =>
            {
                b.Set(x => x.Target, target);
                b.Set(x => x.Type, eventType);
                b.Set(x => x.Action, action);
            });
        return b.MakeSubscription<TModel, EventSubscriptionProps<TModel, TEventTarget, TEvent>>(
            ListenToEvent,
            subscriptionProps);
    }

    public static Var<HyperType.Subscription> Listen<TModel, TEventTarget>(
        this SyntaxBuilder b,
        Var<EventTarget> target,
        Var<string> eventType,
        Var<HyperType.Action<TModel>> action)
        where TEventTarget : EventTarget
    {
        // Event is actually ignored, because Action does not handle it
        Var<EventSubscriptionProps<TModel, TEventTarget, Event>> subscriptionProps = b.NewObj<EventSubscriptionProps<TModel, TEventTarget, Event>>(
            b =>
            {
                b.Set(x => x.Target, target);
                b.Set(x => x.Type, eventType);
                b.Set(x => x.Action, action.As<HyperType.Action<TModel, Event>>());
            });
        return b.MakeSubscription<TModel, EventSubscriptionProps<TModel, TEventTarget, Event>>(
            ListenToEvent,
            subscriptionProps);
    }

    //public static Var<System.Action> ListenToEvent<TState, TPayload>(SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<EventSubscriptionProps<TState, TPayload>> props)
    //{
    //    var listener = b.Def((SyntaxBuilder b, Var<CustomEvent<TPayload>> @event) =>
    //    {
    //        b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
    //        {
    //            b.Dispatch(dispatch, b.MakeActionDescriptor(b.Get(props, x => x.Action), b.Get(@event, x => x.detail)));
    //        }));
    //    });

    //    b.AddEventListener(b.Window(), b.Get(props, x => x.EventType), listener);

    //    return b.Def((SyntaxBuilder b) => b.RemoveEventListener(b.Window(), b.Get(props, x => x.EventType), listener));
    //}

    //public static Var<System.Action> ListenToEvent<TState>(SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<EventSubscriptionProps<TState>> props)
    //{
    //    var listener = b.Def((SyntaxBuilder b) =>
    //    {
    //        b.RequestAnimationFrame(b.Def((SyntaxBuilder b) =>
    //        {
    //            b.Dispatch(dispatch, b.Get(props, x => x.Action));
    //        }));
    //    });

    //    b.AddEventListener(b.Window(), b.Get(props, x => x.EventType), listener);

    //    return b.Def((SyntaxBuilder b) => b.RemoveEventListener(b.Window(), b.Get(props, x => x.EventType), listener));
    //}

    //public static Var<HyperType.Subscription> Listen<TState, TPayload>(this SyntaxBuilder b, Var<string> eventType, Var<HyperType.Action<TState, TPayload>> action)
    //{
    //    Var<EventSubscriptionProps<TState, TPayload>> subscriptionProps = b.NewObj<EventSubscriptionProps<TState, TPayload>>();
    //    b.Set(subscriptionProps, x => x.EventType, eventType);
    //    b.Set(subscriptionProps, x => x.Action, action);
    //    return b.MakeSubscription<TState, EventSubscriptionProps<TState, TPayload>>(ListenToEvent<TState, TPayload>, subscriptionProps);
    //}

    //public static Var<HyperType.Subscription> Listen<TState>(this SyntaxBuilder b, Var<string> eventType, Var<HyperType.Action<TState>> action)
    //{
    //    Var<EventSubscriptionProps<TState>> subscriptionProps = b.NewObj<EventSubscriptionProps<TState>>();
    //    b.Set(subscriptionProps, x => x.EventType, eventType);
    //    b.Set(subscriptionProps, x => x.Action, action);
    //    return b.MakeSubscription<TState, EventSubscriptionProps<TState>>(ListenToEvent<TState>, subscriptionProps);
    //}

    //public static Var<HyperType.Subscription> Listen<TState, TEvent>(this SyntaxBuilder b, Var<HyperType.Action<TState, TEvent>> action)
    //{
    //    return b.Listen<TState, TEvent>(b.Const(typeof(TEvent).Name), action);
    //}
}
