using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The RequestInit dictionary of the Fetch API represents the set of options that can be used to configure a fetch request.
/// </summary>
public interface RequestInit
{
    /// <summary>
    /// The request body contains content to send to the server, for example in a POST or PUT request.
    /// </summary>
    DynamicObject body { get; set; }

    /// <summary>
    /// The cache mode you want to use for the request
    /// </summary>
    string cache { get; set; }

    /// <summary>
    /// Controls whether or not the browser sends credentials with the request, as well as whether any Set-Cookie response headers are respected. Credentials are cookies, TLS client certificates, or authentication headers containing a username and password.
    /// </summary>
    string credentials { get; set; }

    /// <summary>
    /// Any headers you want to add to your request, contained within a Headers object or an object literal whose keys are the names of headers and whose values are the header values.
    /// </summary>
    DynamicObject headers { get; set; }

    /// <summary>
    /// Contains the subresource integrity value of the request.
    /// </summary>
    string integrity { get; set; }

    /// <summary>
    /// When set to true, the browser will not abort the associated request if the page that initiated it is unloaded before the request is complete
    /// </summary>
    bool keepalive { get; set; }

    /// <summary>
    /// The request method. Defaults to GET.
    /// </summary>
    string method { get; set; }

    /// <summary>
    /// Sets cross-origin behavior for the request. Defaults to 'cors'.
    /// </summary>
    string mode { get; set; }

    /// <summary>
    /// Specifies the priority of the fetch request relative to other requests of the same type. Defaults to 'auto'.
    /// </summary>
    string priority { get; set; }

    /// <summary>
    /// Determines the browser's behavior in case the server replies with a redirect status. Defaults to 'follow'.
    /// </summary>
    string redirect { get; set; }

    /// <summary>
    /// A string specifying the value to use for the request's Referer header. 
    /// </summary>
    string referrer { get; set; }

    /// <summary>
    /// A string that sets a policy for the Referer header. The syntax and semantics of this option are exactly the same as for the Referrer-Policy header.
    /// </summary>
    string referrerPolicy { get; set; }

    /// <summary>
    /// An AbortSignal. If this option is set, the request can be canceled by calling abort() on the corresponding AbortController.
    /// </summary>
    AbortSignal signal { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class RequestInitExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<string> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<ArrayBuffer> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<Blob> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<DataView> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<File> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<FormData> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<TypedArray> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<URLSearchParams> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="body"></param>
    public static void SetBody(this PropsBuilder<RequestInit> b, Var<ReadableStream> body)
    {
        b.Set(x => x.body, body.As<DynamicObject>());
    }

    /// <summary>
    /// The browser looks in its HTTP cache for a response matching the request.
    /// <para>If there is a match and it is fresh, it will be returned from the cache.</para>
    /// <para>If there is a match but it is stale, the browser will make a conditional request to the remote server.If the server indicates that the resource has not changed, it will be returned from the cache.Otherwise the resource will be downloaded from the server and the cache will be updated.</para>
    /// <para>If there is no match, the browser will make a normal request, and will update the cache with the downloaded resource.</para>
    /// </summary>
    /// <param name="b"></param>
    public static void SetCacheDefault(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.cache, "default");
    }

    /// <summary>
    /// The browser fetches the resource from the remote server without first looking in the cache, and will not update the cache with the downloaded resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetCacheNoStore(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.cache, "no-store");
    }

    /// <summary>
    /// The browser fetches the resource from the remote server without first looking in the cache, but then will update the cache with the downloaded resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetCacheReload(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.cache, "reload");
    }

    /// <summary>
    /// The browser looks in its HTTP cache for a response matching the request.
    /// <para>If there is a match, fresh or stale, the browser will make a conditional request to the remote server.If the server indicates that the resource has not changed, it will be returned from the cache.Otherwise the resource will be downloaded from the server and the cache will be updated.</para>
    /// <para>If there is no match, the browser will make a normal request, and will update the cache with the downloaded resource.</para>
    /// </summary>
    /// <param name="b"></param>
    public static void SetCacheNoCache(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.cache, "no-cache");
    }

    /// <summary>
    /// The browser looks in its HTTP cache for a response matching the request.
    /// <para>If there is a match, fresh or stale, it will be returned from the cache.</para>
    /// <para>If there is no match, the browser will make a normal request, and will update the cache with the downloaded resource.</para>
    /// </summary>
    /// <param name="b"></param>
    public static void SetCacheForceCache(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.cache, "force-cache");
    }

    /// <summary>
    /// Never send credentials in the request or include credentials in the response.
    /// </summary>
    /// <param name="b"></param>
    public static void SetCredentialsOmit(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.credentials, "omit");
    }

    /// <summary>
    /// Only send and include credentials for same-origin requests.
    /// </summary>
    /// <param name="b"></param>
    public static void SetCredentialsSameOrigin(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.credentials, "same-origin");
    }

    /// <summary>
    /// Always include credentials, even for cross-origin requests.
    /// </summary>
    /// <param name="b"></param>
    public static void SetCredentialsInclude(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.credentials, "include");
    }

    /// <summary>
    /// Any headers you want to add to your request, contained within a Headers object or an object literal whose keys are the names of headers and whose values are the header values.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="headers"></param>
    public static void SetHeaders(this PropsBuilder<RequestInit> b, Var<Headers> headers)
    {
        b.Set(x => x.headers, headers.As<DynamicObject>());
    }

    /// <summary>
    /// Any headers you want to add to your request, contained within a Headers object or an object literal whose keys are the names of headers and whose values are the header values.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="setHeaders"></param>
    public static void SetHeaders(this PropsBuilder<RequestInit> b, System.Action<PropsBuilder<HeadersInit>> setHeaders)
    {
        b.Set(x => x.headers, b.SetProps(b.NewObj<DynamicObject>(), setHeaders).As<DynamicObject>());
    }

    /// <summary>
    /// The GET method requests a representation of the specified resource. Requests using GET should only retrieve data and should not contain a request content.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodGet(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "GET");
    }

    /// <summary>
    /// The HEAD method asks for a response identical to a GET request, but without a response body.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodHead(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "HEAD");
    }

    /// <summary>
    /// The POST method submits an entity to the specified resource, often causing a change in state or side effects on the server.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodPost(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "POST");
    }

    /// <summary>
    /// The PUT method replaces all current representations of the target resource with the request content.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodPut(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "PUT");
    }

    /// <summary>
    /// The DELETE method deletes the specified resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodDelete(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "DELETE");
    }

    /// <summary>
    /// The CONNECT method establishes a tunnel to the server identified by the target resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodConnect(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "CONNECT");
    }

    /// <summary>
    /// The OPTIONS method describes the communication options for the target resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodOptions(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "OPTIONS");
    }

    /// <summary>
    /// The TRACE method performs a message loop-back test along the path to the target resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodTrace(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "TRACE");
    }

    /// <summary>
    /// The PATCH method applies partial modifications to a resource.
    /// </summary>
    /// <param name="b"></param>
    public static void SetMethodPatch(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.method, "PATCH");
    }

    /// <summary>
    /// Disallows cross-origin requests. If a same-origin request is sent to a different origin, the result is a network error.
    /// </summary>
    /// <param name="b"></param>
    public static void SetModeSameOrigin(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.mode, "same-origin");
    }

    /// <summary>
    /// If the request is cross-origin then it will use the Cross-Origin Resource Sharing (CORS) mechanism. Only CORS-safelisted response headers are exposed in the response.
    /// </summary>
    /// <param name="b"></param>
    public static void SetModeCors(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.mode, "cors");
    }

    /// <summary>
    /// Disables CORS for cross-origin requests. 
    /// </summary>
    /// <param name="b"></param>
    public static void SetModeNoCors(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.mode, "no-cors");
    }

    /// <summary>
    /// Used only by HTML navigation. A navigate request is created only while navigating between documents.
    /// </summary>
    /// <param name="b"></param>
    public static void SetModeNavigate(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.mode, "navigate");
    }

    /// <summary>
    /// A high priority fetch request relative to other requests of the same type.
    /// </summary>
    /// <param name="b"></param>
    public static void SetPriorityHigh(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.priority, "high");
    }

    /// <summary>
    /// A low priority fetch request relative to other requests of the same type.
    /// </summary>
    /// <param name="b"></param>
    public static void SetPriorityLow(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.priority, "low");
    }

    /// <summary>
    /// No user preference for the fetch priority. It is used if no value is set or if an invalid value is set.
    /// </summary>
    /// <param name="b"></param>
    public static void SetPriorityAuto(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.priority, "auto");
    }

    /// <summary>
    /// Automatically follow redirects.
    /// </summary>
    /// <param name="b"></param>
    public static void SetRedirectFollow(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.redirect, "follow");
    }

    /// <summary>
    /// Reject the promise with a network error when a redirect status is returned.
    /// </summary>
    /// <param name="b"></param>
    public static void SetRedirectError(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.redirect, "error");
    }

    /// <summary>
    /// Return a response with almost all fields filtered out, to enable a service worker to store the response and later replay it.
    /// </summary>
    /// <param name="b"></param>
    public static void SetRedirectManual(this PropsBuilder<RequestInit> b)
    {
        b.Set(x => x.redirect, "manual");
    }
}
