using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlBreadcrumbItem : SlComponent
{
    public SlBreadcrumbItem() : base("sl-breadcrumb-item") { }
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> An optional prefix, usually an icon or icon button. </para>
        /// </summary>
        public const string Prefix = "prefix";
        /// <summary>
        /// <para> An optional suffix, usually an icon or icon button. </para>
        /// </summary>
        public const string Suffix = "suffix";
        /// <summary>
        /// <para> The separator to use for the breadcrumb item. This will only change the separator for this item. If you want to change it for all items in the group, set the separator on `&lt;sl-breadcrumb&gt;` instead. </para>
        /// </summary>
        public const string Separator = "separator";
    }
}

public static partial class SlBreadcrumbItemControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBreadcrumbItem(this HtmlBuilder b, Action<AttributesBuilder<SlBreadcrumbItem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("sl-breadcrumb-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBreadcrumbItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("sl-breadcrumb-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead. </para>
    /// </summary>
    public static void SetHref(this AttributesBuilder<SlBreadcrumbItem> b,string href)
    {
        b.SetAttribute("href", href);
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget(this AttributesBuilder<SlBreadcrumbItem> b,string target)
    {
        b.SetAttribute("target", target);
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_blank(this AttributesBuilder<SlBreadcrumbItem> b)
    {
        b.SetAttribute("target", "_blank");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_parent(this AttributesBuilder<SlBreadcrumbItem> b)
    {
        b.SetAttribute("target", "_parent");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_self(this AttributesBuilder<SlBreadcrumbItem> b)
    {
        b.SetAttribute("target", "_self");
    }

    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_top(this AttributesBuilder<SlBreadcrumbItem> b)
    {
        b.SetAttribute("target", "_top");
    }

    /// <summary>
    /// <para> The `rel` attribute to use on the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetRel(this AttributesBuilder<SlBreadcrumbItem> b,string rel)
    {
        b.SetAttribute("rel", rel);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumbItem(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumbItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-breadcrumb-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumbItem(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumbItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-breadcrumb-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumbItem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-breadcrumb-item", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumbItem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-breadcrumb-item", children);
    }
    /// <summary>
    /// <para> Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, Var<string> href) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), href);
    }

    /// <summary>
    /// <para> Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead. </para>
    /// </summary>
    public static void SetHref<T>(this PropsBuilder<T> b, string href) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(href));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_blank<T>(this PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_blank"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_parent<T>(this PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_parent"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_self<T>(this PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_self"));
    }


    /// <summary>
    /// <para> Tells the browser where to open the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetTarget_top<T>(this PropsBuilder<T> b) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("target"), b.Const("_top"));
    }


    /// <summary>
    /// <para> The `rel` attribute to use on the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, Var<string> rel) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), rel);
    }

    /// <summary>
    /// <para> The `rel` attribute to use on the link. Only used when `href` is set. </para>
    /// </summary>
    public static void SetRel<T>(this PropsBuilder<T> b, string rel) where T: SlBreadcrumbItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(rel));
    }


}

