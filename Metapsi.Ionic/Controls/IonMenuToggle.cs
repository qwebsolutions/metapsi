using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonMenuToggle : IonComponent
{
    public IonMenuToggle() : base("ion-menu-toggle") { }
    /// <summary> 
    /// Content is placed inside the toggle to act as the click target.
    /// </summary>
    public static class Slot
    {
    }
}

public static partial class IonMenuToggleControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonMenuToggle(this HtmlBuilder b, Action<AttributesBuilder<IonMenuToggle>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-menu-toggle", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonMenuToggle(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-menu-toggle", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide(this AttributesBuilder<IonMenuToggle> b)
    {
        b.SetAttribute("auto-hide", "");
    }
    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide(this AttributesBuilder<IonMenuToggle> b, bool value)
    {
        if (value) b.SetAttribute("auto-hide", "");
    }

    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu(this AttributesBuilder<IonMenuToggle> b, string value)
    {
        b.SetAttribute("menu", value);
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
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autoHide"), b.Const(true));
    }
    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autoHide"), value);
    }
    /// <summary>
    /// Automatically hides the content when the corresponding menu is not active.  By default, it's `true`. Change it to `false` in order to keep `ion-menu-toggle` always visible regardless the state of the menu.
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b, bool value) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("autoHide"), b.Const(value));
    }

    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu<T>(this PropsBuilder<T> b, Var<string> value) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), value);
    }
    /// <summary>
    /// Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle.  If this property is not used, `ion-menu-toggle` will toggle the first menu that is active.
    /// </summary>
    public static void SetMenu<T>(this PropsBuilder<T> b, string value) where T: IonMenuToggle
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), b.Const(value));
    }

}

