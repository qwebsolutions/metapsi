using Metapsi.Syntax;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Metapsi.Html;

public interface IAutoRegisterModule
{
    void Register(WebResourceProvider webResourceProvider);
}

public class VersionsRepository
{
    private readonly ConcurrentDictionary<string, string> frozenVersions = new ConcurrentDictionary<string, string>();

    public void FreezeVersion(IResource resource, string version)
    {
        this.frozenVersions[WebResourceBuilder.CreateId(resource.Package, resource.FileName)] = version;
    }

    public bool TryGetVersion(string package, string fileName, out string version)
    {
        if (this.frozenVersions.TryGetValue(WebResourceBuilder.CreateId(package, fileName), out string local))
        {
            version = local;
            return true;
        }
        version = string.Empty;
        return false;
    }
}

/// <summary>
/// Used for generating outside of a web server environment, eg a console project
/// </summary>
internal class FixedPathsResourceResolver : IResourceResolver
{
    private readonly WebResourceProvider provider;
    private readonly VersionsRepository versionsRepository;

    internal string Prefix { get; set; } = "resource";
    public IJsonSerializer JsonSerializer { get; }

    internal FixedPathsResourceResolver(
        Metapsi.IJsonSerializer jsonSerializer,
        WebResourceProvider provider,
        VersionsRepository versionsRepository)
    {
        JsonSerializer = jsonSerializer;
        this.provider = provider;
        this.versionsRepository = versionsRepository;
    }

    public bool TryResolveDependencyResource(string dependencyId, out IResource resource)
    {
        if (this.provider.TryGetByDependencyId(dependencyId, out IResource local))
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
            var webResourceBuilder = this.provider.GetWebResourceBuilder(resource.Package, resource.FileName);
            var webResource = webResourceBuilder.BuildResource(new WebResourceProvider.ResourceOptions(
                this,
                this.JsonSerializer,
                new ToJavaScriptOptions(),
                new ToCssOptions()));
            version = webResource.Version;
            if (!webResourceBuilder.ReloadEnabled)
            {
                this.versionsRepository.FreezeVersion(resource, version);
            }
        }

        return $"/{Prefix.Trim('/')}/{resource.Package}/{version}/{resource.FileName}";
    }
}

public class WebResourceProvider
{
    public class ResourceOptions
    {
        public ResourceOptions(
            Metapsi.IResourceResolver resourceResolver,
            Metapsi.IJsonSerializer jsonSerializer,
            ToJavaScriptOptions toJavaScriptOptions,
            ToCssOptions toCssOptions)
        {
            this.ResourceResolver = resourceResolver;
            this.JsonSerializer = jsonSerializer;
            this.ToJavaScriptOptions = toJavaScriptOptions;
            this.ToCssOptions = ToCssOptions;
        }

        public IResourceResolver ResourceResolver { get; }
        public Metapsi.IJsonSerializer JsonSerializer { get; }
        public ToJavaScriptOptions ToJavaScriptOptions { get; }
        public ToCssOptions ToCssOptions { get; }
    }

    // resourceId => WebResourceBuilder
    private readonly Dictionary<string, WebResourceBuilder> resurceBuilders = new();
    // resourceId(package,fileName) => version
    private readonly Dictionary<string, IResource> byDependencyId = new Dictionary<string, IResource>();

    internal WebResourceProvider()
    {
    }

    /// <summary>
    /// Used when the HTML resources are not resolved by the web server (for example, a console project that generates static files)
    /// </summary>
    public string FallbackResourcePathPrefix { get; set; } = "resource";

    private readonly VersionsRepository FixedPathsVersionsRepository = new VersionsRepository();

    public IResourceResolver GetFixedPathsResourceResolver(Metapsi.IJsonSerializer jsonSerializer)
    {
        var resourceResolver = new FixedPathsResourceResolver(jsonSerializer, this, FixedPathsVersionsRepository)
        {
            Prefix = this.FallbackResourcePathPrefix
        };
        return resourceResolver;
    }

    public void Register(IResource resource, Func<WebResourceProvider.ResourceOptions, WebResource> build, bool reloadEnabled)
    {
        this.resurceBuilders[resource.GetId()] = new WebResourceBuilder(
            resource,
            build,
            reloadEnabled);

        foreach (var dependencyId in resource.ResolvesDependencyIds)
        {
            byDependencyId[dependencyId] = resource;
        }
    }

    public WebResourceBuilder GetWebResourceBuilder(string package, string fileName)
    {
        if (resurceBuilders.TryGetValue(WebResourceBuilder.CreateId(package, fileName), out var webResourceBuilder))
        {
            return webResourceBuilder;
        }

        return null;
    }

    public bool TryGetByDependencyId(string dependencyId, out IResource resource)
    {
        return byDependencyId.TryGetValue(dependencyId, out resource);
    }

    public static readonly WebResourceProvider Default = new WebResourceProvider();

    public static void AutoRegisterModules(WebResourceProvider webResourceProvider)
    {
        HashSet<System.Reflection.AssemblyName> allAssemblyNames = new HashSet<System.Reflection.AssemblyName>();

        var allReferencedAssemblies = GetReferencedCustomAssemblies(allAssemblyNames, System.Reflection.Assembly.GetEntryAssembly());
        Console.WriteLine(allReferencedAssemblies.Count);

        var autoRegisterTypes = allReferencedAssemblies.ToList().FindAllTypesImplementing<IAutoRegisterModule>();

        foreach (var autoRegisterType in autoRegisterTypes)
        {
            var autoRegisterInstance = System.Activator.CreateInstance(autoRegisterType) as IAutoRegisterModule;
            autoRegisterInstance.Register(webResourceProvider);
        }
    }

    private static HashSet<Assembly> GetReferencedCustomAssemblies(HashSet<System.Reflection.AssemblyName> knownNames, System.Reflection.Assembly fromAssembly)
    {
        HashSet<Assembly> loaddedAssemblies = new HashSet<Assembly>();
        if (loaddedAssemblies.Add(fromAssembly))
        {

            var referencedAssemblyNames = fromAssembly.GetReferencedAssemblies();
            foreach (var assemblyName in referencedAssemblyNames)
            {
                if (assemblyName.Name.StartsWith("Microsoft."))
                    continue;

                if (assemblyName.Name.StartsWith("System."))
                    continue;

                if (knownNames.Add(assemblyName))
                {
                    var assembly = System.Reflection.Assembly.Load(assemblyName);
                    var deeper = GetReferencedCustomAssemblies(knownNames, assembly);
                    foreach (var innerAssembly in deeper)
                    {
                        loaddedAssemblies.Add(innerAssembly);
                    }
                }
            }
        }

        return loaddedAssemblies;
    }
}
