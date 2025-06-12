using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Metapsi.Web;

public interface IRegisterAppFeature : IAutoLoader
{
    string FeatureName { get; }

    void Register(IEndpointRouteBuilder endpoint, App.Setup appSetup, object configuration);
}

public class SsrAutoLoader : IRegisterAppFeature
{
    public string FeatureName => SsrPageFeature.FeatureName;

    public void Register(IEndpointRouteBuilder endpoint, App.Setup appSetup, object configurationObj)
    {
        SsrPageFeature.Configuration feature = configurationObj as SsrPageFeature.Configuration;
        foreach (var page in feature.Pages)
        {
            endpoint.MapGet(page.Key, async (Microsoft.AspNetCore.Http.HttpContext httpContext) =>
            {
                await page.Value.Handle(new Metapsi.Web.CfHttpContext(httpContext), ModelExtensions.LazyAppModel(appSetup, httpContext));
            }).WithName(SsrPageFeature.Routes.PageByName(page.Key).ToRouteName());
        }
    }
}

public static class ModelExtensions
{
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

}