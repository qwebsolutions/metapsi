namespace Metapsi.Html;

/// <summary>
/// The Navigator interface represents the state and the identity of the user agent. It allows scripts to query it and to register themselves to carry on some activities.
/// </summary>
public interface Navigator
{
    /// <summary>
    /// The serviceWorker read-only property of the Navigator interface returns the ServiceWorkerContainer object for the associated document, which provides access to registration, removal, upgrade, and communication with the ServiceWorker.
    /// </summary>
    public ServiceWorkerContainer serviceWorker { get; }
}