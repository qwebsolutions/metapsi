using Metapsi.Html;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{
    //internal class PageResult<TModel> : IResult
    //{
    //    private readonly TModel model;

    //    public PageResult(TModel model)
    //    {
    //        this.model = model;
    //    }

    //    public async Task ExecuteAsync(HttpContext httpContext)
    //    {
    //        var html = string.Empty;

    //        try
    //        {
    //            if (this.renderer != null)
    //            {
    //                html = this.renderer(this.model);
    //            }
    //            else
    //            {
    //                var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
    //                var renderers = (renderersService as RenderersService).Renderers;

    //                var document = renderers[typeof(System.Exception)].DynamicInvoke(this.model);
    //                switch (document)
    //                {
    //                    case HtmlDocument htmlDocument:
    //                        await WebServerExtensions.LoadDocumentMetadataResources(htmlDocument);
    //                        html = htmlDocument.ToHtml();
    //                        break;
    //                    case string htmlString:
    //                        html = htmlString;
    //                        break;
    //                    default:
    //                        throw new Exception($"Document type {document.GetType().Name} does not support rendering");
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
    //            var renderers = (renderersService as RenderersService).Renderers;

    //            html = renderers[typeof(System.Exception)].DynamicInvoke(ex) as string;
    //        }

    //        httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
    //        httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    //        await httpContext.Response.WriteAsync(html);
    //    }
    //}

    //internal class PageResult<TModel, TDocument> : IResult
    //{
    //    private readonly TModel model;
    //    private Func<TModel, TDocument> render;
    //    Func<HttpContext, TDocument, Task> response;

    //    public PageResult(
    //        TModel model,
    //        Func<TModel, TDocument> render,
    //        Func<HttpContext, TDocument, Task> response)
    //    {
    //        this.model = model;
    //        this.render = render;
    //        this.response = response;
    //    }

    //    public async Task ExecuteAsync(HttpContext httpContext)
    //    {
    //        var html = string.Empty;

    //        try
    //        {
    //            var document = this.render(this.model);
    //            await this.response(httpContext, document);
    //            return;
    //        }
    //        catch (Exception ex)
    //        {
    //            var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
    //            var renderers = (renderersService as RenderersService).Renderers;
    //            html = renderers[typeof(System.Exception)].DynamicInvoke(ex) as string;
    //            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
    //            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    //            await httpContext.Response.WriteAsync(html);
    //        }
    //    }
    //}

    internal class PageResult : IResult
    {
        Func<HttpContext, Task> respond = null;
        public PageResult(Func<HttpContext, Task> respond)
        {
            this.respond = respond;
        }

        public async Task ExecuteAsync(HttpContext httpContext)
        {
            try
            {
                await respond(httpContext);
            }
            catch (Exception ex)
            {
                var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
                var renderers = (renderersService as RenderersService).Renderers;
                var exceptionRenderer = renderers.GetValueOrDefault(
                    typeof(System.Exception),
                    async (HttpContext HttpContext) =>
                    {
                        string html = "Error";
                        httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
                        httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
                        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                        await httpContext.Response.WriteAsync(html);
                    });
                exceptionRenderer.DynamicInvoke(httpContext, ex);
            }
        }
    }

    public static class Page
    {
        /// <summary>
        /// Used when registering a separate HtmlDocument renderer, which will be mapped by model type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public static IResult Result<T>(T model)
        {
            return new PageResult(async (HttpContext httpContext) =>
            {
                string html = string.Empty;
                var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
                var renderers = (renderersService as RenderersService).Renderers;

                var document = renderers[typeof(T)].DynamicInvoke(model);
                switch (document)
                {
                    case HtmlDocument htmlDocument:
                        await WebServerExtensions.LoadDocumentMetadataResources(htmlDocument);
                        html = htmlDocument.ToHtml();
                        break;
                    case string htmlString:
                        html = htmlString;
                        break;
                    default:
                        throw new Exception($"Document type {document.GetType().Name} does not support rendering");
                }

                httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
                httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
                await httpContext.Response.WriteAsync(html);
            });
        }

        /// <summary>
        /// Used when rendering to a HTML string directly.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="renderer"></param>
        /// <returns></returns>
        public static IResult Result<T>(T model, Func<T, string> render)
        {
            return new PageResult(
                async (httpContext) =>
                {
                    string html = render(model);
                    httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
                    httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
                    await httpContext.Response.WriteAsync(html);
                });
        }

        /// <summary>
        /// Used to output <see cref="HtmlDocument"/> based on <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <param name="render"></param>
        /// <returns></returns>
        public static IResult Result<T>(
            T model,
            Func<T, HtmlDocument> render)
        {
            return new PageResult(
                async (HttpContext httpContext) =>
                {
                    var htmlDocument = render(model);
                    await WebServerExtensions.WriteHtmlDocumentResponse(httpContext, htmlDocument);
                });
        }

        /// <summary>
        /// Used for custom HTTP output based on <typeparamref name="TDocument"/>
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <typeparam name="TDocument"></typeparam>
        /// <param name="model"></param>
        /// <param name="render"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        public static IResult Result<TModel, TDocument>(
            TModel model,
            Func<TModel, TDocument> render,
            Func<HttpContext, TDocument, Task> response)
        {
            return new PageResult(
                async (HttpContext httpContext) =>
                {
                    var htmlDocument = render(model);
                    await response(httpContext, htmlDocument);
                });
        }
    }
}