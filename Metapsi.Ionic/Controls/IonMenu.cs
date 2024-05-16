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
    public static IHtmlNode IonMenu(this HtmlBuilder b, Action<AttributesBuilder<IonMenu>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-menu", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonMenu(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-menu", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this AttributesBuilder<IonMenu> b, string value)
    {
        b.SetAttribute("content-id", value);
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("disabled", "");
    }
    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonMenu> b, bool value)
    {
        if (value) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public static void SetMaxEdgeStart(this AttributesBuilder<IonMenu> b, string value)
    {
        b.SetAttribute("max-edge-start", value);
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId(this AttributesBuilder<IonMenu> b, string value)
    {
        b.SetAttribute("menu-id", value);
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonMenu> b, string value)
    {
        b.SetAttribute("side", value);
    }
    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("side", "end");
    }
    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }
    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonMenu> b, bool value)
    {
        if (value) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetType(this AttributesBuilder<IonMenu> b, string value)
    {
        b.SetAttribute("type", value);
    }
    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeOverlay(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("type", "overlay");
    }
    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypePush(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("type", "push");
    }
    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeReveal(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("type", "reveal");
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonMenu(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-menu", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonMenu(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-menu", children);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, Var<string> value) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), value);
    }
    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, string value) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(value));
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }

    /// <summary>
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public static void SetMaxEdgeStart<T>(this PropsBuilder<T> b, Var<int> value) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxEdgeStart"), value);
    }
    /// <summary>
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public static void SetMaxEdgeStart<T>(this PropsBuilder<T> b, int value) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxEdgeStart"), b.Const(value));
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId<T>(this PropsBuilder<T> b, Var<string> value) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menuId"), value);
    }
    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId<T>(this PropsBuilder<T> b, string value) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menuId"), b.Const(value));
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("end"));
    }
    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideStart<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.String("side"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("swipeGesture"), b.Const(true));
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeOverlay<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("overlay"));
    }
    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypePush<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("push"));
    }
    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeReveal<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, DynamicProperty.String("type"), b.Const("reveal"));
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidClose", action);
    }
    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidClose", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidOpen", action);
    }
    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidOpen", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillClose", action);
    }
    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillClose", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillOpen", action);
    }
    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillOpen", b.MakeAction(action));
    }

}

