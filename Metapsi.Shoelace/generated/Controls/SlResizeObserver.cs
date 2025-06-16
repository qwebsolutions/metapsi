using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
/// </summary>
public partial class SlResizeObserver
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlResizeObserver
/// </summary>
public static partial class SlResizeObserverControl
{
    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlResizeObserver(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlResizeObserver>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-resize-observer", buildAttributes, children);
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlResizeObserver(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-resize-observer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlResizeObserver(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlResizeObserver>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-resize-observer", buildAttributes, children);
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlResizeObserver(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-resize-observer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlResizeObserver> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlResizeObserver> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlResizeObserver(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlResizeObserver>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-resize-observer", buildProps, children);
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlResizeObserver(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-resize-observer", children);
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlResizeObserver(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlResizeObserver>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-resize-observer", buildProps, children);
    }

    /// <summary>
    /// The Resize Observer component offers a thin, declarative interface to the [`ResizeObserver API`](https://developer.mozilla.org/en-US/docs/Web/API/ResizeObserver).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlResizeObserver(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-resize-observer", children);
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlResizeObserver
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlResizeObserver
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the observer.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlResizeObserver
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlResizeObserver
    {
        b.OnSlEvent("onsl-resize", action);
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlResizeObserver
    {
        b.OnSlResize(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlResizeObserver
    {
        b.OnSlEvent("onsl-resize", action);
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlResizeObserver
    {
        b.OnSlResize(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the element is resized.
    /// </summary>
    public static void OnSlResize<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlResizeDetail>>> action) where T: SlResizeObserver
    {
        b.OnSlEvent("onsl-resize", action);
    }

}