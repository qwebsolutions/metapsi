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
                var module = ce.Value.GetModule(appSetup.GetAppMap(httpContext));
                await httpContext.WriteJsModule(module);
            }).WithName(CustomElementsFeature.Routes.JsPathByTag(ce.Key).ToRouteName(appSetup));
        }
    }
}

