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
}
