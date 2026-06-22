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

    public static void ImportIonic(ICanRequireDependency b)
    {
        string jsPath = $"/ionic@{Cdn.Version}/ionic.esm.js";

        var resolvedJsPath = b.ResolvePath(new EmbeddedResource()
        {
            Assembly = typeof(IonicNodeImport).Assembly,
            LogicalName = jsPath
        });

        b.Require(new JsScriptDependency()
        {
            JsPath = resolvedJsPath,
            IsModule = true
        });

        string cssPath = $"/ionic@{Cdn.Version}/ionic.bundle.css";
        var resolvedCssPath = b.ResolvePath(new EmbeddedResource()
        {
            Assembly = typeof(IonicNodeImport).Assembly,
            LogicalName = cssPath
        });

        b.Require(new StylesheetDependency()
        {
            StylesheetPath = resolvedCssPath
        });
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
    {
        ImportIonic(b);
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
        b.TrackWebComponent(tag);
        return b.IonicNode(b.Const(tag), buildProps, children);
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        params Var<IVNode>[] children)
    {
        b.TrackWebComponent(tag);
        return b.IonicNode(b.Const(tag), buildProps, children);
    }

    public static Var<IVNode> IonicNode(
        this LayoutBuilder b,
        string tag,
        Var<List<IVNode>> children)
    {
        b.TrackWebComponent(tag);
        return b.IonicNode<object>(b.Const(tag), b => { }, children);
    }

    public static Var<IVNode> IonicNode(
        this LayoutBuilder b,
        string tag,
        params Var<IVNode>[] children)
    {
        b.TrackWebComponent(tag);
        return b.IonicNode<object>(b.Const(tag), b => { }, b.List(children));
    }

    internal static Var<object> ImportController(this SyntaxBuilder b, string controllerName)
    {
        var controllersIndexPath = b.ResolvePath(new EmbeddedResource()
        {
            Assembly = typeof(IonicNodeImport).Assembly,
            LogicalName = $"/ionic@{Cdn.Version}/index.esm.js"
        });

        return b.ImportName<object>(controllersIndexPath, controllerName);
    }
}