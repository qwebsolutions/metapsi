using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;

namespace Metapsi.Ionic;


public partial class IonTab
{
    public static class Method
    {
        /// <summary>
        /// <para> Set the active component for the tab </para>
        /// <para> () =&gt; Promise&lt;void&gt; </para>
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
        return b.IonicTag("ion-tab", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTab(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.IonicTag("ion-tab", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTab(this HtmlBuilder b, Action<AttributesBuilder<IonTab>> buildAttributes, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-tab", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode IonTab(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.IonicTag("ion-tab", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent(this AttributesBuilder<IonTab> b, string component)
    {
        b.SetAttribute("component", component);
    }

    /// <summary>
    /// <para> A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them. </para>
    /// </summary>
    public static void SetTab(this AttributesBuilder<IonTab> b, string tab)
    {
        b.SetAttribute("tab", tab);
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
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<Metapsi.Ionic.Function> component) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), component);
    }

    /// <summary>
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Metapsi.Ionic.Function component) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<Metapsi.Ionic.Function>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<HTMLElement> component) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), component);
    }

    /// <summary>
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, HTMLElement component) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<HTMLElement>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, Var<string> component) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), component);
    }

    /// <summary>
    /// <para> The component to display inside of the tab. </para>
    /// </summary>
    public static void SetComponent<T>(this PropsBuilder<T> b, string component) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("component"), b.Const(component));
    }


    /// <summary>
    /// <para> A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them. </para>
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, Var<string> tab) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), tab);
    }

    /// <summary>
    /// <para> A tab id must be provided for each `ion-tab`. It's used internally to reference the selected tab or by the router to switch between them. </para>
    /// </summary>
    public static void SetTab<T>(this PropsBuilder<T> b, string tab) where T: IonTab
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("tab"), b.Const(tab));
    }


}

