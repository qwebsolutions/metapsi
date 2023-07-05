using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Frontend
{
    public class SolutionEntities : ApiResponse
    {
        public bool IsLoading { get; set; }
        public List<RendererReference> Renderers { get; set; } = new();
        public List<Backend.Project> CompiledProjects { get; set; } = new();
        public List<RouteReference> Routes { get; set; } = new();
        public List<HandlerReference> Handlers { get; set; } = new();
        public string CurrentlyCompiling { get; set; } = string.Empty;
    }

    public static Request<ApiResponse, Guid> SelectSolution { get; set; } = new(nameof(SelectSolution));
    public static Request<SolutionEntities, bool> GetSolutionSummary { get; set; } = new(nameof(GetSolutionSummary));
    public static Request<Backend.RendererResponse, SymbolKey> SelectRenderer { get; set; } = new(nameof(SelectRenderer));
    public static Request<ApiResponse, Guid> SetInputId { get; set; } = new(nameof(SetInputId));
    public static Request<Backend.RendererResponse, SymbolKey> AddRendererInput { get; set; } = new(nameof(AddRendererInput));


    public static void MapFrontend(this RouteGroupBuilder apiEndpoint)
    {
        apiEndpoint.MapRequest(Frontend.SelectSolution, async (CommandContext commandContext, HttpContext httpContext, Guid slnId) =>
        {
            var solutions = await commandContext.Do(Storage.GetSolutions);
            var selectedSolution = solutions.Solutions.Single(x => x.Id == slnId);

            commandContext.PostEvent(new SolutionSelected()
            {
                Solution = selectedSolution
            });

            return new ApiResponse()
            {
                ResultCode = "Ok"
            };
        }, WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.GetSolutionSummary, async (CommandContext commandContext, HttpContext httpContext, bool _) =>
        {
            var renderers = await commandContext.Do(Backend.GetRenderers);
            var projects = await commandContext.Do(Backend.GetProjects);
            var routes = await commandContext.Do(Backend.GetRoutes);
            var handlers = await commandContext.Do(Backend.GetHandlers);

            return new Frontend.SolutionEntities()
            {
                IsLoading = renderers.IsLoading,
                Renderers = renderers.Renderers,
                CurrentlyCompiling = renderers.CurrentlyCompiling,
                CompiledProjects = projects.Projects,
                Routes = routes.Routes,
                Handlers = handlers.Handlers
            };
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.SelectRenderer, async (CommandContext commandContext, HttpContext httpContext, SymbolKey renderer) =>
        {
            await commandContext.Do(Backend.SetFocusedRenderer, renderer);
            return await commandContext.Do(Backend.GetFocusedRenderer);
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.AddRendererInput, async (CommandContext commandContext, HttpContext httpContext, SymbolKey rendererKey) =>
        {
            var emptyModel = await commandContext.Do(Backend.CreateEmptyModel, rendererKey);
            //var emptyModel = await CompileEnvironment.CreateEmptyModel(commandContext, compileEnvironment, rendererName);

            await commandContext.Do(Storage.SaveInput, rendererKey, emptyModel);
            var renderer = await commandContext.Do(Backend.GetFocusedRenderer);

            return renderer;
        },
        WebServer.Authorization.Public);

        apiEndpoint.MapRequest(Frontend.SetInputId, async (CommandContext commandContext, HttpContext httpContext, Guid inputId) =>
        {
            var focusedRenderer = await commandContext.Do(Backend.GetFocusedRenderer);
            var selectedInput = focusedRenderer.Inputs.SingleOrDefault(x => x.Id == inputId);

            await commandContext.Do(Backend.SetCurrentInput, selectedInput);
            return new ApiResponse();
        },
        WebServer.Authorization.Public);
    }
}
