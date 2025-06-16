using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// The WindowClient interface of the ServiceWorker API represents the scope of a service worker client that is a document in a browsing context, controlled by an active worker. The service worker client independently selects and uses a service worker for its own loading and sub-resources.
    /// </summary>
    public interface WindowClient : Client
    {
        /// <summary>
        /// The focused read-only property of the WindowClient interface is a boolean value that indicates whether the current client has focus.
        /// </summary>
        public bool focused { get; }

        /// <summary>
        /// The visibilityState read-only property of the WindowClient interface indicates the visibility of the current client. This value can be one of "hidden", "visible", or "prerender".
        /// </summary>
        public string visibilityState { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class WindowClientExtensions
    {
        /// <summary>
        /// The focus() method of the WindowClient interface gives user input focus to the current client and returns a Promise that resolves to the existing WindowClient.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="windowClient"></param>
        /// <returns>A Promise that resolves to the existing WindowClient.</returns>
        public static Var<Promise> WindowClientFocus(this SyntaxBuilder b, Var<WindowClient> windowClient)
        {
            return b.CallOnObject<Promise>(windowClient, "focus");
        }

        /// <summary>
        /// The navigate() method of the WindowClient interface loads a specified URL into a controlled client page then returns a Promise that resolves to the existing WindowClient.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="windowClient"></param>
        /// <param name="url">The location to navigate to.</param>
        /// <returns>A Promise that resolves to the existing WindowClient if the URL is from the same origin as the service worker, or null otherwise.</returns>
        public static Var<Promise> WindowClientNavigate(this SyntaxBuilder b, Var<WindowClient> windowClient, Var<string> url)
        {
            return b.CallOnObject<Promise>(windowClient, "navigate", url);
        }
    }
}
