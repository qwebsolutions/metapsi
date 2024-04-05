using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonTab : IonComponent
{
    public IonTab() : base("ion-tab") { }
    /// <summary>
    /// The component to display inside of the tab.
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
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public string tab
    {
        get
        {
            return this.GetTag().GetAttribute<string>("tab");
        }
        set
        {
            this.GetTag().SetAttribute("tab", value.ToString());
        }
    }

    public static class Method
    {
        /// <summary> 
        /// Set the active component for the tab
        /// <para>() =&gt; Promise&lt;void&gt;</para>
        /// </summary>
        public const string SetActive = "setActive";
    }
}

public static partial class IonTabControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTab(this LayoutBuilder b, Action<PropsBuilder<IonTab>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tab", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTab(this LayoutBuilder b, Action<PropsBuilder<IonTab>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tab", buildProps, children);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonTab> b, Var<Metapsi.Ionic.Function> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonTab> b, Metapsi.Ionic.Function value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonTab> b, Var<HTMLElement> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonTab> b, HTMLElement value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonTab> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this PropsBuilder<IonTab> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this PropsBuilder<IonTab> b, Var<string> value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), value);
    }
    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this PropsBuilder<IonTab> b, string value)
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), b.Const(value));
    }

}

