using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Copies text data to the clipboard when the user clicks the trigger.
/// </summary>
public partial class SlCopyButton
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The icon to show in the default copy state. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string CopyIcon = "copy-icon";
        /// <summary>
        /// The icon to show when the content is copied. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string SuccessIcon = "success-icon";
        /// <summary>
        /// The icon to show when a copy error occurs. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string ErrorIcon = "error-icon";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlCopyButton
/// </summary>
public static partial class SlCopyButtonControl
{
    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCopyButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCopyButton>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-copy-button", buildAttributes, children);
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCopyButton(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-copy-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCopyButton(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCopyButton>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-copy-button", buildAttributes, children);
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCopyButton(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-copy-button", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The text value to copy.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`.
    /// </summary>
    public static void SetFrom(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, string from) 
    {
        b.SetAttribute("from", from);
    }

    /// <summary>
    /// Disables the copy button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the copy button.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlCopyButton> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public static void SetCopyLabel(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, string copyLabel) 
    {
        b.SetAttribute("copy-label", copyLabel);
    }

    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, string successLabel) 
    {
        b.SetAttribute("success-label", successLabel);
    }

    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, string errorLabel) 
    {
        b.SetAttribute("error-label", errorLabel);
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementTop(this Metapsi.Html.AttributesBuilder<SlCopyButton> b) 
    {
        b.SetAttribute("tooltip-placement", "top");
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementRight(this Metapsi.Html.AttributesBuilder<SlCopyButton> b) 
    {
        b.SetAttribute("tooltip-placement", "right");
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementBottom(this Metapsi.Html.AttributesBuilder<SlCopyButton> b) 
    {
        b.SetAttribute("tooltip-placement", "bottom");
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementLeft(this Metapsi.Html.AttributesBuilder<SlCopyButton> b) 
    {
        b.SetAttribute("tooltip-placement", "left");
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlCopyButton> b, bool hoist) 
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlCopyButton> b) 
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCopyButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCopyButton>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-copy-button", buildProps, children);
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCopyButton(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-copy-button", children);
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCopyButton(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCopyButton>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-copy-button", buildProps, children);
    }

    /// <summary>
    /// Copies text data to the clipboard when the user clicks the trigger.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCopyButton(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-copy-button", children);
    }

    /// <summary>
    /// The text value to copy.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The text value to copy.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlCopyButton
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`.
    /// </summary>
    public static void SetFrom<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> from) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("from"), from);
    }

    /// <summary>
    /// An id that references an element in the same document from which data will be copied. If both this and `value` are present, this value will take precedence. By default, the target element's `textContent` will be copied. To copy an attribute, append the attribute name wrapped in square brackets, e.g. `from="el[value]"`. To copy a property, append a dot and the property name, e.g. `from="el.value"`.
    /// </summary>
    public static void SetFrom<T>(this Metapsi.Syntax.PropsBuilder<T> b, string from) where T: SlCopyButton
    {
        b.SetFrom(b.Const(from));
    }

    /// <summary>
    /// Disables the copy button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the copy button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the copy button.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlCopyButton
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public static void SetCopyLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> copyLabel) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("copyLabel"), copyLabel);
    }

    /// <summary>
    /// A custom label to show in the tooltip.
    /// </summary>
    public static void SetCopyLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string copyLabel) where T: SlCopyButton
    {
        b.SetCopyLabel(b.Const(copyLabel));
    }

    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> successLabel) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("successLabel"), successLabel);
    }

    /// <summary>
    /// A custom label to show in the tooltip after copying.
    /// </summary>
    public static void SetSuccessLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string successLabel) where T: SlCopyButton
    {
        b.SetSuccessLabel(b.Const(successLabel));
    }

    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> errorLabel) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("errorLabel"), errorLabel);
    }

    /// <summary>
    /// A custom label to show in the tooltip when a copy error occurs.
    /// </summary>
    public static void SetErrorLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string errorLabel) where T: SlCopyButton
    {
        b.SetErrorLabel(b.Const(errorLabel));
    }

    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public static void SetFeedbackDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> feedbackDuration) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("feedbackDuration"), feedbackDuration);
    }

    /// <summary>
    /// The length of time to show feedback before restoring the default trigger.
    /// </summary>
    public static void SetFeedbackDuration<T>(this Metapsi.Syntax.PropsBuilder<T> b, int feedbackDuration) where T: SlCopyButton
    {
        b.SetFeedbackDuration(b.Const(feedbackDuration));
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("tooltipPlacement"), b.Const("top"));
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementRight<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("tooltipPlacement"), b.Const("right"));
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("tooltipPlacement"), b.Const("bottom"));
    }

    /// <summary>
    /// The preferred placement of the tooltip.
    /// </summary>
    public static void SetTooltipPlacementLeft<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("tooltipPlacement"), b.Const("left"));
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCopyButton
    {
        b.SetHoist(b.Const(true));
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> hoist) where T: SlCopyButton
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// Enable this option to prevent the tooltip from being clipped when the component is placed inside a container with `overflow: auto|hidden|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool hoist) where T: SlCopyButton
    {
        b.SetHoist(b.Const(hoist));
    }

    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCopyButton
    {
        b.OnSlEvent("onsl-copy", action);
    }

    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCopyButton
    {
        b.OnSlCopy(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCopyButton
    {
        b.OnSlEvent("onsl-copy", action);
    }

    /// <summary>
    /// Emitted when the data has been copied.
    /// </summary>
    public static void OnSlCopy<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCopyButton
    {
        b.OnSlCopy(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCopyButton
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCopyButton
    {
        b.OnSlError(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCopyButton
    {
        b.OnSlEvent("onsl-error", action);
    }

    /// <summary>
    /// Emitted when the data could not be copied.
    /// </summary>
    public static void OnSlError<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCopyButton
    {
        b.OnSlError(b.MakeAction(action));
    }

}