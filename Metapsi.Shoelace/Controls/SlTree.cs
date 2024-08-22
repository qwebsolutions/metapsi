using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using Metapsi.Html;
using Metapsi.Dom;

namespace Metapsi.Shoelace;


public partial class SlTree
{
    /// <summary>
    ///
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// <para> The icon to show when the tree item is expanded. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// <para> The icon to show when the tree item is collapsed. Works best with `&lt;sl-icon&gt;`. </para>
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
}

public static partial class SlTreeControl
{
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTree(this HtmlBuilder b, Action<AttributesBuilder<SlTree>> buildAttributes, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tree", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTree(this HtmlBuilder b, params IHtmlNode[] children)
    {
        return b.SlTag("sl-tree", new Dictionary<string, string>(), children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTree(this HtmlBuilder b, Action<AttributesBuilder<SlTree>> buildAttributes, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tree", buildAttributes, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static IHtmlNode SlTree(this HtmlBuilder b, List<IHtmlNode> children)
    {
        return b.SlTag("sl-tree", new Dictionary<string, string>(), children);
    }
    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelection(this AttributesBuilder<SlTree> b, string selection)
    {
        b.SetAttribute("selection", selection);
    }

    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelectionSingle(this AttributesBuilder<SlTree> b)
    {
        b.SetAttribute("selection", "single");
    }

    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelectionMultiple(this AttributesBuilder<SlTree> b)
    {
        b.SetAttribute("selection", "multiple");
    }

    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelectionLeaf(this AttributesBuilder<SlTree> b)
    {
        b.SetAttribute("selection", "leaf");
    }

    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTree(this LayoutBuilder b, Action<PropsBuilder<SlTree>> buildProps, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tree", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTree(this LayoutBuilder b, Action<PropsBuilder<SlTree>> buildProps, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tree", buildProps, children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTree(this LayoutBuilder b, Var<List<IVNode>> children)
    {
        return b.SlNode("sl-tree", children);
    }
    /// <summary>
    ///
    /// </summary>
    public static Var<IVNode> SlTree(this LayoutBuilder b, params Var<IVNode>[] children)
    {
        return b.SlNode("sl-tree", children);
    }
    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelectionSingle<T>(this PropsBuilder<T> b) where T: SlTree
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selection"), b.Const("single"));
    }


    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelectionMultiple<T>(this PropsBuilder<T> b) where T: SlTree
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selection"), b.Const("multiple"));
    }


    /// <summary>
    /// <para> The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected. </para>
    /// </summary>
    public static void SetSelectionLeaf<T>(this PropsBuilder<T> b) where T: SlTree
    {
        b.SetDynamic(b.Props, new DynamicProperty<string>("selection"), b.Const("leaf"));
    }


    /// <summary>
    /// <para> Emitted when a tree item is selected or deselected. </para>
    /// </summary>
    public static void OnSlSelectionChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, DomEvent>> action) where TComponent: SlTree
    {
        b.OnEventAction("onsl-selection-change", action);
    }
    /// <summary>
    /// <para> Emitted when a tree item is selected or deselected. </para>
    /// </summary>
    public static void OnSlSelectionChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<DomEvent>, Var<TModel>> action) where TComponent: SlTree
    {
        b.OnEventAction("onsl-selection-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a tree item is selected or deselected. </para>
    /// </summary>
    public static void OnSlSelectionChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel>> action) where TComponent: SlTree
    {
        b.OnEventAction("onsl-selection-change", action);
    }
    /// <summary>
    /// <para> Emitted when a tree item is selected or deselected. </para>
    /// </summary>
    public static void OnSlSelectionChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<TModel>> action) where TComponent: SlTree
    {
        b.OnEventAction("onsl-selection-change", b.MakeAction(action));
    }

    /// <summary>
    /// <para> Emitted when a tree item is selected or deselected. </para>
    /// </summary>
    public static void OnSlSelectionChange<TComponent, TModel>(this PropsBuilder<TComponent> b, Var<HyperType.Action<TModel, SlSelectionChangeEventArgs>> action) where TComponent: SlTree
    {
        b.OnEventAction("onsl-selection-change", action, "detail");
    }
    /// <summary>
    /// <para> Emitted when a tree item is selected or deselected. </para>
    /// </summary>
    public static void OnSlSelectionChange<TComponent, TModel>(this PropsBuilder<TComponent> b, System.Func<SyntaxBuilder, Var<TModel>, Var<SlSelectionChangeEventArgs>, Var<TModel>> action) where TComponent: SlTree
    {
        b.OnEventAction("onsl-selection-change", b.MakeAction(action), "detail");
    }

}

