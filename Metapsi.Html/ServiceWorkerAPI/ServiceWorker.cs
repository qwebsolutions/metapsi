using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html
{
    /// <summary>
    /// The ServiceWorker interface of the Service Worker API provides a reference to a service worker. Multiple browsing contexts (e.g. pages, workers, etc.) can be associated with the same service worker, each through a unique ServiceWorker object.
    /// </summary>
    public interface ServiceWorker : EventTarget
    {
        /// <summary>
        /// Returns the ServiceWorker serialized script URL defined as part of ServiceWorkerRegistration. Must be on the same origin as the document that registers the ServiceWorker.
        /// </summary>
        public string scriptURL { get; set; }

        /// <summary>
        /// The state read-only property of the ServiceWorker interface returns a string representing the current state of the service worker. It can be one of the following values: parsed, installing, installed, activating, activated, or redundant.
        /// </summary>
        public string state { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ServiceWorkerExtensions
    {
        /// <summary>
        /// The postMessage() method of the ServiceWorker interface sends a message to the worker. The first parameter is the data to send to the worker. The data may be any JavaScript object which can be handled by the structured clone algorithm.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorker"></param>
        /// <param name="message"></param>
        public static void ServiceWorkerPostMessage(this SyntaxBuilder b, Var<ServiceWorker> serviceWorker, IVariable message)
        {
            b.CallOnObject(serviceWorker, "postMessage", message);
        }

        /// <summary>
        /// The postMessage() method of the ServiceWorker interface sends a message to the worker. The first parameter is the data to send to the worker. The data may be any JavaScript object which can be handled by the structured clone algorithm.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="serviceWorker"></param>
        /// <param name="message"></param>
        /// <param name="transfer"></param>
        public static void ServiceWorkerPostMessage(this SyntaxBuilder b, Var<ServiceWorker> serviceWorker, IVariable message, Var<List<object>> transfer)
        {
            b.CallOnObject(serviceWorker, "postMessage", message, transfer);
        }
    }
}
