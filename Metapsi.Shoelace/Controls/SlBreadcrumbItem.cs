using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlBreadcrumbItem
{
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
        /// The separator to use for the breadcrumb item. This will only change the separator for this item. If you want to change it for all items in the group, set the separator on `<sl-breadcrumb>` instead.
        /// </summary>
        public const string Separator = "separator";
    }
}

public static partial class SlBreadcrumbItemControl
{
    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Var<IVNode> SlBreadcrumbItem(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumbItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-breadcrumb-item", buildProps, children);
    }
    /// <summary>
    /// Breadcrumb Items are used inside [breadcrumbs](/components/breadcrumb) to represent different links.
    /// </summary>
    public static Var<IVNode> SlBreadcrumbItem(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumbItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-breadcrumb-item", buildProps, children);
    }
    /// <summary>
    /// Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead.
    /// </summary>
    public static void SetHref(this PropsBuilder<SlBreadcrumbItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), value);
    }
    /// <summary>
    /// Optional URL to direct the user to when the breadcrumb item is activated. When set, a link will be rendered internally. When unset, a button will be rendered instead.
    /// </summary>
    public static void SetHref(this PropsBuilder<SlBreadcrumbItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("href"), b.Const(value));
    }

    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_blank(this PropsBuilder<SlBreadcrumbItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_blank"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_parent(this PropsBuilder<SlBreadcrumbItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_parent"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_self(this PropsBuilder<SlBreadcrumbItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_self"));
    }
    /// <summary>
    /// Tells the browser where to open the link. Only used when `href` is set.
    /// </summary>
    public static void SetTarget_top(this PropsBuilder<SlBreadcrumbItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("target"), b.Const("_top"));
    }

    /// <summary>
    /// The `rel` attribute to use on the link. Only used when `href` is set.
    /// </summary>
    public static void SetRel(this PropsBuilder<SlBreadcrumbItem> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), value);
    }
    /// <summary>
    /// The `rel` attribute to use on the link. Only used when `href` is set.
    /// </summary>
    public static void SetRel(this PropsBuilder<SlBreadcrumbItem> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("rel"), b.Const(value));
    }

}

