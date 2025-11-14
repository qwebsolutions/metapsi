using System.IO;
using System.Threading.Tasks;
using Metapsi.Syntax;

namespace Metapsi.Web;

public class CfHttpRequest
{
    public CfHttpRequest(System.Web.HttpRequest request)
    {
        Request = request;
    }

    /// <summary>
    /// Original request
    /// </summary>
    public System.Web.HttpRequest Request { get; }
}

public class CfHttpResponse
{
    public CfHttpResponse(System.Web.HttpResponse response)
    {
        Response = response;
    }

    /// <summary>
    /// Original HTTP response
    /// </summary>
    public System.Web.HttpResponse Response { get; }
}

public class CfHttpContext
{
    public CfHttpContext(System.Web.HttpContext context)
    {
        Context = context;
        Request = new CfHttpRequest(context.Request);
        Response = new CfHttpResponse(context.Response);
    }

    public Metapsi.Web.CfHttpRequest Request { get; private set; }
    public Metapsi.Web.CfHttpResponse Response { get;private set; }

    /// <summary>
    /// Original HTTP context
    /// </summary>
    public System.Web.HttpContext Context { get; }
}

public static class HttpExtensions
{
    public static Stream Body(this CfHttpRequest request)
    {
        return request.Request.InputStream;
    }

    public static Stream Body(this CfHttpResponse response)
    {
        return response.Response.OutputStream;
    }

    public static string GetHeader(this CfHttpRequest httpRequest, string key)
    {
        return httpRequest.Request.Headers[key];
    }

    public static async Task WriteAsync(this CfHttpResponse response, string content)
    {
        response.Response.Write(content);
    }

    public static async Task WriteHtmlDocument(this CfHttpResponse response, Metapsi.Html.HtmlDocument document)
    {
        response.Response.ContentType = "text/html";
        response.Response.Write(document.ToHtml());
    }

    public static async Task WriteJsonReponse<T>(this CfHttpResponse response, T value)
    {
        response.Response.ContentType = "application/json";
        response.Response.Write(Metapsi.Serialize.ToJson(value));
    }

    public static async Task WriteJsModuleReponse(this CfHttpResponse response, Metapsi.Syntax.Module module)
    {
        response.Response.ContentType = "text/javascript";
        response.Response.Write(module.ToJs());
    }

    public static async Task SetStatusCode(this CfHttpResponse httpResponse, int statusCode)
    {
        httpResponse.Response.StatusCode = statusCode;
    }

    public static async Task<T> ReadJsonBody<T>(this CfHttpRequest request)
    {
        using (var reader = new StreamReader(request.Request.InputStream))
        {
            string result = reader.ReadToEnd();
            return Metapsi.Serialize.FromJson<T>(result);
        }
    }

    public static async Task<object> ReadJsonBody(this CfHttpRequest request, System.Type type)
    {
        using (var reader = new StreamReader(request.Request.InputStream))
        {
            string result = reader.ReadToEnd();
            return Metapsi.Serialize.FromJson(type, result);
        }
    }
}