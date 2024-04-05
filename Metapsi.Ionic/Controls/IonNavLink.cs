using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonNavLink : IonComponent
{
    public IonNavLink() : base("ion-nav-link") { }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
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
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
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
    /// The transition animation when navigating to another page.
    /// </summary>
    public System.Func<object,object,Animation> routerAnimation
    {
        get
        {
            return this.GetTag().GetAttribute<System.Func<object,object,Animation>>("routerAnimation");
        }
        set
        {
            this.GetTag().SetAttribute("routerAnimation", value.ToString());
        }
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public string routerDirection
    {
        get
        {
            return this.GetTag().GetAttribute<string>("routerDirection");
        }
        set
        {
            this.GetTag().SetAttribute("routerDirection", value.ToString());
        }
    }

}

public static partial class IonNavLinkControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonNavLink(this LayoutBuilder b, Action<PropsBuilder<IonNavLink>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonNavLink(this LayoutBuilder b, Action<PropsBuilder<IonNavLink>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-nav-link", buildProps, children);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, Var<Metapsi.Ionic.Function> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, Metapsi.Ionic.Function value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(value));
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(value));
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, Var<ViewController> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, ViewController value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<ViewController>("component"), b.Const(value));
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// Component to navigate to. Only used if the `routerDirection` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonNavLink> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps(this PropsBuilder<IonNavLink> b, Var<object> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("componentProps"), value);
    }
    /// <summary>
    /// Data you want to pass to the component as props. Only used if the `"routerDirection"` is `"forward"` or `"root"`.
    /// </summary>
    public static void SetComponentProps(this PropsBuilder<IonNavLink> b, object value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<object>("componentProps"), b.Const(value));
    }

    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonNavLink> b, Var<Func<object,object,Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), f);
    }
    /// <summary>
    /// The transition animation when navigating to another page.
    /// </summary>
    public static void SetRouterAnimation(this PropsBuilder<IonNavLink> b, Func<SyntaxBuilder,Var<object>,Var<object>,Var<Animation>> f)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Func<object,object,Animation>>("routerAnimation"), b.Def(f));
    }

    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionBack(this PropsBuilder<IonNavLink> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("back"));
    }
    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionForward(this PropsBuilder<IonNavLink> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("forward"));
    }
    /// <summary>
    /// The transition direction when navigating to another page.
    /// </summary>
    public static void SetRouterDirectionRoot(this PropsBuilder<IonNavLink> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("routerDirection"), b.Const("root"));
    }

}

