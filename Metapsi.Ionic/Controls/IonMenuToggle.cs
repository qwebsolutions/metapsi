using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonMenuToggle
{
}

public static partial class IonMenuToggleControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonMenuToggle(this HtmlBuilder b, Action<AttributesBuilder<IonMenuToggle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-menu-toggle", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonMenuToggle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-menu-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonMenuToggle(this HtmlBuilder b, Action<AttributesBuilder<IonMenuToggle>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-menu-toggle", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonMenuToggle(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-menu-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu. </para>
    /// </summary>
    public static void SetAutoHide(this AttributesBuilder<IonMenuToggle> b)
    {
        b.SetAttribute("auto-hide", "");
    }

    /// <summary>
    /// <para> Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu. </para>
    /// </summary>
    public static void SetAutoHide(this AttributesBuilder<IonMenuToggle> b, bool autoHide)
    {
        if (autoHide) b.SetAttribute("auto-hide", "");
    }

    /// <summary>
    /// <para> Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active. </para>
    /// </summary>
    public static void SetMenu(this AttributesBuilder<IonMenuToggle> b, string menu)
    {
        b.SetAttribute("menu", menu);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuToggle(this LayoutBuilder b, Action<PropsBuilder<IonMenuToggle>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu-toggle", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuToggle(this LayoutBuilder b, Action<PropsBuilder<IonMenuToggle>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu-toggle", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuToggle(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu-toggle", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuToggle(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu-toggle", children);
    }
    /// <summary>
    /// <para> Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu. </para>
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoHide"), b.Const(true));
    }


    /// <summary>
    /// <para> Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu. </para>
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b, Var<bool> autoHide) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoHide"), autoHide);
    }

    /// <summary>
    /// <para> Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu. </para>
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b, bool autoHide) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoHide"), b.Const(autoHide));
    }


    /// <summary>
    /// <para> Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active. </para>
    /// </summary>
    public static void SetMenu<T>(this PropsBuilder<T> b, Var<string> menu) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), menu);
    }

    /// <summary>
    /// <para> Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active. </para>
    /// </summary>
    public static void SetMenu<T>(this PropsBuilder<T> b, string menu) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), b.Const(menu));
    }


}

