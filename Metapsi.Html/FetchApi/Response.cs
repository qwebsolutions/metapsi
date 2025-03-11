using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The Response interface of the Fetch API represents the response to a request.
/// </summary>
public interface Response
{
    /// <summary>
    /// The body read-only property of the Response interface is a ReadableStream of the body contents.
    /// </summary>
    ReadableStream body { get; }

    /// <summary>
    /// The bodyUsed read-only property of the Response interface is a boolean value that indicates whether the body has been read yet.
    /// </summary>
    bool bodyUsed { get; }

    /// <summary>
    /// The headers read-only property of the Response interface contains the Headers object associated with the response.
    /// </summary>
    Headers headers { get; }

    /// <summary>
    /// The ok read-only property of the Response interface contains a Boolean stating whether the response was successful (status in the range 200-299) or not.
    /// </summary>
    bool ok { get; }

    /// <summary>
    /// The redirected read-only property of the Response interface indicates whether or not the response is the result of a request you made which was redirected.
    /// </summary>
    bool redirected { get; }

    /// <summary>
    /// The status read-only property of the Response interface contains the HTTP status codes of the response.
    /// </summary>
    int status { get; }

    /// <summary>
    /// The statusText read-only property of the Response interface contains the status message corresponding to the HTTP status code in Response.status.
    /// </summary>
    string statusText { get; }

    /// <summary>
    /// The type read-only property of the Response interface contains the type of the response. It can be one of the following:
    /// <para>basic: Normal, same origin response, with all headers exposed except "Set-Cookie".</para>
    /// <para>cors: Response was received from a valid cross-origin request.Certain headers and the body may be accessed.</para>
    /// <para>error: Network error. No useful information describing the error is available.The Response's status is 0, headers are empty and immutable. This is the type for a Response obtained from Response.error().</para>
    /// <para>opaque: Response for "no-cors" request to cross-origin resource. Severely restricted.</para>
    /// <para>opaqueredirect: The fetch request was made with redirect: "manual". The Response's status is 0, headers are empty, body is null and trailer is empty.</para>
    /// <para>Note: An "error" Response never really gets exposed to script: such a response to a fetch() would reject the promise.</para>
    /// </summary>
    string type { get; }

    /// <summary>
    /// The url read-only property of the Response interface contains the URL of the response. The value of the url property will be the final URL obtained after any redirects.
    /// </summary>
    string url { get; }
}

/// <summary>
/// An options object containing any custom settings that you want to apply to the response
/// </summary>
public interface ResponseOptions
{
    /// <summary>
    /// The status code for the response. The default value is 200.
    /// </summary>
    int status { get; set; }

    /// <summary>
    /// The status message associated with the status code, such as "OK". The default value is ""
    /// </summary>
    string statusText { get; set; }

    /// <summary>
    /// Any headers you want to add to your response, contained within a Headers object
    /// </summary>
    Headers headers { get; set; }
}

/// <summary>
/// 
/// </summary>
public static class ResponseExtensions
{
    /// <summary>
    /// The error() static method of the Response interface returns a new Response object associated with a network error. This is mainly useful when writing service workers: it enables a service worker to send a response from a fetch event handler that will cause the fetch() call in the main app code to reject the promise. An error response has its type set to error.
    /// </summary>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<Response> ResponseError(this SyntaxBuilder b)
    {
        return b.CallOnObject<Response>(
            b.GetProperty<DynamicObject>(b.Self(), "Response"),
            "error");
    }


    /// <summary>
    /// The json() static method of the Response interface returns a Response that contains the provided JSON data as body, and a Content-Type header which is set to application/json.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="data">The JSON data to be used as the response body.</param>
    /// <returns>A Response object.</returns>
    public static Var<Response> ResponseJson(this SyntaxBuilder b, IVariable data)
    {
        return b.CallOnObject<Response>(
            b.GetProperty<DynamicObject>(b.Self(), "Response"),
            "json",
            data);
    }

    /// <summary>
    /// The json() static method of the Response interface returns a Response that contains the provided JSON data as body, and a Content-Type header which is set to application/json. The response status, status message, and additional headers can also be set.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="data">The JSON data to be used as the response body.</param>
    /// <param name="setOptions">Builds options object containing settings for the response, including the status code, status text, and headers. This is the same as the options parameter of the Response() constructor.</param>
    /// <returns>A Response object.</returns>
    public static Var<Response> ResponseJson(this SyntaxBuilder b, IVariable data, System.Action<PropsBuilder<ResponseOptions>> setOptions)
    {
        var options = b.SetProps(setOptions);
        return b.CallOnObject<Response>(
            b.GetProperty<DynamicObject>(b.Self(), "Response"),
            "json",
            data,
            options);
    }

    /// <summary>
    /// The redirect() static method of the Response interface returns a Response resulting in a redirect to the specified URL.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="url">The URL that the new response is to originate from.</param>
    /// <returns>A Response object.</returns>
    public static Var<Response> ResponseRedirect(this SyntaxBuilder b, Var<string> url)
    {
        return b.CallOnObject<Response>(
            b.GetProperty<DynamicObject>(b.Self(), "Response"),
            "redirect",
            url);
    }

    /// <summary>
    /// The redirect() static method of the Response interface returns a Response resulting in a redirect to the specified URL.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="url">The URL that the new response is to originate from.</param>
    /// <param name="status">An optional number indicating the status code for the response: one of 301, 302, 303, 307, or 308. If omitted, 302 Found is used by default.</param>
    /// <returns></returns>
    public static Var<Response> ResponseRedirect(this SyntaxBuilder b, Var<string> url, Var<int> status)
    {
        return b.CallOnObject<Response>(
            b.GetProperty<DynamicObject>(b.Self(), "Response"),
            "redirect",
            url,
            status);
    }

    /// <summary>
    /// The arrayBuffer() method of the Response interface takes a Response stream and reads it to completion. It returns a promise that resolves with an ArrayBuffer.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Promise> ResponseArrayBuffer(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Promise>(response, "arrayBuffer");
    }

    /// <summary>
    /// The blob() method of the Response interface takes a Response stream and reads it to completion. It returns a promise that resolves with a Blob.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Promise> ResponseBlob(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Promise>(response, "blob");
    }

    /// <summary>
    /// The bytes() method of the Response interface takes a Response stream and reads it to completion. It returns a promise that resolves with a Uint8Array.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Promise> ResponseBytes(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Promise>(response, "bytes");
    }

    /// <summary>
    /// The clone() method of the Response interface creates a clone of a response object, identical in every way, but stored in a different variable.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Response> ResponseClone(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Response>(response, "clone");
    }

    /// <summary>
    /// The formData() method of the Response interface takes a Response stream and reads it to completion. It returns a promise that resolves with a FormData object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Promise> ResponseFormData(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Promise>(response, "formData");
    }

    /// <summary>
    /// The json() method of the Response interface takes a Response stream and reads it to completion. It returns a promise which resolves with the result of parsing the body text as JSON. Note that despite the method being named json(), the result is not JSON but is instead the result of taking JSON as input and parsing it to produce a JavaScript object.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Promise> ResponseJson(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Promise>(response, "json");
    }

    /// <summary>
    /// The text() method of the Response interface takes a Response stream and reads it to completion. It returns a promise that resolves with a String. The response is always decoded using UTF-8.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="response"></param>
    /// <returns></returns>
    public static Var<Promise> ResponseText(this SyntaxBuilder b, Var<Response> response)
    {
        return b.CallOnObject<Promise>(response, "text");
    }
}