using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonMenuButton : IonComponent
{
    public IonMenuButton() : base("ion-menu-button") { }
}

public static partial class IonMenuButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonMenuButton(this HtmlBuilder b, Action<AttributesBuilder<IonMenuButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-menu-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonMenuButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-menu-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Automatically hides the menu button when the corresponding menu is not active </para>
    /// </summary>
    public static void SetAutoHide(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("auto-hide", "");
    }

    /// <summary>
    /// <para> Automatically hides the menu button when the corresponding menu is not active </para>
    /// </summary>
    public static void SetAutoHide(this AttributesBuilder<IonMenuButton> b,bool autoHide)
    {
        if (autoHide) b.SetAttribute("auto-hide", "");
    }

    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonMenuButton> b,string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the menu button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the menu button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonMenuButton> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle </para>
    /// </summary>
    public static void SetMenu(this AttributesBuilder<IonMenuButton> b,string menu)
    {
        b.SetAttribute("menu", menu);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonMenuButton> b,string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonMenuButton> b,string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("type", "button");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeReset(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("type", "reset");
    }

    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeSubmit(this AttributesBuilder<IonMenuButton> b)
    {
        b.SetAttribute("type", "submit");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuButton(this LayoutBuilder b, Action<PropsBuilder<IonMenuButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuButton(this LayoutBuilder b, Action<PropsBuilder<IonMenuButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonMenuButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu-button", children);
    }
    /// <summary>
    /// <para> Automatically hides the menu button when the corresponding menu is not active </para>
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoHide"), b.Const(true));
    }


    /// <summary>
    /// <para> Automatically hides the menu button when the corresponding menu is not active </para>
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b, Var<bool> autoHide) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoHide"), autoHide);
    }

    /// <summary>
    /// <para> Automatically hides the menu button when the corresponding menu is not active </para>
    /// </summary>
    public static void SetAutoHide<T>(this PropsBuilder<T> b, bool autoHide) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("autoHide"), b.Const(autoHide));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the menu button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the user cannot interact with the menu button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the user cannot interact with the menu button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle </para>
    /// </summary>
    public static void SetMenu<T>(this PropsBuilder<T> b, Var<string> menu) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), menu);
    }

    /// <summary>
    /// <para> Optional property that maps to a Menu's `menuId` prop. Can also be `start` or `end` for the menu side. This is used to find the correct menu to toggle </para>
    /// </summary>
    public static void SetMenu<T>(this PropsBuilder<T> b, string menu) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menu"), b.Const(menu));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The type of the button. </para>
    /// </summary>
    public static void SetTypeButton<T>(this PropsBuilder<T> b) where T: IonMenuButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("button"));
    }


}

