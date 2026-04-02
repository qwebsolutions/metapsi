using System.Collections.Generic;

namespace Metapsi.Html;

/// <summary>
/// The MutationObserver interface provides the ability to watch for changes being made to the DOM tree. 
/// </summary>
public interface MutationObserver
{
    /// <summary>
    /// An object providing options that describe which DOM mutations should be reported to mutationObserver's callback. At a minimum, one of childList, attributes, and/or characterData must be true when you call observe().
    /// </summary>
    public class ObserveOptions
    {
        /// <summary>
        /// Set to true to extend monitoring to the entire subtree of nodes rooted at target. 
        /// All of the other properties are then extended to all of the nodes in the subtree 
        /// instead of applying solely to the target node. 
        /// The default value is false. 
        /// Note that if a descendant of target is removed, changes in that descendant subtree 
        /// will continue to be observed, until the notification about the removal itself has 
        /// been delivered.
        /// </summary>
        public bool subtree { get; set; }

        /// <summary>
        /// Set to true to monitor the target node (and, if subtree is true, its descendants) for the addition of new child nodes or removal of existing child nodes. The default value is false.
        /// </summary>
        public bool childList { get; set; }

        /// <summary>
        /// Set to true to watch for changes to the value of attributes on the node or nodes being monitored. The default value is true if either of attributeFilter or attributeOldValue is specified, otherwise the default value is false.
        /// </summary>
        public bool attributes { get; set; }

        /// <summary>
        /// An array of specific attribute names to be monitored. If this property isn't included, changes to all attributes cause mutation notifications.
        /// </summary>
        public List<string> attributeFilter { get; set; }

        /// <summary>
        /// Set to true to record the previous value of any attribute that changes when monitoring the node or nodes for attribute changes. The default value is false.
        /// </summary>
        public bool attributeOldValue { get; set; }

        /// <summary>
        /// Set to true to monitor the specified target node (and, if subtree is true, its descendants) for changes to the character data contained within the node or nodes. The default value is true if characterDataOldValue is specified, otherwise the default value is false.
        /// </summary>
        public bool characterData { get; set; }

        /// <summary>
        /// Set to true to record the previous value of a node's text whenever the text changes on nodes being monitored. The default value is false.
        /// </summary>
        public bool characterDataOldValue { get; set; }
    }
}

//public interface MutationRecord
//{

//}