using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The IntersectionObserver interface of the Intersection Observer API provides a way to asynchronously observe changes in the intersection of a target element with an ancestor element or with a top-level document's viewport. The ancestor element or viewport is referred to as the root.
/// When an IntersectionObserver is created, it's configured to watch for given ratios of visibility within the root. The configuration cannot be changed once the IntersectionObserver is created, so a given observer object is only useful for watching for specific changes in degree of visibility; however, you can watch multiple target elements with the same observer.
/// </summary>
public interface IntersectionObserver
{
    /// <summary>
    /// The root read-only property of the IntersectionObserver interface identifies the Element or Document whose bounds are treated as the bounding box of the viewport for the element which is the observer's target.
    /// If the root is null, then the bounds of the actual document viewport are used.
    /// </summary>
    Node root { get; }

    /// <summary>
    /// A string, formatted similarly to the CSS margin property's value, which contains offsets for one or more sides of the root's bounding box. These offsets are added to the corresponding values in the root's bounding box before the intersection between the resulting rectangle and the target element's bounds.
    /// The string returned by this property may not match the one specified when the IntersectionObserver was instantiated. For example, the result always contains four components, though the input may have fewer.
    /// If rootMargin isn't specified when the object was instantiated, it defaults to the string "0px 0px 0px 0px", meaning that the intersection will be computed between the root element's unmodified bounds rectangle and the target's bounds
    /// </summary>
    string rootMargin { get; }

    /// <summary>
    /// A string, formatted similarly to the CSS margin property's value.
    /// The specified margin defines offsets for one or more sides of a scroll container clipping rectangle.If scrollMargin isn't specified when the object was instantiated, it defaults to the string "0px 0px 0px 0px".
    /// </summary>
    string scrollMargin { get; }

    /// <summary>
    /// An array of intersection thresholds, originally specified using the threshold property when instantiating the observer. If only one observer was specified, without being in an array, this value is a one-entry array containing that threshold. Regardless of the order your original threshold array was in, this one is always sorted in numerically increasing order.
    /// If no threshold option was included when IntersectionObserver() was used to instantiate the observer, the value of thresholds is [0].
    /// </summary>
    List<decimal> thresholds { get; }
}
