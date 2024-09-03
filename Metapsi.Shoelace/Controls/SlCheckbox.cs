using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlCheckbox
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Text that describes how to use the checkbox. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Simulates a click on the checkbox. </para>
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// <para> Sets focus on the checkbox. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the checkbox. </para>
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// <para> Checks for validity but does not show a validation message. Returns `true` when valid and `false` when invalid. </para>
        /// </summary>
        public const string CheckValidity = "checkValidity";
        /// <summary>
        /// <para> Gets the associated form, if one exists. </para>
        /// </summary>
        public const string GetForm = "getForm";
        /// <summary>
        /// <para> Checks for validity and shows the browser's validation message if the control is invalid. </para>
        /// </summary>
        public const string ReportValidity = "reportValidity";
        /// <summary>
        /// <para> Sets a custom validation message. The value provided will be shown to the user when the form is submitted. To clear the custom validation message, call this method with an empty string. </para>
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlCheckboxControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCheckbox(this HtmlBuilder b, Action<AttributesBuilder<SlCheckbox>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-checkbox", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCheckbox(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-checkbox", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCheckbox(this HtmlBuilder b, Action<AttributesBuilder<SlCheckbox>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-checkbox", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlCheckbox(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-checkbox", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the checkbox, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlCheckbox> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The current value of the checkbox, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlCheckbox> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlCheckbox> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Disables the checkbox. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the checkbox. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlCheckbox> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Draws the checkbox in a checked state. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> Draws the checkbox in a checked state. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<SlCheckbox> b, bool @checked)
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states. </para>
    /// </summary>
    public static void SetIndeterminate(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// <para> Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states. </para>
    /// </summary>
    public static void SetIndeterminate(this AttributesBuilder<SlCheckbox> b, bool indeterminate)
    {
        if (indeterminate) b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlCheckbox> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Makes the checkbox a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlCheckbox> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> Makes the checkbox a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlCheckbox> b, bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> The checkbox's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlCheckbox> b, string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Action<PropsBuilder<SlCheckbox>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Action<PropsBuilder<SlCheckbox>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-checkbox", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-checkbox", children);
    }
    /// <summary>
    /// <para> The name of the checkbox, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the checkbox, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the checkbox, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The current value of the checkbox, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The checkbox's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Disables the checkbox. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the checkbox. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the checkbox. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Draws the checkbox in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the checkbox in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, Var<bool> @checked) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), @checked);
    }

    /// <summary>
    /// <para> Draws the checkbox in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, bool @checked) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(@checked));
    }


    /// <summary>
    /// <para> Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b, Var<bool> indeterminate) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), indeterminate);
    }

    /// <summary>
    /// <para> Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states. </para>
    /// </summary>
    public static void SetIndeterminate<T>(this PropsBuilder<T> b, bool indeterminate) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("indeterminate"), b.Const(indeterminate));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultChecked<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("defaultChecked"), b.Const(true));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultChecked<T>(this PropsBuilder<T> b, Var<bool> defaultChecked) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("defaultChecked"), defaultChecked);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultChecked<T>(this PropsBuilder<T> b, bool defaultChecked) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("defaultChecked"), b.Const(defaultChecked));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Makes the checkbox a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the checkbox a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), required);
    }

    /// <summary>
    /// <para> Makes the checkbox a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(required));
    }


    /// <summary>
    /// <para> The checkbox's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), helpText);
    }

    /// <summary>
    /// <para> The checkbox's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlCheckbox
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> Emitted when the checkbox loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checkbox loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checkbox gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checkbox gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checkbox receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the checkbox receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the checkbox receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlCheckbox
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

