using System.IO;
using System.Web.Hosting;
using System;
using System.Linq;
using Metapsi.Html;
using Metapsi.Syntax;

namespace Metapsi.Web;

public class EmbeddedResourceVirtualPathProvider : VirtualPathProvider
{
    private EmbeddedFiles.EmbeddedFile GetEmbeddedFile(string virtualPath)
    {
        virtualPath = virtualPath.TrimStart('~').ToLowerInvariant();
        //var fileName = System.IO.Path.GetFileName(virtualPath).ToLowerInvariant();
        //TODO: Fix SingleOrDefault
        var file = EmbeddedFiles.Get(virtualPath);
        if (file != null)
            return file;

        if (virtualPath.StartsWith("/"))
        {
            virtualPath = virtualPath.TrimStart('/');
            file = EmbeddedFiles.Get(virtualPath);
        }

        return file;
    }

    // Check if file exists either in embedded resources or base provider
    public override bool FileExists(string virtualPath)
    {
        var file = GetEmbeddedFile(virtualPath);

        if (file != null)
            return true;

        return base.FileExists(virtualPath);
    }

    // Return a VirtualFile representing the embedded resource
    public override VirtualFile GetFile(string virtualPath)
    {
        var file = GetEmbeddedFile(virtualPath);
        if (file != null) return new EmbeddedResourceVirtualFile(virtualPath, file);

        return base.GetFile(virtualPath);
    }
}

public class EmbeddedResourceVirtualFile : VirtualFile
{
    private readonly EmbeddedFiles.EmbeddedFile file;

    public EmbeddedResourceVirtualFile(string virtualPath, EmbeddedFiles.EmbeddedFile file)
        : base(virtualPath)
    {
        this.file = file;
    }

    // Open stream to embedded resource
    public override Stream Open()
    {
        return new MemoryStream(this.file.Content);
    }
}

public static class HttpContextExtensions
{
    public static void WriteHtmlDocument(this System.Web.HttpResponseBase httpResponse, HtmlDocument htmlDocument)
    {
        httpResponse.ContentType = "text/html";
        httpResponse.Write(htmlDocument.ToHtml());
    }

    public static void WriteJsModule(this System.Web.HttpResponseBase httpResponse, Metapsi.Syntax.Module module)
    {
        httpResponse.ContentType = "text/javascript";
        httpResponse.Write(module.ToJs());
    }
}