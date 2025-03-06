using Metapsi.Syntax;

namespace Metapsi.Html
{
    /// <summary>
    /// The FileReader interface lets web applications asynchronously read the contents of files (or raw data buffers) stored on the user's computer, using File or Blob objects to specify the file or data to read.
    /// </summary>
    public interface FileReader : EventTarget
    {
        /// <summary>
        /// 
        /// </summary>
        public enum ReadyState
        {
            /// <summary>
            /// No data has been loaded yet
            /// </summary>
            EMPTY,
            /// <summary>
            /// Data is currently being loaded
            /// </summary>
            LOADING,
            /// <summary>
            /// The entire read request has been completed.
            /// </summary>
            DONE
        }

        /// <summary>
        /// A DOMException representing the error that occurred while reading the file.
        /// </summary>
        public DOMException error { get; }

        /// <summary>
        /// A number indicating the state of the FileReader. This is one of the following:
        /// <para> EMPTY 	0 	No data has been loaded yet.</para>
        /// <para> LOADING 	1 	Data is currently being loaded.</para>
        /// <para> DONE 	2 	The entire read request has been completed.</para>
        /// </summary>
        public ReadyState readyState { get; }

        /// <summary>
        /// The file's contents. This property is only valid after the read operation is complete, and the format of the data depends on which of the methods was used to initiate the read operation.
        /// </summary>
        public object result { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class FileReaderExtensions
    {
        /// <summary>
        /// Aborts the read operation. Upon return, the readyState will be DONE.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="fileReader"></param>
        public static void FileReaderAbort(this SyntaxBuilder b, Var<FileReader> fileReader)
        {
            b.CallOnObject(fileReader, "abort");
        }

        /// <summary>
        /// The readAsArrayBuffer() method of the FileReader interface is used to start reading the contents of a specified Blob or File. When the read operation is finished, the readyState property becomes DONE, and the loadend event is triggered. At that time, the result property contains an ArrayBuffer representing the file's data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="fileReader"></param>
        /// <param name="blob"></param>
        public static void FileReaderReadAsArrayBuffer<T>(this SyntaxBuilder b, Var<FileReader> fileReader, Var<T> blob)
            where T : Blob
        {
            b.CallOnObject(fileReader, "readAsArrayBuffer", blob);
        }

        /// <summary>
        /// The readAsDataURL() method of the FileReader interface is used to read the contents of the specified Blob or File. When the read operation is finished, the readyState property becomes DONE, and the loadend event is triggered. At that time, the result attribute contains the data as a data: URL representing the file's data as a base64 encoded string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="fileReader"></param>
        /// <param name="blob"></param>
        /// <remarks>The blob's result cannot be directly decoded as Base64 without first removing the Data-URL declaration preceding the Base64-encoded data. To retrieve only the Base64 encoded string, first remove data:*/*;base64, from the result.</remarks>
        public static void FileReaderReadAsDataURL<T>(this SyntaxBuilder b, Var<FileReader> fileReader, Var<T> blob)
            where T : Blob
        {
            b.CallOnObject(fileReader, "readAsDataURL", blob);
        }

        /// <summary>
        /// The readAsText() method of the FileReader interface is used to read the contents of the specified Blob or File. When the read operation is complete, the readyState property is changed to DONE, the loadend event is triggered, and the result property contains the contents of the file as a text string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="fileReader"></param>
        /// <param name="blob"></param>
        /// <remarks>The Blob.text() method is a newer promise-based API to read a file as text.
        /// <para> This method loads the entire file's content into memory and is not suitable for large files. Prefer readAsArrayBuffer() for large files.</para></remarks>
        public static void FileReaderReadAsText<T>(this SyntaxBuilder b, Var<FileReader> fileReader, Var<T> blob)
            where T : Blob
        {
            b.CallOnObject(fileReader, "readAsText", blob);
        }
    }
}
