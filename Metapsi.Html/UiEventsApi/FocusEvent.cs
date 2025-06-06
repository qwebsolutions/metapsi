namespace Metapsi.Html;

/// <summary>
/// The FocusEvent interface represents focus-related events, including focus, blur, focusin, and focusout.
/// </summary>
public interface FocusEvent: UIEvent
{
    /// <summary>
    /// The relatedTarget read-only property of the FocusEvent interface is the secondary target, depending on the type of event:
    /// </summary>
    EventTarget relatedTarget { get; }
}
