using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The Request interface of the Fetch API represents a resource request.
/// </summary>
public interface Request
{
    /// <summary>
    /// The body read-only property of the Request interface contains a ReadableStream with the body contents that have been added to the request. Note that a request using the GET or HEAD method cannot have a body and null is returned in these cases.
    /// </summary>
    ReadableStream body { get; }

    /// <summary>
    /// The bodyUsed read-only property of the Request interface is a boolean value that indicates whether the request body has been read yet.
    /// </summary>
    bool bodyUsed { get; }

    /// <summary>
    /// The cache read-only property of the Request interface contains the cache mode of the request. It controls how the request will interact with the browser's HTTP cache.
    /// The available values are:
    /// <para>"default" The browser looks for a matching request in its HTTP cache. If there is a match and it is fresh, it will be returned from the cache.If there is a match but it is stale, the browser will make a conditional request to the remote server.If the server indicates that the resource has not changed, it will be returned from the cache.Otherwise the resource will be downloaded from the server and the cache will be updated. If there is no match, the browser will make a normal request, and will update the cache with the downloaded resource.</para>
    /// <para>"no-store" The browser fetches the resource from the remote server without first looking in the cache, and will not update the cache with the downloaded resource.</para>
    /// <para>"reload" The browser fetches the resource from the remote server without first looking in the cache, but then will update the cache with the downloaded resource.</para>
    /// <para>"no-cache" The browser looks for a matching request in its HTTP cache. If there is a match, fresh or stale, the browser will make a conditional request to the remote server.If the server indicates that the resource has not changed, it will be returned from the cache.Otherwise the resource will be downloaded from the server and the cache will be updated.If there is no match, the browser will make a normal request, and will update the cache with the downloaded resource.</para>
    /// <para>"force-cache" The browser looks for a matching request in its HTTP cache. If there is a match, fresh or stale, it will be returned from the cache. If there is no match, the browser will make a normal request, and will update the cache with the downloaded resource.</para>
    /// <para>"only-if-cached" The browser looks for a matching request in its HTTP cache (experimental). If there is a match, fresh or stale, it will be returned from the cache. If there is no match, the browser will respond with a 504 Gateway timeout status. The "only-if-cached" mode can only be used if the request's mode is "same-origin". Cached redirects will be followed if the request's redirect property is "follow" and the redirects do not violate the "same-origin" mode.</para>
    /// </summary>
    string cache { get; }

    /// <summary>
    /// The credentials read-only property of the Request interface reflects the value given to the Request() constructor in the credentials option. It determines whether or not the browser sends credentials with the request, as well as whether any Set-Cookie response headers are respected.
    /// <para>"omit" Never send credentials in the request or include credentials in the response.</para>
    /// <para>"same-origin" Only send and include credentials for same-origin requests.</para>
    /// <para>"include" Always include credentials, even for cross-origin requests.</para>
    /// </summary>
    string credentials { get; }

    /// <summary>
    /// The destination read-only property of the Request interface returns a string describing the type of content being requested. The string must be one of the audio, audioworklet, document, embed, fencedframe, font, frame, iframe, image, json, manifest, object, paintworklet, report, script, sharedworker, style, track, video, worker or xslt strings, or the empty string, which is the default value.
    /// </summary>
    string destination { get; }

    /// <summary>
    /// The headers read-only property of the Request interface contains the Headers object associated with the request.
    /// </summary>
    Headers headers { get; }

    /// <summary>
    /// The integrity read-only property of the Request interface contains the subresource integrity value of the request.
    /// </summary>
    string integrity { get; }

    /// <summary>
    /// The isHistoryNavigation read-only property of the Request interface is a boolean indicating whether the request is a history navigation.
    /// </summary>
    bool isHistoryNavigation { get; }

    /// <summary>
    /// The keepalive read-only property of the Request interface contains the request's keepalive setting (true or false), which indicates whether the browser will keep the associated request alive if the page that initiated it is unloaded before the request is complete.
    /// </summary>
    bool keepalive { get; }

    /// <summary>
    /// The method read-only property of the Request interface contains the request's method (GET, POST, etc.)
    /// </summary>
    string method { get; }

    /// <summary>
    /// The mode read-only property of the Request interface contains the mode of the request (e.g., cors, no-cors, same-origin, or navigate.) This is used to determine if cross-origin requests lead to valid responses, and which properties of the response are readable.
    /// </summary>
    string mode { get; }

    /// <summary>
    /// The redirect read-only property of the Request interface contains the mode for how redirects are handled. ("follow", "error", "manual")
    /// </summary>
    string redirect { get; }

    /// <summary>
    /// The referrer read-only property of the Request interface is set by the user agent to be the referrer of the Request. (e.g., client, no-referrer, or a URL.)
    /// <para> Note: If referrer's value is no-referrer, it returns an empty string.</para>
    /// </summary>
    string referrer { get; }

    /// <summary>
    /// The referrerPolicy read-only property of the Request interface returns the referrer policy, which governs what referrer information, sent in the Referer header, should be included with the request.
    /// </summary>
    string referrerPolicy { get; }

    /// <summary>
    /// The read-only signal property of the Request interface returns the AbortSignal associated with the request.
    /// </summary>
    AbortSignal signal { get; }

    /// <summary>
    /// The url read-only property of the Request interface contains the URL of the request.
    /// </summary>
    string url { get; }
}

/// <summary>
/// 
/// </summary>
public static class RequestExtensions
{
    /// <summary>
    /// The arrayBuffer() method of the Request interface reads the request body and returns it as a promise that resolves with an ArrayBuffer.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns>A promise that resolves with an ArrayBuffer.</returns>
    public static Var<Promise> RequestArrayBuffer(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Promise>(request, "arrayBuffer");
    }

    /// <summary>
    /// The blob() method of the Request interface reads the request body and returns it as a promise that resolves with a Blob.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> RequestBlob(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Promise>(request, "blob");
    }

    /// <summary>
    /// The bytes() method of the Request interface reads the request body and returns it as a promise that resolves with an Uint8Array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> RequestBytes(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Promise>(request, "blob");
    }

    /// <summary>
    /// The clone() method of the Request interface creates a copy of the current Request object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Request> RequestClone(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Request>(request, "clone");
    }

    /// <summary>
    /// The formData() method of the Request interface reads the request body and returns it as a promise that resolves with a FormData object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> RequestFormData(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Promise>(request, "formData");
    }

    /// <summary>
    /// The json() method of the Request interface reads the request body and returns it as a promise that resolves with the result of parsing the body text as JSON.Note that despite the method being named json(), the result is not JSON but is instead the result of taking JSON as input and parsing it to produce a JavaScript object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> RequestJson(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Promise>(request, "json");
    }

    /// <summary>
    /// The text() method of the Request interface reads the request body and returns it as a promise that resolves with a String. The response is always decoded using UTF-8.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Var<Promise> RequestText(this SyntaxBuilder b, Var<Request> request)
    {
        return b.CallOnObject<Promise>(request, "text");
    }
}
