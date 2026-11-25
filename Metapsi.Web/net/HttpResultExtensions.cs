using Metapsi.Html;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Metapsi.Web;

public static class MetapsiResult
{
    //public static IResult Result(this HtmlDocument htmlDocument, ToHtmlOptions toHtmlOptions)
    //{
    //    return Results.Text(htmlDocument.ToHtml(toHtmlOptions), "text/html");
    //}

    //public static IResult Result(this HtmlDocument htmlDocument)
    //{
    //    return htmlDocument.Result(WebServerExtensions.DefaultToHtmlOptions);
    //}

    //public static IResult Result(this Metapsi.Syntax.Module module, Metapsi.IJsonSerializer jsonSerializer, ToJavaScriptOptions toJavaScriptOptions)
    //{
    //    return Results.Text(module.ToJs(jsonSerializer, toJavaScriptOptions), "text/javascript");
    //}

    //public static IResult Result(this Metapsi.Syntax.Module module, Metapsi.IJsonSerializer jsonSerializer = null)
    //{
    //    if (jsonSerializer == null) jsonSerializer = WebServerExtensions.DefaultToHtmlOptions.JsonSerializer;
    //    return module.Result(jsonSerializer, WebServerExtensions.DefaultToHtmlOptions.ToJavaScriptOptions);
    //}

    //public static IResult Result(this CssRule cssRule, ToCssOptions options)
    //{
    //    return Results.Text(cssRule.ToCss(options), "text/css");
    //}

    //public static IResult Result(this CssRule cssRule)
    //{
    //    return cssRule.Result(WebServerExtensions.DefaultToHtmlOptions.ToCssOptions);
    //}

    public static IResult Html(System.Action<HtmlBuilder> b, ToHtmlOptions toHtmlOptions)
    {
        if (toHtmlOptions == null)
        {
            throw new ArgumentNullException(nameof(toHtmlOptions));
        }
        return new MetapsiHtmlBuilderResult(b, toHtmlOptions);
    }

    public static IResult Html(System.Action<HtmlBuilder> build)
    {
        return Html(build, WebServerExtensions.DefaultToHtmlOptions);
    }

    public static IResult Js(System.Action<ModuleBuilder> build, ToJavaScriptOptions toJavaScriptOptions)
    {
        if (toJavaScriptOptions == null)
        {
            throw new ArgumentNullException(nameof(toJavaScriptOptions));
        }
        return new MetapsiJsBuilderResult(build, WebServerExtensions.DefaultToHtmlOptions.JsonSerializer, toJavaScriptOptions);
    }

    public static IResult Js(System.Action<ModuleBuilder> build)
    {
        return Js(build, WebServerExtensions.DefaultToHtmlOptions.ToJavaScriptOptions);
    }

    public static IResult Css(System.Action<CssBuilder> build, ToCssOptions toCssOptions)
    {
        if (toCssOptions == null)
        {
            throw new ArgumentNullException(nameof(toCssOptions));
        }
        return new MetapsiCssBuilderResult(build, toCssOptions);
    }

    public static IResult Css(System.Action<CssBuilder> build)
    {
        return Css(build, WebServerExtensions.DefaultToHtmlOptions.ToCssOptions);
    }
}

internal class MetapsiHtmlBuilderResult : IResult
{
    private readonly Action<HtmlBuilder> build;
    private readonly ToHtmlOptions toHtmlOptions;

    public MetapsiHtmlBuilderResult(System.Action<HtmlBuilder> build, ToHtmlOptions toHtmlOptions)
    {
        this.build = build;
        this.toHtmlOptions = toHtmlOptions;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        var resolver = httpContext.GetResourceResolver();
        var document = HtmlBuilder.FromDefault(resolver, build);
        await httpContext.WriteHtmlDocumentResponse(document, toHtmlOptions);
    }
}

internal class MetapsiJsBuilderResult: IResult
{
    private readonly Action<ModuleBuilder> build;
    private readonly IJsonSerializer jsonSerializer;
    private readonly ToJavaScriptOptions toJavaScriptOptions;

    public MetapsiJsBuilderResult(System.Action<ModuleBuilder> build, IJsonSerializer jsonSerializer, ToJavaScriptOptions toJavaScriptOptions)
    {
        this.build = build;
        this.jsonSerializer = jsonSerializer;
        this.toJavaScriptOptions = toJavaScriptOptions;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        var resolver = httpContext.GetResourceResolver();
        var module = ModuleBuilder.New(JsOnlyDependencyResolver.Default, resolver, this.build);
        await httpContext.WriteJsModuleResponse(module, toJavaScriptOptions, jsonSerializer);
    }
}

internal class MetapsiCssBuilderResult : IResult
{
    private readonly Action<CssBuilder> build;
    private readonly ToCssOptions toCssOptions;

    public MetapsiCssBuilderResult(System.Action<CssBuilder> build, ToCssOptions toCssOptions)
    {
        this.build = build;
        this.toCssOptions = toCssOptions;
    }

    public async Task ExecuteAsync(HttpContext httpContext)
    {
        var resolver = httpContext.GetResourceResolver();
        CssBuilder cssBuilder = new CssBuilder(resolver);
        build(cssBuilder);
        httpContext.Response.ContentType = "text/css; charset=UTF-8";
        await httpContext.Response.WriteAsync(cssBuilder.Rule.ToCss(this.toCssOptions));
    }
}