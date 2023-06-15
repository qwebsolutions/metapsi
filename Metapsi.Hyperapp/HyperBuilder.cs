using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class HyperBuilder
    {
        public static Module BuildModule<TDataModel>(
           Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render,
           Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> initAction = null)
        {
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
                    b.Set(inlineStyle, new DynamicProperty<string>("backgroundColor"), b.Const("white"));
                    b.Set(inlineStyle, new DynamicProperty<string>("color"), b.Const("black"));
                    b.Set(inlineStyle, new DynamicProperty<string>("display"), b.Const("flex"));
                    b.Set(inlineStyle, new DynamicProperty<string>("flex-direction"), b.Const("row"));
                    b.Set(inlineStyle, new DynamicProperty<string>("width"), b.Const("100vw"));
                    b.Set(inlineStyle, new DynamicProperty<string>("height"), b.Const("100vh"));
                    b.Set(inlineStyle, new DynamicProperty<string>("justify-content"), b.Const("center"));
                    b.Set(inlineStyle, new DynamicProperty<string>("align-items"), b.Const("center"));

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
                    b.CallExternal(nameof(Native), "DispatchEvent", b.Const("afterRender"));
                    return rootNode;
                }));
                b.Set(app, x => x.node, b.GetElementById(b.Const("app")));


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

    //    public static string WithVersion(string version)
    //    {
    //        if (string.IsNullOrEmpty(version))
    //            return string.Empty;

    //        return $"?v={version}";
    //    }

    //    public string Render(TDataModel model)
    //    {
    //        System.Text.StringBuilder pageBuilder = new System.Text.StringBuilder();
    //        pageBuilder.AppendLine($"<!DOCTYPE html>");
    //        pageBuilder.AppendLine($"<html lang=\"en\">");
    //        pageBuilder.AppendLine($"<head>");
    //        pageBuilder.AppendLine($"    <meta charset='utf-8'>");
    //        pageBuilder.AppendLine($"    <meta name='viewport' content='width=device-width,initial-scale=1'>");
    //        pageBuilder.AppendLine($"    <title>{GetPageTitle(model)}</title>");

    //        var faviconPath = GetFaviconPath(model);

    //        if (!string.IsNullOrWhiteSpace(faviconPath))
    //        {
    //            pageBuilder.AppendLine($"    <link rel='icon' type='image/x-icon' href='{faviconPath}'>");
    //        }

    //        pageBuilder.AppendLine($"    <base href=\"/\">");
    //        foreach (var linkTag in page.LinkTags)
    //        {
    //            pageBuilder.AppendLine($"<link rel=\"{linkTag.rel}\" href=\"{linkTag.href}{WithVersion(page.Version)}\"/>");
    //        }
    //        foreach (var script in page.ScriptPaths)
    //        {
    //            pageBuilder.AppendLine($"<script src=\"{script}{WithVersion(page.Version)}\"></script>");
    //        }
    //        pageBuilder.AppendLine($"</head>");

    //        if (!string.IsNullOrEmpty(page.BodyCss))
    //        {
    //            pageBuilder.AppendLine($"<body class=\"{page.BodyCss}\">");
    //        }
    //        else
    //        {
    //            pageBuilder.AppendLine($"<body>");
    //        }

    //        pageBuilder.AppendLine($"    <script type=\"module\">");

    //        //pageBuilder.AppendLine($"    {page.PageScript}");
    //        if (!string.IsNullOrWhiteSpace(page.ModuleScriptPath))
    //        {
    //            pageBuilder.AppendLine($"    import {{ main }} from \"{page.ModuleScriptPath}\";");
    //        }
    //        pageBuilder.AppendLine($"    var model = {Metapsi.JavaScript.PrettyBuilder.Serialize(page.InitialModel)}");
    //        if (!string.IsNullOrWhiteSpace(page.PageScript))
    //        {
    //            pageBuilder.AppendLine(page.PageScript);
    //        }

    //        pageBuilder.AppendLine($"    main(model)");
    //        pageBuilder.AppendLine($"    </script>");
    //        pageBuilder.AppendLine($"    <main id=\"app\"></main>");
    //        pageBuilder.AppendLine($"</body>");

    //        return pageBuilder.ToString();
    //    }
    //}
}