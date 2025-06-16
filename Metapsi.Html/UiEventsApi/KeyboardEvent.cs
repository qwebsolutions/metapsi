namespace Metapsi.Html;

/// <summary>
/// KeyboardEvent objects describe a user interaction with the keyboard; each event describes a single interaction between the user and a key (or combination of a key with modifier keys) on the keyboard. The event type (keydown, keypress, or keyup) identifies what kind of keyboard activity occurred.
/// </summary>
public interface KeyboardEvent : UIEvent
{
    /// <summary>
    /// The KeyboardEvent.altKey read-only property is a boolean value that indicates if the alt key (Option or ⌥ on macOS) was pressed (true) or not (false) when the event occurred.
    /// </summary>
    bool altKey { get; }

    /// <summary>
    /// The KeyboardEvent.ctrlKey read-only property returns a boolean value that indicates if the control key was pressed (true) or not (false) when the event occurred.
    /// </summary>
    bool ctrlKey { get; }


    /// <summary>
    /// The KeyboardEvent.isComposing read-only property returns a boolean value indicating if the event is fired within a composition session, i.e., after compositionstart and before compositionend.
    /// </summary>
    bool isComposing { get; }

    /// <summary>
    /// The KeyboardEvent interface's key read-only property returns the value of the key pressed by the user, taking into consideration the state of modifier keys such as Shift as well as the keyboard locale and layout.
    /// </summary>
    string key { get; }

    /// <summary>
    /// The KeyboardEvent.location read-only property returns an unsigned long representing the location of the key on the keyboard or other input device.
    /// </summary>
    ulong location { get; }

    /// <summary>
    /// The KeyboardEvent.metaKey read-only property returning a boolean value that indicates if the Meta key was pressed (true) or not (false) when the event occurred. Some operating systems may intercept the key so it is never detected.
    /// </summary>
    bool metaKey { get; }

    /// <summary>
    /// The repeat read-only property of the KeyboardEvent interface returns a boolean value that is true if the given key is being held down such that it is automatically repeating.
    /// </summary>
    bool repeat { get; }

    /// <summary>
    /// The KeyboardEvent.shiftKey read-only property is a boolean value that indicates if the shift key was pressed (true) or not (false) when the event occurred.
    /// <para> The pressing of the shift key may change the key of the event too.For example, pressing B generates key: "b", while simultaneously pressing Shift generates key: "B".</para>
    /// </summary>
    bool shiftKey { get; }
}