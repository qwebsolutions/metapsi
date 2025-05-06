using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Html
{
    /// <summary>
    /// The Cache interface provides a persistent storage mechanism for Request / Response object pairs that are cached in long lived memory.
    /// </summary>
    public interface Cache
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public static class CacheExtensions
    {
        /// <summary>
        /// The add() method of the Cache interface takes a URL, retrieves it, and adds the resulting response object to the given cache.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request"> A request for the resource you want to add to the cache. This can be a Request object or a URL.         This parameter is used as a parameter to the Request() constructor, so URLs follow the same rules as for that constructor. In particular, URLs may be relative to the base URL, which is the document's baseURI in a window context, or WorkerGlobalScope.location in a worker context.</param>
        /// <returns>A Promise that resolves with undefined.</returns>
        public static Var<Promise> CacheAdd(this SyntaxBuilder b, Var<Cache> cache, Var<string> request)
        {
            return b.CallOnObject<Promise>(cache, "add", request);
        }

        /// <summary>
        /// The add() method of the Cache interface takes a URL, retrieves it, and adds the resulting response object to the given cache.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request"> A request for the resource you want to add to the cache. This can be a Request object or a URL.         This parameter is used as a parameter to the Request() constructor, so URLs follow the same rules as for that constructor. In particular, URLs may be relative to the base URL, which is the document's baseURI in a window context, or WorkerGlobalScope.location in a worker context.</param>
        /// <returns>A Promise that resolves with undefined.</returns>
        public static Var<Promise> CacheAdd(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request)
        {
            return b.CallOnObject<Promise>(cache, "add", request);
        }

        /// <summary>
        /// The addAll() method of the Cache interface takes an array of URLs, retrieves them, and adds the resulting response objects to the given cache. The request objects created during retrieval become keys to the stored response operations.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="requests">An array of requests for the resources you want to add to the cache.These can be Request objects or URLs. These requests are used as parameters to the Request() constructor, so URLs follow the same rules as for that constructor.In particular, URLs may be relative to the base URL, which is the document's baseURI in a window context, or WorkerGlobalScope.location in a worker context.</param>
        /// <returns>A Promise that resolves with undefined.</returns>
        public static Var<Promise> CacheAddAll(this SyntaxBuilder b, Var<Cache> cache, Var<List<string>> requests)
        {
            return b.CallOnObject<Promise>(cache, "addAll", requests);
        }

        /// <summary>
        /// The delete() method of the Cache interface finds the Cache entry whose key is the request, and if found, deletes the Cache entry and returns a Promise that resolves to true. If no Cache entry is found, it resolves to false.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request you are looking to delete. This can be a Request object or a URL.</param>
        /// <returns>A Promise that resolves to true if the cache entry is deleted, or false otherwise.</returns>
        public static Var<Promise> CacheDelete(this SyntaxBuilder b, Var<Cache> cache, Var<string> request)
        {
            return b.CallOnObject<Promise>(cache, "delete", request);
        }

        /// <summary>
        /// The delete() method of the Cache interface finds the Cache entry whose key is the request, and if found, deletes the Cache entry and returns a Promise that resolves to true. If no Cache entry is found, it resolves to false.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request you are looking to delete. This can be a Request object or a URL.</param>
        /// <returns>A Promise that resolves to true if the cache entry is deleted, or false otherwise.</returns>
        public static Var<Promise> CacheDelete(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request)
        {
            return b.CallOnObject<Promise>(cache, "delete", request);
        }

        /// <summary>
        /// The delete() method of the Cache interface finds the Cache entry whose key is the request, and if found, deletes the Cache entry and returns a Promise that resolves to true. If no Cache entry is found, it resolves to false.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request you are looking to delete. This can be a Request object or a URL.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to true if the cache entry is deleted, or false otherwise.</returns>
        public static Var<Promise> CacheDelete(this SyntaxBuilder b, Var<Cache> cache, Var<string> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "delete", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The delete() method of the Cache interface finds the Cache entry whose key is the request, and if found, deletes the Cache entry and returns a Promise that resolves to true. If no Cache entry is found, it resolves to false.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request you are looking to delete. This can be a Request object or a URL.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to true if the cache entry is deleted, or false otherwise.</returns>
        public static Var<Promise> CacheDelete(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "delete", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The keys() method of the Cache interface returns a Promise that resolves to an array of Request objects representing the keys of the Cache. The requests are returned in the same order that they were inserted.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <returns>A Promise that resolves to an array of Request objects.</returns>
        public static Var<Promise> CacheKeys(this SyntaxBuilder b, Var<Cache> cache)
        {
            return b.CallOnObject<Promise>(cache, "keys");
        }

        /// <summary>
        /// The keys() method of the Cache interface returns a Promise that resolves to an array of Request objects representing the keys of the Cache. The requests are returned in the same order that they were inserted.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request want to return, if a specific key is desired. This can be a Request object or a URL.</param>
        /// <returns>A Promise that resolves to an array of Request objects.</returns>
        public static Var<Promise> CacheKeys(this SyntaxBuilder b, Var<Cache> cache, Var<string> request)
        {
            return b.CallOnObject<Promise>(cache, "keys", request);
        }

        /// <summary>
        /// The keys() method of the Cache interface returns a Promise that resolves to an array of Request objects representing the keys of the Cache. The requests are returned in the same order that they were inserted.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request want to return, if a specific key is desired. This can be a Request object or a URL.</param>
        /// <returns>A Promise that resolves to an array of Request objects.</returns>
        public static Var<Promise> CacheKeys(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request)
        {
            return b.CallOnObject<Promise>(cache, "keys", request);
        }

        /// <summary>
        /// The keys() method of the Cache interface returns a Promise that resolves to an array of Request objects representing the keys of the Cache. The requests are returned in the same order that they were inserted.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request want to return, if a specific key is desired. This can be a Request object or a URL.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to an array of Request objects.</returns>
        public static Var<Promise> CacheKeys(this SyntaxBuilder b, Var<Cache> cache, Var<string> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "keys", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The keys() method of the Cache interface returns a Promise that resolves to an array of Request objects representing the keys of the Cache. The requests are returned in the same order that they were inserted.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request want to return, if a specific key is desired. This can be a Request object or a URL.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to an array of Request objects.</returns>
        public static Var<Promise> CacheKeys(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "keys", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The match() method of the Cache interface returns a Promise that resolves to the Response associated with the first matching request in the Cache object. If no match is found, the Promise resolves to undefined.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL string.</param>
        /// <returns>A Promise that resolves to the first Response that matches the request or to undefined if no match is found.</returns>
        public static Var<Promise> CacheMatch(this SyntaxBuilder b, Var<Cache> cache, Var<string> request)
        {
            return b.CallOnObject<Promise>(cache, "match", request);
        }

        /// <summary>
        /// The match() method of the Cache interface returns a Promise that resolves to the Response associated with the first matching request in the Cache object. If no match is found, the Promise resolves to undefined.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL string.</param>
        /// <returns>A Promise that resolves to the first Response that matches the request or to undefined if no match is found.</returns>
        public static Var<Promise> CacheMatch(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request)
        {
            return b.CallOnObject<Promise>(cache, "match", request);
        }

        /// <summary>
        /// The match() method of the Cache interface returns a Promise that resolves to the Response associated with the first matching request in the Cache object. If no match is found, the Promise resolves to undefined.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL string.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to the first Response that matches the request or to undefined if no match is found.</returns>
        public static Var<Promise> CacheMatch(this SyntaxBuilder b, Var<Cache> cache, Var<string> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "match", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The match() method of the Cache interface returns a Promise that resolves to the Response associated with the first matching request in the Cache object. If no match is found, the Promise resolves to undefined.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL string.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to the first Response that matches the request or to undefined if no match is found.</returns>
        public static Var<Promise> CacheMatch(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "match", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The matchAll() method of the Cache interface returns a Promise that resolves to an array of all matching responses in the Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <returns>A Promise that resolves to an array of all matching responses in the Cache object.</returns>
        public static Var<Promise> CacheMatchAll(this SyntaxBuilder b, Var<Cache> cache)
        {
            return b.CallOnObject<Promise>(cache, "matchAll");
        }

        /// <summary>
        /// The matchAll() method of the Cache interface returns a Promise that resolves to an array of all matching responses in the Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL. If this argument is omitted, you will get a copy of all responses in this cache.</param>
        /// <returns>A Promise that resolves to an array of all matching responses in the Cache object.</returns>
        public static Var<Promise> CacheMatchAll(this SyntaxBuilder b, Var<Cache> cache, Var<string> request)
        {
            return b.CallOnObject<Promise>(cache, "matchAll", request);
        }

        /// <summary>
        /// The matchAll() method of the Cache interface returns a Promise that resolves to an array of all matching responses in the Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL. If this argument is omitted, you will get a copy of all responses in this cache.</param>
        /// <returns>A Promise that resolves to an array of all matching responses in the Cache object.</returns>
        public static Var<Promise> CacheMatchAll(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request)
        {
            return b.CallOnObject<Promise>(cache, "matchAll", request);
        }

        /// <summary>
        /// The matchAll() method of the Cache interface returns a Promise that resolves to an array of all matching responses in the Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL. If this argument is omitted, you will get a copy of all responses in this cache.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to an array of all matching responses in the Cache object.</returns>
        public static Var<Promise> CacheMatchAll(this SyntaxBuilder b, Var<Cache> cache, Var<string> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "matchAll", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The matchAll() method of the Cache interface returns a Promise that resolves to an array of all matching responses in the Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request for which you are attempting to find responses in the Cache. This can be a Request object or a URL. If this argument is omitted, you will get a copy of all responses in this cache.</param>
        /// <param name="setOptions"></param>
        /// <returns>A Promise that resolves to an array of all matching responses in the Cache object.</returns>
        public static Var<Promise> CacheMatchAll(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request, System.Action<PropsBuilder<CacheStorageMatchOptions>> setOptions)
        {
            return b.CallOnObject<Promise>(cache, "matchAll", request, b.SetProps(b.NewObj(), setOptions));
        }

        /// <summary>
        /// The put() method of the Cache interface allows key/value pairs to be added to the current Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request object or URL that you want to add to the cache.</param>
        /// <param name="response">The Response you want to match up to the request.</param>
        /// <returns>A Promise that resolves with undefined.</returns>
        public static Var<Promise> CachePut(this SyntaxBuilder b, Var<Cache> cache, Var<string> request, Var<Response> response)
        {
            return b.CallOnObject<Promise>(cache, "put", request, response);
        }

        /// <summary>
        /// The put() method of the Cache interface allows key/value pairs to be added to the current Cache object.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="cache"></param>
        /// <param name="request">The Request object or URL that you want to add to the cache.</param>
        /// <param name="response">The Response you want to match up to the request.</param>
        /// <returns>A Promise that resolves with undefined.</returns>
        public static Var<Promise> CachePut(this SyntaxBuilder b, Var<Cache> cache, Var<Request> request, Var<Response> response)
        {
            return b.CallOnObject<Promise>(cache, "put", request, response);
        }
    }
}
