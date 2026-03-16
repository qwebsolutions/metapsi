using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;

/// <summary>
/// The Array object, as with arrays in other programming languages, enables storing a collection of multiple items under a single variable name, and has members for performing common array operations.
/// </summary>
public interface Array
{
    /// <summary>
    /// The length data property of an Array instance represents the number of elements in that array. The value is an unsigned, 32-bit integer that is always numerically greater than the highest index in the array.
    /// </summary>
    int length { get; set; }
}

/// <summary>
/// 
/// </summary>
public static partial class ArrayExtensions
{

    /// <summary>
    /// Array class reference
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<ClassDef<Array>> Array(this SyntaxBuilder b)
    {
        return b.GetProperty<ClassDef<Array>>(b.Self(), "Array");
    }

    /// <summary>
    /// The Array() constructor creates Array objects.
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ObjBuilder<Array> New(this ObjBuilder<ClassDef<Array>> b)
    {
        return b.New<Array>();
    }

    /// <summary>
    /// The Array() constructor creates Array objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="elements">A JavaScript array is initialized with the given elements, except in the case where a single argument is passed to the Array constructor and that argument is a number</param>
    /// <returns></returns>
    public static ObjBuilder<Array> New(
        this ObjBuilder<ClassDef<Array>> b,
        params IVariable[] elements)
    {
        return b.New<Array>(elements);
    }

    /// <summary>
    /// The Array() constructor creates Array objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="arrayLength">If the only argument passed to the Array constructor is an integer between 0 and 232 - 1 (inclusive), this returns a new JavaScript array with its length property set to that number.</param>
    /// <returns></returns>
    public static ObjBuilder<Array> New(
        this ObjBuilder<ClassDef<Array>> b,
        Var<int> arrayLength)
    {
        return b.New<Array>(arrayLength);
    }

    /// <summary>
    /// The Array.from() static method creates a new, shallow-copied Array instance from an iterable or array-like object.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="items">An iterable or array-like object to convert to an array.</param>
    /// <param name="mapFn">A function to call on every element of the array. If provided, every value to be added to the array is first passed through this function, and mapFn's return value is added to the array instead. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>A new Array instance.</returns>
    public static ObjBuilder<Array> from<TMapIn, TMapOut>(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable items,
        Var<System.Func<TMapIn, int, TMapOut>> mapFn)
    {
        return b.Call<Array>(nameof(from), items, mapFn);
    }

    /// <summary>
    /// The Array.from() static method creates a new, shallow-copied Array instance from an iterable or array-like object.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="items">An iterable or array-like object to convert to an array.</param>
    /// <param name="mapFn">A function to call on every element of the array. If provided, every value to be added to the array is first passed through this function, and mapFn's return value is added to the array instead. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>A new Array instance.</returns>
    public static ObjBuilder<Array> from<TMapIn, TMapOut>(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable items,
        Var<System.Func<TMapIn, TMapOut>> mapFn)
    {
        return b.Call<Array>(nameof(from), items, mapFn);
    }


    /// <summary>
    /// The Array.from() static method creates a new, shallow-copied Array instance from an iterable or array-like object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="items">An iterable or array-like object to convert to an array.</param>
    /// <returns>A new Array instance.</returns>
    public static ObjBuilder<Array> from(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable items)
    {
        return b.Call<Array>(nameof(from), items);
    }

    /// <summary>
    /// The Array.fromAsync() static method creates a new, shallow-copied Array instance from an async iterable, iterable, or array-like object.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="items">An async iterable, iterable, or array-like object to convert to an array.</param>
    /// <param name="mapFn">A function to call on every element of the array. If provided, every value to be added to the array is first passed through this function, and mapFn's return value is added to the array instead (after being awaited). The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.If items is a sync iterable or array-like object, then all elements are first awaited, and element will never be a thenable.If items is an async iterable, then each yielded value is passed as-is.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>A new Promise whose fulfillment value is a new Array instance.</returns>
    public static ObjBuilder<Promise> fromAsync<TMapIn, TMapOut>(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable items,
        Var<System.Func<TMapIn, int, TMapOut>> mapFn)
    {
        return b.Call<Promise>(nameof(from), items, mapFn);
    }


    /// <summary>
    /// The Array.fromAsync() static method creates a new, shallow-copied Array instance from an async iterable, iterable, or array-like object.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="items">An async iterable, iterable, or array-like object to convert to an array.</param>
    /// <param name="mapFn">A function to call on every element of the array. If provided, every value to be added to the array is first passed through this function, and mapFn's return value is added to the array instead (after being awaited). The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.If items is a sync iterable or array-like object, then all elements are first awaited, and element will never be a thenable.If items is an async iterable, then each yielded value is passed as-is.</para>
    /// </param>
    /// <returns>A new Promise whose fulfillment value is a new Array instance.</returns>
    public static ObjBuilder<Promise> fromAsync<TMapIn, TMapOut>(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable items,
        Var<System.Func<TMapIn, TMapOut>> mapFn)
    {
        return b.Call<Promise>(nameof(from), items, mapFn);
    }

    /// <summary>
    /// The Array.fromAsync() static method creates a new, shallow-copied Array instance from an async iterable, iterable, or array-like object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="items">An async iterable, iterable, or array-like object to convert to an array.</param>
    /// <returns>A new Promise whose fulfillment value is a new Array instance.</returns>
    public static ObjBuilder<Promise> fromAsync(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable items)
    {
        return b.Call<Promise>(nameof(from), items);
    }

    /// <summary>
    /// The Array.isArray() static method determines whether the passed value is an Array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="value">The value to be checked.</param>
    /// <returns>true if value is an Array; otherwise, false. false is always returned if value is a TypedArray instance.</returns>
    public static ObjBuilder<bool> isArray(
        this ObjBuilder<ClassDef<Array>> b,
        IVariable value)
    {
        return b.Call<bool>(nameof(isArray), value);
    }

    /// <summary>
    /// The Array.of() static method creates a new Array instance from a variable number of arguments, regardless of number or type of the arguments.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="elements">Elements used to create the array.</param>
    /// <returns>A new Array instance.</returns>
    public static ObjBuilder<Array> of(
        this ObjBuilder<ClassDef<Array>> b,
        params IVariable[] elements)
    {
        return b.Call<Array>(nameof(of), elements);
    }

    /// <summary>
    /// The at() method of Array instances takes an integer value and returns the item at that index, allowing for positive and negative integers. Negative integers count back from the last item in the array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="index">Zero-based index of the array element to be returned, converted to an integer. Negative index counts back from the end of the array — if index &lt; 0, index + array.length is accessed.</param>
    /// <returns>The element in the array matching the given index. Always returns undefined if index &lt; -array.length or index &gt;= array.length without attempting to access the corresponding property.</returns>
    public static ObjBuilder<T> at<T>(
        this ObjBuilder<Array> b,
        Var<int> index)
    {
        return b.Call<T>(nameof(at), index);
    }

    /// <summary>
    /// The concat() method of Array instances is used to merge two or more arrays. This method does not change the existing arrays, but instead returns a new array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="values">Arrays and/or values to concatenate into a new array. If all valueN parameters are omitted, concat returns a shallow copy of the existing array on which it is called.</param>
    /// <returns>A new Array instance.</returns>
    public static ObjBuilder<Array> concat(
        this ObjBuilder<Array> b,
        params Var<Array>[] values)
    {
        return b.Call<Array>(nameof(concat), values);
    }

    /// <summary>
    /// The copyWithin() method of Array instances shallow copies part of this array to another location in the same array and returns this array without modifying its length.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="target">
    /// Zero-based index at which to copy the sequence to, converted to an integer. This corresponds to where the element at start will be copied to, and all elements between start and end are copied to succeeding indices.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= target&lt; 0, target + array.length is used.</para>
    /// <para>If target &lt; -array.length, 0 is used.</para>
    /// <para>If target >= array.length, nothing is copied.</para>
    /// <para>If target is positioned after start after normalization, copying only happens until the end of array.length (in other words, copyWithin() never extends the array).</para>
    /// </param>
    /// <param name="start">
    /// Zero-based index at which to start copying elements from, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length, 0 is used.</para>
    /// <para>If start >= array.length, nothing is copied.</para>
    /// </param>
    /// <param name="end">
    /// Zero-based index at which to end copying elements from, converted to an integer. copyWithin() copies up to but not including end.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= end&lt; 0, end + array.length is used.</para>
    /// <para>If end&lt; -array.length, 0 is used.</para>
    /// <para>If end >= array.length or end is omitted or undefined, array.length is used, causing all elements until the end to be copied.</para>
    /// <para>If end implies a position before or at the position that start implies, nothing is copied.</para>
    /// </param>
    /// <returns>The modified array.</returns>
    public static ObjBuilder<Array> copyWithin(
        this ObjBuilder<Array> b,
        Var<int> target,
        Var<int> start,
        Var<int> end)
    {
        return b.Call<Array>(nameof(copyWithin), target, start, end);
    }

    /// <summary>
    /// The copyWithin() method of Array instances shallow copies part of this array to another location in the same array and returns this array without modifying its length.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="target">
    /// Zero-based index at which to copy the sequence to, converted to an integer. This corresponds to where the element at start will be copied to, and all elements between start and end are copied to succeeding indices.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= target&lt; 0, target + array.length is used.</para>
    /// <para>If target &lt; -array.length, 0 is used.</para>
    /// <para>If target >= array.length, nothing is copied.</para>
    /// <para>If target is positioned after start after normalization, copying only happens until the end of array.length (in other words, copyWithin() never extends the array).</para>
    /// </param>
    /// <param name="start">
    /// Zero-based index at which to start copying elements from, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length, 0 is used.</para>
    /// <para>If start >= array.length, nothing is copied.</para>
    /// </param>
    /// <returns>The modified array.</returns>
    public static ObjBuilder<Array> copyWithin(
        this ObjBuilder<Array> b,
        Var<int> target,
        Var<int> start)
    {
        return b.Call<Array>(nameof(copyWithin), target, start);
    }

    /// <summary>
    /// The entries() method of Array instances returns a new array iterator object that contains the key/value pairs for each index in the array.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new iterable iterator object.</returns>
    public static ObjBuilder<object> entries(this ObjBuilder<Array> b)
    {
        return b.Call<object>(nameof(entries));
    }

    /// <summary>
    /// The every() method of Array instances returns false if it finds an element in the array that does not satisfy the provided testing function. Otherwise, it returns true.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate the element passes the test, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array every() was called upon.</para>
    /// </param>
    /// <returns>true unless callbackFn returns a falsy value for an array element, in which case false is immediately returned.</returns>
    public static ObjBuilder<bool> every<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<bool>(nameof(every), callbackFn);
    }

    /// <summary>
    /// The every() method of Array instances returns false if it finds an element in the array that does not satisfy the provided testing function. Otherwise, it returns true.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate the element passes the test, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>true unless callbackFn returns a falsy value for an array element, in which case false is immediately returned.</returns>
    public static ObjBuilder<bool> every<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<bool>(nameof(every), callbackFn);
    }

    /// <summary>
    /// The every() method of Array instances returns false if it finds an element in the array that does not satisfy the provided testing function. Otherwise, it returns true.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate the element passes the test, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>true unless callbackFn returns a falsy value for an array element, in which case false is immediately returned.</returns>
    public static ObjBuilder<bool> every<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<bool>(nameof(every), callbackFn);
    }

    /// <summary>
    /// The fill() method of Array instances changes all elements within a range of indices in an array to a static value. It returns the modified array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="value">Value to fill the array with. Note all elements in the array will be this exact value: if value is an object, each slot in the array will reference that object.</param>
    /// <param name="start">Zero-based index at which to start filling, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, no index is filled.</para>
    /// </param>
    /// <param name="end">Zero-based index at which to end filling, converted to an integer. fill() fills up to but not including end.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= end&lt; 0, end + array.length is used.</para>
    /// <para>If end&lt; -array.length, 0 is used.</para>
    /// <para>If end >= array.length or end is omitted or undefined, array.length is used, causing all indices until the end to be filled.</para>
    /// <para>If end implies a position before or at the position that start implies, nothing is filled.</para>
    /// </param>
    /// <returns>The modified array, filled with value.</returns>
    public static ObjBuilder<Array> fill(
        this ObjBuilder<Array> b,
        IVariable value,
        Var<int> start,
        Var<int> end)
    {
        return b.Call<Array>(nameof(fill), value, start, end);
    }

    /// <summary>
    /// The fill() method of Array instances changes all elements within a range of indices in an array to a static value. It returns the modified array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="value">Value to fill the array with. Note all elements in the array will be this exact value: if value is an object, each slot in the array will reference that object.</param>
    /// <param name="start">Zero-based index at which to start filling, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, no index is filled.</para>
    /// </param>
    /// <returns>The modified array, filled with value.</returns>
    public static ObjBuilder<Array> fill(
        this ObjBuilder<Array> b,
        IVariable value,
        Var<int> start)
    {
        return b.Call<Array>(nameof(fill), value, start);
    }

    /// <summary>
    /// The fill() method of Array instances changes all elements within a range of indices in an array to a static value. It returns the modified array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="value">Value to fill the array with. Note all elements in the array will be this exact value: if value is an object, each slot in the array will reference that object.</param>
    /// <returns>The modified array, filled with value.</returns>
    public static ObjBuilder<Array> fill(
        this ObjBuilder<Array> b,
        IVariable value)
    {
        return b.Call<Array>(nameof(fill), value);
    }

    /// <summary>
    /// The filter() method of Array instances creates a shallow copy of a portion of a given array, filtered down to just the elements from the given array that pass the test implemented by the provided function.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to keep the element in the resulting array, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array filter() was called upon.</para>
    /// </param>
    /// <returns>A shallow copy of the given array containing just the elements that pass the test. If no elements pass the test, an empty array is returned.</returns>
    public static ObjBuilder<Array> filter<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<Array>(nameof(filter), callbackFn);
    }

    /// <summary>
    /// The filter() method of Array instances creates a shallow copy of a portion of a given array, filtered down to just the elements from the given array that pass the test implemented by the provided function.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to keep the element in the resulting array, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>A shallow copy of the given array containing just the elements that pass the test. If no elements pass the test, an empty array is returned.</returns>
    public static ObjBuilder<Array> filter<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<Array>(nameof(filter), callbackFn);
    }

    /// <summary>
    /// The filter() method of Array instances creates a shallow copy of a portion of a given array, filtered down to just the elements from the given array that pass the test implemented by the provided function.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to keep the element in the resulting array, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>A shallow copy of the given array containing just the elements that pass the test. If no elements pass the test, an empty array is returned.</returns>
    public static ObjBuilder<Array> filter<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<Array>(nameof(filter), callbackFn);
    }

    /// <summary>
    /// The find() method of Array instances returns the first element in the provided array that satisfies the provided testing function. If no values satisfy the testing function, undefined is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array find() was called upon.</para>
    /// </param>
    /// <returns>The first element in the array that satisfies the provided testing function. Otherwise, undefined is returned.</returns>
    public static ObjBuilder<TItem> find<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<TItem>(nameof(find), callbackFn);
    }

    /// <summary>
    /// The find() method of Array instances returns the first element in the provided array that satisfies the provided testing function. If no values satisfy the testing function, undefined is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>The first element in the array that satisfies the provided testing function. Otherwise, undefined is returned.</returns>
    public static ObjBuilder<TItem> find<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<TItem>(nameof(find), callbackFn);
    }

    /// <summary>
    /// The find() method of Array instances returns the first element in the provided array that satisfies the provided testing function. If no values satisfy the testing function, undefined is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>The first element in the array that satisfies the provided testing function. Otherwise, undefined is returned.</returns>
    public static ObjBuilder<TItem> find<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<TItem>(nameof(find), callbackFn);
    }

    /// <summary>
    /// The findIndex() method of Array instances returns the index of the first element in an array that satisfies the provided testing function. If no elements satisfy the testing function, -1 is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array findIndex() was called upon.</para>
    /// </param>
    /// <returns>The index of the first element in the array that passes the test. Otherwise, -1.</returns>
    public static ObjBuilder<int> findIndex<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<int>(nameof(findIndex), callbackFn);
    }

    /// <summary>
    /// The findIndex() method of Array instances returns the index of the first element in an array that satisfies the provided testing function. If no elements satisfy the testing function, -1 is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>The index of the first element in the array that passes the test. Otherwise, -1.</returns>
    public static ObjBuilder<int> findIndex<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<int>(nameof(findIndex), callbackFn);
    }

    /// <summary>
    /// The findIndex() method of Array instances returns the index of the first element in an array that satisfies the provided testing function. If no elements satisfy the testing function, -1 is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>The index of the first element in the array that passes the test. Otherwise, -1.</returns>
    public static ObjBuilder<int> findIndex<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<int>(nameof(findIndex), callbackFn);
    }

    /// <summary>
    /// The findLast() method of Array instances iterates the array in reverse order and returns the value of the first element that satisfies the provided testing function. If no elements satisfy the testing function, undefined is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array findLast() was called upon.</para>
    /// </param>
    /// <returns>The last (highest-index) element in the array that satisfies the provided testing function; undefined if no matching element is found.</returns>
    public static ObjBuilder<TItem> findLast<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<TItem>(nameof(findLast), callbackFn);
    }

    /// <summary>
    /// The findLast() method of Array instances iterates the array in reverse order and returns the value of the first element that satisfies the provided testing function. If no elements satisfy the testing function, undefined is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>The last (highest-index) element in the array that satisfies the provided testing function; undefined if no matching element is found.</returns>
    public static ObjBuilder<TItem> findLast<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<TItem>(nameof(findLast), callbackFn);
    }

    /// <summary>
    /// The findLast() method of Array instances iterates the array in reverse order and returns the value of the first element that satisfies the provided testing function. If no elements satisfy the testing function, undefined is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>The last (highest-index) element in the array that satisfies the provided testing function; undefined if no matching element is found.</returns>
    public static ObjBuilder<TItem> findLast<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<TItem>(nameof(findLast), callbackFn);
    }

    /// <summary>
    /// The findLastIndex() method of Array instances iterates the array in reverse order and returns the index of the first element that satisfies the provided testing function. If no elements satisfy the testing function, -1 is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array findLastIndex() was called upon.</para>
    /// </param>
    /// <returns>The index of the last (highest-index) element in the array that passes the test. Otherwise -1 if no matching element is found.</returns>
    public static ObjBuilder<int> findLastIndex<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<int>(nameof(findLastIndex), callbackFn);
    }

    /// <summary>
    /// The findLastIndex() method of Array instances iterates the array in reverse order and returns the index of the first element that satisfies the provided testing function. If no elements satisfy the testing function, -1 is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>The index of the last (highest-index) element in the array that passes the test. Otherwise -1 if no matching element is found.</returns>
    public static ObjBuilder<int> findLastIndex<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<int>(nameof(findLastIndex), callbackFn);
    }

    /// <summary>
    /// The findLastIndex() method of Array instances iterates the array in reverse order and returns the index of the first element that satisfies the provided testing function. If no elements satisfy the testing function, -1 is returned.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. It should return a truthy value to indicate a matching element has been found, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>The index of the last (highest-index) element in the array that passes the test. Otherwise -1 if no matching element is found.</returns>
    public static ObjBuilder<int> findLastIndex<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<int>(nameof(findLastIndex), callbackFn);
    }

    /// <summary>
    /// The flat() method of Array instances creates a new array with all sub-array elements concatenated into it recursively up to the specified depth.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="depth">The depth level specifying how deep a nested array structure should be flattened. Defaults to 1.</param>
    /// <returns>A new array with the sub-array elements concatenated into it.</returns>
    public static ObjBuilder<Array> flat(
        this ObjBuilder<Array> b,
        Var<int> depth)
    {
        return b.Call<Array>(nameof(flat), depth);
    }

    /// <summary>
    /// The flat() method of Array instances creates a new array with all sub-array elements concatenated into it recursively up to the specified depth.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new array with the sub-array elements concatenated into it.</returns>
    public static ObjBuilder<Array> flat(
        this ObjBuilder<Array> b)
    {
        return b.Call<Array>(nameof(flat));
    }


    /// <summary>
    /// The flatMap() method of Array instances returns a new array formed by applying a given callback function to each element of the array, and then flattening the result by one level. It is identical to a map() followed by a flat() of depth 1 (arr.map(...args).flat()), but slightly more efficient than calling those two methods separately.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return an array containing new elements of the new array, or a single non-array value to be added to the new array. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array flatMap() was called upon.</para>
    /// </param>
    /// <returns>A new array with each element being the result of the callback function and flattened by a depth of 1.</returns>
    public static ObjBuilder<Array> flatMap<TMapIn, TMapOut>(
        this ObjBuilder<Array> b,
        Var<System.Func<TMapIn, int, Array, TMapOut>> callbackFn)
    {
        return b.Call<Array>(nameof(flatMap), callbackFn);
    }

    /// <summary>
    /// The flatMap() method of Array instances returns a new array formed by applying a given callback function to each element of the array, and then flattening the result by one level. It is identical to a map() followed by a flat() of depth 1 (arr.map(...args).flat()), but slightly more efficient than calling those two methods separately.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return an array containing new elements of the new array, or a single non-array value to be added to the new array. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>A new array with each element being the result of the callback function and flattened by a depth of 1.</returns>
    public static ObjBuilder<Array> flatMap<TMapIn, TMapOut>(
        this ObjBuilder<Array> b,
        Var<System.Func<TMapIn, int, TMapOut>> callbackFn)
    {
        return b.Call<Array>(nameof(flatMap), callbackFn);
    }

    /// <summary>
    /// The flatMap() method of Array instances returns a new array formed by applying a given callback function to each element of the array, and then flattening the result by one level. It is identical to a map() followed by a flat() of depth 1 (arr.map(...args).flat()), but slightly more efficient than calling those two methods separately.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return an array containing new elements of the new array, or a single non-array value to be added to the new array. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>A new array with each element being the result of the callback function and flattened by a depth of 1.</returns>
    public static ObjBuilder<Array> flatMap<TMapIn, TMapOut>(
        this ObjBuilder<Array> b,
        Var<System.Func<TMapIn, TMapOut>> callbackFn)
    {
        return b.Call<Array>(nameof(flatMap), callbackFn);
    }

    /// <summary>
    /// The forEach() method of Array instances executes a provided function once for each array element.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value is discarded. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array forEach() was called upon.</para>
    /// </param>
    public static void forEach<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Action<TItem, int, Array>> callbackFn)
    {
        b.Call(nameof(forEach), callbackFn);
    }

    /// <summary>
    /// The forEach() method of Array instances executes a provided function once for each array element.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value is discarded. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    public static void forEach<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Action<TItem, int>> callbackFn)
    {
        b.Call(nameof(forEach), callbackFn);
    }

    /// <summary>
    /// The forEach() method of Array instances executes a provided function once for each array element.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value is discarded. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    public static void forEach<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Action<TItem>> callbackFn)
    {
        b.Call(nameof(forEach), callbackFn);
    }

    /// <summary>
    /// The includes() method of Array instances determines whether an array includes a certain value among its entries, returning true or false as appropriate.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="searchElement">The value to search for.</param>
    /// <param name="fromIndex">
    /// Zero-based index at which to start searching, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= fromIndex&lt; 0, fromIndex + array.length is used.However, the array is still searched from front to back in this case.</para>
    /// <para>If fromIndex&lt; -array.length or fromIndex is omitted, 0 is used, causing the entire array to be searched.</para>
    /// <para>If fromIndex >= array.length, the array is not searched and false is returned.</para>
    /// </param>
    /// <returns>A boolean value which is true if the value searchElement is found within the array (or the part of the array indicated by the index fromIndex, if specified).</returns>
    public static ObjBuilder<bool> includes(
        this ObjBuilder<Array> b,
        IVariable searchElement,
        Var<int> fromIndex)
    {
        return b.Call<bool>(nameof(includes), searchElement, fromIndex);
    }

    /// <summary>
    /// The includes() method of Array instances determines whether an array includes a certain value among its entries, returning true or false as appropriate.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="searchElement">The value to search for.</param>
    /// <returns>A boolean value which is true if the value searchElement is found within the array (or the part of the array indicated by the index fromIndex, if specified).</returns>
    public static ObjBuilder<bool> includes(
        this ObjBuilder<Array> b,
        IVariable searchElement)
    {
        return b.Call<bool>(nameof(includes), searchElement);
    }

    /// <summary>
    /// The indexOf() method of Array instances returns the first index at which a given element can be found in the array, or -1 if it is not present.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="searchElement">Element to locate in the array.</param>
    /// <param name="fromIndex">Zero-based index at which to start searching, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= fromIndex&lt; 0, fromIndex + array.length is used.Note, the array is still searched from front to back in this case.</para>
    /// <para>If fromIndex&lt; -array.length or fromIndex is omitted, 0 is used, causing the entire array to be searched.</para>
    /// <para>If fromIndex >= array.length, the array is not searched and -1 is returned.</para>
    /// </param>
    /// <returns>The first index of searchElement in the array; -1 if not found.</returns>
    public static ObjBuilder<int> indexOf(
        this ObjBuilder<Array> b,
        IVariable searchElement,
        Var<int> fromIndex)
    {
        return b.Call<int>(nameof(indexOf), searchElement, fromIndex);
    }

    /// <summary>
    /// The indexOf() method of Array instances returns the first index at which a given element can be found in the array, or -1 if it is not present.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="searchElement">Element to locate in the array.</param>
    /// <returns>The first index of searchElement in the array; -1 if not found.</returns>
    public static ObjBuilder<int> indexOf(
        this ObjBuilder<Array> b,
        IVariable searchElement)
    {
        return b.Call<int>(nameof(indexOf), searchElement);
    }

    /// <summary>
    /// The join() method of Array instances creates and returns a new string by concatenating all of the elements in this array, separated by commas or a specified separator string. If the array has only one item, then that item will be returned without using the separator.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="separator">A string to separate each pair of adjacent elements of the array. If omitted, the array elements are separated with a comma (",").</param>
    /// <returns>A string with all array elements joined. If array.length is 0, the empty string is returned.</returns>
    public static ObjBuilder<string> join(
        this ObjBuilder<Array> b,
        Var<string> separator)
    {
        return b.Call<string>(nameof(join), separator);
    }

    /// <summary>
    /// The join() method of Array instances creates and returns a new string by concatenating all of the elements in this array, separated by commas or a specified separator string. If the array has only one item, then that item will be returned without using the separator.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A string with all array elements joined. If array.length is 0, the empty string is returned.</returns>
    public static ObjBuilder<string> join(
        this ObjBuilder<Array> b)
    {
        return b.Call<string>(nameof(join));
    }

    /// <summary>
    /// The keys() method of Array instances returns a new array iterator object that contains the keys for each index in the array.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new iterable iterator object.</returns>
    public static ObjBuilder<object> keys(
        this ObjBuilder<Array> b)
    {
        return b.Call<object>(nameof(keys));
    }

    /// <summary>
    /// The lastIndexOf() method of Array instances returns the last index at which a given element can be found in the array, or -1 if it is not present. The array is searched backwards, starting at fromIndex.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="searchElement">Element to locate in the array.</param>
    /// <param name="fromIndex">
    /// Zero-based index at which to start searching backwards, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= fromIndex&lt; 0, fromIndex + array.length is used.</para>
    /// <para>If fromIndex&lt; -array.length, the array is not searched and -1 is returned.You can think of it conceptually as starting at a nonexistent position before the beginning of the array and going backwards from there. There are no array elements on the way, so searchElement is never found.</para>
    /// <para>If fromIndex >= array.length or fromIndex is omitted or undefined, array.length - 1 is used, causing the entire array to be searched.You can think of it conceptually as starting at a nonexistent position beyond the end of the array and going backwards from there. It eventually reaches the real end position of the array, at which point it starts searching backwards through the actual array elements.</para>
    /// </param>
    /// <returns>The last index of searchElement in the array; -1 if not found.</returns>
    public static ObjBuilder<int> lastIndexOf(
        this ObjBuilder<Array> b,
        IVariable searchElement,
        Var<int> fromIndex)
    {
        return b.Call<int>(nameof(lastIndexOf), searchElement, fromIndex);
    }

    /// <summary>
    /// The lastIndexOf() method of Array instances returns the last index at which a given element can be found in the array, or -1 if it is not present. The array is searched backwards, starting at fromIndex.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="searchElement">Element to locate in the array.</param>
    /// <returns>The last index of searchElement in the array; -1 if not found.</returns>
    public static ObjBuilder<int> lastIndexOf(
        this ObjBuilder<Array> b,
        IVariable searchElement)
    {
        return b.Call<int>(nameof(lastIndexOf), searchElement);
    }

    /// <summary>
    /// The map() method of Array instances creates a new array populated with the results of calling a provided function on every element in the calling array.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value is added as a single element in the new array. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array map() was called upon.</para>
    /// </param>
    /// <returns>A new array with each element being the result of the callback function.</returns>
    public static ObjBuilder<Array> map<TMapIn, TMapOut>(
        this ObjBuilder<Array> b,
        Var<System.Func<TMapIn, int, Array, TMapOut>> callbackFn)
    {
        return b.Call<Array>(nameof(map), callbackFn);
    }

    /// <summary>
    /// The map() method of Array instances creates a new array populated with the results of calling a provided function on every element in the calling array.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value is added as a single element in the new array. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>A new array with each element being the result of the callback function.</returns>
    public static ObjBuilder<Array> map<TMapIn, TMapOut>(
        this ObjBuilder<Array> b,
        Var<System.Func<TMapIn, int, TMapOut>> callbackFn)
    {
        return b.Call<Array>(nameof(map), callbackFn);
    }

    /// <summary>
    /// The map() method of Array instances creates a new array populated with the results of calling a provided function on every element in the calling array.
    /// </summary>
    /// <typeparam name="TMapIn"></typeparam>
    /// <typeparam name="TMapOut"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value is added as a single element in the new array. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>A new array with each element being the result of the callback function.</returns>
    public static ObjBuilder<Array> map<TMapIn, TMapOut>(
        this ObjBuilder<Array> b,
        Var<System.Func<TMapIn, TMapOut>> callbackFn)
    {
        return b.Call<Array>(nameof(map), callbackFn);
    }

    /// <summary>
    /// The pop() method of Array instances removes the last element from an array and returns that element. This method changes the length of the array.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>The removed element from the array; undefined if the array is empty.</returns>
    public static ObjBuilder<TItem> pop<TItem>(
        this ObjBuilder<Array> b)
    {
        return b.Call<TItem>(nameof(pop));
    }

    /// <summary>
    /// The push() method of Array instances adds the specified elements to the end of an array and returns the new length of the array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="elements">The element(s) to add to the end of the array.</param>
    /// <returns>The new length property of the object upon which the method was called.</returns>
    public static ObjBuilder<int> push(
        this ObjBuilder<Array> b,
        params IVariable[] elements)
    {
        return b.Call<int>(nameof(push), elements);
    }

    /// <summary>
    /// The reduce() method of Array instances executes a user-supplied "reducer" callback function on each element of the array, in order, passing in the return value from the calculation on the preceding element. The final result of running the reducer across all elements of the array is a single value.
    /// The first time that the callback is run there is no "return value of the previous calculation". If supplied, an initial value may be used in its place.Otherwise the array element at index 0 is used as the initial value and iteration starts from the next element (index 1 instead of index 0).
    /// </summary>
    /// <typeparam name="TAcc"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduce(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is array[0].</para>
    /// <para>currentValue - The value of the current element.On the first call, its value is array[0] if initialValue is specified; otherwise its value is array[1].</para>
    /// <para>currentIndex - The index position of currentValue in the array.On the first call, its value is 0 if initialValue is specified, otherwise 1.</para>
    /// <para>array - The array reduce() was called upon.</para>
    /// </param>
    /// <param name="initialValue">A value to which accumulator is initialized the first time the callback is called. 
    /// If initialValue is specified, callbackFn starts executing with the first value in the array as currentValue. 
    /// If initialValue is not specified, accumulator is initialized to the first value in the array, and callbackFn starts executing with the second value in the array as currentValue. 
    /// In this case, if the array is empty (so that there's no first value to return as accumulator), an error is thrown.</param>
    /// <returns>The value that results from running the "reducer" callback function to completion over the entire array.</returns>
    public static ObjBuilder<TAcc> reduce<TAcc, TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TAcc, TItem, int, Array, TAcc>> callbackFn,
        Var<TAcc> initialValue)
    {
        return b.Call<TAcc>(nameof(reduce), callbackFn, initialValue);
    }

    /// <summary>
    /// The reduce() method of Array instances executes a user-supplied "reducer" callback function on each element of the array, in order, passing in the return value from the calculation on the preceding element. The final result of running the reducer across all elements of the array is a single value.
    /// The first time that the callback is run there is no "return value of the previous calculation". If supplied, an initial value may be used in its place.Otherwise the array element at index 0 is used as the initial value and iteration starts from the next element (index 1 instead of index 0).
    /// </summary>
    /// <typeparam name="TAcc"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduce(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is array[0].</para>
    /// <para>currentValue - The value of the current element.On the first call, its value is array[0] if initialValue is specified; otherwise its value is array[1].</para>
    /// <para>currentIndex - The index position of currentValue in the array.On the first call, its value is 0 if initialValue is specified, otherwise 1.</para>
    /// </param>
    /// <param name="initialValue">A value to which accumulator is initialized the first time the callback is called. 
    /// If initialValue is specified, callbackFn starts executing with the first value in the array as currentValue. 
    /// If initialValue is not specified, accumulator is initialized to the first value in the array, and callbackFn starts executing with the second value in the array as currentValue. 
    /// In this case, if the array is empty (so that there's no first value to return as accumulator), an error is thrown.</param>
    /// <returns>The value that results from running the "reducer" callback function to completion over the entire array.</returns>
    public static ObjBuilder<TAcc> reduce<TAcc, TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TAcc, TItem, int, TAcc>> callbackFn,
        Var<TAcc> initialValue)
    {
        return b.Call<TAcc>(nameof(reduce), callbackFn, initialValue);
    }

    /// <summary>
    /// The reduce() method of Array instances executes a user-supplied "reducer" callback function on each element of the array, in order, passing in the return value from the calculation on the preceding element. The final result of running the reducer across all elements of the array is a single value.
    /// The first time that the callback is run there is no "return value of the previous calculation". If supplied, an initial value may be used in its place.Otherwise the array element at index 0 is used as the initial value and iteration starts from the next element (index 1 instead of index 0).
    /// </summary>
    /// <typeparam name="TAcc"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduce(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is array[0].</para>
    /// <para>currentValue - The value of the current element.On the first call, its value is array[0] if initialValue is specified; otherwise its value is array[1].</para>
    /// </param>
    /// <param name="initialValue">A value to which accumulator is initialized the first time the callback is called. 
    /// If initialValue is specified, callbackFn starts executing with the first value in the array as currentValue. 
    /// If initialValue is not specified, accumulator is initialized to the first value in the array, and callbackFn starts executing with the second value in the array as currentValue. 
    /// In this case, if the array is empty (so that there's no first value to return as accumulator), an error is thrown.</param>
    /// <returns>The value that results from running the "reducer" callback function to completion over the entire array.</returns>
    public static ObjBuilder<TAcc> reduce<TAcc, TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TAcc, TItem, TAcc>> callbackFn,
        Var<TAcc> initialValue)
    {
        return b.Call<TAcc>(nameof(reduce), callbackFn, initialValue);
    }

    /// <summary>
    /// The reduce() method of Array instances executes a user-supplied "reducer" callback function on each element of the array, in order, passing in the return value from the calculation on the preceding element. The final result of running the reducer across all elements of the array is a single value.
    /// The first time that the callback is run there is no "return value of the previous calculation". If supplied, an initial value may be used in its place.Otherwise the array element at index 0 is used as the initial value and iteration starts from the next element (index 1 instead of index 0).
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduce(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is array[0].</para>
    /// <para>currentValue - The value of the current element.On the first call, its value is array[0] if initialValue is specified; otherwise its value is array[1].</para>
    /// <para>currentIndex - The index position of currentValue in the array.On the first call, its value is 0 if initialValue is specified, otherwise 1.</para>
    /// <para>array - The array reduce() was called upon.</para>
    /// </param>
    /// <returns>The value that results from running the "reducer" callback function to completion over the entire array.</returns>
    public static ObjBuilder<TItem> reduce<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, int, Array, TItem>> callbackFn)
    {
        return b.Call<TItem>(nameof(reduce), callbackFn);
    }

    /// <summary>
    /// The reduce() method of Array instances executes a user-supplied "reducer" callback function on each element of the array, in order, passing in the return value from the calculation on the preceding element. The final result of running the reducer across all elements of the array is a single value.
    /// The first time that the callback is run there is no "return value of the previous calculation". If supplied, an initial value may be used in its place.Otherwise the array element at index 0 is used as the initial value and iteration starts from the next element (index 1 instead of index 0).
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduce(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is array[0].</para>
    /// <para>currentValue - The value of the current element.On the first call, its value is array[0] if initialValue is specified; otherwise its value is array[1].</para>
    /// <para>currentIndex - The index position of currentValue in the array.On the first call, its value is 0 if initialValue is specified, otherwise 1.</para>
    /// </param>
    /// <returns>The value that results from running the "reducer" callback function to completion over the entire array.</returns>
    public static ObjBuilder<TItem> reduce<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, int, TItem>> callbackFn)
    {
        return b.Call<TItem>(nameof(reduce), callbackFn);
    }

    /// <summary>
    /// The reduce() method of Array instances executes a user-supplied "reducer" callback function on each element of the array, in order, passing in the return value from the calculation on the preceding element. The final result of running the reducer across all elements of the array is a single value.
    /// The first time that the callback is run there is no "return value of the previous calculation". If supplied, an initial value may be used in its place.Otherwise the array element at index 0 is used as the initial value and iteration starts from the next element (index 1 instead of index 0).
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduce(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is array[0].</para>
    /// <para>currentValue - The value of the current element.On the first call, its value is array[0] if initialValue is specified; otherwise its value is array[1].</para>
    /// </param>
    /// <returns>The value that results from running the "reducer" callback function to completion over the entire array.</returns>
    public static ObjBuilder<TItem> reduce<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, TItem>> callbackFn)
    {
        return b.Call<TItem>(nameof(reduce), callbackFn);
    }

    /// <summary>
    /// The reduceRight() method of Array instances applies a function against an accumulator and each value of the array (from right-to-left) to reduce it to a single value.
    /// </summary>
    /// <typeparam name="TAcc"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduceRight(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is the last element of the array.</para>
    /// <para>currentValue - The value of the current element. On the first call, its value is the last element if initialValue is specified; otherwise its value is the second-to-last element.</para>
    /// <para>currentIndex - The index position of currentValue in the array. On the first call, its value is array.length - 1 if initialValue is specified, otherwise array.length - 2.</para>
    /// <para>array - The array reduceRight() was called upon.</para>
    /// </param>
    /// <param name="initialValue">Value to use as accumulator to the first call of the callbackFn. If no initial value is supplied, the last element in the array will be used and skipped. Calling reduceRight() on an empty array without an initial value creates a TypeError.</param>
    /// <returns>The value that results from the reduction.</returns>
    public static ObjBuilder<TAcc> reduceRight<TAcc, TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TAcc, TItem, int, Array, TAcc>> callbackFn,
        Var<TAcc> initialValue)
    {
        return b.Call<TAcc>(nameof(reduceRight), callbackFn, initialValue);
    }

    /// <summary>
    /// The reduceRight() method of Array instances applies a function against an accumulator and each value of the array (from right-to-left) to reduce it to a single value.
    /// </summary>
    /// <typeparam name="TAcc"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduceRight(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is the last element of the array.</para>
    /// <para>currentValue - The value of the current element. On the first call, its value is the last element if initialValue is specified; otherwise its value is the second-to-last element.</para>
    /// <para>currentIndex - The index position of currentValue in the array. On the first call, its value is array.length - 1 if initialValue is specified, otherwise array.length - 2.</para>
    /// </param>
    /// <param name="initialValue">Value to use as accumulator to the first call of the callbackFn. If no initial value is supplied, the last element in the array will be used and skipped. Calling reduceRight() on an empty array without an initial value creates a TypeError.</param>
    /// <returns>The value that results from the reduction.</returns>
    public static ObjBuilder<TAcc> reduceRight<TAcc, TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TAcc, TItem, int, TAcc>> callbackFn,
        Var<TAcc> initialValue)
    {
        return b.Call<TAcc>(nameof(reduceRight), callbackFn, initialValue);
    }

    /// <summary>
    /// The reduceRight() method of Array instances applies a function against an accumulator and each value of the array (from right-to-left) to reduce it to a single value.
    /// </summary>
    /// <typeparam name="TAcc"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduceRight(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is the last element of the array.</para>
    /// <para>currentValue - The value of the current element. On the first call, its value is the last element if initialValue is specified; otherwise its value is the second-to-last element.</para>
    /// </param>
    /// <param name="initialValue">Value to use as accumulator to the first call of the callbackFn. If no initial value is supplied, the last element in the array will be used and skipped. Calling reduceRight() on an empty array without an initial value creates a TypeError.</param>
    /// <returns>The value that results from the reduction.</returns>
    public static ObjBuilder<TAcc> reduceRight<TAcc, TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TAcc, TItem, TAcc>> callbackFn,
        Var<TAcc> initialValue)
    {
        return b.Call<TAcc>(nameof(reduceRight), callbackFn, initialValue);
    }

    /// <summary>
    /// The reduceRight() method of Array instances applies a function against an accumulator and each value of the array (from right-to-left) to reduce it to a single value.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduceRight(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is the last element of the array.</para>
    /// <para>currentValue - The value of the current element. On the first call, its value is the last element if initialValue is specified; otherwise its value is the second-to-last element.</para>
    /// <para>currentIndex - The index position of currentValue in the array. On the first call, its value is array.length - 1 if initialValue is specified, otherwise array.length - 2.</para>
    /// <para>array - The array reduceRight() was called upon.</para>
    /// </param>
    /// <returns>The value that results from the reduction.</returns>
    public static ObjBuilder<TItem> reduceRight<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, int, Array, TItem>> callbackFn)
    {
        return b.Call<TItem>(nameof(reduceRight), callbackFn);
    }

    /// <summary>
    /// The reduceRight() method of Array instances applies a function against an accumulator and each value of the array (from right-to-left) to reduce it to a single value.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduceRight(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is the last element of the array.</para>
    /// <para>currentValue - The value of the current element. On the first call, its value is the last element if initialValue is specified; otherwise its value is the second-to-last element.</para>
    /// <para>currentIndex - The index position of currentValue in the array. On the first call, its value is array.length - 1 if initialValue is specified, otherwise array.length - 2.</para>
    /// </param>
    /// <returns>The value that results from the reduction.</returns>
    public static ObjBuilder<TItem> reduceRight<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, int, TItem>> callbackFn)
    {
        return b.Call<TItem>(nameof(reduceRight), callbackFn);
    }

    /// <summary>
    /// The reduceRight() method of Array instances applies a function against an accumulator and each value of the array (from right-to-left) to reduce it to a single value.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">A function to execute for each element in the array. Its return value becomes the value of the accumulator parameter on the next invocation of callbackFn. For the last invocation, the return value becomes the return value of reduceRight(). The function is called with the following arguments:
    /// <para>accumulator - The value resulting from the previous call to callbackFn.On the first call, its value is initialValue if the latter is specified; otherwise its value is the last element of the array.</para>
    /// <para>currentValue - The value of the current element. On the first call, its value is the last element if initialValue is specified; otherwise its value is the second-to-last element.</para>
    /// </param>
    /// <returns>The value that results from the reduction.</returns>
    public static ObjBuilder<TItem> reduceRight<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, TItem>> callbackFn)
    {
        return b.Call<TItem>(nameof(reduceRight), callbackFn);
    }

    /// <summary>
    /// The reverse() method of Array instances reverses an array in place and returns the reference to the same array, the first array element now becoming the last, and the last array element becoming the first. In other words, elements order in the array will be turned towards the direction opposite to that previously stated.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>The reference to the original array, now reversed. Note that the array is reversed in place, and no copy is made.</returns>
    public static ObjBuilder<Array> reverse(
        this ObjBuilder<Array> b)
    {
        return b.Call<Array>(nameof(reverse));
    }

    /// <summary>
    /// The shift() method of Array instances removes the first element from an array and returns that removed element. This method changes the length of the array.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>The removed element from the array; undefined if the array is empty.</returns>
    public static ObjBuilder<TItem> shift<TItem>(
        this ObjBuilder<Array> b)
    {
        return b.Call<TItem>(nameof(shift));
    }

    /// <summary>
    /// The slice() method of Array instances returns a shallow copy of a portion of an array into a new array object selected from start to end (end not included) where start and end represent the index of items in that array. The original array will not be modified.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">Zero-based index at which to start extraction, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, an empty array is returned.</para>
    /// </param>
    /// <param name="end">Zero-based index at which to end extraction, converted to an integer. slice() extracts up to but not including end.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= end&lt; 0, end + array.length is used.</para>
    /// <para>If end&lt; -array.length, 0 is used.</para>
    /// <para>If end >= array.length or end is omitted or undefined, array.length is used, causing all elements until the end to be extracted.</para>
    /// <para>If end implies a position before or at the position that start implies, an empty array is returned.</para>
    /// </param>
    /// <returns>A new array containing the extracted elements.</returns>
    public static ObjBuilder<Array> slice(
        this ObjBuilder<Array> b,
        Var<int> start,
        Var<int> end)
    {
        return b.Call<Array>(nameof(slice), start, end);
    }

    /// <summary>
    /// The slice() method of Array instances returns a shallow copy of a portion of an array into a new array object selected from start to end (end not included) where start and end represent the index of items in that array. The original array will not be modified.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">Zero-based index at which to start extraction, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, an empty array is returned.</para>
    /// </param>
    /// <returns>A new array containing the extracted elements.</returns>
    public static ObjBuilder<Array> slice(
        this ObjBuilder<Array> b,
        Var<int> start)
    {
        return b.Call<Array>(nameof(slice), start);
    }

    /// <summary>
    /// The slice() method of Array instances returns a shallow copy of a portion of an array into a new array object selected from start to end (end not included) where start and end represent the index of items in that array. The original array will not be modified.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new array containing the extracted elements.</returns>
    public static ObjBuilder<Array> slice(
        this ObjBuilder<Array> b)
    {
        return b.Call<Array>(nameof(slice));
    }

    /// <summary>
    /// The some() method of Array instances returns true if it finds an element in the array that satisfies the provided testing function. Otherwise, it returns false.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return a truthy value to indicate the element passes the test, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// <para>array - The array some() was called upon.</para>
    /// </param>
    /// <returns>false unless callbackFn returns a truthy value for an array element, in which case true is immediately returned.</returns>
    public static ObjBuilder<bool> some<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, Array, bool>> callbackFn)
    {
        return b.Call<bool>(nameof(some), callbackFn);
    }

    /// <summary>
    /// The some() method of Array instances returns true if it finds an element in the array that satisfies the provided testing function. Otherwise, it returns false.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return a truthy value to indicate the element passes the test, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// <para>index - The index of the current element being processed in the array.</para>
    /// </param>
    /// <returns>false unless callbackFn returns a truthy value for an array element, in which case true is immediately returned.</returns>
    public static ObjBuilder<bool> some<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, int, bool>> callbackFn)
    {
        return b.Call<bool>(nameof(some), callbackFn);
    }

    /// <summary>
    /// The some() method of Array instances returns true if it finds an element in the array that satisfies the provided testing function. Otherwise, it returns false.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="callbackFn">
    /// A function to execute for each element in the array. It should return a truthy value to indicate the element passes the test, and a falsy value otherwise. The function is called with the following arguments:
    /// <para>element - The current element being processed in the array.</para>
    /// </param>
    /// <returns>false unless callbackFn returns a truthy value for an array element, in which case true is immediately returned.</returns>
    public static ObjBuilder<bool> some<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, bool>> callbackFn)
    {
        return b.Call<bool>(nameof(some), callbackFn);
    }

    /// <summary>
    /// The sort() method of Array instances sorts the elements of an array in place and returns the reference to the same array, now sorted. The default sort order is ascending, built upon converting the elements into strings, then comparing their sequences of UTF-16 code unit values.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="compareFn">A function that determines the order of the elements. The function is called with the following arguments:
    /// <para>a - The first element for comparison.Will never be undefined.</para>
    /// <para>b - The second element for comparison.Will never be undefined.</para>
    /// It should return a number where:
    /// <para>A negative value indicates that a should come before b.</para>
    /// <para>A positive value indicates that a should come after b.</para>
    /// <para>Zero or NaN indicates that a and b are considered equal.</para>
    /// If omitted, the array elements are converted to strings, then sorted according to each character's Unicode code point value.</param>
    /// <returns>The reference to the original array, now sorted. Note that the array is sorted in place, and no copy is made.</returns>
    public static ObjBuilder<Array> sort<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, int>> compareFn)
    {
        return b.Call<Array>(nameof(sort), compareFn);
    }

    /// <summary>
    /// The sort() method of Array instances sorts the elements of an array in place and returns the reference to the same array, now sorted. The default sort order is ascending, built upon converting the elements into strings, then comparing their sequences of UTF-16 code unit values.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>The reference to the original array, now sorted. Note that the array is sorted in place, and no copy is made.</returns>
    public static ObjBuilder<Array> sort(
        this ObjBuilder<Array> b)
    {
        return b.Call<Array>(nameof(sort));
    }

    /// <summary>
    /// The splice() method of Array instances changes the contents of an array by removing or replacing existing elements and/or adding new elements in place.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">
    /// Zero-based index at which to start changing the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length, 0 is used.</para>
    /// <para>If start >= array.length, no element will be deleted, but the method will behave as an adding function, adding as many elements as provided.</para>
    /// <para>If start is omitted (and splice() is called with no arguments), nothing is deleted.This is different from passing undefined, which is converted to 0.</para>
    /// </param>
    /// <param name="deleteCount">
    /// An integer indicating the number of elements in the array to remove from start.
    /// <para>If deleteCount is omitted, or if its value is greater than or equal to the number of elements after the position specified by start, then all the elements from start to the end of the array will be deleted.However, if you wish to pass any itemN parameter, you should pass Infinity as deleteCount to delete all elements after start, because an explicit undefined gets converted to 0.</para>
    /// <para>If deleteCount is 0 or negative, no elements are removed. In this case, you should specify at least one new element(see below).</para>
    /// </param>
    /// <param name="items">The elements to add to the array, beginning from start.
    /// If you do not specify any elements, splice() will only remove elements from the array.</param>
    /// <returns>An array containing the deleted elements.
    /// If only one element is removed, an array of one element is returned.
    /// If no elements are removed, an empty array is returned.</returns>
    public static ObjBuilder<Array> splice(
        this ObjBuilder<Array> b,
        Var<int> start,
        Var<int> deleteCount,
        params IVariable[] items)
    {
        List<IVariable> allArguments = new() { start, deleteCount };
        allArguments.AddRange(items);
        return b.Call<Array>(nameof(splice), items.ToArray());
    }

    /// <summary>
    /// The splice() method of Array instances changes the contents of an array by removing or replacing existing elements and/or adding new elements in place.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">
    /// Zero-based index at which to start changing the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length, 0 is used.</para>
    /// <para>If start >= array.length, no element will be deleted, but the method will behave as an adding function, adding as many elements as provided.</para>
    /// <para>If start is omitted (and splice() is called with no arguments), nothing is deleted.This is different from passing undefined, which is converted to 0.</para>
    /// </param>
    /// <param name="deleteCount">
    /// An integer indicating the number of elements in the array to remove from start.
    /// <para>If deleteCount is omitted, or if its value is greater than or equal to the number of elements after the position specified by start, then all the elements from start to the end of the array will be deleted.However, if you wish to pass any itemN parameter, you should pass Infinity as deleteCount to delete all elements after start, because an explicit undefined gets converted to 0.</para>
    /// <para>If deleteCount is 0 or negative, no elements are removed. In this case, you should specify at least one new element(see below).</para>
    /// </param>
    /// <returns>An array containing the deleted elements.
    /// If only one element is removed, an array of one element is returned.
    /// If no elements are removed, an empty array is returned.</returns>
    public static ObjBuilder<Array> splice(
        this ObjBuilder<Array> b,
        Var<int> start,
        Var<int> deleteCount)
    {
        return b.Call<Array>(nameof(splice), start, deleteCount);
    }

    /// <summary>
    /// The splice() method of Array instances changes the contents of an array by removing or replacing existing elements and/or adding new elements in place.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">
    /// Zero-based index at which to start changing the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length, 0 is used.</para>
    /// <para>If start >= array.length, no element will be deleted, but the method will behave as an adding function, adding as many elements as provided.</para>
    /// <para>If start is omitted (and splice() is called with no arguments), nothing is deleted.This is different from passing undefined, which is converted to 0.</para>
    /// </param>
    /// <returns>An array containing the deleted elements.
    /// If only one element is removed, an array of one element is returned.
    /// If no elements are removed, an empty array is returned.</returns>
    public static ObjBuilder<Array> splice(
        this ObjBuilder<Array> b,
        Var<int> start)
    {
        return b.Call<Array>(nameof(splice), start);
    }

    /// <summary>
    /// The toLocaleString() method of Array instances returns a string representing the elements of the array. The elements are converted to strings using their toLocaleString methods and these strings are separated by a locale-specific string (such as a comma ",").
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag, or an array of such strings.</param>
    /// <param name="options">An object with configuration properties.</param>
    /// <returns>A string representing the elements of the array.</returns>
    public static ObjBuilder<string> toLocaleString(
        this ObjBuilder<Array> b,
        IVariable locales,
        IVariable options)
    {
        return b.Call<string>(nameof(toLocaleString), locales, options);
    }

    /// <summary>
    /// The toLocaleString() method of Array instances returns a string representing the elements of the array. The elements are converted to strings using their toLocaleString methods and these strings are separated by a locale-specific string (such as a comma ",").
    /// </summary>
    /// <param name="b"></param>
    /// <param name="locales">A string with a BCP 47 language tag, or an array of such strings.</param>
    /// <returns>A string representing the elements of the array.</returns>
    public static ObjBuilder<string> toLocaleString(
        this ObjBuilder<Array> b,
        IVariable locales)
    {
        return b.Call<string>(nameof(toLocaleString), locales);
    }

    /// <summary>
    /// The toLocaleString() method of Array instances returns a string representing the elements of the array. The elements are converted to strings using their toLocaleString methods and these strings are separated by a locale-specific string (such as a comma ",").
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A string representing the elements of the array.</returns>
    public static ObjBuilder<string> toLocaleString(
        this ObjBuilder<Array> b)
    {
        return b.Call<string>(nameof(toLocaleString));
    }

    /// <summary>
    /// The toReversed() method of Array instances is the copying counterpart of the reverse() method. It returns a new array with the elements in reversed order.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new array containing the elements in reversed order.</returns>
    public static ObjBuilder<Array> toReversed(
        this ObjBuilder<Array> b)
    {
        return b.Call<Array>(nameof(toReversed));
    }

    /// <summary>
    /// The toSorted() method of Array instances is the copying version of the sort() method. It returns a new array with the elements sorted in ascending order.
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    /// <param name="b"></param>
    /// <param name="compareFn">A function that determines the order of the elements. The function is called with the following arguments:
    /// <para>a - The first element for comparison.Will never be undefined.</para>
    /// <para>b - The second element for comparison.Will never be undefined.</para>
    /// It should return a number where:
    /// <para>A negative value indicates that a should come before b.</para>
    /// <para>A positive value indicates that a should come after b.</para>
    /// <para>Zero or NaN indicates that a and b are considered equal.</para>
    /// If omitted, the array elements are converted to strings, then sorted according to each character's Unicode code point value.</param>
    /// <returns>A new array with the elements sorted in ascending order.</returns>
    public static ObjBuilder<Array> toSorted<TItem>(
        this ObjBuilder<Array> b,
        Var<System.Func<TItem, TItem, int>> compareFn)
    {
        return b.Call<Array>(nameof(toSorted), compareFn);
    }

    /// <summary>
    /// The toSorted() method of Array instances is the copying version of the sort() method. It returns a new array with the elements sorted in ascending order.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new array with the elements sorted in ascending order.</returns>
    public static ObjBuilder<Array> toSorted(
        this ObjBuilder<Array> b)
    {
        return b.Call<Array>(nameof(toSorted));
    }

    /// <summary>
    /// The toSpliced() method of Array instances is the copying version of the splice() method. It returns a new array with some elements removed and/or replaced at a given index.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">
    /// Zero-based index at which to start changing the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, no element will be deleted, but the method will behave as an adding function, adding as many elements as provided.</para>
    /// </param>
    /// <param name="skipCount">
    /// An integer indicating the number of elements in the array to remove (or, to skip) from start.
    /// <para>If skipCount is omitted, or if its value is greater than or equal to the number of elements after the position specified by start, then all the elements from start to the end of the array will be deleted.However, if you wish to pass any itemN parameter, you should pass Infinity as skipCount to delete all elements after start, because an explicit undefined gets converted to 0.</para>
    /// <para>If skipCount is 0 or negative, no elements are removed. In this case, you should specify at least one new element(see below).</para>
    /// </param>
    /// <param name="items">The elements to add to the array, beginning from start.
    /// If you do not specify any elements, toSpliced() will only remove elements from the array.</param>
    /// <returns>A new array that consists of all elements before start, item1, item2, …, itemN, and all elements after start + skipCount.</returns>
    public static ObjBuilder<Array> toSpliced(
        this ObjBuilder<Array> b,
        Var<int> start,
        Var<int> skipCount,
        params IVariable[] items)
    {
        List<IVariable> allArguments = new() { start, skipCount };
        allArguments.AddRange(items);
        return b.Call<Array>(nameof(toSpliced), items.ToArray());
    }

    /// <summary>
    /// The toSpliced() method of Array instances is the copying version of the splice() method. It returns a new array with some elements removed and/or replaced at a given index.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">
    /// Zero-based index at which to start changing the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, no element will be deleted, but the method will behave as an adding function, adding as many elements as provided.</para>
    /// </param>
    /// <param name="skipCount">
    /// An integer indicating the number of elements in the array to remove (or, to skip) from start.
    /// <para>If skipCount is omitted, or if its value is greater than or equal to the number of elements after the position specified by start, then all the elements from start to the end of the array will be deleted.However, if you wish to pass any itemN parameter, you should pass Infinity as skipCount to delete all elements after start, because an explicit undefined gets converted to 0.</para>
    /// <para>If skipCount is 0 or negative, no elements are removed. In this case, you should specify at least one new element(see below).</para>
    /// </param>
    /// <returns>A new array that consists of all elements before start, item1, item2, …, itemN, and all elements after start + skipCount.</returns>
    public static ObjBuilder<Array> toSpliced(
        this ObjBuilder<Array> b,
        Var<int> start,
        Var<int> skipCount)
    {
        return b.Call<Array>(nameof(toSpliced), start, skipCount);
    }

    /// <summary>
    /// The toSpliced() method of Array instances is the copying version of the splice() method. It returns a new array with some elements removed and/or replaced at a given index.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="start">
    /// Zero-based index at which to start changing the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length &lt;= start&lt; 0, start + array.length is used.</para>
    /// <para>If start&lt; -array.length or start is omitted, 0 is used.</para>
    /// <para>If start >= array.length, no element will be deleted, but the method will behave as an adding function, adding as many elements as provided.</para>
    /// </param>
    /// <returns>A new array that consists of all elements before start, item1, item2, …, itemN, and all elements after start + skipCount.</returns>
    public static ObjBuilder<Array> toSpliced(
        this ObjBuilder<Array> b,
        Var<int> start)
    {
        return b.Call<Array>(nameof(toSpliced), start);
    }

    /// <summary>
    /// The toString() method of Array instances returns a string representing the specified array and its elements.
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static ObjBuilder<string> toString(
        this ObjBuilder<Array> b)
    {
        return b.Call<string>(nameof(toString));
    }

    /// <summary>
    /// The unshift() method of Array instances adds the specified elements to the beginning of an array and returns the new length of the array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="elements">The elements to add to the front of the array.</param>
    /// <returns>The new length property of the object upon which the method was called.</returns>
    public static ObjBuilder<int> unshift(
        this ObjBuilder<Array> b,
        params IVariable[] elements)
    {
        return b.Call<int>(nameof(unshift), elements);
    }

    /// <summary>
    /// The values() method of Array instances returns a new array iterator object that iterates the value of each item in the array.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A new iterable iterator object.</returns>
    public static ObjBuilder<object> values(
        this ObjBuilder<Array> b)
    {
        return b.Call<object>(nameof(values));
    }

    /// <summary>
    /// The with() method of Array instances is the copying version of using the bracket notation to change the value of a given index. It returns a new array with the element at the given index replaced with the given value.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="index">Zero-based index at which to change the array, converted to an integer.
    /// <para>Negative index counts back from the end of the array — if -array.length <= index< 0, index + array.length is used.</para>
    /// <para>If the index after normalization is out of bounds, a RangeError is thrown.</para>
    /// </param>
    /// <param name="value">Any value to be assigned to the given index.</param>
    /// <returns>A new array with the element at index replaced with value.</returns>
    public static ObjBuilder<Array> with(
        this ObjBuilder<Array> b,
        Var<int> index,
        IVariable value)
    {
        return b.Call<Array>(nameof(with), index, value);
    }

    // =================================================================
    // vvv The next methods are old style, working directly on lists vvv


    /// <summary>
    /// The Array.from() static method creates a new, shallow-copied Array instance from an iterable or array-like object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="arrayLike"></param>
    /// <returns></returns>
    public static Var<List<T>> ArrayFrom<T>(this SyntaxBuilder b, IVariable arrayLike)
    {
        return b.CallOnObject<List<T>>(b.GetProperty<object>(b.Self(), "Array"), "from", arrayLike);
    }

    public static Var<List<T>> ArrayFilter<T>(this SyntaxBuilder b, Var<List<T>> collection, Var<Func<T, int, List<T>, bool>> filter)
    {
        return b.CallOnObject<List<T>>(collection, "filter", filter);
    }

    public static Var<List<T>> ArrayFilter<T>(this SyntaxBuilder b, Var<List<T>> collection, Func<SyntaxBuilder, Var<T>, Var<int>, Var<List<T>>, Var<bool>> filter)
    {
        return b.CallOnObject<List<T>>(collection, "filter", b.Def(filter));
    }
}