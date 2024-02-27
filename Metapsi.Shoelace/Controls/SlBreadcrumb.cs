using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlBreadcrumb
{
}
public static partial class SlBreadcrumbControl
{
    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Var<IVNode> SlBreadcrumb(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumb>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-breadcrumb", buildProps, children);
    }
    /// <summary>
    /// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
    /// </summary>
    public static Var<IVNode> SlBreadcrumb(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumb>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-breadcrumb", buildProps, children);
    }
    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlBreadcrumb> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), value);
    }
    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public static void SetLabel(this PropsBuilder<SlBreadcrumb> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(value));
    }
}

/// <summary>
/// Breadcrumbs provide a group of links so users can easily navigate a website's hierarchy.
/// </summary>
public partial class SlBreadcrumb : HtmlTag
{
    public SlBreadcrumb()
    {
        this.Tag = "sl-breadcrumb";
    }

    public static SlBreadcrumb New()
    {
        return new SlBreadcrumb();
    }
    public static class Slot
    {
        /// <summary> 
        /// The separator to use between breadcrumb items. Works best with `<sl-icon>`.
        /// </summary>
        public const string Separator = "separator";
    }
}

public static partial class SlBreadcrumbControl
{
    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public static SlBreadcrumb SetLabel(this SlBreadcrumb tag, string value)
    {
        return tag.SetAttribute("label", value.ToString());
    }
}

