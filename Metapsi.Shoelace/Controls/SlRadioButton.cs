using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlRadioButton : SlComponent
{
    public SlRadioButton() : base("sl-radio-button") { }
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
    /// Disables the radio button.
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
    /// The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted.
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
    /// Draws a pill-style radio button with rounded edges.
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
    public static class Method
    {
        /// <summary> 
        /// Sets focus on the radio button.
        /// </summary>
        public const string Focus = "focus";
        /// <summary> 
        /// Removes focus from the radio button.
        /// </summary>
        public const string Blur = "blur";
    }
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
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
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
        b.SetDynamic(b.Props, DynamicProperty.String("pill"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadioButton> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadioButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadioButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// Emitted when the button loses focus.
    /// </summary>
    public static void OnSlBlur<TModel>(this PropsBuilder<SlRadioButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadioButton> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadioButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadioButton> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// Emitted when the button gains focus.
    /// </summary>
    public static void OnSlFocus<TModel>(this PropsBuilder<SlRadioButton> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

}

