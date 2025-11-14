using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentCounterBadge
{
    public static class Slot
    {
    }
}
public static partial class FluentCounterBadgeExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCounterBadge(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentCounterBadge>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-counter-badge", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCounterBadge(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentCounterBadge>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentCounterBadge(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentCounterBadge(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentCounterBadge(b => { }, children);
    }
    public static void SetAppearanceFilled(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("filled"));
    }
    public static void SetAppearanceGhost(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("ghost"));
    }
    public static void SetColorSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("subtle"));
    }
    public static void SetColorBrand(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("brand"));
    }
    public static void SetColorDanger(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("danger"));
    }
    public static void SetColorImportant(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("important"));
    }
    public static void SetColorInformative(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("informative"));
    }
    public static void SetColorSevere(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("severe"));
    }
    public static void SetColorSuccess(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("success"));
    }
    public static void SetColorWarning(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("warning"));
    }
    public static void SetShapeCircular(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("circular"));
    }
    public static void SetShapeRounded(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("shape"), b.Const("rounded"));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetSizeExtraLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("extra-large"));
    }
    public static void SetSizeTiny(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("tiny"));
    }
    public static void SetSizeExtraSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("extra-small"));
    }
    public static void SetCount(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b, Metapsi.Syntax.Var<int> count) 
    {
        b.SetProperty(b.Props, b.Const("count"), count);
    }
    public static void SetOverflowCount(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b, Metapsi.Syntax.Var<int> overflowCount) 
    {
        b.SetProperty(b.Props, b.Const("overflowCount"), overflowCount);
    }
    public static void SetShowZero(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b, Metapsi.Syntax.Var<bool> showZero) 
    {
        b.SetProperty(b.Props, b.Const("showZero"), showZero);
    }
    public static void SetShowZero(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b, bool showZero) 
    {
        b.SetShowZero(b.Const(showZero));
    }
    public static void SetShowZero(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetShowZero(b.Const(true));
    }
    public static void SetDot(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b, Metapsi.Syntax.Var<bool> dot) 
    {
        b.SetProperty(b.Props, b.Const("dot"), dot);
    }
    public static void SetDot(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b, bool dot) 
    {
        b.SetDot(b.Const(dot));
    }
    public static void SetDot(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentCounterBadge> b) 
    {
        b.SetDot(b.Const(true));
    }
}