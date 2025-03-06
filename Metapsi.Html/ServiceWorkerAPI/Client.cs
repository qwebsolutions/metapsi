using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html
{
    /// <summary>
    /// The Client interface represents an executable context such as a Worker, or a SharedWorker. Window clients are represented by the more-specific WindowClient. You can get Client/WindowClient objects from methods such as Clients.matchAll() and Clients.get().
    /// </summary>
    public interface Client
    {
        /// <summary>
        /// The frameType read-only property of the Client interface indicates the type of browsing context of the current Client. This value can be one of "auxiliary", "top-level", "nested", or "none".
        /// </summary>
        public string frameType { get; set; }

        /// <summary>
        /// The id read-only property of the Client interface returns the universally unique identifier of the Client object.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// The type read-only property of the Client interface indicates the type of client the service worker is controlling.  The value can be one of
        /// <para>"window"</para>
        /// <para>"worker"</para>
        /// <para>"sharedworker"</para>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// The url read-only property of the Client interface returns the URL of the current service worker client.
        /// </summary>
        public string url { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ClientExtensions
    {
        /// <summary>
        /// The postMessage() method of the Client interface allows a service worker to send a message to a client (a Window, Worker, or SharedWorker). The message is received in the message event on navigator.serviceWorker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="client"></param>
        /// <param name="message">The message to send to the client. This can be any structured-cloneable type.</param>
        public static void ClientPostMessage(this SyntaxBuilder b, Var<Client> client, IVariable message)
        {
            b.CallOnObject(client, "postMessage", message);
        }

        /// <summary>
        /// The postMessage() method of the Client interface allows a service worker to send a message to a client (a Window, Worker, or SharedWorker). The message is received in the message event on navigator.serviceWorker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="client"></param>
        /// <param name="message">The message to send to the client. This can be any structured-cloneable type.</param>
        /// <param name="transfer">An optional array of transferable objects to transfer ownership of. The ownership of these objects is given to the destination side and they are no longer usable on the sending side. These transferable objects should be attached to the message; otherwise they would be moved but not actually accessible on the receiving end.</param>
        public static void ClientPostMessage(this SyntaxBuilder b, Var<Client> client, IVariable message, Var<List<object>> transfer)
        {
            b.CallOnObject(client, "postMessage", message, transfer);
        }
    }
}
