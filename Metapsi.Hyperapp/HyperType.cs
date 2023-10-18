using Metapsi.Dom;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using static Metapsi.Hyperapp.HyperType;

namespace Metapsi.Hyperapp
{

    public static class HyperType
    {
        public class App<TState>
        {
            public Init init { get; set; }
            public Func<TState, HyperNode> view { get; set; }
            public DomElement node { get; set; }
            public Func<TState, List<Subscription>> subscriptions { get; set; }
        }

        public class Init { }
        
        public class Subscription { } // [Subscriber, Payload?]
        
        // (DispatchFn, Payload?) -> CleanupFn
        public class Subscriber { } 
        public class Subscriber<TPayload> { } 
        
        public class Cleanup { }

        public static Var<Init> MakeInit<TState>(this BlockBuilder b, Var<TState> state)
        {
            return state.As<Init>();
        }

        public static Var<Init> MakeInit(this BlockBuilder b, Var<StateWithEffects> stateWithEffects)
        {
            return stateWithEffects.As<Init>();
        }

        public static Var<Init> MakeInit<TState>(this BlockBuilder b, Var<HyperType.Action<TState>> action)
        {
            return action.As<Init>();
        }

        public static Var<Init> MakeInit<TState, TPayload>(this BlockBuilder b, Var<HyperType.ActionDescriptor<TState, TPayload>> actionDescriptor)
        {
            return actionDescriptor.As<Init>();
        }

        public static Var<HyperType.Subscriber<TProps>> MakeSubscriber<TState, TProps>(this BlockBuilder b, System.Func<BlockBuilder, Var<Dispatcher<TState>>, Var<TProps>, Var<Cleanup>> subscriber)
        {
            var subscriberFunc = b.Def(subscriber);
            return subscriberFunc.As<HyperType.Subscriber<TProps>>();
        }

        public static Var<HyperType.Subscriber<TProps>> MakeSubscriber<TState, TPayload, TProps>(this BlockBuilder b, System.Func<BlockBuilder, Var<Dispatcher<TState, TPayload>>, Var<TProps>, Var<Cleanup>> subscriber)
        {
            var subscriberFunc = b.Def(subscriber);
            return subscriberFunc.As<HyperType.Subscriber<TProps>>();
        }

        public static Var<HyperType.Subscription> MakeSubscription(this BlockBuilder b, Var<Subscriber> subscriber)
        {
            Var<List<object>> subscription = b.NewCollection<object>();
            b.Push(subscription, subscriber.As<object>());
            return subscription.As<HyperType.Subscription>();
        }

        public static Var<HyperType.Subscription> MakeSubscription<TPayload>(this BlockBuilder b, Var<Subscriber<TPayload>> subscriber, Var<TPayload> payload)
        {
            Var<List<object>> subscription = b.NewCollection<object>();
            b.Push(subscription, subscriber.As<object>());
            b.Push(subscription, payload.As<object>());
            return subscription.As<HyperType.Subscription>();
        }

        public static void AddSubscription<TState>(this BlockBuilder b, string subscriptionName, Func<BlockBuilder, Var<TState>, Var<HyperType.Subscription>> buildSubscription)
        {
            var subscriptionBuilder = b.ModuleBuilder.Define(subscriptionName, buildSubscription);
        }

        //Actions are functions that, given a state & optional payload, returns a different state or another action
        // Action : (State, Payload?) -> NextState
        //                               | [NextState, ...Effects]
        //                               | OtherAction
        //                               | [OtherAction, Payload?]
        public class Action<TState> { }
        public class Action<TState, TPayload> { }

        // State & effects allow async execution.
        // The state is temporary, effects execute async code
        public class StateWithEffects { }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(this BlockBuilder b, Var<TState> state, params Var<Effect>[] effects)
        {
            var output = b.NewCollection<object>();
            b.Push(output, state.As<object>());
            foreach (Var<Effect> effect in effects)
            {
                b.Push(output, effect.As<object>());
            }

            return output.As<HyperType.StateWithEffects>();
        }

        /// <summary>
        /// Returns temporary state & converts all System.Actions into effects
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="initialState"></param>
        /// <param name="effects"></param>
        /// <returns></returns>
        public static Var<HyperType.StateWithEffects> AsyncResult<TState>(this BlockBuilder b, Var<TState> initialState, params System.Action<BlockBuilder, Var<Dispatcher<TState>>>[] effects)
        {
            return b.MakeStateWithEffects(initialState, effects.Select(x => b.RunAsync(x)).ToArray());
        }

        public static Var<HyperType.StateWithEffects> AsyncResult<TState, TPayload>(this BlockBuilder b, Var<TState> initialState, System.Action<BlockBuilder, Var<Dispatcher<TState, TPayload>>, Var<TPayload>> effecter, Var<TPayload> payload)
        {
            return b.MakeStateWithEffects(initialState, b.RunAsync(effecter, payload));
        }

        public static Var<HyperType.Action<TState>> MakeAction<TState>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<TState>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        public static Var<HyperType.Action<TState, TPayload>> MakeAction<TState, TPayload>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<TPayload>, Var<TState>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TPayload>>();
        }

        public static Var<HyperType.Action<TState>> MakeAction<TState>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<StateWithEffects>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        public static Var<HyperType.Action<TState, TPayload>> MakeAction<TState, TPayload>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<TPayload>, Var<StateWithEffects>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TPayload>>();
        }

        public static Var<HyperType.Action<TState>> MakeAction<TState>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<HyperType.Action<TState>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState>>();
        }

        public static Var<HyperType.Action<TState, TInPayload>> MakeAction<TState, TInPayload>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<TInPayload>, Var<HyperType.Action<TState>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TInPayload>>();
        }

        public static Var<HyperType.Action<TState, TInPayload>> MakeAction<TState, TInPayload, TOutPayload>(this BlockBuilder b, Func<BlockBuilder, Var<TState>, Var<TInPayload>, Var<HyperType.ActionDescriptor<TState, TOutPayload>>> func)
        {
            var actionFunc = b.Def(func);
            return actionFunc.As<HyperType.Action<TState, TInPayload>>();
        }

        public class ActionDescriptor<TState> { }
        public class ActionDescriptor<TState, TPayload> { }

        public static Var<ActionDescriptor<TState>> MakeActionDescriptor<TState>(this BlockBuilder b, Var<HyperType.Action<TState>> action)
        {
            return action.As<ActionDescriptor<TState>>();
        }

        public static Var<ActionDescriptor<TState, TPayload>> MakeActionDescriptor<TState, TPayload>(this BlockBuilder b, Var<HyperType.Action<TState, TPayload>> action, Var<TPayload> payload)
        {
            var output = b.NewCollection<object>();
            b.Push(output, action.As<object>());
            b.Push(output, payload.As<object>());
            return output.As<ActionDescriptor<TState, TPayload>>();
        }

        // Effecter is the function that executes async code & dispatches the result
        public class Effecter { }
        public class Effecter<TPayload> { }

        public static Var<HyperType.Effecter> MakeEffecter<TState>(this BlockBuilder b, System.Action<BlockBuilder, Var<Dispatcher<TState>>> effecter)
        {
            var effecterFunc = b.Def(effecter);
            return effecterFunc.As<HyperType.Effecter>();
        }

        public static Var<HyperType.Effecter<TPayload>> MakeEffecter<TState, TPayload>(this BlockBuilder b, System.Action<BlockBuilder, Var<Dispatcher<TState, TPayload>>, Var<TPayload>> effecter)
        {
            var effecterFunc = b.Def(effecter);
            return effecterFunc.As<HyperType.Effecter<TPayload>>();
        }

        // Effects are the effecter function itself OR effecter function + payload
        public class Effect { }

        public static Var<HyperType.Effect> MakeEffect(this BlockBuilder b, Var<Effecter> effecter)
        {
            return effecter.As<HyperType.Effect>();
        }

        public static Var<HyperType.Effect> MakeEffect<TPayload>(this BlockBuilder b, Var<Effecter<TPayload>> effecter, Var<TPayload> payload)
        {
            Var<List<object>> effectList = b.NewCollection<object>();
            b.Push(effectList, effecter.As<object>());
            b.Push(effectList, payload.As<object>());
            return effectList.As<HyperType.Effect>();
        }

        /// <summary>
        /// Transforms System.Action directly into effect
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="b"></param>
        /// <param name="effecter"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> RunAsync<TState>(this BlockBuilder b, System.Action<BlockBuilder, Var<Dispatcher<TState>>> effecter)
        {
            return b.MakeEffect(b.MakeEffecter(effecter));
        }

        /// <summary>
        /// Transforms System.Action directly into effect with payload
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <typeparam name="TPayload"></typeparam>
        /// <param name="b"></param>
        /// <param name="effecter"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public static Var<HyperType.Effect> RunAsync<TState, TPayload>(this BlockBuilder b, System.Action<BlockBuilder, Var<Dispatcher<TState, TPayload>>, Var<TPayload>> effecter, Var<TPayload> payload)
        {
            return b.MakeEffect(b.MakeEffecter(effecter), payload);
        }

        public static Var<StateWithEffects> RunAsync(this BlockBuilder b, Var<StateWithEffects> stateWithEffects, Var<Effect> effect)
        {
            Var<List<object>> stateWithEffectsAsTupleList = stateWithEffects.As<List<object>>();
            b.Push(stateWithEffectsAsTupleList, effect.As<object>());
            return stateWithEffectsAsTupleList.As<StateWithEffects>();
        }

        public class Dispatcher<TState> { }
        public class Dispatcher<TState,TPayload> { }

        public static void Dispatch<TState>(this BlockBuilder b, Var<Dispatcher<TState>> dispatcher, Var<HyperType.Action<TState>> action)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState>>>();
            b.Call(callable, action);
        }

        public static void Dispatch<TState>(this BlockBuilder b, Var<Dispatcher<TState>> dispatcher, Func<BlockBuilder, Var<TState>, Var<TState>> action)
        {
            b.Dispatch(dispatcher, b.MakeAction(action));
        }

        public static void Dispatch<TState, TPayload>(
            this BlockBuilder b, 
            Var<Dispatcher<TState, TPayload>> dispatcher, 
            Var<HyperType.Action<TState, TPayload>> action, 
            Var<TPayload> payload)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState, TPayload>, TPayload>>();
            b.Call(callable, action, payload);
        }

        public static void Dispatch<TState,TPayload>(
            this BlockBuilder b,
            Var<Dispatcher<TState, TPayload>> dispatcher,
            Func<BlockBuilder, Var<TState>, Var<TPayload>, Var<TState>> action,
            Var<TPayload> payload)
        {
            b.Dispatch(dispatcher, b.MakeAction(action), payload);
        }
    }
}
