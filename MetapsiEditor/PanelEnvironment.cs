using Metapsi;
using Metapsi.Live;
using Microsoft.Build.Evaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class PanelEnvironment
{
    public static async Task AddProject(CommandContext commandContext, State state, Backend.Project project)
    {
        if (state.Projects.Any(x => x.Name == project.Name))
            return;

        state.Projects.Add(project);
    }

    public static async Task SetCurrentlyCompiling(CommandContext commandContext, State state, string currentlyCompiling)
    {
        state.CurrentlyCompiling = currentlyCompiling;
    }



    public class State
    {
        public bool IsLoading { get; set; } = true;
        public string FullDbPath { get; set; }
        public List<Backend.Project> Projects { get; set; } = new();
        public List<RendererReference> AllRenderers { get; set; } = new();
        public List<HandlerReference> Handlers { get; set; } = new();
        public List<string> AllRoutes { get; set; } = new();
        public string FocusedRenderer { get; set; } = string.Empty;
        public Metapsi.Live.Db.Input SelectedInput { get; set; }
        public string CurrentlyCompiling { get; set; } = string.Empty;
    }

    public static async Task SetLoading(CommandContext commandContext, State state, bool isLoading)
    {
        state.IsLoading = isLoading;
    }

    public static async Task AddRoute(CommandContext commandContext, State state, string routeName)
    {
        state.AllRoutes.Add(routeName);
    }

    public static async Task AddHandler(CommandContext commandContext, State state, HandlerReference handlerName)
    {
        state.Handlers.Add(handlerName);
    }

    public static async Task AddRenderer(CommandContext commandContext, State state, RendererReference renderer)
    {
        state.AllRenderers.Add(renderer);
    }

    //public static async Task SetProjects(CommandContext commandContext, State state, List<Backend.Project> projects)
    //{
    //    state.Projects = projects;
    //    state.IsLoading = false;
    //}

    public static async Task SetRoutes(CommandContext commandContext, State state, List<string> routes)
    {
        state.AllRoutes = routes;
        state.IsLoading = false;
    }

    public static async Task SetHandlers(CommandContext commandContext, State state, List<HandlerReference> handlers)
    {
        state.Handlers = handlers;
        state.IsLoading = false;
    }

    public static async Task SetRenderers(CommandContext commandContext, State state, List<RendererReference> renderers)
    {
        state.AllRenderers = renderers;
        state.IsLoading = false;
    }

    public static async Task<Backend.ProjectsResponse> GetProjects(CommandContext commandContext, State state)
    {
        return new Backend.ProjectsResponse()
        {
            IsLoading = state.IsLoading,
            Projects = state.Projects
        };
    }

    public static async Task<Backend.RoutesResponse> GetRoutes(CommandContext commandContext, State state)
    {
        return new Backend.RoutesResponse()
        {
            IsLoading = state.IsLoading,
            Routes = state.AllRoutes
        };
    }

    public static async Task<Backend.HandlersResponse> GetHandlers(CommandContext commandContext, State state)
    {
        return new Backend.HandlersResponse()
        {
            IsLoading = state.IsLoading,
            Handlers = state.Handlers
        };
    }

    public static async Task<Backend.RenderersResponse> GetRenderers(CommandContext commandContext, State state)
    {
        return new Backend.RenderersResponse()
        {
            IsLoading = state.IsLoading,
            Renderers = state.AllRenderers,
            CompiledProjects = state.Projects.Select(x => x.Name).ToList(),
            CurrentlyCompiling = state.CurrentlyCompiling,
            Handlers = state.Handlers
        };
    }

    public static async Task SetFocusedRenderer(CommandContext commandContext, State state, string renderer)
    {
        state.FocusedRenderer = renderer;
    }

    public static async Task<Backend.RendererResponse> GetRenderer(CommandContext commandContext, State state)
    {
        var inputs = await commandContext.Do(Storage.LoadRendererInputs, state.FocusedRenderer);

        return new Backend.RendererResponse()
        {
            RendererName = state.FocusedRenderer,
            Inputs = inputs
        };
    }
}