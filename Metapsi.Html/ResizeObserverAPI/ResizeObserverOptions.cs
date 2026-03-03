namespace Metapsi.Html;

/// <summary>
/// An options object allowing you to set options for the observation.
/// </summary>
public interface ResizeObserverOptions
{
    /// <summary>
    /// Sets which box model the observer will observe changes to. Possible values are:
    /// <para>"content-box" (the default) - Size of the content area as defined in CSS.</para>
    /// <para>"border-box" - Size of the box border area as defined in CSS.</para>
    /// <para>"device-pixel-content-box" - The size of the content area as defined in CSS, in device pixels, before applying any CSS transforms on the element or its ancestors.</para>
    /// </summary>
    public string box { get; set; }
}