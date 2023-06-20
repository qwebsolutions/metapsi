using Metapsi;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Metapsi.Live.Db
{
    public class Solution : IRecord
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
    }

    public class Input : IRecord
    {
        public Guid Id { get; set; }
        public string InputName { get; set; }
        public string RendererName { get; set; }
        public string Json { get; set; } = "{}";
    }
}

public class PanelEnvironment
{

    //public class ProjectSelected : IData
    //{
    //    public string ProjectName { get; set; } = string.Empty;
    //}

    public static async Task UpdateCompilationStatus(CommandContext commandContext, State state, List<string> compiledProjects, string currentlyCompiling)
    {
        foreach (var compiledProject in compiledProjects)
        {
            state.CompiledProjects.Add(compiledProject);
        }

        state.CurrentlyCompiling = currentlyCompiling;
    }

    public class RendererSelected : IData
    {
        public string RendererName { get; set; } = string.Empty;
    }

    public class State
    {
        public bool IsLoading { get; set; } = true;
        public string FullDbPath { get; set; }
        public List<string> Projects { get; set; } = new();
        public List<Backend.Renderer> AllRenderers { get; set; } = new();
        public List<string> AllRoutes { get; set; } = new();
        public string FocusedRenderer { get; set; } = string.Empty;
        public Metapsi.Live.Db.Input SelectedInput { get; set; }

        public HashSet<string> CompiledProjects { get; set; } = new();
        public string CurrentlyCompiling { get; set; } = string.Empty;
    }

    public static async Task SetLoading(CommandContext commandContext, State state, bool isLoading)
    {
        state.IsLoading = isLoading;
    }

    public static async Task SetProjects(CommandContext commandContext, State state, List<string> projects)
    {
        state.Projects = projects;
        state.IsLoading = false;
    }

    public static async Task SetRoutes(CommandContext commandContext, State state, List<string> routes)
    {
        state.AllRoutes = routes;
        state.IsLoading = false;
    }

    public static async Task SetRenderers(CommandContext commandContext, State state, List<Backend.Renderer> renderers)
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

    public static async Task<Backend.RenderersResponse> GetRenderers(CommandContext commandContext, State state)
    {
        return new Backend.RenderersResponse()
        {
            IsLoading = state.IsLoading,
            Renderers = state.AllRenderers,
            CompiledProjects = state.CompiledProjects,
            CurrentlyCompiling = state.CurrentlyCompiling
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