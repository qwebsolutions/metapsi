using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlRadioGroup
{
    public string value { get; set; }
}
public partial class SlRadioGroupChangeArgs
{
    public IClientSideSlRadioGroup target { get; set; }
}
public partial class SlRadioGroupInputArgs
{
    public IClientSideSlRadioGroup target { get; set; }
}
public partial class SlRadioGroupInvalidArgs
{
    public IClientSideSlRadioGroup target { get; set; }
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
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), value);
    }
    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static void SetHelpText(this PropsBuilder<SlRadioGroup> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("helpText"), b.Const(value));
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
        b.SetDynamic(b.Props, DynamicProperty.Bool("required"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel, SlRadioGroupChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioGroupChangeArgs>>("onsl-change"), action);
    }
    /// <summary>
    /// Emitted when the radio group's selected value changes.
    /// </summary>
    public static void OnSlChange<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioGroupChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioGroupChangeArgs>>("onsl-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel, SlRadioGroupInputArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioGroupInputArgs>>("onsl-input"), action);
    }
    /// <summary>
    /// Emitted when the radio group receives user input.
    /// </summary>
    public static void OnSlInput<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioGroupInputArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioGroupInputArgs>>("onsl-input"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRadioGroup> b, Var<HyperType.Action<TModel, SlRadioGroupInvalidArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioGroupInvalidArgs>>("onsl-invalid"), action);
    }
    /// <summary>
    /// Emitted when the form control has been checked for validity and its constraints aren't satisfied.
    /// </summary>
    public static void OnSlInvalid<TModel>(this PropsBuilder<SlRadioGroup> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioGroupInvalidArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioGroupInvalidArgs>>("onsl-invalid"), b.MakeAction(action));
    }
}

/// <summary>
/// Radio groups are used to group multiple [radios](/components/radio) or [radio buttons](/components/radio-button) so they function as a single form control.
/// </summary>
public partial class SlRadioGroup : HtmlTag
{
    public SlRadioGroup()
    {
        this.Tag = "sl-radio-group";
    }

    public static SlRadioGroup New()
    {
        return new SlRadioGroup();
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
}

public static partial class SlRadioGroupControl
{
    /// <summary>
    /// The radio group's label. Required for proper accessibility. If you need to display HTML, use the `label` slot instead.
    /// </summary>
    public static SlRadioGroup SetLabel(this SlRadioGroup tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
    /// <summary>
    /// The radio groups's help text. If you need to display HTML, use the `help-text` slot instead.
    /// </summary>
    public static SlRadioGroup SetHelpText(this SlRadioGroup tag, string value)
    {
        return tag.SetAttribute("helpText", value.ToString());
    }
    /// <summary>
    /// The name of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static SlRadioGroup SetName(this SlRadioGroup tag, string value)
    {
        return tag.SetAttribute("name", value.ToString());
    }
    /// <summary>
    /// The current value of the radio group, submitted as a name/value pair with form data.
    /// </summary>
    public static SlRadioGroup SetValue(this SlRadioGroup tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static SlRadioGroup SetSizeSmall(this SlRadioGroup tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static SlRadioGroup SetSizeMedium(this SlRadioGroup tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The radio group's size. This size will be applied to all child radios and radio buttons.
    /// </summary>
    public static SlRadioGroup SetSizeLarge(this SlRadioGroup tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// By default, form controls are associated with the nearest containing `<form>` element. This attribute allows you to place the form control outside of a form and associate it with the form that has this `id`. The form must be in the same document or shadow root for this to work.
    /// </summary>
    public static SlRadioGroup SetForm(this SlRadioGroup tag, string value)
    {
        return tag.SetAttribute("form", value.ToString());
    }
    /// <summary>
    /// Ensures a child radio is checked before allowing the containing form to submit.
    /// </summary>
    public static SlRadioGroup SetRequired(this SlRadioGroup tag)
    {
        return tag.SetAttribute("required", "true");
    }
}

