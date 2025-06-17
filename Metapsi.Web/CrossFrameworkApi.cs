using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Metapsi.Web;

namespace Metapsi;

public class CfApiConfiguration
{
    public string Name { get; set; }
    public Func<Metapsi.Web.CfHttpContext, App.Model, Task> HandleRequest { get; set; }
}

public static class CrossFrameworkApiFeature
{
    public static string FeatureName = "cf-api";

    public static class Routes
    {
        public static RouteDescription GetApiByName(string apiName)
        {
            return RouteDescription.New(
                "get-cf-api",
                b =>
                {
                    b.Add("api-name", apiName);
                });
        }
    }

    public class Data
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
            GetData = (findUrl) =>
            {
                var data = new Data();

                foreach (var page in apisConfiguration.Apis)
                {
                    data.ApiUrls[page.Value.Name] = findUrl(Routes.GetApiByName(page.Key));
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
    public static void Add<TResult>(this ConfigurationBuilder<Configuration> b, string name, Func<Metapsi.Web.CfHttpContext, App.Model, Task<TResult>> handle)
    {
        b.Configuration.Apis[name] = new CfApiConfiguration()
        {
            Name = name,
            HandleRequest = async (httpContext, appModel) =>
            {
                try
                {
                    var response = await handle(httpContext, appModel);
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
    public static void Add(this ConfigurationBuilder<Configuration> b, string name, Func<Metapsi.Web.CfHttpContext, App.Model, Task> handle)
    {
        b.Configuration.Apis[name] = new CfApiConfiguration()
        {
            Name = name,
            HandleRequest = async (httpContext, appModel) =>
            {
                try
                {
                    await handle(httpContext, appModel);
                }
                catch (Exception ex)
                {
                    // TODO: Logger feature
                    await httpContext.Response.SetStatusCode(500);
                }
            }
        };
    }

    public static string GetApiUrl(this App.Model appModel, string apiName)
    {
        Data apisData = appModel.FeatureModels[FeatureName] as Data;
        return apisData.ApiUrls[apiName];
    }
}