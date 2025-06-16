using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
/// </summary>
public partial class SlTabPanel
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
/// Setter extensions of SlTabPanel
/// </summary>
public static partial class SlTabPanelControl
{
    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabPanel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTabPanel>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tab-panel", buildAttributes, children);
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabPanel(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tab-panel", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabPanel(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTabPanel>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tab-panel", buildAttributes, children);
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTabPanel(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tab-panel", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The tab panel's name.
    /// </summary>
    public static void SetName(this Metapsi.Html.AttributesBuilder<SlTabPanel> b, string name) 
    {
        b.SetAttribute("name", name);
    }

    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static void SetActive(this Metapsi.Html.AttributesBuilder<SlTabPanel> b, bool active) 
    {
        if (active) b.SetAttribute("active", "");
    }

    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static void SetActive(this Metapsi.Html.AttributesBuilder<SlTabPanel> b) 
    {
        b.SetAttribute("active", "");
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabPanel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTabPanel>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tab-panel", buildProps, children);
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabPanel(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tab-panel", children);
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabPanel(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTabPanel>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tab-panel", buildProps, children);
    }

    /// <summary>
    /// Tab panels are used inside [tab groups](/components/tab-group) to display tabbed content.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTabPanel(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tab-panel", children);
    }

    /// <summary>
    /// The tab panel's name.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> name) where T: SlTabPanel
    {
        b.SetProperty(b.Props, b.Const("name"), name);
    }

    /// <summary>
    /// The tab panel's name.
    /// </summary>
    public static void SetName<T>(this Metapsi.Syntax.PropsBuilder<T> b, string name) where T: SlTabPanel
    {
        b.SetName(b.Const(name));
    }

    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTabPanel
    {
        b.SetActive(b.Const(true));
    }

    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> active) where T: SlTabPanel
    {
        b.SetProperty(b.Props, b.Const("active"), active);
    }

    /// <summary>
    /// When true, the tab panel will be shown.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool active) where T: SlTabPanel
    {
        b.SetActive(b.Const(active));
    }

}