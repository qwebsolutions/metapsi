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
        var file = EmbeddedFiles.GetAll().SingleOrDefault(x => virtualPath.ToLowerInvariant().EndsWith(x.LowerCaseFileName, StringComparison.OrdinalIgnoreCase));
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


public class HtmlDocumentResult : System.Web.Mvc.ActionResult
{
    private HtmlDocument htmlDocument;

    public HtmlDocumentResult(HtmlDocument htmlDocument)
    {
        this.htmlDocument = htmlDocument;
    }

    public override void ExecuteResult(System.Web.Mvc.ControllerContext context)
    {
        context.HttpContext.Response.WriteHtmlDocument(this.htmlDocument);
    }
}

public class JsModuleResult : System.Web.Mvc.ActionResult
{
    private Metapsi.Syntax.Module module;

    public JsModuleResult(Module module)
    {
        this.module = module;
    }

    public override void ExecuteResult(System.Web.Mvc.ControllerContext context)
    {
        context.HttpContext.Response.WriteJsModule(this.module);
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

//public static class WebServer
//{

//    public static void Test()
//    {
//        System.Web.Hosting.HostingEnvironment.RegisterVirtualPathProvider(new EmbeddedResourceVirtualPathProvider());
//    }

//    public static string GetMimeType(string path)
//    {
//        if (path.EndsWith(".js"))
//            return "text/javascript";

//        if (path.EndsWith(".mjs"))
//            return "text/javascript";

//        if (path.EndsWith(".css"))
//            return "text/css";

//        if (path.EndsWith(".svg"))
//            return "image/svg+xml";

//        throw new System.Exception("Mime type not supported");
//    }
//}
