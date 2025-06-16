using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Spinners are used to show the progress of an indeterminate operation.
/// </summary>
public partial class SlSpinner
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
/// Setter extensions of SlSpinner
/// </summary>
public static partial class SlSpinnerControl
{
    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSpinner(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSpinner>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-spinner", buildAttributes, children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSpinner(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-spinner", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSpinner(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlSpinner>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-spinner", buildAttributes, children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlSpinner(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-spinner", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSpinner(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSpinner>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-spinner", buildProps, children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSpinner(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-spinner", children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSpinner(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlSpinner>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-spinner", buildProps, children);
    }

    /// <summary>
    /// Spinners are used to show the progress of an indeterminate operation.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlSpinner(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-spinner", children);
    }

}