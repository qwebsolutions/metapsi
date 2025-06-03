using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
/// </summary>
public partial class SlTree
{
    /// <summary>
    /// 
    /// </summary>
    public static class Slot
    {
        /// <summary>
        /// The icon to show when the tree item is expanded. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string ExpandIcon = "expand-icon";
        /// <summary>
        /// The icon to show when the tree item is collapsed. Works best with `&lt;sl-icon&gt;`.
        /// </summary>
        public const string CollapseIcon = "collapse-icon";
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
    }
}
/// <summary>
/// Setter extensions of SlTree
/// </summary>
public static partial class SlTreeControl
{
    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTree(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTree>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tree", buildAttributes, children);
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTree(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tree", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTree(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTree>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tree", buildAttributes, children);
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTree(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tree", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionSingle(this Metapsi.Html.AttributesBuilder<SlTree> b) 
    {
        b.SetAttribute("selection", "single");
    }

    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionMultiple(this Metapsi.Html.AttributesBuilder<SlTree> b) 
    {
        b.SetAttribute("selection", "multiple");
    }

    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionLeaf(this Metapsi.Html.AttributesBuilder<SlTree> b) 
    {
        b.SetAttribute("selection", "leaf");
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTree(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTree>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tree", buildProps, children);
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTree(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tree", children);
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTree(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTree>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tree", buildProps, children);
    }

    /// <summary>
    /// Trees allow you to display a hierarchical list of selectable [tree items](/components/tree-item). Items with children can be expanded and collapsed as desired by the user.
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTree(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tree", children);
    }

    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionSingle<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTree
    {
        b.SetProperty(b.Props, b.Const("selection"), b.Const("single"));
    }

    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionMultiple<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTree
    {
        b.SetProperty(b.Props, b.Const("selection"), b.Const("multiple"));
    }

    /// <summary>
    /// The selection behavior of the tree. Single selection allows only one node to be selected at a time. Multiple displays checkboxes and allows more than one node to be selected. Leaf allows only leaf nodes to be selected.
    /// </summary>
    public static void SetSelectionLeaf<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTree
    {
        b.SetProperty(b.Props, b.Const("selection"), b.Const("leaf"));
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTree
    {
        b.OnSlEvent("onsl-selection-change", action);
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTree
    {
        b.OnSlSelectionChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTree
    {
        b.OnSlEvent("onsl-selection-change", action);
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTree
    {
        b.OnSlSelectionChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a tree item is selected or deselected.
    /// </summary>
    public static void OnSlSelectionChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.CustomEvent<SlSelectionChangeDetail>>> action) where T: SlTree
    {
        b.OnSlEvent("onsl-selection-change", action);
    }

}