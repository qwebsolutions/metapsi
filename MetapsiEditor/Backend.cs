using Metapsi;
using Metapsi.Live.Db;
using System.Collections.Generic;

public class Backend
{
    public static Request<SolutionsResponse> GetSolutions { get; set; } = new(nameof(GetSolutions));

    public static Request<ProjectsResponse> GetProjects { get; set; } = new(nameof(GetProjects));
    public static Request<RoutesResponse> GetRoutes { get; set; } = new(nameof(GetRoutes));
    public static Request<RenderersResponse> GetRenderers { get; set; } = new(nameof(GetRenderers));
    public static Command<string> SetFocusedRenderer { get; set; } = new(nameof(SetFocusedRenderer));
    public static Request<RendererResponse> GetFocusedRenderer { get; set; } = new(nameof(GetFocusedRenderer));
    public static Request<string> PreviewFocusedRenderer { get; set; } = new(nameof(PreviewFocusedRenderer));

    public class SolutionsResponse
    {
        public bool IsLoading { get; set; }
        public List<Solution> Solutions { get; set; } = new();
    }

    public class ProjectsResponse
    {
        public bool IsLoading { get; set; }
        public List<string> Projects { get; set; }
    }

    public class RoutesResponse
    {
        public bool IsLoading { get; set; }
        public List<string> Routes { get; set; }
    }

    public class RenderersResponse
    {
        public bool IsLoading { get; set; }
        public List<string> Renderers { get; set; } = new();
    }

    public class RendererResponse
    {
        public bool IsLoading { get; set; }
        public string RendererName { get; set; } = string.Empty;
        public string Js { get; set; } = string.Empty;
    }
}