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
}

public static partial class SlRadioControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadio(this HtmlBuilder b, Action<AttributesBuilder<SlRadio>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-radio", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlRadio(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-radio", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The radio's value. When selected, the radio group will receive this value. </para>
    /// </summary>
    public static void SetValue(this AttributesBuilder<SlRadio> b,string value)
    {
        b.SetAttribute("value", value);
    }

    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSize(this AttributesBuilder<SlRadio> b,string size)
    {
        b.SetAttribute("size", size);
    }

    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeSmall(this AttributesBuilder<SlRadio> b)
    {
        b.SetAttribute("size", "small");
    }

    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeMedium(this AttributesBuilder<SlRadio> b)
    {
        b.SetAttribute("size", "medium");
    }

    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeLarge(this AttributesBuilder<SlRadio> b)
    {
        b.SetAttribute("size", "large");
    }

    /// <summary>
    /// <para> Disables the radio. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRadio> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the radio. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlRadio> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadio(this LayoutBuilder b, Action<PropsBuilder<SlRadio>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-radio", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadio(this LayoutBuilder b, Action<PropsBuilder<SlRadio>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-radio", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadio(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-radio", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlRadio(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-radio", children);
    }
    /// <summary>
    /// <para> The radio's value. When selected, the radio group will receive this value. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, Var<string> value) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), value);
    }

    /// <summary>
    /// <para> The radio's value. When selected, the radio group will receive this value. </para>
    /// </summary>
    public static void SetValue<T>(this PropsBuilder<T> b, string value) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("value"), b.Const(value));
    }


    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeSmall<T>(this PropsBuilder<T> b) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("small"));
    }


    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeMedium<T>(this PropsBuilder<T> b) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("medium"));
    }


    /// <summary>
    /// <para> The radio's size. When used inside a radio group, the size will be determined by the radio group's size so this attribute can typically be omitted. </para>
    /// </summary>
    public static void SetSizeLarge<T>(this PropsBuilder<T> b) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("size"), b.Const("large"));
    }


    /// <summary>
    /// <para> Disables the radio. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the radio. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the radio. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlRadio
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-blur", action);
    }
    /// <summary>
    /// <para> Emitted when the control loses focus. </para>
    /// </summary>
    public static void OnSlBlur<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-blur", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-focus", action);
    }
    /// <summary>
    /// <para> Emitted when the control gains focus. </para>
    /// </summary>
    public static void OnSlFocus<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlRadio
    {
        b.OnEventAction("onsl-focus", b.MakeAction(action));
    }

}

