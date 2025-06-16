namespace Metapsi.Html;

/// <summary>
/// The DataTransferItem object represents one drag data item. During a drag operation, each DragEvent has a dataTransfer property which contains a list of drag data items. Each item in the list is a DataTransferItem object.
/// </summary>
public interface DataTransferItem
{
    /// <summary>
    /// The read-only DataTransferItem.kind property returns the kind–a string or a file–of the DataTransferItem object representing the drag data item.
    /// <para> file - If the drag data item is a file. </para>
    /// <para> string - If the kind of drag data item is a plain Unicode string. </para>
    /// </summary>
    string kind { get; }

    /// <summary>
    /// The read-only DataTransferItem.type property returns the type (format) of the DataTransferItem object representing the drag data item. The type is a Unicode string generally given by a MIME type, although a MIME type is not required.
    /// </summary>
    string type { get; }
}
