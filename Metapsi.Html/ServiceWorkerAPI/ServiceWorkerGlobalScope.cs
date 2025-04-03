using Metapsi.Syntax;
using System.Runtime.Intrinsics.X86;

namespace Metapsi.Html
{
    /// <summary>
    /// The ServiceWorkerGlobalScope interface of the Service Worker API represents the global execution context of a service worker.
    /// </summary>
    public interface ServiceWorkerGlobalScope : WorkerGlobalScope
    {
        /// <summary>
        /// The clients read-only property of the ServiceWorkerGlobalScope interface returns the Clients object associated with the service worker.
        /// </summary>
        public Clients clients { get; }

        /// <summary>
        /// The registration read-only property of the ServiceWorkerGlobalScope interface returns a reference to the ServiceWorkerRegistration object, which represents the service worker's registration.
        /// </summary>
        public ServiceWorkerRegistration registration { get; }

        /// <summary>
        /// The serviceWorker read-only property of the ServiceWorkerGlobalScope interface returns a reference to the ServiceWorker object, which represents the service worker.
        /// </summary>
        public ServiceWorker serviceWorker { get; }
    }

    public static class ServiceWorkerGlobalScopeExtensions
    {
        /// <summary>
        /// The skipWaiting() method of the ServiceWorkerGlobalScope interface forces the waiting service worker to become the active service worker. Use this method with Clients.claim() to ensure that updates to the underlying service worker take effect immediately for both the current client and all other active clients.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorkerGlobalScope"></param>
        /// <returns>A Promise that resolves with undefined after trying to activate the newly installed service worker.</returns>
        public static Var<Promise> ServiceWorkerGlobalScopeSkipWaiting(this SyntaxBuilder b, Var<ServiceWorkerGlobalScope> serviceWorkerGlobalScope)
        {
            return b.CallOnObject<Promise>(serviceWorkerGlobalScope, "skipWaiting");
        }

        /// <summary>
        /// The skipWaiting() method of the ServiceWorkerGlobalScope interface forces the waiting service worker to become the active service worker. Use this method with Clients.claim() to ensure that updates to the underlying service worker take effect immediately for both the current client and all other active clients.
        /// </summary>
        /// <param name="b"></param>
        /// <returns>A Promise that resolves with undefined after trying to activate the newly installed service worker.</returns>
        public static Var<Promise> ServiceWorkerGlobalScopeSkipWaiting(this SyntaxBuilder b)
        {
            return b.ServiceWorkerGlobalScopeSkipWaiting(b.Self().As<ServiceWorkerGlobalScope>());
        }
    }
}
