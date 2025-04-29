using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The MessageEvent interface represents a message received by a target object.
/// </summary>
public interface MessageEvent : Event
{
    /// <summary>
    /// The data read-only property of the MessageEvent interface represents the data sent by the message emitter.
    /// </summary>
    public DynamicObject data { get; }

    /// <summary>
    /// The lastEventId read-only property of the MessageEvent interface is a string representing a unique ID for the event.
    /// </summary>
    public string lastEventID { get; }

    /// <summary>
    /// The origin read-only property of the MessageEvent interface is a string representing the origin of the message emitter.
    /// </summary>
    public string origin { get; }

    /// <summary>
    /// The ports read-only property of the MessageEvent interface is an array of MessagePort objects containing all MessagePort objects sent with the message, in order.
    /// </summary>
    public List<MessagePort> ports { get; }

    /// <summary>
    /// The source read-only property of the MessageEvent interface is a MessageEventSource (which can be a WindowProxy, MessagePort, or ServiceWorker object) representing the message emitter.
    /// </summary>
    public object source { get; }
}
