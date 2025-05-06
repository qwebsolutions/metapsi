using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi
{
    internal class PageResult<TModel> : IResult
    {
        private readonly TModel model;
        private Func<TModel, string> renderer;

        public PageResult(TModel model)
        {
            this.model = model;
        }

        public PageResult(TModel model, Func<TModel, string> renderer)
        {
            this.model = model;
            this.renderer = renderer;
        }

        public async Task ExecuteAsync(HttpContext httpContext)
        {
            var html = string.Empty;

            try
            {
                if (this.renderer != null)
                {
                    html = this.renderer(this.model);
                }
                else
                {
                    var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
                    var renderers = (renderersService as RenderersService).Renderers;
                    html = renderers[typeof(TModel)].DynamicInvoke(this.model) as string;
                }
            }
            catch (Exception ex)
            {
                var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
                var renderers = (renderersService as RenderersService).Renderers;
                html = renderers[typeof(System.Exception)].DynamicInvoke(ex) as string;
            }

            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
            await httpContext.Response.WriteAsync(html);
        }
    }

    internal class PageResult<TModel, TDocument> : IResult
    {
        private readonly TModel model;
        private Func<TModel, TDocument> render;
        Func<HttpContext, TDocument, Task> response;

        public PageResult(
            TModel model,
            Func<TModel, TDocument> render,
            Func<HttpContext, TDocument, Task> response)
        {
            this.model = model;
            this.render = render;
            this.response = response;
        }

        public async Task ExecuteAsync(HttpContext httpContext)
        {
            var html = string.Empty;

            try
            {
                var document = this.render(this.model);
                await this.response(httpContext, document);
                return;
            }
            catch (Exception ex)
            {
                var renderersService = httpContext.RequestServices.GetService(typeof(RenderersService));
                var renderers = (renderersService as RenderersService).Renderers;
                html = renderers[typeof(System.Exception)].DynamicInvoke(ex) as string;
                httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
                httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
                await httpContext.Response.WriteAsync(html);
            }
        }
    }

    public static class Page
    {
        public static IResult Result<T>(T model)
        {
            return new PageResult<T>(model);
        }

        public static IResult Model<T>(T model)
        {
            return new PageResult<T>(model);
        }

        public static IResult Result<T>(T model, Func<T, string> renderer)
        {
            return new PageResult<T>(model, renderer);
        }

        public static IResult Result<TModel, TDocument>(
            TModel model,
            Func<TModel, TDocument> render,
            Func<HttpContext, TDocument, Task> response)
        {
            return new PageResult<TModel, TDocument>(model, render, response);
        }
    }
}