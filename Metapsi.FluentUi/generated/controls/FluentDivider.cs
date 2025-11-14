using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentDivider
{
    public static class Slot
    {
    }
}
public static partial class FluentDividerExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDivider(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDivider>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-divider", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDivider(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentDivider>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDivider(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentDivider(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentDivider(b => { }, children);
    }
    public static void SetAlignContentStart(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("alignContent"), b.Const("start"));
    }
    public static void SetAlignContentEnd(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("alignContent"), b.Const("end"));
    }
    public static void SetAlignContentCenter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("alignContent"), b.Const("center"));
    }
    public static void SetAppearanceSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle"));
    }
    public static void SetAppearanceBrand(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("brand"));
    }
    public static void SetAppearanceStrong(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("strong"));
    }
    public static void SetInset(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b, Metapsi.Syntax.Var<bool> inset) 
    {
        b.SetProperty(b.Props, b.Const("inset"), inset);
    }
    public static void SetInset(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b, bool inset) 
    {
        b.SetInset(b.Const(inset));
    }
    public static void SetInset(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetInset(b.Const(true));
    }
    public static void SetRoleSeparator(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("role"), b.Const("separator"));
    }
    public static void SetRolePresentation(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("role"), b.Const("presentation"));
    }
    public static void SetOrientationHorizontal(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("horizontal"));
    }
    public static void SetOrientationVertical(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentDivider> b) 
    {
        b.SetProperty(b.Props, b.Const("orientation"), b.Const("vertical"));
    }
}