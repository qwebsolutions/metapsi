using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonSplitPane : IonComponent
{
    public IonSplitPane() : base("ion-split-pane") { }
}

public static partial class IonSplitPaneControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSplitPane(this HtmlBuilder b, Action<AttributesBuilder<IonSplitPane>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-split-pane", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonSplitPane(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-split-pane", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this AttributesBuilder<IonSplitPane> b, string value)
    {
        b.SetAttribute("content-id", value);
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSplitPane> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonSplitPane> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen(this AttributesBuilder<IonSplitPane> b, string value)
    {
        b.SetAttribute("when", value);
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
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), value);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, string value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), value);
    }
    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(value));
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("when"), b.Const(true));
    }
    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, Var<bool> value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("when"), value);
    }
    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, bool value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("when"), b.Const(value));
    }
    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, Var<string> value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("when"), value);
    }
    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen<T>(this PropsBuilder<T> b, string value) where T: IonSplitPane
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("when"), b.Const(value));
    }

    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public class IonSplitPaneIonSplitPaneVisibleDetail
    {
        public bool visible { get; set; }
    }
    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public static void OnIonSplitPaneVisible<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, IonSplitPaneIonSplitPaneVisibleDetail>> action) where TComponent: IonSplitPane
    {
        b.OnEventAction("onionSplitPaneVisible", action, "detail");
    }
    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public static void OnIonSplitPaneVisible<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonSplitPaneIonSplitPaneVisibleDetail>, Var<TModel>> action) where TComponent: IonSplitPane
    {
        b.OnEventAction("onionSplitPaneVisible", b.MakeAction(action), "detail");
    }

}

