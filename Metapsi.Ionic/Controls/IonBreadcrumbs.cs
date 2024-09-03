using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonBreadcrumbs
{
}

public static partial class IonBreadcrumbsControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBreadcrumbs(this HtmlBuilder b, Action<AttributesBuilder<IonBreadcrumbs>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-breadcrumbs", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBreadcrumbs(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-breadcrumbs", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBreadcrumbs(this HtmlBuilder b, Action<AttributesBuilder<IonBreadcrumbs>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-breadcrumbs", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonBreadcrumbs(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-breadcrumbs", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBreadcrumbs> b, string color)
    {
        b.SetAttribute("color", color);
    }

    /// <summary>
    /// <para> The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed. </para>
    /// </summary>
    public static void SetItemsAfterCollapse(this AttributesBuilder<IonBreadcrumbs> b, string itemsAfterCollapse)
    {
        b.SetAttribute("items-after-collapse", itemsAfterCollapse);
    }

    /// <summary>
    /// <para> The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed. </para>
    /// </summary>
    public static void SetItemsBeforeCollapse(this AttributesBuilder<IonBreadcrumbs> b, string itemsBeforeCollapse)
    {
        b.SetAttribute("items-before-collapse", itemsBeforeCollapse);
    }

    /// <summary>
    /// <para> The maximum number of breadcrumbs to show before collapsing. </para>
    /// </summary>
    public static void SetMaxItems(this AttributesBuilder<IonBreadcrumbs> b, string maxItems)
    {
        b.SetAttribute("max-items", maxItems);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBreadcrumbs> b, string mode)
    {
        b.SetAttribute("mode", mode);
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBreadcrumbs> b)
    {
        b.SetAttribute("mode", "ios");
    }

    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd(this AttributesBuilder<IonBreadcrumbs> b)
    {
        b.SetAttribute("mode", "md");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumbs(this LayoutBuilder b, Action<PropsBuilder<IonBreadcrumbs>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-breadcrumbs", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumbs(this LayoutBuilder b, Action<PropsBuilder<IonBreadcrumbs>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-breadcrumbs", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumbs(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-breadcrumbs", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonBreadcrumbs(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-breadcrumbs", children);
    }
    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("dark"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("light"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("secondary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("success"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("tertiary"));
    }


    /// <summary>
    /// <para> The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics). </para>
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed. </para>
    /// </summary>
    public static void SetItemsAfterCollapse<T>(this PropsBuilder<T> b, Var<int> itemsAfterCollapse) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsAfterCollapse"), itemsAfterCollapse);
    }

    /// <summary>
    /// <para> The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed. </para>
    /// </summary>
    public static void SetItemsAfterCollapse<T>(this PropsBuilder<T> b, int itemsAfterCollapse) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsAfterCollapse"), b.Const(itemsAfterCollapse));
    }


    /// <summary>
    /// <para> The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed. </para>
    /// </summary>
    public static void SetItemsBeforeCollapse<T>(this PropsBuilder<T> b, Var<int> itemsBeforeCollapse) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsBeforeCollapse"), itemsBeforeCollapse);
    }

    /// <summary>
    /// <para> The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed. </para>
    /// </summary>
    public static void SetItemsBeforeCollapse<T>(this PropsBuilder<T> b, int itemsBeforeCollapse) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsBeforeCollapse"), b.Const(itemsBeforeCollapse));
    }


    /// <summary>
    /// <para> The maximum number of breadcrumbs to show before collapsing. </para>
    /// </summary>
    public static void SetMaxItems<T>(this PropsBuilder<T> b, Var<int> maxItems) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxItems"), maxItems);
    }

    /// <summary>
    /// <para> The maximum number of breadcrumbs to show before collapsing. </para>
    /// </summary>
    public static void SetMaxItems<T>(this PropsBuilder<T> b, int maxItems) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxItems"), b.Const(maxItems));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("ios"));
    }


    /// <summary>
    /// <para> The mode determines which platform styles to use. </para>
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("mode"), b.Const("md"));
    }


    /// <summary>
    /// <para> Emitted when the collapsed indicator is clicked on. </para>
    /// </summary>
    public static void OnIonCollapsedClick<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, BreadcrumbCollapsedClickEventDetail>> action) where TComponent: IonBreadcrumbs
    {
        b.OnEventAction("onionCollapsedClick", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the collapsed indicator is clicked on. </para>
    /// </summary>
    public static void OnIonCollapsedClick<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<BreadcrumbCollapsedClickEventDetail>, Var<TModel>> action) where TComponent: IonBreadcrumbs
    {
        b.OnEventAction("onionCollapsedClick", b.MakeAction(action), "detail");
    }

}

