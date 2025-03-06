using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// This is the event type for fetch events dispatched on the service worker global scope. It contains information about the fetch, including the request and how the receiver will treat the response. It provides the event.respondWith() method, which allows us to provide a response to this fetch.
    /// </summary>
    public interface FetchEvent : ExtendableEvent
    {
        /// <summary>
        /// The clientId read-only property of the FetchEvent interface returns the id of the Client that the current service worker is controlling.
        /// </summary>
        public string clientId { get; }

        /// <summary>
        /// The handled property of the FetchEvent interface returns a promise indicating if the event has been handled by the fetch algorithm or not. This property allows executing code after the browser has consumed a response, and is usually used together with the waitUntil() method.
        /// </summary>
        public Promise handled { get; set; }

        /// <summary>
        /// The preloadResponse read-only property of the FetchEvent interface returns a Promise that resolves to the navigation preload Response if navigation preload was triggered, or undefined otherwise.
        /// </summary>
        public Promise preloadResponse { get; }

        /// <summary>
        /// The replacesClientId read-only property of the FetchEvent interface is the id of the client that is being replaced during a page navigation.
        /// </summary>
        public string replacesClientId { get; }

        /// <summary>
        /// The request read-only property of the FetchEvent interface returns the Request that triggered the event handler.
        /// </summary>
        public Request request { get; }

        /// <summary>
        /// The resultingClientId read-only property of the FetchEvent interface is the id of the client that replaces the previous client during a page navigation.
        /// </summary>
        public string resultingClientId { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class FetchEventExtensions
    {
        /// <summary>
        /// The respondWith() method of FetchEvent prevents the browser's default fetch handling, and allows you to provide a promise for a Response yourself.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <param name="response"></param>
        public static void FetchEventRespondWith(this SyntaxBuilder b, Var<FetchEvent> e, Var<Response> response)
        {
            b.CallOnObject(e, "respondWith", response);
        }

        /// <summary>
        /// The respondWith() method of FetchEvent prevents the browser's default fetch handling, and allows you to provide a promise for a Response yourself.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <param name="response"></param>
        public static void FetchEventRespondWith(this SyntaxBuilder b, Var<FetchEvent> e, Var<Promise> response)
        {
            b.CallOnObject(e, "respondWith", response);
        }
    }
}
