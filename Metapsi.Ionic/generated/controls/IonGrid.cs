using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonGrid
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of IonGrid
/// </summary>
public static partial class IonGridControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonGrid>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-grid", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-grid", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonGrid>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-grid", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonGrid(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-grid", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this Metapsi.Html.AttributesBuilder<IonGrid> b, bool @fixed) 
    {
        if (@fixed) b.SetAttribute("fixed", "");
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed(this Metapsi.Html.AttributesBuilder<IonGrid> b) 
    {
        b.SetAttribute("fixed", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonGrid>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-grid", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonGrid>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-grid", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonGrid(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-grid", children);
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonGrid
    {
        b.SetFixed(b.Const(true));
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @fixed) where T: IonGrid
    {
        b.SetProperty(b.Props, b.Const("fixed"), @fixed);
    }

    /// <summary>
    /// If `true`, the grid will have a fixed width based on the screen size.
    /// </summary>
    public static void SetFixed<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @fixed) where T: IonGrid
    {
        b.SetFixed(b.Const(@fixed));
    }

}