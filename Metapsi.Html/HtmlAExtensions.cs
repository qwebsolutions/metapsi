using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public static class HtmlAExtensions
{
    public static void SetHref(this PropsBuilder<HtmlA> b, Var<string> href)
    {
        b.SetAttribute("href", href);
    }

    public static void SetHref(this PropsBuilder<HtmlA> b, string href)
    {
        b.SetHref(b.Const(href));
    }

    public static void SetTarget(this PropsBuilder<HtmlA> b, Var<string> target)
    {
        b.SetAttribute("target", target);
    }

    public static void SetTarget(this PropsBuilder<HtmlA> b, string target)
    {
        b.SetTarget(b.Const(target));
    }
}
