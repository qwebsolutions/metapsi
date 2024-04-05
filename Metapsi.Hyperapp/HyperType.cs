using Metapsi.Dom;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{

    public static class HyperType
    {
        public class App<TState>
        {
            public Init init { get; set; }
            public Func<TState, IVNode> view { get; set; }
            public DomElement node { get; set; }
            public Func<TState, List<Subscription>> subscriptions { get; set; }
        }

        public class Init { }
        
        public class Subscription { } // [Subscriber, Payload?]
        
        // (DispatchFn, Payload?) -> CleanupFn
        public class Subscriber { } 
        public class Subscriber<TPayload> { } 
        
        public class Cleanup { }

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

        public static Var<HyperType.Subscriber<TProps>> MakeSubscriber<TState, TProps>(this SyntaxBuilder b, System.Func<SyntaxBuilder, Var<Dispatcher<TState>>, Var<TProps>, Var<Cleanup>> subscriber)
        {
            var subscriberFunc = b.Def(subscriber);
            return subscriberFunc.As<HyperType.Subscriber<TProps>>();
        }

        public static Var<HyperType.Subscriber<TProps>> MakeSubscriber<TState, TPayload, TProps>(this SyntaxBuilder b, System.Func<SyntaxBuilder, Var<Dispatcher<TState>>, Var<TProps>, Var<Cleanup>> subscriber)
        {
            var subscriberFunc = b.Def(subscriber);
            return subscriberFunc.As<HyperType.Subscriber<TProps>>();
        }

        public static Var<HyperType.Subscription> MakeSubscription(this SyntaxBuilder b, Var<Subscriber> subscriber)
        {
            Var<List<object>> subscription = b.NewCollection<object>();
            b.Push(subscription, subscriber.As<object>());
            return subscription.As<HyperType.Subscription>();
        }

        public static Var<HyperType.Subscription> MakeSubscription<TPayload>(this SyntaxBuilder b, Var<Subscriber<TPayload>> subscriber, Var<TPayload> payload)
        {
            Var<List<object>> subscription = b.NewCollection<object>();
            b.Push(subscription, subscriber.As<object>());
            b.Push(subscription, payload.As<object>());
            return subscription.As<HyperType.Subscription>();
        }

        public static void AddSubscription<TState>(this SyntaxBuilder b, string subscriptionName, Func<SyntaxBuilder, Var<TState>, Var<HyperType.Subscription>> buildSubscription)
        {
            var subscriptionBuilder = b.Def(subscriptionName, buildSubscription);
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
            return b.MakeStateWithEffects(state, effects.Select(b.MakeEffect<TState>).ToArray());
        }

        public static Var<HyperType.StateWithEffects> MakeStateWithEffects<TState>(this SyntaxBuilder b, Var<TState> state, params Var<Effect>[] effects)
        {
            var output = b.NewCollection<object>();
            b.Push(output, state.As<object>());
            foreach (Var<Effect> effect in effects)
            {
                b.Push(output, effect.As<object>());
            }

            return output.As<HyperType.StateWithEffects>();
        }

        ///// <summary>
        ///// Returns temporary state & converts all System.Actions into effects
        ///// </summary>
        ///// <typeparam name="TState"></typeparam>
        ///// <param name="b"></param>
        ///// <param name="initialState"></param>
        ///// <param name="effects"></param>
        ///// <returns></returns>
        //public static Var<HyperType.StateWithEffects> AsyncResult<TState>(this SyntaxBuilder b, Var<TState> initialState, params System.Action<SyntaxBuilder, Var<Dispatcher<TState>>>[] effects)
        //{
        //    return b.MakeStateWithEffects(initialState, effects.Select(x => b.MakeEffect(x)).ToArray());
        //}

        //public static Var<HyperType.StateWithEffects> AsyncResult<TState, TPayload>(this SyntaxBuilder b, Var<TState> initialState, System.Action<SyntaxBuilder, Var<Dispatcher<TState>>, Var<TPayload>> effecter, Var<TPayload> payload)
        //{
        //    return b.MakeStateWithEffects(initialState, b.MakeEffectWithPayload(effecter, payload));
        //}

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

        //public class ActionDescriptor<TState> { }
        //public class ActionDescriptor<TState, TPayload> { }


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

        //// Effecter is the function that, given the dispatch function (to call back into application) and an optional payload interacts with the outside world
        //public class Effecter { }
        //public class Effecter<TPayload> { }

        //public static Var<HyperType.Effecter> MakeEffecter<TState>(this SyntaxBuilder b, System.Action<SyntaxBuilder, Var<Dispatcher<TState>>> effecter)
        //{
        //    var effecterFunc = b.Def(effecter);
        //    return effecterFunc.As<HyperType.Effecter>();
        //}

        //public static Var<HyperType.Effecter<TPayload>> MakeEffecter<TState, TPayload>(this SyntaxBuilder b, System.Action<SyntaxBuilder, Var<Dispatcher<TState>>, Var<TPayload>> effecter)
        //{
        //    var effecterFunc = b.Def(effecter);
        //    return effecterFunc.As<HyperType.Effecter<TPayload>>();
        //}

        // Effects are the effecter function itself OR effecter function + payload
        public class Effect { }
        //public class Effect<TInput> { }

        public static Var<HyperType.Effect> MakeEffect<TState>(
            this SyntaxBuilder b, System.Action<SyntaxBuilder> effecterAction)
        {
            return b.Def(effecterAction).As<HyperType.Effect>();
        }

        public static Var<HyperType.Effect> MakeEffect<TState>(
            this SyntaxBuilder b, Var<System.Action> effecterAction)
        {
            return effecterAction.As<HyperType.Effect>();
        }

        public static Var<HyperType.Effect> MakeEffect<TState>(
            this SyntaxBuilder b, Var<System.Action<HyperType.Dispatcher<TState>>> effecterAction)
        {
            return effecterAction.As<HyperType.Effect>();
        }

        public static Var<HyperType.Effect> MakeEffect<TState, TInput>(
            this SyntaxBuilder b, Var<System.Action<HyperType.Dispatcher<TState>, TInput>> effecterAction, Var<TInput> effecterInput)
        {
            Var<List<object>> effectList = b.NewCollection<object>();
            b.Push(effectList, effecterAction.As<object>());
            b.Push(effectList, effecterInput.As<object>());
            return effectList.As<HyperType.Effect>();
        }

        //public static Var<HyperType.Effect<TInput>> MakeEffect<TState, TInput>(
        //    this SyntaxBuilder b, Var<Action<HyperType.Dispatcher<TState>, TInput>> effecterAction)
        //{
        //    return effecterAction.As<HyperType.Effect<TInput>>();
        //}

        //public static Var<HyperType.Effect<TInput>> MakeEffect<TState, TInput>(
        //    this SyntaxBuilder b, Var<Action<HyperType.Dispatcher<TState>, TInput>> effecterAction)
        //{
        //    return effecterAction.As<HyperType.Effect<TInput>>();
        //}

        //public static Var<HyperType.Effect> MakeEffect(this SyntaxBuilder b, Var<Effecter> effecter)
        //{
        //    return effecter.As<HyperType.Effect>();
        //}

        //public static Var<HyperType.Effect> MakeEffect<TState, TInput>(
        //    this SyntaxBuilder b,
        //    Var<Action<Dispatcher<TState>, TInput>> effecter, Var<TInput> payload)
        //{
        //    Var<List<object>> effectList = b.NewCollection<object>();
        //    b.Push(effectList, effecter.As<object>());
        //    b.Push(effectList, payload.As<object>());
        //    return effectList.As<HyperType.Effect>();
        //}


        //public static Var<HyperType.Effect> MakeEffect<TState, TInput>(
        //    this SyntaxBuilder b, 
        //    Var<Action<Dispatcher<TState>, TInput>> effecter, Var<TInput> payload)
        //{
        //    Var<List<object>> effectList = b.NewCollection<object>();
        //    b.Push(effectList, effecter.As<object>());
        //    b.Push(effectList, payload.As<object>());
        //    return effectList.As<HyperType.Effect>();
        //}

        ///// <summary>
        ///// Transforms System.Action directly into effect
        ///// </summary>
        ///// <typeparam name="TState"></typeparam>
        ///// <param name="b"></param>
        ///// <param name="effecter"></param>
        ///// <returns></returns>
        //public static Var<HyperType.Effect> MakeEffect<TState>(this SyntaxBuilder b, System.Action<SyntaxBuilder, Var<Dispatcher<TState>>> effecter)
        //{
        //    return b.MakeEffect(b.MakeEffecter(effecter));
        //}

        ///// <summary>
        ///// Transforms System.Action directly into effect with payload
        ///// </summary>
        ///// <typeparam name="TState"></typeparam>
        ///// <typeparam name="TPayload"></typeparam>
        ///// <param name="b"></param>
        ///// <param name="effecter"></param>
        ///// <param name="payload"></param>
        ///// <returns></returns>
        //public static Var<HyperType.Effect> MakeEffectWithPayload<TState, TPayload>(this SyntaxBuilder b, System.Action<SyntaxBuilder, Var<Dispatcher<TState>>, Var<TPayload>> effecter, Var<TPayload> payload)
        //{
        //    return b.MakeEffectWithPayload(b.MakeEffecter(effecter), payload);
        //}

        public static Var<StateWithEffects> RunAsync(this SyntaxBuilder b, Var<StateWithEffects> stateWithEffects, Var<Effect> effect)
        {
            Var<List<object>> stateWithEffectsAsTupleList = stateWithEffects.As<List<object>>();
            b.Push(stateWithEffectsAsTupleList, effect.As<object>());
            return stateWithEffectsAsTupleList.As<StateWithEffects>();
        }

        public class Dispatcher<TState> { }
        
        // Dispatcher does not know the type of the payload, as it can dispatch ANY action
        // public class Dispatcher<TState,TPayload> { }

        public static void Dispatch<TState>(this SyntaxBuilder b, Var<Dispatcher<TState>> dispatcher, Var<HyperType.Action<TState>> action)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState>>>();
            b.Call(callable, action);
        }

        public static void Dispatch<TState, TPayload>(this SyntaxBuilder b, Var<Dispatcher<TState>> dispatcher, Var<HyperType.Action<TState, TPayload>> action, Var<TPayload> payload)
        {
            var callable = dispatcher.As<System.Action<HyperType.Action<TState, TPayload>, TPayload>>();
            b.Call(callable, action, payload);
        }

        //public static void Dispatch<TState, TPayload>(this SyntaxBuilder b, Var<Dispatcher<TState>> dispatcher, Var<HyperType.Action<TState, TPayload>> action)
        //{
        //    var callable = dispatcher.As<System.Action<HyperType.Action<TState, TPayload>>>();
        //    b.Call(callable, action);
        //}

        //public static void Dispatch<TState, TPayload>(this SyntaxBuilder b, Var<Dispatcher<TState>> dispatcher, Var<HyperType.Action<TState>> action, Var<TPayload> payload)
        //{
        //    var callable = dispatcher.As<System.Action<HyperType.Action<TState>>>();
        //    b.Call(callable, action);
        //}

        //public static void Dispatch<TState>(this SyntaxBuilder b, Var<Dispatcher<TState>> dispatcher, Func<SyntaxBuilder, Var<TState>, Var<TState>> action)
        //{
        //    b.Dispatch(dispatcher, b.MakeAction(action));
        //}

        //public static void Dispatch<TState, TPayload>(
        //    this SyntaxBuilder b, 
        //    Var<Dispatcher<TState>> dispatcher, 
        //    Var<HyperType.Action<TState, TPayload>> action, 
        //    Var<TPayload> payload)
        //{
        //    var callable = dispatcher.As<System.Action<HyperType.Action<TState, TPayload>, TPayload>>();
        //    b.Call(callable, action, payload);
        //}

        //public static void Dispatch<TState,TPayload>(
        //    this SyntaxBuilder b,
        //    Var<Dispatcher<TState>> dispatcher,
        //    Func<SyntaxBuilder, Var<TState>, Var<TPayload>, Var<TState>> action,
        //    Var<TPayload> payload)
        //{
        //    b.Dispatch(dispatcher, b.MakeAction(action), payload);
        //}
    }
}
