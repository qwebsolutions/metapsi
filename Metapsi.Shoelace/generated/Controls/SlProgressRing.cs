using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Progress rings are used to show the progress of a determinate operation in a circular fashion.
/// </summary>
public partial class SlProgressRing
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
/// Setter extensions of SlProgressRing
/// </summary>
public static partial class SlProgressRingControl
{
    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressRing(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlProgressRing>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-progress-ring", buildAttributes, children);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressRing(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-progress-ring", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressRing(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlProgressRing>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-progress-ring", buildAttributes, children);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlProgressRing(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-progress-ring", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlProgressRing> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressRing(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlProgressRing>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-progress-ring", buildProps, children);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressRing(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-progress-ring", children);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressRing(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlProgressRing>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-progress-ring", buildProps, children);
    }

    /// <summary>
    /// Progress rings are used to show the progress of a determinate operation in a circular fashion.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlProgressRing(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-progress-ring", children);
    }

    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<decimal> value) where T: SlProgressRing
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }

    /// <summary>
    /// The current progress as a percentage, 0 to 100.
    /// </summary>
    public static void SetValue<T>(this Metapsi.Syntax.PropsBuilder<T> b, decimal value) where T: SlProgressRing
    {
        b.SetValue(b.Const(value));
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlProgressRing
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// A custom label for assistive devices.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlProgressRing
    {
        b.SetLabel(b.Const(label));
    }

}