using System.IO;
using System.Threading.Tasks;

namespace Metapsi.Web;

public class HttpRequest
{
    public HttpRequest(System.Web.HttpRequest request)
    {
        Request = request;
    }

    /// <summary>
    /// Original request
    /// </summary>
    public System.Web.HttpRequest Request { get; }
}

public class HttpResponse
{
    public HttpResponse(System.Web.HttpResponse response)
    {
        Response = response;
    }

    /// <summary>
    /// Original HTTP response
    /// </summary>
    public System.Web.HttpResponse Response { get; }
}

public class HttpContext
{
    public HttpContext(System.Web.HttpContext context)
    {
        Context = context;
        Request = new HttpRequest(context.Request);
        Response = new HttpResponse(context.Response);
    }

    public Metapsi.Web.HttpRequest Request { get; private set; }
    public Metapsi.Web.HttpResponse Response { get;private set; }

    /// <summary>
    /// Original HTTP context
    /// </summary>
    public System.Web.HttpContext Context { get; }
}

public static class HttpExtensions
{
    public static Stream Body(this HttpRequest request)
    {
        return request.Request.InputStream;
    }

    public static async Task WriteHtmlDocument(this HttpResponse response, Metapsi.Html.HtmlDocument document)
    {
        await Metapsi.MetadataExtensions.LoadMetadataResources(document.Metadata);

        response.Response.ContentType = "text/html";
        response.Response.Write(document.ToHtml());
    }

    public static async Task WriteJsonReponse<T>(this HttpResponse response, T value)
    {
        response.Response.ContentType = "application/json";
        response.Response.Write(Metapsi.Serialize.ToJson(value));
    }

    public static async Task<T> ReadJsonBody<T>(this HttpRequest request)
    {
        return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(request.Request.InputStream);
    }
}