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
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> A presentational prefix icon or similar element. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> A presentational suffix icon or similar element. </para>
        /// </summary>
        public const string Suffix = "suffix";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus on the radio button. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the radio button. </para>
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlRadioButtonControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadioButton(this HtmlBuilder b, Action<AttributesBuilder<SlRadioButton>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-radio-button", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadioButton(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-radio-button", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The radio's value. When selected, the radio group will receive this value. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlRadioButton> b,string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> Disables the radio button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRadioButton> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the radio button. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRadioButton> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlRadioButton> b,string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlRadioButton> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlRadioButton> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlRadioButton> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Draws a pill-style radio button with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlRadioButton> b)
    {
        b.SetAttribute("pill", "");
    }

    /// <summary>
    /// <para> Draws a pill-style radio button with rounded edges. </para>
    /// </summary>
    public static void SetPill(this AttributesBuilder<SlRadioButton> b,bool pill)
    {
        if (pill) b.SetAttribute("pill", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioButton(this LayoutBuilder b, Action<PropsBuilder<SlRadioButton>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-radio-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioButton(this LayoutBuilder b, Action<PropsBuilder<SlRadioButton>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-radio-button", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioButton(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-radio-button", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadioButton(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-radio-button", children);
    }
    /// <summary>
    /// <para> The radio's value. When selected, the radio group will receive this value. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The radio's value. When selected, the radio group will receive this value. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> Disables the radio button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the radio button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the radio button. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The radio button's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Draws a pill-style radio button with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws a pill-style radio button with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, Var<bool> pill) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), pill);
    }

    /// <summary>
    /// <para> Draws a pill-style radio button with rounded edges. </para>
    /// </summary>
    public static void SetPill<T>(this PropsBuilder<T> b, bool pill) where T: SlRadioButton
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("pill"), b.Const(pill));
    }


    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the button loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the button gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadioButton
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

}

