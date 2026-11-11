using Metapsi.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Metapsi
{
    internal class ResourceResolver : IResourceResolver
    {
        internal const string ResourceEndpointName = "metapsi-resource";

        private readonly HttpContext httpContext;
        private readonly WebResourceProvider webResourceProvider;
        private readonly VersionsRepository versionsRepository;

        internal ResourceResolver(
            HttpContext httpContext,
            WebResourceProvider webResourceProvider,
            VersionsRepository webResourceCache)
        {
            this.httpContext = httpContext;
            this.webResourceProvider = webResourceProvider;
            this.versionsRepository = webResourceCache;
        }

        public bool TryResolveDependencyResource(string dependencyId, out IResource resource)
        {
            if (this.webResourceProvider.TryGetByDependencyId(dependencyId, out IResource local))
            {
                resource = local;
                return true;
            }

            resource = null;
            return false;
        }

        public string ResolvePath(IResource resource)
        {
            if (!this.versionsRepository.TryGetVersion(resource.Package, resource.FileName, out var version))
            {
                var webResourceBuilder = webResourceProvider.GetWebResourceBuilder(resource.Package, resource.FileName);
                if (webResourceBuilder == null)
                {
                    throw new Exception($"{resource.FileName} cannot be resolved");
                }
                var webResource = webResourceBuilder.BuildResource(this);
                version = webResource.Version;
                if (!webResourceBuilder.ReloadEnabled)
                {
                    this.versionsRepository.FreezeVersion(resource, webResource.Version);
                }
            }

            var linkGenerator = httpContext.RequestServices.GetRequiredService<LinkGenerator>();
            var path = linkGenerator.GetPathByName(
                ResourceEndpointName,
                new
                {
                    package = resource.Package,
                    version = version,
                    fileName = resource.FileName
                });

            return path;
        }
    }
}