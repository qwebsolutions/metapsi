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

    public static IResult Result(this Metapsi.Syntax.Module module, Metapsi.IJsonSerializer jsonSerializer, ToJavaScriptOptions toJavaScriptOptions)
    {
        return Results.Text(module.ToJs(jsonSerializer, toJavaScriptOptions), "text/javascript");
    }

    public static IResult Result(this Metapsi.Syntax.Module module, Metapsi.IJsonSerializer jsonSerializer = null)
    {
        if (jsonSerializer == null) jsonSerializer = WebServerExtensions.DefaultToHtmlOptions.JsonSerializer;
        return module.Result(jsonSerializer, WebServerExtensions.DefaultToHtmlOptions.ToJavaScriptOptions);
    }

    public static IResult Result(this CssRule cssRule, ToCssOptions options)
    {
        return Results.Text(cssRule.ToCss(options), "text/css");
    }

    public static IResult Result(this CssRule cssRule)
    {
        return cssRule.Result(WebServerExtensions.DefaultToHtmlOptions.ToCssOptions);
    }

    public static IResult Css(this System.Action<CssBuilder> build, IResourceResolver resolver, ToCssOptions toCssOptions = null)
    {
        if (toCssOptions == null) toCssOptions = WebServerExtensions.DefaultToHtmlOptions.ToCssOptions;

        CssBuilder cssBuilder = new CssBuilder(resolver);
        build(cssBuilder);
        return cssBuilder.Rule.Result(toCssOptions);
    }
}
