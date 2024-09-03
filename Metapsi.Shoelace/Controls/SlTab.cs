using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Shoelace;


public partial class SlTab
{
    public static class Method
    {
        /// <summary>
        /// <para> Sets focus to the tab. </para>
        /// </summary>
        public const string Focus = "focus";
        /// <summary>
        /// <para> Removes focus from the tab. </para>
        /// </summary>
        public const string Blur = "blur";
    }
}

public static partial class SlTabControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTab(this HtmlBuilder b, Action<AttributesBuilder<SlTab>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tab", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTab(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tab", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTab(this HtmlBuilder b, Action<AttributesBuilder<SlTab>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tab", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTab(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tab", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The name of the tab panel this tab is associated with. The panel must be located in the same tab group. </para>
    /// </summary>
    public static void SetPanel(this AttributesBuilder<SlTab> b, string panel)
    {
        b.SetAttribute("panel", panel);
    }

    /// <summary>
    /// <para> Draws the tab in an active state. </para>
    /// </summary>
    public static void SetActive(this AttributesBuilder<SlTab> b)
    {
        b.SetAttribute("active", "");
    }

    /// <summary>
    /// <para> Draws the tab in an active state. </para>
    /// </summary>
    public static void SetActive(this AttributesBuilder<SlTab> b, bool active)
    {
        if (active) b.SetAttribute("active", "");
    }

    /// <summary>
    /// <para> Makes the tab closable and shows a close button. </para>
    /// </summary>
    public static void SetClosable(this AttributesBuilder<SlTab> b)
    {
        b.SetAttribute("closable", "");
    }

    /// <summary>
    /// <para> Makes the tab closable and shows a close button. </para>
    /// </summary>
    public static void SetClosable(this AttributesBuilder<SlTab> b, bool closable)
    {
        if (closable) b.SetAttribute("closable", "");
    }

    /// <summary>
    /// <para> Disables the tab and prevents selection. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTab> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the tab and prevents selection. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTab> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Action<PropsBuilder<SlTab>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Action<PropsBuilder<SlTab>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tab", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTab(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tab", children);
    }
    /// <summary>
    /// <para> The name of the tab panel this tab is associated with. The panel must be located in the same tab group. </para>
    /// </summary>
    public static void SetPanel<T>(this PropsBuilder<T> b, Var<string> panel) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("panel"), panel);
    }

    /// <summary>
    /// <para> The name of the tab panel this tab is associated with. The panel must be located in the same tab group. </para>
    /// </summary>
    public static void SetPanel<T>(this PropsBuilder<T> b, string panel) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("panel"), b.Const(panel));
    }


    /// <summary>
    /// <para> Draws the tab in an active state. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the tab in an active state. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, Var<bool> active) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), active);
    }

    /// <summary>
    /// <para> Draws the tab in an active state. </para>
    /// </summary>
    public static void SetActive<T>(this PropsBuilder<T> b, bool active) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("active"), b.Const(active));
    }


    /// <summary>
    /// <para> Makes the tab closable and shows a close button. </para>
    /// </summary>
    public static void SetClosable<T>(this PropsBuilder<T> b) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("closable"), b.Const(true));
    }


    /// <summary>
    /// <para> Makes the tab closable and shows a close button. </para>
    /// </summary>
    public static void SetClosable<T>(this PropsBuilder<T> b, Var<bool> closable) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("closable"), closable);
    }

    /// <summary>
    /// <para> Makes the tab closable and shows a close button. </para>
    /// </summary>
    public static void SetClosable<T>(this PropsBuilder<T> b, bool closable) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("closable"), b.Const(closable));
    }


    /// <summary>
    /// <para> Disables the tab and prevents selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the tab and prevents selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the tab and prevents selection. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Emitted when the tab is closable and the close button is activated. </para>
    /// </summary>
    public static void OnSlClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTab
    {
        b.OnEventAction("onsl-close", action);
    }
    /// <summary>
    /// <para> Emitted when the tab is closable and the close button is activated. </para>
    /// </summary>
    public static void OnSlClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTab
    {
        b.OnEventAction("onsl-close", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tab is closable and the close button is activated. </para>
    /// </summary>
    public static void OnSlClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTab
    {
        b.OnEventAction("onsl-close", action);
    }
    /// <summary>
    /// <para> Emitted when the tab is closable and the close button is activated. </para>
    /// </summary>
    public static void OnSlClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTab
    {
        b.OnEventAction("onsl-close", b.MakeAction(action));
    }

}

