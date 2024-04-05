using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlBreadcrumb : SlComponent
{
    public SlBreadcrumb() : base("sl-breadcrumb") { }
    /// <summary>
    /// The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users.
    /// </summary>
    public string label
    {
        get
        {
            return this.GetTag().GetAttribute<string>("label");
        }
        set
        {
            this.GetTag().SetAttribute("label", value.ToString());
        }
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

