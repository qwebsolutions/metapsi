using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Metapsi.Web;

public class CrossFrameworkApiAutoLoader : IRegisterAppFeature
{
    public string FeatureName => CrossFrameworkApiFeature.FeatureName;

    public void Register(IEndpointRouteBuilder endpoint, App.Setup appSetup, object configurationObj)
    {
        CrossFrameworkApiFeature.Configuration feature = configurationObj as CrossFrameworkApiFeature.Configuration;
        foreach (var api in feature.Apis)
        {
            endpoint.MapPost(api.Key, async (Microsoft.AspNetCore.Http.HttpContext httpContext) =>
            {
                await api.Value.HandleRequest(new Metapsi.Web.CfHttpContext(httpContext), appSetup.GetAppMap(httpContext));
            }).WithName(CrossFrameworkApiFeature.Routes.GetApiByName(api.Key));
        }
    }
}