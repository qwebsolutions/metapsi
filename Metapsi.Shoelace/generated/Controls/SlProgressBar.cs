using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Progress bars are used to show the status of an ongoing operation.
/// </summary>
public partial class SlProgressBar
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
/// Setter extensions of SlProgressBar
/// </summary>
public static partial class SlProgressBarControl
{
    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressBar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlProgressBar>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-progress-bar", buildAttributes, children);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressBar(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-progress-bar", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressBar(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlProgressBar>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-progress-bar", buildAttributes, children);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressBar(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-progress-bar", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static void SetIndeterminate(this Metapsi.Html.AttributesBuilder<SlProgressBar> b, bool indeterminate) 
    {
        if (indeterminate) b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static void SetIndeterminate(this Metapsi.Html.AttributesBuilder<SlProgressBar> b) 
    {
        b.SetAttribute("indeterminate", "");
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlProgressBar> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlProgressBar>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-progress-bar", buildProps, children);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-progress-bar", children);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlProgressBar>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-progress-bar", buildProps, children);
    }

    /// <summary>
    /// Progress bars are used to show the status of an ongoing operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressBar(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-progress-bar", children);
    }

    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> value) where T: SlProgressBar
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal value) where T: SlProgressBar
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlProgressBar
    {
        b.SetIndeterminate(b.Const(true));
    }

    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> indeterminate) where T: SlProgressBar
    {
        b.SetProperty(b.Props, b.Const("indeterminate"), indeterminate);
    }

    /// <summary>
    /// When true, percentage is ignored, the label is hidden, and the progress bar is drawn in an indeterminate state.
    /// </summary>
    public static void SetIndeterminate<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool indeterminate) where T: SlProgressBar
    {
        b.SetIndeterminate(b.Const(indeterminate));
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlProgressBar
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlProgressBar
    {
        b.SetLabel(b.Const(label));
    }

}