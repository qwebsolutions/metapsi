﻿using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Render
{
    public class Homepage : HyperPage<Handler.Home.Model>
    {
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
                (Handler.View.SolutionSummary, b => SolutionSummary(b, model)),
                (Handler.View.ListRenderers, b => ListRenderers(b, model)),
                (Handler.View.ListProjects, b => ListProjects(b, model)),
                (Handler.View.ListHandlers, b => ListHandlers(b, model)),
                (Handler.View.ListRoutes, b => ListRoutes(b, model)),
                (Handler.View.FocusProject, b => FocusProject(b, model)),
                (Handler.View.FocusRenderer, b => FocusRenderer(b, model)));
        }

        public static Var<HyperType.StateWithEffects> PoolCompile(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.AsyncResult(
                model,
                b.Request<Handler.Home.Model, Frontend.SolutionEntitiesResponse>(
                    Frontend.GetSolutionEntities,
                    b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model, Var<Frontend.SolutionEntitiesResponse> result) =>
                    {
                        b.Log(result);
                        return b.If(
                            b.Get(result, x => x.IsLoading),
                            b =>
                            {
                                b.Set(model, x => x.CurrentlyCompiling, b.Get(result, x => x.CurrentlyCompiling));
                                b.Set(model, x => x.AlreadyCompiled, b.Get(result, x => x.AlreadyCompiled));
                                return b.Clone(model);
                            },
                            b =>
                            {
                                b.Set(model, x => x.CurrentView, b.Const(Handler.View.SolutionSummary));
                                b.Set(model, x => x.CurrentlyCompiling, b.Const(string.Empty));
                                b.Set(model, x => x.AlreadyCompiled, b.NewCollection<string>());
                                b.Set(model, x => x.SolutionEntities, b.Get(result, x => x.SolutionEntities));

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

        public Var<HyperNode> ListProjects(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var list = b.Div("flex flex-col gap-8 items-stretch p-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Projects),
                    (b, project) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b =>
                        {
                            var button = b.Node("button", "", b => ProjectListCard(b, model, project));

                            b.SetOnClick(button, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> page) =>
                            {
                                b.Set(page, x => x.FocusedProjectName, b.Get(project, x => x.Name));
                                b.Set(page, x => x.CurrentView, b.Const(Handler.View.FocusProject));
                                return b.Clone(page);
                            }));

                            return button;
                        })));

            return b.Div("flex flex-row justify-center", b => list);
        }

        public Var<HyperNode> ProjectListCard(BlockBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            var renderers = GetProjectRenderers(b, model, project);
            var handlers = GetProjectHandlers(b, model, project);
            var routes = GetProjectRoutes(b, model, project);

            var projectCard = b.Div(
                "flex flex-col gap-2 p-4 rounded bg-blue-100 items-start",
                b => b.Text(b.Get(project, x => x.Name)));

            b.If(
                b.Get(renderers, x => x.Any()),
                b =>
                {
                    b.Add(projectCard,
                        b.Div(
                            "flex flex-row gap-2 text-green-500",
                            b => b.Text(b.AsString(b.Get(renderers, x => x.Count()))),
                            b => b.Text("renderers")));
                });

            b.If(
                b.Get(handlers, x => x.Any()),
                b =>
                {
                    b.Add(projectCard,
                        b.Div(
                            "flex flex-row gap-2 text-blue-500",
                            b => b.Text(b.AsString(b.Get(handlers, x => x.Count()))),
                            b => b.Text("handlers")));
                });

            b.If(
                b.Get(routes, x => x.Any()),
                b =>
                {
                    b.Add(projectCard,
                        b.Div(
                            "flex flex-row gap-2 text-yellow-500",
                            b => b.Text(b.AsString(b.Get(routes, x => x.Count()))),
                            b => b.Text("routes")));
                });

            return projectCard;
        }

        public Var<List<RendererReference>> GetProjectRenderers(BlockBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            return b.Get(model, project, (model, project) => model.SolutionEntities.Renderers.Where(x => x.Renderer.SymbolKey.Project == project.Name).ToList());
        }

        public Var<List<HandlerReference>> GetProjectHandlers(BlockBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            return b.Get(model, project, (model, project) => model.SolutionEntities.Handlers.Where(x => x.Handler.SymbolKey.Project == project.Name).ToList());
        }

        public Var<List<RouteReference>> GetProjectRoutes(BlockBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            return b.Get(model, project, (model, project) => model.SolutionEntities.Routes.Where(x => x.Route.SymbolKey.Project == project.Name).ToList());
        }

        public Var<HyperNode> FocusProject(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var project = b.Get(model, model => model.SolutionEntities.Projects.Single(x => x.Name == model.FocusedProjectName));

            var projectPage = b.Div(
                "flex flex-col gap-2 p-4 rounded bg-blue-100",
                b => b.Text(b.Get(project, x => x.Name)),
                b => b.Div(
                    "flex flex-col text-sm",
                    b.Map(
                        b.Get(project, x => x.UsedProjects),
                        (b, related) => b.Text(related))),
                        b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                b.Get(model, project, (model, project) => model.SolutionEntities.Renderers.Where(x => x.Renderer.SymbolKey.Project == project.Name).ToList()),
                                (b, renderer) => b.Div(
                                    "flex flex-row gap-2",
                                    b => ClassPathToNestedName(b, b.Get(renderer, x => x.Renderer.SymbolKey)),
                                    b => ClassPathToNestedName(b, b.Get(renderer, x => x.Model))))),
                        b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                b.Get(model, project, (model, project) => model.SolutionEntities.Handlers.Where(x => x.Handler.SymbolKey.Project == project.Name).ToList()),
                                (b, handler) => b.Div(
                                    "flex flex-row gap-2",
                                    b => ClassPathToNestedName(b, b.Get(handler, x => x.Handler.SymbolKey)),
                                    b => b.Text(ClassPathToUrl(b, b.Get(handler, x => x.Route)))))),
                        b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                GetProjectRoutes(b, model, project),
                                (b, route) => b.Div(
                                    "flex flex-row gap-2",
                                    b => b.Text(
                                        ClassPathToUrl(b, b.Get(route, x => x.Route.SymbolKey)),
                                        "text-yellow-500"))))
                        );

            return b.Div("flex flex-row justify-center", b => projectPage);
        }

        public Var<string> ClassPathToUrl(BlockBuilder b, Var<SymbolKey> symbolKey)
        {
            var classPath = b.Get(symbolKey, x => x.ClassPath);
            return b.JoinStrings(b.Const("/"), classPath);
        }

        public Var<HyperNode> ClassPathToNestedName(BlockBuilder b, Var<SymbolKey> symbolKey)
        {
            var classPath = b.Get(symbolKey, x => x.ClassPath);
            var nestedClassName = b.JoinStrings(b.Const("."), classPath);

            return b.Span(
                "",
                b => b.Text(b.Get(symbolKey, x => x.Project), "text-sm text-gray-600"),
                b => b.Text(b.Const(":"), "text-sm text-gray-600"),
                b => b.Text(b.Get(symbolKey, x => x.Namespace), "text-gray-800"),
                b => b.Text(nestedClassName, "text-gray-800"));
        }

        public Var<HyperNode> ListRoutes(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div("flex flex-col gap-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Routes),
                    (b, route) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b => b.Text(ClassPathToUrl(b, b.Get(route, x => x.Route.SymbolKey))),
                        b => ClassPathToNestedName(b, b.Get(route, x => x.Route.SymbolKey)))));
        }

        public Var<HyperNode> ListHandlers(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div("flex flex-col gap-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Handlers),
                    (b, handler) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b => ClassPathToNestedName(b, b.Get(handler, x => x.Handler.SymbolKey)),
                        b => b.Text(ClassPathToUrl(b, b.Get(handler, x => x.Route))))));
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
                            b.Get(model, x => x.SolutionEntities.Renderers.Select(x => x.Renderer.SymbolKey).ToList()),
                            SelectRendererButton))));
        }

        public Var<HyperNode> SolutionSummary(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var entities = b.Get(model, x => x.SolutionEntities);

            return b.Div(
                "flex flex-col w-screen h-screen items-center justify-center",
                b => b.Div(
                    "flex flex-row gap-8 items-center justify-center",
                    b =>
                    {
                        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Projects.Count())), b.Const("Projects"));

                        var gotoProjects = b.Node("button", "", b => card);

                        b.SetOnClick(gotoProjects, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListProjects));
                            return b.Clone(model);
                        }));

                        return gotoProjects;
                    },
                    b =>
                    {
                        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Routes.Count())), b.Const("Routes"));

                        var gotoRoutes = b.Node("button", "", b => card);

                        b.SetOnClick(gotoRoutes, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRoutes));
                            return b.Clone(model);
                        }));

                        return gotoRoutes;
                    },
                    b =>
                    {
                        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Renderers.Count())), b.Const("Renderers"));

                        var gotoRenderers = b.Node("button", "", b => card);

                        b.SetOnClick(gotoRenderers, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRenderers));
                            return b.Clone(model);
                        }));

                        return gotoRenderers;

                    },
                    b =>
                    {
                        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Handlers.Count())), b.Const("Handlers"));

                        var gotoHandlers = b.Node("button", "", b => card);

                        b.SetOnClick(gotoHandlers, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListHandlers));
                            return b.Clone(model);
                        }));

                        return gotoHandlers;

                    }));
        }

        public Var<HyperNode> SelectRendererButton(BlockBuilder b, Var<SymbolKey> renderer)
        {
            var button = b.Node(
                "button",
                "bg-blue-100 p-4 rounded",
                b => b.Div(
                    "flex flex-col items-center gap-2",
                    b => ClassPathToNestedName(b, renderer),
                    b => b.Text(b.Get(renderer, x => x.Project), "text-sm text-gray-600")));

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
                            b.Get(model, x => x.AlreadyCompiled),
                            (b, project) => b.Text(project))),
                    b => b.Text(b.Concat(b.Const("Compiling "), b.Get(model, x => x.CurrentlyCompiling), b.Const(" ... ")))));
        }

        public Var<HyperNode> FocusRenderer(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));
            var solutionPath = b.Get(selectedSolution, x => x.Path);

            var selectedRenderer = b.Get(model, model => model.SolutionEntities.Renderers.Single(x => x.Renderer.SymbolKey == model.SelectedRenderer));
            var rendererName = ClassPathToNestedName(b, b.Get(model, x => x.SelectedRenderer));
            var projectName = b.Get(model, x => x.SelectedRenderer.Project);

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
                b => rendererName,
                b => b.Text(projectName, "text-sm text-gray-500"),
                b => b.Div(
                    "flex flex-col",
                    b.Map(b.Get(selectedRenderer, x => x.Renderer.FilePaths), (b, path) => b.Text(path))),
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
                        b.Get(model, x => x.SelectedRenderer),
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

        public Var<HyperNode> FactCard(BlockBuilder b, Var<string> mainData, Var<string> subtitle)
        {
            return b.Div(
                "flex flex-col gap-8 rounded p-8 bg-blue-100 border w-64",
                b => b.Text(mainData, "text-2xl text-gray-700 text-left"),
                b => b.Text(subtitle, "text-gray-500 text-left"));
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