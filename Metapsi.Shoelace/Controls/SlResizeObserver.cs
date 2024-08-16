using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlResizeObserver : SlComponent
{
    public SlResizeObserver() : base("sl-resize-observer") { }
}

public static partial class SlResizeObserverControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlResizeObserver(this HtmlBuilder b, Action<AttributesBuilder<SlResizeObserver>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-resize-observer", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlResizeObserver(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-resize-observer", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlResizeObserver> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlResizeObserver> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlResizeObserver(this LayoutBuilder b, Action<PropsBuilder<SlResizeObserver>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-resize-observer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlResizeObserver(this LayoutBuilder b, Action<PropsBuilder<SlResizeObserver>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-resize-observer", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlResizeObserver(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-resize-observer", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlResizeObserver(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-resize-observer", children);
    }
    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlResizeObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlResizeObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the observer. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlResizeObserver
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the element is resized. </para>
    /// </summary>
    public static void OnSlResize<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlResizeObserver
    {
        b.OnEventAction("onsl-resize", action);
    }
    /// <summary>
    /// <para> Emitted when the element is resized. </para>
    /// </summary>
    public static void OnSlResize<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlResizeObserver
    {
        b.OnEventAction("onsl-resize", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the element is resized. </para>
    /// </summary>
    public static void OnSlResize<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlResizeObserver
    {
        b.OnEventAction("onsl-resize", action);
    }
    /// <summary>
    /// <para> Emitted when the element is resized. </para>
    /// </summary>
    public static void OnSlResize<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlResizeObserver
    {
        b.OnEventAction("onsl-resize", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the element is resized. </para>
    /// </summary>
    public static void OnSlResize<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlResizeEventArgs>> action) where TComponent: SlResizeObserver
    {
        b.OnEventAction("onsl-resize", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when the element is resized. </para>
    /// </summary>
    public static void OnSlResize<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlResizeEventArgs>, Var<TModel>> action) where TComponent: SlResizeObserver
    {
        b.OnEventAction("onsl-resize", b.MakeAction(action), "detail");
    }

}

