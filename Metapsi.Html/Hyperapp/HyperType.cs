using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using Metapsi.Html;
using static Metapsi.Hyperapp.HyperType;

namespace Metapsi.Hyperapp
{

    public static class HyperType
    {
        public class Init { }

        public class Subscription { } // [Subscriber, Payload?]

        //Actions are functions that, given a state & optional payload, returns a different state or another action
        // Action : (State, Payload?) -> NextState
        //                               | [NextState, ...Effects]
        //                               | OtherAction
        //                               | [OtherAction, Payload?]
        public class Action<TState> { }
        public class Action<TState, TPayload> { }

        // Effects are the effecter function itself OR effecter function + payload
        public class Effect { }

        public class Dispatcher { }

        public class App<TState>
        {
            public Init init { get; set; }
            public Func<TState, IVNode> view { get; set; }
            public DomElement node { get; set; }
            public Func<TState, List<Subscription>> subscriptions { get; set; }
            public Func<Dispatcher, Dispatcher> dispatch { get; set; }
        }

        public static Var<Init> MakeInit<TState>(this SyntaxBuilder b, Var<TState> state)
        {
            return state.As<Init>();
        }

        public static Var<Init> MakeInit(this SyntaxBuilder b, Var<StateWithEffects> stateWithEffects)
        {
            return stateWithEffects.As<Init>();
        }

        public static Var<Init> MakeInit<TState>(this SyntaxBuilder b, Var<HyperType.Action<TState>> action)
        {
            return action.As<Init>();
        }

        public static Var<Init> MakeInit<TState, TPayload>(this SyntaxBuilder b, Var<HyperType.Action<TState, TPayload>> action)
        {
            return action.As<Init>();
        }

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


        // State & effects allow async execution.
        // The state is temporary, effects execute async code
        public class StateWithEffects { }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(
            this SyntaxBuilder b,
            Var<TState> state)
        {
            return b.MakeStateWithEffects(state, new Var<Effect>[0]);
        }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(
            this SyntaxBuilder b,
            Var<TState> state,
            params System.Action<SyntaxBuilder>[] effects)
        {
            return b.MakeStateWithEffects(state, effects.Select(b.MakeEffect).ToArray());
        }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(
            this SyntaxBuilder b,
            Var<TState> state,
            params System.Action<SyntaxBuilder, Var<HyperType.Dispatcher>>[] effects)
        {
            return b.MakeStateWithEffects(state, effects.Select(b.MakeEffect).ToArray());
        }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(this SyntaxBuilder b, Var<TState> state, Var<List<HyperType.Effect>> effects)
        {
            var output = b.NewCollection<object>();
            b.Push(output, state.As<object>());
            b.PushRange(output, effects.As<List<object>>());
            return output.As<HyperType.StateWithEffects>();
        }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(this SyntaxBuilder b, Var<TState> state, params Var<Effect>[] effects)
        {
            return b.MakeStateWithEffects(state, b.List(effects));
        }

        public static Var<HyperType.Action<TState>> MakeAction<TState>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TState>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        public static Var<HyperType.Action<TState, TPayload>> MakeAction<TState, TPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TPayload>, Var<TState>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TPayload>>();
        }

        public static Var<HyperType.Action<TState>> MakeAction<TState>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<StateWithEffects>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        public static Var<HyperType.Action<TState, TPayload>> MakeAction<TState, TPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TPayload>, Var<StateWithEffects>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TPayload>>();
        }

        public static Var<HyperType.Action<TState>> MakeAction<TState>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<HyperType.Action<TState>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        public static Var<HyperType.Action<TState, TInPayload>> MakeAction<TState, TInPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TInPayload>, Var<HyperType.Action<TState>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TInPayload>>();
        }

        public static Var<HyperType.Action<TState, TInPayload>> MakeAction<TState, TInPayload, TOutPayload>(this SyntaxBuilder b, Func<SyntaxBuilder, Var<TState>, Var<TInPayload>, Var<HyperType.Action<TState, TOutPayload>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TInPayload>>();
        }

        // If the payload is already set, the resulting action does not take a payload again
        public static Var<HyperType.Action<TState>> MakeActionDescriptor<TState, TPayload>(this SyntaxBuilder b, Var<HyperType.Action<TState, TPayload>> action, Var<TPayload> payload)
        {
            var output = b.NewCollection<object>();
            b.Push(output, action.As<object>());
            b.Push(output, payload.As<object>());
            return output.As<HyperType.Action<TState>>();
        }

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
        
        public static void Dispatch<TState>(this SyntaxBuilder b, Var<Dispatcher> dispatcher, Var<HyperType.Action<TState>> action)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState>>>();
            b.Call(callable, action);
        }

        public static void Dispatch<TState, TPayload>(this SyntaxBuilder b, Var<Dispatcher> dispatcher, Var<HyperType.Action<TState, TPayload>> action, Var<TPayload> payload)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState, TPayload>, TPayload>>();
            b.Call(callable, action, payload);
        }
    }
}
