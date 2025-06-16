using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Ionic;

/// <summary>
/// 
/// </summary>
public partial class IonTabs
{
    /// <summary>
    /// 
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
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Get the currently selected tab. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// </summary>
        public const string GetSelected = "getSelected";
        /// <summary>
        /// Get a specific tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// </summary>
        public const string GetTab = "getTab";
        /// <summary>
        /// Select a tab by the value of its `tab` property or an element reference. This method is only available for vanilla JavaScript projects. The Angular, React, and Vue implementations of tabs are coupled to each framework's router.
        /// </summary>
        public const string Select = "select";
    }
}
/// <summary>
/// Setter extensions of IonTabs
/// </summary>
public static partial class IonTabsControl
{
    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTabs>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-tabs", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.IonicTag("ion-tabs", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<IonTabs>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-tabs", buildAttributes, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Html.IHtmlNode IonTabs(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.IonicTag("ion-tabs", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTabs>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-tabs", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.IonicNode("ion-tabs", children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<IonTabs>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-tabs", buildProps, children);
    }

    /// <summary>
    /// 
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> IonTabs(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.IonicNode("ion-tabs", children);
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTabs
    {
        b.SetProperty(b.Props, "onionTabsDidChange", action);
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTabs
    {
        b.SetProperty(b.Props, "onionTabsDidChange", action);
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsDidChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<IonTabsDidChangeDetail>>> action) where T: IonTabs
    {
        b.SetProperty(b.Props, "onionTabsDidChange", action);
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: IonTabs
    {
        b.SetProperty(b.Props, "onionTabsWillChange", action);
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: IonTabs
    {
        b.SetProperty(b.Props, "onionTabsWillChange", action);
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: IonTabs
    {
        b.OnIonTabsWillChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<IonTabsWillChangeDetail>>> action) where T: IonTabs
    {
        b.SetProperty(b.Props, "onionTabsWillChange", action);
    }

}