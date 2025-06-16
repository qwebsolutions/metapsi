using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonButtons
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
/// Setter extensions of IonButtons
/// </summary>
public static partial class IonButtonsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButtons(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonButtons>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-buttons", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButtons(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-buttons", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButtons(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonButtons>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-buttons", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonButtons(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-buttons", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse(this Metapsi.Html.AttributesBuilder<IonButtons> b, bool collapse) 
    {
        if (collapse) b.SetAttribute("collapse", "");
    }

    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse(this Metapsi.Html.AttributesBuilder<IonButtons> b) 
    {
        b.SetAttribute("collapse", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButtons(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonButtons>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-buttons", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButtons(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-buttons", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButtons(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonButtons>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-buttons", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonButtons(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-buttons", children);
    }

    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonButtons
    {
        b.SetCollapse(b.Const(true));
    }

    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> collapse) where T: IonButtons
    {
        b.SetProperty(b.Props, b.Const("collapse"), collapse);
    }

    /// <summary>
    /// If true, buttons will disappear when its parent toolbar has fully collapsed if the toolbar is not the first toolbar. If the toolbar is the first toolbar, the buttons will be hidden and will only be shown once all toolbars have fully collapsed.  Only applies in `ios` mode with `collapse` set to `true` on `ion-header`.  Typically used for [Collapsible Large Titles](https://ionicframework.com/docs/api/title#collapsible-large-titles)
    /// </summary>
    public static void SetCollapse<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool collapse) where T: IonButtons
    {
        b.SetCollapse(b.Const(collapse));
    }

}