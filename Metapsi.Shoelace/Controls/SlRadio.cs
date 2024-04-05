using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRadio : SlComponent
{
    public SlRadio() : base("sl-radio") { }
    /// <summary>
    /// The radio's value. When selected, the radio group will receive this value.
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
    /// The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
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
    /// Disables the radio.
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
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadio> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadio> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadio> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the control loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadio> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadio> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadio> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadio> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the control gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadio> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

}

