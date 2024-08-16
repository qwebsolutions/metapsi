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
        /// <para> Closes the menu. If the menu is already closed or it can't be closed, it returns `false`. </para>
        /// <para> (animated?: boolean) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> animated  </para>
        /// </summary>
        public const string Close = "close";
        /// <summary>
        /// <para> Returns `true` is the menu is active.  A menu is active when it can be opened or closed, meaning it's enabled and it's not part of a `ion-split-pane`. </para>
        /// <para> () =&gt; Promise&lt;boolean&gt; </para>
        /// </summary>
        public const string IsActive = "isActive";
        /// <summary>
        /// <para> Returns `true` is the menu is open. </para>
        /// <para> () =&gt; Promise&lt;boolean&gt; </para>
        /// </summary>
        public const string IsOpen = "isOpen";
        /// <summary>
        /// <para> Opens the menu. If the menu is already open or it can't be opened, it returns `false`. </para>
        /// <para> (animated?: boolean) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> animated  </para>
        /// </summary>
        public const string Open = "open";
        /// <summary>
        /// <para> Opens or closes the button. If the operation can't be completed successfully, it returns `false`. </para>
        /// <para> (shouldOpen: boolean, animated?: boolean) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> shouldOpen  </para>
        /// <para> animated  </para>
        /// </summary>
        public const string SetOpen = "setOpen";
        /// <summary>
        /// <para> Toggles the menu. If the menu is already open, it will try to close, otherwise it will try to open it. If the operation can't be completed successfully, it returns `false`. </para>
        /// <para> (animated?: boolean) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> animated  </para>
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
    /// <para> The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`. </para>
    /// </summary>
    public static void SetContentId(this AttributesBuilder<IonMenu> b,string contentId)
    {
        b.SetAttribute("content-id", contentId);
    }

    /// <summary>
    /// <para> If `true`, the menu is disabled. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> If `true`, the menu is disabled. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<IonMenu> b,bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered. </para>
    /// </summary>
    public static void SetMaxEdgeStart(this AttributesBuilder<IonMenu> b,string maxEdgeStart)
    {
        b.SetAttribute("max-edge-start", maxEdgeStart);
    }

    /// <summary>
    /// <para> An id for the menu. </para>
    /// </summary>
    public static void SetMenuId(this AttributesBuilder<IonMenu> b,string menuId)
    {
        b.SetAttribute("menu-id", menuId);
    }

    /// <summary>
    /// <para> Which side of the view the menu should be placed. </para>
    /// </summary>
    public static void SetSide(this AttributesBuilder<IonMenu> b,string side)
    {
        b.SetAttribute("side", side);
    }

    /// <summary>
    /// <para> Which side of the view the menu should be placed. </para>
    /// </summary>
    public static void SetSideEnd(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// <para> Which side of the view the menu should be placed. </para>
    /// </summary>
    public static void SetSideStart(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// <para> If `true`, swiping the menu is enabled. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// <para> If `true`, swiping the menu is enabled. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonMenu> b,bool swipeGesture)
    {
        if (swipeGesture) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// <para> The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`. </para>
    /// </summary>
    public static void SetType(this AttributesBuilder<IonMenu> b,string type)
    {
        b.SetAttribute("type", type);
    }

    /// <summary>
    /// <para> The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`. </para>
    /// </summary>
    public static void SetTypeOverlay(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("type", "overlay");
    }

    /// <summary>
    /// <para> The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`. </para>
    /// </summary>
    public static void SetTypePush(this AttributesBuilder<IonMenu> b)
    {
        b.SetAttribute("type", "push");
    }

    /// <summary>
    /// <para> The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`. </para>
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
    /// <para> The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`. </para>
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, Var<string> contentId) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), contentId);
    }

    /// <summary>
    /// <para> The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`. </para>
    /// </summary>
    public static void SetContentId<T>(this PropsBuilder<T> b, string contentId) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("contentId"), b.Const(contentId));
    }


    /// <summary>
    /// <para> If `true`, the menu is disabled. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the menu is disabled. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> If `true`, the menu is disabled. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered. </para>
    /// </summary>
    public static void SetMaxEdgeStart<T>(this PropsBuilder<T> b, Var<int> maxEdgeStart) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxEdgeStart"), maxEdgeStart);
    }

    /// <summary>
    /// <para> The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered. </para>
    /// </summary>
    public static void SetMaxEdgeStart<T>(this PropsBuilder<T> b, int maxEdgeStart) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<int>("maxEdgeStart"), b.Const(maxEdgeStart));
    }


    /// <summary>
    /// <para> An id for the menu. </para>
    /// </summary>
    public static void SetMenuId<T>(this PropsBuilder<T> b, Var<string> menuId) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menuId"), menuId);
    }

    /// <summary>
    /// <para> An id for the menu. </para>
    /// </summary>
    public static void SetMenuId<T>(this PropsBuilder<T> b, string menuId) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("menuId"), b.Const(menuId));
    }


    /// <summary>
    /// <para> Which side of the view the menu should be placed. </para>
    /// </summary>
    public static void SetSideEnd<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("side"), b.Const("end"));
    }


    /// <summary>
    /// <para> If `true`, swiping the menu is enabled. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("swipeGesture"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, swiping the menu is enabled. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, Var<bool> swipeGesture) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// <para> If `true`, swiping the menu is enabled. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, bool swipeGesture) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("swipeGesture"), b.Const(swipeGesture));
    }


    /// <summary>
    /// <para> The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`. </para>
    /// </summary>
    public static void SetTypeOverlay<T>(this PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("type"), b.Const("overlay"));
    }


    /// <summary>
    /// <para> Emitted when the menu is closed. </para>
    /// </summary>
    public static void OnIonDidClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidClose", action);
    }
    /// <summary>
    /// <para> Emitted when the menu is closed. </para>
    /// </summary>
    public static void OnIonDidClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidClose", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the menu is open. </para>
    /// </summary>
    public static void OnIonDidOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidOpen", action);
    }
    /// <summary>
    /// <para> Emitted when the menu is open. </para>
    /// </summary>
    public static void OnIonDidOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionDidOpen", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the menu is about to be closed. </para>
    /// </summary>
    public static void OnIonWillClose<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillClose", action);
    }
    /// <summary>
    /// <para> Emitted when the menu is about to be closed. </para>
    /// </summary>
    public static void OnIonWillClose<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillClose", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the menu is about to be opened. </para>
    /// </summary>
    public static void OnIonWillOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillOpen", action);
    }
    /// <summary>
    /// <para> Emitted when the menu is about to be opened. </para>
    /// </summary>
    public static void OnIonWillOpen<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonMenu
    {
        b.OnEventAction("onionWillOpen", b.MakeAction(action));
    }

}

