using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;
using Metapsi.Dom;
using System.Text;
using System;
using System.Collections.Generic;

namespace Metapsi.Hyperapp;

public class HyperAppNode<TModel> : IHtmlNode, IHtmlComponent
{
    public TModel Model { get; set; }
    public string MountDivId { get; set; } = "hyper-node-" + Guid.NewGuid().ToString();
    public Func<LayoutBuilder, Var<TModel>, Var<IVNode>> Render { get; set; }
    public Func<SyntaxBuilder, Var<HyperType.StateWithEffects>> Init { get; set; }

    private Module Module { get; set; }

    void IHtmlComponent.Attach(DocumentTag document, IHtmlElement parentNode)
    {
        this.Module = BuildHyperappModule();

        var moduleRequiredTags = this.Module.Consts.Where(x => x.Value is IHtmlElement).Select(x => x.Value as IHtmlElement);

        foreach (var requiredTag in moduleRequiredTags)
        {
            document.Head.AddChild(requiredTag);
        }

        var webComponentTags = this.Module.Consts.Where(x => x.Value is WebComponentTag);
        foreach (var wcTag in webComponentTags)
        {
            document.AddToFadeInList((wcTag.Value as WebComponentTag).tag);
        }
    }

    string IHtmlNode.ToHtml()
    {
        DivTag mountDiv = new DivTag().SetAttribute("id", MountDivId);
        var js = Metapsi.JavaScript.PrettyBuilder.Generate(this.Module, string.Empty);
        js = js + "main()";


        StringBuilder htmlBuilder = new StringBuilder();
        htmlBuilder.AppendLine(mountDiv.ToHtml());
        htmlBuilder.AppendLine(new ScriptTag(js, "module").ToHtml());

        var html = htmlBuilder.ToString();
        return html;
    }

    public Module BuildHyperappModule()
    {
        if (this.Render == null)
            this.Render = (b, model) => b.T("");

        if (this.Init == null)
            this.Init = b =>
            {
                if (this.Model == null)
                    return b.MakeStateWithEffects(b.Const(string.Empty));
                else
                    return b.MakeStateWithEffects(b.Const(this.Model));
            };

        var module = BuildHyperappModule(this.Render, this.Init, this.MountDivId);

        return module;
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
                return b.H("div", props, b.T("An error has occurred"));
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