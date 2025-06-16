using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonFabList
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
/// Setter extensions of IonFabList
/// </summary>
public static partial class IonFabListControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabList(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFabList>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-fab-list", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabList(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-fab-list", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabList(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonFabList>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-fab-list", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonFabList(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-fab-list", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFabList> b, bool activated) 
    {
        if (activated) b.SetAttribute("activated", "");
    }

    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated(this Metapsi.Html.AttributesBuilder<IonFabList> b) 
    {
        b.SetAttribute("activated", "");
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideBottom(this Metapsi.Html.AttributesBuilder<IonFabList> b) 
    {
        b.SetAttribute("side", "bottom");
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideEnd(this Metapsi.Html.AttributesBuilder<IonFabList> b) 
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideStart(this Metapsi.Html.AttributesBuilder<IonFabList> b) 
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideTop(this Metapsi.Html.AttributesBuilder<IonFabList> b) 
    {
        b.SetAttribute("side", "top");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabList(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFabList>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-fab-list", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabList(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-fab-list", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabList(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonFabList>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-fab-list", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonFabList(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-fab-list", children);
    }

    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabList
    {
        b.SetActivated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> activated) where T: IonFabList
    {
        b.SetProperty(b.Props, b.Const("activated"), activated);
    }

    /// <summary>
    /// If `true`, the fab list will show all fab buttons in the list.
    /// </summary>
    public static void SetActivated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool activated) where T: IonFabList
    {
        b.SetActivated(b.Const(activated));
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabList
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("bottom"));
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabList
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("end"));
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabList
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// The side the fab list will show on relative to the main fab button.
    /// </summary>
    public static void SetSideTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonFabList
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("top"));
    }

}