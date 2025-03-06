using Metapsi.Syntax;
using System.Net.Mime;

namespace Metapsi.Html
{
    /// <summary>
    /// The Blob interface represents a blob, which is a file-like object of immutable, raw data
    /// </summary>
    public interface Blob
    {
        /// <summary>
        /// The size, in bytes, of the data contained in the Blob object.
        /// </summary>
        public int size { get; }

        /// <summary>
        /// A string indicating the MIME type of the data contained in the Blob. If the type is unknown, this string is empty.
        /// </summary>
        public string type { get; }
    }

    public static class BlobExtensions
    {
        /// <summary>
        /// The arrayBuffer() method of the Blob interface returns a Promise that resolves with the contents of the blob as binary data contained in an ArrayBuffer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <returns></returns>
        public static Var<Promise> BlobArrayBuffer<T>(this SyntaxBuilder b, Var<T> blob)
            where T: Blob
        {
            return b.CallOnObject<Promise>(blob, "arrayBuffer");
        }

        /// <summary>
        /// The bytes() method of the Blob interface returns a Promise that resolves with a Uint8Array containing the contents of the blob as an array of bytes.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <returns></returns>
        public static Var<Promise> BlobBytes<T>(this SyntaxBuilder b, Var<T> blob)
            where T: Blob
        {
            return b.CallOnObject<Promise>(blob, "bytes");
        }

        /// <summary>
        /// The slice() method of the Blob interface creates and returns a new Blob object which contains data from a subset of the blob on which it's called.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <returns></returns>
        public static Var<Blob> BlobSlice<T>(this SyntaxBuilder b, Var<T> blob)
            where T:Blob
        {
            return b.CallOnObject<Blob>(blob, "slice");
        }

        /// <summary>
        /// The slice() method of the Blob interface creates and returns a new Blob object which contains data from a subset of the blob on which it's called.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <param name="start">An index into the Blob indicating the first byte to include in the new Blob. If you specify a negative value, it's treated as an offset from the end of the Blob toward the beginning. For example, -10 would be the 10th from last byte in the Blob. The default value is 0. If you specify a value for start that is larger than the size of the source Blob, the returned Blob has size 0 and contains no data.</param>
        /// <returns>A new Blob object containing the specified subset of the data contained within the blob on which this method was called. The original blob is not altered.</returns>
        public static Var<Blob> BlobSlice<T>(this SyntaxBuilder b, Var<T> blob, Var<int> start) 
            where T : Blob
        {
            return b.CallOnObject<Blob>(blob, "slice", start);
        }

        /// <summary>
        /// The slice() method of the Blob interface creates and returns a new Blob object which contains data from a subset of the blob on which it's called.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <param name="start">An index into the Blob indicating the first byte to include in the new Blob. If you specify a negative value, it's treated as an offset from the end of the Blob toward the beginning. For example, -10 would be the 10th from last byte in the Blob. The default value is 0. If you specify a value for start that is larger than the size of the source Blob, the returned Blob has size 0 and contains no data.</param>
        /// <param name="end">An index into the Blob indicating the first byte that will not be included in the new Blob (i.e. the byte exactly at this index is not included). If you specify a negative value, it's treated as an offset from the end of the Blob toward the beginning. For example, -10 would be the 10th from last byte in the Blob. The default value is size.</param>
        /// <returns>A new Blob object containing the specified subset of the data contained within the blob on which this method was called. The original blob is not altered.</returns>
        public static Var<Blob> BlobSlice<T>(this SyntaxBuilder b, Var<T> blob, Var<int> start, Var<int> end)
            where T : Blob
        {
            return b.CallOnObject<Blob>(blob, "slice", start, end);
        }

        /// <summary>
        /// The slice() method of the Blob interface creates and returns a new Blob object which contains data from a subset of the blob on which it's called.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <param name="start">An index into the Blob indicating the first byte to include in the new Blob. If you specify a negative value, it's treated as an offset from the end of the Blob toward the beginning. For example, -10 would be the 10th from last byte in the Blob. The default value is 0. If you specify a value for start that is larger than the size of the source Blob, the returned Blob has size 0 and contains no data.</param>
        /// <param name="end">An index into the Blob indicating the first byte that will not be included in the new Blob (i.e. the byte exactly at this index is not included). If you specify a negative value, it's treated as an offset from the end of the Blob toward the beginning. For example, -10 would be the 10th from last byte in the Blob. The default value is size.</param>
        /// <param name="contentType">The content type to assign to the new Blob; this will be the value of its type property. The default value is an empty string.</param>
        /// <returns>A new Blob object containing the specified subset of the data contained within the blob on which this method was called. The original blob is not altered.</returns>
        public static Var<Blob> BlobSlice<T>(this SyntaxBuilder b, Var<T> blob, Var<int> start, Var<int> end, Var<string> contentType)
            where T : Blob

        {
            return b.CallOnObject<Blob>(blob, "slice", start, end,contentType);
        }

        /// <summary>
        /// The stream() method of the Blob interface returns a ReadableStream which upon reading returns the data contained within the Blob.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <returns>A ReadableStream which, upon reading, returns the contents of the Blob.</returns>
        public static Var<ReadableStream> BlobStream<T>(this SyntaxBuilder b, Var<T> blob)
            where T:Blob
        {
            return b.CallOnObject<ReadableStream>(blob, "stream");
        }

        /// <summary>
        /// The text() method of the Blob interface returns a Promise that resolves with a string containing the contents of the blob, interpreted as UTF-8.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="b"></param>
        /// <param name="blob"></param>
        /// <returns>A promise that resolves with a string which contains the blob's data as a text string. The data is always presumed to be in UTF-8 format.</returns>
        public static Var<Promise> BlobText<T>(this SyntaxBuilder b, Var<T> blob)
            where T:Blob
        {
            return b.CallOnObject<Promise>(blob, "text");
        }
    }
}
