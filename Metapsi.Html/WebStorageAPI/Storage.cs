namespace Metapsi.Html
{
    /// <summary>
    /// The Storage interface of the Web Storage API provides access to a particular domain's session or local storage. It allows, for example, the addition, modification, or deletion of stored data items.
    /// </summary>
    public interface Storage
    {
        /// <summary>
        /// The length read-only property of the Storage interface returns the number of data items stored in a given Storage object.
        /// </summary>
        public int length { get; }
    }
}
