using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Alerts are used to display important messages inline or as toast notifications.
/// </summary>
public partial class SlAlert
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// An icon to show in the alert. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string Icon = "icon";
    }
    /// <summary>
    /// 
    /// </summary>
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
/// <summary>
/// Setter extensions of SlAlert
/// </summary>
public static partial class SlAlertControl
{
    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAlert(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAlert>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-alert", buildAttributes, children);
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAlert(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-alert", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAlert(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlAlert>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-alert", buildAttributes, children);
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlAlert(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-alert", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlAlert> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static void SetClosable(this Metapsi.Html.AttributesBuilder<SlAlert> b, bool closable) 
    {
        if (closable) b.SetAttribute("closable", "");
    }

    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static void SetClosable(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("closable", "");
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantPrimary(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("variant", "primary");
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantSuccess(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("variant", "success");
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantNeutral(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("variant", "neutral");
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantWarning(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("variant", "warning");
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantDanger(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("variant", "danger");
    }

    /// <summary>
    /// The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own.
    /// </summary>
    public static void SetDuration(this Metapsi.Html.AttributesBuilder<SlAlert> b, string duration) 
    {
        b.SetAttribute("duration", duration);
    }

    /// <summary>
    /// Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh.
    /// </summary>
    public static void SetCountdownRtl(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("countdown", "rtl");
    }

    /// <summary>
    /// Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh.
    /// </summary>
    public static void SetCountdownLtr(this Metapsi.Html.AttributesBuilder<SlAlert> b) 
    {
        b.SetAttribute("countdown", "ltr");
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAlert(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAlert>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-alert", buildProps, children);
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAlert(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-alert", children);
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAlert(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlAlert>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-alert", buildProps, children);
    }

    /// <summary>
    /// Alerts are used to display important messages inline or as toast notifications.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlAlert(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-alert", children);
    }

    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the alert is open. You can toggle this attribute to show and hide the alert, or you can use the `show()` and `hide()` methods and this attribute will reflect the alert's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlAlert
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static void SetClosable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetClosable(b.Const(true));
    }

    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static void SetClosable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> closable) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("closable"), closable);
    }

    /// <summary>
    /// Enables a close button that allows the user to dismiss the alert.
    /// </summary>
    public static void SetClosable<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool closable) where T: SlAlert
    {
        b.SetClosable(b.Const(closable));
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantPrimary<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("primary"));
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantSuccess<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("success"));
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantNeutral<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("neutral"));
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantWarning<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("warning"));
    }

    /// <summary>
    /// The alert's theme variant.
    /// </summary>
    public static void SetVariantDanger<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("variant"), b.Const("danger"));
    }

    /// <summary>
    /// The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> duration) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("duration"), duration);
    }

    /// <summary>
    /// The length of time, in milliseconds, the alert will show before closing itself. If the user interacts with the alert before it closes (e.g. moves the mouse over it), the timer will restart. Defaults to `Infinity`, meaning the alert will not close on its own.
    /// </summary>
    public static void SetDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, string duration) where T: SlAlert
    {
        b.SetDuration(b.Const(duration));
    }

    /// <summary>
    /// Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh.
    /// </summary>
    public static void SetCountdownRtl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("countdown"), b.Const("rtl"));
    }

    /// <summary>
    /// Enables a countdown that indicates the remaining time the alert will be displayed. Typically used to indicate the remaining time before a whole app refresh.
    /// </summary>
    public static void SetCountdownLtr<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlAlert
    {
        b.SetProperty(b.Props, b.Const("countdown"), b.Const("ltr"));
    }

    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the alert opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the alert opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the alert closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlAlert
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the alert closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlAlert
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

}