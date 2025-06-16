namespace Metapsi.Html;

/// <summary>
/// The PushEvent interface of the Push API represents a push message that has been received. This event is sent to the global scope of a ServiceWorker. It contains the information sent from an application server to a PushSubscription.
/// </summary>
public interface PushEvent : ExtendableEvent
{
    /// <summary>
    /// The data read-only property of the PushEvent interface returns a reference to a PushMessageData object containing data sent to the PushSubscription.
    /// </summary>
    PushMessageData data { get; }
}
