using Metapsi.Syntax;
using System;
using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The Promise object represents the eventual completion (or failure) of an asynchronous operation and its resulting value.
/// </summary>
public class Promise
{

}

/// <summary>
/// 
/// </summary>
public interface PromiseResolvers
{
    /// <summary>
    /// A Promise object.
    /// </summary>
    Promise promise { get; }
    
    /// <summary>
    /// A function that resolves the promise.
    /// </summary>
    object resolve { get; }

    /// <summary>
    /// A function that rejects the promise. 
    /// </summary>
    object reject { get; }
}

/// <summary>
/// 
/// </summary>
public static partial class PromiseExtensions
{
    /// <summary>
    /// The Promise() constructor creates Promise objects
    /// </summary>
    /// <param name="b"></param>
    /// <param name="executor">A function to be executed by the constructor. It receives two functions as parameters: resolveFunc and rejectFunc. Any errors thrown in the executor will cause the promise to be rejected, and the return value will be neglected.</param>
    /// <returns>A promise object. The promise object will become resolved when either of the functions resolveFunc or rejectFunc are invoked.</returns>
    public static Var<Promise> NewPromise<TResolve, TReject>(this SyntaxBuilder b, Var<System.Action<System.Action<TResolve>, System.Action<TReject>>> executor)
    {
        return b.Construct<Promise>(b.GetClass<Promise>(), executor);
    }

    /// <summary>
    /// The Promise() constructor creates Promise objects
    /// </summary>
    /// <typeparam name="TResolve"></typeparam>
    /// <typeparam name="TReject"></typeparam>
    /// <param name="b"></param>
    /// <param name="executor">A function to be executed by the constructor. It receives two functions as parameters: resolveFunc and rejectFunc. Any errors thrown in the executor will cause the promise to be rejected, and the return value will be neglected.</param>
    /// <returns>A promise object. The promise object will become resolved when either of the functions resolveFunc or rejectFunc are invoked.</returns>
    public static Var<Promise> NewPromise<TResolve, TReject>(
        this SyntaxBuilder b,
        System.Action<SyntaxBuilder, Var<System.Action<TResolve>>, Var<System.Action<TReject>>> executor)
    {
        return b.NewPromise(b.Def(executor));
    }

    /// <summary>
    /// The catch() method of Promise instances schedules a function to be called when the promise is rejected. It immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TReason"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected.Its return value becomes the fulfillment value of the promise returned by catch(). The function is called with the following arguments:
    /// <para>reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise. This new promise is always pending when returned, regardless of the current promise's status. If onRejected is called, the returned promise will resolve based on the return value of this call, or reject with the thrown error from this call. If the current promise fulfills, onRejected is not called and the returned promise fulfills to the same value.</returns>
    public static Var<Promise> PromiseCatch<TReason,TResult>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Func<TReason, TResult>> onRejected)
    {
        return b.CallOnObject<Promise>(promise, "catch", onRejected);
    }

    /// <summary>
    /// The catch() method of Promise instances schedules a function to be called when the promise is rejected. It immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TReason"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected.Its return value becomes the fulfillment value of the promise returned by catch(). The function is called with the following arguments:
    /// <para>reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise. This new promise is always pending when returned, regardless of the current promise's status. If onRejected is called, the returned promise will resolve based on the return value of this call, or reject with the thrown error from this call. If the current promise fulfills, onRejected is not called and the returned promise fulfills to the same value.</returns>
    public static Var<Promise> PromiseCatch<TReason, TResult>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Func<SyntaxBuilder, Var<TReason>, Var<TResult>> onRejected)
    {
        return b.PromiseCatch(promise, b.Def(onRejected));
    }

    /// <summary>
    /// The catch() method of Promise instances schedules a function to be called when the promise is rejected. It immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected. The function is called with the following arguments:
    /// <para>reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise. This new promise is always pending when returned, regardless of the current promise's status. If onRejected is called, the returned promise will resolve based on the return value of this call, or reject with the thrown error from this call. If the current promise fulfills, onRejected is not called and the returned promise fulfills to the same value.</returns>
    public static Var<Promise> PromiseCatch<TReason>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Action<TReason>> onRejected)
    {
        return b.CallOnObject<Promise>(promise, "catch", onRejected);
    }

    /// <summary>
    /// The catch() method of Promise instances schedules a function to be called when the promise is rejected. It immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected. The function is called with the following arguments:
    /// <para>reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise. This new promise is always pending when returned, regardless of the current promise's status. If onRejected is called, the returned promise will resolve based on the return value of this call, or reject with the thrown error from this call. If the current promise fulfills, onRejected is not called and the returned promise fulfills to the same value.</returns>
    public static Var<Promise> PromiseCatch<TReason>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Action<SyntaxBuilder, Var<TReason>> onRejected)
    {
        return b.PromiseCatch(promise, b.Def(onRejected));
    }

    /// <summary>
    /// The finally() method of Promise instances schedules a function to be called when the promise is settled (either fulfilled or rejected). It immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFinally">A function to asynchronously execute when this promise becomes settled.</param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status. If onFinally throws an error or returns a rejected promise, the new promise will reject with that value. Otherwise, the new promise will settle with the same state as the current promise.</returns>
    public static Var<Promise> PromiseFinally(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Action> onFinally)
    {
        return b.CallOnObject<Promise>(promise, "finally", onFinally);
    }

    /// <summary>
    /// The finally() method of Promise instances schedules a function to be called when the promise is settled (either fulfilled or rejected). It immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFinally">A function to asynchronously execute when this promise becomes settled.</param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status. If onFinally throws an error or returns a rejected promise, the new promise will reject with that value. Otherwise, the new promise will settle with the same state as the current promise.</returns>
    public static Var<Promise> PromiseFinally(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Action<SyntaxBuilder> onFinally)
    {
        return b.PromiseFinally(promise, b.Def(onFinally));
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue, TReason, TResult>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Func<TValue, TResult>> onFulfilled,
        Var<Func<TReason, TResult>> onRejected)
    {
        return b.CallOnObject<Promise>(promise, "then", onFulfilled, onRejected);
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue, TReason>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Action<TValue>> onFulfilled,
        Var<Action<TReason>> onRejected)
    {
        return b.CallOnObject<Promise>(promise, "then", onFulfilled, onRejected);
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue, TReason>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Action<SyntaxBuilder, Var<TValue>> onFulfilled,
        Action<SyntaxBuilder, Var<TReason>> onRejected)
    {
        return b.PromiseThen(promise, b.Def(onFulfilled), b.Def(onRejected));
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <typeparam name="TReason"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <param name="onRejected">A function to asynchronously execute when this promise becomes rejected. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> reason The value that the promise was rejected with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue, TReason, TResult>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Func<SyntaxBuilder, Var<TValue>, Var<TResult>> onFulfilled,
        Func<SyntaxBuilder, Var<TReason>, Var<TResult>> onRejected)
    {
        return b.PromiseThen(promise, b.Def(onFulfilled), b.Def(onRejected));
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue,TResult>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Func<TValue, TResult>> onFulfilled)
    {
        return b.CallOnObject<Promise>(promise, "then", onFulfilled);
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. Its return value becomes the fulfillment value of the promise returned by then(). The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue, TResult>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Func<SyntaxBuilder, Var<TValue>, Var<TResult>> onFulfilled)
    {
        return b.PromiseThen(promise, b.Def(onFulfilled));
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled.  The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Var<Action<TValue>> onFulfilled)
    {
        return b.CallOnObject<Promise>(promise, "then", onFulfilled);
    }

    /// <summary>
    /// The then() method of Promise instances takes up to two arguments: callback functions for the fulfilled and rejected cases of the Promise. It stores the callbacks within the promise it is called on and immediately returns another Promise object, allowing you to chain calls to other promise methods.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="promise"></param>
    /// <param name="onFulfilled">A function to asynchronously execute when this promise becomes fulfilled. The function is called with the following arguments:
    /// <para> value The value that the promise was fulfilled with.</para>
    /// </param>
    /// <returns>Returns a new Promise immediately. This new promise is always pending when returned, regardless of the current promise's status.</returns>
    public static Var<Promise> PromiseThen<TValue>(
        this SyntaxBuilder b,
        Var<Promise> promise,
        Action<SyntaxBuilder, Var<TValue>> onFulfilled)
    {
        return b.PromiseThen(promise, b.Def(onFulfilled));
    }



    /// <summary>
    /// The Promise.all() static method takes an iterable of promises as input and returns a single Promise. This returned promise fulfills when all of the input's promises fulfill (including when an empty iterable is passed), with an array of the fulfillment values. It rejects when any of the input's promises rejects, with this first rejection reason.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="iterable">An iterable (such as an Array) of promises.</param>
    /// <returns>A Promise that is:
    /// <para>    Already fulfilled, if the iterable passed is empty.</para>
    /// <para>    Asynchronously fulfilled, when all the promises in the given iterable fulfill.The fulfillment value is an array of fulfillment values, in the order of the promises passed, regardless of completion order. If the iterable passed is non-empty but contains no pending promises, the returned promise is still asynchronously (instead of synchronously) fulfilled.</para>
    /// <para>    Asynchronously rejected, when any of the promises in the given iterable rejects.The rejection reason is the rejection reason of the first promise that was rejected.</para>
    /// </returns>
    public static Var<Promise> PromiseAll(
        this SyntaxBuilder b,
        Var<List<Promise>> iterable)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "all", iterable);
    }

    /// <summary>
    /// The Promise.all() static method takes an iterable of promises as input and returns a single Promise. This returned promise fulfills when all of the input's promises fulfill (including when an empty iterable is passed), with an array of the fulfillment values. It rejects when any of the input's promises rejects, with this first rejection reason.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="iterable">An iterable (such as an Array) of promises.</param>
    /// <returns>A Promise that is:
    /// <para>    Already fulfilled, if the iterable passed is empty.</para>
    /// <para>    Asynchronously fulfilled, when all the promises in the given iterable fulfill.The fulfillment value is an array of fulfillment values, in the order of the promises passed, regardless of completion order. If the iterable passed is non-empty but contains no pending promises, the returned promise is still asynchronously (instead of synchronously) fulfilled.</para>
    /// <para>    Asynchronously rejected, when any of the promises in the given iterable rejects.The rejection reason is the rejection reason of the first promise that was rejected.</para>
    /// </returns>
    public static Var<Promise> PromiseAll(
        this SyntaxBuilder b,
        params Var<Promise>[] iterable)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "all", b.List(iterable));
    }

    /// <summary>
    /// The Promise.allSettled() static method takes an iterable of promises as input and returns a single Promise. This returned promise fulfills when all of the input's promises settle (including when an empty iterable is passed), with an array of objects that describe the outcome of each promise.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="iterable">An iterable (such as an Array) of promises.</param>
    /// <returns>A Promise that is:
    /// <para>Already fulfilled, if the iterable passed is empty.</para>
    /// <para>Asynchronously fulfilled, when all promises in the given iterable have settled(either fulfilled or rejected). The fulfillment value is an array of objects, each describing the outcome of one promise in the iterable, in the order of the promises passed, regardless of completion order.Each outcome object has the following properties:</para>
    /// <para> - status - A string, either "fulfilled" or "rejected", indicating the eventual state of the promise.</para>
    /// <para> - value - Only present if status is "fulfilled". The value that the promise was fulfilled with.</para>
    /// <para> - reason - Only present if status is "rejected". The reason that the promise was rejected with.</para>
    /// <para> If the iterable passed is non-empty but contains no pending promises, the returned promise is still asynchronously (instead of synchronously) fulfilled.</para>
    /// </returns>
    public static Var<Promise> PromiseAllSettled(
        this SyntaxBuilder b,
        Var<List<Promise>> iterable)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "allSettled", iterable);
    }

    /// <summary>
    /// The Promise.any() static method takes an iterable of promises as input and returns a single Promise. This returned promise fulfills when any of the input's promises fulfills, with this first fulfillment value. It rejects when all of the input's promises reject (including when an empty iterable is passed), with an AggregateError containing an array of rejection reasons.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="iterable">An iterable (such as an Array) of promises.</param>
    /// <returns>A Promise that is:
    /// <para>Already rejected, if the iterable passed is empty.</para>
    /// <para>Asynchronously fulfilled, when any of the promises in the given iterable fulfills.The fulfillment value is the fulfillment value of the first promise that was fulfilled.</para>
    /// <para>Asynchronously rejected, when all of the promises in the given iterable reject. The rejection reason is an AggregateError containing an array of rejection reasons in its errors property.The errors are in the order of the promises passed, regardless of completion order. If the iterable passed is non-empty but contains no pending promises, the returned promise is still asynchronously (instead of synchronously) rejected.</para>
    /// </returns>
    public static Var<Promise> PromiseAny(
        this SyntaxBuilder b,
        Var<List<Promise>> iterable)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "any", iterable);
    }

    /// <summary>
    /// The Promise.race() static method takes an iterable of promises as input and returns a single Promise. This returned promise settles with the eventual state of the first promise that settles.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="iterable">An iterable (such as an Array) of promises.</param>
    /// <returns>A Promise that asynchronously settles with the eventual state of the first promise in the iterable to settle. In other words, it fulfills if the first promise to settle is fulfilled, and rejects if the first promise to settle is rejected. The returned promise remains pending forever if the iterable passed is empty. If the iterable passed is non-empty but contains no pending promises, the returned promise is still asynchronously (instead of synchronously) settled.</returns>
    public static Var<Promise> PromiseRace(
        this SyntaxBuilder b,
        Var<List<Promise>> iterable)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "race", iterable);
    }

    /// <summary>
    /// The Promise.reject() static method returns a Promise object that is rejected with a given reason.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="reason">Reason why this Promise rejected.</param>
    /// <returns>A Promise that is rejected with the given reason.</returns>
    public static Var<Promise> PromiseReject<TReason>(
        this SyntaxBuilder b,
        Var<TReason> reason)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "reject", reason);
    }

    /// <summary>
    /// The Promise.resolve() static method "resolves" a given value to a Promise.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="b"></param>
    /// <param name="value">Argument to be resolved by this Promise. Can also be a Promise or a thenable to resolve.</param>
    /// <returns>A Promise that is resolved with the given value, or the promise passed as value, if the value was a promise object. A resolved promise can be in any of the states — fulfilled, rejected, or pending. For example, resolving a rejected promise will still result in a rejected promise.</returns>
    public static Var<Promise> PromiseResolve<TValue>(
        this SyntaxBuilder b,
        Var<TValue> value)
    {
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "resolve", value);
    }

    /// <summary>
    /// The Promise.try() static method takes a callback of any kind (returns or throws, synchronously or asynchronously) and wraps its result in a Promise.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="func">A function that is called synchronously with the arguments provided (arg1, arg2, …, argN). It can do anything—either return a value, throw an error, or return a promise.</param>
    /// <param name="args">Arguments to pass to func.</param>
    /// <returns></returns>
    public static Var<Promise> PromiseTry<TFunc>(
        this SyntaxBuilder b,
        Var<TFunc> func,
        params IVariable[] args)
        where TFunc : Delegate
    {
        List<IVariable> allArgs = new List<IVariable>();
        allArgs.Add(func);
        allArgs.AddRange(args);
        return b.CallOnObject<Promise>(b.GetClass<Promise>(), "try", allArgs.ToArray());
    }

    /// <summary>
    /// The Promise.withResolvers() static method returns an object containing a new Promise object and two functions to resolve or reject it, corresponding to the two parameters passed to the executor of the Promise() constructor.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A plain object containing the following properties:
    /// <para>promise A Promise object.</para>
    /// <para>resolve A function that resolves the promise.For its semantics, see the Promise() constructor reference.</para> 
    /// <para>reject A function that rejects the promise. For its semantics, see the Promise() constructor reference.</para>
    /// </returns>
    public static Var<PromiseResolvers> PromiseWithResolvers(
        this SyntaxBuilder b)
    {
        return b.CallOnObject<PromiseResolvers>(b.GetClass<Promise>(), "withResolvers");
    }


}

///////////////////////////////////////
//          Typed Promise<T>          
///////////////////////////////////////

/// <summary>
/// The Promise object represents the eventual completion (or failure) of an asynchronous operation and its resulting value.
/// </summary>
/// <typeparam name="T"></typeparam>
public class Promise<T>
{

}

/// <summary>
/// Returned by allSettled
/// </summary>
/// <typeparam name="T"></typeparam>
public class PromiseSettledResult<T>
{
    /// <summary>
    /// A string, either "fulfilled" or "rejected", indicating the eventual state of the promise.
    /// </summary>
    public string status { get; set; }
    /// <summary>
    /// Only present if status is "fulfilled". The value that the promise was fulfilled with.
    /// </summary>
    public T value { get; set; }
    /// <summary>
    /// Only present if status is "rejected". The reason that the promise was rejected with.
    /// </summary>
    public object reason { get; set; }
}

/// <summary>
/// Returned by Promise.withResolvers()
/// </summary>
/// <typeparam name="T"></typeparam>
public class PromiseWithResolvers<T>
{
    /// <summary>
    /// A Promise object.
    /// </summary>
    public Promise<T> promise { get; set; }
    /// <summary>
    /// A function that resolves the promise.
    /// </summary>
    public Action<T> resolve { get; set; }
    /// <summary>
    /// A function that rejects the promise.
    /// </summary>
    public Action<object> reject { get; set; }
}

public static partial class PromiseExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="executor"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> NewPromise<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<Action<Action<T>, Action<object>>> executor)
    {
        var promise = b.Construct(executor);
        return new ObjBuilder<Promise<T>>(
            (b as IObjBuilder).ModuleBuilder,
            (b as IObjBuilder).GetNodes(),
            promise.As<Promise<T>>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFulfilled"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<TResult>> then<T, TResult>(
        this ObjBuilder<Promise<T>> b,
        Var<Func<T, TResult>> onFulfilled)
    {
        return b.Call<Promise<TResult>>("then", onFulfilled);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFulfilled"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<TResult>> then<T, TResult>(
        this ObjBuilder<Promise<T>> b,
        Var<Func<T, Promise<TResult>>> onFulfilled)
    {
        return b.Call<Promise<TResult>>("then", onFulfilled);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFulfilled"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise> then<T>(
        this ObjBuilder<Promise<T>> b,
        Var<Action<T>> onFulfilled)
    {
        return b.Call<Promise>("then", onFulfilled);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFulfilled"></param>
    /// <param name="onRejected"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<TResult>> then<T, TResult>(
        this ObjBuilder<Promise<T>> b,
        Var<Func<T, TResult>> onFulfilled,
        Var<Func<object, TResult>> onRejected)
    {
        return b.Call<Promise<TResult>>("then", onFulfilled, onRejected);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="onRejected"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> @catch<T>(
        this ObjBuilder<Promise<T>> b,
        Var<Func<object, T>> onRejected)
    {
        return b.Call<Promise<T>>("catch", onRejected);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="onRejected"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> @catch<T>(
        this ObjBuilder<Promise<T>> b,
        Var<Func<object, Promise<T>>> onRejected)
    {
        return b.Call<Promise<T>>("catch", onRejected);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="onRejected"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise> @catch<T>(
        this ObjBuilder<Promise<T>> b,
        Var<Action<object>> onRejected)
    {
        return b.Call<Promise>("catch", onRejected);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="onFinally"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> @finally<T>(
        this ObjBuilder<Promise<T>> b,
        Var<Action> onFinally)
    {
        return b.Call<Promise<T>>("finally", onFinally);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="onRejected"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise> @catch(
        this ObjBuilder<Promise> b,
        Var<Action<object>> onRejected)
    {
        return b.Call<Promise>("catch", onRejected);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="onFinally"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise> @finally(
        this ObjBuilder<Promise> b,
        Var<Action> onFinally)
    {
        return b.Call<Promise>("finally", onFinally);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> resolve<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<T> value)
    {
        return b.Call<Promise<T>>("resolve", value);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise> resolve(
        this ObjBuilder<ClassDef<Promise>> b)
    {
        return b.Call<Promise>("resolve");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="reason"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> reject<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<object> reason)
    {
        return b.Call<Promise<T>>("reject", reason);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="promises"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<List<T>>> All<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<List<Promise<T>>> promises)
    {
        return b.Call<Promise<List<T>>>("all", promises);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="promises"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> race<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<List<Promise<T>>> promises)
    {
        return b.Call<Promise<T>>("race", promises);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="promises"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> any<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<List<Promise<T>>> promises)
    {
        return b.Call<Promise<T>>("any", promises);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="promises"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<List<PromiseSettledResult<T>>>> allSettled<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<List<Promise<T>>> promises)
    {
        return b.Call<Promise<List<PromiseSettledResult<T>>>>("allSettled", promises);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ObjBuilder<PromiseWithResolvers<T>> withResolvers<T>(
        this ObjBuilder<ClassDef<Promise>> b)
    {
        return b.Call<PromiseWithResolvers<T>>("withResolvers");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="fn"></param>
    /// <returns></returns>
    public static ObjBuilder<Promise<T>> @try<T>(
        this ObjBuilder<ClassDef<Promise>> b,
        Var<Func<T>> fn)
    {
        return b.Call<Promise<T>>("try", fn);
    }
}