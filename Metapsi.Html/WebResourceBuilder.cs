using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Html;

//public interface IWebResourceCache
//{
//    bool TryGetWebResource(string package, string fileName, out WebResource webResource);
//    void StoreWebResource(string package, string fileName, WebResource webResource);
//}

//public class InMemoryWebResourceCache : IWebResourceCache
//{
//    ConcurrentDictionary<string, WebResource> webResources = new();

//    public void StoreWebResource(string package, string fileName, WebResource webResource)
//    {
//        var resourceId = WebResourceBuilder.CreateId(package, fileName);
//        webResources[resourceId] = webResource;
//    }

//    public bool TryGetWebResource(string package, string fileName, out WebResource webResource)
//    {
//        var resourceId = WebResourceBuilder.CreateId(package, fileName);
//        if (webResources.TryGetValue(resourceId, out var local))
//        {
//            webResource = local;
//            return true;
//        }
//        webResource = null;
//        return false;
//    }

//    public static readonly InMemoryWebResourceCache Default = new InMemoryWebResourceCache();
//}

public class WebResource
{
    public WebResource(
        string package,
        string version,
        string fileName,
        Func<System.IO.Stream, Task> writeAsync)
    {
        Package = package;
        Version = version;
        FileName = fileName;
        this.WriteAsync = writeAsync;
    }

    public string FullId { get; }
    public string Package { get; }
    public string Version { get; }
    public string FileName { get; }
    public Func<System.IO.Stream, Task> WriteAsync { get; set; }
}

public class WebResourceBuilder
{
    public WebResourceBuilder(
        IResource resource,
        Func<IResourceResolver, WebResource> buildResource,
        bool reloadEnabled)
    {
        this.Resource = resource;
        this.BuildResource = buildResource;
        ReloadEnabled = reloadEnabled;
    }

    public IResource Resource { get; }
    public Func<IResourceResolver, WebResource> BuildResource { get; }
    public bool ReloadEnabled { get; }

    public static string CreateId(string package, string fileName)
    {
        return $"{package}|{fileName}";
    }

    public static string Hash(string content)
    {
        var hash = System.IO.Hashing.XxHash32.HashToUInt32(System.Text.Encoding.UTF8.GetBytes(content)).ToString();
        return hash;
    }
}