using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentSpinner
{
    public static class Slot
    {
    }
}
public static partial class FluentSpinnerExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentSpinner(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentSpinner>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-spinner", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentSpinner(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentSpinner>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentSpinner(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentSpinner(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentSpinner(b => { }, children);
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetSizeExtraLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("extra-large"));
    }
    public static void SetSizeTiny(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("tiny"));
    }
    public static void SetSizeExtraSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("extra-small"));
    }
    public static void SetSizeHuge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("huge"));
    }
    public static void SetAppearancePrimary(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("primary"));
    }
    public static void SetAppearanceInverted(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentSpinner> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("inverted"));
    }
}