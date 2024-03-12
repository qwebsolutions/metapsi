using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonBreadcrumbs
{
}

public static partial class IonBreadcrumbsControl
{
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
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDanger(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("danger"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorDark(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("dark"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorLight(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("light"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorMedium(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("medium"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorPrimary(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("primary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSecondary(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("secondary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorSuccess(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("success"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorTertiary(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("tertiary"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColorWarning(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("color"), b.Const("warning"));
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonBreadcrumbs> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), value);
    }
    /// <summary>
    /// The color to use from your application's color palette. Default options are: `"primary"`, `"secondary"`, `"tertiary"`, `"success"`, `"warning"`, `"danger"`, `"light"`, `"medium"`, and `"dark"`. For more information on colors, see [theming](/docs/theming/basics).
    /// </summary>
    public static void SetColor(this PropsBuilder<IonBreadcrumbs> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("color"), b.Const(value));
    }

    /// <summary>
    /// The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsAfterCollapse(this PropsBuilder<IonBreadcrumbs> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsAfterCollapse"), value);
    }
    /// <summary>
    /// The number of breadcrumbs to show after the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsAfterCollapse(this PropsBuilder<IonBreadcrumbs> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsAfterCollapse"), b.Const(value));
    }

    /// <summary>
    /// The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsBeforeCollapse(this PropsBuilder<IonBreadcrumbs> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsBeforeCollapse"), value);
    }
    /// <summary>
    /// The number of breadcrumbs to show before the collapsed indicator. If `itemsBeforeCollapse` + `itemsAfterCollapse` is greater than `maxItems`, the breadcrumbs will not be collapsed.
    /// </summary>
    public static void SetItemsBeforeCollapse(this PropsBuilder<IonBreadcrumbs> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("itemsBeforeCollapse"), b.Const(value));
    }

    /// <summary>
    /// The maximum number of breadcrumbs to show before collapsing.
    /// </summary>
    public static void SetMaxItems(this PropsBuilder<IonBreadcrumbs> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxItems"), value);
    }
    /// <summary>
    /// The maximum number of breadcrumbs to show before collapsing.
    /// </summary>
    public static void SetMaxItems(this PropsBuilder<IonBreadcrumbs> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxItems"), b.Const(value));
    }

    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeIos(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("ios"));
    }
    /// <summary>
    /// The mode determines which platform styles to use.
    /// </summary>
    public static void SetModeMd(this PropsBuilder<IonBreadcrumbs> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("mode"), b.Const("md"));
    }

    /// <summary>
    /// Emitted when the collapsed indicator is clicked on.
    /// </summary>
    public static void OnIonCollapsedClick<TModel>(this PropsBuilder<IonBreadcrumbs> b, Var<HyperType.Action<TModel, BreadcrumbCollapsedClickEventDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<BreadcrumbCollapsedClickEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, BreadcrumbCollapsedClickEventDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionCollapsedClick"), eventAction);
    }
    /// <summary>
    /// Emitted when the collapsed indicator is clicked on.
    /// </summary>
    public static void OnIonCollapsedClick<TModel>(this PropsBuilder<IonBreadcrumbs> b, System.Func<SyntaxBuilder, Var<TModel>, Var<BreadcrumbCollapsedClickEventDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<BreadcrumbCollapsedClickEventDetail>("detail"));
            return b.MakeActionDescriptor<TModel, BreadcrumbCollapsedClickEventDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionCollapsedClick"), eventAction);
    }

}

