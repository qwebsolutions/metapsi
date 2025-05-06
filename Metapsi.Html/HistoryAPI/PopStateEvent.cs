namespace Metapsi.Html;

/// <summary>
/// PopStateEvent is an interface for the popstate event. A popstate event is dispatched to the window every time the active history entry changes between two history entries for the same document. If the history entry being activated was created by a call to history.pushState() or was affected by a call to history.replaceState(), the popstate event's state property contains a copy of the history entry's state object.
/// </summary>
public interface PopStateEvent : Event
{
    /// <summary>
    /// The hasUAVisualTransition read-only property of the PopStateEvent interface returns true if the user agent performed a visual transition for this navigation before dispatching this event, or false otherwise.
    /// </summary>
    bool hasUAVisualTransition { get; }

    /// <summary>
    /// The state read-only property of the PopStateEvent interface represents the state stored when the event was created. Practically it is a value provided by the call to history.pushState() or history.replaceState()
    /// </summary>
    object state { get; }
}