using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Selects allow you to choose items from a menu of predefined options.
/// </summary>
public partial class SlSelect
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The input's label. Alternatively, you can use the `label` attribute.
        /// </summary>
        public const string Label = "label";
        /// <summary>
        /// Used to prepend a presentational icon or similar element to the combobox.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// Used to append a presentational icon or similar element to the combobox.
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// An icon to use in lieu of the default clear icon.
        /// </summary>
        public const string ClearIcon = "clear-icon";
        /// <summary>
        /// The icon to show when the control is expanded and collapsed. Rotates on open and close.
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// Text that describes how to use the input. Alternatively, you can use the `help-text` attribute.
        /// </summary>
        public const string HelpText = "help-text";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Shows the listbox.
        /// </summary>
        public const string Show = "show";
        /// <summary>
        /// Hides the listbox.
        /// </summary>
        public const string Hide = "hide";
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
        /// <summary>
        /// Sets focus on the control.
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// Removes focus from the control.
        /// </summary>
        public const string Blur = "blur";
    }
}
/// <summary>
/// Setter extensions of SlSelect
/// </summary>
public static partial class SlSelectControl
{
    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSelect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSelect>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-select", buildAttributes, children);
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSelect(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-select", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSelect(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSelect>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-select", buildAttributes, children);
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSelect(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-select", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlSelect> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetValue(this Metapsi.Html.AttributesBuilder<SlSelect> b, string value) 
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeSmall(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeMedium(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeLarge(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this Metapsi.Html.AttributesBuilder<SlSelect> b, string placeholder) 
    {
        b.SetAttribute("placeholder", placeholder);
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool multiple) 
    {
        if (multiple) b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static void SetMultiple(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("multiple", "");
    }

    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool clearable) 
    {
        if (clearable) b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("clearable", "");
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool open) 
    {
        if (open) b.SetAttribute("open", "");
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("open", "");
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool hoist) 
    {
        if (hoist) b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("hoist", "");
    }

    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool filled) 
    {
        if (filled) b.SetAttribute("filled", "");
    }

    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("filled", "");
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool pill) 
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlSelect> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static void SetPlacementTop(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("placement", "top");
    }

    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("placement", "bottom");
    }

    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this Metapsi.Html.AttributesBuilder<SlSelect> b, string helpText) 
    {
        b.SetAttribute("help-text", helpText);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this Metapsi.Html.AttributesBuilder<SlSelect> b, string form) 
    {
        b.SetAttribute("form", form);
    }

    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlSelect> b, bool required) 
    {
        if (required) b.SetAttribute("required", "");
    }

    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static void SetRequired(this Metapsi.Html.AttributesBuilder<SlSelect> b) 
    {
        b.SetAttribute("required", "");
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSelect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSelect>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-select", buildProps, children);
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSelect(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-select", children);
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSelect(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSelect>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-select", buildProps, children);
    }

    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSelect(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-select", children);
    }

    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlSelect
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> value) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> defaultValue) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<string>>> defaultValue) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("defaultValue"), defaultValue);
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeSmall<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeMedium<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeLarge<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }

    /// <summary>
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> placeholder) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placeholder"), placeholder);
    }

    /// <summary>
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public static void SetPlaceholder<T>(this Metapsi.Syntax.PropsBuilder<T> b, string placeholder) where T: SlSelect
    {
        b.SetPlaceholder(b.Const(placeholder));
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetMultiple(b.Const(true));
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> multiple) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("multiple"), multiple);
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static void SetMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool multiple) where T: SlSelect
    {
        b.SetMultiple(b.Const(multiple));
    }

    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public static void SetMaxOptionsVisible<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxOptionsVisible) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("maxOptionsVisible"), maxOptionsVisible);
    }

    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlSelect
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetClearable(b.Const(true));
    }

    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> clearable) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("clearable"), clearable);
    }

    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool clearable) where T: SlSelect
    {
        b.SetClearable(b.Const(clearable));
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetOpen(b.Const(true));
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> open) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("open"), open);
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool open) where T: SlSelect
    {
        b.SetOpen(b.Const(open));
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetHoist(b.Const(true));
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> hoist) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("hoist"), hoist);
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool hoist) where T: SlSelect
    {
        b.SetHoist(b.Const(hoist));
    }

    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetFilled(b.Const(true));
    }

    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> filled) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("filled"), filled);
    }

    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool filled) where T: SlSelect
    {
        b.SetFilled(b.Const(filled));
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetPill(b.Const(true));
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> pill) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("pill"), pill);
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool pill) where T: SlSelect
    {
        b.SetPill(b.Const(pill));
    }

    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlSelect
    {
        b.SetLabel(b.Const(label));
    }

    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static void SetPlacementTop<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("top"));
    }

    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("placement"), b.Const("bottom"));
    }

    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> helpText) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("helpText"), helpText);
    }

    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText<T>(this Metapsi.Syntax.PropsBuilder<T> b, string helpText) where T: SlSelect
    {
        b.SetHelpText(b.Const(helpText));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> form) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("form"), form);
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `&lt;form&gt;` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm<T>(this Metapsi.Syntax.PropsBuilder<T> b, string form) where T: SlSelect
    {
        b.SetForm(b.Const(form));
    }

    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlSelect
    {
        b.SetRequired(b.Const(true));
    }

    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> required) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("required"), required);
    }

    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static void SetRequired<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool required) where T: SlSelect
    {
        b.SetRequired(b.Const(required));
    }

    /// <summary>
    /// A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value.
    /// </summary>
    public static void SetGetTag<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Func<Metapsi.Shoelace.SlOption, int, string>>> getTag) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("getTag"), getTag);
    }

    /// <summary>
    /// A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value.
    /// </summary>
    public static void SetGetTag<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Func<Metapsi.Shoelace.SlOption, int, Metapsi.Html.HTMLElement>>> getTag) where T: SlSelect
    {
        b.SetProperty(b.Props, b.Const("getTag"), getTag);
    }

    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-clear", action);
    }

    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlClear(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-clear", action);
    }

    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlClear(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-input", action);
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlInput(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-focus", action);
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlFocus(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-blur", action);
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlBlur(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-show", action);
    }

    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-after-show", action);
    }

    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlAfterShow(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-hide", action);
    }

    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-after-hide", action);
    }

    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlAfterHide(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlSelect
    {
        b.OnSlEvent("onsl-invalid", action);
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlSelect
    {
        b.OnSlInvalid(b.MakeAction(action));
    }

}