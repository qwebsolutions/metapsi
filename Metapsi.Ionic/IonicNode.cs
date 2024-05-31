using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Ui;

namespace Metapsi.Ionic;

public static class IonicNodeImport
{
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

public class IonComponent : HtmlComponent
{
    public IonComponent(string tagName) : base(tagName) { }

    protected override void OnAttach(DocumentTag documentTag, IHtmlElement parentNode)
    {
        documentTag.Body.AddChild(new ExternalScriptTag($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.esm.js", "module"));
        documentTag.Body.AddChild(new ExternalScriptTag($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/dist/ionic/ionic.js", ""));
        documentTag.Head.AddStylesheet($"https://cdn.jsdelivr.net/npm/@ionic/core@{Cdn.Version}/css/ionic.bundle.css");
    }
}
