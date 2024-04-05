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
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<IVNode>[] children)
    {
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.esm.js", "module");
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.js");
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@ionic/core/css/ionic.bundle.css");

        return b.H(tag, buildProps, children);
    }

    public static Var<IVNode> IonicNode<TProps>(
        this LayoutBuilder b,
        string tag,
        Action<PropsBuilder<TProps>> buildProps,
        Var<List<IVNode>> children)
        where TProps : new()
    {
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.esm.js", "module");
        b.AddScript("https://cdn.jsdelivr.net/npm/@ionic/core/dist/ionic/ionic.js");
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@ionic/core/css/ionic.bundle.css");

        return b.H(tag, buildProps, children);
    }
}

public class IonComponent : HtmlComponent
{
    public IonComponent(string tagName) : base(tagName) { }

    protected override void OnAttach(DocumentTag documentTag, IHtmlElement parentNode)
    {
        
    }
}