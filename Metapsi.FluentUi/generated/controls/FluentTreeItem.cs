using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTreeItem
{
    public static class Slot
    {
    }
}
public static partial class FluentTreeItemExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTreeItem>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-tree-item", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTreeItem>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTreeItem(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTreeItem(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTreeItem(b => { }, children);
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetAppearanceSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle"));
    }
    public static void SetAppearanceTransparent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("transparent"));
    }
    public static void SetAppearanceSubtleAlpha(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle-alpha"));
    }
    public static void SetExpanded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, Metapsi.Syntax.Var<bool> expanded) 
    {
        b.SetProperty(b.Props, b.Const("expanded"), expanded);
    }
    public static void SetExpanded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, bool expanded) 
    {
        b.SetExpanded(b.Const(expanded));
    }
    public static void SetExpanded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetExpanded(b.Const(true));
    }
    public static void SetExpandedChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, Metapsi.Syntax.Var<System.Action<bool, bool>> expandedChanged) 
    {
        b.SetProperty(b.Props, b.Const("expandedChanged"), expandedChanged);
    }
    public static void SetSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, Metapsi.Syntax.Var<bool> selected) 
    {
        b.SetProperty(b.Props, b.Const("selected"), selected);
    }
    public static void SetSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, bool selected) 
    {
        b.SetSelected(b.Const(selected));
    }
    public static void SetSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetSelected(b.Const(true));
    }
    public static void SetEmpty(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, Metapsi.Syntax.Var<bool> empty) 
    {
        b.SetProperty(b.Props, b.Const("empty"), empty);
    }
    public static void SetEmpty(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, bool empty) 
    {
        b.SetEmpty(b.Const(empty));
    }
    public static void SetEmpty(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.SetEmpty(b.Const(true));
    }
    public static void SetDataIndent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, Metapsi.Syntax.Var<int> dataIndent) 
    {
        b.SetProperty(b.Props, b.Const("dataIndent"), dataIndent);
    }
    public static void SetChildTreeItemsChanged(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTreeItem> b, Metapsi.Syntax.Var<System.Action> childTreeItemsChanged) 
    {
        b.SetProperty(b.Props, b.Const("childTreeItemsChanged"), childTreeItemsChanged);
    }
    public static void UpdateSizeAndAppearance(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.Call("updateSizeAndAppearance");
    }
    public static void UpdateChildTreeItems(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.Call("updateChildTreeItems");
    }
    public static void ToggleExpansion(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTreeItem> b) 
    {
        b.Call("toggleExpansion");
    }
}