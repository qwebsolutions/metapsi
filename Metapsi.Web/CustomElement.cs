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
    internal Func<App.Model, Module> GetModule();
}

public interface ICustomElementProps<T>
{

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

    public abstract Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, App.Model model, Var<Element> element);

    public abstract IRootControl OnRender(LayoutBuilder b, Var<TModel> model);

    public virtual void OnSubscribe(SyntaxBuilder b, Var<TModel> model, Var<List<HyperType.Subscription>> subscriptions)
    {
    }

    public IRootControl Root(Action<PropsBuilder<object>> setProps, params Var<IVNode>[] children)
    {
        return new RootControl() { RootVirtualNode = rootLayoutBuilder.H(this.Tag, setProps, children) };
    }

    public IRootControl Root(params Var<IVNode>[] children)
    {
        return Root(b => { }, children);
    }

    Func<App.Model, Module> ICustomElement.GetModule()
    {
        return (appModel) =>
        {
            var module = ModuleBuilder.New(
                b =>
                {
                    b.Call(b =>
                    {
                        AppModelExtensions.SetAppModel(b, appModel);

                        b.DefineCustomElement(
                            b.Const(this.Tag),
                            b.Def((SyntaxBuilder b, Var<Element> element) =>
                            {
                                return this.OnInit(b, appModel, element);
                            }),
                            b.Def((LayoutBuilder b, Var<string> tagName, Var<TModel> model) =>
                            {
                                this.rootLayoutBuilder = b;
                                return (this.OnRender(b, model) as RootControl).RootVirtualNode;
                            }),
                            b.Def((SyntaxBuilder b, Var<TModel> model) =>
                            {
                                var subscriptions = b.NewCollection<HyperType.Subscription>();
                                this.OnSubscribe(b, model, subscriptions);
                                return subscriptions;
                            }));
                    });
                });

            return module;
        };
    }
}

public abstract class CustomElement<TModel, TProps> : CustomElement<TModel>, ICustomElementProps<TProps>
{
    public override Var<HyperType.StateWithEffects> OnInit(SyntaxBuilder b, App.Model model, Var<Element> element)
    {
        return OnInitProps(b, model, b.GetInitProps<TProps>(element));
    }
    public abstract Var<HyperType.StateWithEffects> OnInitProps(SyntaxBuilder b, App.Model model, Var<TProps> props);
}

public class CustomElementConfiguration<TModel>
{
    public string Tag { get; set; } = CustomElementExtensions.GetCustomElementTagName(typeof(TModel));
    public Func<SyntaxBuilder, App.Model, Var<Element>, Var<HyperType.StateWithEffects>> Init { get; set; } = (SyntaxBuilder b, App.Model appModel, Var<Element> e) => b.MakeStateWithEffects(b.NewObj().As<TModel>());
    public Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> Render { get; set; } = (LayoutBuilder b, Var<string> tag, Var<TModel> model) => b.H(tag);
    public List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>> Subscriptions { get; set; } = new List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>>();
}

public class CustomElementConfiguration
{
    public string Tag { get; set; }
    public Func<App.Model, Module> GetModule { get; set; }
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
            (appModel) =>
            {
                var module = ModuleBuilder.New(
                    b =>
                    {
                        b.Call(b =>
                        {
                            AppModelExtensions.SetAppModel(b, appModel);

                            b.DefineCustomElement(
                                customElement.Tag,
                                (SyntaxBuilder b, Var<Element> element) =>
                                {
                                    return customElement.Init(b, appModel, element);
                                },
                                customElement.Render,
                                customElement.Subscriptions.ToArray());
                        });
                    });

                return module;
            });
    }

    private static void Add(ConfigurationBuilder<Configuration> b, string tag, Func<App.Model, Module> getModule)
    {
        b.Configuration.CustomElements.Add(tag, new CustomElementConfiguration()
        {
            Tag = tag,
            GetModule = getModule
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
            instance.GetModule());
    }

    public static string GetCustomElementUrl(this App.Model appModel, string tag)
    {
        CustomElementsFeature.Data data = appModel.FeatureModels[CustomElementsFeature.FeatureName] as CustomElementsFeature.Data;
        return data.JsUrls[tag];
    }

    public static string GetCustomElementUrl<T>(this App.Model appModel)
        where T : ICustomElement, new()
    {
        return appModel.GetCustomElementUrl(new T().Tag);
    }
}