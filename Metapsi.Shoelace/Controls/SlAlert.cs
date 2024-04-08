using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlAlert : SlComponent
{
    public SlAlert() : base("sl-alert") { }
    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public bool open
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("open");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("open", value.ToString());
        }
    }

    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public bool closable
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("closable");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("closable", value.ToString());
        }
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public string variant
    {
        get
        {
            return this.GetTag().GetAttribute<string>("variant");
        }
        set
        {
            this.GetTag().SetAttribute("variant", value.ToString());
        }
    }

    /// <summary>
    /// The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own.
    /// </summary>
    public int duration
    {
        get
        {
            return this.GetTag().GetAttribute<int>("duration");
        }
        set
        {
            this.GetTag().SetAttribute("duration", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// An icon to show in the alert. Works best with `<sl-icon>`.
        /// </summary>
        public const string Icon = "icon";
    }
    public static class Method
    {
        /// <summary> 
        /// Shows the alert.
        /// </summary>
        public const string Show = "show";
        /// <summary> 
        /// Hides the alert
        /// </summary>
        public const string Hide = "hide";
        /// <summary> 
        /// Displays the alert as a toast notification. This will move the alert out of its position in the DOM and, when dismissed, it will be removed from the DOM completely. By storing a reference to the alert, you can reuse it by calling this method again. The returned promise will resolve after the alert is hidden.
        /// </summary>
        public const string Toast = "toast";
    }
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
    /// The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own.
    /// </summary>
    public static void SetDuration(this PropsBuilder<SlAlert> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), value);
    }
    /// <summary>
    /// The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own.
    /// </summary>
    public static void SetDuration(this PropsBuilder<SlAlert> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlAlert> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlAlert> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

