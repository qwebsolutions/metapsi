using Metapsi.Syntax;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Web;

public class CfHttpRequest
{
    public CfHttpRequest(Microsoft.AspNetCore.Http.HttpRequest request)
    {
        this.Request = request;
    }
    /// <summary>
    /// Original request
    /// </summary>
    public Microsoft.AspNetCore.Http.HttpRequest Request { get; }
}

public class CfHttpResponse
{
    public CfHttpResponse(Microsoft.AspNetCore.Http.HttpResponse response)
    {
        Response = response;
    }

    /// <summary>
    /// Original HTTP response
    /// </summary>
    public Microsoft.AspNetCore.Http.HttpResponse Response { get; }
}

/// <summary>
/// Cross-framework HttpContext
/// </summary>
/// <remarks>This is just a wrapper on platform-specific HttpContext. It enables cross-framework extension methods</remarks>
public class CfHttpContext
{
    public CfHttpContext(Microsoft.AspNetCore.Http.HttpContext context)
    {
        Context = context;
        Request = new CfHttpRequest(context.Request);
        Response = new CfHttpResponse(context.Response);
    }

    public Metapsi.Web.CfHttpRequest Request { get; private set; }
    public Metapsi.Web.CfHttpResponse Response { get; private set; }

    /// <summary>
    /// Original HTTP context
    /// </summary>
    public Microsoft.AspNetCore.Http.HttpContext Context { get; }
}

public static class HttpExtensions
{
    public static string GetMimeTypeForFileExtension(string filePath)
    {
        const string DefaultContentType = "application/octet-stream";

        var provider = new FileExtensionContentTypeProvider();

        if (!provider.TryGetContentType(filePath, out string contentType))
        {
            contentType = DefaultContentType;
        }

        return contentType;
    }

    public static Stream Body(this CfHttpRequest request)
    {
        return request.Request.Body;
    }

    public static Stream Body(this CfHttpResponse response)
    {
        return response.Response.Body;
    }

    public static string GetHeader(this CfHttpRequest httpRequest, string key)
    {
        httpRequest.Request.Headers.TryGetValue(key, out var value);
        return value;
    }

    public static async Task WriteAsync(this CfHttpResponse response, string content)
    {
        await response.Response.WriteAsync(content);
    }

    public static async Task WriteAsync(this CfHttpResponse response, byte[] content)
    {
        await response.Response.BodyWriter.WriteAsync(content);
    }

    public static void SetContentLengthHeader(this CfHttpResponse response, long contentLength)
    {
        response.Response.Headers.ContentLength = contentLength;
    }

    public static void SetContentTypeHeader(this CfHttpResponse response, string contentType)
    {
        response.Response.Headers.ContentType = contentType;
    }

    public static void SetCacheControlHeader(this CfHttpResponse response, string value)
    {
        response.Response.Headers.CacheControl = value;
    }

    public static async Task WriteHtmlDocument(this CfHttpResponse response, Metapsi.Html.HtmlDocument document)
    {
        response.Response.ContentType = "text/html";
        await response.Response.WriteAsync(document.ToHtml());
    }

    public static async Task WriteJsModuleResponse(this CfHttpResponse response, Metapsi.Syntax.Module module)
    {
        response.Response.ContentType = "text/javascript";
        await response.Response.WriteAsync(module.ToJs());
    }

    public static async Task WriteJsonResponse<T>(this CfHttpResponse response, T value)
    {
        response.Response.ContentType = "application/json";
        await response.Response.WriteAsync(Metapsi.Serialize.ToJson(value));
    }

    public static async Task SetStatusCode(this CfHttpResponse httpResponse, int statusCode)
    {
        httpResponse.Response.StatusCode = statusCode;
    }

    public static async Task<T> ReadJsonBody<T>(this CfHttpRequest request)
    {
        return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(request.Request.Body);
    }

    public static async Task<object> ReadJsonBody(this CfHttpRequest request, System.Type type)
    {
        return await System.Text.Json.JsonSerializer.DeserializeAsync(request.Request.Body, type);
    }

    public static string GetEndpointUrl(this HttpContext httpContext, string name)
    {
        var linkGenerator = httpContext.RequestServices.GetRequiredService<LinkGenerator>();
        var path = linkGenerator.GetPathByName(name);

        if (string.IsNullOrEmpty(path))
        {
            // It has pattern parameters
            var endpointDataSource = httpContext.RequestServices.GetRequiredService<EndpointDataSource>();
            foreach (var endpoint in endpointDataSource.Endpoints)
            {
                if (endpoint is RouteEndpoint routeEndpoint)
                {
                    var endpointName = routeEndpoint.Metadata.GetMetadata<IEndpointNameMetadata>();
                    if (endpointName != null)
                    {
                        if (endpointName.EndpointName == name)
                        {
                            Dictionary<string, string> endpointArguments = new Dictionary<string, string>();
                            var pattern = routeEndpoint.RoutePattern;
                            // pattern.Parameters gives you the parameter info
                            foreach (var param in pattern.Parameters)
                            {
                                endpointArguments.Add(param.Name, "-");
                            }

                            path = linkGenerator.GetPathByName(name, endpointArguments);
                        }
                    }
                }
            }
        }

        if (!string.IsNullOrEmpty(path))
            path = path.TrimEnd('/', '-');

        return path;
    }
}