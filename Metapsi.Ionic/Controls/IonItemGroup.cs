using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonItemGroup : IonComponent
{
    public IonItemGroup() : base("ion-item-group") { }
}

public static partial class IonItemGroupControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonItemGroup(this HtmlBuilder b, Action<AttributesBuilder<IonItemGroup>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-item-group", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonItemGroup(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-item-group", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemGroup(this LayoutBuilder b, Action<PropsBuilder<IonItemGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-group", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemGroup(this LayoutBuilder b, Action<PropsBuilder<IonItemGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-group", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemGroup(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-group", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonItemGroup(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-group", children);
    }
}

