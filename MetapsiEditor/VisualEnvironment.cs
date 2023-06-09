using Metapsi;
using System.Collections.Generic;
using System.Threading.Tasks;

public class VisualEnvironment
{
    public class ProjectSelected : IData
    {
        public string ProjectName { get; set; } = string.Empty;
    }

    public class RendererSelected : IData
    {
        public string RendererName { get; set; } = string.Empty;
    }

    public class State
    {
        public bool IsLoading { get; set; } = true;
        public List<string> Projects { get; set; } = new();
        public List<string> ProjectRenderers { get; set; } = new();
        public string SelectedProjectName { get; set; }
        public string SelectedRendererName { get; set; }
        public string RendererJs { get; set; }
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

    public static async Task SetProjectRenderers(CommandContext commandContext, State state, List<string> renderers)
    {
        state.ProjectRenderers = renderers;
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

    public static async Task<Backend.RenderersResponse> GetRenderers(CommandContext commandContext, State state)
    {
        return new Backend.RenderersResponse()
        {
            IsLoading = state.IsLoading,
            Renderers = state.ProjectRenderers
        };
    }

    public static async Task<Backend.RendererResponse> GetRenderer(CommandContext commandContext, State state)
    {
        return new Backend.RendererResponse()
        {
            IsLoading = state.IsLoading,
            Js = state.RendererJs
        };
    }
}