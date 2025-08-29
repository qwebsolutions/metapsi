using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Linq;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static partial class CustomElementExtensions
{
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
    /// Define a Hyperapp-based custom element
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="init"></param>
    /// <param name="render"></param>
    /// <param name="subscribeFn"></param>
    public static void DefineCustomElement<TModel>(
        this SyntaxBuilder b,
        Var<string> tagName,
        Var<Func<Element, HyperType.StateWithEffects>> init,
        Var<Func<string, TModel, IVNode>> render,
        Var<Func<TModel, System.Collections.Generic.List<HyperType.Subscription>>> subscribeFn)
    {
        Reference<HyperType.Dispatcher> dispatchRef = new();
        b.DefineCustomElement(
            tagName,
            render: b.Def((SyntaxBuilder b, Var<Element> node) =>
            {
                var dispatch = b.GetRef(b.GlobalRef(dispatchRef)).As<HyperType.Dispatcher>();
                b.If(
                    b.Not(b.HasObject(dispatch)),
                    b =>
                    {
                        b.Log("Init application", b.Const(tagName));
                        var appConfig = b.NewObj().As<HyperType.App<TModel>>();

                        var view = b.Def((LayoutBuilder b, Var<TModel> model) =>
                        {
                            var outNode = b.Call(render, tagName, model);
                            b.Log("view outNode", outNode);
                            return outNode;
                        });

                        b.Set(appConfig, x => x.view, view);
                        b.Set(appConfig, x => x.init, b.Call(init, node.As<Element>()).As<HyperType.Init>());
                        b.Set(appConfig, x => x.node, node);
                        b.Set(appConfig, x => x.subscriptions, subscribeFn);
                        b.SetRef(b.GlobalRef(dispatchRef), b.Hyperapp(appConfig));
                    },
                    b =>
                    {
                        b.Log("Re-init", b.Const(tagName));
                        b.Dispatch(dispatch, b.MakeAction((SyntaxBuilder b, Var<TModel> model) =>
                        {
                            return b.Call(init, node);
                        }));
                    });
            }),
            attach: b.Def((SyntaxBuilder b, Var<Element> node) =>
            {
                b.Log("Empty attach in constructor", b.Const(tagName));
                //var shadowRoot = b.ElementAttachShadow(node, b => b.Set(x => x.mode, "open"));
            }),
            cleanup: b.Def((SyntaxBuilder b, Var<Element> node) =>
            {
                b.Call(b.GetRef(b.GlobalRef(dispatchRef)).As<System.Action>());
                b.Log("Dispatch null for cleanup", b.Const(tagName));
                // Remove dispatcher so the controls gets rendered when reused
                b.SetRef(b.GlobalRef(dispatchRef), b.Get<bool, HyperType.Dispatcher>(b.Const(false), x => null));
                b.Log("Unset app", b.Const(tagName));
            }));
    }

    /// <summary>
    /// Define a Hyperapp custom element
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="init"></param>
    /// <param name="render"></param>
    /// <param name="subscriptions"></param>
    /// <remarks>The render function must return b.H(tagName) as root element</remarks>
    public static void DefineCustomElement<TModel>(
        this SyntaxBuilder b,
        string tagName,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        b.DefineCustomElement(
            b.Const(tagName),
            b.Def(init),
            b.Def(render),
            b.MakeSubscriptions(subscriptions.ToList()));
    }

    /// <summary>
    /// Define a Hyperapp custom element
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="tagName"></param>
    /// <param name="init"></param>
    /// <param name="render"></param>
    /// <param name="subscriptionFn"></param>
    public static void DefineCustomElement<TModel>(
        this SyntaxBuilder b,
        string tagName,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> render,
        Func<SyntaxBuilder, Var<TModel>, Var<System.Collections.Generic.List<HyperType.Subscription>>> subscriptionFn)
    {
        b.DefineCustomElement(
            b.Const(tagName),
            b.Def(init),
            b.Def(render),
            b.Def(subscriptionFn));
    }

    /// <summary>
    /// Define a Hyperapp custom element
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="init"></param>
    /// <param name="render"></param>
    /// <param name="subscriptions"></param>
    /// <remarks>The render function must return b.H(tagName) as root element. The tag name is automatically computed from TModel</remarks>
    public static string DefineCustomElement<TModel>(
        this SyntaxBuilder b,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        var tagName = GetCustomElementTagName<TModel>();
        b.DefineCustomElement(tagName, init, render, subscriptions);
        return tagName;
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
        Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> render,
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
        Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> render,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        var customElementScript = b.HtmlCustomElement(init, render, subscriptions);
        b.HeadAppend(customElementScript);
        return b.GetCustomElementTagName<TModel>();
    }

    //public static string AddCustomElement<TModel, TInitProps>(
    //    this HtmlBuilder b,
    //    Func<SyntaxBuilder, Var<TInitProps>, Var<HyperType.StateWithEffects>> init,
    //    Func<LayoutBuilder, string, Var<TModel>, Var<IVNode>> render,
    //    params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    //    where TModel : new()
    //{
    //    var customElementScript = b.HtmlCustomElement(
    //        (SyntaxBuilder b, Var<Element> element) =>
    //        {
    //            var initProps = b.GetInitProps<TInitProps>(element);
    //            return b.If(
    //                b.HasObject(initProps),
    //                b =>
    //                {
    //                    return b.Call(init, initProps);
    //                },
    //                b =>
    //                {
    //                    return b.MakeStateWithEffects(b.NewObj<TModel>());
    //                });
    //        },
    //        render,
    //        subscriptions);
    //    b.HeadAppend(customElementScript);
    //    return b.GetCustomElementTagName<TModel>();
    //}
}
