namespace Metapsi.Html;

/// <summary>
/// The UIEvent interface represents simple user interface events.
/// </summary>
public interface UIEvent : Event
{
    /// <summary>
    /// The UIEvent.detail read-only property, when non-zero, provides the current (or next, depending on the event) click count.
    /// <para> For click or dblclick events, UIEvent.detail is the current click count.</para>
    /// <para> For mousedown or mouseup events, UIEvent.detail is 1 plus the current click count.</para>
    /// <para> For all other UIEvent objects, UIEvent.detail is always zero.</para>
    /// </summary>
    int detail { get; }
}
