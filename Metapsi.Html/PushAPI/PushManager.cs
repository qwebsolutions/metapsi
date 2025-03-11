using Metapsi.Syntax;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Hosting.Server;
using static Metapsi.Html.ServerAction;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

namespace Metapsi.Html;

/// <summary>
/// The PushManager interface of the Push API provides a way to receive notifications from third-party servers as well as request URLs for push notifications.
/// </summary>
public interface PushManager
{
}

/// <summary>
/// 
/// </summary>
public class PushManagerSubscribeOptions
{
    /// <summary>
    /// A boolean indicating that the returned push subscription will only be used for messages whose effect is made visible to the user.
    /// </summary>
    public bool userVisibleOnly { get; set; }

    /// <summary>
    ///     A Base64-encoded string or ArrayBuffer containing an ECDSA P-256 public key that the push server will use to authenticate your application server.If specified, all messages from your application server must use the VAPID authentication scheme, and include a JWT signed with the corresponding private key.This key IS NOT the same ECDH key that you use to encrypt the data.For more information, see "Using VAPID with WebPush".
    /// </summary>
    public string applicationServerKey { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class PushManagerExtensions
{
    /// <summary>
    /// The PushManager.getSubscription() method of the PushManager interface retrieves an existing push subscription.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushManager"></param>
    /// <returns>A Promise that resolves to a PushSubscription object or null.</returns>
    public static Var<Promise> PushManagerGetSubscription(this SyntaxBuilder b, Var<PushManager> pushManager)
    {
        return b.CallOnObject<Promise>(pushManager, "getSubscription");
    }

    /// <summary>
    /// The subscribe() method of the PushManager interface subscribes to a push service.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushManager"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> PushManagerSubscribe(this SyntaxBuilder b, Var<PushManager> pushManager, System.Action<PropsBuilder<PushManagerSubscribeOptions>> setOptions)
    {
        return b.CallOnObject<Promise>(pushManager, "subscribe", b.SetProps(setOptions));
    }
}
