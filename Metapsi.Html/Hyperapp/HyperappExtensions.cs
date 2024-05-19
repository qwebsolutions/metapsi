using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using System.Collections.Generic;
using System.Linq;
using System;
using Metapsi.Dom;

namespace Metapsi.Html;

public static partial class SubscribeTo
{
    public static Var<HyperType.Subscription> ModelUpdate<TModel>(SyntaxBuilder b)
    {
        return b.Listen<TModel, TModel>(
            b.Const($"modelUpdated_{typeof(TModel).Name}"),
            b.MakeAction((SyntaxBuilder b, Var<TModel> model, Var<TModel> incomingModel) =>
            {
                return incomingModel;
            }));
    }

    public static Func<SyntaxBuilder, Var<HyperType.Subscription>> SubscribeToModelUpdate<TModel>(this HtmlBuilder b)
    {
        return ModelUpdate<TModel>;
    }
}

public static class HyperappExtensions
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

    public static IHtmlNode Hyperapp<TModel>(
        this HtmlBuilder b,
        Func<SyntaxBuilder, Var<HyperType.Init>> init,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view,
        params Func<SyntaxBuilder, Var<HyperType.Subscription>>[] subscriptions)
    {
        string mountDivId = "id-" + Guid.NewGuid().ToString();

        ModuleBuilder moduleBuilder = new ModuleBuilder();
        var main = moduleBuilder.Define("main", b =>
        {
            var appConfig = b.NewObj<HyperType.App<TModel>>();
            b.Set(appConfig, x => x.init, b.Call(init));
            b.Set(appConfig, x => x.view, b.Def(view));
            b.Set(appConfig, x => x.node, b.GetElementById(b.Const(mountDivId)));
            b.Set(appConfig, x => x.subscriptions, b.MakeSubscriptionsFunction<TModel>(subscriptions.ToList()));

            return b.App(appConfig);
        });

        var usesExternalResources = GenerateAddExternalResources(moduleBuilder);

        var moduleScript = Metapsi.JavaScript.PrettyBuilder.Generate(moduleBuilder.Module, "");

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
                usesExternalResources ? b.Text("addExternalResources();") : b.Text(string.Empty),
                b.Text("var dispatch = main()"))
        };
    }

    public static bool GenerateAddExternalResources(ModuleBuilder b)
    {
        var distinctTags = b.Module.Consts.Where(x => x.Value is DistinctTag).Distinct().ToList();// are already distinct anyway

        if (!distinctTags.Any())
            return false;

        var addExternalResourcesFn = b.Define("addExternalResources", b =>
        {
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
                                });
                        }
                        break;
                    case ScriptTag scriptTag:
                        {
                            // TODO: Check if it already exists as well
                            var element = b.CreateElement(b.Const("script"));

                            b.SetAttribute(element, b.Const("innerHTML"), b.Const(scriptTag.content));
                            if (!string.IsNullOrEmpty(scriptTag.type))
                            {
                                b.SetAttribute(element, b.Const("type"), b.Const(scriptTag.type));
                            }
                            b.AppendChild(head, element);
                        }
                        break;
                }
            }
        });

        return true;
    }

    public static Var<Func<TModel, List<HyperType.Subscription>>> MakeSubscriptionsFunction<TModel>(
        this SyntaxBuilder b, 
        List<Func<SyntaxBuilder, Var<HyperType.Subscription>>> subscriptions)
    {
        return b.Def((SyntaxBuilder b, Var<TModel> model) =>
        {
            var clientSideSubscriptions = b.NewCollection<HyperType.Subscription>();
            foreach (var subscription in subscriptions)
            {
                b.Push(clientSideSubscriptions, b.Call(subscription));
            }
            return clientSideSubscriptions;
        });
    }

    public static IHtmlNode Hyperapp<TModel>(
        this HtmlBuilder b,
        TModel model,
        Func<LayoutBuilder, Var<TModel>, Var<IVNode>> view,
        params Func<SyntaxBuilder, Var<HyperType.Subscription>>[] subscriptions)
    {
        return b.Hyperapp(
            b => b.MakeInit(b.Const(model)),
            view,
            subscriptions);
    }

    public static Var<HyperType.Dispatcher<TModel>> App<TModel>(this SyntaxBuilder b, Var<HyperType.App<TModel>> appConfig)
    {
        // it seems there's something wrong with passing null values? 
        // just copy in another object

        var untypedConfig = b.NewObj<DynamicObject>();

        var init = b.Get(appConfig, x => x.init);
        b.If(b.HasObject(init), b => b.SetProperty(untypedConfig, b.Const("init"), init));

        var view = b.Get(appConfig, x => x.view);
        b.If(b.HasObject(view), b => b.SetProperty(untypedConfig, b.Const("view"), view));

        var node = b.Get(appConfig, x => x.node);
        b.If(b.HasObject(node), b => b.SetProperty(untypedConfig, b.Const("node"), node));

        var subscriptions = b.Get(appConfig, x => x.subscriptions);
        b.If(b.HasObject(subscriptions), b => b.SetProperty(untypedConfig, b.Const("subscriptions"), subscriptions));

        var dispatch = b.Get(appConfig, x => x.dispatch);
        b.If(b.HasObject(dispatch), b => b.SetProperty(untypedConfig, b.Const("dispatch"), dispatch));

        return b.CallExternal<HyperType.Dispatcher<TModel>>("hyperapp", "app", untypedConfig);
    }

    private static Module BuildHyperappModule<TDataModel>(
        Func<LayoutBuilder, Var<TDataModel>, Var<IVNode>> render,
        Func<SyntaxBuilder, Var<HyperType.StateWithEffects>> initAction,
        string mountDivId)
    {
        ModuleBuilder b = new ModuleBuilder();

        b.Define("main", (SyntaxBuilder b, Var<TDataModel> model) =>
        {
            Var<HyperType.Init> init = b.MakeInit(b.Def((SyntaxBuilder b) =>
            {
                return b.Call(initAction);
            }));

            var onRenderError = (LayoutBuilder b, Var<TDataModel> model, Var<DynamicObject> error) =>
            {
                b.Log(error);
                b.Log(model);

                Var<DynamicObject> inlineStyle = b.NewObj<DynamicObject>();
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("backgroundColor"), b.Const("white"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("color"), b.Const("black"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("display"), b.Const("flex"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("flex-direction"), b.Const("row"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("width"), b.Const("100vw"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("height"), b.Const("100vh"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("justify-content"), b.Const("center"));
                b.SetDynamic(inlineStyle, new DynamicProperty<string>("align-items"), b.Const("center"));

                var props = b.NewObj<DynamicObject>();
                b.SetDynamic(props, new DynamicProperty<DynamicObject>("style"), inlineStyle);

                //var errorDiv = b.Div(props, b.T("An error has occurred"));
                return b.H("div", props, b.Text("An error has occurred"));
            };

            LayoutBuilder layoutBuilder = new LayoutBuilder();
            layoutBuilder.InitializeFrom(b);

            var app = b.NewObj<HyperType.App<TDataModel>>();
            b.Set(app, x => x.init, init);
            b.Set(app, x => x.view, layoutBuilder.Def<LayoutBuilder, TDataModel, IVNode>((LayoutBuilder b, Var<TDataModel> model) =>
            {
                var r = b.Def(render);
                var rootNode = b.TryCatchReturn<IVNode>(
                    b.Def((LayoutBuilder b) => b.Call(r, model)),
                    b.Def((LayoutBuilder b, Var<DynamicObject> error) =>
                    {
                        return b.Call(onRenderError, model, error);
                    }));
                b.DispatchEvent(b.Const("afterRender"));
                return rootNode;
            }));
            b.Set(app, x => x.node, b.GetElementById(b.Const(mountDivId)));


            var subFuncs = b.Module.Functions.Where(x => x.ReturnVariable.Type == typeof(HyperType.Subscription) && x.Parameters.Count == 1 && (x.Parameters.First().Type == typeof(TDataModel) || x.Parameters.First().Type == typeof(object)));
            var aggSubs = b.Def("PageSubscriptions", (SyntaxBuilder b, Var<TDataModel> state) =>
            {
                var subscriptions = b.NewCollection<HyperType.Subscription>();
                foreach (var subBuilder in subFuncs)
                {
                    var fakeFunc = new Var<Func<TDataModel, HyperType.Subscription>>(subBuilder.Name);
                    var sub = b.Call(fakeFunc, state);
                    b.Push(subscriptions, sub);
                }
                return subscriptions;
            });

            b.Set(app, x => x.subscriptions, aggSubs.As<Func<TDataModel, List<HyperType.Subscription>>>());

            b.CallExternal("hyperapp", "app", app);
        });

        return b.Module;
    }
}
