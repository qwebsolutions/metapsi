using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlAlert
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> An icon to show in the alert. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string Icon = "icon";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the alert. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the alert </para>
        /// </summary>
        public const string Hide = "hide";
        /// <summary>
        /// <para> Displays the alert as a toast notification. This will move the alert out of its position in the DOM and, when dismissed, it will be removed from the DOM completely. By storing a reference to the alert, you can reuse it by calling this method again. The returned promise will resolve after the alert is hidden. </para>
        /// </summary>
        public const string Toast = "toast";
    }
}

public static partial class SlAlertControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAlert(this HtmlBuilder b, Action<AttributesBuilder<SlAlert>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-alert", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAlert(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-alert", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAlert(this HtmlBuilder b, Action<AttributesBuilder<SlAlert>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-alert", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlAlert(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-alert", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlAlert> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Enables a close button that allows the user to dismiss the alert. </para>
    /// </summary>
    public static void SetClosable(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("closable", "");
    }

    /// <summary>
    /// <para> Enables a close button that allows the user to dismiss the alert. </para>
    /// </summary>
    public static void SetClosable(this AttributesBuilder<SlAlert> b, bool closable)
    {
        if (closable) b.SetAttribute("closable", "");
    }

    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariant(this AttributesBuilder<SlAlert> b, string variant)
    {
        b.SetAttribute("variant", variant);
    }

    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// <para> The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own. </para>
    /// </summary>
    public static void SetDuration(this AttributesBuilder<SlAlert> b, string duration)
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// <para> Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh. </para>
    /// </summary>
    public static void SetCountdown(this AttributesBuilder<SlAlert> b, string countdown)
    {
        b.SetAttribute("countdown", countdown);
    }

    /// <summary>
    /// <para> Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh. </para>
    /// </summary>
    public static void SetCountdownRtl(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("countdown", "rtl");
    }

    /// <summary>
    /// <para> Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh. </para>
    /// </summary>
    public static void SetCountdownLtr(this AttributesBuilder<SlAlert> b)
    {
        b.SetAttribute("countdown", "ltr");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAlert(this LayoutBuilder b, Action<PropsBuilder<SlAlert>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-alert", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAlert(this LayoutBuilder b, Action<PropsBuilder<SlAlert>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-alert", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAlert(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-alert", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlAlert(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-alert", children);
    }
    /// <summary>
    /// <para> Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("open"), b.Const(open));
    }


    /// <summary>
    /// <para> Enables a close button that allows the user to dismiss the alert. </para>
    /// </summary>
    public static void SetClosable<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("closable"), b.Const(true));
    }


    /// <summary>
    /// <para> Enables a close button that allows the user to dismiss the alert. </para>
    /// </summary>
    public static void SetClosable<T>(this PropsBuilder<T> b, Var<bool> closable) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("closable"), closable);
    }

    /// <summary>
    /// <para> Enables a close button that allows the user to dismiss the alert. </para>
    /// </summary>
    public static void SetClosable<T>(this PropsBuilder<T> b, bool closable) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("closable"), b.Const(closable));
    }


    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantPrimary<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("primary"));
    }


    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantSuccess<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("success"));
    }


    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantNeutral<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("neutral"));
    }


    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantWarning<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("warning"));
    }


    /// <summary>
    /// <para> The alert's theme variant. </para>
    /// </summary>
    public static void SetVariantDanger<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("variant"), b.Const("danger"));
    }


    /// <summary>
    /// <para> The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, Var<int> duration) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), duration);
    }

    /// <summary>
    /// <para> The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own. </para>
    /// </summary>
    public static void SetDuration<T>(this PropsBuilder<T> b, int duration) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("duration"), b.Const(duration));
    }


    /// <summary>
    /// <para> Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh. </para>
    /// </summary>
    public static void SetCountdownRtl<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("countdown"), b.Const("rtl"));
    }


    /// <summary>
    /// <para> Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh. </para>
    /// </summary>
    public static void SetCountdownLtr<T>(this PropsBuilder<T> b) where T: SlAlert
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("countdown"), b.Const("ltr"));
    }


    /// <summary>
    /// <para> Emitted when the alert opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the alert opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the alert opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the alert opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the alert opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the alert opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the alert opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the alert opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the alert closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the alert closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the alert closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the alert closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the alert closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the alert closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the alert closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the alert closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlAlert
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

}

