using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using System.Net.Http;
using System.Linq;

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

    public static async Task WriteHtmlDocument(this CfHttpResponse response, Metapsi.Html.HtmlDocument document)
    {
        response.Response.ContentType = "text/html";
        await response.Response.WriteAsync(document.ToHtml());
    }

    public static async Task WriteJsonReponse<T>(this CfHttpResponse response, T value)
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


    //public static Func<RouteDescription, string> FindRelativeUrl(
    //    this Metapsi.Web.CfHttpContext httpContext,
    //    string rootUrl,
    //    Dictionary<string, string> relative)
    //{
    //    return (RouteDescription route) =>
    //    {
    //        var absolute = new Dictionary<string, string>();
    //        absolute.Add("root-url", rootUrl);
    //        foreach (var entry in relative)
    //        {
    //            absolute.Add(entry.Key, rootUrl + "/" + entry.Value);
    //        }
    //        return absolute[route.Name];
    //    };
    //}

    //public static Func<RouteDescription, string> FindUrl(
    //    this Metapsi.Web.CfHttpContext httpContext,
    //    string baseEndpointName,
    //    Dictionary<string, string> relative)
    //{
    //    return (RouteDescription route) =>
    //    {
    //        var rootUrl = httpContext.GetEndpointUrl(baseEndpointName);
    //        var absolute = new Dictionary<string, string>();
    //        absolute.Add("root-url", rootUrl);
    //        foreach (var entry in relative)
    //        {
    //            absolute.Add(entry.Key, rootUrl + "/" + entry.Value);
    //        }
    //        return absolute[route.Name];
    //    };
    //}

    public static string GetEndpointUrl(this HttpContext httpContext, string name)
    {
        var linkGenerator = httpContext.RequestServices.GetRequiredService<LinkGenerator>();
        return linkGenerator.GetPathByName(name).TrimEnd('/');
    }

    public static void MapApp(this IEndpointRouteBuilder endpoint, App.Setup app, Initializer initializer = null)
    {
        if (initializer == null)
        {
            initializer = new Initializer();
        }

        List<IRegisterAppFeature> autoRegisterActions = null;

        foreach (var feature in app.Features)
        {
            if (feature.Value.Configuration != null)
            {
                if (!initializer.Actions.ContainsKey(feature.Key))
                {
                    if (autoRegisterActions == null)
                    {
                        autoRegisterActions = AutoLoader.FindAllLoaded<IRegisterAppFeature>();
                    }

                    initializer.Actions[feature.Key] = () =>
                    {
                        var featureInitializers = autoRegisterActions.Where(x => x.FeatureName == feature.Key);
                        if (!featureInitializers.Any())
                        {
                            throw new Exception($"Feature {feature.Key} has no initializer");
                        }
                        if (featureInitializers.Count() > 1)
                        {
                            throw new Exception($"Feature {feature.Key} has multiple initializers");
                        }

                        var featureInitializer = autoRegisterActions.Single(x => x.FeatureName == feature.Key);
                        featureInitializer.Register(endpoint, app, feature.Value.Configuration);
                    };
                }
            }
        }

        initializer.RunAll();

        //foreach (var featureConfiguration in app.Features)
        //{
        //    if (featureConfiguration.Value.Register != null)
        //    {
        //        featureConfiguration.Value.Register(mappers);
        //    }
        //}

        //        var mappers = new FeatureMapperRegistry();

        //mappers.OnRegisterFeature<SsrPageFeature.Configuration>(SsrPageFeature.FeatureName, async (appConfiguration, feature) =>
        //{
        //    foreach (var page in feature.Pages)
        //    {
        //        endpoint.MapGet(page.Key, async (Microsoft.AspNetCore.Http.HttpContext httpContext) =>
        //        {
        //            await page.Value.Handle(new Metapsi.Web.CfHttpContext(httpContext), LazyAppModel(appConfiguration, httpContext));
        //        }).WithName(SsrPageFeature.Routes.PageByName(page.Key).ToRouteName());
        //    }
        //});

        //app.MapHandlers(mappers);
    }

    public static App.Model LazyAppModel(App.Setup setup, HttpContext httpContext)
    {
        var findUrl = (RouteDescription routeDescription, HttpContext httpContext) =>
        {
            return httpContext.GetEndpointUrl(routeDescription.ToRouteName());
        };

        Lazy<App.Model> appModel = new Lazy<App.Model>(() =>
        {
            return setup.GetAppModel((routeDescription) => findUrl(routeDescription, httpContext));
        });
        return appModel.Value;
    }

    //public static string GetRootUrl(this HttpContext httpContext)
    //{
    //    var request = httpContext.Request;
    //    var scheme = request.Scheme;
    //    var host = request.Host.Value;
    //    var rootUrl = $"{scheme}://{host}";
    //    return rootUrl;
    //}
}