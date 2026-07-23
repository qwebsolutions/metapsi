using Metapsi.Html;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;

namespace Metapsi.Web;

public static class MetapsiHttpResult
{
    public static IResult Result(this HtmlDocument htmlDocument, ToHtmlOptions toHtmlOptions = null)
    {
        return Results.Text(htmlDocument.ToHtml(toHtmlOptions), "text/html");
    }

    public static IResult Result(this Metapsi.Syntax.Module module, ToJavaScriptOptions toJavaScriptOptions = null)
    {
        return Results.Text(module.ToJs(toJavaScriptOptions), "text/javascript");
    }

    public static IResult Result(this CssRule cssRule, ToCssOptions options = null)
    {
        return Results.Text(cssRule.ToCss(options), "text/css");
    }

    public static IResult Css(this System.Action<CssBuilder> build, ToCssOptions toCssOptions = null)
    {
        CssBuilder cssBuilder = new CssBuilder();
        build(cssBuilder);
        return cssBuilder.Rule.Result(toCssOptions);
    }
}
