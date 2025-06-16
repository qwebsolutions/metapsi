using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Metapsi.Web;

public class SsrFeatureAutoLoader : IRegisterAppFeature
{
    public string FeatureName => SsrPageFeature.FeatureName;

    public void Register(IEndpointRouteBuilder endpoint, App.Setup appSetup, object configurationObj)
    {
        SsrPageFeature.Configuration feature = configurationObj as SsrPageFeature.Configuration;
        foreach (var page in feature.Pages)
        {
            endpoint.MapGet(page.Key, async (Microsoft.AspNetCore.Http.HttpContext httpContext) =>
            {
                await page.Value.HandleRequest(new Metapsi.Web.CfHttpContext(httpContext), ModelExtensions.LazyAppModel(appSetup, httpContext));
            }).WithName(SsrPageFeature.Routes.PageByName(page.Key).ToRouteName());
        }
    }
}

public class CustomElementFeatureAutoLoader : IRegisterAppFeature
{
    public string FeatureName => CustomElementsFeature.FeatureName;

    public void Register(IEndpointRouteBuilder endpoint, App.Setup appSetup, object configurationObj)
    {
        CustomElementsFeature.Configuration feature = configurationObj as CustomElementsFeature.Configuration;
        var customElementsGroup = endpoint.MapGroup("ce");
        foreach (var ce in feature.CustomElements)
        {
            customElementsGroup.MapGet(ce.Value.Tag + ".js", async (Microsoft.AspNetCore.Http.HttpContext httpContext) =>
            {
                await ce.Value.HandleRequest(new Metapsi.Web.CfHttpContext(httpContext), ModelExtensions.LazyAppModel(appSetup, httpContext));
            }).WithName(CustomElementsFeature.Routes.JsPathByTag(ce.Key).ToRouteName());
        }
    }
}

