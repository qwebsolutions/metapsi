using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Metapsi
{
    /// <summary>
    /// A logical requirement that makes the HTML document render correctly. Dependency types are differentiated by their resulting import HTML tags
    /// </summary>
    public interface IDependency
    {
        /// <summary>
        /// The ID of the dependency instance. Must be unique so we know if it's already resolved or not
        /// </summary>
        string DependencyId { get; }
    }

    /// <summary>
    /// Builders that can raise logical requirements as IDependency
    /// </summary>
    public interface ICanRequireDependency
    {
        /// <summary>
        /// Ensures that some resource exists, for example CSS stylesheet, JavaScript module, CSS class
        /// </summary>
        /// <param name="dependency"></param>
        void Require(IDependency dependency);
    }

    /// <summary>
    /// Resolves a dependency by manipulating the HTML document
    /// </summary>
    public interface IDependencyResolver
    {
        public void Import(IDependency dependency);
    }

    /// <summary>
    /// A reference to a web asset
    /// </summary>
    public interface IResource
    {
        string Package { get; }
        string FileName { get; }
        //string ResourceId { get; }
        List<string> ResolvesDependencyIds { get; }
    }

    /// <summary>
    /// Builders that can ask for resource paths
    /// </summary>
    public interface ICanRequestResourcePath
    {
        /// <summary>
        /// Resolves a path. Could be for js or css or img src or anything
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        string ResolvePath(IResource resource);
    }

    /// <summary>
    /// The WEB HOST provided resolver. It's not the document that resolves the path, it's the environment
    /// </summary>
    public interface IResourceResolver
    {
        string ResolvePath(IResource resource);
        bool TryResolveDependencyResource(string dependencyId, out IResource resource);
    }

    public class EmbeddedResource : IResource
    {
        private EmbeddedResource(EmbeddedFileReference embeddedFile, string version)
        {
            this.EmbeddedFile = embeddedFile;
            this.Version = version;
            this.Package = embeddedFile.Assembly.GetName().Name;
            this.FileName = this.EmbeddedFile.LogicalName;
        }

        public EmbeddedFileReference EmbeddedFile { get; }
        public string Version { get; }
        public string Package { get; }
        public string FileName { get; }

        public List<string> ResolvesDependencyIds => new List<string>();

        public static EmbeddedResource Versioned(Assembly assembly, string version, string logicalName)
        {
            var embeddedFile = new EmbeddedFileReference(assembly, logicalName);
            return new EmbeddedResource(embeddedFile, version);
        }

        public static EmbeddedResource Hashed(Assembly assembly, string logicalName)
        {
            var embeddedFile = new EmbeddedFileReference(assembly, logicalName);
            using var sourceStream = assembly.GetManifestResourceStream(logicalName);
            if (sourceStream == null)
            {
                throw new InvalidOperationException($"Embedded file not found: {logicalName}");
            }
            using var ms = new MemoryStream();
            sourceStream.CopyTo(ms);
            var content = ms.ToArray();
            var hash = System.IO.Hashing.XxHash32.HashToUInt32(content).ToString();
            return EmbeddedResource.Versioned(assembly, hash, logicalName);
        }
    }

    public class EmbeddedFileReference
    {
        public EmbeddedFileReference(Assembly assembly, string logicalName)
        {
            this.Assembly = assembly;
            this.LogicalName = logicalName;
        }

        public Assembly Assembly { get; }
        public string LogicalName { get; }

        public async Task WriteAsync(Stream stream)
        {
            using var sourceStream = this.Assembly.GetManifestResourceStream(this.LogicalName);
            if (sourceStream == null)
            {
                throw new InvalidOperationException($"Embedded file not found: {this.LogicalName}");
            }
            await sourceStream.CopyToAsync(stream);
            await sourceStream.FlushAsync();
        }
    }
}