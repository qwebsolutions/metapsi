namespace Metapsi.Html
{
    /// <summary>
    /// The parameter passed into an install event handler function, the InstallEvent interface represents an install action that is dispatched on the ServiceWorkerGlobalScope of a ServiceWorker. As a child of ExtendableEvent, it ensures that functional events such as FetchEvent are not dispatched during installation.
    /// </summary>
    public interface InstallEvent : ExtendableEvent
    {

    }
}
