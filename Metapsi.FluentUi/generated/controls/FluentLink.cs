using Metapsi.Syntax;
using Metapsi.Html;

namespace Metapsi.FluentUi;

public partial interface FluentLink
{
    public static class Slot
    {
        public const string Start = "start";
        public const string End = "end";
    }
}
public static partial class FluentLinkExtensions
{
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentLink(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentLink>> buildProps, Metapsi.Syntax.Var<System.Collections.Generic.List<Metapsi.Hyperapp.IVNode>> children) 
    {
        return b.FluentNode("fluent-link", buildProps, children);
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentLink(this Metapsi.Hyperapp.LayoutBuilder b, System.Action<Metapsi.Syntax.PropsBuilder<FluentLink>> buildProps, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentLink(buildProps, b.List(children));
    }
    public static Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode> FluentLink(this Metapsi.Hyperapp.LayoutBuilder b, params Metapsi.Syntax.Var<Metapsi.Hyperapp.IVNode>[] children) 
    {
        return b.FluentLink(b => { }, children);
    }
    public static void SetAppearanceSubtle(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b) 
    {
        b.SetProperty(b.Props, b.Const("appearance"), b.Const("subtle"));
    }
    public static void SetInline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<bool> inline) 
    {
        b.SetProperty(b.Props, b.Const("inline"), inline);
    }
    public static void SetInline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, bool inline) 
    {
        b.SetInline(b.Const(inline));
    }
    public static void SetInline(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b) 
    {
        b.SetInline(b.Const(true));
    }
    public static void SetDownload(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> download) 
    {
        b.SetProperty(b.Props, b.Const("download"), download);
    }
    public static void SetDownload(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string download) 
    {
        b.SetDownload(b.Const(download));
    }
    public static void SetHref(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> href) 
    {
        b.SetProperty(b.Props, b.Const("href"), href);
    }
    public static void SetHref(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string href) 
    {
        b.SetHref(b.Const(href));
    }
    public static void SetHreflang(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> hreflang) 
    {
        b.SetProperty(b.Props, b.Const("hreflang"), hreflang);
    }
    public static void SetHreflang(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string hreflang) 
    {
        b.SetHreflang(b.Const(hreflang));
    }
    public static void SetPing(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> ping) 
    {
        b.SetProperty(b.Props, b.Const("ping"), ping);
    }
    public static void SetPing(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string ping) 
    {
        b.SetPing(b.Const(ping));
    }
    public static void SetReferrerpolicy(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> referrerpolicy) 
    {
        b.SetProperty(b.Props, b.Const("referrerpolicy"), referrerpolicy);
    }
    public static void SetReferrerpolicy(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string referrerpolicy) 
    {
        b.SetReferrerpolicy(b.Const(referrerpolicy));
    }
    public static void SetRel(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> rel) 
    {
        b.SetProperty(b.Props, b.Const("rel"), rel);
    }
    public static void SetRel(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string rel) 
    {
        b.SetRel(b.Const(rel));
    }
    public static void SetTarget_blank(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b) 
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_blank"));
    }
    public static void SetTarget_self(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b) 
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_self"));
    }
    public static void SetTarget_parent(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b) 
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_parent"));
    }
    public static void SetTarget_top(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b) 
    {
        b.SetProperty(b.Props, b.Const("target"), b.Const("_top"));
    }
    public static void SetType(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<string> type) 
    {
        b.SetProperty(b.Props, b.Const("type"), type);
    }
    public static void SetType(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, string type) 
    {
        b.SetType(b.Const(type));
    }
    public static void SetKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<System.Func<KeyboardEvent, bool>> keydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("keydownHandler"), keydownHandler);
    }
    public static void SetKeydownHandler(this Metapsi.Syntax.PropsBuilder<Metapsi.FluentUi.FluentLink> b, Metapsi.Syntax.Var<System.Action<KeyboardEvent>> keydownHandler) 
    {
        b.SetProperty(b.Props, b.Const("keydownHandler"), keydownHandler);
    }
}