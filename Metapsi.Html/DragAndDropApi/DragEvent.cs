namespace Metapsi.Html;

/// <summary>
/// The DragEvent interface is a DOM event that represents a drag and drop interaction. The user initiates a drag by placing a pointer device (such as a mouse) on the touch surface and then dragging the pointer to a new location (such as another DOM element). Applications are free to interpret a drag and drop interaction in an application-specific way.
/// </summary>
public interface DragEvent : MouseEvent
{
    /// <summary>
    /// The DragEvent.dataTransfer read-only property holds the drag operation's data (as a DataTransfer object).
    /// </summary>
    DataTransfer dataTransfer { get; }
}