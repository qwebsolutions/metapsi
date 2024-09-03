using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonNav
{
    public static class Method
    {
        /// <summary>
        /// <para> Returns `true` if the current view can go back. </para>
        /// <para> (view?: ViewController) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> view The view to check. </para>
        /// </summary>
        public const string CanGoBack = "canGoBack";
        /// <summary>
        /// <para> Get the active view. </para>
        /// <para> () =&gt; Promise&lt;ViewController | undefined&gt; </para>
        /// </summary>
        public const string GetActive = "getActive";
        /// <summary>
        /// <para> Get the view at the specified index. </para>
        /// <para> (index: number) =&gt; Promise&lt;ViewController | undefined&gt; </para>
        /// <para> index The index of the view. </para>
        /// </summary>
        public const string GetByIndex = "getByIndex";
        /// <summary>
        /// <para> Returns the number of views in the stack. </para>
        /// <para> () =&gt; Promise&lt;number&gt; </para>
        /// </summary>
        public const string GetLength = "getLength";
        /// <summary>
        /// <para> Get the previous view. </para>
        /// <para> (view?: ViewController) =&gt; Promise&lt;ViewController | undefined&gt; </para>
        /// <para> view The view to get. </para>
        /// </summary>
        public const string GetPrevious = "getPrevious";
        /// <summary>
        /// <para> Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack. </para>
        /// <para> &lt;T extends NavComponent&gt;(insertIndex: number, component: T, componentProps?: ComponentProps&lt;T&gt; | null, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> insertIndex The index to insert the component at in the stack. </para>
        /// <para> component The component to insert into the navigation stack. </para>
        /// <para> componentProps Any properties of the component. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string Insert = "insert";
        /// <summary>
        /// <para> Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view. </para>
        /// <para> (insertIndex: number, insertComponents: NavComponent[] | NavComponentWithProps[], opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> insertIndex The index to insert the components at in the stack. </para>
        /// <para> insertComponents The components to insert into the navigation stack. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string InsertPages = "insertPages";
        /// <summary>
        /// <para> Pop a component off of the navigation stack. Navigates back from the current component. </para>
        /// <para> (opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string Pop = "pop";
        /// <summary>
        /// <para> Pop to a specific index in the navigation stack. </para>
        /// <para> (indexOrViewCtrl: number | ViewController, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> indexOrViewCtrl The index or view controller to pop to. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string PopTo = "popTo";
        /// <summary>
        /// <para> Navigate back to the root of the stack, no matter how far back that is. </para>
        /// <para> (opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string PopToRoot = "popToRoot";
        /// <summary>
        /// <para> Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams. </para>
        /// <para> &lt;T extends NavComponent&gt;(component: T, componentProps?: ComponentProps&lt;T&gt; | null, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> component The component to push onto the navigation stack. </para>
        /// <para> componentProps Any properties of the component. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string Push = "push";
        /// <summary>
        /// <para> Removes a component from the navigation stack at the specified index. </para>
        /// <para> (startIndex: number, removeCount?: number, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> startIndex The number to begin removal at. </para>
        /// <para> removeCount The number of components to remove. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string RemoveIndex = "removeIndex";
        /// <summary>
        /// <para> Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array. </para>
        /// <para> (views: NavComponent[] | NavComponentWithProps[], opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> views The list of views to set as the navigation stack. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string SetPages = "setPages";
        /// <summary>
        /// <para> Set the root for the current navigation stack to a component. </para>
        /// <para> &lt;T extends NavComponent&gt;(component: T, componentProps?: ComponentProps&lt;T&gt; | null, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt; </para>
        /// <para> component The component to set as the root of the navigation stack. </para>
        /// <para> componentProps Any properties of the component. </para>
        /// <para> opts The navigation options. </para>
        /// <para> done The transition complete function. </para>
        /// </summary>
        public const string SetRoot = "setRoot";
    }
}

public static partial class IonNavControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNav(this HtmlBuilder b, Action<AttributesBuilder<IonNav>> buildAttributes, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNav(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-nav", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNav(this HtmlBuilder b, Action<AttributesBuilder<IonNav>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-nav", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonNav(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-nav", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> If `true`, the nav should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonNav> b)
    {
        b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> If `true`, the nav should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated(this AttributesBuilder<IonNav> b, bool animated)
    {
        if (animated) b.SetAttribute("animated", "");
    }

    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot(this AttributesBuilder<IonNav> b, string root)
    {
        b.SetAttribute("root", root);
    }

    /// <summary>
    /// <para> If the nav component should allow for swipe-to-go-back. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonNav> b)
    {
        b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    /// <para> If the nav component should allow for swipe-to-go-back. </para>
    /// </summary>
    public static void SetSwipeGesture(this AttributesBuilder<IonNav> b, bool swipeGesture)
    {
        if (swipeGesture) b.SetAttribute("swipe-gesture", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNav(this LayoutBuilder b, Action<PropsBuilder<IonNav>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-nav", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNav(this LayoutBuilder b, Action<PropsBuilder<IonNav>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-nav", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNav(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-nav", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> IonNav(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-nav", children);
    }
    /// <summary>
    /// <para> If `true`, the nav should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(true));
    }


    /// <summary>
    /// <para> If `true`, the nav should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, Var<bool> animated) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), animated);
    }

    /// <summary>
    /// <para> If `true`, the nav should animate the transition of components. </para>
    /// </summary>
    public static void SetAnimated<T>(this PropsBuilder<T> b, bool animated) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("animated"), b.Const(animated));
    }


    /// <summary>
    /// <para> By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions. </para>
    /// </summary>
    public static void SetAnimation<T>(this PropsBuilder<T> b, Var<System.Func<object,object,Animation>> animation) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("animation"), animation);
    }

    /// <summary>
    /// <para> By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions. </para>
    /// </summary>
    public static void SetAnimation<T>(this PropsBuilder<T> b, System.Func<object,object,Animation> animation) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<System.Func<object,object,Animation>>("animation"), b.Const(animation));
    }


    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("root"), root);
    }

    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("root"), b.Const(root));
    }


    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, Var<HTMLElement> root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("root"), root);
    }

    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, HTMLElement root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("root"), b.Const(root));
    }


    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, Var<ViewController> root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("root"), root);
    }

    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, ViewController root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("root"), b.Const(root));
    }


    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, Var<string> root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("root"), root);
    }

    /// <summary>
    /// <para> Root NavComponent to load </para>
    /// </summary>
    public static void SetRoot<T>(this PropsBuilder<T> b, string root) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("root"), b.Const(root));
    }


    /// <summary>
    /// <para> Any parameters for the root component </para>
    /// </summary>
    public static void SetRootParams<T>(this PropsBuilder<T> b, Var<DynamicObject> rootParams) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("rootParams"), rootParams);
    }

    /// <summary>
    /// <para> Any parameters for the root component </para>
    /// </summary>
    public static void SetRootParams<T>(this PropsBuilder<T> b, DynamicObject rootParams) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<DynamicObject>("rootParams"), b.Const(rootParams));
    }


    /// <summary>
    /// <para> If the nav component should allow for swipe-to-go-back. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("swipeGesture"), b.Const(true));
    }


    /// <summary>
    /// <para> If the nav component should allow for swipe-to-go-back. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, Var<bool> swipeGesture) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("swipeGesture"), swipeGesture);
    }

    /// <summary>
    /// <para> If the nav component should allow for swipe-to-go-back. </para>
    /// </summary>
    public static void SetSwipeGesture<T>(this PropsBuilder<T> b, bool swipeGesture) where T: IonNav
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("swipeGesture"), b.Const(swipeGesture));
    }


    /// <summary>
    /// <para> Event fired when the nav has changed components </para>
    /// </summary>
    public static void OnIonNavDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonNav
    {
        b.OnEventAction("onionNavDidChange", action);
    }
    /// <summary>
    /// <para> Event fired when the nav has changed components </para>
    /// </summary>
    public static void OnIonNavDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonNav
    {
        b.OnEventAction("onionNavDidChange", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Event fired when the nav will change components </para>
    /// </summary>
    public static void OnIonNavWillChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: IonNav
    {
        b.OnEventAction("onionNavWillChange", action);
    }
    /// <summary>
    /// <para> Event fired when the nav will change components </para>
    /// </summary>
    public static void OnIonNavWillChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: IonNav
    {
        b.OnEventAction("onionNavWillChange", b.MakeAction(action));
    }

}

