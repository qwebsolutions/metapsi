﻿using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.Build.Utilities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

public static partial class Render
{
    public class Homepage : HyperPage<Handler.Home.Model>
    {
        public override Var<HyperNode> OnRender(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            b.AddStylesheet("metapsi.live.css");

            b.AddSubscription(
                "metapsi_each_second",
                (SyntaxBuilder b, Var<Handler.Home.Model> model) =>
                {
                    return b.Every<Handler.Home.Model>(
                        b.Const(1000),
                        b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
                        {
                            return b.Switch(
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

        public static Var<HyperNode> Layout(LayoutBuilder b, Var<HyperNode> header, Var<HyperNode> content)
        {
            var mainDiv = b.Div();
            b.Add(mainDiv, b.AddClass(header, "fixed z-10"));
            b.Add(mainDiv, b.AddClass(content, "p-4 pt-24 z-0"));
            return mainDiv;
        }

        public static Var<HyperNode> SolutionNameHeader(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var headerInfo = b.Div(
                "px-8 flex flex-row w-full py-4 gap-2 text-gray-600 items-center",
                b => b.Text("Solution"),
                b => b.Text(b.Get(SelectedSolution(b, model), x => x.Path), "font-semibold"),
                b => b.Optional(b.Get(model, x => x.TotalProjects == 0), b => b.Spinner()));

            // Show progress bar with 0 percent instead of hiding it, because it affects the shadow

            var showProgressBar = b.Get(model, x => x.CurrentView == Handler.View.WaitingCompile && x.TotalProjects != 0);

            var progressValue = b.If(
                showProgressBar,
                b => b.Get(model, x => x.AlreadyCompiled.Count() / x.TotalProjects * 100),
                b => b.Const(0));

            var headerAndProgress = b.Div(
                "flex flex-col gap-0 w-full bg-slate-50 shadow",
                b => headerInfo,
                b =>
                {
                    var bar = b.ProgressBar(progressValue);

                    b.AddStyle(bar, "--height", b.Const("2px"));

                    return bar;
                });

            return headerAndProgress;
        }

        public static Var<Metapsi.Live.Db.Solution> SelectedSolution(SyntaxBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.SingleOrDefault(solution => solution.Id == model.SelectedSolutionId));

            return b.If(
                b.HasObject(selectedSolution),
                b => selectedSolution,
                b => b.NewObj<Metapsi.Live.Db.Solution>());
        }

        public static Var<HyperType.StateWithEffects> PoolCompile(SyntaxBuilder b, Var<Handler.Home.Model> model)
        {
            return b.AsyncResult(
                model,
                b.Request<Handler.Home.Model, Frontend.SolutionEntitiesResponse>(
                    Frontend.GetSolutionEntities,
                    b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model, Var<Frontend.SolutionEntitiesResponse> result) =>
                    {
                        b.Log(result);
                        return b.If(
                            b.Get(result, x => x.IsLoading),
                            b =>
                            {
                                b.Set(model, x => x.CurrentlyCompiling, b.Get(result, x => x.CurrentlyCompiling));
                                b.Set(model, x => x.AlreadyCompiled, b.Get(result, x => x.AlreadyCompiled));
                                b.Set(model, x => x.TotalProjects, b.Get(result, x => x.TotalProjects));
                                return b.Clone(model);
                            },
                            b =>
                            {
                                b.Set(model, x => x.CurrentView, b.Const(Handler.View.SolutionSummary));
                                b.Set(model, x => x.CurrentlyCompiling, b.Const(string.Empty));
                                b.Set(model, x => x.AlreadyCompiled, b.NewCollection<string>());
                                b.Set(model, x => x.SolutionEntities, b.Get(result, x => x.SolutionEntities));
                                b.Set(model, x => x.TotalProjects, b.Get(result, x => x.SolutionEntities.Projects.Count()));

                                b.If(
                                    b.Get(model, x => x.SolutionEntities.Errors.Any()),
                                    b => b.Toast(
                                        b.Const("Compilation error"),
                                        b.Const(AlertVariant.Danger)));

                                return b.Clone(model);
                            });
                    })));
        }

        public Var<HyperNode> SelectSolutionDropDown(LayoutBuilder b, Var<Handler.Home.Model> clientModel)
        {
            var select = b.Select(
                new Select()
                {
                    Label = "Select solution",
                    HelpText = "The solution will be loaded & compiled for live preview"
                },
                b.MapOptions(
                    b.Get(clientModel, x => x.Solutions),
                    x => x.Id,
                    x => x.Path));

            b.SetOnSlChange(
                select,
                b.MakeServerAction<Handler.Home.Model, string>(
                clientModel,
                OnSolutionSelected));

            return select;
        }

        public static async Task<Handler.Home.Model> OnSolutionSelected(CommandContext commandContext, Handler.Home.Model serverModel, string selectedValue)
        {
            serverModel.SelectedSolutionId = Guid.Parse(selectedValue);
            var solutions = await commandContext.Do(Storage.GetSolutions);
            var selectedSolution = solutions.Solutions.Single(x => x.Id == serverModel.SelectedSolutionId);

            commandContext.PostEvent(new SolutionSelected()
            {
                Solution = selectedSolution
            });

            serverModel.CurrentView = Handler.View.WaitingCompile;
            return serverModel;
        }

        public Var<HyperNode> ListSolutions(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col w-full h-full items-center justify-center",
                b => b.Div(
                    "flex flex-col items-center gap-8 border rounded p-4",
                    b => b.Text("Select solution", "font-semibold"),
                    b => SelectSolutionDropDown(b, model)
                    )
                );
        }

        public Var<HyperNode> SelectSolutionButton(LayoutBuilder b, Var<Metapsi.Live.Db.Solution> sln)
        {
            var button = b.Node("button", "bg-gray-200 hover:bg-gray-300 rounded py-4 px-8", b => b.Text(b.Get(sln, x => x.Path)));

            b.SetOnClick(button, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
            {
                b.Set(model, x => x.SelectedSolutionId, b.Get(sln, x => x.Id));

                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SelectSolution,
                        b.Get(sln, x => x.Id),
                        b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model, Var<ApiResponse> result) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.WaitingCompile));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> ListProjects(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var list = b.Div("flex flex-col gap-8 items-stretch p-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Projects),
                    (b, project) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b =>
                        {
                            var button = b.Node("button", "", b => ProjectListCard(b, model, project));

                            b.SetOnClick(button, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> page) =>
                            {
                                b.Set(page, x => x.FocusedProjectName, b.Get(project, x => x.Name));
                                b.Set(page, x => x.CurrentView, b.Const(Handler.View.FocusProject));
                                return b.Clone(page);
                            }));

                            return button;
                        })));

            return b.Div("flex flex-row justify-center", b => list);
        }

        public Var<HyperNode> ProjectListCard(LayoutBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
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

        public Var<List<RendererReference>> GetProjectRenderers(SyntaxBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            return b.Get(model, project, (model, project) => model.SolutionEntities.Renderers.Where(x => x.Renderer.SymbolKey.Project == project.Name).ToList());
        }

        public Var<List<HandlerReference>> GetProjectHandlers(SyntaxBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            return b.Get(model, project, (model, project) => model.SolutionEntities.Handlers.Where(x => x.Handler.SymbolKey.Project == project.Name).ToList());
        }

        public Var<List<RouteReference>> GetProjectRoutes(SyntaxBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            return b.Get(model, project, (model, project) => model.SolutionEntities.Routes.Where(x => x.Route.SymbolKey.Project == project.Name).ToList());
        }

        public Var<HyperNode> FocusProject(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var project = b.GetFocusedProject(model);

            var projectPage = b.Div(
                "flex flex-col gap-2 p-4 rounded bg-blue-50 w-full",
                b => RelatedProjectsList(b, model),
                b => ProjectRoutesList(b, model),
                b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                b.Get(model, project, (model, project) => model.SolutionEntities.Renderers.Where(x => x.Renderer.SymbolKey.Project == project.Name).ToList()),
                                (b, renderer) => b.Div(
                                    "flex flex-row gap-2",
                                    b => QualifiedSymbolClass(b, b.Get(renderer, x => x.Renderer.SymbolKey)),
                                    b => QualifiedSymbolClass(b, b.Get(renderer, x => x.Model))))),
                b=> ProjectHandlersList(b, model));

            return b.Div("flex flex-row justify-center", b => projectPage);
        }

        public Var<HyperNode> RelatedProjectsList(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var project = b.Get(model, model => model.SolutionEntities.Projects.Single(x => x.Name == model.FocusedProjectName));

            var usedProjects = b.Get(project, x => x.UsedProjects);

            var container = b.Div(
                "flex flex-col gap-2",
                b => b.Text("Based on"),
                b => b.Div(
                    "flex flex-col text-sm",
                    b.Map(
                        usedProjects,
                        (b, related) =>
                        {
                            var selectProject = b.Node("button", "w-fit", b => b.Text(related));

                            b.SetOnClick(selectProject, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
                            {
                                b.Set(model, x => x.FocusedProjectName, related);
                                return b.Clone(model);
                            }));

                            return selectProject;
                        })));

            return b.ShowIfAny(usedProjects, b => container);
        }

        public Var<HyperNode> ProjectRoutesList(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var projectRoutes = GetProjectRoutes(b, model, b.GetFocusedProject(model));
            var container = b.Div(
                "flex flex-col gap-2",
                b => b.Text("Routes"),
                b => b.Div(
                    "flex flex-col gap-2",
                    b.Map(
                        projectRoutes,
                        (b, route) => b.Div(
                            "flex flex-row gap-2",
                            b =>
                            {
                                var routeBtn = QualifiedSymbolUrl(b, b.Get(route, x => x.Route.SymbolKey));
                                return routeBtn;
                            }))));

            return b.ShowIfAny(projectRoutes, b => container);
        }

        public Var<HyperNode> ProjectHandlersList(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var projectHandlers = b.Get(model, b.GetFocusedProject(model), (model, project) => model.SolutionEntities.Handlers.Where(x => x.Handler.SymbolKey.Project == project.Name).ToList());
            var container = b.Div(
                "flex flex-col gap-2",
                b => b.Text("Handlers"),
                b => b.Div(
                    "flex flex-col gap-2",
                    b.Map(
                        projectHandlers,
                        (b, handler) => b.Div(
                            "flex flex-row gap-2",
                            b => QualifiedSymbolClass(b, b.Get(handler, x => x.Handler.SymbolKey)),
                            b => QualifiedSymbolUrl(b, b.Get(handler, x => x.Route))))));

            return b.ShowIfAny(projectHandlers, b => container);
        }

        //public Var<string> ClassPathToUrl(BlockBuilder b, Var<SymbolKey> symbolKey)
        //{
        //    var classPath = b.Get(symbolKey, x => x.ClassPath);
        //    return b.JoinStrings(b.Const("/"), classPath);
        //}

        //public Var<HyperNode> ClassPathToNestedName(BlockBuilder b, Var<SymbolKey> symbolKey)
        //{
        //    var classPath = b.Get(symbolKey, x => x.ClassPath);
        //    var nestedClassName = b.JoinStrings(b.Const("."), classPath);

        //    return b.Span(
        //        "",
        //        b => b.Text(b.Get(symbolKey, x => x.Project), "text-sm text-gray-600"),
        //        b => b.Text(b.Const(":"), "text-sm text-gray-600"),
        //        b => b.Text(b.Get(symbolKey, x => x.Namespace), "text-gray-800"),
        //        b => b.Text(nestedClassName, "text-gray-800"));
        //}

        public Var<HyperNode> ListRoutes(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div("flex flex-col gap-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Routes),
                    (b, route) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b => QualifiedSymbolUrl(b, b.Get(route, x => x.Route.SymbolKey)),
                        b => QualifiedSymbolClass(b, b.Get(route, x => x.Route.SymbolKey)))));
        }

        public Var<HyperNode> ListHandlers(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div("flex flex-col gap-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Handlers),
                    (b, handler) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b => QualifiedSymbolClass(b, b.Get(handler, x => x.Handler.SymbolKey)),
                        b => QualifiedSymbolUrl(b, b.Get(handler, x => x.Route)),
                        b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                b.Get(handler, x => x.CommandContextCalls),
                                (b, call) => b.Text(call))))));
        }

        public Var<HyperNode> ListRenderers(LayoutBuilder b, Var<Handler.Home.Model> model)
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
                        var previewLink = b.Node("a", "flex flex-row items-center justify-center bg-red-100 rounded p-4");
                        b.SetAttr(previewLink, Html.href, "http://localhost:9999");
                        b.SetAttr(previewLink, new DynamicProperty<string>("target"), b.Const("_blank"));

                        b.Add(previewLink,
                            b.Div(
                                "flex flex-row text-blue-500 gap-4 items-center",
                                b => b.TextNode("Preview"),
                                b => b.Icon("box-arrow-up-right")));

                        return previewLink;
                    },
                    b => b.Div(
                        "flex flex-col gap-4",
                        b.Map(
                            b.Get(model, x => x.SolutionEntities.Renderers.Select(x => x.Renderer.SymbolKey).ToList()),
                            SelectRendererButton))));
        }

        public class SummaryRow
        {
            public RouteReference Route { get; set; }
            public HandlerReference Handler { get; set; }
            public ModelReference Model { get; set; }
            public RendererReference Renderer { get; set; }
        }

        public Var<string> GetQualifiedSymbolKey(SyntaxBuilder b, Var<SymbolKey> symbolKey)
        {
            return b.If(
                b.HasObject(symbolKey),
                b =>
                {

                    var classPath = b.JoinStrings(b.Const("."), b.Get(symbolKey, x => x.ClassPath));

                    var qualified = b.Concat(
                        b.Get(symbolKey, x => x.Project),
                        b.Const(":"),
                        b.Get(symbolKey, x => x.Namespace),
                        b.Const(":"),
                        classPath);

                    return qualified;
                },
                b => b.Const(string.Empty));
        }

        public Var<HyperNode> QualifiedSymbolClass(LayoutBuilder b, Var<SymbolKey> symbolKey)
        {
            return b.If(
                b.HasObject(symbolKey),
                b =>
                {
                    var classPath = b.JoinStrings(b.Const("."), b.Get(symbolKey, x => x.ClassPath));

                    return b.Span(
                        "",
                        b => b.Text(b.Get(symbolKey, x => x.Project), "text-xs text-gray-400"),
                        b => b.Text(": ", "text-xs text-gray-400"),
                        b => b.Text(b.Get(symbolKey, x => x.Namespace), "text-sm text-gray-600"),
                        b => b.Text(": ", "text-sm text-gray-600"),
                        b => b.Text(classPath, "text-gray-800"));
                },
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> QualifiedSymbolUrl(LayoutBuilder b, Var<SymbolKey> symbolKey)
        {
            return b.If(
                b.HasObject(symbolKey),
                b =>
                {
                    var classPath = b.JoinStrings(b.Const("/"), b.Get(symbolKey, x => x.ClassPath));

                    return b.Span(
                        "",
                        b => b.Text(b.Get(symbolKey, x => x.Project), "text-xs text-gray-400"),
                        b => b.Text(": ", "text-xs text-gray-400"),
                        b => b.Text(b.Get(symbolKey, x => x.Namespace), "text-sm text-gray-600"),
                        b => b.Text(": ", "text-sm text-gray-600"),
                        b => b.Text(classPath, "text-gray-800"));
                },
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<bool> SymbolKeyEquals(SyntaxBuilder b, Var<SymbolKey> first, Var<SymbolKey> second)
        {
            return b.AreEqual(GetQualifiedSymbolKey(b, first), GetQualifiedSymbolKey(b, second));
        }

        public Var<HyperNode> SolutionSummaryTable(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.VoidNode();

            //var summary = b.Get(model, x => x.SolutionEntities);

            //var tableProps = b.NewObj<DataTable.Props<SummaryRow>>();

            //var rows = b.NewCollection<SummaryRow>();

            //var eq = b.DefineFunc<SymbolKey, SymbolKey, bool>(SymbolKeyEquals);

            //b.Foreach(
            //    b.Get(model, x => x.SolutionEntities.Routes),
            //    (b, route) =>
            //    {
            //        var routeHandlers = b.Get(
            //            summary,
            //            route,
            //            eq,
            //            (summary, route, eq) => summary.Handlers.Where(x => eq(x.Route, route.Route.SymbolKey)).ToList());

            //        b.If(
            //            b.Get(routeHandlers, x => !x.Any()),
            //            b =>
            //            {
            //                // if no handler exists we still need to display the route
            //                var row = b.NewObj<SummaryRow>();
            //                b.Set(row, x => x.Route, route);
            //                b.Push(rows, row);
            //            },
            //            b =>
            //            {
            //                b.Foreach(routeHandlers, (b, routeHandler) =>
            //                {
            //                    b.If(
            //                        b.HasObject(b.Get(routeHandler, x => x.ReturnModelType)),
            //                        b =>
            //                        {
            //                            var returnModelType = b.Get(routeHandler, x => x.ReturnModelType);

            //                            var renderers = b.Get(summary, returnModelType, eq, (summary, returnModelType, eq) => summary.Renderers.Where(x => eq(x.Model, returnModelType)).ToList());

            //                            b.If(
            //                                b.Get(renderers, x => !x.Any()),
            //                                b =>
            //                                {
            //                                    var row = b.NewObj<SummaryRow>();
            //                                    b.Set(row, x => x.Route, route);
            //                                    b.Set(row, x => x.Handler, routeHandler);
            //                                    b.Push(rows, row);
            //                                },
            //                                b =>
            //                                {
            //                                    b.Foreach(renderers, (b, renderer) =>
            //                                    {
            //                                        var row = b.NewObj<SummaryRow>();
            //                                        b.Set(row, x => x.Route, route);
            //                                        b.Set(row, x => x.Handler, routeHandler);
            //                                        b.Set(row, x => x.Renderer, renderer);
            //                                        b.Push(rows, row);
            //                                    });
            //                                });
            //                        },
            //                        b =>
            //                        {
            //                            // if no return model type is associated we still need to display the route & handler
            //                            var row = b.NewObj<SummaryRow>();
            //                            b.Set(row, x => x.Route, route);
            //                            b.Push(rows, row);
            //                        });
            //                });
            //            });
            //    });

            //b.Set(tableProps, x => x.Rows, rows);
            //var columns = b.NewCollection<DataTable.Column>();
            //b.Push(columns, b.NewObj<DataTable.Column>(b =>
            //{
            //    b.Set(x => x.Name, b.Const("Route"));
            //}));

            //b.Push(columns, b.NewObj<DataTable.Column>(b =>
            //{
            //    b.Set(x => x.Name, b.Const("Handler"));
            //}));

            //b.Push(columns, b.NewObj<DataTable.Column>(b =>
            //{
            //    b.Set(x => x.Name, b.Const("Model"));
            //}));

            //b.Push(columns, b.NewObj<DataTable.Column>(b =>
            //{
            //    b.Set(x => x.Name, b.Const("Renderer"));
            //}));

            //b.Set(tableProps, x => x.Columns, columns);

            //b.Log(rows);

            //b.Set(tableProps, x => x.CreateCell, b.DefineFunc<SummaryRow, DataTable.Column, HyperNode>(RenderSummaryCell));

            //return b.DataTable<SummaryRow>(tableProps);
        }

        //public Var<HyperNode> RenderSummaryCell(BlockBuilder b, Var<SummaryRow> row, Var<DataTable.Column> column)
        //{
        //    return b.Switch(
        //        b.Get(column, x => x.Name),
        //        b => b.Text("Not defined", "text-red-500"),
        //        ("Route", b => QualifiedSymbolUrl(b, b.Get(row, x => x.Route.Route.SymbolKey))),
        //        ("Handler", b => GetHandlerCell(b, row)),
        //        ("Model", b => GetModelCell(b, row)),
        //        ("Renderer", b => GetRendererCell(b, row)));
        //}

        public Var<HyperNode> GetRendererCell(LayoutBuilder b, Var<SummaryRow> row)
        {
            var renderer = b.Get(row, x => x.Renderer);

            return b.If(
                b.HasObject(renderer),
                b => QualifiedSymbolClass(b, b.Get(renderer, x => x.Renderer.SymbolKey)),
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> GetHandlerCell(LayoutBuilder b, Var<SummaryRow> row)
        {
            var handler = b.Get(row, x => x.Handler);

            return b.If(
                b.HasObject(handler),
                b => QualifiedSymbolClass(b, b.Get(handler, x => x.Handler.SymbolKey)),
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> GetModelCell(LayoutBuilder b, Var<SummaryRow> row)
        {
            var handler = b.Get(row, x => x.Handler);

            return b.If(
                b.HasObject(handler),
                b => QualifiedSymbolClass(b, b.Get(handler, x => x.ReturnModelType)),
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> SolutionSummary(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var entities = b.Get(model, x => x.SolutionEntities);

            return Layout(
                b,
                SolutionNameHeader(b, model),
                b.Div(
                    "",
                    b => CompileErrorsStack(b, model),
                    b =>
                    {
                        var tabGroup = b.TabGroup();

                        b.TabPage(
                            tabGroup,
                            b.Const("projects"),
                            b.Concat(b.AsString(b.Get(entities, x => x.Projects.Count())), b.Const(" Projects")),
                            ProjectsTab(b, model));

                        b.TabPage(
                            tabGroup,
                            b.Const("routes"),
                            b.Concat(b.AsString(b.Get(entities, x => x.Routes.Count())), b.Const(" Routes")),
                            RoutesTab(b, model));

                        b.TabPage(
                            tabGroup,
                            b.Const("handlers"),
                            b.Concat(b.AsString(b.Get(entities, x => x.Handlers.Count())), b.Const(" Handlers")),
                            ListHandlers(b, model));

                        b.TabPage(
                            tabGroup,
                            b.Const("renderers"),
                            b.Concat(b.AsString(b.Get(entities, x => x.Renderers.Count())), b.Const(" Renderers")),
                            ListRenderers(b, model));

                        return tabGroup;
                    },
                //b => b.Div(
                //    "flex flex-row gap-8 items-center justify-center",
                //    b =>
                //    {
                //        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Projects.Count())), b.Const("Projects"));

                //        var gotoProjects = b.Node("button", "", b => card);

                //        b.SetOnClick(gotoProjects, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                //        {
                //            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListProjects));
                //            return b.Clone(model);
                //        }));

                //        return gotoProjects;
                //    },
                //    b =>
                //    {
                //        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Routes.Count())), b.Const("Routes"));

                //        var gotoRoutes = b.Node("button", "", b => card);

                //        b.SetOnClick(gotoRoutes, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                //        {
                //            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRoutes));
                //            return b.Clone(model);
                //        }));

                //        return gotoRoutes;
                //    },
                //    b =>
                //    {
                //        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Renderers.Count())), b.Const("Renderers"));

                //        var gotoRenderers = b.Node("button", "", b => card);

                //        b.SetOnClick(gotoRenderers, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                //        {
                //            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListRenderers));
                //            return b.Clone(model);
                //        }));

                //        return gotoRenderers;

                //    },
                //    b =>
                //    {
                //        var card = FactCard(b, b.AsString(b.Get(entities, x => x.Handlers.Count())), b.Const("Handlers"));

                //        var gotoHandlers = b.Node("button", "", b => card);

                //        b.SetOnClick(gotoHandlers, b.MakeAction((BlockBuilder b, Var<Handler.Home.Model> model) =>
                //        {
                //            b.Set(model, x => x.CurrentView, b.Const(Handler.View.ListHandlers));
                //            return b.Clone(model);
                //        }));

                //        return gotoHandlers;

                //    }),
                b => SolutionSummaryTable(b, model)));
        }

        public Var<HyperNode> ProjectsTab(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.If(
                b.Not(b.HasValue(b.Get(model, x => x.FocusedProjectName))),
                b => ProjectsList(b, model),
                b => FocusedProjectDetails(b, model));
        }

        public Var<HyperNode> RoutesTab(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return ListRoutes(b, model);
        }

        public Var<HyperNode> ProjectsList(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col gap-8 p-4",
                b => b.Div(
                    "flex flex-row gap-8 p-2 items-center",
                b => b.BoundCheckbox(b.Const("Routes"), model, x => x.ProjectsFilterIncludeRoutes),
                b => b.BoundCheckbox(b.Const("Handlers"), model, x => x.ProjectsFilterIncludeHandlers),
                b => b.BoundCheckbox(b.Const("Renderers"), model, x => x.ProjectsFilterIncludeRenderers),
                b => b.BoundCheckbox(b.Const("Other"), model, x => x.ProjectsFilterIncludeOther)),
                b => b.Div(
                "flex flex-col gap-8",
                b.Map(
                    FilteredProjects(b, model),
                    (b, project) => ProjectEntry(b, model, project))));
        }

        public Var<HyperNode> FocusedProjectDetails(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col gap-8 p-4",
                b =>
                {
                    var breadcrumb = b.Breadcrumb();
                    var projectsItem = b.BreadcrumbButtonItem(b.Const("Projects"));
                    b.SetOnClick(projectsItem, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
                    {
                        b.Set(model, x => x.FocusedProjectName, b.Const(string.Empty));
                        return b.Clone(model);
                    }));

                    b.Add(breadcrumb, projectsItem);
                    b.Add(breadcrumb, b.BreadcrumbButtonItemLast(b.Get(model, x => x.FocusedProjectName)));
                    return breadcrumb;
                },
                b => FocusProject(b, model));
        }

        public Var<List<ProjectReference>> FilteredProjects(SyntaxBuilder b, Var<Handler.Home.Model> model)
        {
            var withRoutes = b.Get(model, Filter.ProjectContainingRoutes);
            var withHandlers = b.Get(model, Filter.ProjectContainingHandlers);
            var withRenderers = b.Get(model, Filter.ProjectContainingRenderers);

            var relevantProjects = b.Get(withRoutes, withHandlers, withRenderers, (w1, w2, w3) => w1.Union(w2).Union(w3));

            var otherProjects = b.Get(model, relevantProjects, (model, relevantProjects) => model.SolutionEntities.Projects.Where(project => !relevantProjects.Contains(project)).ToList());

            var outProjects = b.Ref<List<ProjectReference>>(b.NewCollection<ProjectReference>());

            b.If(b.Get(model, x => x.ProjectsFilterIncludeRoutes),
                b => b.SetRef(outProjects, b.Get(b.GetRef(outProjects), withRoutes, (o, n) => o.Union(n).ToList())));

            b.If(b.Get(model, x => x.ProjectsFilterIncludeHandlers),
                b => b.SetRef(outProjects, b.Get(b.GetRef(outProjects), withHandlers, (o, n) => o.Union(n).ToList())));

            b.If(b.Get(model, x => x.ProjectsFilterIncludeRenderers),
                b => b.SetRef(outProjects, b.Get(b.GetRef(outProjects), withRenderers, (o, n) => o.Union(n).ToList())));

            b.If(b.Get(model, x => x.ProjectsFilterIncludeOther),
                b => b.SetRef(outProjects, b.Get(b.GetRef(outProjects), otherProjects, (o, n) => o.Union(n).ToList())));

            return b.GetRef(outProjects);
        }

        public Var<HyperNode> ProjectEntry(LayoutBuilder b, Var<Handler.Home.Model> model, Var<ProjectReference> project)
        {
            var projectRoutes = b.Get(model, project, (model, project) => model.SolutionEntities.Routes.Where(x => x.Route.SymbolKey.Project == project.Name));
            var projectHandlers = b.Get(model, project, (model, project) => model.SolutionEntities.Handlers.Where(x => x.Handler.SymbolKey.Project == project.Name));
            var projectRenderers = b.Get(model, project, (model, project) => model.SolutionEntities.Renderers.Where(x => x.Renderer.SymbolKey.Project == project.Name));

            var entry = b.Div(
                "flex flex-col gap-4 bg-gray-50 text-xs text-gray-500 p-4 cursor-pointer",
                b => b.Text(b.Get(project, x => x.Name), "text-gray-700 text-sm"));

            b.SetOnClick(entry, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
            {
                b.Set(model, x => x.FocusedProjectName, b.Get(project, x => x.Name));
                //b.Set(model, x => x.CurrentView, b.Const(Handler.View.FocusProject));
                return b.Clone(model);
            }));

            b.If(b.Get(projectRoutes, x => x.Any()),
                b => b.Add(entry, b.Text(b.Concat(b.AsString(b.Get(projectRoutes, x => x.Count())), b.Const(" routes")))));
            b.If(b.Get(projectHandlers, x => x.Any()),
                b => b.Add(entry, b.Text(b.Concat(b.AsString(b.Get(projectHandlers, x => x.Count())), b.Const(" handlers")))));
            b.If(b.Get(projectRenderers, x => x.Any()),
                b => b.Add(entry, b.Text(b.Concat(b.AsString(b.Get(projectRenderers, x => x.Count())), b.Const(" renderers")))));

            b.AddStyle(entry, "border-radius", "var(--sl-border-radius-small)");

            return entry;
        }

        public Var<HyperNode> CompileErrorsStack(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var container = b.Div("flex flex-col gap-2");

            b.Foreach(
                b.Get(model, x => x.SolutionEntities.Errors.Select(x => x.ProjectName).Distinct().ToList()),
                (b, project) =>
                {
                    var projectErrors = b.Get(model, project, (model, project) => model.SolutionEntities.Errors.Where(x => x.ProjectName == project).ToList());

                    var details = b.Add(
                        container,
                        b.Details(
                            b.NewObj<Details>(),
                            b =>
                            {
                                return b.Div(
                                    "flex flex-col gap-2 text-sm text-gray-500",
                                    b.Map(projectErrors, (b, e) => b.Text(b.Get(e, x => x.ErrorMessage))));
                            }));

                    var strongLabel = b.Text(
                        b.Concat(
                            project,
                            b.Const(" - "),
                            b.AsString(b.Get(projectErrors, x => x.Count())),
                            b.Const(" errors")),
                        "font-semibold text-red-600");
                    b.SetAttr(strongLabel, new DynamicProperty<string>("slot"), "summary");
                    b.Add(details, strongLabel);
                });

            return container;
        }

        public Var<HyperNode> SelectRendererButton(LayoutBuilder b, Var<SymbolKey> renderer)
        {
            var button = b.Node(
                "button",
                "bg-blue-100 p-4 rounded",
                b => b.Div(
                    "flex flex-col items-center gap-2",
                    b => QualifiedSymbolClass(b, renderer)));

            b.SetOnClick(button, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SelectRenderer,
                        renderer,
                        b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model, Var<Backend.RendererResponse> result) =>
                        {
                            b.Set(model, x => x.CurrentView, b.Const(Handler.View.FocusRenderer));
                            b.Set(model, x => x.SelectedRenderer, renderer);
                            b.Set(model, x => x.Inputs, b.Get(result, x => x.Inputs));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> WaitCompile(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));
            var solutionPath = b.Get(selectedSolution, x => x.Path);

            var content = b.Div(
                "flex flex-col w-screen h-screen items-center justify-center",
                b => b.Div(
                    "flex flex-col gap-8",
                    b => b.Div(
                        "flex flex-col gap-2",
                        b.Map(
                            b.Get(model, x => x.AlreadyCompiled),
                            (b, project) => b.Text(project))),
                    b =>
                    b.If(
                        b.Not(b.HasValue(b.Get(model, x => x.CurrentlyCompiling))),
                        b => b.Text(b.Const("Loading solution ...")),
                        b => b.Text(b.Concat(b.Const("Compiling "), b.Get(model, x => x.CurrentlyCompiling), b.Const(" ... "))))));

            return Layout(b, SolutionNameHeader(b, model), content);
        }

        public Var<HyperNode> FocusRenderer(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.Single(solution => solution.Id == model.SelectedSolutionId));
            var solutionPath = b.Get(selectedSolution, x => x.Path);

            var selectedRenderer = b.Get(model, model => model.SolutionEntities.Renderers.Single(x => x.Renderer.SymbolKey == model.SelectedRenderer));
            var rendererName = QualifiedSymbolClass(b, b.Get(model, x => x.SelectedRenderer));
            var projectName = b.Get(model, x => x.SelectedRenderer.Project);

            return b.Div(
                "flex flex-col items-center gap-8 p-8",
                b =>
                {
                    var sln = b.Node("button", "", b => b.Text(solutionPath));

                    b.SetOnClick(sln, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
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

        public Var<HyperNode> AddInputButton(LayoutBuilder b, Var<Handler.Home.Model> model)
        {
            var addInputButton = b.Node("button", "w-10 h-10 flex flex-col items-center justify-center rounded bg-green-100 font-bold text-lg", b => b.Text("+"));

            b.SetOnClick(addInputButton, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    model,
                    b.Request(
                        Frontend.AddRendererInput,
                        b.Get(model, x => x.SelectedRenderer),
                        b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model, Var<Backend.RendererResponse> response) =>
                        {
                            b.Set(model, x => x.Inputs, b.Get(response, x => x.Inputs));
                            return b.Clone(model);
                        })));
            }));

            return addInputButton;
        }

        public Var<HyperNode> SelectInputButton(LayoutBuilder b, Var<Metapsi.Live.Db.Input> input, Var<bool> isSelected)
        {
            var inputName = b.Get(input, x => x.InputName);
            var inputId = b.Get(input, x => x.Id);

            var button = b.Node("button", "p-4 border bg-blue-100", b => b.Text(inputName));

            b.If(isSelected, b => b.AddClass(button, "font-semibold"));

            b.SetOnClick(button, b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model) =>
            {
                return b.AsyncResult(
                    b.Clone(model),
                    b.Request(
                        Frontend.SetInputId,
                        inputId,
                        b.MakeAction((SyntaxBuilder b, Var<Handler.Home.Model> model, Var<ApiResponse> result) =>
                        {
                            b.Set(model, x => x.SelectedInputId, b.Get(input, x => x.Id));
                            return b.Clone(model);
                        })));
            }));

            return button;
        }

        public Var<HyperNode> FactCard(LayoutBuilder b, Var<string> mainData, Var<string> subtitle)
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

public static class Filter
{
    public static System.Linq.Expressions.Expression<Func<Handler.Home.Model, List<ProjectReference>>> ProjectContainingRoutes = (Handler.Home.Model model) => model.SolutionEntities.Projects.Where(x => model.SolutionEntities.Routes.Select(x => x.Route.SymbolKey.Project).Any(projectName => x.Name == projectName)).ToList();
    public static System.Linq.Expressions.Expression<Func<Handler.Home.Model, List<ProjectReference>>> ProjectContainingHandlers = (Handler.Home.Model model) => model.SolutionEntities.Projects.Where(x => model.SolutionEntities.Handlers.Select(x => x.Handler.SymbolKey.Project).Any(projectName => x.Name == projectName)).ToList();
    public static System.Linq.Expressions.Expression<Func<Handler.Home.Model, List<ProjectReference>>> ProjectContainingRenderers = (Handler.Home.Model model) => model.SolutionEntities.Projects.Where(x => model.SolutionEntities.Renderers.Select(x => x.Renderer.SymbolKey.Project).Any(projectName => x.Name == projectName)).ToList();
}

public static class ModelExtensions
{
    public static Var<ProjectReference> GetFocusedProject(this SyntaxBuilder b, Var<Handler.Home.Model> model)
    {
        var project = b.Get(model, model => model.SolutionEntities.Projects.Single(x => x.Name == model.FocusedProjectName));
        return project;
    }
}
