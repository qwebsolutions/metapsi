using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Compare visual differences between similar photos with a sliding panel.
/// </summary>
public partial class SlImageComparer
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The before image, an `&lt;img&gt;` or `&lt;svg&gt;` element.
        /// </summary>
        public const string Before = "before";
        /// <summary>
        /// The after image, an `&lt;img&gt;` or `&lt;svg&gt;` element.
        /// </summary>
        public const string After = "after";
        /// <summary>
        /// The icon used inside the handle.
        /// </summary>
        public const string Handle = "handle";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlImageComparer
/// </summary>
public static partial class SlImageComparerControl
{
    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlImageComparer(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlImageComparer>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-image-comparer", buildAttributes, children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlImageComparer(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-image-comparer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlImageComparer(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlImageComparer>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-image-comparer", buildAttributes, children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlImageComparer(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-image-comparer", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlImageComparer(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlImageComparer>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-image-comparer", buildProps, children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlImageComparer(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-image-comparer", children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlImageComparer(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlImageComparer>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-image-comparer", buildProps, children);
    }

    /// <summary>
    /// Compare visual differences between similar photos with a sliding panel.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlImageComparer(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-image-comparer", children);
    }

    /// <summary>
    /// The position of the divider as a percentage.
    /// </summary>
    public static void SetPosition<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> position) where T: SlImageComparer
    {
        b.SetProperty(b.Props, b.Const("position"), position);
    }

    /// <summary>
    /// The position of the divider as a percentage.
    /// </summary>
    public static void SetPosition<T>(this Metapsi.Syntax.PropsBuilder<T> b, int position) where T: SlImageComparer
    {
        b.SetPosition(b.Const(position));
    }

    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlImageComparer
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlImageComparer
    {
        b.OnSlChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlImageComparer
    {
        b.OnSlEvent("onsl-change", action);
    }

    /// <summary>
    /// Emitted when the position changes.
    /// </summary>
    public static void OnSlChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlImageComparer
    {
        b.OnSlChange(b.MakeAction(action));
    }

}