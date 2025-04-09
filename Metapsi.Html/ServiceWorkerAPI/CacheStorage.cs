using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The CacheStorage interface represents the storage for Cache objects.
/// </summary>
public interface CacheStorage
{

}

/// <summary>
/// An object whose properties control how matching is done in the match operation.
/// </summary>
public interface CacheStorageMatchOptions
{
    /// <summary>
    /// A boolean value that specifies whether the matching process should ignore the query string in the URL. For example, if set to true, the ?value=bar part of http://foo.com/?value=bar would be ignored when performing a match. It defaults to false.
    /// </summary>
    bool ignoreSearch { get; set; }

    /// <summary>
    /// A boolean value that, when set to true, prevents matching operations from validating the Request http method (normally only GET and HEAD are allowed.) It defaults to false.
    /// </summary>
    bool ignoreMethod { get; set; }

    /// <summary>
    /// A boolean value that, when set to true, tells the matching operation not to perform VARY header matching. In other words, if the URL matches you will get a match regardless of whether the Response object has a VARY header or not. It defaults to false.
    /// </summary>
    bool ignoreVary { get; set; }

    /// <summary>
    /// A string that represents a specific cache to search within.
    /// </summary>
    string cacheName { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class CacheStorageExtensions
{
    /// <summary>
    /// The delete() method of the CacheStorage interface finds the Cache object matching the cacheName, and if found, deletes the Cache object and returns a Promise that resolves to true. If no Cache object is found, it resolves to false.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="cacheName">The name of the cache you want to delete.</param>
    /// <returns>a Promise that resolves to true if the Cache object is found and deleted, and false otherwise.</returns>
    public static Var<Promise> CacheStorageDelete(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<string> cacheName)
    {
        return b.CallOnObject<Promise>(cacheStorage, "delete", cacheName);
    }

    /// <summary>
    /// The has() method of the CacheStorage interface returns a Promise that resolves to true if a Cache object matches the cacheName.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="cacheName">A string representing the name of the Cache object you are looking for in the CacheStorage.</param>
    /// <returns>A Promise that resolves to true if the cache exists or false if not.</returns>
    public static Var<Promise> CacheStorageHas(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<string> cacheName)
    {
        return b.CallOnObject<Promise>(cacheStorage, "has", cacheName);
    }

    /// <summary>
    /// The keys() method of the CacheStorage interface returns a Promise that will resolve with an array containing strings corresponding to all of the named Cache objects tracked by the CacheStorage object in the order they were created. Use this method to iterate over a list of all Cache objects.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <returns>a Promise that resolves with an array of the Cache names inside the CacheStorage object.</returns>
    public static Var<Promise> CacheStorageKeys(this SyntaxBuilder b, Var<CacheStorage> cacheStorage)
    {
        return b.CallOnObject<Promise>(cacheStorage, "keys");
    }

    /// <summary>
    /// The match() method of the CacheStorage interface checks if a given Request or URL string is a key for a stored Response. This method returns a Promise for a Response, or a Promise which resolves to undefined if no match is found.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> CacheStorageMatch(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<string> request)
    {
        return b.CallOnObject<Promise>(cacheStorage, "match", request);
    }

    /// <summary>
    /// The match() method of the CacheStorage interface checks if a given Request or URL string is a key for a stored Response. This method returns a Promise for a Response, or a Promise which resolves to undefined if no match is found.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> CacheStorageMatch(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<Request> request)
    {
        return b.CallOnObject<Promise>(cacheStorage, "match", request);
    }

    /// <summary>
    /// The match() method of the CacheStorage interface checks if a given Request or URL string is a key for a stored Response. This method returns a Promise for a Response, or a Promise which resolves to undefined if no match is found.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="request"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> CacheStorageMatch(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<string> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
    {
        return b.CallOnObject<Promise>(cacheStorage, "match", request, b.SetProps(b.NewObj(), setOptions));
    }

    /// <summary>
    /// The match() method of the CacheStorage interface checks if a given Request or URL string is a key for a stored Response. This method returns a Promise for a Response, or a Promise which resolves to undefined if no match is found.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="request"></param>
    /// <param name="setOptions"></param>
    /// <returns></returns>
    public static Var<Promise> CacheStorageMatch(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<Request> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
    {
        return b.CallOnObject<Promise>(cacheStorage, "match", request, b.SetProps(b.NewObj(), setOptions));
    }

    /// <summary>
    /// The open() method of the CacheStorage interface returns a Promise that resolves to the Cache object matching the cacheName.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="cacheStorage"></param>
    /// <param name="cacheName">The name of the cache you want to open.</param>
    /// <returns></returns>
    public static Var<Promise> CacheStorageOpen(this SyntaxBuilder b, Var<CacheStorage> cacheStorage, Var<string> cacheName)
    {
        return b.CallOnObject<Promise>(cacheStorage, "open", cacheName);
    }
}