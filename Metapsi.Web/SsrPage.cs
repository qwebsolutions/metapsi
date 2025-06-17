using Metapsi.Html;
using Metapsi.Web;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi;

public interface IServerRenderedPage
{
    string Name { get; }
    internal Type ModelType { get; }
    internal Func<CfHttpContext, App.Model, Task> GetHandler();
}

public abstract class ServerRenderedPage<TModel> : IServerRenderedPage
{
    public string Name { get; set; }

    public ServerRenderedPage()
    {
        this.Name = this.GetType().CSharpTypeName();
    }

    public abstract Task<TModel> OnLoadModel(Metapsi.Web.CfHttpContext context, App.Model model);

    public abstract void OnRender(HtmlBuilder b, TModel model);

    public Type ModelType => typeof(TModel);

    Func<CfHttpContext, App.Model, Task> IServerRenderedPage.GetHandler()
    {
        return async (httpContext, appModel) =>
        {
            var model = await OnLoadModel(httpContext, appModel);
            var document = HtmlBuilder.FromDefault(b =>
            {
                OnRender(b, model);
            });
            await httpContext.Response.WriteHtmlDocument(document);
        };
    }
}

public class SsrPageConfiguration<TModel>
{
    public string Name { get; set; } = typeof(TModel).CSharpTypeName();
    public Func<Metapsi.Web.CfHttpContext, Task<TModel>> LoadModel { get; set; }
    public Action<HtmlBuilder, TModel> Render { get; set; }
}

public class SsrPageConfiguration
{
    public string Name { get; set; }
    public Func<Metapsi.Web.CfHttpContext, App.Model, Task> HandleRequest { get; set; }
}

public static class SsrPageFeature
{
    public static class Routes
    {
        public static RouteDescription PageByName(string pageName)
        {
            return RouteDescription.New(
                "get-page",
                b =>
                {
                    b.Add("page-name", pageName);
                });
        }
    }

    public class Data
    {
        public Dictionary<string,string> PageUrls { get; set; } = new Dictionary<string,string>();
    }

    public class Configuration
    {
        public Dictionary<string, SsrPageConfiguration> Pages { get; set; } = new Dictionary<string, SsrPageConfiguration>();
    }

    public static string FeatureName = nameof(SsrPageFeature);

    public static void ConfigurePages(
           this ConfigurationBuilder<App.Setup> b,
           System.Action<ConfigurationBuilder<Configuration>> configure = null)
    {
        var ssrPagesConfiguration = ConfigurationBuilder.Configure(configure);

        b.Configuration.Features[FeatureName] = new App.Feature()
        {
            Configuration = ssrPagesConfiguration,
            GetData = (findUrl) =>
            {
                var data = new Data();

                foreach (var page in ssrPagesConfiguration.Pages)
                {
                    data.PageUrls[page.Value.Name] = findUrl(Routes.PageByName(page.Key));
                }

                return data;
            }
        };
    }

    /// <summary>
    /// Add a page rendering a <typeparamref name="TModel"/> by explicit configuration
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="configurePage"></param>
    public static void Add<TModel>(this ConfigurationBuilder<Configuration> b, Action<ConfigurationBuilder<SsrPageConfiguration<TModel>>> configurePage)
    {
        var page = ConfigurationBuilder.Configure(configurePage);
        Add(
            b,
            page.Name,
            async (httpContext, appModel) =>
            {
                TModel model = default(TModel);
                if (page.LoadModel != null)
                {
                    model = await page.LoadModel(httpContext);
                }
                else
                {
                    model = (TModel)Activator.CreateInstance(typeof(TModel));
                }

                var document = HtmlBuilder.FromDefault(b =>
                {
                    page.Render(b, model);
                });
                await httpContext.Response.WriteHtmlDocument(document);
            });
    }

    private static void Add(ConfigurationBuilder<Configuration> b, string name, Func<CfHttpContext, App.Model, Task> handle)
    {
        b.Configuration.Pages.Add(name, new SsrPageConfiguration()
        {
            Name = name,
            HandleRequest = handle
        });
    }

    /// <summary>
    /// Add a page by implementation type <typeparamref name="TModel"/>
    /// </summary>
    /// <typeparam name="TPage"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    public static void Add<TPage>(this ConfigurationBuilder<Configuration> b) where TPage : IServerRenderedPage, new()
    {
        var pageInstance = new TPage();
        Add(
            b,
            pageInstance.Name,
            pageInstance.GetHandler());
    }

    public static string GetPageUrl<T>(this App.Model appKeys)
        where T : IServerRenderedPage, new()
    {
        SsrPageFeature.Data pageData = appKeys.FeatureModels[SsrPageFeature.FeatureName] as SsrPageFeature.Data;
        var pageName = new T().Name;
        return pageData.PageUrls[pageName];
    }
}
