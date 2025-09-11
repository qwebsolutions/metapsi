using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentRatingDisplay
{
    public static class Slot
    {
        public const string Icon = "icon";
    }
}
public static partial class FluentRatingDisplayExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentRatingDisplay(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentRatingDisplay>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-rating-display", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentRatingDisplay(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentRatingDisplay>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentRatingDisplay(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentRatingDisplay(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentRatingDisplay(b => { }, children);
    }
    public static void SetColorMarigold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("marigold"));
    }
    public static void SetColorNeutral(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("neutral"));
    }
    public static void SetColorBrand(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetProperty(b.Props, b.Const("color"), b.Const("brand"));
    }
    public static void SetSizeSmall(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("small"));
    }
    public static void SetSizeMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("medium"));
    }
    public static void SetSizeLarge(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("large"));
    }
    public static void SetCompact(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<bool> compact) 
    {
        b.SetProperty(b.Props, b.Const("compact"), compact);
    }
    public static void SetCompact(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, bool compact) 
    {
        b.SetCompact(b.Const(compact));
    }
    public static void SetCompact(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b) 
    {
        b.SetCompact(b.Const(true));
    }
    public static void SetCount(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<int> count) 
    {
        b.SetProperty(b.Props, b.Const("count"), count);
    }
    public static void SetIconViewBox(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<string> iconViewBox) 
    {
        b.SetProperty(b.Props, b.Const("iconViewBox"), iconViewBox);
    }
    public static void SetIconViewBox(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, string iconViewBox) 
    {
        b.SetIconViewBox(b.Const(iconViewBox));
    }
    public static void SetMax(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<decimal> max) 
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }
    public static void SetMax(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<int> max) 
    {
        b.SetProperty(b.Props, b.Const("max"), max);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<decimal> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
    public static void SetValue(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentRatingDisplay> b, Metapsi.Syntax.Var<int> value) 
    {
        b.SetProperty(b.Props, b.Const("value"), value);
    }
}