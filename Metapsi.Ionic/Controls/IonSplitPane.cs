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
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public string contentId
    {
        get
        {
            return this.GetTag().GetAttribute<string>("contentId");
        }
        set
        {
            this.GetTag().SetAttribute("contentId", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public bool disabled
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("disabled");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("disabled", value.ToString());
        }
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public string when
    {
        get
        {
            return this.GetTag().GetAttribute<string>("when");
        }
        set
        {
            this.GetTag().SetAttribute("when", value.ToString());
        }
    }

}

public static partial class IonSplitPaneControl
{
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
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this PropsBuilder<IonSplitPane> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), value);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this PropsBuilder<IonSplitPane> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the split pane will be hidden.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonSplitPane> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen(this PropsBuilder<IonSplitPane> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("when"), b.Const(true));
    }
    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen(this PropsBuilder<IonSplitPane> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("when"), value);
    }
    /// <summary>
    /// When the split-pane should be shown. Can be a CSS media query expression, or a shortcut expression. Can also be a boolean expression.
    /// </summary>
    public static void SetWhen(this PropsBuilder<IonSplitPane> b, string value)
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
    public static void OnIonSplitPaneVisible<TModel>(this PropsBuilder<IonSplitPane> b, Var<HyperType.Action<TModel, IonSplitPaneIonSplitPaneVisibleDetail>> action)
    {
        b.OnEventAction("onionSplitPaneVisible", action, "detail");
    }
    /// <summary>
    /// Expression to be called when the split-pane visibility has changed
    /// </summary>
    public static void OnIonSplitPaneVisible<TModel>(this PropsBuilder<IonSplitPane> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonSplitPaneIonSplitPaneVisibleDetail>, Var<TModel>> action)
    {
        b.OnEventAction("onionSplitPaneVisible", b.MakeAction(action), "detail");
    }

}

