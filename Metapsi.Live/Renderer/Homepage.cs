using Metapsi;
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
using System.Threading.Tasks;

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

        public static Var<HyperNode> Layout(BlockBuilder b, Var<HyperNode> header, Var<HyperNode> content)
        {
            var mainDiv = b.Div();
            b.Add(mainDiv, header);
            b.Add(mainDiv, content);
            return mainDiv;
        }

        public static Var<HyperNode> SolutionNameHeader(BlockBuilder b, Var<Handler.Home.Model> model)
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

        public static Var<Metapsi.Live.Db.Solution> SelectedSolution(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var selectedSolution = b.Get(model, model => model.Solutions.SingleOrDefault(solution => solution.Id == model.SelectedSolutionId));

            return b.If(
                b.HasObject(selectedSolution),
                b => selectedSolution,
                b => b.NewObj<Metapsi.Live.Db.Solution>());
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

        public Var<HyperNode> SelectSolutionDropDown(BlockBuilder b, Var<Handler.Home.Model> clientModel)
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

        public Var<HyperNode> ListSolutions(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div(
                "flex flex-col w-full h-full items-center justify-center",
                b => b.Div(
                    "flex flex-col items-center gap-8 border rounded p-4",
                    b => b.Text("Select solution", "font-semibold"),
                    b => SelectSolutionDropDown(b, model),
                    //b=> b.Alert(b.NewObj<Metapsi.Shoelace.Alert>()),
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
                                    b => QualifiedSymbolClass(b, b.Get(renderer, x => x.Renderer.SymbolKey)),
                                    b => QualifiedSymbolClass(b, b.Get(renderer, x => x.Model))))),
                        b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                b.Get(model, project, (model, project) => model.SolutionEntities.Handlers.Where(x => x.Handler.SymbolKey.Project == project.Name).ToList()),
                                (b, handler) => b.Div(
                                    "flex flex-row gap-2",
                                    b => QualifiedSymbolClass(b, b.Get(handler, x => x.Handler.SymbolKey)),
                                    b => QualifiedSymbolUrl(b, b.Get(handler, x => x.Route))))),
                        b => b.Div(
                            "flex flex-col gap-2",
                            b.Map(
                                GetProjectRoutes(b, model, project),
                                (b, route) => b.Div(
                                    "flex flex-row gap-2",
                                    b => QualifiedSymbolUrl(b, b.Get(route, x => x.Route.SymbolKey)))))
                        );

            return b.Div("flex flex-row justify-center", b => projectPage);
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

        public Var<HyperNode> ListRoutes(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            return b.Div("flex flex-col gap-8",
                b.Map(
                    b.Get(model, x => x.SolutionEntities.Routes),
                    (b, route) => b.Div(
                        "flex flex-col gap-2 p-4 rounded bg-blue-100",
                        b => QualifiedSymbolUrl(b, b.Get(route, x => x.Route.SymbolKey)),
                        b => QualifiedSymbolClass(b, b.Get(route, x => x.Route.SymbolKey)))));
        }

        public Var<HyperNode> ListHandlers(BlockBuilder b, Var<Handler.Home.Model> model)
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

        public class SummaryRow
        {
            public RouteReference Route { get; set; }
            public HandlerReference Handler { get; set; }
            public ModelReference Model { get; set; }
            public RendererReference Renderer { get; set; }
        }

        public Var<string> GetQualifiedSymbolKey(BlockBuilder b, Var<SymbolKey> symbolKey)
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

        public Var<HyperNode> QualifiedSymbolClass(BlockBuilder b, Var<SymbolKey> symbolKey)
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

        public Var<HyperNode> QualifiedSymbolUrl(BlockBuilder b, Var<SymbolKey> symbolKey)
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

        public Var<bool> SymbolKeyEquals(BlockBuilder b, Var<SymbolKey> first, Var<SymbolKey> second)
        {
            return b.AreEqual(GetQualifiedSymbolKey(b, first), GetQualifiedSymbolKey(b, second));
        }

        public Var<HyperNode> SolutionSummaryTable(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var summary = b.Get(model, x => x.SolutionEntities);

            var tableProps = b.NewObj<DataTable.Props<SummaryRow>>();

            var rows = b.NewCollection<SummaryRow>();

            var eq = b.DefineFunc<SymbolKey, SymbolKey, bool>(SymbolKeyEquals);

            b.Foreach(
                b.Get(model, x => x.SolutionEntities.Routes),
                (b, route) =>
                {
                    var routeHandlers = b.Get(
                        summary,
                        route,
                        eq,
                        (summary, route, eq) => summary.Handlers.Where(x => eq(x.Route, route.Route.SymbolKey)).ToList());

                    b.If(
                        b.Get(routeHandlers, x => !x.Any()),
                        b =>
                        {
                            // if no handler exists we still need to display the route
                            var row = b.NewObj<SummaryRow>();
                            b.Set(row, x => x.Route, route);
                            b.Push(rows, row);
                        },
                        b =>
                        {
                            b.Foreach(routeHandlers, (b, routeHandler) =>
                            {
                                b.If(
                                    b.HasObject(b.Get(routeHandler, x => x.ReturnModelType)),
                                    b =>
                                    {
                                        var returnModelType = b.Get(routeHandler, x => x.ReturnModelType);

                                        var renderers = b.Get(summary, returnModelType, eq, (summary, returnModelType, eq) => summary.Renderers.Where(x => eq(x.Model, returnModelType)).ToList());

                                        b.If(
                                            b.Get(renderers, x => !x.Any()),
                                            b =>
                                            {
                                                var row = b.NewObj<SummaryRow>();
                                                b.Set(row, x => x.Route, route);
                                                b.Set(row, x => x.Handler, routeHandler);
                                                b.Push(rows, row);
                                            },
                                            b =>
                                            {
                                                b.Foreach(renderers, (b, renderer) =>
                                                {
                                                    var row = b.NewObj<SummaryRow>();
                                                    b.Set(row, x => x.Route, route);
                                                    b.Set(row, x => x.Handler, routeHandler);
                                                    b.Set(row, x => x.Renderer, renderer);
                                                    b.Push(rows, row);
                                                });
                                            });
                                    },
                                    b=>
                                    {
                                        // if no return model type is associated we still need to display the route & handler
                                        var row = b.NewObj<SummaryRow>();
                                        b.Set(row, x => x.Route, route);
                                        b.Push(rows, row);
                                    });
                            });
                        });
                });

            b.Set(tableProps, x => x.Rows, rows);
            var columns = b.NewCollection<DataTable.Column>();
            b.Push(columns, b.NewObj<DataTable.Column>(b =>
            {
                b.Set(x => x.Name, b.Const("Route"));
            }));

            b.Push(columns, b.NewObj<DataTable.Column>(b =>
            {
                b.Set(x => x.Name, b.Const("Handler"));
            }));

            b.Push(columns, b.NewObj<DataTable.Column>(b =>
            {
                b.Set(x => x.Name, b.Const("Model"));
            }));

            b.Push(columns, b.NewObj<DataTable.Column>(b =>
            {
                b.Set(x => x.Name, b.Const("Renderer"));
            }));

            b.Set(tableProps, x => x.Columns, columns);

            b.Log(rows);

            b.Set(tableProps, x => x.CreateCell, b.DefineFunc<SummaryRow, DataTable.Column, HyperNode>(RenderSummaryCell));

            return b.DataTable<SummaryRow>(tableProps);
        }

        public Var<HyperNode> RenderSummaryCell(BlockBuilder b, Var<SummaryRow> row, Var<DataTable.Column> column)
        {
            return b.Switch(
                b.Get(column, x => x.Name),
                b => b.Text("Not defined", "text-red-500"),
                ("Route", b => QualifiedSymbolUrl(b, b.Get(row, x => x.Route.Route.SymbolKey))),
                ("Handler", b => GetHandlerCell(b, row)),
                ("Model", b => GetModelCell(b, row)),
                ("Renderer", b => GetRendererCell(b, row)));
        }

        public Var<HyperNode> GetRendererCell(BlockBuilder b, Var<SummaryRow> row)
        {
            var renderer = b.Get(row, x => x.Renderer);

            return b.If(
                b.HasObject(renderer),
                b => QualifiedSymbolClass(b, b.Get(renderer, x => x.Renderer.SymbolKey)),
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> GetHandlerCell(BlockBuilder b, Var<SummaryRow> row)
        {
            var handler = b.Get(row, x => x.Handler);

            return b.If(
                b.HasObject(handler),
                b => QualifiedSymbolClass(b, b.Get(handler, x => x.Handler.SymbolKey)),
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> GetModelCell(BlockBuilder b, Var<SummaryRow> row)
        {
            var handler = b.Get(row, x => x.Handler);

            return b.If(
                b.HasObject(handler),
                b => QualifiedSymbolClass(b, b.Get(handler, x => x.ReturnModelType)),
                b => b.Text("Not defined", "text-red-500"));
        }

        public Var<HyperNode> SolutionSummary(BlockBuilder b, Var<Handler.Home.Model> model)
        {
            var entities = b.Get(model, x => x.SolutionEntities);

            return Layout(
                b,
                SolutionNameHeader(b, model),
                b.Div(
                    "p-4",
                    b => CompileErrorsStack(b, model),
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

                        }),
                b => SolutionSummaryTable(b, model)));
        }

        public Var<HyperNode> CompileErrorsStack(BlockBuilder b, Var<Handler.Home.Model> model)
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

        public Var<HyperNode> SelectRendererButton(BlockBuilder b, Var<SymbolKey> renderer)
        {
            var button = b.Node(
                "button",
                "bg-blue-100 p-4 rounded",
                b => b.Div(
                    "flex flex-col items-center gap-2",
                    b => QualifiedSymbolClass(b, renderer)));

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

        public Var<HyperNode> FocusRenderer(BlockBuilder b, Var<Handler.Home.Model> model)
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

public static class ServerExtensions
{
    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
        this BlockBuilder b,
        Var<TState> model,
        Func<TState, TPayload, TState> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
    }

    public static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
        this BlockBuilder b,
        Var<TState> model,
        Func<CommandContext, TState, TPayload, System.Threading.Tasks.Task<TState>> onServerAction)
        where TState : IApiSupportState
    {
        return MakeServerAction<TState, TPayload>(b, model, onServerAction.Method);
    }

    private static Var<HyperType.Action<TState, TPayload>> MakeServerAction<TState, TPayload>(
            this BlockBuilder b,
            Var<TState> model,
            System.Reflection.MethodInfo method)
            where TState : IApiSupportState
    {
        var clientAction = b.MakeAction((BlockBuilder b, Var<TState> state, Var<TPayload> payload) =>
        {
            var serverActionInput = b.NewObj<Frontend.ServerActionInput>();
            b.Set(serverActionInput, x => x.SerializedModel, b.Serialize(state));
            b.Set(serverActionInput, x => x.SerializedPayload, b.Serialize(payload));
            b.Set(serverActionInput, x => x.HandlerMethod, b.Const(method.Name));
            b.Set(serverActionInput, x => x.QualifiedHandlerClass, b.Const(method.DeclaringType.AssemblyQualifiedName));

            return b.AsyncResult(
                b.ShowPanel(model),
                b.Request(
                    Frontend.ServerAction,
                    serverActionInput,
                    b.MakeAction((BlockBuilder b, Var<TState> model, Var<Frontend.ServerActionResponse> result) =>
                    {
                        return b.Deserialize<TState>(b.Get(result, x => x.SerializedModel));
                    })));
        });

        return clientAction;
    }
}