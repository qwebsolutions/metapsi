using Metapsi.Html;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Web;

namespace Metapsi;

public interface ICustomElement
{
    string Tag { get; }
    //internal Type ModelType { get; }
    internal Func<CfHttpContext, App.Model, Task> GetHandler();
}

public interface IRootControl
{
}

internal class RootControl : IRootControl
{
    public Var<IVNode> RootVirtualNode { get; set; }
}

public abstract class CustomElement<TModel> : ICustomElement
{
    public string Tag { get; set; }

    public CustomElement()
    {
        this.Tag = CustomElementExtensions.GetCustomElementTagName(this.GetType());
    }

    internal LayoutBuilder rootLayoutBuilder { get; set; }

    public abstract Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, Metapsi.Web.CfHttpContext context, App.Model model, Var<Element> element);

    public abstract IRootControl OnRender(LayoutBuilder b, Var<TModel> model);

    //public Type ModelType => typeof(TModel);

    public IRootControl Root(Action<PropsBuilder<object>> setProps, params Var<IVNode>[] children)
    {
        return new RootControl() { RootVirtualNode = rootLayoutBuilder.H(this.Tag, setProps, children) };
    }

    public IRootControl Root(params Var<IVNode>[] children)
    {
        return Root(b => { }, children);
    }

    Func<CfHttpContext, App.Model, Task> ICustomElement.GetHandler()
    {
        return async (httpContext, appModel) =>
        {
            var module = ModuleBuilder.New(
                b =>
                {
                    b.Call(b =>
                    {
                        b.DefineCustomElement(
                            this.Tag,
                            (SyntaxBuilder b, Var<Element> element) =>
                            {
                                return this.OnInit(b, httpContext, appModel, element);
                            },
                            (LayoutBuilder b, string tagName, Var<TModel> model) =>
                            {
                                this.rootLayoutBuilder = b;
                                return (this.OnRender(b, model) as RootControl).RootVirtualNode;
                            });

                            //customElement.Subscriptions.ToArray());
                    });
                });

            await httpContext.Response.WriteJsModuleReponse(module);
        };
    }
}


public class CustomElementConfiguration<TModel>
{
    public string Tag { get; set; } = CustomElementExtensions.GetCustomElementTagName(typeof(TModel));
    public Func<SyntaxBuilder, CfHttpContext, App.Model, Var<Element>, Var<HyperType.StateWithEffects>> Init { get; set; } = (SyntaxBuilder b, CfHttpContext httpContext, App.Model appModel, Var<Element> e) => b.MakeStateWithEffects(b.NewObj().As<TModel>());
    public Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> Render { get; set; } = (LayoutBuilder b, string tag, Var<TModel> model) => b.H(tag);
    public List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>> Subscriptions { get; set; } = new List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>>();
}

public class CustomElementConfiguration
{
    public string Tag { get; set; }
    public Func<CfHttpContext, App.Model, Task> HandleRequest { get; set; }
}


public static class CustomElementsFeature
{
    public static class Routes
    {
        public static RouteDescription JsPathByTag(string tag)
        {
            return RouteDescription.New(
                "get-custom-element-js-path",
                b =>
                {
                    b.Add("tag", tag);
                });
        }
    }

    public class Data
    {
        public Dictionary<string, string> JsUrls { get; set; } = new Dictionary<string, string>();
    }

    public class Configuration
    {
        public Dictionary<string, CustomElementConfiguration> CustomElements { get; set; } = new Dictionary<string, CustomElementConfiguration>();
    }

    public static string FeatureName = nameof(CustomElementsFeature);

    public static void ConfigureCustomElements(
           this ConfigurationBuilder<App.Setup> b,
           System.Action<ConfigurationBuilder<Configuration>> configure = null)
    {
        var configuration = ConfigurationBuilder.Configure(configure);

        b.Configuration.Features[FeatureName] = new App.Feature()
        {
            Configuration = configuration,
            GetData = (findUrl) =>
            {
                var data = new Data();

                foreach (var customElement in configuration.CustomElements)
                {
                    data.JsUrls[customElement.Value.Tag] = findUrl(Routes.JsPathByTag(customElement.Value.Tag));
                }

                return data;
            }
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="configureCustomElement"></param>
    public static void Add<TModel>(this ConfigurationBuilder<Configuration> b, Action<ConfigurationBuilder<CustomElementConfiguration<TModel>>> configureCustomElement)
    {
        var customElement = ConfigurationBuilder.Configure(configureCustomElement);
        Add(
            b,
            customElement.Tag,
            async (httpContext, appModel) =>
            {
                var module = ModuleBuilder.New(
                    b =>
                    {
                        b.Call(b =>
                        {
                            b.DefineCustomElement(
                                customElement.Tag,
                                (SyntaxBuilder b, Var<Element> element) =>
                                {
                                    return customElement.Init(b, httpContext, appModel, element);
                                },
                                customElement.Render,
                                customElement.Subscriptions.ToArray());
                        });
                    });

                await httpContext.Response.WriteJsModuleReponse(module);
            });
    }

    private static void Add(ConfigurationBuilder<Configuration> b, string tag, Func<Metapsi.Web.CfHttpContext, App.Model, Task> handle)
    {
        b.Configuration.CustomElements.Add(tag, new CustomElementConfiguration()
        {
            Tag = tag,
            HandleRequest = handle
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TCustomElement"></typeparam>
    /// <param name="b"></param>
    public static void Add<TCustomElement>(this ConfigurationBuilder<Configuration> b) where TCustomElement : ICustomElement, new()
    {
        var instance = new TCustomElement();
        Add(
            b,
            instance.Tag,
            instance.GetHandler());
    }

    public static string GetCustomElementUrl<T>(this App.Model appKeys)
        where T : ICustomElement, new()
    {
        CustomElementsFeature.Data data = appKeys.FeatureModels[CustomElementsFeature.FeatureName] as CustomElementsFeature.Data;
        var tag = new T().Tag;
        return data.JsUrls[tag];
    }
}