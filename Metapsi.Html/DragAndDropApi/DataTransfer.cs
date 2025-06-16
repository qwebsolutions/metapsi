using System.Collections.Generic;
using System.Security.Cryptography;

namespace Metapsi.Html;

/// <summary>
/// The DataTransfer object is used to hold any data transferred between contexts, such as a drag and drop operation, or clipboard read/write. It may hold one or more data items, each of one or more data types.
/// </summary>
public interface DataTransfer
{
    /// <summary>
    /// The DataTransfer.dropEffect property controls the feedback (typically visual) the user is given during a drag and drop operation. It will affect which cursor is displayed while dragging. For example, when the user hovers over a target drop element, the browser's cursor may indicate which type of operation will occur.
    /// <para> copy - A copy of the source item is made at the new location. </para>
    /// <para> move - An item is moved to a new location. </para>
    /// <para> link - A link is established to the source at the new location. </para>
    /// <para> none - The item may not be dropped. </para>
    /// <para> Assigning any other value to dropEffect has no effect and the old value is retained. </para>
    /// </summary>
    string dropEffect { get; set; }

    /// <summary>
    /// The DataTransfer.effectAllowed property specifies the effect that is allowed for a drag operation. 
    /// <para> none - The item may not be dropped. </para>
    /// <para> copy - A copy of the source item may be made at the new location. </para>
    /// <para> copyLink - A copy or link operation is permitted. </para>
    /// <para> copyMove - A copy or move operation is permitted. </para>
    /// <para> link - A link may be established to the source at the new location. </para>
    /// <para> linkMove - A link or move operation is permitted. </para>
    /// <para> move - An item may be moved to a new location. </para>
    /// <para> all - All operations are permitted. </para>
    /// <para> uninitialized - The default value when the effect has not been set, equivalent to all. </para>
    /// <para> Assigning any other value to effectAllowed has no effect and the old value is retained. </para>
    /// </summary>
    string effectAllowed { get; set; }

    /// <summary>
    /// The files read-only property of DataTransfer objects is a list of the files in the drag operation. If the operation includes no files, the list is empty.
    /// </summary>
    FileList files { get; }

    /// <summary>
    /// The read-only items property of the DataTransfer interface is a list of the data transfer items in a drag operation. The list includes one item for each item in the operation and if the operation had no items, the list is empty.
    /// </summary>
    DataTransferItemList items { get; }

    /// <summary>
    /// The DataTransfer.types read-only property returns the available types that exist in the items.
    /// </summary>
    List<string> types { get; }
}
