using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Metapsi.Ionic;

public static class IonicNodeImport
{
    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        Action<AttributesBuilder<T>> setAttributes,
        List<IHtmlNode> children)
    {
        ImportIonic(b);
        b.TrackWebComponent(tag);
        return b.Tag(tag, setAttributes, children);
    }

    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        Action<AttributesBuilder<T>> setAttributes,
        params IHtmlNode[] children)
    {
        ImportIonic(b);
        b.TrackWebComponent(tag);
        return b.Tag(tag, setAttributes, children);
    }

    public static IHtmlNode IonicTag(
        this HtmlBuilder b,
        string tag,
        Dictionary<string, string> attributes,
        List<IHtmlNode> children)
    {
        ImportIonic(b);
        b.TrackWebComponent(tag);
        return b.Tag(tag, attributes, children);
    }

    public static IHtmlNode IonicTag(
        this HtmlBuilder b,
        string tag,
        Dictionary<string, string> attributes,
        params IHtmlNode[] children)
    {
        ImportIonic(b);
        b.TrackWebComponent(tag);
        return b.Tag(tag, attributes, children);
    }

    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        List<IHtmlNode> children)
    {
        ImportIonic(b);
        b.TrackWebComponent(tag);
        return b.Tag(tag, children);
    }

    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        params IHtmlNode[] children)
    {
        ImportIonic(b);
        b.TrackWebComponent(tag);
        return b.Tag(tag, children);
    }

    public static void ImportIonic(HtmlBuilder b)
    {
        string jsPath = $"/ionic@{Cdn.Version}/ionic.esm.js";
        string cssPath = $"/ionic@{Cdn.Version}/ionic.bundle.css";
        var ionicJsResource = b.Document.Metadata.AddEmbeddedResourceMetadata(typeof(IonicNodeImport).Assembly, jsPath);
        var ionicCssResource = b.Document.Metadata.AddEmbeddedResourceMetadata(typeof(IonicNodeImport).Assembly, cssPath);

        var scriptNode = new HtmlTag("script");
        scriptNode.SetAttribute("src", ionicJsResource);
        scriptNode.SetAttribute("type", "module");

        var link= new HtmlTag("link");
        link.SetAttribute("rel", "stylesheet");
        link.SetAttribute("href", ionicCssResource);

        b.HeadAppend(new HtmlNode()
        {
            Tags = new List<HtmlTag>() { scriptNode, link }
        });
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
    {
        var ionicJs = b.AddEmbeddedResourceMetadata(typeof(IonicNodeImport).Assembly, $"/ionic@{Cdn.Version}/ionic.esm.js");

        var scriptTag = new HtmlTag("script");
        scriptTag.SetAttribute("type", "module");
        scriptTag.SetAttribute("src", ionicJs);
        b.Metadata().AddRequiredTagMetadata(scriptTag);

        var ionicCss = b.AddEmbeddedResourceMetadata(typeof(IonicNodeImport).Assembly, $"/ionic@{Cdn.Version}/ionic.bundle.css");

        var stylesheet = new HtmlTag("link");
        stylesheet.SetAttribute("rel", "stylesheet");
        stylesheet.SetAttribute("href", ionicCss);
        b.Metadata().AddRequiredTagMetadata(stylesheet);
        return b.H(tag, buildProps, children);
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TProps>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.IonicNode(tag, buildProps, b.List(children));
    }


    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
    {
        return b.IonicNode(b.Const(tag), buildProps, children);
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        params Var<IVNode>[] children)
    {
        return b.IonicNode(b.Const(tag), buildProps, children);
    }

    public static Var<IVNode> IonicNode(
        this LayoutBuilder b,
        Var<string> tag,
        Var<List<IVNode>> children)
    {
        return b.IonicNode<object>(tag, b => { }, children);
    }

    public static Var<IVNode> IonicNode(
        this LayoutBuilder b,
        string tag,
        Var<List<IVNode>> children)
    {
        return b.IonicNode(b.Const(tag), children);
    }

    public static Var<IVNode> IonicNode(
        this LayoutBuilder b,
        string tag,
        params Var<IVNode>[] children)
    {
        return b.IonicNode(b.Const(tag), b.List(children));
    }

    internal static Var<object> ImportController(this SyntaxBuilder b, string controllerName)
    {
        var ionicJsResource = b.AddEmbeddedResourceMetadata(typeof(IonicNodeImport).Assembly, $"/ionic@{Cdn.Version}/index.esm.js");
        return b.ImportName<object>(ionicJsResource, controllerName);
    }
}