using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;

namespace Metapsi.Shoelace;


public partial class SlTree
{
    public static class Slot
    {
        /// <summary> 
        /// The icon to show when the tree item is expanded. Works best with `<sl-icon>`.
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary> 
        /// The icon to show when the tree item is collapsed. Works best with `<sl-icon>`.
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
}

public static partial class SlTreeControl
{
    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Var<IVNode> SlTree(this LayoutBuilder b, Action<PropsBuilder<SlTree>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tree", buildProps, children);
    }
    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Var<IVNode> SlTree(this LayoutBuilder b, Action<PropsBuilder<SlTree>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tree", buildProps, children);
    }
    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionSingle(this PropsBuilder<SlTree> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("selection"), b.Const("single"));
    }
    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionMultiple(this PropsBuilder<SlTree> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("selection"), b.Const("multiple"));
    }
    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionLeaf(this PropsBuilder<SlTree> b)
    {
        b.SetDynamic(b.Props, DynamicProperty.String("selection"), b.Const("leaf"));
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, Var<HyperType.Action<TModel, object>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(action, value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-selection-change"), eventAction);
    }
    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, System.Func<SyntaxBuilder, Var<TModel>, Var<object>, Var<TModel>> action)
    {
        var eventAction = b.MakeAction<TModel, object>((SyntaxBuilder b, Var<TModel> state, Var<object> eventArgs) =>
        {
            var value = b.GetDynamic(eventArgs, new DynamicProperty<object>("detail"));
            return b.MakeActionDescriptor<TModel, object>(b.MakeAction(action), value);
        });
        b.SetDynamic(b.Props, new DynamicProperty<HyperType.Action<TModel, object>>("onsl-selection-change"), eventAction);
    }

}

