using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlRadioButton
{
    public string value { get; set; }
}
public partial class SlRadioButtonBlurArgs
{
    public IClientSideSlRadioButton target { get; set; }
}
public partial class SlRadioButtonFocusArgs
{
    public IClientSideSlRadioButton target { get; set; }
}
public static partial class SlRadioButtonControl
{
    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Var<IVNode> SlRadioButton(this LayoutBuilder b, Action<PropsBuilder<SlRadioButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-radio-button", buildProps, children);
    }
    /// <summary>
    /// Radios buttons allow the user to select a single option from a group using a button-like control.
    /// </summary>
    public static Var<IVNode> SlRadioButton(this LayoutBuilder b, Action<PropsBuilder<SlRadioButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-radio-button", buildProps, children);
    }
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRadioButton> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRadioButton> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlRadioButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlRadioButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlRadioButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlRadioButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static void SetPill(this PropsBuilder<SlRadioButton> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("pill"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadioButton> b, Var<HyperType.Action<TModel, SlRadioButtonBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioButtonBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadioButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioButtonBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioButtonBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadioButton> b, Var<HyperType.Action<TModel, SlRadioButtonFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioButtonFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadioButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioButtonFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioButtonFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
}

/// <summary>
/// Radios buttons allow the user to select a single option from a group using a button-like control.
/// </summary>
public partial class SlRadioButton : HtmlTag
{
    public SlRadioButton()
    {
        this.Tag = "sl-radio-button";
    }

    public static SlRadioButton New()
    {
        return new SlRadioButton();
    }
    public static class Slot
    {
        /// <summary> 
        /// A presentational prefix icon or similar element.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary> 
        /// A presentational suffix icon or similar element.
        /// </summary>
        public const string Suffix = "suffix";
    }
}

public static partial class SlRadioButtonControl
{
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static SlRadioButton SetValue(this SlRadioButton tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// Disables the radio button.
    /// </summary>
    public static SlRadioButton SetDisabled(this SlRadioButton tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static SlRadioButton SetSizeSmall(this SlRadioButton tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static SlRadioButton SetSizeMedium(this SlRadioButton tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static SlRadioButton SetSizeLarge(this SlRadioButton tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Draws a pill-style radio button with rounded edges.
    /// </summary>
    public static SlRadioButton SetPill(this SlRadioButton tag)
    {
        return tag.SetAttribute("pill", "true");
    }
}

