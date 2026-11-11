using Metapsi.Html;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;

namespace Metapsi.Web;

public static class MetapsiHttpResult
{
    public static IResult Result(this HtmlDocument htmlDocument, ToHtmlOptions toHtmlOptions)
    {
        return Results.Text(htmlDocument.ToHtml(toHtmlOptions), "text/html");
    }

    public static IResult Result(this HtmlDocument htmlDocument)
    {
        return htmlDocument.Result(WebServerExtensions.DefaultToHtmlOptions);
    }

    public static IResult Result(this Metapsi.Syntax.Module module, ToJavaScriptOptions toJavaScriptOptions)
    {
        return Results.Text(module.ToJs(toJavaScriptOptions), "text/javascript");
    }

    public static IResult Result(this Metapsi.Syntax.Module module)
    {
        return module.Result(WebServerExtensions.DefaultToJavaScriptOptions);
    }

    public static IResult Result(this CssRule cssRule, ToCssOptions options)
    {
        return Results.Text(cssRule.ToCss(options), "text/css");
    }

    public static IResult Result(this CssRule cssRule)
    {
        return cssRule.Result(WebServerExtensions.DefaultToCssOptions);
    }

    public static IResult Css(this System.Action<CssBuilder> build, ToCssOptions toCssOptions = null)
    {
        if (toCssOptions == null) toCssOptions = WebServerExtensions.DefaultToCssOptions;

        CssBuilder cssBuilder = new CssBuilder();
        build(cssBuilder);
        return cssBuilder.Rule.Result(toCssOptions);
    }
}
