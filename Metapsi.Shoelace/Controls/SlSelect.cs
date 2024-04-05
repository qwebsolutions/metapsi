using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlSelect : SlComponent
{
    public SlSelect() : base("sl-select") { }
    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
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
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
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
    /// The select's size.
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
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public string placeholder
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placeholder");
        }
        set
        {
            this.GetTag().SetAttribute("placeholder", value.ToString());
        }
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public bool multiple
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("multiple");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("multiple", value.ToString());
        }
    }

    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public int maxOptionsVisible
    {
        get
        {
            return this.GetTag().GetAttribute<int>("max-options-visible");
        }
        set
        {
            this.GetTag().SetAttribute("max-options-visible", value.ToString());
        }
    }

    /// <summary>
    /// Disables the select control.
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
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public bool clearable
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("clearable");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("clearable", value.ToString());
        }
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public bool open
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("open");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("open", value.ToString());
        }
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
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
    /// Draws a filled select.
    /// </summary>
    public bool filled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("filled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("filled", value.ToString());
        }
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public bool pill
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("pill");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("pill", value.ToString());
        }
    }

    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
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
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public string placement
    {
        get
        {
            return this.GetTag().GetAttribute<string>("placement");
        }
        set
        {
            this.GetTag().SetAttribute("placement", value.ToString());
        }
    }

    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
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
    /// The select's required attribute.
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
    /// A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value.
    /// </summary>
    public System.Func<SlOption,int,object> getTag
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<SlOption,int,object>>("getTag");
        }
        set
        {
            this.GetTag().SetAttribute("getTag", value.ToString());
        }
    }

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

public static partial class SlSelectControl
{
    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Var<IVNode> SlSelect(this LayoutBuilder b, Action<PropsBuilder<SlSelect>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-select", buildProps, children);
    }
    /// <summary>
    /// Selects allow you to choose items from a menu of predefined options.
    /// </summary>
    public static Var<IVNode> SlSelect(this LayoutBuilder b, Action<PropsBuilder<SlSelect>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-select", buildProps, children);
    }
    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), value);
    }
    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
    /// </summary>
    public static void SetName(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(value));
    }

    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static void SetValue(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static void SetValue(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static void SetValue(this PropsBuilder<SlSelect> b, Var<List<string>> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), value);
    }
    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static void SetValue(this PropsBuilder<SlSelect> b, List<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), b.Const(value));
    }

    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The select's size.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }

    /// <summary>
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), value);
    }
    /// <summary>
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public static void SetPlaceholder(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("placeholder"), b.Const(value));
    }

    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static void SetMultiple(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("multiple"), b.Const(string.Empty));
    }

    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public static void SetMaxOptionsVisible(this PropsBuilder<SlSelect> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max-options-visible"), value);
    }
    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public static void SetMaxOptionsVisible(this PropsBuilder<SlSelect> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("max-options-visible"), b.Const(value));
    }

    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("clearable"), b.Const(string.Empty));
    }

    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("open"), b.Const(string.Empty));
    }

    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("hoist"), b.Const(string.Empty));
    }

    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("filled"), b.Const(string.Empty));
    }

    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("pill"), b.Const(string.Empty));
    }

    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }

    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static void SetPlacementTop(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("top"));
    }
    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static void SetPlacementBottom(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("placement"), b.Const("bottom"));
    }

    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), value);
    }
    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("help-text"), b.Const(value));
    }

    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), value);
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static void SetForm(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("form"), b.Const(value));
    }

    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static void SetRequired(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("required"), b.Const(string.Empty));
    }

    /// <summary>
    /// A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value.
    /// </summary>
    public static void SetGetTag(this PropsBuilder<SlSelect> b, Var<Func<SlOption,int,object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<SlOption,int,object>>("getTag"), f);
    }
    /// <summary>
    /// A function that customizes the tags to be rendered when multiple=true. The first argument is the option, the second is the current tag's index.  The function should return either a Lit TemplateResult or a string containing trusted HTML of the symbol to render at the specified value.
    /// </summary>
    public static void SetGetTag(this PropsBuilder<SlSelect> b, Func<SyntaxBuilder,Var<SlOption>,Var<int>,Var<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<SlOption,int,object>>("getTag"), b.Def(f));
    }

    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-change", action);
    }
    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-clear", action);
    }
    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-clear", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-clear", action);
    }
    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-clear", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-input", action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-input", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-show", action);
    }
    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", action);
    }
    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-show", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-hide", action);
    }
    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", action);
    }
    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-after-hide", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-invalid", b.MakeAction(action));
    }

}

