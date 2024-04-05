using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonMenu : IonComponent
{
    public IonMenu() : base("ion-menu") { }
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
    /// If `true`, the menu is disabled.
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
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public int maxEdgeStart
    {
        get
        {
            return this.GetTag().GetAttribute<int>("maxEdgeStart");
        }
        set
        {
            this.GetTag().SetAttribute("maxEdgeStart", value.ToString());
        }
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public string menuId
    {
        get
        {
            return this.GetTag().GetAttribute<string>("menuId");
        }
        set
        {
            this.GetTag().SetAttribute("menuId", value.ToString());
        }
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public string side
    {
        get
        {
            return this.GetTag().GetAttribute<string>("side");
        }
        set
        {
            this.GetTag().SetAttribute("side", value.ToString());
        }
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public bool swipeGesture
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("swipeGesture");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("swipeGesture", value.ToString());
        }
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public string type
    {
        get
        {
            return this.GetTag().GetAttribute<string>("type");
        }
        set
        {
            this.GetTag().SetAttribute("type", value.ToString());
        }
    }

    public static class Method
    {
        /// <summary> 
        /// Closes the menu. If the menu is already closed or it can't be closed, it returns `false`.
        /// <para>(animated?: boolean) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>animated </para>
        /// </summary>
        public const string Close = "close";
        /// <summary> 
        /// Returns `true` is the menu is active.  A menu is active when it can be opened or closed, meaning it's enabled and it's not part of a `ion-split-pane`.
        /// <para>() =&gt; Promise&lt;boolean&gt;</para>
        /// </summary>
        public const string IsActive = "isActive";
        /// <summary> 
        /// Returns `true` is the menu is open.
        /// <para>() =&gt; Promise&lt;boolean&gt;</para>
        /// </summary>
        public const string IsOpen = "isOpen";
        /// <summary> 
        /// Opens the menu. If the menu is already open or it can't be opened, it returns `false`.
        /// <para>(animated?: boolean) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>animated </para>
        /// </summary>
        public const string Open = "open";
        /// <summary> 
        /// Opens or closes the button. If the operation can't be completed successfully, it returns `false`.
        /// <para>(shouldOpen: boolean, animated?: boolean) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>shouldOpen </para>
        /// <para>animated </para>
        /// </summary>
        public const string SetOpen = "setOpen";
        /// <summary> 
        /// Toggles the menu. If the menu is already open, it will try to close, otherwise it will try to open it. If the operation can't be completed successfully, it returns `false`.
        /// <para>(animated?: boolean) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>animated </para>
        /// </summary>
        public const string Toggle = "toggle";
    }
}

public static partial class IonMenuControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonMenu(this LayoutBuilder b, Action<PropsBuilder<IonMenu>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonMenu(this LayoutBuilder b, Action<PropsBuilder<IonMenu>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu", buildProps, children);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this PropsBuilder<IonMenu> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), value);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this PropsBuilder<IonMenu> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<IonMenu> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public static void SetMaxEdgeStart(this PropsBuilder<IonMenu> b, Var<int> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxEdgeStart"), value);
    }
    /// <summary>
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public static void SetMaxEdgeStart(this PropsBuilder<IonMenu> b, int value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxEdgeStart"), b.Const(value));
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId(this PropsBuilder<IonMenu> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menuId"), value);
    }
    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId(this PropsBuilder<IonMenu> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menuId"), b.Const(value));
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideEnd(this PropsBuilder<IonMenu> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideStart(this PropsBuilder<IonMenu> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture(this PropsBuilder<IonMenu> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("swipeGesture"), b.Const(true));
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetType(this PropsBuilder<IonMenu> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), value);
    }
    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetType(this PropsBuilder<IonMenu> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const(value));
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<TModel>(this PropsBuilder<IonMenu> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionDidClose", action);
    }
    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<TModel>(this PropsBuilder<IonMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionDidClose", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<TModel>(this PropsBuilder<IonMenu> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionDidOpen", action);
    }
    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<TModel>(this PropsBuilder<IonMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionDidOpen", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<TModel>(this PropsBuilder<IonMenu> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionWillClose", action);
    }
    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<TModel>(this PropsBuilder<IonMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionWillClose", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<TModel>(this PropsBuilder<IonMenu> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionWillOpen", action);
    }
    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<TModel>(this PropsBuilder<IonMenu> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionWillOpen", b.MakeAction(action));
    }

}

