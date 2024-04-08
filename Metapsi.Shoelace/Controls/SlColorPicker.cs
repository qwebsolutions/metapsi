using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlColorPicker : SlComponent
{
    public SlColorPicker() : base("sl-color-picker") { }
    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
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
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public string defaultValue
    {
        get
        {
            return this.GetTag().GetAttribute<string>("");
        }
        set
        {
            this.GetTag().SetAttribute("", value.ToString());
        }
    }

    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
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
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public string format
    {
        get
        {
            return this.GetTag().GetAttribute<string>("format");
        }
        set
        {
            this.GetTag().SetAttribute("format", value.ToString());
        }
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public bool inline
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("inline");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("inline", value.ToString());
        }
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
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
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public bool noFormatToggle
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("no-format-toggle");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("no-format-toggle", value.ToString());
        }
    }

    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
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
    /// Disables the color picker.
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
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public bool hoist
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("hoist");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("hoist", value.ToString());
        }
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public bool opacity
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("opacity");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("opacity", value.ToString());
        }
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public bool uppercase
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("uppercase");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("uppercase", value.ToString());
        }
    }

    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public string swatches
    {
        get
        {
            return this.GetTag().GetAttribute<string>("swatches");
        }
        set
        {
            this.GetTag().SetAttribute("swatches", value.ToString());
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
    /// Makes the color picker a required field.
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
        /// The color picker's form label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
    }
    public static class Method
    {
        /// <summary> 
        /// Generates a hex string from HSV values. Hue must be 0-360. All other arguments must be 0-100.
        /// </summary>
        public const string GetHexString = "getHexString";
        /// <summary> 
        /// Sets focus on the color picker.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the color picker.
        /// </summary>
        public const string Blur = "blur";
        /// <summary> 
        /// Returns the current value as a string in the specified format.
        /// </summary>
        public const string GetFormattedValue = "getFormattedValue";
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

public static partial class SlColorPickerControl
{
    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Var<IVNode> SlColorPicker(this LayoutBuilder b, Action<PropsBuilder<SlColorPicker>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-color-picker", buildProps, children);
    }
    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Var<IVNode> SlColorPicker(this LayoutBuilder b, Action<PropsBuilder<SlColorPicker>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-color-picker", buildProps, children);
    }
    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlColorPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlColorPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }

    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlColorPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlColorPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHex(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("hex"));
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatRgb(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("rgb"));
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHsl(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("hsl"));
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHsv(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("format"), b.Const("hsv"));
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static void SetInline(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("inline"), b.Const(true));
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }

    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static void SetNoFormatToggle(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("noFormatToggle"), b.Const(true));
    }

    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlColorPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlColorPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("hoist"), b.Const(true));
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static void SetOpacity(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("opacity"), b.Const(true));
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static void SetUppercase(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("uppercase"), b.Const(true));
    }

    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches(this PropsBuilder<SlColorPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("swatches"), value);
    }
    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches(this PropsBuilder<SlColorPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("swatches"), b.Const(value));
    }
    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches(this PropsBuilder<SlColorPicker> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("swatches"), value);
    }
    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches(this PropsBuilder<SlColorPicker> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("swatches"), b.Const(value));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlColorPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlColorPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlColorPicker> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }

    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

