namespace Metapsi.Html;

/// <summary>
/// The NotificationEvent interface of the Notifications API represents a notification event dispatched on the ServiceWorkerGlobalScope of a ServiceWorker.
/// </summary>
public interface NotificationEvent: ExtendableEvent
{
    /// <summary>
    /// The action read-only property of the NotificationEvent interface returns the string ID of the notification button the user clicked. This value returns an empty string if the user clicked the notification somewhere other than an action button, or the notification does not have a button. The notification id is set during the creation of the Notification via the actions array attribute and can't be modified unless the notification is replaced.
    /// </summary>
    string action { get; }

    /// <summary>
    /// The notification read-only property of the NotificationEvent interface returns the instance of the Notification that was clicked to fire the event. The Notification provides read-only access to many properties that were set at the instantiation time of the Notification such as tag and data attributes that allow you to store information for deferred use in the notificationclick event.
    /// </summary>
    Notification notification { get; }
}