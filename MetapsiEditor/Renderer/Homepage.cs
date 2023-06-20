﻿using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Linq;

public static partial class Render
{
    public class Homepage : HyperPage<Handler.Home.Model>
    {
        public override IHtmlNode GetHtml(Handler.Home.Model dataModel)
        {
            var html = base.GetHtml(dataModel);

            var bodyNode = (html as HtmlTag).Children.Single(x => (x is HtmlTag) && (x as HtmlTag).Tag == "body");

            if (bodyNode == null)
            {
                throw new ArgumentException("No body present!");
            }

            //var body = bodyNode as HtmlTag;

            //var eachSecondScript = new HtmlTag("script");

            //eachSecondScript.Children.Add(new HtmlText()
            //{
            //    Text = "setInterval(function () {dispatchEvent(new CustomEvent('metapsi.second.tick')}, 1000);"
            //});

            //body.Children.Add(eachSecondScript);

            return html;
        }

        public override Var<HyperNode> OnRender(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            b.AddStylesheet("metapsi.live.css");

            b.AddSubscription(
                "metapsi_each_second",
                (BlockBuilder b, Var<Handler.Home.Model> model) =>
                {
                    return b.Every<Handler.Home.Model>(
                        b.Const(1000),
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            return b.Switch<HyperType.StateWithEffects, Handler.View>(
                                b.Get(model, x => x.CurrentView),
                                b => b.MakeStateWithEffects(model),
                                (Handler.View.WaitingCompile, b => PoolCompile(b, model)));
                        }));
                });

            return b.Switch(
                b.Get(model, x => x.CurrentView),
                b => ListSolutions(b, model),
                (Handler.View.WaitingCompile, b => WaitCompile(b, model)),
                (Handler.View.ListRenderers, b => ListRenderers(b, model)),
                (Handler.View.FocusRenderer, b => FocusRenderer(b, model)));
        }

        public static Var<HyperType.StateWithEffects> PoolCompile(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.AsyncResult(
                model,
                b.Request<Handler.Home.Model, Frontend.RenderersResponse, bool>(
                    Frontend.GetRenderers,
                    b.Const(true),
                    b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<Frontend.RenderersResponse> result) =>
                    {
                        b.Log(result);
                        return b.If(
                            b.Get(result, x => x.IsLoading),
                            b =>
                            {
                                b.Set(model, x => x.CurrentlyCompiling, b.Get(result, x => x.CurrentlyCompiling));
                                b.Set(model, x => x.CompiledProjects, b.Get(result, x => x.CompiledProjects));
                                return b.Clone(model);
                            },
                            b =>
                            {
                                b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRenderers));
                                b.Set(model, x => x.Renderers, b.Get(result, x => x.Renderers));

                                b.Set(model, x => x.CurrentlyCompiling, b.Const(string.Empty));
                                b.Set(model, x => x.CompiledProjects, b.NewCollection<string>());

                                return b.Clone(model);
                            });
                    })));
        }

        public Var<HyperNode> ListSolutions(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col w-screen h-screen items-center justify-center",
                b => b.Div(
                    "flex flex-col items-center gap-8 border rounded p-4",
                    b => b.Text("Select solution", "font-semibold"),
                    b => b.Div(
                        "flex flex-col items-center gap-2",
                        b.Map(
                            b.Get(model, x => x.Solutions),
                            SelectSolutionButton))));
        }

        public Var<HyperNode> SelectSolutionButton(BlockBuilder b, Var<Metapsi.Live.Db.Solution> sln)
        {
            var button = b.Node("button", "bg-gray-200 hover:bg-gray-300 rounded py-4 px-8", b => b.Text(b.Get(sln, x => x.Path)));

            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                b.Set(model, x => x.SelectedSolutionId, b.Get(sln, x => x.Id));

                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SelectSolution,
                        b.Get(sln, x => x.Id),
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<ApiResponse> result) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.WaitingCompile));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> ListRenderers(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));
            var solutionPath = b.Get(selectedSolution, x => x.Path);

            return b.Div(
                "flex flex-row w-full justify-center",
                b => b.Div(
                    "flex flex-col gap-8 w-1/2",
                    b => b.Text(solutionPath, "font-semibold"),
                    b =>
                    {
                        var icon = "<svg xmlns=\"http://www.w3.org/2000/svg\" fill=\"none\" viewBox=\"0 0 24 24\" stroke-width=\"1.5\" stroke=\"currentColor\" class=\"w-6 h-6\">\r\n  <path stroke-linecap=\"round\" stroke-linejoin=\"round\" d=\"M13.5 6H5.25A2.25 2.25 0 003 8.25v10.5A2.25 2.25 0 005.25 21h10.5A2.25 2.25 0 0018 18.75V10.5m-10.5 6L21 3m0 0h-5.25M21 3v5.25\" />\r\n</svg>\r\n";

                        var previewLink = b.Node("a", "flex flex-row items-center justify-center bg-red-100 rounded p-4");
                        b.SetAttr(previewLink, Html.href, "http://localhost:9999");
                        b.SetAttr(previewLink, new DynamicProperty<string>("target"), b.Const("_blank"));

                        b.Add(previewLink,
                            b.Div(
                                "flex flex-row text-blue-500 gap-4",
                                b => b.TextNode("Preview"),
                                b => b.Svg(icon)));

                        return previewLink;
                    },
                    b => b.Div(
                        "flex flex-col gap-4",
                        b.Map(
                            b.Get(model, x => x.Renderers),
                            SelectRendererButton))));
        }

        public Var<HyperNode> SelectRendererButton(BlockBuilder b, Var<Backend.Renderer> renderer)
        {
            var button = b.Node(
                "button",
                "bg-blue-100 p-4 rounded",
                b => b.Div(
                    "flex flex-col items-center gap-2",
                    b => b.Text(b.Get(renderer, x => x.Name)),
                    b => b.Text(b.Get(renderer, x => x.ProjectName), "text-sm text-gray-600")));

            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SelectRenderer,
                        renderer,
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<Backend.RendererResponse> result) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.FocusRenderer));
                            b.Set(model, x => x.SelectedRenderer, renderer);
                            b.Set(model, x => x.Inputs, b.Get(result, x => x.Inputs));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> WaitCompile(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));
            var solutionPath = b.Get(selectedSolution, x => x.Path);

            return b.Div(
                "flex flex-col w-screen h-screen items-center justify-center",
                b => b.Div(
                    "flex flex-col gap-8",
                    b => b.Text(solutionPath, "font-semibold"),
                    b => b.Div(
                        "flex flex-col gap-2",
                        b.Map(
                            b.Get(model, x => x.CompiledProjects),
                            (b, projectName) => b.Text(projectName))),
                    b => b.Text(b.Concat(b.Const("Compiling "), b.Get(model, x => x.CurrentlyCompiling), b.Const(" ... ")))));
        }

        public Var<HyperNode> FocusRenderer(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));
            var solutionPath = b.Get(selectedSolution, x => x.Path);

            var rendererName = b.Get(model, x => x.SelectedRenderer.Name);
            var projectName = b.Get(model, x => x.SelectedRenderer.ProjectName);

            return b.Div(
                "flex flex-col items-center gap-8 p-8",
                b =>
                {
                    var sln = b.Node("button", "", b => b.Text(solutionPath));

                    b.SetOnClick(sln, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                    {
                        b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRenderers));
                        return b.Clone(model);
                    }));

                    return sln;
                },
                b => b.Text(rendererName),
                b => b.Text(projectName, "text-sm text-gray-500"),
                b => b.Div(
                    "flex flex-col",
                    b.Map(b.Get(model, x => x.SelectedRenderer.FileNames), (b, path) => b.Text(path))),
                b => AddInputButton(b, model),
                b => b.Div(
                    "flex flex-col gap-4 w-1/2",
                    b.Map(
                        b.Get(model, x => x.Inputs),
                        (b, input) =>
                        SelectInputButton(
                            b,
                            input,
                            b.Get(
                                model,
                                b.Get(input, x => x.Id),
                                (model, currentInputId) => model.SelectedInputId == currentInputId)))));
        }

        public Var<HyperNode> AddInputButton(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var addInputButton = b.Node("button", "w-10 h-10 flex flex-col items-center justify-center rounded bg-green-100 font-bold text-lg", b => b.Text("+"));

            b.SetOnClick(addInputButton, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    model,
                    b.Request(
                        Frontend.AddRendererInput,
                        b.Get(model, x => x.SelectedRenderer.Name),
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<Backend.RendererResponse> response) =>
                        {
                            b.Set(model, x => x.Inputs, b.Get(response, x => x.Inputs));
                            return b.Clone(model);
                        })));
            }));

            return addInputButton;
        }

        public Var<HyperNode> SelectInputButton(BlockBuilder b, Var<Metapsi.Live.Db.Input> input, Var<bool> isSelected)
        {
            var inputName = b.Get(input, x => x.InputName);
            var inputId = b.Get(input, x => x.Id);

            var button = b.Node("button", "p-4 border bg-blue-100", b => b.Text(inputName));

            b.If(isSelected, b => b.AddClass(button, "font-semibold"));

            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SetInputId,
                        inputId,
                        b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<ApiResponse> result) =>
                        {
                            b.Set(model, x => x.SelectedInputId, b.Get(input, x => x.Id));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }
    }

    //public class Homepage : HtmlPage<Handler.Home.Model>
    //{
    //    public override IHtmlNode GetHtml(Handler.Home.Model dataModel)
    //    {
    //        var html = new HtmlTag("html");
    //        var body = html.AddChild(new HtmlTag("body"));

    //        foreach (var solution in dataModel.Solutions)
    //        {
    //            var link = body.AddChild(new HtmlTag("a").AddAttribute("href", Metapsi.Route.Path<Metapsi.Live.Route.Sln, Guid>(solution.Id)));
    //            link.AddChild(new HtmlText(solution.Path));
    //        }

    //        return html;
    //    }
    //}
}