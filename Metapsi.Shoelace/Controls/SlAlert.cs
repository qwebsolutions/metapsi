using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlAlert
{
}
public partial class SlAlertShowArgs
{
    public IClientSideSlAlert target { get; set; }
}
public partial class SlAlertAfterShowArgs
{
    public IClientSideSlAlert target { get; set; }
}
public partial class SlAlertHideArgs
{
    public IClientSideSlAlert target { get; set; }
}
public partial class SlAlertAfterHideArgs
{
    public IClientSideSlAlert target { get; set; }
}
public static partial class SlAlertControl
{
    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Var<IVNode> SlAlert(this LayoutBuilder b, Action<PropsBuilder<SlAlert>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-alert", buildProps, children);
    }
    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Var<IVNode> SlAlert(this LayoutBuilder b, Action<PropsBuilder<SlAlert>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-alert", buildProps, children);
    }
    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
    }
    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static void SetClosable(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("closable"), b.Const(true));
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("primary"));
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("success"));
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("neutral"));
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantWarning(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("warning"));
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantDanger(this PropsBuilder<SlAlert> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("variant"), b.Const("danger"));
    }
    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, SlAlertShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertShowArgs>>("onsl-show"), action);
    }
    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAlertShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertShowArgs>>("onsl-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, SlAlertAfterShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertAfterShowArgs>>("onsl-after-show"), action);
    }
    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAlertAfterShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertAfterShowArgs>>("onsl-after-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, SlAlertHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertHideArgs>>("onsl-hide"), action);
    }
    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAlertHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertHideArgs>>("onsl-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, SlAlertAfterHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertAfterHideArgs>>("onsl-after-hide"), action);
    }
    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlAlertAfterHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlAlertAfterHideArgs>>("onsl-after-hide"), b.MakeAction(action));
    }
}

/// <summary>
/// Alerts are used to display important messages inline or as toast notifications.
/// </summary>
public partial class SlAlert : HtmlTag
{
    public SlAlert()
    {
        this.Tag = "sl-alert";
    }

    public static SlAlert New()
    {
        return new SlAlert();
    }
    public static class Slot
    {
        /// <summary> 
        /// An icon to show in the alert. Works best with `<sl-icon>`.
        /// </summary>
        public const string Icon = "icon";
    }
}

public static partial class SlAlertControl
{
    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static SlAlert SetOpen(this SlAlert tag)
    {
        return tag.SetAttribute("open", "true");
    }
    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static SlAlert SetClosable(this SlAlert tag)
    {
        return tag.SetAttribute("closable", "true");
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static SlAlert SetVariantPrimary(this SlAlert tag)
    {
        return tag.SetAttribute("variant", "primary");
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static SlAlert SetVariantSuccess(this SlAlert tag)
    {
        return tag.SetAttribute("variant", "success");
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static SlAlert SetVariantNeutral(this SlAlert tag)
    {
        return tag.SetAttribute("variant", "neutral");
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static SlAlert SetVariantWarning(this SlAlert tag)
    {
        return tag.SetAttribute("variant", "warning");
    }
    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static SlAlert SetVariantDanger(this SlAlert tag)
    {
        return tag.SetAttribute("variant", "danger");
    }
}

