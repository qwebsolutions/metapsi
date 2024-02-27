using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlSelect
{
    public string value { get; set; }
}
public partial class SlSelectChangeArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectClearArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectInputArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectFocusArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectBlurArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectShowArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectAfterShowArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectHideArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectAfterHideArgs
{
    public IClientSideSlSelect target { get; set; }
}
public partial class SlSelectInvalidArgs
{
    public IClientSideSlSelect target { get; set; }
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
        b.SetDynamic(b.Props, DynamicProperty.String("value"), value);
    }
    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static void SetValues(this PropsBuilder<SlSelect> b, Var<List<string>> values)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("value"), values);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValue(this PropsBuilder<SlSelect> b, Var<string> value)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("defaultValue"), value);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static void SetDefaultValues(this PropsBuilder<SlSelect> b, Var<List<string>> values)
    {
        b.SetDynamic(b.Props, new DynamicProperty<List<string>>("defaultValue"), values);
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
        b.SetDynamic(b.Props, DynamicProperty.Bool("multiple"), b.Const(true));
    }
    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public static void SetMaxOptionsVisible(this PropsBuilder<SlSelect> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxOptionsVisible"), value);
    }
    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public static void SetMaxOptionsVisible(this PropsBuilder<SlSelect> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxOptionsVisible"), b.Const(value));
    }
    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static void SetClearable(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("clearable"), b.Const(true));
    }
    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static void SetOpen(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("open"), b.Const(true));
    }
    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static void SetHoist(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("hoist"), b.Const(true));
    }
    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static void SetFilled(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("filled"), b.Const(true));
    }
    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlSelect> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pill"), b.Const(true));
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
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlSelect> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
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
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the control's value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectClearArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectClearArgs>>("onsl-clear"), action);
    }
    /// <summary>
    /// Emitted when the control's value is cleared.
    /// </summary>
    public static void OnSlClear<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectClearArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectClearArgs>>("onsl-clear"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the control receives input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectShowArgs>>("onsl-show"), action);
    }
    /// <summary>
    /// Emitted when the select's menu opens.
    /// </summary>
    public static void OnSlShow<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectShowArgs>>("onsl-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectAfterShowArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectAfterShowArgs>>("onsl-after-show"), action);
    }
    /// <summary>
    /// Emitted after the select's menu opens and all animations are complete.
    /// </summary>
    public static void OnSlAfterShow<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectAfterShowArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectAfterShowArgs>>("onsl-after-show"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectHideArgs>>("onsl-hide"), action);
    }
    /// <summary>
    /// Emitted when the select's menu closes.
    /// </summary>
    public static void OnSlHide<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectHideArgs>>("onsl-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectAfterHideArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectAfterHideArgs>>("onsl-after-hide"), action);
    }
    /// <summary>
    /// Emitted after the select's menu closes and all animations are complete.
    /// </summary>
    public static void OnSlAfterHide<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectAfterHideArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectAfterHideArgs>>("onsl-after-hide"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSelect> b, Var<HyperType.Action<TModel, SlSelectInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlSelect> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlSelectInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Selects allow you to choose items from a menu of predefined options.
/// </summary>
public partial class SlSelect : HtmlTag
{
    public SlSelect()
    {
        this.Tag = "sl-select";
    }

    public static SlSelect New()
    {
        return new SlSelect();
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
}

public static partial class SlSelectControl
{
    /// <summary>
    /// The name of the select, submitted as a name/value pair with form data.
    /// </summary>
    public static SlSelect SetName(this SlSelect tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the select, submitted as a name/value pair with form data. When `multiple` is enabled, the value attribute will be a space-delimited list of values based on the options selected, and the value property will be an array. **For this reason, values must not contain spaces.**
    /// </summary>
    public static SlSelect SetValue(this SlSelect tag, string value)
    {
        return tag.SetAttribute("value", value);
    }
    /// <summary>
    /// The default value of the form control. Primarily used for resetting the form control.
    /// </summary>
    public static SlSelect SetDefaultValue(this SlSelect tag, string value)
    {
        return tag.SetAttribute("defaultValue", value);
    }
    /// <summary>
    /// The select's size.
    /// </summary>
    public static SlSelect SetSizeSmall(this SlSelect tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The select's size.
    /// </summary>
    public static SlSelect SetSizeMedium(this SlSelect tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The select's size.
    /// </summary>
    public static SlSelect SetSizeLarge(this SlSelect tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Placeholder text to show as a hint when the select is empty.
    /// </summary>
    public static SlSelect SetPlaceholder(this SlSelect tag, string value)
    {
        return tag.SetAttribute("placeholder", value.ToString());
    }
    /// <summary>
    /// Allows more than one option to be selected.
    /// </summary>
    public static SlSelect SetMultiple(this SlSelect tag)
    {
        return tag.SetAttribute("multiple", "true");
    }
    /// <summary>
    /// The maximum number of selected options to show when `multiple` is true. After the maximum, "+n" will be shown to indicate the number of additional items that are selected. Set to 0 to remove the limit.
    /// </summary>
    public static SlSelect SetMaxOptionsVisible(this SlSelect tag, int value)
    {
        return tag.SetAttribute("maxOptionsVisible", value.ToString());
    }
    /// <summary>
    /// Disables the select control.
    /// </summary>
    public static SlSelect SetDisabled(this SlSelect tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Adds a clear button when the select is not empty.
    /// </summary>
    public static SlSelect SetClearable(this SlSelect tag)
    {
        return tag.SetAttribute("clearable", "true");
    }
    /// <summary>
    /// Indicates whether or not the select is open. You can toggle this attribute to show and hide the menu, or you can use the `show()` and `hide()` methods and this attribute will reflect the select's open state.
    /// </summary>
    public static SlSelect SetOpen(this SlSelect tag)
    {
        return tag.SetAttribute("open", "true");
    }
    /// <summary>
    /// Enable this option to prevent the listbox from being clipped when the component is placed inside a container with `overflow: auto|scroll`. Hoisting uses a fixed positioning strategy that works in many, but not all, scenarios.
    /// </summary>
    public static SlSelect SetHoist(this SlSelect tag)
    {
        return tag.SetAttribute("hoist", "true");
    }
    /// <summary>
    /// Draws a filled select.
    /// </summary>
    public static SlSelect SetFilled(this SlSelect tag)
    {
        return tag.SetAttribute("filled", "true");
    }
    /// <summary>
    /// Draws a pill-style select with rounded edges.
    /// </summary>
    public static SlSelect SetPill(this SlSelect tag)
    {
        return tag.SetAttribute("pill", "true");
    }
    /// <summary>
    /// The select's label. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static SlSelect SetLabel(this SlSelect tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static SlSelect SetPlacementTop(this SlSelect tag)
    {
        return tag.SetAttribute("placement", "top");
    }
    /// <summary>
    /// The preferred placement of the select's menu. Note that the actual placement may vary as needed to keep the listbox inside of the viewport.
    /// </summary>
    public static SlSelect SetPlacementBottom(this SlSelect tag)
    {
        return tag.SetAttribute("placement", "bottom");
    }
    /// <summary>
    /// The select's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static SlSelect SetHelpText(this SlSelect tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlSelect SetForm(this SlSelect tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// The select's required attribute.
    /// </summary>
    public static SlSelect SetRequired(this SlSelect tag)
    {
        return tag.SetAttribute("required", "true");
    }
}

