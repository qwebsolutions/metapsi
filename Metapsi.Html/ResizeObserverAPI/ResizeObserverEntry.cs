using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The ResizeObserverEntry interface represents the object passed to the ResizeObserver() constructor's callback function, which allows you to access the new dimensions of the Element or SVGElement being observed.
/// </summary>
public interface ResizeObserverEntry
{
    /// <summary>
    /// The borderBoxSize read-only property of the ResizeObserverEntry interface returns an array containing the new border box size of the observed element when the callback is run.
    /// </summary>
    List<ResizeObserverSize> borderBoxSize { get; }

    /// <summary>
    /// The contentBoxSize read-only property of the ResizeObserverEntry interface returns an array containing the new content box size of the observed element when the callback is run.
    /// </summary>
    List<ResizeObserverSize> contentBoxSize { get; }

    /// <summary>
    /// The contentRect read-only property of the ResizeObserverEntry interface returns a DOMRectReadOnly object containing the new size of the observed element when the callback is run. 
    /// </summary>
    DOMRectReadOnly contentRect { get; }

    /// <summary>
    /// The devicePixelContentBoxSize read-only property of the ResizeObserverEntry interface returns an array containing the size in device pixels of the observed element when the callback is run.
    /// </summary>
    List<ResizeObserverSize> devicePixelContentBoxSize { get; }

    /// <summary>
    /// The target read-only property of the ResizeObserverEntry interface returns a reference to the Element or SVGElement that is being observed.
    /// </summary>
    Element target { get; }
}
