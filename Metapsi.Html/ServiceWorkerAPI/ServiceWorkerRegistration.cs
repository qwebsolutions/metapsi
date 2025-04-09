using Metapsi.Syntax;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Metapsi.Html
{
    /// <summary>
    /// 
    /// </summary>
    public interface ServiceWorkerRegistration : EventTarget
    {
        /// <summary>
        /// The active read-only property of the ServiceWorkerRegistration interface returns a service worker whose ServiceWorker.state is activating or activated. This property is initially set to null.
        /// </summary>
        public ServiceWorker active { get; }

        /// <summary>
        /// The installing read-only property of the ServiceWorkerRegistration interface returns a service worker whose ServiceWorker.state is installing. This property is initially set to null.
        /// </summary>
        public ServiceWorker installing { get; }

        /// <summary>
        /// The navigationPreload read-only property of the ServiceWorkerRegistration interface returns the NavigationPreloadManager associated with the current service worker registration.
        /// </summary>
        public NavigationPreloadManager navigationPreload { get; }

        /// <summary>
        /// The pushManager read-only property of the ServiceWorkerRegistration interface returns a reference to the PushManager interface for managing push subscriptions; this includes support for subscribing, getting an active subscription, and accessing push permission status.
        /// </summary>
        public PushManager pushManager { get; }

        /// <summary>
        /// The scope read-only property of the ServiceWorkerRegistration interface returns a string representing a URL that defines a service worker's registration scope; that is, the range of URLs a service worker can control. This is set using the scope parameter specified in the call to ServiceWorkerContainer.register() which registered the service worker.
        /// </summary>
        public string scope { get; }

        /// <summary>
        /// The updateViaCache read-only property of the ServiceWorkerRegistration interface returns the value of the setting used to determine the circumstances in which the browser will consult the HTTP cache when it tries to update the service worker or any scripts that are imported via importScripts().
        /// </summary>
        public string updateViaCache { get; }

        /// <summary>
        /// The waiting read-only property of the ServiceWorkerRegistration interface returns a service worker whose ServiceWorker.state is installed. This property is initially set to null.
        /// </summary>
        public ServiceWorker waiting { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ServiceWorkerRegistrationGetNotificationsOptions
    {
        /// <summary>
        /// A string representing a notification tag. If specified, only notifications that have this tag will be returned.
        /// </summary>
        public string tag { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ServiceWorkerRegistrationShowNotificationOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public class Action
        {
            /// <summary>
            /// A string identifying a user action to be displayed on the notification.
            /// </summary>
            public string action { get; set; }

            /// <summary>
            /// A string containing action text to be shown to the user.
            /// </summary>
            public string title { get; set; }

            /// <summary>
            /// A string containing the URL of an icon to display with the action.
            /// </summary>
            public string icon { get; set; }
        }

        /// <summary>
        /// An array of actions to display in the notification, for which the default is an empty array. 
        /// </summary>
        public List<Action> actions { get; set; }

        /// <summary>
        /// A string containing the URL of the image used to represent the notification when there isn't enough space to display the notification itself; for example, the Android Notification Bar. On Android devices, the badge should accommodate devices up to 4x resolution, about 96x96px, and the image will be automatically masked.
        /// </summary>
        public string badge { get; set; }

        /// <summary>
        /// A string representing the body text of the notification, which is displayed below the title. The default is the empty string.
        /// </summary>
        public string body { get; set; }

        /// <summary>
        /// Arbitrary data that you want associated with the notification. This can be of any structured-clonable data type. The default is null.
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// The direction in which to display the notification. It defaults to auto, which just adopts the browser's language setting behavior, but you can override that behavior by setting values of ltr and rtl (although most browsers seem to ignore these settings.)
        /// </summary>
        public string dir { get; set; }

        /// <summary>
        /// A string containing the URL of an icon to be displayed in the notification.
        /// </summary>
        public string icon { get; set; }

        /// <summary>
        /// A string containing the URL of an image to be displayed in the notification.
        /// </summary>
        public string image { get; set; }

        /// <summary>
        /// The notification's language, as specified using a string representing a language tag according to RFC 5646: Tags for Identifying Languages (also known as BCP 47). See the Sitepoint ISO 2 letter language codes page for a simple reference. The default is the empty string.
        /// </summary>
        public string lang { get; set; }

        /// <summary>
        /// A boolean value specifying whether the user should be notified after a new notification replaces an old one. The default is false, which means they won't be notified. If true, then tag also must be set.
        /// </summary>
        public bool renotify { get; set; }

        /// <summary>
        /// Indicates that a notification should remain active until the user clicks or dismisses it, rather than closing automatically. The default value is false.
        /// </summary>
        public bool requireInteraction { get; set; }

        /// <summary>
        /// A boolean value specifying whether the notification is silent (no sounds or vibrations issued), regardless of the device settings. The default, null, means to respect device defaults. If true, then vibrate must not be present.
        /// </summary>
        public bool silent { get; set; }

        /// <summary>
        /// A string representing an identifying tag for the notification. The default is the empty string.
        /// </summary>
        public string tag { get; set; }

        /// <summary>
        /// A timestamp, given as Unix time in milliseconds, representing the time associated with the notification. This could be in the past when a notification is used for a message that couldn't immediately be delivered because the device was offline, or in the future for a meeting that is about to start.
        /// </summary>
        public long timestamp { get; set; }

        /// <summary>
        /// A vibration pattern for the device's vibration hardware to emit with the notification. If specified, silent must not be true.
        /// </summary>
        public object vibrate { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceWorkerRegistrationExtensions
    {
        /// <summary>
        /// The getNotifications() method of the ServiceWorkerRegistration interface returns a list of the notifications in the order that they were created from the current origin via the current service worker registration. Origins can have many active but differently-scoped service worker registrations. Notifications created by one service worker on the same origin will not be available to other active service workers on that same origin.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerRegistration"></param>
        /// <returns>A Promise that resolves to a list of Notification objects.</returns>
        public static Var<Promise> ServiceWorkerRegistrationGetNotifications(this SyntaxBuilder b, Var<ServiceWorkerRegistration> serviceWorkerRegistration)
        {
            return b.CallOnObject<Promise>(serviceWorkerRegistration, "getNotifications");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerRegistration"></param>
        /// <param name="setOptions"></param>
        /// <returns></returns>
        public static Var<Promise> ServiceWorkerRegistrationGetNotifications(this SyntaxBuilder b, Var<ServiceWorkerRegistration> serviceWorkerRegistration, System.Action<PropsBuilder<ServiceWorkerRegistrationGetNotificationsOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(serviceWorkerRegistration, "getNotifications", b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The showNotification() method of the ServiceWorkerRegistration interface creates a notification on an active service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerRegistration"></param>
        /// <param name="title">Defines a title for the notification, which is shown at the top of the notification window.</param>
        /// <returns>A Promise that resolves to undefined.</returns>
        public static Var<Promise> ServiceWorkerRegistrationShowNotification(this SyntaxBuilder b, Var<ServiceWorkerRegistration> serviceWorkerRegistration, Var<string> title)
        {
            return b.CallOnObject<Promise>(serviceWorkerRegistration, "showNotification", title);

        }

        /// <summary>
        /// The showNotification() method of the ServiceWorkerRegistration interface creates a notification on an active service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerRegistration"></param>
        /// <param name="title">Defines a title for the notification, which is shown at the top of the notification window.</param>
        /// <param name="setOptions"></param>
        /// <returns></returns>
        public static Var<Promise> ServiceWorkerRegistrationShowNotification(this SyntaxBuilder b, Var<ServiceWorkerRegistration> serviceWorkerRegistration, Var<string> title, System.Action<PropsBuilder<ServiceWorkerRegistrationShowNotificationOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(serviceWorkerRegistration, "showNotification", title, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The unregister() method of the ServiceWorkerRegistration interface unregisters the service worker registration and returns a Promise. The promise will resolve to false if no registration was found, otherwise it resolves to true irrespective of whether unregistration happened or not (it may not unregister if someone else just called ServiceWorkerContainer.register() with the same scope.) The service worker will finish any ongoing operations before it is unregistered.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerRegistration"></param>
        /// <returns>Promise resolves with a boolean indicating whether the service worker has unregistered or not.</returns>
        public static Var<Promise> ServiceWorkerRegistrationUnregister(this SyntaxBuilder b, Var<ServiceWorkerRegistration> serviceWorkerRegistration)
        {
            return b.CallOnObject<Promise>(serviceWorkerRegistration, "unregister");
        }

        /// <summary>
        /// The update() method of the ServiceWorkerRegistration interface attempts to update the service worker. It fetches the worker's script URL, and if the new worker is not byte-by-byte identical to the current worker, it installs the new worker. The fetch of the worker bypasses any browser caches if the previous fetch occurred over 24 hours ago.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerRegistration"></param>
        /// <returns>A Promise that resolves with a ServiceWorkerRegistration object.</returns>
        public static Var<Promise> ServiceWorkerRegistrationUpdate(this SyntaxBuilder b, Var<ServiceWorkerRegistration> serviceWorkerRegistration)
        {
            return b.CallOnObject<Promise>(serviceWorkerRegistration, "update");
        }
    }
}
