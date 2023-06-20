using Metapsi;
using Metapsi.Hyperapp;
using System;
using System.Collections.Generic;

public static class Frontend
{
    public class RenderersResponse: ApiResponse
    {
        public bool IsLoading { get; set; }
        public List<Backend.Renderer> Renderers { get; set; } = new();
        public List<string> CompiledProjects { get; set; } = new();
        public string CurrentlyCompiling { get; set; } = string.Empty;
    }

    public static Request<ApiResponse, Guid> SelectSolution { get; set; } = new(nameof(SelectSolution));
    public static Request<RenderersResponse, bool> GetRenderers { get; set; } = new(nameof(GetRenderers));
    public static Request<Backend.RendererResponse, Backend.Renderer> SelectRenderer { get; set; } = new(nameof(SelectRenderer));
    public static Request<ApiResponse, Guid> SetInputId { get; set; } = new(nameof(SetInputId));
    public static Request<Backend.RendererResponse, string> AddRendererInput { get; set; } = new(nameof(AddRendererInput));
}
