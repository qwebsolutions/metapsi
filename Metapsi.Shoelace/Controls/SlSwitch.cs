using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlSwitch : SlComponent
{
    public SlSwitch() : base("sl-switch") { }
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> Text that describes how to use the switch. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Simulates a click on the switch. </para>
        /// </summary>
        public const string Click = "click";
        /// <summary>
        /// <para> Sets focus on the switch. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the switch. </para>
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
        /// <para> Sets a custom validation message. Pass an empty string to restore validity. </para>
        /// </summary>
        public const string SetCustomValidity = "setCustomValidity";
    }
}

public static partial class SlSwitchControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSwitch(this HtmlBuilder b, Action<AttributesBuilder<SlSwitch>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-switch", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSwitch(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-switch", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the switch, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlSwitch> b,string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The current value of the switch, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlSwitch> b,string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlSwitch> b,string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlSwitch> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlSwitch> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlSwitch> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Disables the switch. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlSwitch> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the switch. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlSwitch> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Draws the switch in a checked state. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<SlSwitch> b)
    {
        b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> Draws the switch in a checked state. </para>
    /// </summary>
    public static void SetChecked(this AttributesBuilder<SlSwitch> b,bool @checked)
    {
        if (@checked) b.SetAttribute("checked", "");
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlSwitch> b,string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Makes the switch a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlSwitch> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> Makes the switch a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlSwitch> b,bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> The switch's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlSwitch> b,string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSwitch(this LayoutBuilder b, Action<PropsBuilder<SlSwitch>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-switch", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSwitch(this LayoutBuilder b, Action<PropsBuilder<SlSwitch>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-switch", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSwitch(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-switch", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSwitch(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-switch", children);
    }
    /// <summary>
    /// <para> The name of the switch, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the switch, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the switch, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The current value of the switch, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The switch's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Disables the switch. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the switch. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the switch. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Draws the switch in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the switch in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, Var<bool> @checked) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), @checked);
    }

    /// <summary>
    /// <para> Draws the switch in a checked state. </para>
    /// </summary>
    public static void SetChecked<T>(this PropsBuilder<T> b, bool @checked) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("checked"), b.Const(@checked));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultChecked<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("defaultChecked"), b.Const(true));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultChecked<T>(this PropsBuilder<T> b, Var<bool> defaultChecked) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("defaultChecked"), defaultChecked);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultChecked<T>(this PropsBuilder<T> b, bool defaultChecked) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("defaultChecked"), b.Const(defaultChecked));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Makes the switch a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the switch a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), required);
    }

    /// <summary>
    /// <para> Makes the switch a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(required));
    }


    /// <summary>
    /// <para> The switch's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), helpText);
    }

    /// <summary>
    /// <para> The switch's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlSwitch
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control's checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the control's checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control's checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the control's checked state changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSwitch
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

