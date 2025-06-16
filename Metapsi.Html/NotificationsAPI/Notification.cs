using Metapsi.Syntax;
using System.Security;

namespace Metapsi.Html;

/// <summary>
/// The Notification interface of the Notifications API is used to configure and display desktop notifications to the user.
/// </summary>
public interface Notification : EventTarget
{
    /// <summary>
    /// The badge read-only property of the Notification interface returns a string containing the URL of an image to represent the notification when there is not enough space to display the notification itself such as for example, the Android Notification Bar. On Android devices, the badge should accommodate devices up to 4x resolution, about 96 by 96 px, and the image will be automatically masked.
    /// </summary>
    public string badge { get;  }

    /// <summary>
    /// The body read-only property of the Notification interface indicates the body string of the notification, as specified in the body option of the Notification() constructor.
    /// </summary>
    public string body { get;  }

    /// <summary>
    /// The data read-only property of the Notification interface returns a structured clone of the notification's data, as specified in the data option of the Notification() constructor. The notification's data can be any arbitrary data that you want associated with the notification.
    /// </summary>
    public object data { get; }

    /// <summary>
    /// The dir read-only property of the Notification interface indicates the text direction of the notification, as specified in the dir option of the Notification() constructor.
    /// </summary>
    public string dir { get; }

    /// <summary>
    /// The icon read-only property of the Notification interface contains the URL of an icon to be displayed as part of the notification, as specified in the icon option of the Notification() constructor.
    /// </summary>
    public string icon { get; }

    /// <summary>
    /// The image read-only property of the Notification interface contains the URL of an image to be displayed as part of the notification, as specified in the image option of the Notification() constructor.
    /// </summary>
    public string image { get; }

    /// <summary>
    /// The lang read-only property of the Notification interface indicates the language used in the notification, as specified in the lang option of the Notification() constructor.
    /// </summary>
    public string lang { get; }

    /// <summary>
    /// The renotify read-only property of the Notification interface specifies whether the user should be notified after a new notification replaces an old one, as specified in the renotify option of the Notification() constructor.
    /// </summary>
    public bool renotify { get; }

    /// <summary>
    /// The requireInteraction read-only property of the Notification interface returns a boolean value indicating that a notification should remain active until the user clicks or dismisses it, rather than closing automatically.
    /// </summary>
    public bool requireInteraction { get; }

    /// <summary>
    /// The silent read-only property of the Notification interface specifies whether the notification should be silent, i.e., no sounds or vibrations should be issued regardless of the device settings. This is controlled via the silent option of the Notification() constructor.
    /// </summary>
    public bool silent { get; }

    /// <summary>
    /// The tag read-only property of the Notification interface signifies an identifying tag for the notification, as specified in the tag option of the Notification() constructor.
    /// </summary>
    public string tag { get; }

    /// <summary>
    /// The timestamp read-only property of the Notification interface returns a number, as specified in the timestamp option of the Notification() constructor.
    /// </summary>
    public long timestamp { get; }

    /// <summary>
    /// The title read-only property of the Notification interface indicates the title of the notification, as specified in the title parameter of the Notification() constructor.
    /// </summary>
    public string title { get; }

    /// <summary>
    /// The vibrate read-only property of the Notification interface specifies a vibration pattern for the device's vibration hardware to emit when the notification fires. This is specified in the vibrate option of the Notification() constructor.
    /// </summary>
    public object vibrate { get; }
}

/// <summary>
/// 
/// </summary>
public static class NotificationExtensions
{
    /// <summary>
    /// The permission read-only static property of the Notification interface indicates the current permission granted by the user for the current origin to display web notifications.
    /// <para> "granted" The user has explicitly granted permission for the current origin to display system notifications.</para>
    /// <para> "denied" The user has explicitly denied permission for the current origin to display system notifications.</para>
    /// <para> "default" The user decision is unknown; in this case the application will act as if permission was denied.</para>
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<string> NotificationPermission(this SyntaxBuilder b)
    {
        return b.GetProperty<string>(
                b.GetProperty<Notification>(
                    b.Self(),
                    "Notification"),
                "permission");
    }

    /// <summary>
    /// The requestPermission() static method of the Notification interface requests permission from the user for the current origin to display notifications. The method returns a Promise that fulfills with a string indicating whether permission was granted or denied.
    /// </summary>
    /// <param name="b"></param>
    /// <returns>A Promise that resolves to a string with the permission picked by the user. Possible values for this string are:
    /// <para> "granted" The user has explicitly granted permission for the current origin to display system notifications.</para>
    /// <para> "denied" The user has explicitly denied permission for the current origin to display system notifications.</para>
    /// <para> "default" The user decision is unknown; in this case the application will act as if permission was denied.</para>
    /// </returns>
    public static Var<Promise> NotificationRequestPermission(this SyntaxBuilder b)
    {
        return b.CallOnObject<Promise>(
            b.GetProperty<Notification>(
                b.Self(),
                "Notification"),
            "requestPermission");
    }

    /// <summary>
    /// The close() method of the Notification interface is used to close/remove a previously displayed notification.
    /// </summary>
    /// <remarks>This API shouldn't be used just to have the notification removed from the screen after a fixed delay since this method will also remove the notification from any notification tray, preventing users from interacting with it after it was initially shown. A valid use for this API would be to remove a notification that is no longer relevant (e.g. the user already read the notification on the webpage in the case of a messaging app or the following song is already playing in a music app).</remarks>
    /// <param name="b"></param>
    /// <param name="notification"></param>
    public static void NotificationClose(this SyntaxBuilder b, Var<Notification> notification)
    {
        b.CallOnObject(notification, "close");
    }
}
