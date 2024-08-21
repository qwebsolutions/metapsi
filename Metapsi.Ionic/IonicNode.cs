using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

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
        return b.Tag(tag, setAttributes, children);
    }

    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        Action<AttributesBuilder<T>> setAttributes,
        params IHtmlNode[] children)
    {
        ImportIonic(b);
        return b.Tag(tag, setAttributes, children);
    }

    public static IHtmlNode IonicTag(
        this HtmlBuilder b,
        string tag,
        Dictionary<string, string> attributes,
        List<IHtmlNode> children)
    {
        ImportIonic(b);
        return b.Tag(tag, attributes, children);
    }

    public static IHtmlNode IonicTag(
        this HtmlBuilder b,
        string tag,
        Dictionary<string, string> attributes,
        params IHtmlNode[] children)
    {
        ImportIonic(b);
        return b.Tag(tag, attributes, children);
    }

    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        List<IHtmlNode> children)
    {
        ImportIonic(b);
        return b.Tag(tag, children);
    }

    public static IHtmlNode IonicTag<T>(
        this HtmlBuilder b,
        string tag,
        params IHtmlNode[] children)
    {
        ImportIonic(b); 
        return b.Tag(tag, children);
    }

    private static void ImportIonic(
        this HtmlBuilder b)
    {
        b.AddScript($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.esm.js", "module");
        b.AddScript($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.js");
        b.AddStylesheet($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/css/ionic.bundle.css");
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
    {
        b.AddScript($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.esm.js", "module");
        b.AddScript($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.js");
        b.AddStylesheet($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/css/ionic.bundle.css");

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
        b.AddScript($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.esm.js", "module");
        b.AddScript($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.js");
        b.AddStylesheet($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/css/ionic.bundle.css");

        return b.H(tag, children);
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
}