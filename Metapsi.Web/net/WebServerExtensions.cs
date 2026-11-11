using Metapsi.Html;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Web
{
    public static class WebServerExtensions
    {
        public static WebApplicationBuilder AddMetapsi(
           this WebApplicationBuilder builder)
        {
            //builder.Services.TryAddSingleton<IWebResourceCache>(InMemoryWebResourceCache.Default);
            builder.Services.TryAddSingleton<VersionsRepository>();
            builder.Services.TryAddSingleton<IResourceWriter>(new InMemoryResourceWriter(WebResourceProvider.Default));
            builder.Services.AddHttpContextAccessor();
            builder.Services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.PropertyNamingPolicy = null;
                options.SerializerOptions.WriteIndented = true;
                options.SerializerOptions.PropertyNameCaseInsensitive = true;
            });

            return builder;
        }

        public static RouteHandlerBuilder UseMetapsi(this IEndpointRouteBuilder endpoint)
        {
            WebResourceProvider.AutoRegisterModules(WebResourceProvider.Default);
            
            return endpoint.UseResourceFiles();
        }

        public static IResourceResolver GetResourceResolver(this HttpContext httpContext)
        {
            return new ResourceResolver(httpContext, WebResourceProvider.Default, httpContext.GetVersionsRepository());
        }

        public static IResourceWriter GetResourceWriter(this HttpContext httpContext)
        {
            return httpContext.RequestServices.GetService<IResourceWriter>();
        }

        internal static VersionsRepository GetVersionsRepository(this HttpContext httpContext)
        {
            return httpContext.RequestServices.GetRequiredService<VersionsRepository>();
        }

        public static HtmlDocument HtmlBuilder(this HttpContext httpContext, Action<HtmlBuilder> buildHtml)
        {
            return Metapsi.Html.HtmlBuilder.FromDefault(httpContext.GetResourceResolver(), buildHtml);
        }

        public static RouteHandlerBuilder UseResourceFiles(this IEndpointRouteBuilder endpoint)
        {
            return endpoint.MapGet("/resource/{package}/{version}/{**fileName}", async (HttpContext httpContext, string package, string version, string fileName) =>
            {
                var resourceWriter = httpContext.GetResourceWriter();
                var resourceResolver = httpContext.GetResourceResolver();
                await resourceWriter.WriteAsync(
                    package, 
                    version, 
                    fileName, 
                    new CfHttpResponse(httpContext.Response),
                    resourceResolver);

            }).WithName(ResourceResolver.ResourceEndpointName);
        }

        internal static readonly ToJavaScriptOptions DefaultToJavaScriptOptions = new ToJavaScriptOptions()
        {
            JsonSerializer = new Metapsi.Serializer()
        };

        internal static readonly ToCssOptions DefaultToCssOptions = new ToCssOptions();

        internal static readonly ToHtmlOptions DefaultToHtmlOptions = new ToHtmlOptions()
        {
            ToJavaScriptOptions = DefaultToJavaScriptOptions,
            ToCssOptions = DefaultToCssOptions
        };

        public static async Task WriteHtmlDocumentResponse(
            this HttpContext httpContext, 
            HtmlDocument document,
            ToHtmlOptions options = null)
        {
            if (options == null)
            {
                options = DefaultToHtmlOptions;
            }
            string html = document.ToHtml(options);
            httpContext.Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Html;
            httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
            await httpContext.Response.WriteAsync(html);
        }

        public static Task WriteJsModuleResponse(this HttpContext httpContext, Metapsi.Syntax.Module module, ToJavaScriptOptions options = null)
        {
            return Metapsi.Web.HttpExtensions.WriteJsModuleResponse(new CfHttpResponse(httpContext.Response), module, options);
        }

        public static async Task WriteCssFile(this HttpContext httpContext, CssFile cssFile, ToCssOptions options = null)
        {
            httpContext.Response.ContentType = "text/css; charset=UTF-8";
            await httpContext.Response.WriteAsync(cssFile.ToCss(options));
        }
    }
}