using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Ui;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTree : SlComponent
{
    public SlTree() : base("sl-tree") { }
    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public string selection
    {
        get
        {
            return this.GetTag().GetAttribute<string>("selection");
        }
        set
        {
            this.GetTag().SetAttribute("selection", value.ToString());
        }
    }

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
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, Var<HyperType.Action<TModel, DomEvent>> action)
    {
        b.OnEventAction("onsl-selection-change", action);
    }
    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-selection-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, Var<HyperType.Action<TModel>> action)
    {
        b.OnEventAction("onsl-selection-change", action);
    }
    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-selection-change", b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, Var<HyperType.Action<TModel, SlSelectionChangeEventArgs>> action)
    {
        b.OnEventAction("onsl-selection-change", action, "detail");
    }
    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<TModel>(this PropsBuilder<SlTree> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectionChangeEventArgs>, Var<TModel>> action)
    {
        b.OnEventAction("onsl-selection-change", b.MakeAction(action), "detail");
    }

}

