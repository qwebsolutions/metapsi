using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlColorPicker
{
    public string value { get; set; }
}
public partial class SlColorPickerBlurArgs
{
    public IClientSideSlColorPicker target { get; set; }
}
public partial class SlColorPickerChangeArgs
{
    public IClientSideSlColorPicker target { get; set; }
}
public partial class SlColorPickerFocusArgs
{
    public IClientSideSlColorPicker target { get; set; }
}
public partial class SlColorPickerInputArgs
{
    public IClientSideSlColorPicker target { get; set; }
}
public partial class SlColorPickerInvalidArgs
{
    public IClientSideSlColorPicker target { get; set; }
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
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlColorPicker> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), value);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlColorPicker> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), b.Const(value));
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
        b.SetDynamic(b.Props, DynamicProperty.String("swatches"), value);
    }
    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatchess(this PropsBuilder<SlColorPicker> b, Var<List<string>> values)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("swatches"), values);
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
    public static void OnSlBlur<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, SlColorPickerBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlColorPickerBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, SlColorPickerChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlColorPickerChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, SlColorPickerFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlColorPickerFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, SlColorPickerInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlColorPickerInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlColorPicker> b, Var<HyperType.Action<TModel, SlColorPickerInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlColorPicker> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlColorPickerInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlColorPickerInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Color pickers allow the user to select a color.
/// </summary>
public partial class SlColorPicker : HtmlTag
{
    public SlColorPicker()
    {
        this.Tag = "sl-color-picker";
    }

    public static SlColorPicker New()
    {
        return new SlColorPicker();
    }
    public static class Slot
    {
        /// <summary> 
        /// The color picker's form label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
    }
}

public static partial class SlColorPickerControl
{
    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
    /// </summary>
    public static SlColorPicker SetValue(this SlColorPicker tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlColorPicker SetDefaultValue(this SlColorPicker tag, string value)
    {
        return tag.SetAttribute("defaultValue", value.ToString());
    }
    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
    /// </summary>
    public static SlColorPicker SetLabel(this SlColorPicker tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static SlColorPicker SetFormatHex(this SlColorPicker tag)
    {
        return tag.SetAttribute("format", "hex");
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static SlColorPicker SetFormatRgb(this SlColorPicker tag)
    {
        return tag.SetAttribute("format", "rgb");
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static SlColorPicker SetFormatHsl(this SlColorPicker tag)
    {
        return tag.SetAttribute("format", "hsl");
    }
    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static SlColorPicker SetFormatHsv(this SlColorPicker tag)
    {
        return tag.SetAttribute("format", "hsv");
    }
    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static SlColorPicker SetInline(this SlColorPicker tag)
    {
        return tag.SetAttribute("inline", "true");
    }
    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static SlColorPicker SetSizeSmall(this SlColorPicker tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static SlColorPicker SetSizeMedium(this SlColorPicker tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static SlColorPicker SetSizeLarge(this SlColorPicker tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static SlColorPicker SetNoFormatToggle(this SlColorPicker tag)
    {
        return tag.SetAttribute("noFormatToggle", "true");
    }
    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
    /// </summary>
    public static SlColorPicker SetName(this SlColorPicker tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static SlColorPicker SetDisabled(this SlColorPicker tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static SlColorPicker SetHoist(this SlColorPicker tag)
    {
        return tag.SetAttribute("hoist", "true");
    }
    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static SlColorPicker SetOpacity(this SlColorPicker tag)
    {
        return tag.SetAttribute("opacity", "true");
    }
    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static SlColorPicker SetUppercase(this SlColorPicker tag)
    {
        return tag.SetAttribute("uppercase", "true");
    }
    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static SlColorPicker SetSwatches(this SlColorPicker tag, string value)
    {
        return tag.SetAttribute("swatches", value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlColorPicker SetForm(this SlColorPicker tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static SlColorPicker SetRequired(this SlColorPicker tag)
    {
        return tag.SetAttribute("required", "true");
    }
}

