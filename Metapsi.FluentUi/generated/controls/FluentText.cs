using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentText
{
    public static class Slot
    {
    }
}
public static partial class FluentTextExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentText(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentText>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-text", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentText(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentText>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentText(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentText(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentText(b => { }, children);
    }
    public static void SetNowrap(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, Metapsi.Syntax.Var<bool> nowrap) 
    {
        b.SetProperty(b.Props, b.Const("nowrap"), nowrap);
    }
    public static void SetNowrap(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, bool nowrap) 
    {
        b.SetNowrap(b.Const(nowrap));
    }
    public static void SetNowrap(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetNowrap(b.Const(true));
    }
    public static void SetTruncate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, Metapsi.Syntax.Var<bool> truncate) 
    {
        b.SetProperty(b.Props, b.Const("truncate"), truncate);
    }
    public static void SetTruncate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, bool truncate) 
    {
        b.SetTruncate(b.Const(truncate));
    }
    public static void SetTruncate(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetTruncate(b.Const(true));
    }
    public static void SetItalic(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, Metapsi.Syntax.Var<bool> italic) 
    {
        b.SetProperty(b.Props, b.Const("italic"), italic);
    }
    public static void SetItalic(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, bool italic) 
    {
        b.SetItalic(b.Const(italic));
    }
    public static void SetItalic(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetItalic(b.Const(true));
    }
    public static void SetUnderline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, Metapsi.Syntax.Var<bool> underline) 
    {
        b.SetProperty(b.Props, b.Const("underline"), underline);
    }
    public static void SetUnderline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, bool underline) 
    {
        b.SetUnderline(b.Const(underline));
    }
    public static void SetUnderline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetUnderline(b.Const(true));
    }
    public static void SetStrikethrough(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, Metapsi.Syntax.Var<bool> strikethrough) 
    {
        b.SetProperty(b.Props, b.Const("strikethrough"), strikethrough);
    }
    public static void SetStrikethrough(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, bool strikethrough) 
    {
        b.SetStrikethrough(b.Const(strikethrough));
    }
    public static void SetStrikethrough(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetStrikethrough(b.Const(true));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, Metapsi.Syntax.Var<bool> block) 
    {
        b.SetProperty(b.Props, b.Const("block"), block);
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b, bool block) 
    {
        b.SetBlock(b.Const(block));
    }
    public static void SetBlock(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetBlock(b.Const(true));
    }
    public static void SetSize100(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("100"));
    }
    public static void SetSize200(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("200"));
    }
    public static void SetSize300(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("300"));
    }
    public static void SetSize400(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("400"));
    }
    public static void SetSize500(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("500"));
    }
    public static void SetSize600(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("600"));
    }
    public static void SetSize700(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("700"));
    }
    public static void SetSize800(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("800"));
    }
    public static void SetSize900(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("900"));
    }
    public static void SetSize1000(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("size"), b.Const("1000"));
    }
    public static void SetFontBase(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("font"), b.Const("base"));
    }
    public static void SetFontNumeric(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("font"), b.Const("numeric"));
    }
    public static void SetFontMonospace(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("font"), b.Const("monospace"));
    }
    public static void SetWeightMedium(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("weight"), b.Const("medium"));
    }
    public static void SetWeightRegular(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("weight"), b.Const("regular"));
    }
    public static void SetWeightSemibold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("weight"), b.Const("semibold"));
    }
    public static void SetWeightBold(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("weight"), b.Const("bold"));
    }
    public static void SetAlignStart(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("align"), b.Const("start"));
    }
    public static void SetAlignEnd(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("align"), b.Const("end"));
    }
    public static void SetAlignCenter(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("align"), b.Const("center"));
    }
    public static void SetAlignJustify(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentText> b) 
    {
        b.SetProperty(b.Props, b.Const("align"), b.Const("justify"));
    }
}