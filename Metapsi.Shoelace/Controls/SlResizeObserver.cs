using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlResizeObserver
{
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
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-resize"), eventAction);
    }
    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<TModel>(this PropsBuilder<SlResizeObserver> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-resize"), eventAction);
    }

}

