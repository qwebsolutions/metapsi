using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlCheckbox : SlComponent
{
    public SlCheckbox() : base("sl-checkbox") { }
    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public string name
    {
        get
        {
            return this.GetTag().GetAttribute<string>("name");
        }
        set
        {
            this.GetTag().SetAttribute("name", value.ToString());
        }
    }

    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public string value
    {
        get
        {
            return this.GetTag().GetAttribute<string>("value");
        }
        set
        {
            this.GetTag().SetAttribute("value", value.ToString());
        }
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public string size
    {
        get
        {
            return this.GetTag().GetAttribute<string>("size");
        }
        set
        {
            this.GetTag().SetAttribute("size", value.ToString());
        }
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public bool @checked
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("checked");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("checked", value.ToString());
        }
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public bool indeterminate
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("indeterminate");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("indeterminate", value.ToString());
        }
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public bool defaultChecked
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("", value.ToString());
        }
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public string form
    {
        get
        {
            return this.GetTag().GetAttribute<string>("form");
        }
        set
        {
            this.GetTag().SetAttribute("form", value.ToString());
        }
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public bool required
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("required");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("required", value.ToString());
        }
    }

    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public string helpText
    {
        get
        {
            return this.GetTag().GetAttribute<string>("help-text");
        }
        set
        {
            this.GetTag().SetAttribute("help-text", value.ToString());
        }
    }

    public static class Slot
    {
        /// <summary> 
        /// Text that describes how to use the checkbox. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
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

public static partial class SlCheckboxControl
{
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Action<PropsBuilder<SlCheckbox>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Action<PropsBuilder<SlCheckbox>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-checkbox", buildProps, children);
    }
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-checkbox", children);
    }
    /// <summary>
    /// Checkboxes allow the user to toggle an option on or off.
    /// </summary>
    public static Var<IVNode> SlCheckbox(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-checkbox", children);
    }
    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the checkbox, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The checkbox's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }

    /// <summary>
    /// Disables the checkbox.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Draws the checkbox in a checked state.
    /// </summary>
    public static void SetChecked(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("checked"), b.Const(true));
    }

    /// <summary>
    /// Draws the checkbox in an indeterminate state. This is usually applied to checkboxes that represents a "select all/none" behavior when associated checkboxes have a mix of checked and unchecked states.
    /// </summary>
    public static void SetIndeterminate(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("indeterminate"), b.Const(true));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Makes the checkbox a required field.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlCheckbox> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }

    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlCheckbox> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), value);
    }
    /// <summary>
    /// The checkbox's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlCheckbox> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the checkbox loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the checked state changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the checkbox gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the checkbox receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlCheckbox> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

