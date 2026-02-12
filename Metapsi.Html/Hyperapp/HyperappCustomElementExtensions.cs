using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Html;

public class HyperappCustomElementDefinition
{
    public string Tag { get; set; }
    public Func<Element, HyperType.Init> Init { get; set; }
    public Func<string, object, IVNode> View { get; set; }
    public Func<object, System.Collections.Generic.List<HyperType.Subscription>> SubscribeFn { get; set; }
    public Func<Element, Node> Attach { get; set; }
    public Action<Element> Cleanup { get; set; }
}

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

    public static void DefineCustomElement(
        this SyntaxBuilder b,
        Var<HyperappCustomElementDefinition> definition)
    {
        DefineCustomElement(
            b,
            b.NewObj<ArcCustomElementDefinition>(
                b =>
                {
                    b.Set(x => x.Tag, b.Get(definition, x => x.Tag));
                    b.Set(
                        x => x.Attach,
                        b.Def((SyntaxBuilder b, Var<Element> element) =>
                        {
                            var hyperappAttachFn = b.Get(definition, x => x.Attach);
                            b.If(
                                b.HasObject(hyperappAttachFn),
                                b =>
                                {
                                    var takeoverNode = b.Call(hyperappAttachFn, element);
                                    b.SetProperty(element, "_hNode", takeoverNode);
                                },
                                b =>
                                {
                                    b.SetProperty(element, "_hNode", element);
                                });
                        }));
                        
                    b.Set(x => x.Cleanup, b.Get(definition, x => x.Cleanup));
                    b.Set(x => x.Render, b.Def((SyntaxBuilder b, Var<Element> hostElement) =>
                    {
                        var takeoverNode = b.GetProperty<Node>(hostElement, "_hNode");
                        var rootTag = b.StringToLowerCase(b.GetProperty<string>(takeoverNode, "nodeName"));
                        // Keep dispatch on control itself, because it can be rendered multiple times
                        var dispatch = b.GetProperty<HyperType.Dispatcher>(hostElement, "_hDispatch");
                        b.If(
                            b.Not(b.HasObject(dispatch)),
                            b =>
                            {
                                var appConfig = b.NewObj().As<HyperType.App<object>>();

                                var view = b.Def((LayoutBuilder b, Var<object> model) =>
                                {
                                    var outNode = b.Call(b.Get(definition, x => x.View), rootTag, model);
                                    return outNode;
                                });

                                b.Set(appConfig, x => x.view, view);
                                b.Set(appConfig, x => x.init, b.Call(b.Get(definition, x => x.Init), hostElement));
                                b.Set(appConfig, x => x.node, takeoverNode);
                                b.Set(appConfig, x => x.subscriptions, b.Get(definition, x => x.SubscribeFn));
                                b.SetProperty(hostElement, "_hDispatch", b.Hyperapp(appConfig));
                            });
                    }));
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
            b.NewObj<HyperappCustomElementDefinition>(
                b =>
                {
                    b.Set(x => x.Tag, b.Const(tagName));
                    b.Set(x => x.Init, b.Def(init).As<Func<Element, HyperType.Init>>());
                    b.Set(x => x.View, b.Def(render).As<Func<string, object, IVNode>>());
                    b.Set(x => x.SubscribeFn, b.MakeSubscriptions(subscriptions.ToList()).As<Func<object, List<HyperType.Subscription>>>());
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
    /// <param name="subscriptionFn"></param>
    public static void DefineCustomElement<TModel>(
        this SyntaxBuilder b,
        string tagName,
        Func<SyntaxBuilder, Var<Element>, Var<HyperType.StateWithEffects>> init,
        Func<LayoutBuilder, Var<string>, Var<TModel>, Var<IVNode>> render,
        Func<SyntaxBuilder, Var<TModel>, Var<System.Collections.Generic.List<HyperType.Subscription>>> subscriptionFn)
    {
        b.DefineCustomElement(
            b.NewObj<HyperappCustomElementDefinition>(
                b =>
                {
                    b.Set(x => x.Tag, b.Const(tagName));
                    b.Set(x => x.Init, b.Def(init).As<Func<Element, HyperType.Init>>());
                    b.Set(x => x.View, b.Def(render).As<Func<string, object, IVNode>>());
                    b.Set(x => x.SubscribeFn, b.Def(subscriptionFn).As<Func<object, List<HyperType.Subscription>>>());
                }));
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
}
