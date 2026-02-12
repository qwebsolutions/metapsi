using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public static partial class HyperappExtensions
{
    /// <summary>
    /// Imports 'app' from hyperapp
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Var<Func<HyperType.App<TModel>, HyperType.Dispatcher>> ImportHyperapp<TModel>(this SyntaxBuilder b)
    {
        var resource = b.AddEmbeddedResourceMetadata(typeof(HyperType).Assembly, "hyperapp.js");
        var app = b.ImportName<Func<HyperType.App<TModel>, HyperType.Dispatcher>>(resource, "app");
        return app;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="mountNodeId"></param>
    /// <param name="init"></param>
    /// <param name="view"></param>
    /// <param name="subscriptions"></param>
    /// <returns></returns>
    public static IHtmlNode Hyperapp<TModel>(
        HtmlBuilder b,
        string mountNodeId,
        Func<SyntaxBuilder, Var<HyperType.Init>> init = null,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view = null,
        Func<SyntaxBuilder, Var<Func<TModel, List<HyperType.Subscription>>>> subscriptions = null)
    {
        ModuleBuilder moduleBuilder = new ModuleBuilder();
        var main = moduleBuilder.AddFunction<HyperType.Dispatcher>("main", b =>
        {
            var appConfig = b.NewObj().As<HyperType.App<TModel>>();
            if (init != null)
            {
                b.Set(appConfig, x => x.init, b.Call(init));
            }
            if (view != null)
            {
                b.Set(appConfig, x => x.view, b.Def(view));
            }
            b.Set(appConfig, x => x.node, b.GetElementById(b.Const(mountNodeId)));
            if (subscriptions != null)
            {
                b.Set(appConfig, x => x.subscriptions, b.Call(subscriptions));
            }

            return b.Hyperapp(appConfig);;
        });

        HtmlScriptExtensions.GenerateAddExternalResources(b, moduleBuilder.Module);
        foreach(var moduleMetadata in moduleBuilder.Module.Metadata)
        {
            b.Document.Metadata.Add(moduleMetadata);
        }

        moduleBuilder.Module.Nodes.Add(
            new SyntaxNode()
            {
                Call = new CallNode()
                {
                    Fn = new SyntaxNode()
                    {
                        Identifier = new IdentifierNode()
                        {
                            Name = "main"
                        }
                    }
                }
            });

        //var moduleScript = moduleBuilder.Module.ToJs();

        var outNode = new HtmlNode();
        var divTag = new HtmlTag("div");
        divTag.SetAttribute("id", mountNodeId);

        var scriptTag = new HtmlTag("script");
        scriptTag.SetAttribute("type", "module");
        scriptTag.Children.Add(new HtmlNode()
        {
            Modules = new List<Module>() { moduleBuilder.Module },
        });

        return new HtmlNode()
        {
            Tags = new() { divTag, scriptTag }
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="init"></param>
    /// <param name="view"></param>
    /// <param name="subscriptions"></param>
    /// <returns></returns>
    public static IHtmlNode Hyperapp<TModel>(
        HtmlBuilder b,
        Func<SyntaxBuilder, Var<HyperType.Init>> init = null,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view = null,
        Func<SyntaxBuilder, Var<Func<TModel, List<HyperType.Subscription>>>> subscriptions = null)
    {
        string mountNodeId = "id-" + Guid.NewGuid().ToString();
        return Hyperapp(b, mountNodeId, init, view, subscriptions);
    }

    /// <summary>
    /// Initializes and mounts a Hyperapp application.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="appConfig"></param>
    /// <returns>The dispatch function your app uses.</returns>
    public static Var<HyperType.Dispatcher> Hyperapp<TModel>(
        this SyntaxBuilder b,
        Var<HyperType.App<TModel>> appConfig)
    {
        var app = ImportHyperapp<TModel>(b);
        return b.Call(app, appConfig);
    }

    public static IHtmlNode Hyperapp<TModel>(
        this HtmlBuilder b,
        Func<SyntaxBuilder, Var<HyperType.Init>> init,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        return Hyperapp(b, init, view, b => b.MakeSubscriptions(subscriptions));
    }

    public static IHtmlNode Hyperapp<TModel>(
        this HtmlBuilder b,
        TModel model,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        return b.Hyperapp(
            init: b => b.MakeInit(b.Const(model)),
            view: view,
            subscriptions: subscriptions);
    }

    public static Var<Func<TModel, List<HyperType.Subscription>>> MakeSubscriptions<TModel>(
        this SyntaxBuilder b,
        Var<List<Func<TModel, HyperType.Subscription>>> subscriptions)
    {
        return b.Def((SyntaxBuilder b, Var<TModel> model) =>
        {
            var appSubscriptions = b.NewCollection<HyperType.Subscription>();
            b.Foreach(subscriptions, (b, subscription) =>
            {
                b.Push(appSubscriptions, b.Call(subscription, model));
            });
            return appSubscriptions;
        });
    }

    public static Var<Func<TModel, List<HyperType.Subscription>>> MakeSubscriptions<TModel>(
        this SyntaxBuilder b,
        List<Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>> subscriptions)
    {
        return b.MakeSubscriptions(b.List(subscriptions.Select(x => b.Def(x))));
    }

    public static Var<Func<TModel, List<HyperType.Subscription>>> MakeSubscriptions<TModel>(
        this SyntaxBuilder b,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        return b.MakeSubscriptions(subscriptions.ToList());
    }

    /// <summary>
    /// Sets the initial state directly.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="model"></param>
    public static void SetInitModel<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Var<TModel> model)
    {
        b.Set(x => x.init, b.MakeInit(model));
    }

    /// <summary>
    /// Sets the initial state directly
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="model"></param>
    public static void SetInitModel<TModel>(this PropsBuilder<HyperType.App<TModel>> b, TModel model)
    {
        b.Set(x => x.init, b.MakeInit(b.Const(model)));
    }

    /// <summary>
    /// Runs the given Action. This form is useful when the action can be reused later. The state passed to the action in this case is undefined.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="action"></param>
    public static void SetInitAction<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Var<HyperType.Action<TModel>> action)
    {
        b.Set(x => x.init, b.MakeInit(action));
    }

    /// <summary>
    /// Sets the initial state and then runs the given list of effects.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="stateWithEffects"></param>
    public static void SetInitEffects<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Var<HyperType.StateWithEffects> stateWithEffects)
    {
        b.Set(x => x.init, b.MakeInit(stateWithEffects));
    }

    /// <summary>
    /// The top-level view that represents the app as a whole. 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="render"></param>
    public static void SetView<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Var<Func<TModel, IVNode>> render)
    {
        b.Set(x => x.view, render);
    }

    /// <summary>
    /// The DOM element to render the virtual DOM over (the mount node). The given element is replaced by a Hyperapp application. 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="node"></param>
    public static void SetNode<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Var<Element> node)
    {
        b.Set(x => x.node, node);
    }

    /// <summary>
    /// A function that returns an array of subscriptions for a given state.
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="subscriptions"></param>
    public static void SetSubscriptions<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Var<Func<TModel, List<HyperType.Subscription>>> subscriptions)
    {
        b.Set(x=>x.subscriptions, subscriptions);
    }

    /// <summary>
    /// Sets subscriptions
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="buildSubscriptions"></param>
    public static void SetSubscriptions<TModel>(this PropsBuilder<HyperType.App<TModel>> b, Action<PropsBuilder<List<Func<TModel, HyperType.Subscription>>>> buildSubscriptions)
    {
        var subscriptions = b.SetProps(b.NewCollection<Func<TModel, HyperType.Subscription>>(), buildSubscriptions);
        b.Set(x => x.subscriptions, b.MakeSubscriptions(subscriptions));
    }

    /// <summary>
    /// Adds subscription
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="subscription"></param>
    public static void AddSubscription<TModel>(this PropsBuilder<List<Func<TModel, HyperType.Subscription>>> b, Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>> subscription)
    {
        b.Push(b.Props, b.Def(subscription));
    }

    /// <summary>
    /// Adds subscription
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <param name="b"></param>
    /// <param name="subscription"></param>
    public static void AddSubscription<TModel>(this PropsBuilder<List<Func<TModel, HyperType.Subscription>>> b, Func<SyntaxBuilder, Var<HyperType.Subscription>> subscription)
    {
        b.Push(b.Props, b.Def((SyntaxBuilder b, Var<TModel> model) => b.Call(subscription)));
    }
}
