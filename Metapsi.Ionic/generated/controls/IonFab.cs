using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonFab
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
        /// <summary>
        /// Close an active FAB list container.
        /// </summary>
        public const string Close = "close";
    }
}
/// <summary>
/// Setter extensions of IonFab
/// </summary>
public static partial class IonFabControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFab>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-fab", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-fab", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFab>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-fab", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFab(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-fab", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFab> b, bool activated) 
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this Metapsi.Html.AttributesBuilder<IonFab> b, bool edge) 
    {
        if (edge) b.SetAttribute("edge", "");
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("edge", "");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("horizontal", "center");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("horizontal", "end");
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("horizontal", "start");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("vertical", "bottom");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("vertical", "center");
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop(this Metapsi.Html.AttributesBuilder<IonFab> b) 
    {
        b.SetAttribute("vertical", "top");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFab>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-fab", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-fab", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFab>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-fab", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFab(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-fab", children);
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetActivated(b.Const(true));
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> activated) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("activated"), activated);
    }

    /// <summary>
    /// If `true`, both the `ion-fab-button` and all `ion-fab-list` inside `ion-fab` will become active. That means `ion-fab-button` will become a `close` icon and `ion-fab-list` will become visible.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool activated) where T: IonFab
    {
        b.SetActivated(b.Const(activated));
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetEdge(b.Const(true));
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> edge) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("edge"), edge);
    }

    /// <summary>
    /// If `true`, the fab will display on the edge of the header if `vertical` is `"top"`, and on the edge of the footer if it is `"bottom"`. Should be used with a `fixed` slot.
    /// </summary>
    public static void SetEdge<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool edge) where T: IonFab
    {
        b.SetEdge(b.Const(edge));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("horizontal"), b.Const("center"));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("horizontal"), b.Const("end"));
    }

    /// <summary>
    /// Where to align the fab horizontally in the viewport.
    /// </summary>
    public static void SetHorizontalStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("horizontal"), b.Const("start"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("vertical"), b.Const("bottom"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalCenter<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("vertical"), b.Const("center"));
    }

    /// <summary>
    /// Where to align the fab vertically in the viewport.
    /// </summary>
    public static void SetVerticalTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFab
    {
        b.SetProperty(b.Props, b.Const("vertical"), b.Const("top"));
    }

}