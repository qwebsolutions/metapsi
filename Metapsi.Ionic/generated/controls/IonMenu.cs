using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonMenu
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
        /// <summary>
        /// Closes the menu. If the menu is already closed or it can't be closed, it returns `false`.
        /// </summary>
        public const string Close = "close";
        /// <summary>
        /// Returns `true` is the menu is active.  A menu is active when it can be opened or closed, meaning it's enabled and it's not part of a `ion-split-pane`.
        /// </summary>
        public const string IsActive = "isActive";
        /// <summary>
        /// Returns `true` is the menu is open.
        /// </summary>
        public const string IsOpen = "isOpen";
        /// <summary>
        /// Opens the menu. If the menu is already open or it can't be opened, it returns `false`.
        /// </summary>
        public const string Open = "open";
        /// <summary>
        /// Opens or closes the button. If the operation can't be completed successfully, it returns `false`.
        /// </summary>
        public const string SetOpen = "setOpen";
        /// <summary>
        /// Toggles the menu. If the menu is already open, it will try to close, otherwise it will try to open it. If the operation can't be completed successfully, it returns `false`.
        /// </summary>
        public const string Toggle = "toggle";
    }
}
/// <summary>
/// Setter extensions of IonMenu
/// </summary>
public static partial class IonMenuControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenu(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonMenu>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-menu", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenu(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-menu", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenu(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonMenu>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-menu", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonMenu(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-menu", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId(this Metapsi.Html.AttributesBuilder<IonMenu> b, string contentId) 
    {
        b.SetAttribute("contentId", contentId);
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonMenu> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId(this Metapsi.Html.AttributesBuilder<IonMenu> b, string menuId) 
    {
        b.SetAttribute("menuId", menuId);
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideEnd(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("side", "end");
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideStart(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("side", "start");
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonMenu> b, bool swipeGesture) 
    {
        if (swipeGesture) b.SetAttribute("swipeGesture", "");
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("swipeGesture", "");
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeOverlay(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("type", "overlay");
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypePush(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("type", "push");
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeReveal(this Metapsi.Html.AttributesBuilder<IonMenu> b) 
    {
        b.SetAttribute("type", "reveal");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenu(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonMenu>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-menu", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenu(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-menu", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenu(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonMenu>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-menu", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonMenu(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-menu", children);
    }

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> contentId) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("contentId"), contentId);
    }

    /// <summary>
    /// The `id` of the main content. When using a router this is typically `ion-router-outlet`. When not using a router, this is typically your main view's `ion-content`. This is not the id of the `ion-content` inside of your `ion-menu`.
    /// </summary>
    public static void SetContentId<T>(this Metapsi.Syntax.PropsBuilder<T> b, string contentId) where T: IonMenu
    {
        b.SetContentId(b.Const(contentId));
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// If `true`, the menu is disabled.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: IonMenu
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// The edge threshold for dragging the menu open. If a drag/swipe happens over this value, the menu is not triggered.
    /// </summary>
    public static void SetMaxEdgeStart<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<int> maxEdgeStart) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("maxEdgeStart"), maxEdgeStart);
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> menuId) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("menuId"), menuId);
    }

    /// <summary>
    /// An id for the menu.
    /// </summary>
    public static void SetMenuId<T>(this Metapsi.Syntax.PropsBuilder<T> b, string menuId) where T: IonMenu
    {
        b.SetMenuId(b.Const(menuId));
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideEnd<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("end"));
    }

    /// <summary>
    /// Which side of the view the menu should be placed.
    /// </summary>
    public static void SetSideStart<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("side"), b.Const("start"));
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetSwipeGesture(b.Const(true));
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> swipeGesture) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// If `true`, swiping the menu is enabled.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool swipeGesture) where T: IonMenu
    {
        b.SetSwipeGesture(b.Const(swipeGesture));
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeOverlay<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("overlay"));
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypePush<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("push"));
    }

    /// <summary>
    /// The display type of the menu. Available options: `"overlay"`, `"reveal"`, `"push"`.
    /// </summary>
    public static void SetTypeReveal<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonMenu
    {
        b.SetProperty(b.Props, b.Const("type"), b.Const("reveal"));
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionDidClose", action);
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonDidClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionDidClose", action);
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonDidClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is closed.
    /// </summary>
    public static void OnIonDidClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<MenuCloseEventDetail>>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionDidClose", action);
    }

    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionDidOpen", action);
    }

    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonDidOpen(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionDidOpen", action);
    }

    /// <summary>
    /// Emitted when the menu is open.
    /// </summary>
    public static void OnIonDidOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonDidOpen(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionWillClose", action);
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonWillClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionWillClose", action);
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonWillClose(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be closed.
    /// </summary>
    public static void OnIonWillClose<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<MenuCloseEventDetail>>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionWillClose", action);
    }

    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionWillOpen", action);
    }

    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonWillOpen(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonMenu
    {
        b.SetProperty(b.Props, "onionWillOpen", action);
    }

    /// <summary>
    /// Emitted when the menu is about to be opened.
    /// </summary>
    public static void OnIonWillOpen<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonMenu
    {
        b.OnIonWillOpen(b.MakeAction(action));
    }

}