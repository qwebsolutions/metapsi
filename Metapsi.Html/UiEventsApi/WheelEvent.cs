namespace Metapsi.Html;

/// <summary>
/// The WheelEvent interface represents events that occur due to the user moving a mouse wheel or similar input device.
/// </summary>
public interface WheelEvent
{
    /// <summary>
    /// The WheelEvent.deltaMode read-only property returns an unsigned long representing the unit of the delta values scroll amount.
    /// </summary>
    ulong deltaMode { get; }

    /// <summary>
    /// The WheelEvent.deltaX read-only property is a double representing the horizontal scroll amount in the WheelEvent.deltaMode unit.
    /// </summary>
    double deltaX { get; }

    /// <summary>
    /// The WheelEvent.deltaY read-only property is a double representing the vertical scroll amount in the WheelEvent.deltaMode unit.
    /// </summary>
    double deltaY { get; }

    /// <summary>
    /// The WheelEvent.deltaZ read-only property is a double representing the scroll amount along the z-axis, in the WheelEvent.deltaMode unit.
    /// </summary>
    double deltaZ { get; }
}