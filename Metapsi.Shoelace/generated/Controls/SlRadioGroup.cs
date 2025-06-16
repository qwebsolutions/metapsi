using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
/// </summary>
public partial class SlRadioGroup
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The radio group's label. Required for proper accessibility. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Text that describes how to use the radio group. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
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
        /// <summary>
        /// Sets focus on the radio-group.
        /// </summary>
        public const string Focus = "focus";
    }
}
/// <summary>
/// Setter extensions of SlRadioGroup
/// </summary>
public static partial class SlRadioGroupControl
{
    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRadioGroup>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-radio-group", buildAttributes, children);
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioGroup(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-radio-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlRadioGroup>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-radio-group", buildAttributes, children);
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlRadioGroup(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-radio-group", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The current value of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlRadioGroup> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRadioGroup>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-radio-group", buildProps, children);
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-radio-group", children);
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlRadioGroup>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-radio-group", buildProps, children);
    }

    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlRadioGroup(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-radio-group", children);
    }

    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlRadioGroup
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlRadioGroup
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlRadioGroup
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlRadioGroup
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlRadioGroup
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlRadioGroup
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlRadioGroup
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlRadioGroup
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadioGroup
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadioGroup
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlRadioGroup
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlRadioGroup
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}