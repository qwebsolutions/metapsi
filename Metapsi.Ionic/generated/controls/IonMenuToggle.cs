using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonMenuToggle
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
/// Setter extensions of IonMenuToggle
/// </summary>
public static partial class IonMenuToggleControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenuToggle(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonMenuToggle>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-menu-toggle", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenuToggle(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-menu-toggle", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenuToggle(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonMenuToggle>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-menu-toggle", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenuToggle(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-menu-toggle", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide(this Metapsi.Html.AttributesBuilder<IonMenuToggle> b, bool autoHide) 
    {
        if (autoHide) b.SetAttribute("autoHide", "");
    }

    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide(this Metapsi.Html.AttributesBuilder<IonMenuToggle> b) 
    {
        b.SetAttribute("autoHide", "");
    }

    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu(this Metapsi.Html.AttributesBuilder<IonMenuToggle> b, string menu) 
    {
        b.SetAttribute("menu", menu);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenuToggle(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonMenuToggle>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-menu-toggle", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenuToggle(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-menu-toggle", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenuToggle(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonMenuToggle>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-menu-toggle", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenuToggle(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-menu-toggle", children);
    }

    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenuToggle
    {
        b.SetAutoHide(b.Const(true));
    }

    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> autoHide) where T: IonMenuToggle
    {
        b.SetProperty(b.Props, b.Const("autoHide"), autoHide);
    }

    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool autoHide) where T: IonMenuToggle
    {
        b.SetAutoHide(b.Const(autoHide));
    }

    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> menu) where T: IonMenuToggle
    {
        b.SetProperty(b.Props, b.Const("menu"), menu);
    }

    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu<T>(this Metapsi.Syntax.PropsBuilder<T> b, string menu) where T: IonMenuToggle
    {
        b.SetMenu(b.Const(menu));
    }

}