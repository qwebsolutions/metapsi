namespace Metapsi.Html;

/// <summary>
/// The MouseEvent interface represents events that occur due to the user interacting with a pointing device (such as a mouse). Common events using this interface include click, dblclick, mouseup, mousedown.
/// </summary>
public interface MouseEvent : UIEvent
{
    /// <summary>
    /// The MouseEvent.altKey read-only property is a boolean value that indicates whether the alt key was pressed or not when a given mouse event occurs.
    /// </summary>
    bool altKey { get; }

    /// <summary>
    /// The MouseEvent.button read-only property indicates which button was pressed or released on the mouse to trigger the event.
    /// <para> 0: Main button, usually the left button or the un-initialized state </para>
    /// <para> 1: Auxiliary button, usually the wheel button or the middle button(if present) </para>
    /// <para> 2: Secondary button, usually the right button </para>
    /// <para> 3: Fourth button, typically the Browser Back button </para>
    /// <para> 4: Fifth button, typically the Browser Forward button </para>
    /// </summary>
    int button { get; }

    /// <summary>
    /// The MouseEvent.buttons read-only property indicates which buttons are pressed on the mouse (or other input device) when a mouse event is triggered.
    /// <para> 0: No button or un-initialized </para>
    /// <para> 1: Primary button(usually the left button) </para>
    /// <para> 2: Secondary button(usually the right button) </para>
    /// <para> 4: Auxiliary button(usually the mouse wheel button or middle button) </para>
    /// <para> 8: 4th button(typically the "Browser Back" button) </para>
    /// <para> 16 : 5th button(typically the "Browser Forward" button)</para>
    /// </summary>
    int buttons { get; }

    /// <summary>
    /// The clientX read-only property of the MouseEvent interface provides the horizontal coordinate within the application's viewport at which the event occurred (as opposed to the coordinate within the page).
    /// </summary>
    double clientX { get; }

    /// <summary>
    /// The clientY read-only property of the MouseEvent interface provides the vertical coordinate within the application's viewport at which the event occurred (as opposed to the coordinate within the page).
    /// </summary>
    double clientY { get; }

    /// <summary>
    /// The MouseEvent.ctrlKey read-only property is a boolean value that indicates whether the ctrl key was pressed or not when a given mouse event occurs.
    /// </summary>
    bool ctrlKey { get; }

    /// <summary>
    /// The MouseEvent.metaKey read-only property is a boolean value that indicates whether the meta key was pressed or not when a given mouse event occurs.
    /// </summary>
    bool metaKey { get; }

    /// <summary>
    /// The offsetX read-only property of the MouseEvent interface provides the offset in the X coordinate of the mouse pointer between that event and the padding edge of the target node.
    /// </summary>
    double offsetX { get; }

    /// <summary>
    /// The offsetY read-only property of the MouseEvent interface provides the offset in the Y coordinate of the mouse pointer between that event and the padding edge of the target node.
    /// </summary>
    double offsetY { get; }

    /// <summary>
    /// The pageX read-only property of the MouseEvent interface returns the X (horizontal) coordinate (in pixels) at which the mouse was clicked, relative to the left edge of the entire document. This includes any portion of the document not currently visible.
    /// </summary>
    double pageX { get; }

    /// <summary>
    /// The pageY read-only property of the MouseEvent interface returns the Y (vertical) coordinate (in pixels) at which the mouse was clicked, relative to the top edge of the entire document. This includes any portion of the document not currently visible.
    /// </summary>
    double pageY { get; }

    /// <summary>
    /// The MouseEvent.relatedTarget read-only property is the secondary target for the mouse event, if there is one.
    /// </summary>
    EventTarget relatedTarget { get; }

    /// <summary>
    /// The screenX read-only property of the MouseEvent interface provides the horizontal coordinate (offset) of the mouse pointer in screen coordinates.
    /// </summary>
    double screenX { get; }

    /// <summary>
    /// The screenY read-only property of the MouseEvent interface provides the vertical coordinate (offset) of the mouse pointer in screen coordinates.
    /// </summary>
    double screenY { get; }

    /// <summary>
    /// The MouseEvent.shiftKey read-only property is a boolean value that indicates whether the shift key was pressed or not when a given mouse event occurs.
    /// </summary>
    bool shiftKey { get; }

    /// <summary>
    /// The MouseEvent.x property is an alias for the MouseEvent.clientX property.
    /// </summary>
    double x { get; }

    /// <summary>
    /// The MouseEvent.y property is an alias for the MouseEvent.clientY property.
    /// </summary>
    double y { get; }
}
