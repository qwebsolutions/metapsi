using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Metapsi.Web;
using Metapsi.Syntax;

namespace Metapsi;

public class CfApiConfiguration
{
    public string Name { get; set; }
    public Func<Metapsi.Web.CfHttpContext, App.Map, Task> HandleRequest { get; set; }
}

public static class CrossFrameworkApiFeature
{
    public static string FeatureName = "cf-api";

    //public static class Routes
    //{
    //    public static RouteDescription GetApiByName(string apiName)
    //    {
    //        return RouteDescription.New(
    //            "get-cf-api",
    //            b =>
    //            {
    //                b.Add("api-name", apiName);
    //            });
    //    }
    //}

    public class Details
    {
        public Dictionary<string, string> ApiUrls { get; set; } = new Dictionary<string, string>();
    }

    public class Configuration
    {
        public Dictionary<string, CfApiConfiguration> Apis { get; set; } = new Dictionary<string, CfApiConfiguration>();
    }

    public static void ConfigureApis(
           this ConfigurationBuilder<App.Setup> b,
           System.Action<ConfigurationBuilder<Configuration>> configure = null)
    {
        var apisConfiguration = ConfigurationBuilder.Configure(configure);

        b.Configuration.Features[FeatureName] = new App.Feature()
        {
            Configuration = apisConfiguration,
            GetDetails = (findUrl) =>
            {
                var data = new Details();

                foreach (var page in apisConfiguration.Apis)
                {
                    data.ApiUrls[page.Value.Name] = findUrl(new RouteDescription(page.Key));
                }

                return data;
            }
        };
    }

    /// <summary>
    /// Adds a cross-framework http handler that writes <typeparamref name="TResult"/> as JSON response
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="b"></param>
    /// <param name="name"></param>
    /// <param name="handle"></param>
    public static void Add<TResult>(this ConfigurationBuilder<Configuration> b, string name, Func<Metapsi.Web.CfHttpContext, App.Map, Task<TResult>> handle)
    {
        b.Configuration.Apis[name] = new CfApiConfiguration()
        {
            Name = name,
            HandleRequest = async (httpContext, appMap) =>
            {
                try
                {
                    var response = await handle(httpContext, appMap);
                    await httpContext.Response.WriteJsonReponse(response);
                }
                catch (Exception ex)
                {
                    // TODO: Logger feature
                    await httpContext.Response.SetStatusCode(500);
                }
            }
        };
    }

    /// <summary>
    /// Add a cross-framework http handler that writes the response directly
    /// </summary>
    /// <param name="b"></param>
    /// <param name="name"></param>
    /// <param name="handle"></param>
    public static void Add(this ConfigurationBuilder<Configuration> b, string name, Func<Metapsi.Web.CfHttpContext, App.Map, Task> handle)
    {
        b.Configuration.Apis[name] = new CfApiConfiguration()
        {
            Name = name,
            HandleRequest = async (httpContext, appMap) =>
            {
                try
                {
                    await handle(httpContext, appMap);
                }
                catch (Exception ex)
                {
                    // TODO: Logger feature
                    await httpContext.Response.SetStatusCode(500);
                }
            }
        };
    }

    public static string GetApiUrl(this App.Map appMap, string apiName)
    {
        Details apisData = appMap.Features[FeatureName] as Details;
        return apisData.ApiUrls[apiName];
    }

    public static Var<string> GetApiUrl(this SyntaxBuilder b, Var<string> apiName)
    {
        var data = b.GetFeature<Details>(CrossFrameworkApiFeature.FeatureName);
        var apiUrls = b.Get(data, x => x.ApiUrls);
        return b.GetProperty<string>(apiUrls, apiName);
    }

    public static Var<string> GetApiUrl(this SyntaxBuilder b, string apiName)
    {
        return b.GetApiUrl(b.Const(apiName));
    }
}