using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlResizeObserver
{
}
public partial class SlResizeObserverResizeArgs
{
    public IClientSideSlResizeObserver target { get; set; }
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
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the element is resized.
    /// event detail: { entries: ResizeObserverEntry[] }
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, Var<HyperType.Action<TModel, SlResizeObserverResizeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlResizeObserverResizeArgs>>("onsl-resize"), action);
    }
    /// <summary>
    /// Emitted when the element is resized.
    /// event detail: { entries: ResizeObserverEntry[] }
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlResizeObserverResizeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlResizeObserverResizeArgs>>("onsl-resize"), b.MakeAction(action));
    }
}

/// <summary>
/// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
/// </summary>
public partial class SlResizeObserver : HtmlTag
{
    public SlResizeObserver()
    {
        this.Tag = "sl-resize-observer";
    }

    public static SlResizeObserver New()
    {
        return new SlResizeObserver();
    }
}

public static partial class SlResizeObserverControl
{
    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static SlResizeObserver SetDisabled(this SlResizeObserver tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
}

