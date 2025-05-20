using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlSelect
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The input's label. Alternatively, you can use the `label` attribute. </para>
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// <para> Used to prepend a presentational icon or similar element to the combobox. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> Used to append a presentational icon or similar element to the combobox. </para>
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// <para> An icon to use in lieu of the default clear icon. </para>
        /// </summary>
        public const string ClearIcon = "clear-icon";
        /// <summary>
        /// <para> The icon to show when the control is expanded and collapsed. Rotates on open and close. </para>
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// <para> Text that describes how to use the input. Alternatively, you can use the `help-text` attribute. </para>
        /// </summary>
        public const string HelpText = "help-text";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Shows the listbox. </para>
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// <para> Hides the listbox. </para>
        /// </summary>
        public const string Hide = "hide";
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
        /// <summary>
        /// <para> Sets focus on the control. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the control. </para>
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlSelectControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSelect(this HtmlBuilder b, Action<AttributesBuilder<SlSelect>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-select", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSelect(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-select", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSelect(this HtmlBuilder b, Action<AttributesBuilder<SlSelect>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-select", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlSelect(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-select", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the select, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlSelect> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlSelect> b, string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlSelect> b, string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Placeholder text to show as a hint when the select is empty. </para>
    /// </summary>
    public static void SetPlaceholder(this AttributesBuilder<SlSelect> b, string placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// <para> Allows more than one option to be selected. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> Allows more than one option to be selected. </para>
    /// </summary>
    public static void SetMultiple(this AttributesBuilder<SlSelect> b, bool multiple)
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// <para> The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit. </para>
    /// </summary>
    public static void SetMaxOptionsVisible(this AttributesBuilder<SlSelect> b, string maxOptionsVisible)
    {
        b.SetAttribute("max-options-visible", maxOptionsVisible);
    }

    /// <summary>
    /// <para> Disables the select control. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the select control. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlSelect> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Adds a clear button when the select is not empty. </para>
    /// </summary>
    public static void SetClearable(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// <para> Adds a clear button when the select is not empty. </para>
    /// </summary>
    public static void SetClearable(this AttributesBuilder<SlSelect> b, bool clearable)
    {
        if (clearable) b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state. </para>
    /// </summary>
    public static void SetOpen(this AttributesBuilder<SlSelect> b, bool open)
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist(this AttributesBuilder<SlSelect> b, bool hoist)
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// <para> Draws a filled select. </para>
    /// </summary>
    public static void SetFilled(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("filled", "");
    }

    /// <summary>
    /// <para> Draws a filled select. </para>
    /// </summary>
    public static void SetFilled(this AttributesBuilder<SlSelect> b, bool filled)
    {
        if (filled) b.SetAttribute("filled", "");
    }

    /// <summary>
    /// <para> Draws a pill-style select with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a pill-style select with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlSelect> b, bool pill)
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> The select's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlSelect> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// <para> The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport. </para>
    /// </summary>
    public static void SetPlacement(this AttributesBuilder<SlSelect> b, string placement)
    {
        b.SetAttribute("placement", placement);
    }

    /// <summary>
    /// <para> The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTop(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// <para> The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottom(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// <para> The select's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText(this AttributesBuilder<SlSelect> b, string helpText)
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm(this AttributesBuilder<SlSelect> b, string form)
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// <para> The select's required attribute. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlSelect> b)
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> The select's required attribute. </para>
    /// </summary>
    public static void SetRequired(this AttributesBuilder<SlSelect> b, bool required)
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// <para> A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value. </para>
    /// </summary>
    public static void SetGetTag(this AttributesBuilder<SlSelect> b, string getTag)
    {
        b.SetAttribute("getTag", getTag);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSelect(this LayoutBuilder b, Action<PropsBuilder<SlSelect>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-select", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSelect(this LayoutBuilder b, Action<PropsBuilder<SlSelect>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-select", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSelect(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-select", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlSelect(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-select", children);
    }
    /// <summary>
    /// <para> The name of the select, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// <para> The name of the select, submitted as a name/value pair with form data. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("name"), b.Const(name));
    }


    /// <summary>
    /// <para> The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.** </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.** </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.** </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<List<string>> value) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// <para> The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.** </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, List<string> value) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, Var<string> defaultValue) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, string defaultValue) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), b.Const(defaultValue));
    }


    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, Var<List<string>> defaultValue) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// <para> The default value of the form control. Primarily used for resetting the form control. </para>
    /// </summary>
    public static void SetDefaultValue<T>(this PropsBuilder<T> b, List<string> defaultValue) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), b.Const(defaultValue));
    }


    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The select's size. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Placeholder text to show as a hint when the select is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, Var<string> placeholder) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// <para> Placeholder text to show as a hint when the select is empty. </para>
    /// </summary>
    public static void SetPlaceholder<T>(this PropsBuilder<T> b, string placeholder) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placeholder"), b.Const(placeholder));
    }


    /// <summary>
    /// <para> Allows more than one option to be selected. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("multiple"), b.Const(true));
    }


    /// <summary>
    /// <para> Allows more than one option to be selected. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, Var<bool> multiple) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    /// <para> Allows more than one option to be selected. </para>
    /// </summary>
    public static void SetMultiple<T>(this PropsBuilder<T> b, bool multiple) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("multiple"), b.Const(multiple));
    }


    /// <summary>
    /// <para> The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit. </para>
    /// </summary>
    public static void SetMaxOptionsVisible<T>(this PropsBuilder<T> b, Var<int> maxOptionsVisible) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("maxOptionsVisible"), maxOptionsVisible);
    }

    /// <summary>
    /// <para> The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit. </para>
    /// </summary>
    public static void SetMaxOptionsVisible<T>(this PropsBuilder<T> b, int maxOptionsVisible) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("maxOptionsVisible"), b.Const(maxOptionsVisible));
    }


    /// <summary>
    /// <para> Disables the select control. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the select control. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the select control. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Adds a clear button when the select is not empty. </para>
    /// </summary>
    public static void SetClearable<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("clearable"), b.Const(true));
    }


    /// <summary>
    /// <para> Adds a clear button when the select is not empty. </para>
    /// </summary>
    public static void SetClearable<T>(this PropsBuilder<T> b, Var<bool> clearable) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("clearable"), clearable);
    }

    /// <summary>
    /// <para> Adds a clear button when the select is not empty. </para>
    /// </summary>
    public static void SetClearable<T>(this PropsBuilder<T> b, bool clearable) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("clearable"), b.Const(clearable));
    }


    /// <summary>
    /// <para> Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("open"), b.Const(true));
    }


    /// <summary>
    /// <para> Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, Var<bool> open) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// <para> Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state. </para>
    /// </summary>
    public static void SetOpen<T>(this PropsBuilder<T> b, bool open) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("open"), b.Const(open));
    }


    /// <summary>
    /// <para> Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("hoist"), b.Const(true));
    }


    /// <summary>
    /// <para> Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, Var<bool> hoist) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// <para> Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios. </para>
    /// </summary>
    public static void SetHoist<T>(this PropsBuilder<T> b, bool hoist) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("hoist"), b.Const(hoist));
    }


    /// <summary>
    /// <para> Draws a filled select. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("filled"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a filled select. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b, Var<bool> filled) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("filled"), filled);
    }

    /// <summary>
    /// <para> Draws a filled select. </para>
    /// </summary>
    public static void SetFilled<T>(this PropsBuilder<T> b, bool filled) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("filled"), b.Const(filled));
    }


    /// <summary>
    /// <para> Draws a pill-style select with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("pill"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a pill-style select with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, Var<bool> pill) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// <para> Draws a pill-style select with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, bool pill) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("pill"), b.Const(pill));
    }


    /// <summary>
    /// <para> The select's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// <para> The select's label. If you need to display HTML, use the `label` slot instead. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("label"), b.Const(label));
    }


    /// <summary>
    /// <para> The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementTop<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }


    /// <summary>
    /// <para> The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport. </para>
    /// </summary>
    public static void SetPlacementBottom<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }


    /// <summary>
    /// <para> The select's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, Var<string> helpText) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// <para> The select's help text. If you need to display HTML, use the `help-text` slot instead. </para>
    /// </summary>
    public static void SetHelpText<T>(this PropsBuilder<T> b, string helpText) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("helpText"), b.Const(helpText));
    }


    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, Var<string> form) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// <para> By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work. </para>
    /// </summary>
    public static void SetForm<T>(this PropsBuilder<T> b, string form) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("form"), b.Const(form));
    }


    /// <summary>
    /// <para> The select's required attribute. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("required"), b.Const(true));
    }


    /// <summary>
    /// <para> The select's required attribute. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, Var<bool> required) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// <para> The select's required attribute. </para>
    /// </summary>
    public static void SetRequired<T>(this PropsBuilder<T> b, bool required) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("required"), b.Const(required));
    }


    /// <summary>
    /// <para> A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value. </para>
    /// </summary>
    public static void SetGetTag<T>(this PropsBuilder<T> b, Var<System.Func<SlOption,int,object>> getTag) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("getTag"), getTag);
    }

    /// <summary>
    /// <para> A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value. </para>
    /// </summary>
    public static void SetGetTag<T>(this PropsBuilder<T> b, System.Func<SlOption,int,object> getTag) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("getTag"), b.Const(getTag));
    }


    /// <summary>
    /// <para> Emitted when the control's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the control's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// <para> Emitted when the control's value changes. </para>
    /// </summary>
    public static void OnSlChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control's value is cleared. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-clear", action);
    }
    /// <summary>
    /// <para> Emitted when the control's value is cleared. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-clear", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control's value is cleared. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-clear", action);
    }
    /// <summary>
    /// <para> Emitted when the control's value is cleared. </para>
    /// </summary>
    public static void OnSlClear<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-clear", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// <para> Emitted when the control receives input. </para>
    /// </summary>
    public static void OnSlInput<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the select's menu opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the select's menu opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the select's menu opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// <para> Emitted when the select's menu opens. </para>
    /// </summary>
    public static void OnSlShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the select's menu opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the select's menu opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the select's menu opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// <para> Emitted after the select's menu opens and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterShow<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the select's menu closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the select's menu closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the select's menu closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// <para> Emitted when the select's menu closes. </para>
    /// </summary>
    public static void OnSlHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the select's menu closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the select's menu closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the select's menu closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// <para> Emitted after the select's menu closes and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterHide<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, Event>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<Event>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// <para> Emitted when the form control has been checked for validity and its constraints aren't satisfied. </para>
    /// </summary>
    public static void OnSlInvalid<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlSelect
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

