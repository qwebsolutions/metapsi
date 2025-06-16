using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// The Clients interface provides access to Client objects. Access it via self.clients within a service worker.
    /// </summary>
    public interface Clients
    {

    }
    
    /// <summary>
    /// 
    /// </summary>
    public class ClientsMatchAllOptions
    {
        /// <summary>
        /// A boolean value — if set to true, the matching operation will return all service worker clients who share the same origin as the current service worker. Otherwise, it returns only the service worker clients controlled by the current service worker. The default is false.
        /// </summary>
        public bool includeUncontrolled { get; set; }

        /// <summary>
        /// Sets the type of clients you want matched. Available values are "window", "worker", "sharedworker", and "all". The default is "window".
        /// </summary>
        public string type { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ClientsExtensions
    {
        /// <summary>
        /// The claim() method of the Clients interface allows an active service worker to set itself as the controller for all clients within its scope. This triggers a controllerchange event on navigator.serviceWorker in any clients that become controlled by this service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="clients"></param>
        /// <returns>A Promise that resolves to undefined.</returns>
        public static Var<Promise> ClientsClaim(this SyntaxBuilder b, Var<Clients> clients)
        {
            return b.CallOnObject<Promise>(clients, "claim");
        }

        /// <summary>
        /// The get() method of the Clients interface gets a service worker client matching a given id and returns it in a Promise.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="clients"></param>
        /// <param name="id">A string representing the id of the client you want to get.</param>
        /// <returns>A Promise that resolves to a Client object or undefined.</returns>
        public static Var<Promise> ClientsGet(this SyntaxBuilder b, Var<Clients> clients, Var<string> id)
        {
            return b.CallOnObject<Promise>(clients, "get", id);
        }

        /// <summary>
        /// The matchAll() method of the Clients interface returns a Promise for a list of service worker Client objects. Include the options parameter to return all service worker clients whose origin is the same as the associated service worker's origin. If options are not included, the method returns only the service worker clients controlled by the service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="clients"></param>
        /// <returns>A Promise that resolves to an array of Client objects.</returns>
        public static Var<Promise> ClientsMatchAll(this SyntaxBuilder b, Var<Clients> clients)
        {
            return b.CallOnObject<Promise>(clients, "matchAll");
        }

        /// <summary>
        /// The matchAll() method of the Clients interface returns a Promise for a list of service worker Client objects. Include the options parameter to return all service worker clients whose origin is the same as the associated service worker's origin. If options are not included, the method returns only the service worker clients controlled by the service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="clients"></param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to an array of Client objects.</returns>
        public static Var<Promise> ClientsMatchAll(this SyntaxBuilder b, Var<Clients> clients, System.Action<PropsBuilder<ClientsMatchAllOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(clients, "matchAll", b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The openWindow() method of the Clients interface creates a new top level browsing context and loads a given URL. If the calling script doesn't have permission to show popups, openWindow() will throw an InvalidAccessError.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="clients"></param>
        /// <param name="url">A string representing the URL of the client you want to open in the window. Generally this value must be a URL from the same origin as the calling script.</param>
        /// <returns>A Promise that resolves to a WindowClient object if the URL is from the same origin as the service worker or a null value otherwise.</returns>
        /// <exception cref="DOMException"></exception>
        /// <remarks>InvalidAccessError The promise is rejected with this exception if none of the windows in the app's origin have transient activation.</remarks>
        public static Var<Promise> ClientsOpenWindow(this SyntaxBuilder b, Var<Clients> clients, Var<string> url)
        {
            return b.CallOnObject<Promise>(clients, "openWindow", url);
        }
    }
}
