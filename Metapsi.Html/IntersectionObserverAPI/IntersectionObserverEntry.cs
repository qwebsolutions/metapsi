namespace Metapsi.Html;

/// <summary>
/// The IntersectionObserverEntry interface of the Intersection Observer API describes the intersection between the target element and its root container at a specific moment of transition.
/// Instances of IntersectionObserverEntry are delivered to an IntersectionObserver callback in its entries parameter; otherwise, these objects can only be obtained by calling IntersectionObserver.takeRecords().
/// </summary>
public interface IntersectionObserverEntry
{
    /// <summary>
    /// The boundingClientRect read-only property of the IntersectionObserverEntry interface returns a DOMRectReadOnly which in essence describes a rectangle describing the smallest rectangle that contains the entire target element.
    /// </summary>
    DOMRectReadOnly boundingClientRect { get; }

    /// <summary>
    /// The intersectionRatio read-only property of the IntersectionObserverEntry interface tells you how much of the target element is currently visible within the root's intersection ratio, as a value between 0.0 and 1.0.
    /// </summary>
    decimal intersectionRatio { get; }

    /// <summary>
    /// The intersectionRect read-only property of the IntersectionObserverEntry interface is a DOMRectReadOnly object which describes the smallest rectangle that contains the entire portion of the target element which is currently visible within the intersection root.
    /// </summary>
    DOMRectReadOnly intersectionRect { get; }

    /// <summary>
    /// The isIntersecting read-only property of the IntersectionObserverEntry interface is a Boolean value which is true if the target element intersects with the intersection observer's root.
    /// If this is true, then, the IntersectionObserverEntry describes a transition into a state of intersection; if it's false, then you know the transition is from intersecting to not-intersecting.
    /// </summary>
    bool isIntersecting { get; }

    /// <summary>
    /// The rootBounds read-only property of the IntersectionObserverEntry interface is a DOMRectReadOnly corresponding to the target's root intersection rectangle, offset by the IntersectionObserver.rootMargin if one is specified.
    /// </summary>
    DOMRectReadOnly rootBounds { get; }

    /// <summary>
    /// The target read-only property of the IntersectionObserverEntry interface indicates which targeted Element has changed its amount of intersection with the intersection root.
    /// </summary>
    Element target { get; }

    /// <summary>
    /// The time read-only property of the IntersectionObserverEntry interface is a DOMHighResTimeStamp that indicates the time at which the intersection change occurred relative to the time at which the document was created.
    /// </summary>
    decimal time { get; }
}
