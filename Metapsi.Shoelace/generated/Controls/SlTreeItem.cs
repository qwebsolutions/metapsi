using Metapsi.Html;
using Metapsi.Syntax;
using Metapsi.Hyperapp;

namespace Metapsi.Shoelace;

/// <summary>
/// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
/// </summary>
public partial class SlTreeItem
{
    /// <summary>
    /// 
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public static class Method
    {
        /// <summary>
        /// Gets all the nested tree items in this node.
        /// </summary>
        public const string GetChildrenItems = "getChildrenItems";
    }
}
/// <summary>
/// Setter extensions of SlTreeItem
/// </summary>
public static partial class SlTreeItemControl
{
    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTreeItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTreeItem>> buildAttributes, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tree-item", buildAttributes, children);
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTreeItem(this Metapsi.Html.HtmlBuilder b, params Metapsi.Html.IHtmlNode[] children) 
    {
        return b.SlTag("sl-tree-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTreeItem(this Metapsi.Html.HtmlBuilder b, System.Action<Metapsi.Html.AttributesBuilder<SlTreeItem>> buildAttributes, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tree-item", buildAttributes, children);
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Html.IHtmlNode SlTreeItem(this Metapsi.Html.HtmlBuilder b, System.Collections.Generic.List<Metapsi.Html.IHtmlNode> children) 
    {
        return b.SlTag("sl-tree-item", new System.Collections.Generic.Dictionary<string, string>(), children);
    }

    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static void SetExpanded(this Metapsi.Html.AttributesBuilder<SlTreeItem> b, bool expanded) 
    {
        if (expanded) b.SetAttribute("expanded", "");
    }

    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static void SetExpanded(this Metapsi.Html.AttributesBuilder<SlTreeItem> b) 
    {
        b.SetAttribute("expanded", "");
    }

    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static void SetSelected(this Metapsi.Html.AttributesBuilder<SlTreeItem> b, bool selected) 
    {
        if (selected) b.SetAttribute("selected", "");
    }

    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static void SetSelected(this Metapsi.Html.AttributesBuilder<SlTreeItem> b) 
    {
        b.SetAttribute("selected", "");
    }

    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTreeItem> b, bool disabled) 
    {
        if (disabled) b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static void SetDisabled(this Metapsi.Html.AttributesBuilder<SlTreeItem> b) 
    {
        b.SetAttribute("disabled", "");
    }

    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static void SetLazy(this Metapsi.Html.AttributesBuilder<SlTreeItem> b, bool lazy) 
    {
        if (lazy) b.SetAttribute("lazy", "");
    }

    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static void SetLazy(this Metapsi.Html.AttributesBuilder<SlTreeItem> b) 
    {
        b.SetAttribute("lazy", "");
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTreeItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tree-item", buildProps, children);
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.SlNode("sl-tree-item", children);
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<SlTreeItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tree-item", buildProps, children);
    }

    /// <summary>
    /// A tree item serves as a hierarchical node that lives inside a [tree](/components/tree).
    /// </summary>
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> SlTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.SlNode("sl-tree-item", children);
    }

    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static void SetExpanded<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetExpanded(b.Const(true));
    }

    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static void SetExpanded<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> expanded) where T: SlTreeItem
    {
        b.SetProperty(b.Props, b.Const("expanded"), expanded);
    }

    /// <summary>
    /// Expands the tree item.
    /// </summary>
    public static void SetExpanded<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool expanded) where T: SlTreeItem
    {
        b.SetExpanded(b.Const(expanded));
    }

    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static void SetSelected<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetSelected(b.Const(true));
    }

    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static void SetSelected<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> selected) where T: SlTreeItem
    {
        b.SetProperty(b.Props, b.Const("selected"), selected);
    }

    /// <summary>
    /// Draws the tree item in a selected state.
    /// </summary>
    public static void SetSelected<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool selected) where T: SlTreeItem
    {
        b.SetSelected(b.Const(selected));
    }

    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetDisabled(b.Const(true));
    }

    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> disabled) where T: SlTreeItem
    {
        b.SetProperty(b.Props, b.Const("disabled"), disabled);
    }

    /// <summary>
    /// Disables the tree item.
    /// </summary>
    public static void SetDisabled<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool disabled) where T: SlTreeItem
    {
        b.SetDisabled(b.Const(disabled));
    }

    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static void SetLazy<T>(this Metapsi.Syntax.PropsBuilder<T> b) where T: SlTreeItem
    {
        b.SetLazy(b.Const(true));
    }

    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static void SetLazy<T>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<bool> lazy) where T: SlTreeItem
    {
        b.SetProperty(b.Props, b.Const("lazy"), lazy);
    }

    /// <summary>
    /// Enables lazy loading behavior.
    /// </summary>
    public static void SetLazy<T>(this Metapsi.Syntax.PropsBuilder<T> b, bool lazy) where T: SlTreeItem
    {
        b.SetLazy(b.Const(lazy));
    }

    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-expand", action);
    }

    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlExpand(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-expand", action);
    }

    /// <summary>
    /// Emitted when the tree item expands.
    /// </summary>
    public static void OnSlExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlExpand(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-after-expand", action);
    }

    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlAfterExpand(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-after-expand", action);
    }

    /// <summary>
    /// Emitted after the tree item expands and all animations are complete.
    /// </summary>
    public static void OnSlAfterExpand<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlAfterExpand(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-collapse", action);
    }

    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlCollapse(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-collapse", action);
    }

    /// <summary>
    /// Emitted when the tree item collapses.
    /// </summary>
    public static void OnSlCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlCollapse(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-after-collapse", action);
    }

    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlAfterCollapse(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-after-collapse", action);
    }

    /// <summary>
    /// Emitted after the tree item collapses and all animations are complete.
    /// </summary>
    public static void OnSlAfterCollapse<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlAfterCollapse(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-lazy-change", action);
    }

    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlLazyChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-lazy-change", action);
    }

    /// <summary>
    /// Emitted when the tree item's lazy state changes.
    /// </summary>
    public static void OnSlLazyChange<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlLazyChange(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel, Metapsi.Html.Event>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-lazy-load", action);
    }

    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<Metapsi.Html.Event>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlLazyLoad(b.MakeAction(action));
    }

    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, Metapsi.Syntax.Var<Metapsi.Hyperapp.HyperType.Action<TModel>> action) where T: SlTreeItem
    {
        b.OnSlEvent("onsl-lazy-load", action);
    }

    /// <summary>
    /// Emitted when a lazy item is selected. Use this event to asynchronously load data and append items to the tree before expanding. After appending new items, remove the `lazy` attribute to remove the loading state and update the tree.
    /// </summary>
    public static void OnSlLazyLoad<T,TModel>(this Metapsi.Syntax.PropsBuilder<T> b, System.Func<Metapsi.Syntax.SyntaxBuilder, Metapsi.Syntax.Var<TModel>, Metapsi.Syntax.Var<TModel>> action) where T: SlTreeItem
    {
        b.OnSlLazyLoad(b.MakeAction(action));
    }

}