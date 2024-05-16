using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonGrid : IonComponent
{
    public IonGrid() : base("ion-grid") { }
}

public static partial class IonGridControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonGrid(this HtmlBuilder b, Action<AttributesBuilder<IonGrid>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-grid", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonGrid(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-grid", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this AttributesBuilder<IonGrid> b)
    {
        b.SetAttribute("fixed", "");
    }
    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this AttributesBuilder<IonGrid> b, bool value)
    {
        if (value) b.SetAttribute("fixed", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonGrid(this LayoutBuilder b, Action<PropsBuilder<IonGrid>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonGrid(this LayoutBuilder b, Action<PropsBuilder<IonGrid>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonGrid(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-grid", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonGrid(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-grid", children);
    }
    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed<T>(this PropsBuilder<T> b) where T: IonGrid
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("fixed"), b.Const(true));
    }

}

