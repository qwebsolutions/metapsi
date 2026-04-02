namespace Metapsi.Html;

/// <summary>
/// The MutationRecord is a read-only interface that represents an individual DOM mutation observed by a MutationObserver. It is the object inside the array passed to the callback of a MutationObserver.
/// </summary>
public interface MutationRecord
{
    /// <summary>
    /// The nodes added by a mutation. Will be an empty NodeList if no nodes were added.
    /// </summary>
    public NodeList addedNodes { get; }

    /// <summary>
    /// If the record's type is attributes, this is a string representing the name of the mutated attribute of the mutation target.
    /// If the record's type is not attributes, this is null.
    /// </summary>
    public string attributeName { get; }

    /// <summary>
    /// If the record's type is attributes, the property is a string representing the namespace of the mutated attribute of the mutation target. The value is null otherwise.
    /// </summary>
    public string attributeNamespace { get; }

    /// <summary>
    /// If a node is added to or removed from the target of a MutationObserver, the value is the Node that is the next sibling of the added or removed node: that is, the node immediately following this one in the parent's childNodes list.
    /// The value is null if there are no added or removed nodes, or if the node is the last child of its parent.
    /// </summary>
    public Node nextSibling { get; }

    /// <summary>
    /// A string representing the old value of an attribute which has been changed, if:
    /// <para>the attributeOldValue parameter to MutationObserver.observe() is true</para>
    /// <para>the attributes parameter to MutationObserver.observe() is true or omitted</para>
    /// <para>the mutation type is attributes.</para>
    /// A string representing the old value of a CharacterData node that has been changed, if:
    /// <para>the characterDataOldValue parameter to MutationObserver.observe() is true</para>
    /// <para>the characterData parameter to MutationObserver.observe() is true or omitted</para>
    /// <para>the mutation type is characterData.</para>
    /// Otherwise this property is null.
    /// </summary>
    public string oldValue { get; }

    /// <summary>
    /// If a node is added to or removed from the target of a MutationObserver, the value is the Node that is the previous sibling of the added or removed node: that is, the node immediately before this one in the parent's childNodes list.
    /// The value is null if there are no added or removed nodes, or if the node is the first child of its parent.
    /// </summary>
    public Node previousSibling { get; }

    /// <summary>
    /// A NodeList containing the nodes removed from the target of the mutation observed by the MutationObserver.
    /// </summary>
    public NodeList removedNodes { get; }

    /// <summary>
    /// The Node that the mutation affected.
    /// <para>If the record's type is attributes, this is the Element whose attributes changed.</para>
    /// <para>If the record's type is characterData, this is the CharacterData node.</para>
    /// <para>If the record's type is childList, this is the Node whose children changed.</para>
    /// </summary>
    public Node target { get; }

    /// <summary>
    /// The property is set to the type of the mutation as a string. The value can be one of the following:
    /// <para>attributes if the mutation was an attribute mutation.</para>
    /// <para>characterData if it was a mutation to a CharacterData node.</para>
    /// <para>childList if the mutation was a mutation to the tree of nodes.</para>
    /// </summary>
    public string type { get; }
}
