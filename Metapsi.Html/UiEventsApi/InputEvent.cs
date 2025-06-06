namespace Metapsi.Html;

/// <summary>
/// The InputEvent interface represents an event notifying the user of editable content changes.
/// </summary>
public interface InputEvent : UIEvent
{
    /// <summary>
    /// The data read-only property of the InputEvent interface returns a string with inserted characters. This may be an empty string if the change doesn't insert text, such as when characters are deleted.
    /// </summary>
    string data { get; }

    /// <summary>
    /// The dataTransfer read-only property of the InputEvent interface returns a DataTransfer object containing information about richtext or plaintext data being added to or removed from editable content.
    /// </summary>
    DataTransfer dataTransfer { get; }

    /// <summary>
    /// The inputType read-only property of the InputEvent interface returns the type of change made to editable content. Possible changes include for example inserting, deleting, and formatting text.
    /// </summary>
    string inputType { get; }

    /// <summary>
    /// The InputEvent.isComposing read-only property returns a boolean value indicating if the event is fired after compositionstart and before compositionend.
    /// </summary>
    bool isComposing { get; }
}
