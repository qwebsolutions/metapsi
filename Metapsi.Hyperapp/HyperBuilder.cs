using Metapsi.Syntax;
using Metapsi.Dom;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class HyperBuilder
    {
        public static Module BuildHyperapp<TDataModel>(
            this ModuleBuilder moduleBuilder,
            Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
            Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> initAction = null,
            string mountDivId = null)
        {
            if (mountDivId == null)
                mountDivId = "app";

            ModuleBuilder b = new ModuleBuilder();

            b.Define("main", (BlockBuilder b, Var<TDataModel> model) =>
            {
                Var<HyperType.Init> init = null;

                if (initAction == null)
                {
                    init = b.MakeInit(b.Def((BlockBuilder b) =>
                    {
                        return model;
                    }));
                }
                else
                {
                    init = b.MakeInit(b.Def((BlockBuilder b) =>
                    {
                        return b.Call(initAction, model);
                    }));
                }

                var onRenderError = (BlockBuilder b, Var<TDataModel> model, Var<DynamicObject> error) =>
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

                    var errorDiv = b.Div("", b => b.TextNode("An error has occurred"));
                    b.SetAttr(errorDiv, new DynamicProperty<DynamicObject>("style"), inlineStyle);

                    return errorDiv;
                };

                var app = b.NewObj<HyperType.App<TDataModel>>();
                b.Set(app, x => x.init, init);
                b.Set(app, x => x.view, b.Def((BlockBuilder b, Var<TDataModel> model) =>
                {
                    var r = b.Def(render);
                    var rootNode = b.TryCatchReturn<HyperNode>(
                        b.Def(b => b.Call(r, model)),
                        b.Def((BlockBuilder b, Var<DynamicObject> error) =>
                        {
                            return b.Call(onRenderError, model, error);
                        }));
                    b.DispatchEvent(b.Const("afterRender"));
                    return rootNode;
                }));
                b.Set(app, x => x.node, b.GetElementById(b.Const(mountDivId)));


                //var subFuncs2 = b.Module.Constants.Where(x => x.Value is IFunction);
                var subFuncs = b.Module.Functions.Where(x => x.ReturnVariable.Type == typeof(HyperType.Subscription) && x.Parameters.Count == 1 && (x.Parameters.First().Type == typeof(TDataModel) || x.Parameters.First().Type == typeof(object)));
                var aggSubs = b.ModuleBuilder.Define("PageSubscriptions", (BlockBuilder b, Var<TDataModel> state) =>
                {
                    var subscriptions = b.NewCollection<HyperType.Subscription>();
                    foreach (var subBuilder in subFuncs)
                    {
                        var fakeFunc = new Var<object>(subBuilder.Name);
                        var sub = b.CallFunction<HyperType.Subscription>(fakeFunc, state);
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
}