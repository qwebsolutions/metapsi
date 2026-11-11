using Metapsi.Html;
using Metapsi.Syntax;
using System.IO;
using System.Threading.Tasks;

namespace Metapsi.Web;

public static partial class HttpExtensions
{
    public static async Task WriteHtmlDocument(this CfHttpResponse response, Metapsi.Html.HtmlDocument document, ToHtmlOptions options)
    {
        response.SetContentTypeHeader("text/html");
        await response.WriteAsync(document.ToHtml(options));
    }

    public static async Task WriteJsonResponse<T>(this CfHttpResponse response, T value, IJsonSerializer serializer)
    {
        response.SetContentTypeHeader("application/json");
        await response.WriteAsync(serializer.ToJson(value));
    }

    public static async Task WriteJsModuleResponse(this CfHttpResponse response, Metapsi.Syntax.Module module, ToJavaScriptOptions options)
    {
        response.SetContentTypeHeader("text/javascript");
        await response.WriteAsync(module.ToJs(options));
    }

    public static async Task<T> ReadJsonBody<T>(this CfHttpRequest request, IJsonSerializer serializer)
    {
        using (var reader = new StreamReader(request.BodyStream()))
        {
            string result = reader.ReadToEnd();
            return serializer.FromJson<T>(result);
        }
    }

    public static async Task<object> ReadJsonBody(this CfHttpRequest request, System.Type type, IJsonSerializer serializer)
    {
        using (var reader = new StreamReader(request.BodyStream()))
        {
            string result = reader.ReadToEnd();
            return serializer.FromJson(type, result);
        }
    }
}