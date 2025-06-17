using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Metapsi.Web;

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

