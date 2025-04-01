using Metapsi.Syntax;

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

/// <summary>
/// 
/// </summary>
public static class NodeExtensions
{
    /// <summary>
    /// The appendChild() method of the Node interface adds a node to the end of the list of children of a specified parent node.
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    /// <typeparam name="TChild"></typeparam>
    /// <param name="b"></param>
    /// <param name="node"></param>
    /// <param name="aChild">The node to append to the given parent node (commonly an element).</param>
    /// <returns>A Node that is the appended child (aChild), except when aChild is a DocumentFragment, in which case the empty DocumentFragment is returned.</returns>
    public static Var<TChild> NodeAppendChild<TParent, TChild>(this SyntaxBuilder b, Var<TParent> node, Var<TChild> aChild)
        where TParent : Node
        where TChild : Node
    {
        return b.CallOnObject<TChild>(node, "appendChild", aChild);
    }
}