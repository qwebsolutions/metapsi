using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
/// </summary>
public partial class SlVisuallyHidden
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
/// Setter extensions of SlVisuallyHidden
/// </summary>
public static partial class SlVisuallyHiddenControl
{
    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlVisuallyHidden(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlVisuallyHidden>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-visually-hidden", buildAttributes, children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlVisuallyHidden(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-visually-hidden", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlVisuallyHidden(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlVisuallyHidden>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-visually-hidden", buildAttributes, children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlVisuallyHidden(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-visually-hidden", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlVisuallyHidden(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlVisuallyHidden>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-visually-hidden", buildProps, children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlVisuallyHidden(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-visually-hidden", children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlVisuallyHidden(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlVisuallyHidden>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-visually-hidden", buildProps, children);
    }

    /// <summary>
    /// The visually hidden utility makes content accessible to assistive devices without displaying it on the screen.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlVisuallyHidden(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-visually-hidden", children);
    }

}