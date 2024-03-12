using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Ionic;


public partial class IonTabs
{
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
    public static void OnIonTabsDidChange<TModel>(this PropsBuilder<IonTabs> b, Var<HyperType.Action<TModel, IonTabsIonTabsDidChangeDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<IonTabsIonTabsDidChangeDetail>("detail"));
            return b.MakeActionDescriptor<TModel, IonTabsIonTabsDidChangeDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionTabsDidChange"), eventAction);
    }
    /// <summary>
    /// Emitted when the navigation has finished transitioning to a new component.
    /// </summary>
    public static void OnIonTabsDidChange<TModel>(this PropsBuilder<IonTabs> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonTabsIonTabsDidChangeDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<IonTabsIonTabsDidChangeDetail>("detail"));
            return b.MakeActionDescriptor<TModel, IonTabsIonTabsDidChangeDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionTabsDidChange"), eventAction);
    }

    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<TModel>(this PropsBuilder<IonTabs> b, Var<HyperType.Action<TModel, IonTabsIonTabsWillChangeDetail>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<IonTabsIonTabsWillChangeDetail>("detail"));
            return b.MakeActionDescriptor<TModel, IonTabsIonTabsWillChangeDetail>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionTabsWillChange"), eventAction);
    }
    /// <summary>
    /// Emitted when the navigation is about to transition to a new component.
    /// </summary>
    public static void OnIonTabsWillChange<TModel>(this PropsBuilder<IonTabs> b, System.Func<SyntaxBuilder, Var<TModel>, Var<IonTabsIonTabsWillChangeDetail>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<IonTabsIonTabsWillChangeDetail>("detail"));
            return b.MakeActionDescriptor<TModel, IonTabsIonTabsWillChangeDetail>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onionTabsWillChange"), eventAction);
    }

}

