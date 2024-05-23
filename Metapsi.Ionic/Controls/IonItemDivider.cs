using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonItemDivider : IonComponent
{
    public IonItemDivider() : base("ion-item-divider") { }
    /// <summary> 
    /// Content is placed between the named slots if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Content is placed to the right of the divider text in LTR, and to the left in RTL.
        /// </summary>
        public const string End = "end";
        /// <summary> 
        /// Content is placed to the left of the divider text in LTR, and to the right in RTL.
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
        return b.Tag("ion-item-divider", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonItemDivider(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-item-divider", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonItemDivider> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonItemDivider> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonItemDivider> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonItemDivider> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    /// When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky
    /// </summary>
    public static void SetSticky(this AttributesBuilder<IonItemDivider> b)
    {
        b.SetAttribute("sticky", "");
    }
    /// <summary>
    /// When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky
    /// </summary>
    public static void SetSticky(this AttributesBuilder<IonItemDivider> b, bool value)
    {
        if (value) b.SetAttribute("sticky", "");
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
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky
    /// </summary>
    public static void SetSticky<T>(this PropsBuilder<T> b) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("sticky"), b.Const(true));
    }
    /// <summary>
    /// When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky
    /// </summary>
    public static void SetSticky<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("sticky"), value);
    }
    /// <summary>
    /// When it's set to `true`, the item-divider will stay visible when it reaches the top of the viewport until the next `ion-item-divider` replaces it.  This feature relies in `position:sticky`: https://caniuse.com/#feat=css-sticky
    /// </summary>
    public static void SetSticky<T>(this PropsBuilder<T> b, bool value) where T: IonItemDivider
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("sticky"), b.Const(value));
    }

}

