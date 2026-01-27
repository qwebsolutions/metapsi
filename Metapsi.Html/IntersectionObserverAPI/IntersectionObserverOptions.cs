namespace Metapsi.Html;

/// <summary>
/// An optional object which customizes the observer.
/// </summary>
public interface IntersectionObserverOptions
{
    /// <summary>
    /// An Element or Document object which is an ancestor of the intended target, whose bounding rectangle will be considered the viewport. Any part of the target not visible in the visible area of the root is not considered visible. If not specified, the observer uses the document's viewport as the root, with no margin, and a 0% threshold (meaning that even a one-pixel change is enough to trigger a callback).
    /// </summary>
    Node root { get; set; }

    /// <summary>
    /// A string which specifies a set of offsets to add to the root's bounding_box when calculating intersections, effectively shrinking or growing the root for calculation purposes. Each offset value can be only expressed in pixels (px) or percentages (%). The syntax is approximately the same as that for the CSS margin property; see The intersection root and root margin for more information on how the margin works and the syntax. The default is "0px 0px 0px 0px".
    /// </summary>
    string rootMargin { get; set; }

    /// <summary>
    /// A string that specifies the offsets to add to every scroll container on path to the target when calculating intersections, effectively shrinking or growing the clip rectangles used to calculate intersections. This allows, for example, better observation of targets inside nested scroll containers that are currently clipped away by the scroll containers. The syntax is the same as rootMargin. The default is "0px 0px 0px 0px".
    /// </summary>
    string scrollMargin { get; set; }

    /// <summary>
    /// Either a single number or an array of numbers between 0.0 and 1.0, specifying a ratio of intersection area to total bounding box area for the observed target. A value of 0.0 means that even a single visible pixel counts as the target being visible. 1.0 means that the entire target element is visible. The default is a threshold of "0".
    /// </summary>
    decimal threshold { get; set; }
}
