using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
/// </summary>
public partial class SlBreadcrumbItem
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// An optional prefix, usually an icon or icon button.
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// An optional suffix, usually an icon or icon button.
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// The separator to use for the breadcrumb item. This will only change the separator for this item. If you want to change it for all items in the group, set the separator on `&lt;sl-breadcrumb&gt;` instead.
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
/// Setter extensions of SlBreadcrumbItem
/// </summary>
public static partial class SlBreadcrumbItemControl
{
    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumbItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlBreadcrumbItem>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-breadcrumb-item", buildAttributes, children);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumbItem(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-breadcrumb-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumbItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlBreadcrumbItem>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-breadcrumb-item", buildAttributes, children);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlBreadcrumbItem(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-breadcrumb-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead.
    /// </summary>
    public static void SetHref(this Metapsi.Html.AttributesBuilder<SlBreadcrumbItem> b, string href) 
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_blank(this Metapsi.Html.AttributesBuilder<SlBreadcrumbItem> b) 
    {
        b.SetAttribute("target", "_blank");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_parent(this Metapsi.Html.AttributesBuilder<SlBreadcrumbItem> b) 
    {
        b.SetAttribute("target", "_parent");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_self(this Metapsi.Html.AttributesBuilder<SlBreadcrumbItem> b) 
    {
        b.SetAttribute("target", "_self");
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_top(this Metapsi.Html.AttributesBuilder<SlBreadcrumbItem> b) 
    {
        b.SetAttribute("target", "_top");
    }

    /// <summary>
    /// The `rel` attribute to use on the link. Only used when `href` is set.
    /// </summary>
    public static void SetRel(this Metapsi.Html.AttributesBuilder<SlBreadcrumbItem> b, string rel) 
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumbItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlBreadcrumbItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-breadcrumb-item", buildProps, children);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumbItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-breadcrumb-item", children);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumbItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlBreadcrumbItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-breadcrumb-item", buildProps, children);
    }

    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlBreadcrumbItem(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-breadcrumb-item", children);
    }

    /// <summary>
    /// Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> href) where T: SlBreadcrumbItem
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }

    /// <summary>
    /// Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead.
    /// </summary>
    public static void SetHref<T>(this Metapsi.Syntax.PropsBuilder<T> b, string href) where T: SlBreadcrumbItem
    {
        b.SetHref(b.Const(href));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_blank<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_blank"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_parent<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_parent"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_self<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_self"));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_top<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_top"));
    }

    /// <summary>
    /// The `rel` attribute to use on the link. Only used when `href` is set.
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> rel) where T: SlBreadcrumbItem
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }

    /// <summary>
    /// The `rel` attribute to use on the link. Only used when `href` is set.
    /// </summary>
    public static void SetRel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string rel) where T: SlBreadcrumbItem
    {
        b.SetRel(b.Const(rel));
    }

}