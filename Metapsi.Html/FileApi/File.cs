namespace Metapsi.Html
{
    /// <summary>
    /// The File interface provides information about files and allows JavaScript in a web page to access their content.
    /// </summary>
    public interface File : Blob
    {
        /// <summary>
        /// The lastModified read-only property of the File interface provides the last modified date of the file as the number of milliseconds since the Unix epoch (January 1, 1970 at midnight). Files without a known last modified date return the current date.
        /// </summary>
        public long lastModified { get; }

        /// <summary>
        /// The name read-only property of the File interface returns the name of the file represented by a File object. For security reasons, the path is excluded from this property.
        /// </summary>
        public string name { get; }
    }
}
