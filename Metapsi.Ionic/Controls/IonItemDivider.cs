using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonItemDivider
{
    /// <summary>
    /// <para> Content is placed between the named slots if provided without a slot. </para>
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Content is placed to the right of the divider text in LTR, and to the left in RTL. </para>
        /// </summary>
        public const string End = "end";
        /// <summary>
        /// <para> Content is placed to the left of the divider text in LTR, and to the right in RTL. </para>
        /// </summary>
        public const string Start = "start";
    }
}

public static partial class IonItemDividerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemDivider(this HtmlBuilder b, Action<AttributesBuilder<IonItemDivider>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-divider", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemDivider(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-item-divider", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemDivider(this HtmlBuilder b, Action<AttributesBuilder<IonItemDivider>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item-divider", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonItemDivider(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-item-divider", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonItemDivider> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonItemDivider> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonItemDivider> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonItemDivider> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// <para> When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky </para>
    /// </summary>
    public static void SetSticky(this AttributesBuilder<IonItemDivider> b)
    {
        b.SetAttribute("sticky", "");
    }

    /// <summary>
    /// <para> When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky </para>
    /// </summary>
    public static void SetSticky(this AttributesBuilder<IonItemDivider> b, bool sticky)
    {
        if (sticky) b.SetAttribute("sticky", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemDivider(this LayoutBuilder b, Action<PropsBuilder<IonItemDivider>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-divider", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemDivider(this LayoutBuilder b, Action<PropsBuilder<IonItemDivider>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-divider", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemDivider(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-item-divider", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonItemDivider(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-item-divider", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky </para>
    /// </summary>
    public static void SetSticky<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("sticky"), b.Const(true));
    }


    /// <summary>
    /// <para> When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky </para>
    /// </summary>
    public static void SetSticky<T>(this PropsBuilder<T> b, Var<bool> sticky) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("sticky"), sticky);
    }

    /// <summary>
    /// <para> When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky </para>
    /// </summary>
    public static void SetSticky<T>(this PropsBuilder<T> b, bool sticky) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("sticky"), b.Const(sticky));
    }


}

