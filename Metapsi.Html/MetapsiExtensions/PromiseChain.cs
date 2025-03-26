using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// Metapsi-specific props for easier chaining or promises
/// </summary>
public class PromiseChain
{
    /// <summary>
    /// Then handlers
    /// </summary>
    public List<ThenHandler> Thens { get; set; } = new();
    /// <summary>
    /// Catch handler
    /// </summary>
    public Func<Error, DynamicObject> Catch { get; set; }
    /// <summary>
    /// Finally handler
    /// </summary>
    public Action Finally { get; set; }

    /// <summary>
    /// Stores onFullfilled/onRejected then handlers
    /// </summary>
    public class ThenHandler
    {
        /// <summary>
        /// On fullfilled then handler
        /// </summary>
        public Func<DynamicObject, DynamicObject> OnFullfilled { get; set; }
        /// <summary>
        /// On rejected then handler
        /// </summary>
        public Func<DynamicObject, DynamicObject> OnRejected { get; set; }
    }
}

/// <summary>
/// 
/// </summary>
public static class PromiseChainExtensions
{
    /// <summary>
    /// Builds a promise chain
    /// </summary>
    /// <param name="b"></param>
    /// <param name="initial">The initial promise</param>
    /// <param name="build">Chain builder</param>
    /// <returns>The resulting promise</returns>
    public static Var<Promise> PromiseChain(this SyntaxBuilder b, Var<Promise> initial, Action<PropsBuilder<PromiseChain>> build)
    {
        var props = b.SetProps(b.NewObj<PromiseChain>(), build);
        var lastPromiseRef = b.Ref(initial);
        b.Foreach(
            b.Get(props, x => x.Thens),
            (b, then) =>
            {
                var onFullfilled = b.Get(then, x => x.OnFullfilled);
                var onRejected = b.Get(then, x => x.OnRejected);

                b.SetRef(
                    lastPromiseRef,
                    b.If(
                        b.And(b.HasObject(onFullfilled), b.HasObject(onRejected)),
                        b => b.PromiseThen(b.GetRef(lastPromiseRef), onFullfilled, onRejected),
                        b => b.If(
                            b.HasObject(onFullfilled),
                        b => b.PromiseThen(b.GetRef(lastPromiseRef), onFullfilled),
                        b => b.PromiseThen(b.GetRef(lastPromiseRef), onRejected))));
            });

        b.If(b.HasObject(b.Get(props, x => x.Catch)),
            b => b.SetRef(lastPromiseRef, b.PromiseCatch(b.GetRef(lastPromiseRef), b.Get(props, x => x.Catch))));

        b.If(b.HasObject(b.Get(props, x => x.Finally)),
            b => b.SetRef(lastPromiseRef, b.PromiseFinally(b.GetRef(lastPromiseRef), b.Get(props, x => x.Finally))));

        return b.GetRef(lastPromiseRef);
    }

    /// <summary>
    /// Chain then action handler ignoring fullfilled value
    /// </summary>
    /// <param name="b"></param>
    /// <param name="onFullfilled"></param>
    public static void Then(this PropsBuilder<PromiseChain> b, Action<SyntaxBuilder> onFullfilled)
    {
        b.Push(
            b.Get(x => x.Thens),
            b.NewObj<PromiseChain.ThenHandler>(
                b =>
                {
                    b.Set(x => x.OnFullfilled, b.Def(onFullfilled).As<Func<DynamicObject, DynamicObject>>());
                }));
    }

    /// <summary>
    /// Chain then action handler for fullfilled value
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFullfilled"></param>
    public static void Then<TValue>(this PropsBuilder<PromiseChain> b, Action<SyntaxBuilder, Var<TValue>> onFullfilled)
    {
        b.Push(
            b.Get(x => x.Thens),
            b.NewObj<PromiseChain.ThenHandler>(
                b =>
                {
                    b.Set(x => x.OnFullfilled, b.Def(onFullfilled).As<Func<DynamicObject, DynamicObject>>());
                }));
    }

    /// <summary>
    /// Chain then function handler for fullfilled value
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFullfilled"></param>
    public static void Then<TValue, TResult>(this PropsBuilder<PromiseChain> b, Func<SyntaxBuilder, Var<TValue>, Var<TResult>> onFullfilled)
    {
        b.Push(
            b.Get(x => x.Thens),
            b.NewObj<PromiseChain.ThenHandler>(
                b =>
                {
                    b.Set(x => x.OnFullfilled, b.Def(onFullfilled).As<Func<DynamicObject, DynamicObject>>());
                }));
    }

    /// <summary>
    /// Chain catch handler for rejected reason. This can only be used once per promise chain
    /// </summary>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="onRejected"></param>
    public static void Catch<TReason>(this PropsBuilder<PromiseChain> b, Action<SyntaxBuilder, Var<TReason>> onRejected)
    {
        b.Set(x => x.Catch, b.Def(onRejected).As<Func<Error, DynamicObject>>());
    }
}
