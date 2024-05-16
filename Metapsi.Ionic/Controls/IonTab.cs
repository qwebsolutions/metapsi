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
    public static IHtmlNode IonTab(this HtmlBuilder b, Action<AttributesBuilder<IonTab>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-tab", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTab(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-tab", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonTab> b, string value)
    {
        b.SetAttribute("component", value);
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab(this AttributesBuilder<IonTab> b, string value)
    {
        b.SetAttribute("tab", value);
    }

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
    /// 
    /// </summary>
    public static Var<IVNode> IonTab(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tab", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTab(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tab", children);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<HTMLElement> value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, HTMLElement value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(value));
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), value);
    }
    /// <summary>
    /// The component to display inside of the tab.
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(value));
    }

    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, Var<string> value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), value);
    }
    /// <summary>
    /// A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them.
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, string value) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), b.Const(value));
    }

}

