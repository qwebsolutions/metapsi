using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentTree
{
    public static class Slot
    {
    }
}
public static partial class FluentTreeExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTree(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTree>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-tree", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTree(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentTree>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTree(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentTree(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentTree(b => { }, children);
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTree> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTree> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetAppearanceSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTree> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle"));
    }
    public static void SetAppearanceTransparent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTree> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("transparent"));
    }
    public static void SetAppearanceSubtleAlpha(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTree> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle-alpha"));
    }
    public static void SetCurrentSelected(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentTree> b, Metapsi.Syntax.Var<HTMLElement> currentSelected) 
    {
        b.SetProperty(b.Props, b.Const("currentSelected"), currentSelected);
    }
    public static void UpdateSizeAndAppearance(this Metapsi.Syntax.ObjBuilder<Metapsi.FluentUi.FluentTree> b) 
    {
        b.Call("updateSizeAndAppearance");
    }
}