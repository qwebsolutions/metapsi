using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Checkboxes allow the user to toggle an option on or off.
/// </summary>
public partial class SlCheckbox
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Text that describes how to use the checkbox. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Simulates a click on the checkbox.
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// Sets focus on the checkbox.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the checkbox.
        /// </summary>
        public const string Blur = "blur";
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
        /// Sets a custom validation message. The value provided will be shown to the user when the form is submitted. To clear the custom validation message, call this method with an empty string.
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}
/// <summary>
/// Setter extensions of SlCheckbox
/// </summary>
public static partial class SlCheckboxControl
{
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCheckbox(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCheckbox>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-checkbox", buildAttributes, children);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCheckbox(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-checkbox", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCheckbox(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlCheckbox>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-checkbox", buildAttributes, children);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlCheckbox(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-checkbox", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetTitle(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, string title) 
    {
        b.SetAttribute("title", title);
    }

    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, bool @checked) 
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, bool indeterminate) 
    {
        if (indeterminate) b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlCheckbox> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlCheckbox> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCheckbox>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-checkbox", children);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlCheckbox>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }

    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlCheckbox(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-checkbox", children);
    }

    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlCheckbox
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlCheckbox
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlCheckbox
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetChecked(b.Const(true));
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @checked) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("checked"), @checked);
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @checked) where T: SlCheckbox
    {
        b.SetChecked(b.Const(@checked));
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetIndeterminate(b.Const(true));
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> indeterminate) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("indeterminate"), indeterminate);
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool indeterminate) where T: SlCheckbox
    {
        b.SetIndeterminate(b.Const(indeterminate));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDefaultChecked(b.Const(true));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> defaultChecked) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("defaultChecked"), defaultChecked);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool defaultChecked) where T: SlCheckbox
    {
        b.SetDefaultChecked(b.Const(defaultChecked));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlCheckbox
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlCheckbox
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlCheckbox
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlCheckbox
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlCheckbox
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlCheckbox
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}