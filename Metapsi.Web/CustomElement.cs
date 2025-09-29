using Metapsi.Html;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Web;
using System.Linq;

namespace Metapsi;

public class CustomElementConfiguration<TModel>
{
    public string Tag { get; set; } = CustomElementExtensions.GetCustomElementTagName(typeof(TModel));
    public Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> Init { get; set; } = (SyntaxBuilder b, Var<Element> e) => b.MakeStateWithEffects(b.NewObj().As<TModel>());
    public Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> Render { get; set; } = (LayoutBuilder b, Var<string> tag, Var<TModel> model) => b.H(tag);
    public List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>> Subscriptions { get; set; } = new List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>>();
}

public static class CustomElementsFeature
{
    //public static string GetCustomElementDefaultPath(this ICustomElement ce)
    //{
    //    return $"/ce/{ce.Tag}.js";
    //}

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

    public class Details
    {
        public Dictionary<string, string> JsUrls { get; set; } = new Dictionary<string, string>();
    }

    public class Configuration
    {
        public Dictionary<string, ICustomElement> CustomElements { get; set; } = new Dictionary<string, ICustomElement>();
    }

    public static string FeatureName = nameof(Metapsi.CustomElementsFeature);

    public static void ConfigureCustomElements(
           this ConfigurationBuilder<App.Setup> b,
           System.Action<ConfigurationBuilder<Configuration>> configure = null)
    {
        var configuration = ConfigurationBuilder.Configure(configure);

        b.Configuration.Features[FeatureName] = new App.Feature()
        {
            Configuration = configuration,
            GetDetails = (findUrl) =>
            {
                var data = new Details();

                foreach (var customElement in configuration.CustomElements)
                {
                    var customElementUrl = findUrl(Routes.JsPathByTag(customElement.Value.Tag));
                    data.JsUrls[customElement.Value.Tag] = customElementUrl;
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
        var module = ModuleBuilder.New(
            b =>
            {
                b.Call(b =>
                {
                    //AppMapExtensions.SetAppMap(b, appMap);

                    b.DefineCustomElement(
                        customElement.Tag,
                        (SyntaxBuilder b, Var<Element> element) =>
                        {
                            return customElement.Init(b, element);
                        },
                        customElement.Render,
                        customElement.Subscriptions.ToArray());
                });
            });

        Add(b, customElement.Tag, module);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="configureCustomElement"></param>
    public static void Add<TModel, TProps>(this ConfigurationBuilder<Configuration> b, Action<ConfigurationBuilder<CustomElementConfiguration<TModel>>> configureCustomElement)
    {
        b.Add<TModel>(configureCustomElement);
    }

    private static void Add(ConfigurationBuilder<Configuration> b, string tag, Module module)
    {
        b.Configuration.CustomElements[tag] = new CustomElement()
        {
            Tag = tag,
            Module = module
        };
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
            instance.Module);
    }

    /// <summary>
    /// Adds all ICustomElement types from assembly.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="assembly"></param>
    /// <param name="namespace"></param>
    public static void AddFrom(
        this ConfigurationBuilder<CustomElementsFeature.Configuration> b,
        System.Reflection.Assembly assembly,
        string @namespace = null)
    {
        var customElementTypes = assembly.GetTypes().Where(x => typeof(ICustomElement).IsAssignableFrom(x)).Where(x => !x.IsAbstract);

        foreach (var type in customElementTypes)
        {
            var isValid = true;

            if (!string.IsNullOrWhiteSpace(@namespace))
            {
                isValid = type.Namespace == @namespace;
            }

            if (isValid)
            {
                var instance = (ICustomElement)Activator.CreateInstance(type);
                Add(b, instance.Tag, instance.Module);
            }
        }
    }

    //public static string GetCustomElementUrl(this List<PathResolution> appMap, string tag)
    //{
    //    CustomElementsFeature.Details data = appMap.Features[Metapsi.CustomElementsFeature.FeatureName] as CustomElementsFeature.Details;
    //    return data.JsUrls[tag];
    //}

    //public static string GetCustomElementUrl<T>(this App.Map appMap)
    //    where T : ICustomElement, new()
    //{
    //    var customElement = new T();
    //    var module = customElement.GetModule(appMap);
    //    var moduleJs = module.ToJs();
    //    var hash = EmbeddedFiles.Hash(moduleJs);
    //    var baseUrl = appMap.GetCustomElementUrl(customElement.Tag);
    //    return $"{baseUrl}?hash={hash}";
    //}

    public static void OnInit<TModel>(this ConfigurationBuilder<CustomElementConfiguration<TModel>> b, Func<SyntaxBuilder, Var<Html.Element>, Var<HyperType.StateWithEffects>> onInit)
    {
        b.Configuration.Init = onInit;
    }

    public static void OnRender<TModel>(this ConfigurationBuilder<CustomElementConfiguration<TModel>> b, Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> onRender)
    {
        b.Configuration.Render = onRender;
    }

    public static void AddSubscription<TModel>(this ConfigurationBuilder<CustomElementConfiguration<TModel>> b, System.Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>> subscribe)
    {
        b.Configuration.Subscriptions.Add(subscribe);
    }

    public static bool HasCustomElementsFeature(this App.Map appMap)
    {
        return appMap.Features.ContainsKey(FeatureName);
    }

    public static CustomElementsFeature.Details CustomElementsDetails(this App.Map appMap)
    {
        if (!appMap.Features.ContainsKey(FeatureName))
            throw new Exception("Custom element feature is not registered");

        return appMap.Features[FeatureName] as CustomElementsFeature.Details;
    }

    /// <summary>
    /// Gets the &lt;script type="module" src="path.js"&gt; for the specified custom element
    /// </summary>
    /// <param name="appMap"></param>
    /// <param name="tag"></param>
    /// <returns></returns>
    /// <exception cref="System.ArgumentException">If tag is not registered in <paramref name="appMap"/></exception>
    public static IHtmlNode GetCustomElementScriptTag(this HtmlBuilder b, Details details, string tag)
    {
        if (!details.JsUrls.ContainsKey(tag))
        {
            throw new Exception($"Custom element {tag} is not registered");
        }

        return b.HtmlScript(
            b =>
            {
                b.SetTypeModule();
                b.SetSrc(details.JsUrls[tag]);
            });
    }

    /// <summary>
    /// Gets a list of &lt;script type="module" src="path.js"&gt; for all the registered documents. Does not throw if there are none.
    /// </summary>
    /// <param name="b"></param>
    /// <param name="details"></param>
    /// <returns></returns>
    public static List<IHtmlNode> GetAllCustomElementScriptTags(this HtmlBuilder b, Details details)
    {
        return details.JsUrls.Select(x => b.GetCustomElementScriptTag(details, x.Key)).ToList();
    }
}