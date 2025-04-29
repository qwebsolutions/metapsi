using System.Text;
using System.Web;
using System;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Metapsi.Html;

public static partial class CustomElementExtensions
{
    private const string ExternalScriptName = "metapsi-custom-elements";

    /// <summary>
    /// Gets a custom element tag name based on T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>tag name</returns>
    public static string GetCustomElementTagName<T>()
    {
        return GetCustomElementTagName(typeof(T));
    }

    /// <summary>
    /// Gets a custom element tag name based on t
    /// </summary>
    /// <param name="t"></param>
    /// <returns></returns>
    public static string GetCustomElementTagName(Type t)
    {
        var genericTypes = string.Join("-", t.GenericTypeArguments.Select(x => x.Name.ToLower().Replace("`", string.Empty)));
        if (!string.IsNullOrEmpty(genericTypes))
        {
            genericTypes = $"-{genericTypes}";
        }
        var nestedClassName = t.CSharpTypeName().ToLower().Replace(".", "-").Replace("`", string.Empty);
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
    /// Define a render/attach/cleanup custom element
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="render"></param>
    /// <param name="attach"></param>
    /// <param name="cleanup"></param>
    public static void DefineCustomElement(
        this SyntaxBuilder b,
        Var<string> tagName,
        Var<Action<Element>> render,
        Var<Action<Element>> attach,
        Var<Action<Element>> cleanup)
    {
        b.AddScript(typeof(CustomElementExtensions).Assembly, $"{ExternalScriptName}.js", "module");
        var scriptTags = b.Module.GetDistinctTags("script");
        var stylesheets = b.Module.GetDistinctTags("link");

        var contentElement = b.Ref(b.NewObj<DynamicObject>().As<Element>());

        b.CallExternal(
            ExternalScriptName,
            "defineRACCustomElement",
            tagName,
            render,
            attach,
            cleanup);
    }

    /// <summary>
    /// Define a render/attach/cleanup custom element
    /// </summary>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="render"></param>
    /// <param name="attach"></param>
    /// <param name="cleanup"></param>
    public static void DefineCustomElement(
        this SyntaxBuilder b,
        string tagName,
        Action<SyntaxBuilder, Var<Element>> render,
        Action<SyntaxBuilder, Var<Element>> attach = null,
        Action<SyntaxBuilder, Var<Element>> cleanup = null)
    {
        if (attach == null) attach = (SyntaxBuilder b, Var<Element> node) => { };
        if (cleanup == null) cleanup = (SyntaxBuilder b, Var<Element> node) => { };

        var jsRender = b.Def("render", render);
        var jsAttach = b.Def("attach", attach);
        var jsCleanup = b.Def("cleanup", cleanup);
        b.DefineCustomElement(b.Const(tagName), jsRender, jsAttach, jsCleanup);
    }

    /// <summary>
    /// Define a Hyperapp custom element
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="init"></param>
    /// <param name="render"></param>
    /// <param name="subscriptions"></param>
    /// <remarks>The render function must return b.H(tagName) as root element</remarks>
    public static void DefineCustomElement<TModel>(
        this SyntaxBuilder b,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        var tagName = GetCustomElementTagName<TModel>();

        Reference<HyperType.Dispatcher> dispatchRef = new();
        b.DefineCustomElement(
            tagName,
            render: (SyntaxBuilder b, Var<Element> node) =>
            {
                var dispatch = b.GetRef(b.GlobalRef(dispatchRef)).As<HyperType.Dispatcher>();
                b.If(
                    b.Not(b.HasObject(dispatch)),
                    b =>
                    {
                        var appConfig = b.NewObj<HyperType.App<TModel>>();

                        var view = b.Def((LayoutBuilder b, Var<TModel> model) =>
                        {
                            var outNode = render(b, tagName, model);
                            return outNode;
                        });

                        b.Set(appConfig, x => x.view, view);
                        b.Set(appConfig, x => x.init, b.Call(init, node.As<Element>()).As<HyperType.Init>());
                        //b.Set(appConfig, x => x.node, b.Get(node, x => x.shadowRoot).As<Element>());
                        b.Set(appConfig, x => x.node, node);
                        b.Set(appConfig, x => x.subscriptions, b.MakeSubscriptions<TModel>(subscriptions.ToList()));

                        var dispatch = b.App(appConfig.As<HyperType.App<TModel>>());
                        b.SetRef(b.GlobalRef(dispatchRef), dispatch);
                    },
                    b =>
                    {
                        b.Dispatch(dispatch, b.MakeAction((SyntaxBuilder b, Var<TModel> model) =>
                        {
                            return b.Call(init, node);
                        }));
                    });
            },
            attach: (SyntaxBuilder b, Var<Element> node) =>
            {
                //var shadowRoot = b.ElementAttachShadow(node, b => b.Set(x => x.mode, "open"));
            },
            cleanup: (SyntaxBuilder b, Var<Element> node) =>
            {
                b.Call(b.GetRef(b.GlobalRef(dispatchRef)).As<System.Action>());
                // Remove dispatcher so the controls gets rendered when reused
                b.SetRef(b.GlobalRef(dispatchRef), b.Get<bool, HyperType.Dispatcher>(b.Const(false), x => null));
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
        return b.HtmlScriptModule(b =>
        {
            b.DefineCustomElement(tagName, render, attach, cleanup);
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

        return b.HtmlScriptModule(
            b =>
            {
                b.DefineCustomElement(init, render, subscriptions);
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

    public static string AddCustomElement<TModel, TInitProps>(
        this HtmlBuilder b,
        Func<SyntaxBuilder, Var<TInitProps>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
        where TModel: new()
    {
        var customElementScript = b.HtmlCustomElement(
            (SyntaxBuilder b, Var<Element> element) =>
            {
                var initProps = b.GetInitProps<TInitProps>(element);
                return b.If(
                    b.HasObject(initProps),
                    b =>
                    {
                        return b.Call(init, initProps);
                    },
                    b =>
                    {
                        return b.MakeStateWithEffects(b.NewObj<TModel>());
                    });
            },
            render,
            subscriptions);
        b.HeadAppend(customElementScript);
        return b.GetCustomElementTagName<TModel>();
    }

    /// <summary>
    /// Retrieves the 'props' property of element as T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="b"></param>
    /// <param name="e"></param>
    /// <returns></returns>
    public static Var<T> GetInitProps<T>(this SyntaxBuilder b, Var<Element> e)
    {
        var initProps = b.GetProperty<T>(e, "props");
        return initProps;
    }
}

