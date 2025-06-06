namespace Metapsi.Html;

/// <summary>
/// The DataTransferItemList object is a list of DataTransferItem objects representing items being dragged. During a drag operation, each DragEvent has a dataTransfer property and that property is a DataTransferItemList.
/// </summary>
public interface DataTransferItemList
{
    /// <summary>
    /// The read-only length property of the DataTransferItemList interface returns the number of items currently in the drag item list.
    /// </summary>
    int length { get; }
}
