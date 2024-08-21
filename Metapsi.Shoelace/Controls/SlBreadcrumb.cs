using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlBreadcrumb
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The separator to use between breadcrumb items. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string Separator = "separator";
    }
}

public static partial class SlBreadcrumbControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBreadcrumb(this HtmlBuilder b, Action<AttributesBuilder<SlBreadcrumb>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-breadcrumb", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBreadcrumb(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-breadcrumb", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBreadcrumb(this HtmlBuilder b, Action<AttributesBuilder<SlBreadcrumb>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-breadcrumb", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlBreadcrumb(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-breadcrumb", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users. </para>
    /// </summary>
    public static void SetLabel(this AttributesBuilder<SlBreadcrumb> b, string label)
    {
        b.SetAttribute("label", label);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumb(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumb>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-breadcrumb", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumb(this LayoutBuilder b, Action<PropsBuilder<SlBreadcrumb>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-breadcrumb", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumb(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-breadcrumb", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlBreadcrumb(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-breadcrumb", children);
    }
    /// <summary>
    /// <para> The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, Var<string> label) where T: SlBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), label);
    }

    /// <summary>
    /// <para> The label to use for the breadcrumb control. This will not be shown on the screen, but it will be announced by screen readers and other assistive devices to provide more context for users. </para>
    /// </summary>
    public static void SetLabel<T>(this PropsBuilder<T> b, string label) where T: SlBreadcrumb
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("label"), b.Const(label));
    }


}

