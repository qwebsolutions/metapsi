using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live.Db;
using Metapsi.Sqlite;
using System;
using System.Collections.Generic;

public class Storage
{
    public static Request<List<Metapsi.Live.Db.Input>, string> LoadRendererInputs { get; set; } = new(nameof(LoadRendererInputs));
}

public class Backend
{
    public static Request<SolutionsResponse> GetSolutions { get; set; } = new(nameof(GetSolutions));

    public static Request<ProjectsResponse> GetProjects { get; set; } = new(nameof(GetProjects));
    public static Request<RoutesResponse> GetRoutes { get; set; } = new(nameof(GetRoutes));
    public static Request<RenderersResponse> GetRenderers { get; set; } = new(nameof(GetRenderers));
    public static Command<string> SetFocusedRenderer { get; set; } = new(nameof(SetFocusedRenderer));
    public static Request<RendererResponse> GetFocusedRenderer { get; set; } = new(nameof(GetFocusedRenderer));
    public static Command<Guid> SetInputId { get; set; } = new(nameof(SetInputId));
    public static Request<Metapsi.Live.Db.Input> GetSelectedInput { get; set; } = new(nameof(GetSelectedInput));

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
        public List<Renderer> Renderers { get; set; } = new();

        public HashSet<string> CompiledProjects { get; set; } = new();
        public string CurrentlyCompiling { get; set; } = string.Empty;
    }

    public class RendererResponse: ApiResponse
    {
        public List<Metapsi.Live.Db.Input> Inputs { get; set; } = new();
        public string RendererName { get; set; } = string.Empty;
    }

    public class Renderer
    {
        public string Name { get; set; }
        public string ProjectName { get; set; }
    }
}