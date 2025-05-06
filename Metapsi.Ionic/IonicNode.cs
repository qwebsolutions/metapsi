using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using System.Runtime.CompilerServices;

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
        b.AddScript($"/ionic@{Cdn.Version}/ionic.esm.js", "module");
        b.AddStylesheet($"/ionic@{Cdn.Version}/ionic.bundle.css");
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        Var<string> tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
    {
        b.AddRequiredScriptMetadata($"/ionic@{Cdn.Version}/ionic.esm.js", "module");
        //b.AddScript($"/ionic@{Cdn.Version}/ionic.js");
        b.AddRequiredStylesheetMetadata($"/ionic@{Cdn.Version}/ionic.bundle.css");

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
        b.AddRequiredScriptMetadata($"/ionic@{Cdn.Version}/ionic.esm.js", "module");
        b.AddRequiredStylesheetMetadata($"/ionic@{Cdn.Version}/ionic.bundle.css");

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