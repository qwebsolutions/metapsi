using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Metapsi.Web;

public static class HttpEmbeddedFileExtensions
{
    public static async Task WriteEmbeddedResource(this CfHttpResponse httpResponse, string assemblyName, string logicalName)
    {
        logicalName = logicalName.ToLowerInvariant().Trim('/');
        var packageAssembly = Assembly.Load(assemblyName);
        if (packageAssembly == null)
        {
            await httpResponse.SetStatusCode(404);
            return;
        }

        foreach (var rn in packageAssembly.GetManifestResourceNames())
        {
            var resourceName = rn.ToLowerInvariant().Trim('/');
            if (resourceName == logicalName)
            {
                using var stream = packageAssembly.GetManifestResourceStream(rn);

                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    var content = ms.ToArray();
                    httpResponse.SetContentLengthHeader(content.Length);
                    httpResponse.SetContentTypeHeader(HttpExtensions.GetMimeTypeForFileExtension(logicalName));
                    httpResponse.SetCacheControlHeader("public,max-age=31536000");
                    await httpResponse.WriteAsync(content);
                    return;
                }
            }
        }

        await httpResponse.SetStatusCode(404);
    }
}