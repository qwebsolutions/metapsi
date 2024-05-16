using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Html;

public static class HtmlImgExtensions
{
    public static void SetSrc(this AttributesBuilder<HtmlImg> b, string src)
    {
        b.SetAttribute("src", src);
    }

    public static void SetSrc(this PropsBuilder<HtmlImg> b, Var<string> src)
    {
        b.SetAttribute("src", src);
    }

    public static void SetSrc(this PropsBuilder<HtmlImg> b, string src)
    {
        b.SetSrc(b.Const(src));
    }

    public static void SetAlt(this PropsBuilder<HtmlImg> b, Var<string> alt)
    {
        b.SetAttribute("alt", alt);
    }

    public static void SetAlt(this PropsBuilder<HtmlImg> b, string alt)
    {
        b.SetAlt(b.Const(alt));
    }

    public static void SetWidth(this PropsBuilder<HtmlImg> b, int width)
    {
        b.SetAttribute("width", width);
    }

    public static void SetHeight(this PropsBuilder<HtmlImg> b, int height)
    {
        b.SetAttribute("height", height);
    }
}
