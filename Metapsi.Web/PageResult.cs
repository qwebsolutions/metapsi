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

        public PageResult(TModel model)
        {
            this.model = model;
        }

        public async Task ExecuteAsync(HttpContext httpContext)
        {
            var renderers = httpContext.Items["Metapsi.Renderers"] as Dictionary<Type, Delegate>;

            var html = string.Empty;

            try
            {
                html = renderers[typeof(TModel)].DynamicInvoke(this.model) as string;
            }
            catch (Exception ex)
            {
                html = renderers[typeof(System.Exception)].DynamicInvoke(ex) as string;
            }

            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
            await httpContext.Response.WriteAsync(html);
        }
    }

    public static class Page
    {
        public static IResult Result<T>(T model)
        {
            return new PageResult<T>(model);
        }
    }
}