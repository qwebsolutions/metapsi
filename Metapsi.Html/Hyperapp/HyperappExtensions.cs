﻿using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using System.Collections.Generic;
using System.Linq;
using System;
using Metapsi.Dom;

namespace Metapsi.Html;

public static partial class HyperappExtensions
{
    internal class HyperAppNode : IHtmlNode
    {
        public IHtmlNode MountDiv { get; set; }
        public IHtmlNode ScriptTag { get; set; }
        string IHtmlNode.ToHtml()
        {
            return $"{MountDiv.ToHtml()}\n{ScriptTag.ToHtml()}";
        }
    }

    // This is the base hyperapp app call, but it's going to be called less often than the other overrides
    // so, no 'this' on this
    public static IHtmlNode Hyperapp<TModel>(
        HtmlBuilder b,
        Func<SyntaxBuilder, Var<HyperType.Init>> init = null,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view = null,
        Func<SyntaxBuilder, Var<Func<TModel, List<HyperType.Subscription>>>> subscriptions = null)
    {
        string mountDivId = "id-" + Guid.NewGuid().ToString();

        ModuleBuilder moduleBuilder = new ModuleBuilder();
        var main = moduleBuilder.Define("main", b =>
        {
            var appConfig = b.NewObj<HyperType.App<TModel>>();
            if (init != null)
            {
                b.Set(appConfig, x => x.init, b.Call(init));
            }
            if (view != null)
            {
                b.Set(appConfig, x => x.view, b.Def(view));
            }
            b.Set(appConfig, x => x.node, b.GetElementById(b.Const(mountDivId)));
            if (subscriptions != null)
            {
                b.Set(appConfig, x => x.subscriptions, b.Call(subscriptions));
            }

            return b.App(appConfig);
        });

        var usesExternalResources = GenerateAddExternalResources(moduleBuilder);

        var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(moduleBuilder.Module);

        return new HyperAppNode()
        {
            MountDiv = b.HtmlDiv(b =>
            {
                b.SetAttribute("id", mountDivId);
            }),
            ScriptTag = b.HtmlScript(
                b =>
                {
                    b.SetAttribute("type", "module");
                },
                b.Text(moduleScript),
                usesExternalResources ? b.Text("addExternalResources(() => {var dispatch = main()});") : b.Text(string.Empty),
                !usesExternalResources ? b.Text("var dispatch = main()") : b.Text(string.Empty))
        };
    }

    public static IHtmlNode Hyperapp<TModel>(
        this HtmlBuilder b,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view,
        params Func<SyntaxBuilder, Var<TModel>, Var<HyperType.Subscription>>[] subscriptions)
    {
        return Hyperapp(b, view: view, subscriptions: b => b.MakeSubscriptions(subscriptions));
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

    public static bool GenerateAddExternalResources(ModuleBuilder b)
    {
        var distinctTags = b.Module.Consts.Where(x => x.Value is DistinctTag).Distinct().ToList();// are already distinct anyway

        if (!distinctTags.Any())
            return false;

        var addExternalResourcesFn = b.Define("addExternalResources", (SyntaxBuilder b, Var<Action> callback) =>
        {
            var scriptLoadPromises = b.NewCollection<Promise>();

            var head = b.QuerySelector("head");
            foreach (var tag in distinctTags)
            {
                switch (tag.Value)
                {
                    case LinkTag linkTag:
                        {
                            var alreadyPresent = b.QuerySelector(head, $"link[href='{linkTag.href}']");
                            b.If(
                                b.Not(b.HasObject(alreadyPresent)),
                                b =>
                                {

                                    var element = b.CreateElement(b.Const("link"));
                                    b.SetAttribute(element, b.Const("rel"), b.Const(linkTag.rel));
                                    b.SetAttribute(element, b.Const("href"), b.Const(linkTag.href));
                                    b.AppendChild(head, element);
                                });
                        }
                        break;
                    case ExternalScriptTag externalScriptTag:
                        {
                            var callbacks = b.Def((SyntaxBuilder b, Var<Action<object>> resolve, Var<Action<object>> reject) =>
                            {
                                var alreadyPresent = b.QuerySelector(head, $"script[src='{externalScriptTag.src}']");
                                b.If(
                                    b.Not(b.HasObject(alreadyPresent)),
                                    b =>
                                    {
                                        var element = b.CreateElement(b.Const("script"));
                                        b.SetAttribute(element, b.Const("src"), b.Const(externalScriptTag.src));
                                        if (!string.IsNullOrEmpty(externalScriptTag.type))
                                        {
                                            b.SetAttribute(element, b.Const("type"), b.Const(externalScriptTag.type));
                                        }
                                        b.AppendChild(head, element);
                                        b.AddEventListener(element, b.Const("load"), b.Def((SyntaxBuilder b) =>
                                        {
                                            b.Call(resolve, b.NewObj<object>());
                                        }));
                                    },
                                    b=>
                                    {
                                        b.Call(resolve, b.NewObj<object>());
                                    });
                            });

                            var promise = b.NewPromise(callbacks);
                            b.Push(scriptLoadPromises, promise);
                        }
                        break;
                    case ScriptTag scriptTag:
                        {
                            // TODO: Check if it already exists as well
                            var element = b.CreateElement(b.Const("script"));
                            if (!string.IsNullOrEmpty(scriptTag.type))
                            {
                                b.SetAttribute(element, b.Const("type"), b.Const(scriptTag.type));
                            }
                            var content = b.CreateTextNode(scriptTag.content);
                            b.AppendChild(element, content);
                            b.AppendChild(head, element);
                        }
                        break;
                }
            }

            b.Then(
                b.PromiseAll(scriptLoadPromises),
                b.Def((SyntaxBuilder b, Var<object> success) =>
                {
                    b.Call(callback);
                }),
                b.Def((SyntaxBuilder b, Var<object> failure) =>
                {
                    b.Log(failure);
                }));
        });

        return true;
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

    public static Var<HyperType.Dispatcher> App<TModel>(this SyntaxBuilder b, Var<HyperType.App<TModel>> appConfig)
    {
        // it seems there's something wrong with passing null values? 
        // just copy in another object

        var app = b.SetProps<HyperType.App<TModel>>(
            b.NewObj<DynamicObject>(),
            b =>
            {
                b.SetIfExists(x => x.init, b.Get(appConfig, x => x.init));
                b.SetIfExists(x => x.view, b.Get(appConfig, x => x.view));
                b.SetIfExists(x => x.node, b.Get(appConfig, x => x.node));
                b.SetIfExists(x => x.subscriptions, b.Get(appConfig, x => x.subscriptions));
                b.SetIfExists(x => x.dispatch, b.Get(appConfig, x => x.dispatch));
            });

        return b.CallExternal<HyperType.Dispatcher>("hyperapp", "app", app);
    }
}
