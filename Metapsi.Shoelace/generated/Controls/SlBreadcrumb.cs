using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
/// </summary>
public partial class SlBreadcrumb
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The separator to use between breadcrumb items. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string Separator = "separator";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlBreadcrumb
/// </summary>
public static partial class SlBreadcrumbControl
{
    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumb(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlBreadcrumb>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-breadcrumb", buildAttributes, children);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumb(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-breadcrumb", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumb(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlBreadcrumb>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-breadcrumb", buildAttributes, children);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumb(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-breadcrumb", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public static void SetLabel(this Metapsi.Html.AttributesBuilder<SlBreadcrumb> b, string label) 
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlBreadcrumb>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-breadcrumb", buildProps, children);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-breadcrumb", children);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlBreadcrumb>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-breadcrumb", buildProps, children);
    }

    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumb(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-breadcrumb", children);
    }

    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> label) where T: SlBreadcrumb
    {
        b.SetProperty(b.Props, b.Const("label"), label);
    }

    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public static void SetLabel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string label) where T: SlBreadcrumb
    {
        b.SetLabel(b.Const(label));
    }

}