using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlTreeItem
{
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
    public static class Method
    {
        /// <summary> 
        /// Gets all the nested tree items in this node.
        /// </summary>
        public const string GetChildrenItems = "getChildrenItems";
    }
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
    public static void OnSlExpand<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-expand"), eventAction);
    }
    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-expand"), eventAction);
    }

    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-expand"), eventAction);
    }
    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-expand"), eventAction);
    }

    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-collapse"), eventAction);
    }
    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-collapse"), eventAction);
    }

    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-collapse"), eventAction);
    }
    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-after-collapse"), eventAction);
    }

    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-lazy-change"), eventAction);
    }
    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-lazy-change"), eventAction);
    }

    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<TModel>(this PropsBuilder<SlTreeItem> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-lazy-load"), eventAction);
    }
    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<TModel>(this PropsBuilder<SlTreeItem> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-lazy-load"), eventAction);
    }

}

