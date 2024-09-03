using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlTabPanel
{
}

public static partial class SlTabPanelControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabPanel(this HtmlBuilder b, Action<AttributesBuilder<SlTabPanel>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tab-panel", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabPanel(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tab-panel", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabPanel(this HtmlBuilder b, Action<AttributesBuilder<SlTabPanel>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tab-panel", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTabPanel(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tab-panel", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The tab panel's name. </para>
    /// </summary>
    public static void SetName(this AttributesBuilder<SlTabPanel> b, string name)
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// <para> When true, the tab panel will be shown. </para>
    /// </summary>
    public static void SetActive(this AttributesBuilder<SlTabPanel> b)
    {
        b.SetAttribute("active", "");
    }

    /// <summary>
    /// <para> When true, the tab panel will be shown. </para>
    /// </summary>
    public static void SetActive(this AttributesBuilder<SlTabPanel> b, bool active)
    {
        if (active) b.SetAttribute("active", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabPanel(this LayoutBuilder b, Action<PropsBuilder<SlTabPanel>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab-panel", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabPanel(this LayoutBuilder b, Action<PropsBuilder<SlTabPanel>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab-panel", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabPanel(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab-panel", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTabPanel(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab-panel", children);
    }
    /// <summary>
    /// <para> The tab panel's name. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, Var<string> name) where T: SlTabPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), name);
    }

    /// <summary>
    /// <para> The tab panel's name. </para>
    /// </summary>
    public static void SetName<T>(this PropsBuilder<T> b, string name) where T: SlTabPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("name"), b.Const(name));
    }


    /// <summary>
    /// <para> When true, the tab panel will be shown. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b) where T: SlTabPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), b.Const(true));
    }


    /// <summary>
    /// <para> When true, the tab panel will be shown. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, Var<bool> active) where T: SlTabPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), active);
    }

    /// <summary>
    /// <para> When true, the tab panel will be shown. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, bool active) where T: SlTabPanel
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), b.Const(active));
    }


}

