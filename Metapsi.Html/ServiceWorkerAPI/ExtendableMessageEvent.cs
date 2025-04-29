using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The ExtendableMessageEvent interface of the Service Worker API represents the event object of a message event fired on a service worker (when a message is received on the ServiceWorkerGlobalScope from another context) — extends the lifetime of such events.
/// </summary>
public interface ExtendableMessageEvent : ExtendableEvent
{
    /// <summary>
    /// The data read-only property of the ExtendableMessageEvent interface returns the event's data. It can be any data type.
    /// </summary>
    public DynamicObject data { get; set; }

    /// <summary>
    /// The lastEventID read-only property of the ExtendableMessageEvent interface represents, in server-sent events, the last event ID of the event source.
    /// </summary>
    public string lastEventID { get; set; }

    /// <summary>
    /// The origin read-only property of the ExtendableMessageEvent interface returns the origin of the Client that sent the message.
    /// </summary>
    public string origin { get; set; }

    /// <summary>
    /// The ports read-only property of the ExtendableMessageEvent interface returns the array containing the MessagePort objects representing the ports of the associated message channel (the channel the message is being sent through.)
    /// </summary>
    public List<MessagePort> ports { get; set; }

    /// <summary>
    /// The source read-only property of the ExtendableMessageEvent interface returns a reference to the Client object from which the message was sent. It is a Client, ServiceWorker or MessagePort object.
    /// </summary>
    public object source { get; set; }
}
