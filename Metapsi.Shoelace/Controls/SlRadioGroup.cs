using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRadioGroup : SlComponent
{
    public SlRadioGroup() : base("sl-radio-group") { }
    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
    }

    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
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

    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
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
    /// The current value of the radio group, submitted as a name/value pair with form data.
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
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
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
    /// Ensures a child radio is checked before allowing the containing form to submit.
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
    }
}

public static partial class SlRadioGroupControl
{
    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Var<IVNode> SlRadioGroup(this LayoutBuilder b, Action<PropsBuilder<SlRadioGroup>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-radio-group", buildProps, children);
    }
    /// <summary>
    /// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
    /// </summary>
    public static Var<IVNode> SlRadioGroup(this LayoutBuilder b, Action<PropsBuilder<SlRadioGroup>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-radio-group", buildProps, children);
    }
    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), value);
    }
    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), b.Const(value));
    }

    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The current value of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlRadioGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlRadioGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlRadioGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlRadioGroup> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlRadioGroup> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("required"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

