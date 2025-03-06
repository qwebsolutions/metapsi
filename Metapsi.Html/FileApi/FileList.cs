using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// The FileList interface represents an object of this type returned by the files property of the HTML &lt;input&gt; element; this lets you access the list of files selected with the &lt;input type="file"&gt; element. It's also used for a list of files dropped into web content when using the drag and drop API
    /// </summary>
    public interface FileList
    {
        /// <summary>
        /// The length read-only property of the FileList interface returns the number of files in the FileList.
        /// </summary>
        public int length { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class FileListExtensions
    {
        /// <summary>
        /// The item() method of the FileList interface returns a File object representing the file at the specified index in the file list.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="fileList"></param>
        /// <param name="index">The zero-based index of the file to retrieve from the list.</param>
        /// <returns>A File object representing the requested file.</returns>
        public static Var<File> FileListItem(this SyntaxBuilder b, Var<FileList> fileList, Var<int> index)
        {
            return b.CallOnObject<File>(fileList, "item", index);
        }
    }
}
