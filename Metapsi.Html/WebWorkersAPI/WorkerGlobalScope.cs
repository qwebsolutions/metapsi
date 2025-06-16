namespace Metapsi.Html;

/// <summary>
/// The WorkerGlobalScope interface of the Web Workers API is an interface representing the scope of any worker. 
/// </summary>
public interface WorkerGlobalScope : EventTarget
{
    /// <summary>
    /// The caches read-only property of the WorkerGlobalScope interface returns the CacheStorage object associated with the current context. This object enables functionality such as storing assets for offline use, and generating custom responses to requests.
    /// </summary>
    CacheStorage caches { get; }
}
