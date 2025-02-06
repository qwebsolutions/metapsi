using System.Text;
using System.Web;
using System;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Linq;
using System.Collections.Generic;

namespace Metapsi.Html;

public static partial class CustomElementExtensions
{
    private const string ExternalScriptName = "MetapsiCustomElements";

    /// <summary>
    /// Gets a custom element tag name based on T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>tag name</returns>
    public static string GetCustomElementTagName<T>()
    {
        var genericTypes = string.Join("-", typeof(T).GenericTypeArguments.Select(x => x.Name.ToLower().Replace("`", string.Empty)));
        if (!string.IsNullOrEmpty(genericTypes))
        {
            genericTypes = $"-{genericTypes}";
        }
        var nestedClassName = typeof(T).CSharpTypeName().ToLower().Replace(".", "-").Replace("`", string.Empty);
        return $"metapsi-{nestedClassName}{genericTypes}";
    }
    /// <summary>
    /// Gets a custom element tag name based on T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <returns>Tag name</returns>
    public static string GetCustomElementTagName<T>(this HtmlBuilder b)
    {
        return GetCustomElementTagName<T>();
    }

    /// <summary>
    /// Gets a custom element tag name based on T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <returns>Tag name</returns>
    public static string GetCustomElementTagName<T>(this LayoutBuilder b)
    {
        return GetCustomElementTagName<T>();
    }

    /// <summary>
    /// Creates a script tag that defines a custom element with the children list as inner HTML
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="children"></param>
    /// <returns></returns>
    public static IHtmlNode HtmlCustomElement(this HtmlBuilder b, string tagName, params IHtmlNode[] children)
    {
        var innerHtml = HttpUtility.JavaScriptStringEncode(string.Join("\n", children.Select(x => x.ToHtml())));
        return b.HtmlScriptModule(b =>
        {
            b.AddScript(typeof(CustomElementExtensions).Assembly, $"{ExternalScriptName}.js", "module");
            b.CallExternal(ExternalScriptName, "defineStaticCustomElement", b.Const(tagName), b.Const(innerHtml));
        });
    }

    /// <summary>
    /// Adds a head script tag that defines a custom element with the children list as inner HTML 
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="children"></param>
    public static void AddCustomElement(this HtmlBuilder b, string tagName, params IHtmlNode[] children)
    {
        var innerHtml = HttpUtility.JavaScriptStringEncode(string.Join("\n", children.Select(x => x.ToHtml())));
        b.HeadAppend(b.HtmlCustomElement(tagName, children));
    }

    public static IHtmlNode HtmlCustomElement(
        this HtmlBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<Element>> render,
        Action<SyntaxBuilder, Var<Element>> attach = null,
        Action<SyntaxBuilder, Var<Element>> cleanup = null)
    {
        if (attach == null) attach = (SyntaxBuilder b, Var<Element> node) => { };
        if (cleanup == null) cleanup = (SyntaxBuilder b, Var<Element> node) => { };

        return b.HtmlScriptModule(b =>
        {
            var jsRender = b.Def("render", render);
            var jsAttach = b.Def("attach", attach);
            var jsCleanup = b.Def("cleanup", cleanup);
            b.AddScript(typeof(CustomElementExtensions).Assembly, $"{ExternalScriptName}.js", "module");
            b.CallExternal(
                ExternalScriptName,
                "defineRACCustomElement",
                b.Const(tagName),
                jsRender,
                jsAttach,
                jsCleanup);
        });
    }

    public static void AddCustomElement(
        this HtmlBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<Element>> render,
        Action<SyntaxBuilder, Var<Element>> attach = null,
        Action<SyntaxBuilder, Var<Element>> cleanup = null)
    {
        b.HeadAppend(b.HtmlCustomElement(tagName, render, attach, cleanup));
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="init"></param>
    /// <param name="render"></param>
    /// <param name="subscriptions"></param>
    /// <remarks>The render function must return b.H(tagName) as root element</remarks>
    /// <returns></returns>
    public static IHtmlNode HtmlCustomElement<TModel>(
        this HtmlBuilder b,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        var tagName = GetCustomElementTagName<TModel>();

        Reference<HyperType.Dispatcher> dispatchRef = new();
        return b.HtmlCustomElement(
            tagName,
            (SyntaxBuilder b, Var<Element> node) =>
            {
                // Call init again to "reset" the application
                // For example, if some ID changes, everything needs to reload

                var dispatch = b.GetRef(b.GlobalRef(dispatchRef)).As<HyperType.Dispatcher>();

                b.Dispatch(dispatch, b.MakeAction((SyntaxBuilder b, Var<TModel> model) =>
                {
                    return b.Call(init, node);
                }));
            },
            attach: (SyntaxBuilder b, Var<Element> node) =>
            {
                var appConfig = b.NewObj<HyperType.App<TModel>>();

                var view = b.Def((LayoutBuilder b, Var<TModel> model) =>
                {
                    return render(b, tagName, model);
                });

                b.Set(appConfig, x => x.view, view);
                b.Set(appConfig, x => x.init, b.Call(init, node.As<Element>()).As<HyperType.Init>());
                b.Set(appConfig, x => x.node, node);
                b.Set(appConfig, x => x.subscriptions, b.MakeSubscriptions<TModel>(subscriptions.ToList()));

                var dispatch = b.App(appConfig.As<HyperType.App<TModel>>());
                b.SetRef(b.GlobalRef(dispatchRef), dispatch);
            },
            cleanup: (SyntaxBuilder b, Var<Element> node) =>
            {
                b.Call(b.GetRef(b.GlobalRef(dispatchRef)).As<System.Action>());
            });
    }

    public static string AddCustomElement<TModel>(
        this HtmlBuilder b,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        var customElementScript = b.HtmlCustomElement(init, render, subscriptions);
        b.HeadAppend(customElementScript);
        return b.GetCustomElementTagName<TModel>();
    }

        //private static object NoModel = new object();

        //private static Var<bool> IsModelInitialized<TModel>(SyntaxBuilder b, Var<TModel> model)
        //{
        //    // If model is not null/undefine, check if it is not NoModel
        //    return b.If(
        //        b.Not(
        //            b.HasObject(model)),
        //        b => b.Const(false),
        //        b => b.Not(b.AreEqual(model.As<object>(), b.Const(NoModel))));
        //}

        //    /// <summary>
        //    /// Must return the custom element itself as root!
        //    /// </summary>
        //    /// <typeparam name="TComponent"></typeparam>
        //    /// <param name="b"></param>
        //    /// <param name="render"></param>
        //    /// <param name="subscriptions"></param>
        //    /// <returns></returns>
        //    public static string DefineCustomElement<TComponent>(
        //        this HtmlBuilder b,
        //        Func<SyntaxBuilder, Var<TComponent>, Var<HyperType.Init>> init,
        //        Func<LayoutBuilder, string, Var<TComponent>, Var<IVNode>> render,
        //        params Func<SyntaxBuilder, Var<TComponent>, Var<HyperType.Subscription>>[] subscriptions)
        //    {
        //        var tagName = GetCustomElementTagName<TComponent>();

        //        Reference<HyperType.Dispatcher> dispatchRef = new();
        //        b.DefineCustomElement(
        //            tagName,
        //            (SyntaxBuilder b, Var<DomElement> node) =>
        //            {
        //                var model = node.As<TComponent>();// b.GetProperty<TComponent>(node, "Component");
        //                b.Log("Render component", model);
        //                b.If(
        //                    IsModelInitialized(b, model),
        //                    b =>
        //                    {
        //                        b.Call(
        //                            b.GetRef(b.GlobalRef(dispatchRef)).As<Action<Func<TComponent, TComponent>>>(),
        //                            b.Def((SyntaxBuilder b, Var<TComponent> _) => model));
        //                    });
        //            },
        //            attach: (SyntaxBuilder b, Var<DomElement> node) =>
        //            {
        //                var appConfig = b.NewObj<HyperType.App<TComponent>>();

        //                var view = b.Def((LayoutBuilder b, Var<TComponent> model) =>
        //                {
        //                    return b.If(
        //                        IsModelInitialized(b, model),
        //                        b => render(b, tagName, model),
        //                        b => b.H(tagName));
        //                });

        //                b.Set(appConfig, x => x.view, view);
        //                b.Set(appConfig, x => x.init, b.Call(init, node.As<TComponent>()));
        //                b.Set(appConfig, x => x.node, node);
        //                b.Set(appConfig, x => x.subscriptions, b.MakeSubscriptions<TComponent>(subscriptions.ToList()));

        //                var dispatch = b.App(appConfig.As<HyperType.App<TComponent>>());
        //                b.SetRef(b.GlobalRef(dispatchRef), dispatch);
        //            },
        //            cleanup: (SyntaxBuilder b, Var<DomElement> node) =>
        //            {
        //                b.Call(b.GetRef(b.GlobalRef(dispatchRef)).As<System.Action>());
        //            });

        //        return tagName;
        //    }

        //    /// <summary>
        //    /// Must return the custom element itself as root!
        //    /// </summary>
        //    /// <typeparam name="TComponent"></typeparam>
        //    /// <param name="b"></param>
        //    /// <param name="render"></param>
        //    /// <param name="subscriptions"></param>
        //    /// <returns></returns>
        //    public static string DefineCustomElement<TComponent>(
        //        this HtmlBuilder b,
        //        Func<SyntaxBuilder, Var<HyperType.Init>> init,
        //        Func<LayoutBuilder, string, Var<TComponent>, Var<IVNode>> render,
        //        params Func<SyntaxBuilder, Var<TComponent>, Var<HyperType.Subscription>>[] subscriptions)
        //    {
        //        return b.DefineCustomElement<TComponent>(
        //            (SyntaxBuilder b, Var<TComponent> model) => b.Call(init),
        //            render,
        //            subscriptions);
        //    }

        //    /// <summary>
        //    /// Must return the custom element itself as root!
        //    /// </summary>
        //    /// <typeparam name="TComponent"></typeparam>
        //    /// <param name="b"></param>
        //    /// <param name="render"></param>
        //    /// <param name="subscriptions"></param>
        //    /// <returns></returns>
        //    public static string DefineCustomElement<TComponent>(
        //        this HtmlBuilder b,
        //        Func<LayoutBuilder, string, Var<TComponent>, Var<IVNode>> render,
        //        params Func<SyntaxBuilder, Var<TComponent>, Var<HyperType.Subscription>>[] subscriptions)
        //    {
        //        return b.DefineCustomElement<TComponent>(b => b.MakeInit(b.Const(NoModel)), render, subscriptions);
        //    }
    }

//public interface IHasDataModel<TModel>
//{

//}

