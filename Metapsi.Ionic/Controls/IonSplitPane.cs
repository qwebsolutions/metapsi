using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSplitPane
{
}

public static partial class IonSplitPaneControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSplitPane(this HtmlBuilder b, Action<AttributesBuilder<IonSplitPane>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-split-pane", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSplitPane(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-split-pane", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSplitPane(this HtmlBuilder b, Action<AttributesBuilder<IonSplitPane>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-split-pane", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonSplitPane(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-split-pane", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`. </para>
    /// </summary>
    public static void SetContentId(this AttributesBuilder<IonSplitPane> b, string contentId)
    {
        b.SetAttribute("content-id", contentId);
    }

    /// <summary>
    /// <para> If `true`, the split pane will be hidden. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSplitPane> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the split pane will be hidden. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSplitPane> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression. </para>
    /// </summary>
    public static void SetWhen(this AttributesBuilder<IonSplitPane> b, string when)
    {
        b.SetAttribute("when", when);
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSplitPane(this LayoutBuilder b, Action<PropsBuilder<IonSplitPane>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-split-pane", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSplitPane(this LayoutBuilder b, Action<PropsBuilder<IonSplitPane>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-split-pane", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSplitPane(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-split-pane", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonSplitPane(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-split-pane", children);
    }
    /// <summary>
    /// <para> The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`. </para>
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, Var<string> contentId) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), contentId);
    }

    /// <summary>
    /// <para> The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`. </para>
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, string contentId) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(contentId));
    }


    /// <summary>
    /// <para> If `true`, the split pane will be hidden. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the split pane will be hidden. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the split pane will be hidden. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression. </para>
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("when"), b.Const(true));
    }


    /// <summary>
    /// <para> When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression. </para>
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, Var<bool> when) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("when"), when);
    }

    /// <summary>
    /// <para> When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression. </para>
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, bool when) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("when"), b.Const(when));
    }


    /// <summary>
    /// <para> When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression. </para>
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, Var<string> when) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("when"), when);
    }

    /// <summary>
    /// <para> When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression. </para>
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, string when) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("when"), b.Const(when));
    }


    /// <summary>
    /// <para> Expression to be called when the split-pane visibility has changed </para>
    /// </summary>
    public class IonSplitPaneIonSplitPaneVisibleDetail
    {
        public bool visible { get; set; }
    }

    /// <summary>
    /// <para> Expression to be called when the split-pane visibility has changed </para>
    /// </summary>
    public static void OnIonSplitPaneVisible<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, IonSplitPaneIonSplitPaneVisibleDetail>> action) where TComponent: IonSplitPane
    {
        b.OnEventAction("onionSplitPaneVisible", action, "detail");
    }
    /// <summary>
    /// <para> Expression to be called when the split-pane visibility has changed </para>
    /// </summary>
    public static void OnIonSplitPaneVisible<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonSplitPaneIonSplitPaneVisibleDetail>, Var<TModel>> action) where TComponent: IonSplitPane
    {
        b.OnEventAction("onionSplitPaneVisible", b.MakeAction(action), "detail");
    }

}

