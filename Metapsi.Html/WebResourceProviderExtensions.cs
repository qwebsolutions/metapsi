using Metapsi.Html;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Html;

public static class WebResourceProviderExtensions
{
    public static string GetId(this IResource resource)
    {
        return resource.Package + "|" + resource.FileName;
    }

    public static void RegisterCssFile(this WebResourceProvider webResourceProvider, CssFile cssFile, bool reloadEnabled = false)
    {
        webResourceProvider.Register(
            cssFile,
            (resourceOptions) =>
            {
                var fileContent = cssFile.ToCss(resourceOptions.ResourceResolver, resourceOptions.ToCssOptions);
                var hash = WebResourceBuilder.Hash(fileContent);

                return new WebResource(
                    cssFile.Package,
                    hash,
                    cssFile.FileName,
                    async (stream) =>
                    {
                        var bytes = Encoding.UTF8.GetBytes(fileContent);
                        await stream.WriteAsync(bytes, 0, bytes.Length);
                    });
            },
            reloadEnabled);
    }

    public static void RegisterJsModuleFile(this WebResourceProvider webResourceProvider, JsModuleFile jsModuleFile, bool reloadEnabled = false)
    {
        webResourceProvider.Register(
            jsModuleFile,
            (resourceOptions) =>
            {
                var fileContent = jsModuleFile.ToJs(resourceOptions.ResourceResolver, resourceOptions.JsonSerializer, resourceOptions.ToJavaScriptOptions);
                var hash = WebResourceBuilder.Hash(fileContent);

                return new WebResource(
                    jsModuleFile.Package,
                    hash,
                    jsModuleFile.FileName,
                    async (stream) =>
                    {
                        var bytes = Encoding.UTF8.GetBytes(fileContent);
                        await stream.WriteAsync(bytes, 0, bytes.Length);
                    });
            },
            reloadEnabled);
    }

    public static void RegisterEmbeddedResource(this WebResourceProvider webResourceProvider, EmbeddedResource embeddedResource)
    {
        var fullId = $"{embeddedResource.Package}/{embeddedResource.Version}/{embeddedResource.FileName}";
        webResourceProvider.Register(
            embeddedResource,
            (resolver) => new WebResource(
                embeddedResource.Package,
                embeddedResource.Version,
                embeddedResource.FileName,
                embeddedResource.EmbeddedFile.WriteAsync),
            false);
    }

    public static void RegisterCustomElement(
        this WebResourceProvider webResourceProvider,
        ICustomElement customElement,
        bool reloadEnabled = false)
    {
        var package = customElement.GetType().Assembly.GetName().Name.ToLowerInvariant();
        var jsFile = new JsModuleFile(package, customElement.Tag, customElement.BuildModule);
        jsFile.ResolvesDependencyIds.Add(customElement.Tag);
        webResourceProvider.RegisterJsModuleFile(jsFile, reloadEnabled);
    }

    public static void AutoLoadCustomElementsFrom(
        this WebResourceProvider webResourceProvider,
        System.Reflection.Assembly assembly,
        bool reloadEnabled)
    {
        var allCustomElementTypes = new List<System.Reflection.Assembly>() { assembly }.FindAllTypesImplementing<Metapsi.Html.ICustomElement>();
        foreach (var customElementType in allCustomElementTypes)
        {
            ICustomElement customElement = System.Activator.CreateInstance(customElementType) as ICustomElement;
            if (customElement == null)
            {
                throw new InvalidOperationException($"Cannot instantiate custom element type {customElementType.GetType().Name}. Custom elements must have a default constructor with no parameters");
            }
            webResourceProvider.RegisterCustomElement(customElement, reloadEnabled);
        }
    }

    public static void AutoLoadCustomElementsFrom(
        this WebResourceProvider webResourceProvider,
        System.Reflection.Assembly assembly)
    {
        webResourceProvider.AutoLoadCustomElementsFrom(assembly, System.Diagnostics.Debugger.IsAttached);
    }
}