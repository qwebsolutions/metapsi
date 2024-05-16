using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Ionic;


public partial class IonTabs : IonComponent
{
    public IonTabs() : base("ion-tabs") { }
    /// <summary> 
    /// Content is placed between the named slots if provided without a slot.
    /// </summary>
    public static class Slot
    {
        /// <summary> 
        /// Content is placed at the bottom of the screen.
        /// </summary>
        public const string Bottom = "bottom";
        /// <summary> 
        /// Content is placed at the top of the screen.
        /// </summary>
        public const string Top = "top";
    }
    public static class Method
    {
        /// <summary> 
        /// Get the currently selected tab. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// <para>() =&gt; Promise&lt;string | undefined&gt;</para>
        /// </summary>
        public const string GetSelected = "getSelected";
        /// <summary> 
        /// Get a specific tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// <para>(tab: string | HTMLIonTabElement) =&gt; Promise&lt;HTMLIonTabElement | undefined&gt;</para>
        /// <para>tab The tab instance to select. If passed a string, it should be the value of the tab's `tab` property.</para>
        /// </summary>
        public const string GetTab = "getTab";
        /// <summary> 
        /// Select a tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// <para>(tab: string | HTMLIonTabElement) =&gt; Promise&lt;boolean&gt;</para>
        /// <para>tab The tab instance to select. If passed a string, it should be the value of the tab's `tab` property.</para>
        /// </summary>
        public const string Select = "select";
    }
}

public static partial class IonTabsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTabs(this HtmlBuilder b, Action<AttributesBuilder<IonTabs>> buildAttributes, params IHtmlNode[] children)
    {
        return b.Tag("ion-tabs", buildAttributes, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static IHtmlNode IonTabs(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.Tag("ion-tabs", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTabs(this LayoutBuilder b, Action<PropsBuilder<IonTabs>> buildProps, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tabs", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTabs(this LayoutBuilder b, Action<PropsBuilder<IonTabs>> buildProps, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tabs", buildProps, children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTabs(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.IonicNode("ion-tabs", children);
    }
    /// <summary>
    /// 
    /// </summary>
    public static Var<IVNode> IonTabs(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.IonicNode("ion-tabs", children);
    }
    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public class IonTabsIonTabsDidChangeDetail
    {
        public string tab { get; set; }
    }
    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public class IonTabsIonTabsWillChangeDetail
    {
        public string tab { get; set; }
    }
    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, IonTabsIonTabsDidChangeDetail>> action) where TComponent: IonTabs
    {
        b.OnEventAction("onionTabsDidChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonTabsIonTabsDidChangeDetail>, Var<TModel>> action) where TComponent: IonTabs
    {
        b.OnEventAction("onionTabsDidChange", b.MakeAction(action), "detail");
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, IonTabsIonTabsWillChangeDetail>> action) where TComponent: IonTabs
    {
        b.OnEventAction("onionTabsWillChange", action, "detail");
    }
    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonTabsIonTabsWillChangeDetail>, Var<TModel>> action) where TComponent: IonTabs
    {
        b.OnEventAction("onionTabsWillChange", b.MakeAction(action), "detail");
    }

}

