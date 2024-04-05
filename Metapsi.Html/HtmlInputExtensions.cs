using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public static class HtmlInputExtensions
{
    public static void SetType(this PropsBuilder<HtmlInput> b, string type)
    {
        b.SetType(b.Const(type));
    }

    public static void SetType(this PropsBuilder<HtmlInput> b, Var<string> type)
    {
        b.SetAttribute("type", type);
    }

    public static void SetPlaceholder(this PropsBuilder<HtmlInput> b, Var<string> placeholder)
    {
        b.SetAttribute("placeholder", placeholder);
    }

    public static void SetPlaceholder(this PropsBuilder<HtmlInput> b, string placeholder)
    {
        b.SetPlaceholder(b.Const(placeholder));
    }
}