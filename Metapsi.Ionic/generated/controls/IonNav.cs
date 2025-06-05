using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonNav
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
        /// Returns `true` if the current view can go back.
        /// </summary>
        public const string CanGoBack = "canGoBack";
        /// <summary>
        /// Get the active view.
        /// </summary>
        public const string GetActive = "getActive";
        /// <summary>
        /// Get the view at the specified index.
        /// </summary>
        public const string GetByIndex = "getByIndex";
        /// <summary>
        /// Returns the number of views in the stack.
        /// </summary>
        public const string GetLength = "getLength";
        /// <summary>
        /// Get the previous view.
        /// </summary>
        public const string GetPrevious = "getPrevious";
        /// <summary>
        /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
        /// </summary>
        public const string Insert = "insert";
        /// <summary>
        /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
        /// </summary>
        public const string InsertPages = "insertPages";
        /// <summary>
        /// Pop a component off of the navigation stack. Navigates back from the current component.
        /// </summary>
        public const string Pop = "pop";
        /// <summary>
        /// Pop to a specific index in the navigation stack.
        /// </summary>
        public const string PopTo = "popTo";
        /// <summary>
        /// Navigate back to the root of the stack, no matter how far back that is.
        /// </summary>
        public const string PopToRoot = "popToRoot";
        /// <summary>
        /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
        /// </summary>
        public const string Push = "push";
        /// <summary>
        /// Removes a component from the navigation stack at the specified index.
        /// </summary>
        public const string RemoveIndex = "removeIndex";
        /// <summary>
        /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
        /// </summary>
        public const string SetPages = "setPages";
        /// <summary>
        /// Set the root for the current navigation stack to a component.
        /// </summary>
        public const string SetRoot = "setRoot";
    }
}
/// <summary>
/// Setter extensions of IonNav
/// </summary>
public static partial class IonNavControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNav>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-nav", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-nav", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonNav>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-nav", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonNav(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-nav", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonNav> b, bool animated) 
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this Metapsi.Html.AttributesBuilder<IonNav> b) 
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this Metapsi.Html.AttributesBuilder<IonNav> b, string root) 
    {
        b.SetAttribute("root", root);
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonNav> b, bool swipeGesture) 
    {
        if (swipeGesture) b.SetAttribute("swipeGesture", "");
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture(this Metapsi.Html.AttributesBuilder<IonNav> b) 
    {
        b.SetAttribute("swipeGesture", "");
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNav>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-nav", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-nav", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonNav>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-nav", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonNav(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-nav", children);
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNav
    {
        b.SetAnimated(b.Const(true));
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> animated) where T: IonNav
    {
        b.SetProperty(b.Props, b.Const("animated"), animated);
    }

    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool animated) where T: IonNav
    {
        b.SetAnimated(b.Const(animated));
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<string> root) where T: IonNav
    {
        b.SetProperty(b.Props, b.Const("root"), root);
    }

    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public static void SetRootParams<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Syntax.Var<System.Collections.Generic.List<object>>> rootParams) where T: IonNav
    {
        b.SetProperty(b.Props, b.Const("rootParams"), rootParams);
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: IonNav
    {
        b.SetSwipeGesture(b.Const(true));
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> swipeGesture) where T: IonNav
    {
        b.SetProperty(b.Props, b.Const("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool swipeGesture) where T: IonNav
    {
        b.SetSwipeGesture(b.Const(swipeGesture));
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonNav
    {
        b.SetProperty(b.Props, "onionNavDidChange", action);
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonNav
    {
        b.SetProperty(b.Props, "onionNavDidChange", action);
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonNav
    {
        b.SetProperty(b.Props, "onionNavWillChange", action);
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonNav
    {
        b.SetProperty(b.Props, "onionNavWillChange", action);
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonNav
    {
        b.OnIonNavWillChange(b.MakeAction(action));
    }

}