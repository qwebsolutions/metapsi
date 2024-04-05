using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonNav : IonComponent
{
    public IonNav() : base("ion-nav") { }
    /// <summary>
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public bool animated
    {
        get
        {
            return this.GetTag().GetAttribute<bool>("animated");
        }
        set
        {
            if (!value) return;
            this.GetTag().SetAttribute("animated", value.ToString());
        }
    }

    /// <summary>
    /// By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions.
    /// </summary>
    public System.Func<object,object,Animation> animation
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object,object,Animation>>("animation");
        }
        set
        {
            this.GetTag().SetAttribute("animation", value.ToString());
        }
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public string root
    {
        get
        {
            return this.GetTag().GetAttribute<string>("root");
        }
        set
        {
            this.GetTag().SetAttribute("root", value.ToString());
        }
    }

    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public object rootParams
    {
        get
        {
            return this.GetTag().GetAttribute<object>("rootParams");
        }
        set
        {
            this.GetTag().SetAttribute("rootParams", value.ToString());
        }
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
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

    public static class Method
    {
        /// <summary> 
        /// Returns `true` if the current view can go back.
        /// <para>(view?: ViewController) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>view The view to check.</para>
        /// </summary>
        public const string CanGoBack = "canGoBack";
        /// <summary> 
        /// Get the active view.
        /// <para>() =&gt; Promise&lt;ViewController | undefined&gt;</para>
        /// </summary>
        public const string GetActive = "getActive";
        /// <summary> 
        /// Get the view at the specified index.
        /// <para>(index: number) =&gt; Promise&lt;ViewController | undefined&gt;</para>
        /// <para>index The index of the view.</para>
        /// </summary>
        public const string GetByIndex = "getByIndex";
        /// <summary> 
        /// Get the previous view.
        /// <para>(view?: ViewController) =&gt; Promise&lt;ViewController | undefined&gt;</para>
        /// <para>view The view to get.</para>
        /// </summary>
        public const string GetPrevious = "getPrevious";
        /// <summary> 
        /// Inserts a component into the navigation stack at the specified index. This is useful to add a component at any point in the navigation stack.
        /// <para>&lt;T extends NavComponent&gt;(insertIndex: number, component: T, componentProps?: ComponentProps&lt;T&gt; | null, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>insertIndex The index to insert the component at in the stack.</para>
        /// <para>component The component to insert into the navigation stack.</para>
        /// <para>componentProps Any properties of the component.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string Insert = "insert";
        /// <summary> 
        /// Inserts an array of components into the navigation stack at the specified index. The last component in the array will become instantiated as a view, and animate in to become the active view.
        /// <para>(insertIndex: number, insertComponents: NavComponent[] | NavComponentWithProps[], opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>insertIndex The index to insert the components at in the stack.</para>
        /// <para>insertComponents The components to insert into the navigation stack.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string InsertPages = "insertPages";
        /// <summary> 
        /// Pop a component off of the navigation stack. Navigates back from the current component.
        /// <para>(opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string Pop = "pop";
        /// <summary> 
        /// Pop to a specific index in the navigation stack.
        /// <para>(indexOrViewCtrl: number | ViewController, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>indexOrViewCtrl The index or view controller to pop to.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string PopTo = "popTo";
        /// <summary> 
        /// Navigate back to the root of the stack, no matter how far back that is.
        /// <para>(opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string PopToRoot = "popToRoot";
        /// <summary> 
        /// Push a new component onto the current navigation stack. Pass any additional information along as an object. This additional information is accessible through NavParams.
        /// <para>&lt;T extends NavComponent&gt;(component: T, componentProps?: ComponentProps&lt;T&gt; | null, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>component The component to push onto the navigation stack.</para>
        /// <para>componentProps Any properties of the component.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string Push = "push";
        /// <summary> 
        /// Removes a component from the navigation stack at the specified index.
        /// <para>(startIndex: number, removeCount?: number, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>startIndex The number to begin removal at.</para>
        /// <para>removeCount The number of components to remove.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string RemoveIndex = "removeIndex";
        /// <summary> 
        /// Set the views of the current navigation stack and navigate to the last view. By default animations are disabled, but they can be enabled by passing options to the navigation controller. Navigation parameters can also be passed to the individual pages in the array.
        /// <para>(views: NavComponent[] | NavComponentWithProps[], opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>views The list of views to set as the navigation stack.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string SetPages = "setPages";
        /// <summary> 
        /// Set the root for the current navigation stack to a component.
        /// <para>&lt;T extends NavComponent&gt;(component: T, componentProps?: ComponentProps&lt;T&gt; | null, opts?: NavOptions | null, done?: TransitionDoneFn) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>component The component to set as the root of the navigation stack.</para>
        /// <para>componentProps Any properties of the component.</para>
        /// <para>opts The navigation options.</para>
        /// <para>done The transition complete function.</para>
        /// </summary>
        public const string SetRoot = "setRoot";
    }
}

public static partial class IonNavControl
{
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
    /// If `true`, the nav should animate the transition of components.
    /// </summary>
    public static void SetAnimated(this PropsBuilder<IonNav> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("animated"), b.Const(true));
    }

    /// <summary>
    /// By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions.
    /// </summary>
    public static void SetAnimation(this PropsBuilder<IonNav> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("animation"), f);
    }
    /// <summary>
    /// By default `ion-nav` animates transition between pages based in the mode (ios or material design). However, this property allows to create custom transition using `AnimationBuilder` functions.
    /// </summary>
    public static void SetAnimation(this PropsBuilder<IonNav> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("animation"), b.Def(f));
    }

    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, Var<Metapsi.Ionic.Function> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("root"), value);
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, Metapsi.Ionic.Function value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("root"), b.Const(value));
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("root"), value);
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("root"), b.Const(value));
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, Var<ViewController> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("root"), value);
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, ViewController value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("root"), b.Const(value));
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("root"), value);
    }
    /// <summary>
    /// Root NavComponent to load
    /// </summary>
    public static void SetRoot(this PropsBuilder<IonNav> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("root"), b.Const(value));
    }

    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public static void SetRootParams(this PropsBuilder<IonNav> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("rootParams"), value);
    }
    /// <summary>
    /// Any parameters for the root component
    /// </summary>
    public static void SetRootParams(this PropsBuilder<IonNav> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("rootParams"), b.Const(value));
    }

    /// <summary>
    /// If the nav component should allow for swipe-to-go-back.
    /// </summary>
    public static void SetSwipeGesture(this PropsBuilder<IonNav> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("swipeGesture"), b.Const(true));
    }

    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<TModel>(this PropsBuilder<IonNav> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionNavDidChange", action);
    }
    /// <summary>
    /// Event fired when the nav has changed components
    /// </summary>
    public static void OnIonNavDidChange<TModel>(this PropsBuilder<IonNav> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionNavDidChange", b.MakeAction(action));
    }

    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<TModel>(this PropsBuilder<IonNav> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onionNavWillChange", action);
    }
    /// <summary>
    /// Event fired when the nav will change components
    /// </summary>
    public static void OnIonNavWillChange<TModel>(this PropsBuilder<IonNav> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onionNavWillChange", b.MakeAction(action));
    }

}

