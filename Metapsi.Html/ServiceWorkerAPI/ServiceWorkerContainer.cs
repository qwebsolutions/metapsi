using Metapsi.Syntax;
using Microsoft.AspNetCore.HttpOverrides;
using static Metapsi.Html.ServerAction;
using static System.Net.WebRequestMethods;
using System.Resources;
using System;

namespace Metapsi.Html
{
    /// <summary>
    /// The ServiceWorkerContainer interface of the Service Worker API provides an object representing the service worker as an overall unit in the network ecosystem, including facilities to register, unregister and update service workers, and access the state of service workers and their registrations.
    /// </summary>
    public interface ServiceWorkerContainer
    {
        /// <summary>
        /// The controller read-only property of the ServiceWorkerContainer interface returns a ServiceWorker object if its state is activating or activated (the same object returned by ServiceWorkerRegistration.active). This property returns null if the request is a force refresh (Shift + refresh) or if there is no active worker.
        /// </summary>
        public ServiceWorker controller { get; }

        /// <summary>
        /// The ready read-only property of the ServiceWorkerContainer interface provides a way of delaying code execution until a service worker is active. It returns a Promise that will never reject, and which waits indefinitely until the ServiceWorkerRegistration associated with the current page has an active worker. Once that condition is met, it resolves with the ServiceWorkerRegistration.
        /// </summary>
        public Promise ready {get;}
    }

    /// <summary>
    /// 
    /// </summary>
    public class ServiceWorkerContainerRegisterOptions
    {
        /// <summary>
        /// A string representing a URL that defines a service worker's registration scope; that is, what range of URLs a service worker can control.
        /// </summary>
        public string scope { get; set; }

        /// <summary>
        /// A string specifying the type of worker to create. Valid values are:
        /// <para>'classic' The loaded service worker is in a standard script.This is the default.</para>
        /// <para>'module' The loaded service worker is in an ES module and the import statement is available on worker contexts.</para>
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// A string indicating how the HTTP cache is used for service worker scripts resources during updates.Note: This only refers to the service worker script and its imports, not other resources fetched by these scripts.
        /// <para>'all' The HTTP cache will be queried for the main script, and all imported scripts. If no fresh entry is found in the HTTP cache, then the scripts are fetched from the network.</para>
        /// <para> 'imports' The HTTP cache will be queried for imports, but the main script will always be updated from the network.If no fresh entry is found in the HTTP cache for the imports, they're fetched from the network.</para>
        /// <para> 'none' The HTTP cache will not be used for the main script or its imports. All service worker script resources will be updated from the network.</para>
        /// </summary>
        public string updateViaCache { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceWorkerContainerExtensions
    {
        /// <summary>
        /// The getRegistration() method of the ServiceWorkerContainer interface gets a ServiceWorkerRegistration object whose scope URL matches the provided client URL. The method returns a Promise that resolves to a ServiceWorkerRegistration or undefined.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerContainer"></param>
        /// <returns></returns>
        public static Var<Promise> ServiceWorkerContainerGetRegistration(this SyntaxBuilder b, Var<ServiceWorkerContainer> serviceWorkerContainer)
        {
            return b.CallOnObject<Promise>(serviceWorkerContainer, "getRegistration");
        }

        /// <summary>
        /// The getRegistration() method of the ServiceWorkerContainer interface gets a ServiceWorkerRegistration object whose scope URL matches the provided client URL. The method returns a Promise that resolves to a ServiceWorkerRegistration or undefined.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerContainer"></param>
        /// <param name="url">The registration whose scope matches this URL will be returned. Relative URLs are resolved with the current client as the base. If this parameter is not provided, the current client's URL will be used by default.</param>
        /// <returns></returns>
        public static Var<Promise> ServiceWorkerContainerGetRegistration(this SyntaxBuilder b, Var<ServiceWorkerContainer> serviceWorkerContainer, Var<string> url)
        {
            return b.CallOnObject<Promise>(serviceWorkerContainer, "getRegistration", url);
        }

        /// <summary>
        /// The getRegistrations() method of the ServiceWorkerContainer interface gets all ServiceWorkerRegistrations associated with a ServiceWorkerContainer, in an array. The method returns a Promise that resolves to an array of ServiceWorkerRegistration.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerContainer"></param>
        /// <returns></returns>
        public static Var<Promise> ServiceWorkerContainerGetRegistrations(this SyntaxBuilder b, Var<ServiceWorkerContainer> serviceWorkerContainer)
        {
            return b.CallOnObject<Promise>(serviceWorkerContainer, "getRegistrations");
        }


        /// <summary>
        /// The register() method of the ServiceWorkerContainer interface creates or updates a ServiceWorkerRegistration for the given scope. If successful, the registration associates the provided script URL to a scope, which is subsequently used for matching documents to a specific service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerContainer"></param>
        /// <param name="scriptURL">The URL of the service worker script. The registered service worker file needs to have a valid JavaScript MIME type.</param>
        /// <returns>A Promise that resolves with a ServiceWorkerRegistration object.</returns>
        public static Var<Promise> ServiceWorkerContainerRegister(this SyntaxBuilder b, Var<ServiceWorkerContainer> serviceWorkerContainer, Var<string> scriptURL)
        {
            return b.CallOnObject<Promise>(serviceWorkerContainer, "register", scriptURL);
        }

        /// <summary>
        /// The register() method of the ServiceWorkerContainer interface creates or updates a ServiceWorkerRegistration for the given scope. If successful, the registration associates the provided script URL to a scope, which is subsequently used for matching documents to a specific service worker.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerContainer"></param>
        /// <param name="scriptURL">The URL of the service worker script. The registered service worker file needs to have a valid JavaScript MIME type.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves with a ServiceWorkerRegistration object.</returns>
        public static Var<Promise> ServiceWorkerContainerRegister(this SyntaxBuilder b, Var<ServiceWorkerContainer> serviceWorkerContainer, Var<string> scriptURL, System.Action<PropsBuilder<ServiceWorkerContainerRegisterOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(serviceWorkerContainer, "register", scriptURL, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The startMessages() method of the ServiceWorkerContainer interface explicitly starts the flow of messages being dispatched from a service worker to pages under its control (e.g. sent via Client.postMessage()). This can be used to react to sent messages earlier, even before that page's content has finished loading.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerContainer"></param>
        public static void ServiceWorkerContainerStartMessages(this SyntaxBuilder b, Var<ServiceWorkerContainer> serviceWorkerContainer)
        {
            b.CallOnObject(serviceWorkerContainer, "startMessages");
        }
    }
}
