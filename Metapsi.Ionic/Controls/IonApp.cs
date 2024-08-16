using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonApp : IonComponent
{
    public IonApp() : base("ion-app") { }
}

public static partial class IonAppControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, Action<AttributesBuilder<IonApp>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-app", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonApp(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-app", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Action<PropsBuilder<IonApp>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-app", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonApp(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-app", children);
    }
}

