using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using System.ComponentModel;

namespace Metapsi.Shoelace;


public partial interface IClientSideSlTreeItem
{
}
public partial class SlTreeItemExpandArgs
{
    public IClientSideSlTreeItem target { get; set; }
}
public partial class SlTreeItemAfterExpandArgs
{
    public IClientSideSlTreeItem target { get; set; }
}
public partial class SlTreeItemCollapseArgs
{
    public IClientSideSlTreeItem target { get; set; }
}
public partial class SlTreeItemAfterCollapseArgs
{
    public IClientSideSlTreeItem target { get; set; }
}
public partial class SlTreeItemLazyChangeArgs
{
    public IClientSideSlTreeItem target { get; set; }
}
public partial class SlTreeItemLazyLoadArgs
{
    public IClientSideSlTreeItem target { get; set; }
}
public static partial class SlTreeItemControl
{
    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Var<IVNode> SlTreeItem(this LayoutBuilder b, Action<PropsBuilder<SlTreeItem>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tree-item", buildProps, children);
    }
    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Var<IVNode> SlTreeItem(this LayoutBuilder b, Action<PropsBuilder<SlTreeItem>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tree-item", buildProps, children);
    }
    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static void SetExpanded(this PropsBuilder<SlTreeItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("expanded"), b.Const(true));
    }
    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static void SetSelected(this PropsBuilder<SlTreeItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("selected"), b.Const(true));
    }
    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static void SetDisabled(this PropsBuilder<SlTreeItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("disabled"), b.Const(true));
    }
    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static void SetLazy(this PropsBuilder<SlTreeItem> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.Bool("lazy"), b.Const(true));
    }
    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, SlTreeItemExpandArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemExpandArgs>>("onsl-expand"), action);
    }
    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTreeItemExpandArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemExpandArgs>>("onsl-expand"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, SlTreeItemAfterExpandArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemAfterExpandArgs>>("onsl-after-expand"), action);
    }
    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTreeItemAfterExpandArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemAfterExpandArgs>>("onsl-after-expand"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, SlTreeItemCollapseArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemCollapseArgs>>("onsl-collapse"), action);
    }
    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTreeItemCollapseArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemCollapseArgs>>("onsl-collapse"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, SlTreeItemAfterCollapseArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemAfterCollapseArgs>>("onsl-after-collapse"), action);
    }
    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTreeItemAfterCollapseArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemAfterCollapseArgs>>("onsl-after-collapse"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, SlTreeItemLazyChangeArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemLazyChangeArgs>>("onsl-lazy-change"), action);
    }
    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTreeItemLazyChangeArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemLazyChangeArgs>>("onsl-lazy-change"), b.MakeAction(action));
    }
    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, SlTreeItemLazyLoadArgs>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemLazyLoadArgs>>("onsl-lazy-load"), action);
    }
    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlTreeItemLazyLoadArgs>, Var<TModel>> action)
    {
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, SlTreeItemLazyLoadArgs>>("onsl-lazy-load"), b.MakeAction(action));
    }
}

/// <summary>
/// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
/// </summary>
public partial class SlTreeItem : HtmlTag
{
    public SlTreeItem()
    {
        this.Tag = "sl-tree-item";
    }

    public static SlTreeItem New()
    {
        return new SlTreeItem();
    }
    public static class Slot
    {
        /// <summary> 
        /// The icon to show when the tree item is expanded.
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary> 
        /// The icon to show when the tree item is collapsed.
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
}

public static partial class SlTreeItemControl
{
    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static SlTreeItem SetExpanded(this SlTreeItem tag)
    {
        return tag.SetAttribute("expanded", "true");
    }
    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static SlTreeItem SetSelected(this SlTreeItem tag)
    {
        return tag.SetAttribute("selected", "true");
    }
    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static SlTreeItem SetDisabled(this SlTreeItem tag)
    {
        return tag.SetAttribute("disabled", "true");
    }
    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static SlTreeItem SetLazy(this SlTreeItem tag)
    {
        return tag.SetAttribute("lazy", "true");
    }
}

