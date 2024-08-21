using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonGrid
{
}

public static partial class IonGridControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonGrid(this HtmlBuilder b, Action<AttributesBuilder<IonGrid>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-grid", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonGrid(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-grid", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonGrid(this HtmlBuilder b, Action<AttributesBuilder<IonGrid>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-grid", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonGrid(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-grid", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the grid will have a fixed width based on the screen size. </para>
    /// </summary>
    public static void SetFixed(this AttributesBuilder<IonGrid> b)
    {
        b.SetAttribute("fixed", "");
    }

    /// <summary>
    /// <para> If `true`, the grid will have a fixed width based on the screen size. </para>
    /// </summary>
    public static void SetFixed(this AttributesBuilder<IonGrid> b, bool @fixed)
    {
        if (@fixed) b.SetAttribute("fixed", "");
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
    /// <para> If `true`, the grid will have a fixed width based on the screen size. </para>
    /// </summary>
    public static void SetFixed<T>(this PropsBuilder<T> b) where T: IonGrid
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("fixed"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the grid will have a fixed width based on the screen size. </para>
    /// </summary>
    public static void SetFixed<T>(this PropsBuilder<T> b, Var<bool> @fixed) where T: IonGrid
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("fixed"), @fixed);
    }

    /// <summary>
    /// <para> If `true`, the grid will have a fixed width based on the screen size. </para>
    /// </summary>
    public static void SetFixed<T>(this PropsBuilder<T> b, bool @fixed) where T: IonGrid
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("fixed"), b.Const(@fixed));
    }


}

