using Metapsi.Syntax;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Security.Cryptography;

namespace Metapsi.Html;

/// <summary>
/// The PushSubscription interface of the Push API provides a subscription's URL endpoint along with the public key and secrets that should be used for encrypting push messages to this subscription. This information must be passed to the application server, using any desired application-specific method.
/// </summary>
public interface PushSubscription
{
    /// <summary>
    /// The endpoint read-only property of the PushSubscription interface returns a string containing the endpoint associated with the push subscription.
    /// </summary>
    public string endpoint { get; }

    /// <summary>
    /// The expirationTime read-only property of the PushSubscription interface returns a DOMHighResTimeStamp of the subscription expiration time associated with the push subscription, if there is one, or null otherwise.
    /// </summary>
    public object expirationTime { get; }

    /// <summary>
    /// The options read-only property of the PushSubscription interface is an object containing the options used to create the subscription.
    /// </summary>
    public PushSubscriptionOptions options { get; }
}

/// <summary>
/// 
/// </summary>
public class PushSubscriptionOptions
{
    /// <summary>
    /// The userVisibleOnly read-only property of the PushSubscriptionOptions interface indicates if the returned push subscription will only be used for messages whose effect is made visible to the user.
    /// </summary>
    public bool userVisibleOnly { get; }

    /// <summary>
    /// The applicationServerKey read-only property of the PushSubscriptionOptions interface contains the public key used by the push server.
    /// </summary>
    public string applicationServerKey { get; }
}

/// <summary>
/// 
/// </summary>
public static class PushSubscriptionExtensions
{
    /// <summary>
    /// The getKey() method of the PushSubscription interface returns an ArrayBuffer representing a client public key, which can then be sent to a server and used in encrypting push message data.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushSubscription"></param>
    /// <param name="name">A string representing the encryption method used to generate a client key.The value can be:
    /// <para> "p256dh" An Elliptic curve Diffie–Hellman public key on the P-256 curve(that is, the NIST secp256r1 elliptic curve). The resulting key is an uncompressed point in ANSI X9.62 format.</para>
    /// <para> "auth" An authentication secret, as described in Message Encryption for Web Push.</para></param>
    /// <returns>An ArrayBuffer or null if no public key can be found.</returns>
    public static Var<ArrayBuffer> PushSubscriptionGetKey(this SyntaxBuilder b, Var<PushSubscription> pushSubscription, Var<string> name)
    {
        return b.CallOnObject<ArrayBuffer>(pushSubscription, "getKey", name);
    }

    /// <summary>
    /// The toJSON() method of the PushSubscription interface is a standard serializer: it returns a JSON representation of the subscription properties, providing a useful shortcut.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushSubscription"></param>
    /// <returns>A JSON object. It contains the subscription endpoint, expirationTime and public keys, as an endpoint member, an expirationTime member and a keys member.</returns>
    public static Var<object> PushSubscriptionToJson(this SyntaxBuilder b, Var<PushSubscription> pushSubscription)
    {
        return b.CallOnObject<object>(pushSubscription, "toJSON");
    }

    /// <summary>
    /// The unsubscribe() method of the PushSubscription interface returns a Promise that resolves to a boolean value when the current subscription is successfully unsubscribed.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="pushSubscription"></param>
    /// <returns></returns>
    public static Var<Promise> PushSubscriptionUnsubscribe(this SyntaxBuilder b, Var<PushSubscription> pushSubscription)
    {
        return b.CallOnObject<Promise>(pushSubscription, "unsubscribe");
    }
}
