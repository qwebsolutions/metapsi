using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Switches allow the user to toggle an option on or off.
/// </summary>
public partial class SlSwitch
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// Text that describes how to use the switch. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Simulates a click on the switch.
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// Sets focus on the switch.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the switch.
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
        /// Sets a custom validation message. Pass an empty string to restore validity.
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}
/// <summary>
/// Setter extensions of SlSwitch
/// </summary>
public static partial class SlSwitchControl
{
    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSwitch(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSwitch>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-switch", buildAttributes, children);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSwitch(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-switch", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSwitch(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSwitch>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-switch", buildAttributes, children);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSwitch(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-switch", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static void SetTitle(this Metapsi.Html.AttributesBuilder<SlSwitch> b, string title) 
    {
        b.SetAttribute("title", title);
    }

    /// <summary>
    /// The name of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlSwitch> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The current value of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlSwitch> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlSwitch> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlSwitch> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlSwitch> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlSwitch> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlSwitch> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<SlSwitch> b, bool @checked) 
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static void SetChecked(this Metapsi.Html.AttributesBuilder<SlSwitch> b) 
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlSwitch> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlSwitch> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlSwitch> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// The switch's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlSwitch> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSwitch(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSwitch>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-switch", buildProps, children);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSwitch(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-switch", children);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSwitch(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSwitch>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-switch", buildProps, children);
    }

    /// <summary>
    /// Switches allow the user to toggle an option on or off.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSwitch(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-switch", children);
    }

    /// <summary>
    /// The name of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlSwitch
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the switch, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlSwitch
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The switch's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the switch.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlSwitch
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetChecked(b.Const(true));
    }

    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> @checked) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("checked"), @checked);
    }

    /// <summary>
    /// Draws the switch in a checked state.
    /// </summary>
    public static void SetChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool @checked) where T: SlSwitch
    {
        b.SetChecked(b.Const(@checked));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDefaultChecked(b.Const(true));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> defaultChecked) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("defaultChecked"), defaultChecked);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultChecked<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool defaultChecked) where T: SlSwitch
    {
        b.SetDefaultChecked(b.Const(defaultChecked));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlSwitch
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// Makes the switch a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlSwitch
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// The switch's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlSwitch
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The switch's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlSwitch
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the control's checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the control's checked state changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSwitch
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSwitch
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}