using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Ranges allow the user to select a single value within a given range using a slider.
/// </summary>
public partial class SlRange
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The range's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Text that describes how to use the input. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Sets focus on the range.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the range.
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// Increments the value of the range by the value of the step attribute.
        /// </summary>
        public const string StepUp = "stepUp";
        /// <summary>
        /// Decrements the value of the range by the value of the step attribute.
        /// </summary>
        public const string StepDown = "stepDown";
        /// <summary>
        /// Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid.
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary>
        /// Gets the associated form, if one exists.
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary>
        /// Checks for validity and shows the browser's validation message if the control is invalid.
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary>
        /// Sets a custom validation message. Pass an empty string to restore validity.
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}
/// <summary>
/// Setter extensions of SlRange
/// </summary>
public static partial class SlRangeControl
{
    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRange(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRange>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-range", buildAttributes, children);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRange(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-range", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRange(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRange>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-range", buildAttributes, children);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRange(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-range", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetTitle(this Metapsi.Html.AttributesBuilder<SlRange> b, string title) 
    {
        b.SetAttribute("title", title);
    }

    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlRange> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlRange> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlRange> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// Disables the range.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRange> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the range.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlRange> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipTop(this Metapsi.Html.AttributesBuilder<SlRange> b) 
    {
        b.SetAttribute("tooltip", "top");
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipBottom(this Metapsi.Html.AttributesBuilder<SlRange> b) 
    {
        b.SetAttribute("tooltip", "bottom");
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipNone(this Metapsi.Html.AttributesBuilder<SlRange> b) 
    {
        b.SetAttribute("tooltip", "none");
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlRange> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRange(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRange>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-range", buildProps, children);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRange(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-range", children);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRange(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRange>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-range", buildProps, children);
    }

    /// <summary>
    /// Ranges allow the user to select a single value within a given range using a slider.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRange(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-range", children);
    }

    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlRange
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> value) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, int value) where T: SlRange
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> value) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the range, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal value) where T: SlRange
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The range's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlRange
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The range's help text. If you need to display HTML, use the help-text slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlRange
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// Disables the range.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRange
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the range.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the range.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlRange
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> min) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, int min) where T: SlRange
    {
        b.SetMin(b.Const(min));
    }

    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> min) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("min"), min);
    }

    /// <summary>
    /// The minimum acceptable value of the range.
    /// </summary>
    public static void SetMin<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal min) where T: SlRange
    {
        b.SetMin(b.Const(min));
    }

    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> max) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, int max) where T: SlRange
    {
        b.SetMax(b.Const(max));
    }

    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> max) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }

    /// <summary>
    /// The maximum acceptable value of the range.
    /// </summary>
    public static void SetMax<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal max) where T: SlRange
    {
        b.SetMax(b.Const(max));
    }

    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> step) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }

    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, int step) where T: SlRange
    {
        b.SetStep(b.Const(step));
    }

    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> step) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("step"), step);
    }

    /// <summary>
    /// The interval at which the range will increase and decrease.
    /// </summary>
    public static void SetStep<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal step) where T: SlRange
    {
        b.SetStep(b.Const(step));
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("tooltip"), b.Const("top"));
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("tooltip"), b.Const("bottom"));
    }

    /// <summary>
    /// The preferred placement of the range's tooltip.
    /// </summary>
    public static void SetTooltipNone<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("tooltip"), b.Const("none"));
    }

    /// <summary>
    /// A function used to format the tooltip's value. The range's value is passed as the first and only argument. The function should return a string to display in the tooltip.
    /// </summary>
    public static void SetTooltipFormatter<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Func<decimal, string>>> tooltipFormatter) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("tooltipFormatter"), tooltipFormatter);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlRange
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> defaultValue) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, int defaultValue) where T: SlRange
    {
        b.SetDefaultValue(b.Const(defaultValue));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> defaultValue) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal defaultValue) where T: SlRange
    {
        b.SetDefaultValue(b.Const(defaultValue));
    }

    /// <summary>
    /// Gets the validity state object
    /// </summary>
    public static void SetValidity<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> validity) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("validity"), validity);
    }

    /// <summary>
    /// Gets the validity state object
    /// </summary>
    public static void SetValidity<T>(this Metapsi.Syntax.PropsBuilder<T> b, string validity) where T: SlRange
    {
        b.SetValidity(b.Const(validity));
    }

    /// <summary>
    /// Gets the validation message
    /// </summary>
    public static void SetValidationMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> validationMessage) where T: SlRange
    {
        b.SetProperty(b.Props, b.Const("validationMessage"), validationMessage);
    }

    /// <summary>
    /// Gets the validation message
    /// </summary>
    public static void SetValidationMessage<T>(this Metapsi.Syntax.PropsBuilder<T> b, string validationMessage) where T: SlRange
    {
        b.SetValidationMessage(b.Const(validationMessage));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when an alteration to the control's value is committed by the user.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRange
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRange
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}