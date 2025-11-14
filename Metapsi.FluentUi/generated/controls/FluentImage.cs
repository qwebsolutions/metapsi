using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentImage
{
    public static class Slot
    {
    }
}
public static partial class FluentImageExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentImage(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentImage>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-image", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentImage(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentImage>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentImage(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentImage(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentImage(b => { }, children);
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b, Metapsi.Syntax.Var<bool> block) 
    {
        b.SetProperty(b.Props, b.Const("block"), block);
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b, bool block) 
    {
        b.SetBlock(b.Const(block));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetBlock(b.Const(true));
    }
    public static void SetBordered(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b, Metapsi.Syntax.Var<bool> bordered) 
    {
        b.SetProperty(b.Props, b.Const("bordered"), bordered);
    }
    public static void SetBordered(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b, bool bordered) 
    {
        b.SetBordered(b.Const(bordered));
    }
    public static void SetBordered(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetBordered(b.Const(true));
    }
    public static void SetShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b, Metapsi.Syntax.Var<bool> shadow) 
    {
        b.SetProperty(b.Props, b.Const("shadow"), shadow);
    }
    public static void SetShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b, bool shadow) 
    {
        b.SetShadow(b.Const(shadow));
    }
    public static void SetShadow(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetShadow(b.Const(true));
    }
    public static void SetFitCenter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("fit"), b.Const("center"));
    }
    public static void SetFitNone(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("fit"), b.Const("none"));
    }
    public static void SetFitContain(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("fit"), b.Const("contain"));
    }
    public static void SetFitCover(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("fit"), b.Const("cover"));
    }
    public static void SetShapeCircular(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("circular"));
    }
    public static void SetShapeRounded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("rounded"));
    }
    public static void SetShapeSquare(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentImage> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("square"));
    }
}