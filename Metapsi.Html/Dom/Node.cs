using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The DOM Node interface is an abstract base class upon which many other DOM API objects are based, thus letting those object types to be used similarly and often interchangeably.
/// </summary>
public interface Node : EventTarget
{
    /// <summary>
    /// Returns a string representing the base URL of the document containing the Node.
    /// </summary>
    public string baseURI { get; }

    /// <summary>
    /// Returns a live NodeList containing all the children of this node (including elements, text and comments).
    /// </summary>
    public NodeList childNodes { get; }

    /// <summary>
    /// Returns a Node representing the first direct child node of the node, or null if the node has no child.
    /// </summary>
    public Node firstChild { get; }

    /// <summary>
    /// A boolean indicating whether or not the Node is connected (directly or indirectly) to the context object, e.g., the Document object in the case of the normal DOM, or the ShadowRoot in the case of a shadow DOM.
    /// </summary>
    public bool isConnected { get; }

    /// <summary>
    /// Returns a Node representing the last direct child node of the node, or null if the node has no child.
    /// </summary>
    public Node lastChild { get; }

    /// <summary>
    /// Returns a Node representing the next node in the tree, or null if there isn't such node.
    /// </summary>
    public Node nextSibling { get; }

    /// <summary>
    /// Returns a string containing the name of the Node. The structure of the name will differ with the node type.
    /// </summary>
    public string nodeName { get; }

    /// <summary>
    /// Returns an unsigned short representing the type of the node. 
    /// </summary>
    public NodeType nodeType { get; }

    /// <summary>
    /// Returns / Sets the value of the current node.
    /// </summary>
    public string nodeValue { get; set; }

    /// <summary>
    /// Returns the Document that this node belongs to. If the node is itself a document, returns null.
    /// </summary>
    public Document ownerDocument { get; }

    /// <summary>
    /// Returns a Node that is the parent of this node. If there is no such node — for example, if this node is the top of the tree, or if it doesn't participate in a tree — this property returns null.
    /// </summary>
    public Node parentNode { get; }

    /// <summary>
    /// Returns an Element that is the parent of this node. If the node has no parent, or if that parent is not an Element, this property returns null.
    /// </summary>
    public Element parentElement { get; }

    /// <summary>
    /// Returns a Node representing the previous node in the tree, or null if there isn't such node.
    /// </summary>
    public Node previousSibling { get; }

    /// <summary>
    /// Returns / Sets the textual content of an element and all its descendants.
    /// </summary>
    public string textContent { get; set; }
}

/// <summary>
/// An unsigned short representing the type of a node
/// </summary>
public enum NodeType
{
    /// <summary>
    /// Element node
    /// </summary>
    ELEMENT_NODE = 1,
    /// <summary>
    /// Attribute node
    /// </summary>
    ATTRIBUTE_NODE = 2,
    /// <summary>
    /// Text node
    /// </summary>
    TEXT_NODE = 3,
    /// <summary>
    /// CDATA section
    /// </summary>
    CDATA_SECTION_NODE = 4,
    /// <summary>
    /// Processing instruction node
    /// </summary>
    PROCESSING_INSTRUCTION_NODE = 7,
    /// <summary>
    /// Comment node
    /// </summary>
    COMMENT_NODE = 8,
    /// <summary>
    /// Document node
    /// </summary>
    DOCUMENT_NODE = 9,
    /// <summary>
    /// Document type node
    /// </summary>
    DOCUMENT_TYPE_NODE = 10,
    /// <summary>
    /// Document fragment node
    /// </summary>
    DOCUMENT_FRAGMENT_NODE = 11
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