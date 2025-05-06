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
/// An object that sets options for getting the root node.
/// </summary>
public interface GetRootNodeOptions
{
    /// <summary>
    /// A boolean value that indicates whether the shadow root should be returned (false, the default), or a root node beyond shadow root (true).
    /// </summary>
    bool composed { get; set; }
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

    /// <summary>
    /// The getRootNode() method of the Node interface returns the context object's root, which optionally includes the shadow root if it is available.
    /// </summary>
    /// <typeparam name="TNode"></typeparam>
    /// <param name="b"></param>
    /// <param name="node"></param>
    /// <param name="setOptions"></param>
    /// <returns>An object inheriting from Node. This will differ in exact form depending on where you call getRootNode(); for example:
    /// <para>Calling it on an element inside a standard web page will return an HTMLDocument object representing the entire page(or &lt;iframe&gt;).</para>
    /// <para>Calling it on an element inside a shadow DOM will return the associated ShadowRoot.</para>
    /// <para>Calling it on an element that is not attached to a document or a shadow tree will return the root of the DOM tree it belongs to.</para>
    /// </returns>
    public static Var<Node> NodeGetRootNode<TNode>(this SyntaxBuilder b, Var<TNode> node, System.Action<PropsBuilder<GetRootNodeOptions>> setOptions = null)
    {
        if (setOptions != null)
        {
            return b.CallOnObject<Node>(node, "getRootNode", b.SetProps(b.NewObj(), setOptions));
        }
        else
        {
            return b.CallOnObject<Node>(node, "getRootNode");
        }
    }
}