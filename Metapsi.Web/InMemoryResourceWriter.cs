using Metapsi.Html;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Metapsi.Web;

public class InMemoryResourceWriter : IResourceWriter
{
    private ConcurrentDictionary<string, WebResource> webResources = new ConcurrentDictionary<string, WebResource>();

    private readonly WebResourceProvider webResourceProvider;

    public InMemoryResourceWriter(WebResourceProvider webResourceProvider)
    {
        this.webResourceProvider = webResourceProvider;
    }

    public async Task WriteAsync(string package, string version, string fileName, CfHttpResponse response, IResourceResolver resourceResolver)
    {
        var key = $"{package}/{version}/{fileName}";
        if (!webResources.TryGetValue(key, out var webResource))
        {
            var webResourceBuilder = webResourceProvider.GetWebResourceBuilder(package, fileName);
            if (webResourceBuilder == null)
            {
                await response.SetStatusCode(404);
                return;
            }

            webResource = webResourceBuilder.BuildResource(resourceResolver);
            if (webResource.Version != version)
            {
                await response.SetStatusCode(404);
                return;
            }
            webResources[key] = webResource;
        }

        response.SetContentTypeHeader(HttpExtensions.GetMimeTypeForFileExtension(fileName));
        response.SetCacheControlHeader("public,max-age=31536000");
        await webResource.WriteAsync(response.BodyStream());
    }
}
