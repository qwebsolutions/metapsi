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
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The color picker's form label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Generates a hex string from HSV values. Hue must be 0-360. All other arguments must be 0-100. </para>
        /// </summary>
        public const string GetHexString = "getHexString";
        /// <summary>
        /// <para> Sets focus on the color picker. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the color picker. </para>
        /// </summary>
        public const string Blur = "blur";
        /// <summary>
        /// <para> Returns the current value as a string in the specified format. </para>
        /// </summary>
        public const string GetFormattedValue = "getFormattedValue";
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

public static partial class SlColorPickerControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlColorPicker(this HtmlBuilder b, Action<AttributesBuilder<SlColorPicker>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-color-picker", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlColorPicker(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-color-picker", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlColorPicker> b,string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlColorPicker> b,string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormat(this AttributesBuilder<SlColorPicker> b,string format)
    {
        b.SetAttribute("format", format);
    }

    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatHex(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("format", "hex");
    }

    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatRgb(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("format", "rgb");
    }

    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatHsl(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("format", "hsl");
    }

    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatHsv(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("format", "hsv");
    }

    /// <summary>
    /// <para> Renders the color picker inline rather than in a dropdown. </para>
    /// </summary>
    public static void SetInline(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("inline", "");
    }

    /// <summary>
    /// <para> Renders the color picker inline rather than in a dropdown. </para>
    /// </summary>
    public static void SetInline(this AttributesBuilder<SlColorPicker> b,bool inline)
    {
        if (inline) b.SetAttribute("inline", "");
    }

    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlColorPicker> b,string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Removes the button that lets users toggle between format. </para>
    /// </summary>
    public static void SetNoFormatToggle(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("no-format-toggle", "");
    }

    /// <summary>
    /// <para> Removes the button that lets users toggle between format. </para>
    /// </summary>
    public static void SetNoFormatToggle(this AttributesBuilder<SlColorPicker> b,bool noFormatToggle)
    {
        if (noFormatToggle) b.SetAttribute("no-format-toggle", "");
    }

    /// <summary>
    /// <para> The name of the form control, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlColorPicker> b,string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> Disables the color picker. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the color picker. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlColorPicker> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlColorPicker> b,bool hoist)
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA. </para>
    /// </summary>
    public static void SetOpacity(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("opacity", "");
    }

    /// <summary>
    /// <para> Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA. </para>
    /// </summary>
    public static void SetOpacity(this AttributesBuilder<SlColorPicker> b,bool opacity)
    {
        if (opacity) b.SetAttribute("opacity", "");
    }

    /// <summary>
    /// <para> By default, values are lowercase. With this attribute, values will be uppercase instead. </para>
    /// </summary>
    public static void SetUppercase(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("uppercase", "");
    }

    /// <summary>
    /// <para> By default, values are lowercase. With this attribute, values will be uppercase instead. </para>
    /// </summary>
    public static void SetUppercase(this AttributesBuilder<SlColorPicker> b,bool uppercase)
    {
        if (uppercase) b.SetAttribute("uppercase", "");
    }

    /// <summary>
    /// <para> One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript. </para>
    /// </summary>
    public static void SetSwatches(this AttributesBuilder<SlColorPicker> b,string swatches)
    {
        b.SetAttribute("swatches", swatches);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlColorPicker> b,string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> Makes the color picker a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlColorPicker> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> Makes the color picker a required field. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlColorPicker> b,bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlColorPicker(this LayoutBuilder b, Action<PropsBuilder<SlColorPicker>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-color-picker", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlColorPicker(this LayoutBuilder b, Action<PropsBuilder<SlColorPicker>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-color-picker", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlColorPicker(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-color-picker", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlColorPicker(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-color-picker", children);
    }
    /// <summary>
    /// <para> The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, Var<string> defaultValue) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), defaultValue);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, string defaultValue) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("defaultValue"), b.Const(defaultValue));
    }


    /// <summary>
    /// <para> The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatHex<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("hex"));
    }


    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatRgb<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("rgb"));
    }


    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatHsl<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("hsl"));
    }


    /// <summary>
    /// <para> The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format. </para>
    /// </summary>
    public static void SetFormatHsv<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("format"), b.Const("hsv"));
    }


    /// <summary>
    /// <para> Renders the color picker inline rather than in a dropdown. </para>
    /// </summary>
    public static void SetInline<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("inline"), b.Const(true));
    }


    /// <summary>
    /// <para> Renders the color picker inline rather than in a dropdown. </para>
    /// </summary>
    public static void SetInline<T>(this PropsBuilder<T> b, Var<bool> inline) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("inline"), inline);
    }

    /// <summary>
    /// <para> Renders the color picker inline rather than in a dropdown. </para>
    /// </summary>
    public static void SetInline<T>(this PropsBuilder<T> b, bool inline) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("inline"), b.Const(inline));
    }


    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> Determines the size of the color picker's trigger. This has no effect on inline color pickers. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Removes the button that lets users toggle between format. </para>
    /// </summary>
    public static void SetNoFormatToggle<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noFormatToggle"), b.Const(true));
    }


    /// <summary>
    /// <para> Removes the button that lets users toggle between format. </para>
    /// </summary>
    public static void SetNoFormatToggle<T>(this PropsBuilder<T> b, Var<bool> noFormatToggle) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noFormatToggle"), noFormatToggle);
    }

    /// <summary>
    /// <para> Removes the button that lets users toggle between format. </para>
    /// </summary>
    public static void SetNoFormatToggle<T>(this PropsBuilder<T> b, bool noFormatToggle) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("noFormatToggle"), b.Const(noFormatToggle));
    }


    /// <summary>
    /// <para> The name of the form control, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The name of the form control, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> Disables the color picker. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the color picker. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the color picker. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), b.Const(true));
    }


    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, Var<bool> hoist) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), hoist);
    }

    /// <summary>
    /// <para> Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, bool hoist) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("hoist"), b.Const(hoist));
    }


    /// <summary>
    /// <para> Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA. </para>
    /// </summary>
    public static void SetOpacity<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("opacity"), b.Const(true));
    }


    /// <summary>
    /// <para> Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA. </para>
    /// </summary>
    public static void SetOpacity<T>(this PropsBuilder<T> b, Var<bool> opacity) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("opacity"), opacity);
    }

    /// <summary>
    /// <para> Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA. </para>
    /// </summary>
    public static void SetOpacity<T>(this PropsBuilder<T> b, bool opacity) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("opacity"), b.Const(opacity));
    }


    /// <summary>
    /// <para> By default, values are lowercase. With this attribute, values will be uppercase instead. </para>
    /// </summary>
    public static void SetUppercase<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("uppercase"), b.Const(true));
    }


    /// <summary>
    /// <para> By default, values are lowercase. With this attribute, values will be uppercase instead. </para>
    /// </summary>
    public static void SetUppercase<T>(this PropsBuilder<T> b, Var<bool> uppercase) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("uppercase"), uppercase);
    }

    /// <summary>
    /// <para> By default, values are lowercase. With this attribute, values will be uppercase instead. </para>
    /// </summary>
    public static void SetUppercase<T>(this PropsBuilder<T> b, bool uppercase) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("uppercase"), b.Const(uppercase));
    }


    /// <summary>
    /// <para> One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript. </para>
    /// </summary>
    public static void SetSwatches<T>(this PropsBuilder<T> b, Var<string> swatches) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("swatches"), swatches);
    }

    /// <summary>
    /// <para> One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript. </para>
    /// </summary>
    public static void SetSwatches<T>(this PropsBuilder<T> b, string swatches) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("swatches"), b.Const(swatches));
    }


    /// <summary>
    /// <para> One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript. </para>
    /// </summary>
    public static void SetSwatches<T>(this PropsBuilder<T> b, Var<List<string>> swatches) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("swatches"), swatches);
    }

    /// <summary>
    /// <para> One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript. </para>
    /// </summary>
    public static void SetSwatches<T>(this PropsBuilder<T> b, List<string> swatches) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("swatches"), b.Const(swatches));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(form));
    }


    /// <summary>
    /// <para> Makes the color picker a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the color picker a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), required);
    }

    /// <summary>
    /// <para> Makes the color picker a required field. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlColorPicker
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("required"), b.Const(required));
    }


    /// <summary>
    /// <para> Emitted when the color picker loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker receives focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker receives focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker receives focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker receives focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the color picker receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the color picker receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlColorPicker
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

