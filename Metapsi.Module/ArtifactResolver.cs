using Metapsi.Syntax;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Metapsi
{
    public interface IDependency
    {
        /// <summary>
        /// The ID of the dependency instance. Must be unique so we know if it's already resolved or not
        /// </summary>
        string DependencyId { get; }
    }

    public interface IResource
    {
        string ResourceId { get; }
    }


    public interface ICanResolveResourcePath
    {
        /// <summary>
        /// Resolves a path. Could be for js or css or img src or anything
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        string ResolvePath(IResource resource);
    }

    public interface ICanRequireDependency : ICanResolveResourcePath
    {
        /// <summary>
        /// Ensures that some resource exists, for example CSS stylesheet, JavaScript module, CSS class
        /// </summary>
        /// <param name="dependency"></param>
        void Require(IDependency dependency);
    }

    public interface IDependencyResolver
    {
        string ResolvePath(IResource resource);
        void Import(IDependency dependency);
    }

    public interface IResourceDefaultPath : IResource
    {
        string GetDefaultPath();
    }

    public class EmbeddedResource : IResource, IResourceDefaultPath
    {
        public const string DefaultHttpRoutePattern = "/embedded/{package}/{*logicalName}";

        public Assembly Assembly { get; set; }
        public string LogicalName { get; set; }

        public string ResourceId => Assembly.FullName + "|" + LogicalName;

        public virtual string GetDefaultPath()
        {
            var logicalName = LogicalName.ToLowerInvariant();
            logicalName = logicalName.Trim('/');

            return "/embedded/" + Assembly.GetName().Name + "/" + logicalName;
        }
    }

    public class HashedEmbeddedResource : EmbeddedResource
    {
        public override string GetDefaultPath()
        {
            return this.ResolveHashedPath();
        }

        private string ResolveHashedPath()
        {
            var logicalName = LogicalName.ToLowerInvariant();
            logicalName = logicalName.Trim('/');

            foreach (var rn in Assembly.GetManifestResourceNames())
            {
                var resourceName = rn.ToLowerInvariant().Trim('/');
                if (resourceName == logicalName)
                {
                    using var stream = Assembly.GetManifestResourceStream(rn);
                    using (var ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        var content = ms.ToArray();
                        var hash = System.IO.Hashing.XxHash32.HashToUInt32(content).ToString();
                        return "/embedded/" + Assembly.GetName().Name + "/" + logicalName + "?h=" + hash;
                    }
                }
            }

            throw new System.Exception($"{LogicalName} is not an embedded resource of {Assembly.FullName}");
        }
    }

    /// <summary>
    /// When resolved in JS, required tags are ignored
    /// </summary>
    public class JsOnlyResolver : IDependencyResolver
    {
        HashSet<string> ResolvedDependencyIds = new HashSet<string>();
        Dictionary<string, string> ResolvedPaths = new Dictionary<string, string>();

        // Resolves a path. Could be for js or css or img src or anything
        public string ResolvePath(IResource resource)
        {
            var resourceId = resource.ResourceId;
            ResolvedPaths.TryGetValue(resourceId, out var path);
            if (!string.IsNullOrEmpty(path))
                return path;

            // Enable overrides here

            var withDefaultResolver = resource as IResourceDefaultPath;
            if (withDefaultResolver != null)
            {
                path = withDefaultResolver.GetDefaultPath();
                ResolvedPaths[resourceId] = path;
                return path;
            }
            else
            {
                return string.Empty;
            }
        }

        // Ensures that some resource exists, for example CSS stylesheet, JavaScript module, CSS class
        public void Import(IDependency dependency)
        {
            var dependencyId = dependency.DependencyId;
            if (ResolvedDependencyIds.Contains(dependencyId))
                return;
        }
    }
}