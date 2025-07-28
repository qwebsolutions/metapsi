using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using Metapsi.Html;
using static Metapsi.Hyperapp.HyperType;
using static Metapsi.Html.ServiceWorkerRegistrationShowNotificationOptions;
using System.Drawing;

namespace Metapsi.Hyperapp
{
    /// <summary>
    /// Hyperapp specific types
    /// </summary>
    public static class HyperType
    {
        /// <summary>
        /// Initializes the app by either setting the initial value of the state or taking an action. It takes place before the first view render and subscriptions registration.
        /// </summary>
        /// <remarks>This is a marker class to represent the init operation. Create with MakeInit()</remarks>
        public class Init { }

        /// <summary>
        /// Marker class for subscription function
        /// </summary>
        public class Subscription { } // [Subscriber, Payload?]

        //Actions are functions that, given a state & optional payload, returns a different state or another action
        // Action : (State, Payload?) -> NextState
        //                               | [NextState, ...Effects]
        //                               | OtherAction
        //                               | [OtherAction, Payload?]

        /// <summary>
        /// An action is a message used within your app that signals the valid way to change state.
        /// <para>An action is implemented by a deterministic function that produces no side-effects which describes a transition between the current state and the next state and in so doing may optionally list out effects to be run as well.</para>
        /// <para>Actions are dispatched by either DOM events in your app, effecters, or subscribers. When dispatched, actions always implicitly receive the current state as their first argument.</para>
        /// <para>Signature:</para>
        /// <para>Action : (State, Payload?) -> NextState | [NextState, ...Effects] | OtherAction | [OtherAction, Payload?]</para>
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        public class Action<TState> { }

        /// <summary>
        /// An action is a message used within your app that signals the valid way to change state.
        /// <para>An action is implemented by a deterministic function that produces no side-effects which describes a transition between the current state and the next state and in so doing may optionally list out effects to be run as well.</para>
        /// <para>Actions are dispatched by either DOM events in your app, effecters, or subscribers. When dispatched, actions always implicitly receive the current state as their first argument.</para>
        /// <para>Signature:</para>
        /// <para>Action : (State, Payload?) -> NextState | [NextState, ...Effects] | OtherAction | [OtherAction, Payload?]</para>
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        public class Action<TState, TPayload> { }

        /// <summary>
        /// An effect is a representation used by actions to interact with some external process.
        /// </summary>
        public class Effect { }

        /// <summary>
        /// The dispatch function controls Hyperapp's core dispatching process which executes actions, applies state transitions, runs effects, and starts/stops subscriptions that need it.
        /// </summary>
        public class Dispatcher { }

        /// <summary>
        /// Hyperapp app setup
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        public class App<TState>
        {
            /// <summary>
            /// Initializes the app by either setting the initial value of the state or taking an action. It takes place before the first view render and subscriptions registration.
            /// </summary>
            public Init init { get; set; }

            /// <summary>
            /// The top-level view that represents the app as a whole. There can only be one top-level view in your app. Hyperapp uses this to map your state to your UI for rendering the app. Every time the state of the application changes, this function will be called to render the UI based on the new state, using the logic you've defined inside of it.
            /// </summary>
            public Func<TState, IVNode> view { get; set; }

            /// <summary>
            /// The DOM element to render the virtual DOM over (the mount node). The given element is replaced by a Hyperapp application. This process is called mounting. It's common to define an intentionally empty element in your HTML which has an ID that your app can use for mounting. If the mount node had content within it then Hyperapp will attempt to recycle that content.
            /// </summary>
            public Element node { get; set; }
            /// <summary>
            /// A function that returns an array of subscriptions for a given state. Every time the state of the application changes, this function will be called to determine the current subscriptions.
            /// If a subscription entry is falsy then the subscription that was at that spot, if any, will be considered unsubscribed from and will be cleaned up.
            /// If subscriptions is omitted the app has no subscriptions.
            /// </summary>
            public Func<TState, List<Subscription>> subscriptions { get; set; }
            /// <summary>
            /// A dispatch initializer that can create a custom dispatch function to use instead of the default dispatch. Allows tapping into dispatches for debugging, testing, telemetry etc.
            /// </summary>
            public Func<Dispatcher, Dispatcher> dispatch { get; set; }
        }

        /// <summary>
        /// Sets the initial state directly.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static Var<Init> MakeInit<TState>(this SyntaxBuilder b, Var<TState> state)
        {
            return state.As<Init>();
        }

        /// <summary>
        /// Converts a StateWithEffects to init
        /// </summary>
        /// <param name="b"></param>
        /// <param name="stateWithEffects"></param>
        /// <returns></returns>
        public static Var<Init> MakeInit(this SyntaxBuilder b, Var<StateWithEffects> stateWithEffects)
        {
            return stateWithEffects.As<Init>();
        }

        /// <summary>
        /// Runs the given Action.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Var<Init> MakeInit<TState>(this SyntaxBuilder b, Var<HyperType.Action<TState>> action)
        {
            return action.As<Init>();
        }

        /// <summary>
        /// Runs the given Action with a payload.
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Var<Init> MakeInit<TState, TPayload>(this SyntaxBuilder b, Var<HyperType.Action<TState, TPayload>> action)
        {
            return action.As<Init>();
        }

        /// <summary>
        /// Converts a subscriber function to a subscription with the specified properties
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TSubProps"></typeparam>
        /// <param name="b"></param>
        /// <param name="subscriberFn"></param>
        /// <param name="subProps"></param>
        /// <returns></returns>
        public static Var<HyperType.Subscription> MakeSubscription<TState, TSubProps>(
            this SyntaxBuilder b,
            Var<System.Func<HyperType.Dispatcher, TSubProps, System.Action>> subscriberFn,
            Var<TSubProps> subProps)
        {
            Var<List<object>> subscription = b.NewCollection<object>();
            b.Push(subscription, subscriberFn.As<object>());
            b.Push(subscription, subProps.As<object>());
            return subscription.As<HyperType.Subscription>();
        }

        /// <summary>
        /// Converts a subscriber function to a subscription with the specified properties
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TSubProps"></typeparam>
        /// <param name="b"></param>
        /// <param name="subscriberFn"></param>
        /// <param name="subProps"></param>
        /// <returns></returns>
        public static Var<HyperType.Subscription> MakeSubscription<TState, TSubProps>(
            this SyntaxBuilder b,
            Func<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TSubProps>, Var<System.Action>> subscriberFn,
            Var<TSubProps> subProps)
        {
            return b.MakeSubscription<TState, TSubProps>(b.Def(subscriberFn), subProps);
        }

        /// <summary>
        /// Return NoSubscription to unsubscribe
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Var<HyperType.Subscription> NoSubscription(this SyntaxBuilder b)
        {
            return b.Const(false).As<HyperType.Subscription>();
        }



        /// <summary>
        /// App state with a collection of effects to be executed
        /// </summary>
        public class StateWithEffects { }

        /// <summary>
        /// Make state with effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(
            this SyntaxBuilder b,
            Var<TState> state)
        {
            return b.MakeStateWithEffects(state, new Var<Effect>[0]);
        }

        /// <summary>
        /// Make state with effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="state"></param>
        /// <param name="effects"></param>
        /// <returns></returns>
        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(
            this SyntaxBuilder b,
            Var<TState> state,
            params System.Action<SyntaxBuilder>[] effects)
        {
            return b.MakeStateWithEffects(state, effects.Select(b.MakeEffect).ToArray());
        }

        /// <summary>
        /// Make state with effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="state"></param>
        /// <param name="effects"></param>
        /// <returns></returns>
        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(
            this SyntaxBuilder b,
            Var<TState> state,
            params System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>>[] effects)
        {
            return b.MakeStateWithEffects(state, effects.Select(b.MakeEffect).ToArray());
        }

        /// <summary>
        /// Make state with effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="state"></param>
        /// <param name="effects"></param>
        /// <returns></returns>
        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(this SyntaxBuilder b, Var<TState> state, Var<List<HyperType.Effect>> effects)
        {
            var output = b.NewCollection<object>();
            b.Push(output, state.As<object>());
            b.PushRange(output, effects.As<List<object>>());
            return output.As<HyperType.StateWithEffects>();
        }

        /// <summary>
        /// Make state with effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="state"></param>
        /// <param name="effects"></param>
        /// <returns></returns>
        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(this SyntaxBuilder b, Var<TState> state, params Var<Effect>[] effects)
        {
            return b.MakeStateWithEffects(state, b.List(effects));
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState>> MakeAction<TState>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TState>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState, TPayload>> MakeAction<TState, TPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TPayload>, Var<TState>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TPayload>>();
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState>> MakeAction<TState>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<StateWithEffects>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState, TPayload>> MakeAction<TState, TPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TPayload>, Var<StateWithEffects>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TPayload>>();
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState>> MakeAction<TState>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<HyperType.Action<TState>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TInPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState, TInPayload>> MakeAction<TState, TInPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TInPayload>, Var<HyperType.Action<TState>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TInPayload>>();
        }

        /// <summary>
        /// Make action
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TInPayload"></typeparam>
        /// <typeparam name="TOutPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState, TInPayload>> MakeAction<TState, TInPayload, TOutPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TInPayload>, Var<HyperType.Action<TState, TOutPayload>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TInPayload>>();
        }

        /// <summary>
        /// Use action with payload
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="action"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState>> MakeActionDescriptor<TState, TPayload>(this SyntaxBuilder b, Var<HyperType.Action<TState, TPayload>> action, Var<TPayload> payload)
        {
            var output = b.NewCollection<object>();
            b.Push(output, action.As<object>());
            b.Push(output, payload.As<object>());
            return output.As<HyperType.Action<TState>>();
        }

        /// <summary>
        /// Use action with payload
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="action"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public static Var<HyperType.Action<TState>> MakeActionDescriptor<TState, TPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TPayload>, Var<TState>> action, Var<TPayload> payload)
        {
            var output = b.NewCollection<object>();
            b.Push(output, b.MakeAction(action).As<object>());
            b.Push(output, payload.As<object>());
            return output.As<HyperType.Action<TState>>();
        }

        /// <summary>
        /// Effect using function with no dispatch
        /// </summary>
        /// <param name="b"></param>
        /// <param name="effecterAction"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> MakeEffect(
            this SyntaxBuilder b, Var<System.Action> effecterAction)
        {
            return effecterAction.As<HyperType.Effect>();
        }

        /// <summary>
        /// Effect using function with no dispatch
        /// </summary>
        /// <param name="b"></param>
        /// <param name="effecterAction"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> MakeEffect(
            this SyntaxBuilder b, System.Action<SyntaxBuilder> effecterAction)
        {
            return b.MakeEffect(b.Def(effecterAction));
        }

        /// <summary>
        /// Effect using function with dispatch
        /// </summary>
        /// <param name="b"></param>
        /// <param name="effecterAction"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> MakeEffect(
            this SyntaxBuilder b, Var<System.Action<HyperType.Dispatcher>> effecterAction)
        {
            return effecterAction.As<HyperType.Effect>();
        }

        /// <summary>
        /// Effect using function with dispatch
        /// </summary>
        /// <param name="b"></param>
        /// <param name="effecterAction"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> MakeEffect(
            this SyntaxBuilder b, System.Action<SyntaxBuilder, Var<Dispatcher>> effecterAction)
        {
            return b.MakeEffect(b.Def(effecterAction));
        }

        /// <summary>
        /// Effect using function with dispatch and props
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TEffecterProps"></typeparam>
        /// <param name="b"></param>
        /// <param name="effecterFn"></param>
        /// <param name="effecterProps"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> MakeEffect<TEffecterProps>(
            this SyntaxBuilder b, Var<System.Action<HyperType.Dispatcher, TEffecterProps>> effecterFn, Var<TEffecterProps> effecterProps)
        {
            Var<List<object>> effectList = b.NewCollection<object>();
            b.Push(effectList, effecterFn.As<object>());
            b.Push(effectList, effecterProps.As<object>());
            return effectList.As<HyperType.Effect>();
        }

        /// <summary>
        /// Effect using function with dispatch and props
        /// </summary>
        /// <typeparam name="TEffecterProps"></typeparam>
        /// <param name="b"></param>
        /// <param name="effecterFn"></param>
        /// <param name="effecterProps"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> MakeEffect<TEffecterProps>(
            this SyntaxBuilder b, System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>, Var<TEffecterProps>> effecterFn, Var<TEffecterProps> effecterProps)
        {
            return b.MakeEffect(b.Def(effecterFn), effecterProps);
        }
        
        /// <summary>
        /// Dispatch the speficied <paramref name="action"/>
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="dispatcher"></param>
        /// <param name="action"></param>
        public static void Dispatch<TState>(this SyntaxBuilder b, Var<Dispatcher> dispatcher, Var<HyperType.Action<TState>> action)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState>>>();
            b.Call(callable, action);
        }

        /// <summary>
        /// Dispatch <paramref name="action"/> with <paramref name="payload"/>
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="dispatcher"></param>
        /// <param name="action"></param>
        /// <param name="payload"></param>
        public static void Dispatch<TState, TPayload>(this SyntaxBuilder b, Var<Dispatcher> dispatcher, Var<HyperType.Action<TState, TPayload>> action, Var<TPayload> payload)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState, TPayload>, TPayload>>();
            b.Call(callable, action, payload);
        }

        /// <summary>
        /// Dispatch state with effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="dispatcher"></param>
        /// <param name="action"></param>
        public static void Dispatch<TState>(this SyntaxBuilder b, Var<Dispatcher> dispatcher, Var<HyperType.StateWithEffects> action)
        {
            b.Dispatch(dispatcher, action.As<HyperType.Action<TState>>());
        }
    }
}
