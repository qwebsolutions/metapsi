using Metapsi;
using System.Collections.Generic;

public class Backend
{
    public static Request<ProjectsResponse> GetProjects { get; set; } = new(nameof(GetProjects));
    public static Request<RenderersResponse> GetRenderers { get; set; } = new(nameof(GetRenderers));
    public static Request<RendererResponse> GetRenderer { get; set; } = new(nameof(GetRenderer));

    public class ProjectsResponse
    {
        public bool IsLoading { get; set; }
        public List<string> Projects { get; set; }
    }

    public class RenderersResponse
    {
        public bool IsLoading { get; set; }
        public List<string> Renderers { get; set; } = new();
    }

    public class RendererResponse
    {
        public bool IsLoading { get; set; }
        public string Js { get; set; } = string.Empty;
    }
}