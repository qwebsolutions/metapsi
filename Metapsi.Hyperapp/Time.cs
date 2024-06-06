using Metapsi.Dom;
using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp;

// Remake of hyperapp/packages/time/index.js

public static class Time
{
    public class TimeoutProps<TState>
    {
        public HyperType.Action<TState> Action { get; set; }
        public int DelayMs { get; set; }
    }

    /// <summary>
    /// Timeout effecter
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <param name="dispatch"></param>
    /// <param name="props"></param>
    public static void Timeout<TState>(this SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<TimeoutProps<TState>> props)
    {
        b.SetTimeout(b.Def((SyntaxBuilder b) =>
        {
            b.Dispatch(dispatch, b.Get(props, x => x.Action));
        }),
        b.Get(props, x => x.DelayMs));
    }

    public class IntervalProps<TState>
    {
        public HyperType.Action<TState, long> Action { get; set; }
        public int DelayMs { get; set; }
    }

    /// <summary>
    /// Interval subscriber
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <param name="dispatch"></param>
    /// <param name="props"></param>
    /// <returns>Cleanup function</returns>
    public static Var<System.Action> Interval<TState>(this SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<IntervalProps<TState>> props)
    {
        var id = b.SetInterval(b.Def((SyntaxBuilder b) =>
        {
            b.Dispatch(dispatch, b.Get(props, x => x.Action), b.DateNow());
        }),
        b.Get(props, x => x.DelayMs));
        return b.Def((SyntaxBuilder b) => b.ClearInterval(id));
    }

    /// <summary>
    /// Date now effecter
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    /// <param name="b"></param>
    /// <param name="dispatch"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public static void GetTime<TState>(this SyntaxBuilder b, Var<HyperType.Dispatcher> dispatch, Var<HyperType.Action<TState, long>> action)
    {
        b.Dispatch(dispatch, action, b.DateNow());
    }

    public static Var<HyperType.Subscription> Every<TState>(this SyntaxBuilder b, Var<int> delay, Var<HyperType.Action<TState, long>> action)
    {
        return b.MakeSubscription<TState, IntervalProps<TState>>(
            b.Def<SyntaxBuilder, HyperType.Dispatcher, IntervalProps<TState>, System.Action>(Interval),
            b.NewObj<IntervalProps<TState>>(b =>
            {
                b.Set(x => x.DelayMs, delay);
                b.Set(x => x.Action, action);
            }));
    }

    public static Var<HyperType.Effect> Delay<TState>(this SyntaxBuilder b, Var<int> delay, Var<HyperType.Action<TState>> action)
    {
        return b.MakeEffect(
            Timeout,
            b.NewObj<TimeoutProps<TState>>(b =>
            {
                b.Set(x => x.DelayMs, delay);
                b.Set(x => x.Action, action);
            }));
    }

    public static Var<HyperType.Effect> Now<TState>(this SyntaxBuilder b, Var<HyperType.Action<TState, long>> action)
    {
        return b.MakeEffect(GetTime, action);
    }
}
