using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonList
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
        /// If `ion-item-sliding` are used inside the list, this method closes any open sliding item.  Returns `true` if an actual `ion-item-sliding` is closed.
        /// </summary>
        public const string CloseSlidingItems = "closeSlidingItems";
    }
}
/// <summary>
/// Setter extensions of IonList
/// </summary>
public static partial class IonListControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonList(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonList>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-list", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonList(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-list", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonList(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonList>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-list", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonList(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-list", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset(this Metapsi.Html.AttributesBuilder<IonList> b, bool inset) 
    {
        if (inset) b.SetAttribute("inset", "");
    }

    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset(this Metapsi.Html.AttributesBuilder<IonList> b) 
    {
        b.SetAttribute("inset", "");
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesFull(this Metapsi.Html.AttributesBuilder<IonList> b) 
    {
        b.SetAttribute("lines", "full");
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesInset(this Metapsi.Html.AttributesBuilder<IonList> b) 
    {
        b.SetAttribute("lines", "inset");
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesNone(this Metapsi.Html.AttributesBuilder<IonList> b) 
    {
        b.SetAttribute("lines", "none");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this Metapsi.Html.AttributesBuilder<IonList> b) 
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this Metapsi.Html.AttributesBuilder<IonList> b) 
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonList(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonList>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-list", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonList(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-list", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonList(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonList>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-list", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonList(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-list", children);
    }

    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonList
    {
        b.SetInset(b.Const(true));
    }

    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> inset) where T: IonList
    {
        b.SetProperty(b.Props, b.Const("inset"), inset);
    }

    /// <summary>
    /// If `true`, the list will have margin around it and rounded corners.
    /// </summary>
    public static void SetInset<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool inset) where T: IonList
    {
        b.SetInset(b.Const(inset));
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesFull<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonList
    {
        b.SetProperty(b.Props, b.Const("lines"), b.Const("full"));
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesInset<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonList
    {
        b.SetProperty(b.Props, b.Const("lines"), b.Const("inset"));
    }

    /// <summary>
    /// How the bottom border should be displayed on all items.
    /// </summary>
    public static void SetLinesNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonList
    {
        b.SetProperty(b.Props, b.Const("lines"), b.Const("none"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonList
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("ios"));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonList
    {
        b.SetProperty(b.Props, b.Const("mode"), b.Const("md"));
    }

}