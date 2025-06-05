using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Color pickers allow the user to select a color.
/// </summary>
public partial class SlColorPicker
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The color picker's form label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
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
/// <summary>
/// Setter extensions of SlColorPicker
/// </summary>
public static partial class SlColorPickerControl
{
    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlColorPicker(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlColorPicker>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-color-picker", buildAttributes, children);
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlColorPicker(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-color-picker", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlColorPicker(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlColorPicker>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-color-picker", buildAttributes, children);
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlColorPicker(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-color-picker", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHex(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("format", "hex");
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatRgb(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("format", "rgb");
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHsl(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("format", "hsl");
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHsv(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("format", "hsv");
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static void SetInline(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool inline) 
    {
        if (inline) b.SetAttribute("inline", "");
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static void SetInline(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("inline", "");
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static void SetNoFormatToggle(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool noFormatToggle) 
    {
        if (noFormatToggle) b.SetAttribute("no-format-toggle", "");
    }

    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static void SetNoFormatToggle(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("no-format-toggle", "");
    }

    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool hoist) 
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static void SetOpacity(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool opacity) 
    {
        if (opacity) b.SetAttribute("opacity", "");
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static void SetOpacity(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("opacity", "");
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static void SetUppercase(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool uppercase) 
    {
        if (uppercase) b.SetAttribute("uppercase", "");
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static void SetUppercase(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("uppercase", "");
    }

    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, string swatches) 
    {
        b.SetAttribute("swatches", swatches);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlColorPicker> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlColorPicker> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlColorPicker(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlColorPicker>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-color-picker", buildProps, children);
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlColorPicker(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-color-picker", children);
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlColorPicker(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlColorPicker>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-color-picker", buildProps, children);
    }

    /// <summary>
    /// Color pickers allow the user to select a color.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlColorPicker(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-color-picker", children);
    }

    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current value of the color picker. The value's format will vary based the `format` attribute. To get the value in a specific format, use the `getFormattedValue()` method. The value is submitted as a name/value pair with form data.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string value) where T: SlColorPicker
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> defaultValue) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, string defaultValue) where T: SlColorPicker
    {
        b.SetDefaultValue(b.Const(defaultValue));
    }

    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The color picker's label. This will not be displayed, but it will be announced by assistive devices. If you need to display HTML, you can use the `label` slot` instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlColorPicker
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHex<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("hex"));
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatRgb<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("rgb"));
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHsl<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("hsl"));
    }

    /// <summary>
    /// The format to use. If opacity is enabled, these will translate to HEXA, RGBA, HSLA, and HSVA respectively. The color picker will accept user input in any format (including CSS color names) and convert it to the desired format.
    /// </summary>
    public static void SetFormatHsv<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("format"), b.Const("hsv"));
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static void SetInline<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetInline(b.Const(true));
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static void SetInline<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> inline) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("inline"), inline);
    }

    /// <summary>
    /// Renders the color picker inline rather than in a dropdown.
    /// </summary>
    public static void SetInline<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool inline) where T: SlColorPicker
    {
        b.SetInline(b.Const(inline));
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// Determines the size of the color picker's trigger. This has no effect on inline color pickers.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static void SetNoFormatToggle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetNoFormatToggle(b.Const(true));
    }

    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static void SetNoFormatToggle<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> noFormatToggle) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("noFormatToggle"), noFormatToggle);
    }

    /// <summary>
    /// Removes the button that lets users toggle between format.
    /// </summary>
    public static void SetNoFormatToggle<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool noFormatToggle) where T: SlColorPicker
    {
        b.SetNoFormatToggle(b.Const(noFormatToggle));
    }

    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the form control, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlColorPicker
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the color picker.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlColorPicker
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetHoist(b.Const(true));
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> hoist) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// Enable this option to prevent the panel from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool hoist) where T: SlColorPicker
    {
        b.SetHoist(b.Const(hoist));
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static void SetOpacity<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetOpacity(b.Const(true));
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static void SetOpacity<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> opacity) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("opacity"), opacity);
    }

    /// <summary>
    /// Shows the opacity slider. Enabling this will cause the formatted value to be HEXA, RGBA, or HSLA.
    /// </summary>
    public static void SetOpacity<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool opacity) where T: SlColorPicker
    {
        b.SetOpacity(b.Const(opacity));
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static void SetUppercase<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetUppercase(b.Const(true));
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static void SetUppercase<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> uppercase) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("uppercase"), uppercase);
    }

    /// <summary>
    /// By default, values are lowercase. With this attribute, values will be uppercase instead.
    /// </summary>
    public static void SetUppercase<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool uppercase) where T: SlColorPicker
    {
        b.SetUppercase(b.Const(uppercase));
    }

    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> swatches) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("swatches"), swatches);
    }

    /// <summary>
    /// One or more predefined color swatches to display as presets in the color picker. Can include any format the color picker can parse, including HEX(A), RGB(A), HSL(A), HSV(A), and CSS color names. Each color must be separated by a semicolon (`;`). Alternatively, you can pass an array of color values to this property using JavaScript.
    /// </summary>
    public static void SetSwatches<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<string>>> swatches) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("swatches"), swatches);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlColorPicker
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlColorPicker
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlColorPicker
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// Makes the color picker a required field.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlColorPicker
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the color picker loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the color picker's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the color picker receives focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the color picker receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlColorPicker
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlColorPicker
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}