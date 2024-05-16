using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonBreadcrumbs : IonComponent
{
    public IonBreadcrumbs() : base("ion-breadcrumbs") { }
}

public static partial class IonBreadcrumbsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonBreadcrumbs(this HtmlBuilder b, Action<AttributesBuilder<IonBreadcrumbs>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-breadcrumbs", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonBreadcrumbs(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-breadcrumbs", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this AttributesBuilder<IonBreadcrumbs> b, string value)
    {
        b.SetAttribute("color", value);
    }

    /// <summary>
    /// The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsAfterCollapse(this AttributesBuilder<IonBreadcrumbs> b, string value)
    {
        b.SetAttribute("items-after-collapse", value);
    }

    /// <summary>
    /// The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsBeforeCollapse(this AttributesBuilder<IonBreadcrumbs> b, string value)
    {
        b.SetAttribute("items-before-collapse", value);
    }

    /// <summary>
    /// The maximum number of breadcrumbs to show before collapsing.
    /// </summary>
    public static void SetMaxItems(this AttributesBuilder<IonBreadcrumbs> b, string value)
    {
        b.SetAttribute("max-items", value);
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetMode(this AttributesBuilder<IonBreadcrumbs> b, string value)
    {
        b.SetAttribute("mode", value);
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this AttributesBuilder<IonBreadcrumbs> b)
    {
        b.SetAttribute("mode", "ios");
    }
    /// <summary>
    /// The mode determines which platform styles to use.
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
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, Var<string> value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor<T>(this PropsBuilder<T> b, string value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsAfterCollapse<T>(this PropsBuilder<T> b, Var<int> value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsAfterCollapse"), value);
    }
    /// <summary>
    /// The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsAfterCollapse<T>(this PropsBuilder<T> b, int value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsAfterCollapse"), b.Const(value));
    }

    /// <summary>
    /// The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsBeforeCollapse<T>(this PropsBuilder<T> b, Var<int> value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsBeforeCollapse"), value);
    }
    /// <summary>
    /// The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsBeforeCollapse<T>(this PropsBuilder<T> b, int value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsBeforeCollapse"), b.Const(value));
    }

    /// <summary>
    /// The maximum number of breadcrumbs to show before collapsing.
    /// </summary>
    public static void SetMaxItems<T>(this PropsBuilder<T> b, Var<int> value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxItems"), value);
    }
    /// <summary>
    /// The maximum number of breadcrumbs to show before collapsing.
    /// </summary>
    public static void SetMaxItems<T>(this PropsBuilder<T> b, int value) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxItems"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd<T>(this PropsBuilder<T> b) where T: IonBreadcrumbs
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Emitted when the collapsed indicator is clicked on.
    /// </summary>
    public static void OnIonCollapsedClick<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, BreadcrumbCollapsedClickEventDetail>> action) where TComponent: IonBreadcrumbs
    {
        b.OnEventAction("onionCollapsedClick", action, "detail");
    }
    /// <summary>
    /// Emitted when the collapsed indicator is clicked on.
    /// </summary>
    public static void OnIonCollapsedClick<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<BreadcrumbCollapsedClickEventDetail>, Var<TModel>> action) where TComponent: IonBreadcrumbs
    {
        b.OnEventAction("onionCollapsedClick", b.MakeAction(action), "detail");
    }

}

