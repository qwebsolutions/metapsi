using Metapsi.Html;
using Metapsi.Syntax;
using System.IO;
using System.Reflection;
using System.Web.Hosting;

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

//public class EmbeddedResourceHandler : IHttpHandler
//{
//    public void ProcessRequest(HttpContext context)
//    {
//        string filename = context.Request.QueryString["file"];
//        if (string.IsNullOrEmpty(filename))
//        {
//            context.Response.StatusCode = 400; // Bad Request
//            return;
//        }

//        var assembly = Assembly.GetExecutingAssembly();
//        string resourceName = $"YourNamespace.Resources.{filename}";

//        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
//        {
//            if (stream == null)
//            {
//                context.Response.StatusCode = 404; // Not Found
//                return;
//            }

//            string contentType = GetContentType(filename);
//            context.Response.ContentType = contentType;

//            stream.CopyTo(context.Response.OutputStream);
//        }
//    }

//    public bool IsReusable => true;

//    private string GetContentType(string filename)
//    {
//        if (filename.EndsWith(".txt")) return "text/plain";
//        if (filename.EndsWith(".jpg")) return "image/jpeg";
//        if (filename.EndsWith(".pdf")) return "application/pdf";
//        return "application/octet-stream";
//    }
//}


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