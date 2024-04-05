using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonRoute : IonComponent
{
    public IonRoute() : base("ion-route") { }
    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public System.Func<object> beforeEnter
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object>>("beforeEnter");
        }
        set
        {
            this.GetTag().SetAttribute("beforeEnter", value.ToString());
        }
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public System.Func<object> beforeLeave
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object>>("beforeLeave");
        }
        set
        {
            this.GetTag().SetAttribute("beforeLeave", value.ToString());
        }
    }

    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public string component
    {
        get
        {
            return this.GetTag().GetAttribute<string>("component");
        }
        set
        {
            this.GetTag().SetAttribute("component", value.ToString());
        }
    }

    /// <summary>
    /// A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered.
    /// </summary>
    public object componentProps
    {
        get
        {
            return this.GetTag().GetAttribute<object>("componentProps");
        }
        set
        {
            this.GetTag().SetAttribute("componentProps", value.ToString());
        }
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public string url
    {
        get
        {
            return this.GetTag().GetAttribute<string>("url");
        }
        set
        {
            this.GetTag().SetAttribute("url", value.ToString());
        }
    }

}

public static partial class IonRouteControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRoute(this LayoutBuilder b, Action<PropsBuilder<IonRoute>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-route", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonRoute(this LayoutBuilder b, Action<PropsBuilder<IonRoute>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-route", buildProps, children);
    }
    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter(this PropsBuilder<IonRoute> b, Var<Func<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeEnter"), f);
    }
    /// <summary>
    /// A navigation hook that is fired when the route tries to enter. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeEnter(this PropsBuilder<IonRoute> b, Func<SyntaxBuilder,Var<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeEnter"), b.Def(f));
    }

    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave(this PropsBuilder<IonRoute> b, Var<Func<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeLeave"), f);
    }
    /// <summary>
    /// A navigation hook that is fired when the route tries to leave. Returning `true` allows the navigation to proceed, while returning `false` causes it to be cancelled. Returning a `NavigationHookOptions` object causes the router to redirect to the path specified.
    /// </summary>
    public static void SetBeforeLeave(this PropsBuilder<IonRoute> b, Func<SyntaxBuilder,Var<object>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object>>("beforeLeave"), b.Def(f));
    }

    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonRoute> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// Name of the component to load/select in the navigation outlet (`ion-tabs`, `ion-nav`) when the route matches.  The value of this property is not always the tagname of the component to load, in `ion-tabs` it actually refers to the name of the `ion-tab` to select.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonRoute> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered.
    /// </summary>
    public static void SetComponentProps(this PropsBuilder<IonRoute> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("componentProps"), value);
    }
    /// <summary>
    /// A key value `{ 'red': true, 'blue': 'white'}` containing props that should be passed to the defined component when rendered.
    /// </summary>
    public static void SetComponentProps(this PropsBuilder<IonRoute> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("componentProps"), b.Const(value));
    }

    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl(this PropsBuilder<IonRoute> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("url"), value);
    }
    /// <summary>
    /// Relative path that needs to match in order for this route to apply.  Accepts paths similar to expressjs so that you can define parameters in the url /foo/:bar where bar would be available in incoming props.
    /// </summary>
    public static void SetUrl(this PropsBuilder<IonRoute> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("url"), b.Const(value));
    }

    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<TModel>(this PropsBuilder<IonRoute> b, Var<HyperType.Action<TModel, object>> action)
    {
        b.OnEventAction("onionRouteDataChanged", action, "detail");
    }
    /// <summary>
    /// Used internally by `ion-router` to know when this route did change.
    /// </summary>
    public static void OnIonRouteDataChanged<TModel>(this PropsBuilder<IonRoute> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        b.OnEventAction("onionRouteDataChanged", b.MakeAction(action), "detail");
    }

}

