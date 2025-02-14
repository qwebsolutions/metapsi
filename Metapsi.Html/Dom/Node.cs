namespace Metapsi.Html;

/// <summary>
/// The DOM Node interface is an abstract base class upon which many other DOM API objects are based, thus letting those object types to be used similarly and often interchangeably.
/// </summary>
public interface Node : EventTarget
{
    /// <summary>
    /// The read-only parentElement property of Node interface returns the DOM node's parent Element, or null if the node either has no parent, or its parent isn't a DOM Element.
    /// </summary>
    public Element parentElement { get; }
}