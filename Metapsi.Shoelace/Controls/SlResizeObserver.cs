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
    /// <summary>
    /// Disables the observer.
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

public static partial class SlResizeObserverControl
{
    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Var<IVNode> SlResizeObserver(this LayoutBuilder b, Action<PropsBuilder<SlResizeObserver>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-resize-observer", buildProps, children);
    }
    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Var<IVNode> SlResizeObserver(this LayoutBuilder b, Action<PropsBuilder<SlResizeObserver>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-resize-observer", buildProps, children);
    }
    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlResizeObserver> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("disabled"), b.Const(string.Empty));
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-resize", action);
    }
    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-resize", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-resize", action);
    }
    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-resize", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, Var<HyperType.Action<TModel, SlResizeEventArgs>> action)
    {
        b.OnEventAction("onsl-resize", action, "detail");
    }
    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlResizeEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-resize", b.MakeAction(action), "detail");
    }

}

