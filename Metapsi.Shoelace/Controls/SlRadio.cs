using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlRadio
{
    public string value { get; set; }
}
public partial class SlRadioBlurArgs
{
    public IClientSideSlRadio target { get; set; }
}
public partial class SlRadioFocusArgs
{
    public IClientSideSlRadio target { get; set; }
}
public static partial class SlRadioControl
{
    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Var<IVNode> SlRadio(this LayoutBuilder b, Action<PropsBuilder<SlRadio>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-radio", buildProps, children);
    }
    /// <summary>
    /// Radios allow the user to select a single option from a group.
    /// </summary>
    public static Var<IVNode> SlRadio(this LayoutBuilder b, Action<PropsBuilder<SlRadio>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-radio", buildProps, children);
    }
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRadio> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static void SetValue(this PropsBuilder<SlRadio> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }
    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeSmall(this PropsBuilder<SlRadio> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("small"));
    }
    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeMedium(this PropsBuilder<SlRadio> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("medium"));
    }
    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static void SetSizeLarge(this PropsBuilder<SlRadio> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("size"), b.Const("large"));
    }
    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlRadio> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadio> b, Var<HyperType.Action<TModel, SlRadioBlurArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioBlurArgs>>("onsl-blur"), action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadio> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioBlurArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioBlurArgs>>("onsl-blur"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadio> b, Var<HyperType.Action<TModel, SlRadioFocusArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioFocusArgs>>("onsl-focus"), action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadio> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlRadioFocusArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlRadioFocusArgs>>("onsl-focus"), b.MakeAction(action));
    }
}

/// <summary>
/// Radios allow the user to select a single option from a group.
/// </summary>
public partial class SlRadio : HtmlTag
{
    public SlRadio()
    {
        this.Tag = "sl-radio";
    }

    public static SlRadio New()
    {
        return new SlRadio();
    }
}

public static partial class SlRadioControl
{
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
    /// </summary>
    public static SlRadio SetValue(this SlRadio tag, string value)
    {
        return tag.SetAttribute("value", value.ToString());
    }
    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static SlRadio SetSizeSmall(this SlRadio tag)
    {
        return tag.SetAttribute("size", "small");
    }
    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static SlRadio SetSizeMedium(this SlRadio tag)
    {
        return tag.SetAttribute("size", "medium");
    }
    /// <summary>
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
    /// </summary>
    public static SlRadio SetSizeLarge(this SlRadio tag)
    {
        return tag.SetAttribute("size", "large");
    }
    /// <summary>
    /// Disables the radio.
    /// </summary>
    public static SlRadio SetDisabled(this SlRadio tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
}

