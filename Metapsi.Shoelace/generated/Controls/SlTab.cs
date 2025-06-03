using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
/// </summary>
public partial class SlTab
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
/// Setter extensions of SlTab
/// </summary>
public static partial class SlTabControl
{
    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTab>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tab", buildAttributes, children);
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTab(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tab", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTab(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTab>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tab", buildAttributes, children);
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTab(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tab", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel(this Metapsi.Html.AttributesBuilder<SlTab> b, string panel) 
    {
        b.SetAttribute("panel", panel);
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive(this Metapsi.Html.AttributesBuilder<SlTab> b, bool active) 
    {
        if (active) b.SetAttribute("active", "");
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive(this Metapsi.Html.AttributesBuilder<SlTab> b) 
    {
        b.SetAttribute("active", "");
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable(this Metapsi.Html.AttributesBuilder<SlTab> b, bool closable) 
    {
        if (closable) b.SetAttribute("closable", "");
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable(this Metapsi.Html.AttributesBuilder<SlTab> b) 
    {
        b.SetAttribute("closable", "");
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTab> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTab> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTab>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tab", buildProps, children);
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTab(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tab", children);
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTab(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTab>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tab", buildProps, children);
    }

    /// <summary>
    /// Tabs are used inside [tab groups](/components/tab-group) to represent and activate [tab panels](/components/tab-panel).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTab(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tab", children);
    }

    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> panel) where T: SlTab
    {
        b.SetProperty(b.Props, b.Const("panel"), panel);
    }

    /// <summary>
    /// The name of the tab panel this tab is associated with. The panel must be located in the same tab group.
    /// </summary>
    public static void SetPanel<T>(this Metapsi.Syntax.PropsBuilder<T> b, string panel) where T: SlTab
    {
        b.SetPanel(b.Const(panel));
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTab
    {
        b.SetActive(b.Const(true));
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> active) where T: SlTab
    {
        b.SetProperty(b.Props, b.Const("active"), active);
    }

    /// <summary>
    /// Draws the tab in an active state.
    /// </summary>
    public static void SetActive<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool active) where T: SlTab
    {
        b.SetActive(b.Const(active));
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTab
    {
        b.SetClosable(b.Const(true));
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> closable) where T: SlTab
    {
        b.SetProperty(b.Props, b.Const("closable"), closable);
    }

    /// <summary>
    /// Makes the tab closable and shows a close button.
    /// </summary>
    public static void SetClosable<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool closable) where T: SlTab
    {
        b.SetClosable(b.Const(closable));
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTab
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlTab
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the tab and prevents selection.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlTab
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTab
    {
        b.OnSlEvent("onsl-close", action);
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTab
    {
        b.OnSlClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTab
    {
        b.OnSlEvent("onsl-close", action);
    }

    /// <summary>
    /// Emitted when the tab is closable and the close button is activated.
    /// </summary>
    public static void OnSlClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTab
    {
        b.OnSlClose(b.MakeAction(action));
    }

}