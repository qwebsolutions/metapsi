using Metapsi.Syntax;

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

    /// <summary>
    /// The StorageEvent interface is implemented by the storage event, which is sent to a window when a storage area the window has access to is changed within the context of another document.
    /// </summary>
    public interface StorageEvent : Event
    {
        /// <summary>
        /// A string containing the key for the storage item that was changed.
        /// </summary>
        string key { get; }

        /// <summary>
        /// A string containing the new value of the storage item.
        /// </summary>
        string newValue { get; }

        /// <summary>
        /// A string containing the original value of the storage item.
        /// </summary>
        string oldValue { get; }

        /// <summary>
        /// A Storage object that represents the storage object that was affected.
        /// </summary>
        Storage storageArea { get; }

        /// <summary>
        /// A string containing the URL of the document whose storage changed.
        /// </summary>
        string url { get; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class StorageExtensions
    {
        /// <summary>
        /// The clear() method of the Storage interface clears all keys stored in a given Storage object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="storage"></param>
        public static void StorageClear(this SyntaxBuilder b, Var<Storage> storage)
        {
            b.CallOnObject(storage, "clear");
        }

        /// <summary>
        /// The getItem() method of the Storage interface, when passed a key name, will return that key's value, or null if the key does not exist, in the given Storage object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="storage"></param>
        /// <param name="keyName">A string containing the name of the key you want to retrieve the value of.</param>
        /// <returns>A string containing the value of the key. If the key does not exist, null is returned.</returns>
        public static Var<string> StorageGetItem(this SyntaxBuilder b, Var<Storage> storage, Var<string> keyName)
        {
            return b.CallOnObject<string>(storage, "getItem", keyName);
        }

        /// <summary>
        /// The key() method of the Storage interface, when passed a number n, returns the name of the nth key in a given Storage object. The order of keys is user-agent defined, so you should not rely on it.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="storage"></param>
        /// <param name="index">An integer representing the number of the key you want to get the name of. This is a zero-based index.</param>
        /// <returns>A string containing the name of the key. If the index does not exist, null is returned.</returns>
        public static Var<string> StorageKey(this SyntaxBuilder b, Var<Storage> storage, Var<int> index)
        {
            return b.CallOnObject<string>(storage, "key", index);
        }

        /// <summary>
        /// The removeItem() method of the Storage interface, when passed a key name, will remove that key from the given Storage object if it exists. The Storage interface of the Web Storage API provides access to a particular domain's session or local storage.
        /// <para>If there is no item associated with the given key, this method will do nothing.</para>
        /// </summary>
        /// <param name="b"></param>
        /// <param name="storage"></param>
        /// <param name="keyName">A string containing the name of the key you want to remove.</param>
        public static void StorageRemoveItem(this SyntaxBuilder b, Var<Storage> storage, Var<string> keyName)
        {
            b.CallOnObject(storage, "removeItem", keyName);
        }

        /// <summary>
        /// The setItem() method of the Storage interface, when passed a key name and value, will add that key to the given Storage object, or update that key's value if it already exists.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="storage"></param>
        /// <param name="keyName">A string containing the name of the key you want to create/update.</param>
        /// <param name="keyValue">A string containing the value you want to give the key you are creating/updating.</param>
        public static void StorageSetItem(this SyntaxBuilder b, Var<Storage> storage, Var<string> keyName, Var<string> keyValue)
        {
            b.CallOnObject(storage, "setItem", keyName, keyValue);
        }
    }
}
