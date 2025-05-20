using Metapsi.Html;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Metapsi.Web;

public class HttpRequest
{
    public HttpRequest(Microsoft.AspNetCore.Http.HttpRequest request)
    {
        this.Request = request;
    }
    /// <summary>
    /// Original request
    /// </summary>
    public Microsoft.AspNetCore.Http.HttpRequest Request { get; }
}

public class HttpResponse
{
    public HttpResponse(Microsoft.AspNetCore.Http.HttpResponse response)
    {
        Response = response;
    }

    /// <summary>
    /// Original HTTP response
    /// </summary>
    public Microsoft.AspNetCore.Http.HttpResponse Response { get; }
}

public class HttpContext
{
    public HttpContext(Microsoft.AspNetCore.Http.HttpContext context)
    {
        Context = context;
        Request = new HttpRequest(context.Request);
        Response = new HttpResponse(context.Response);
    }

    public Metapsi.Web.HttpRequest Request { get; private set; }
    public Metapsi.Web.HttpResponse Response { get; private set; }

    /// <summary>
    /// Original HTTP context
    /// </summary>
    public Microsoft.AspNetCore.Http.HttpContext Context { get; }
}

public static class HttpExtensions
{
    public static Stream Body(this HttpRequest request)
    {
        return request.Request.Body;
    }

    public static Stream Body(this HttpResponse response)
    {
        return response.Response.Body;
    }

    public static string GetHeader(this HttpRequest httpRequest, string key)
    {
        httpRequest.Request.Headers.TryGetValue(key, out var value);
        return value;
    }

    public static async Task WriteAsync(this HttpResponse response, string content)
    {
        await response.Response.WriteAsync(content);
    }

    public static async Task WriteHtmlDocument(this HttpResponse response, Metapsi.Html.HtmlDocument document)
    {
        response.Response.ContentType = "text/html";
        await response.Response.WriteAsync(document.ToHtml());
    }

    public static async Task WriteJsonReponse<T>(this HttpResponse response, T value)
    {
        response.Response.ContentType = "application/json";
        await response.Response.WriteAsync(Metapsi.Serialize.ToJson(value));
    }

    public static async Task SetStatusCode(this HttpResponse httpResponse, int statusCode)
    {
        httpResponse.Response.StatusCode = statusCode;
    }

    public static async Task<T> ReadJsonBody<T>(this HttpRequest request)
    {
        return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(request.Request.Body);
    }
}