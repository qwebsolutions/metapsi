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
                await page.Value.HandleRequest(new Metapsi.Web.CfHttpContext(httpContext), appSetup.GetAppMap(httpContext));
            }).WithName(SsrPageFeature.Routes.PageByName(page.Key));
        }
    }
}