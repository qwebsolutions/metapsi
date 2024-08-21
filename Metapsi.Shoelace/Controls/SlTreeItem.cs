using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTreeItem
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The icon to show when the tree item is expanded. </para>
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// <para> The icon to show when the tree item is collapsed. </para>
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
    public static class Method
    {
        /// <summary>
        /// <para> Gets all the nested tree items in this node. </para>
        /// </summary>
        public const string GetChildrenItems = "getChildrenItems";
    }
}

public static partial class SlTreeItemControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTreeItem(this HtmlBuilder b, Action<AttributesBuilder<SlTreeItem>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tree-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTreeItem(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tree-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTreeItem(this HtmlBuilder b, Action<AttributesBuilder<SlTreeItem>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tree-item", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTreeItem(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tree-item", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> Expands the tree item. </para>
    /// </summary>
    public static void SetExpanded(this AttributesBuilder<SlTreeItem> b)
    {
        b.SetAttribute("expanded", "");
    }

    /// <summary>
    /// <para> Expands the tree item. </para>
    /// </summary>
    public static void SetExpanded(this AttributesBuilder<SlTreeItem> b, bool expanded)
    {
        if (expanded) b.SetAttribute("expanded", "");
    }

    /// <summary>
    /// <para> Draws the tree item in a selected state. </para>
    /// </summary>
    public static void SetSelected(this AttributesBuilder<SlTreeItem> b)
    {
        b.SetAttribute("selected", "");
    }

    /// <summary>
    /// <para> Draws the tree item in a selected state. </para>
    /// </summary>
    public static void SetSelected(this AttributesBuilder<SlTreeItem> b, bool selected)
    {
        if (selected) b.SetAttribute("selected", "");
    }

    /// <summary>
    /// <para> Disables the tree item. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTreeItem> b)
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Disables the tree item. </para>
    /// </summary>
    public static void SetDisabled(this AttributesBuilder<SlTreeItem> b, bool disabled)
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// <para> Enables lazy loading behavior. </para>
    /// </summary>
    public static void SetLazy(this AttributesBuilder<SlTreeItem> b)
    {
        b.SetAttribute("lazy", "");
    }

    /// <summary>
    /// <para> Enables lazy loading behavior. </para>
    /// </summary>
    public static void SetLazy(this AttributesBuilder<SlTreeItem> b, bool lazy)
    {
        if (lazy) b.SetAttribute("lazy", "");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTreeItem(this LayoutBuilder b, Action<PropsBuilder<SlTreeItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.H("sl-tree-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTreeItem(this LayoutBuilder b, Action<PropsBuilder<SlTreeItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.H("sl-tree-item", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTreeItem(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.H("sl-tree-item", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTreeItem(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.H("sl-tree-item", children);
    }
    /// <summary>
    /// <para> Expands the tree item. </para>
    /// </summary>
    public static void SetExpanded<T>(this PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("expanded"), b.Const(true));
    }


    /// <summary>
    /// <para> Expands the tree item. </para>
    /// </summary>
    public static void SetExpanded<T>(this PropsBuilder<T> b, Var<bool> expanded) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("expanded"), expanded);
    }

    /// <summary>
    /// <para> Expands the tree item. </para>
    /// </summary>
    public static void SetExpanded<T>(this PropsBuilder<T> b, bool expanded) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("expanded"), b.Const(expanded));
    }


    /// <summary>
    /// <para> Draws the tree item in a selected state. </para>
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("selected"), b.Const(true));
    }


    /// <summary>
    /// <para> Draws the tree item in a selected state. </para>
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b, Var<bool> selected) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("selected"), selected);
    }

    /// <summary>
    /// <para> Draws the tree item in a selected state. </para>
    /// </summary>
    public static void SetSelected<T>(this PropsBuilder<T> b, bool selected) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("selected"), b.Const(selected));
    }


    /// <summary>
    /// <para> Disables the tree item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(true));
    }


    /// <summary>
    /// <para> Disables the tree item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, Var<bool> disabled) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), disabled);
    }

    /// <summary>
    /// <para> Disables the tree item. </para>
    /// </summary>
    public static void SetDisabled<T>(this PropsBuilder<T> b, bool disabled) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("disabled"), b.Const(disabled));
    }


    /// <summary>
    /// <para> Enables lazy loading behavior. </para>
    /// </summary>
    public static void SetLazy<T>(this PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("lazy"), b.Const(true));
    }


    /// <summary>
    /// <para> Enables lazy loading behavior. </para>
    /// </summary>
    public static void SetLazy<T>(this PropsBuilder<T> b, Var<bool> lazy) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("lazy"), lazy);
    }

    /// <summary>
    /// <para> Enables lazy loading behavior. </para>
    /// </summary>
    public static void SetLazy<T>(this PropsBuilder<T> b, bool lazy) where T: SlTreeItem
    {
        b.SetDynamic(b.Props, new DynamicProperty<bool>("lazy"), b.Const(lazy));
    }


    /// <summary>
    /// <para> Emitted when the tree item expands. </para>
    /// </summary>
    public static void OnSlExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-expand", action);
    }
    /// <summary>
    /// <para> Emitted when the tree item expands. </para>
    /// </summary>
    public static void OnSlExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-expand", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tree item expands. </para>
    /// </summary>
    public static void OnSlExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-expand", action);
    }
    /// <summary>
    /// <para> Emitted when the tree item expands. </para>
    /// </summary>
    public static void OnSlExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-expand", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tree item expands and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-expand", action);
    }
    /// <summary>
    /// <para> Emitted after the tree item expands and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-expand", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tree item expands and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-expand", action);
    }
    /// <summary>
    /// <para> Emitted after the tree item expands and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterExpand<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-expand", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tree item collapses. </para>
    /// </summary>
    public static void OnSlCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-collapse", action);
    }
    /// <summary>
    /// <para> Emitted when the tree item collapses. </para>
    /// </summary>
    public static void OnSlCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-collapse", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tree item collapses. </para>
    /// </summary>
    public static void OnSlCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-collapse", action);
    }
    /// <summary>
    /// <para> Emitted when the tree item collapses. </para>
    /// </summary>
    public static void OnSlCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-collapse", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tree item collapses and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-collapse", action);
    }
    /// <summary>
    /// <para> Emitted after the tree item collapses and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-collapse", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted after the tree item collapses and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-collapse", action);
    }
    /// <summary>
    /// <para> Emitted after the tree item collapses and all animations are complete. </para>
    /// </summary>
    public static void OnSlAfterCollapse<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-after-collapse", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tree item's lazy state changes. </para>
    /// </summary>
    public static void OnSlLazyChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-change", action);
    }
    /// <summary>
    /// <para> Emitted when the tree item's lazy state changes. </para>
    /// </summary>
    public static void OnSlLazyChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when the tree item's lazy state changes. </para>
    /// </summary>
    public static void OnSlLazyChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-change", action);
    }
    /// <summary>
    /// <para> Emitted when the tree item's lazy state changes. </para>
    /// </summary>
    public static void OnSlLazyChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree. </para>
    /// </summary>
    public static void OnSlLazyLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-load", action);
    }
    /// <summary>
    /// <para> Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree. </para>
    /// </summary>
    public static void OnSlLazyLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-load", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree. </para>
    /// </summary>
    public static void OnSlLazyLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-load", action);
    }
    /// <summary>
    /// <para> Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree. </para>
    /// </summary>
    public static void OnSlLazyLoad<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTreeItem
    {
        b.OnEventAction("onsl-lazy-load", b.MakeAction(action));
    }

}

