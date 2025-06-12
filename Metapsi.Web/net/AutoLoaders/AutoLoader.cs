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