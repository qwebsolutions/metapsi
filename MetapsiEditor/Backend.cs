using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live;
using Metapsi.Live.Db;
using Metapsi.Sqlite;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Backend
{
    public static Request<SolutionEntities> GetSolutionEntities { get; set; } = new(nameof(GetSolutionEntities));
    public static Request<CompilationStatus> GetCompilationStatus { get; set; } = new(nameof(GetCompilationStatus));
    public static Command<SymbolKey> SetFocusedRenderer { get; set; } = new(nameof(SetFocusedRenderer));
    public static Request<RendererResponse> GetFocusedRenderer { get; set; } = new(nameof(GetFocusedRenderer));
    public static Command<Metapsi.Live.Db.Input> SetCurrentInput { get; set; } = new(nameof(SetCurrentInput));
    public static Request<Metapsi.Live.Db.Input> GetSelectedInput { get; set; } = new(nameof(GetSelectedInput));

    public static Request<string> PreviewFocusedRenderer { get; set; } = new(nameof(PreviewFocusedRenderer));
    public static Request<string, SymbolKey> CreateEmptyModel { get; set; } = new(nameof(CreateEmptyModel));

    public class SolutionsResponse
    {
        public bool IsLoading { get; set; }
        public List<Solution> Solutions { get; set; } = new();
    }

    //public class ProjectsResponse
    //{
    //    public bool IsLoading { get; set; }
    //    public List<ProjectReference> Projects { get; set; } = new();
    //}

    //public class RoutesResponse
    //{
    //    public bool IsLoading { get; set; }
    //    public List<RouteReference> Routes { get; set; }
    //}

    //public class HandlersResponse
    //{
    //    public bool IsLoading { get; set; }
    //    public List<HandlerReference> Handlers { get; set; } = new();
    //}

    //public class RenderersResponse
    //{
    //    public bool IsLoading { get; set; }
    //    public List<RendererReference> Renderers { get; set; } = new();
    //    public List<HandlerReference> Handlers { get; set; } = new();

    //    public List<string> CompiledProjects { get; set; } = new();
    //    public string CurrentlyCompiling { get; set; } = string.Empty;
    //}

    public class RendererResponse : ApiResponse
    {
        public List<Metapsi.Live.Db.Input> Inputs { get; set; } = new();
        public SymbolKey Renderer { get; set; }
    }

    //public class Renderer
    //{
    //    public string Name { get; set; }
    //    public string ProjectName { get; set; }

    //    // Could be partial classes
    //    public List<string> FileNames { get; set; } = new();
    //}

    //public class Project
    //{
    //    public string Name { get; set; } = string.Empty;
    //    public List<string> UsedProjects { get; set; } = new();
    //}

    public static void MapBackend(this ImplementationGroup ig, 
        CompileEnvironment.State compileEnvironment,
            PanelEnvironment.State panelEnvironment,
            PreviewEnvironment.State previewEnvironment)
    {
        //ig.MapRequest(Backend.GetProjects, async (rc) =>
        //{
        //    return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetProjects);
        //});

        //ig.MapRequest(Backend.GetRoutes, async (rc) =>
        //{
        //    return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetRoutes);
        //});

        //ig.MapRequest(Backend.GetHandlers, async (rc) =>
        //{
        //    return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetHandlers);
        //});

        //ig.MapRequest(Backend.GetRenderers, async (rc) =>
        //{
        //    return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetRenderers);
        //});

        ig.MapRequest(Backend.GetSolutionEntities, async (rc) =>
        {
            return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetSolutionEntities);
        });

        ig.MapRequest(Backend.GetCompilationStatus, async (rc) =>
        {
            return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetCompilationStatus);
        });

        ig.MapRequest(Backend.GetFocusedRenderer, async (rc) =>
        {
            return await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetFocusedRenderer);
        });

        ig.MapCommand(Backend.SetFocusedRenderer, async (CommandRoutingContext rc, SymbolKey renderer) =>
        {
            await rc.Using(panelEnvironment, ig).EnqueueCommand(PanelEnvironment.SetFocusedRenderer, renderer);
        });

        ig.MapRequest(Backend.PreviewFocusedRenderer, async (RequestRoutingContext rc) =>
        {
            var renderer = await rc.Using(panelEnvironment, ig).EnqueueRequest(PanelEnvironment.GetFocusedRenderer);

            var input = panelEnvironment.SelectedInput;
            if (input == null)
                input = new Metapsi.Live.Db.Input()
                {
                    Json = string.Empty
                };

            var result = await rc.Using(compileEnvironment, ig).EnqueueRequest(CompileEnvironment.PreviewRenderer, renderer.Renderer, input.Json);
            return result;
        });


        ig.MapRequest(Backend.GetSelectedInput, async (rc) =>
        {
            return panelEnvironment.SelectedInput;
        });

        ig.MapRequest(PreviewEnvironment.GetPreviewParameters, async (cc) =>
        {
            var selectedInput = panelEnvironment.SelectedInput;
            if (selectedInput == null)
            {
                selectedInput = new Metapsi.Live.Db.Input();
            }

            return new PreviewEnvironment.PreviewParameters()
            {
                InputName = selectedInput.InputName,
                RendererName = panelEnvironment.FocusedRenderer.ClassPath.Last()
            };
        });

        ig.MapCommand(Backend.SetCurrentInput, async (c, selectedInput) =>
        {
            panelEnvironment.SelectedInput = selectedInput;
        });

        ig.MapRequest(Backend.CreateEmptyModel, async (RequestRoutingContext rc, SymbolKey renderer) =>
        {
            return await rc.Using(compileEnvironment, ig).EnqueueRequest(CompileEnvironment.CreateEmptyModel, renderer);
        });
    }
}