using System.Collections.Generic;

namespace Metapsi.Live
{
    public class SolutionSelected : IData
    {
        public Metapsi.Live.Db.Solution Solution { get; set; }
    }

    public class LoadingStarted : IData
    {
    }

    public class StartedProjectCompile : IData
    {
        public string ProjectName { get; set; }
    }

    public class FinishedProjectCompile : IData
    {
        public Backend.Project Project { get; set; }
    }

    public class RouteAdded : IData
    {
        public RouteReference Route { get; set; }
    }

    public class HandlerAdded : IData
    {
        public HandlerReference Handler { get; set; }
    }

    public class RendererAdded : IData
    {
        public RendererReference Renderer { get; set; }
    }

    public class SolutionLoaded : IData
    {
        //public List<Backend.Project> Projects { get; set; }
        //public List<string> Routes { get; set; }
        //public List<Backend.Renderer> Renderers { get; set; }
        //public List<string> Handlers { get; set; } = new();
        public List<EmbeddedResource> EmbeddedResources { get; set; } = new();
    }

    public class RendererGenerated : IData
    {
        public string RendererName { get; set; } = string.Empty;
        public string Js { get; set; } = string.Empty;
        public long Milliseconds { get; set; }
    }

    public class RendererSelected : IData
    {
        public string RendererName { get; set; } = string.Empty;
    }

    public class ProjectSelected : IData
    {
        public string ProjectName { get; set; }
    }

    public static class EventMapping
    {
        public static void MapEvents(
            this ApplicationSetup setup,
            ImplementationGroup ig,
            CompileEnvironment.State compileEnvironment,
            PanelEnvironment.State panelEnvironment,
            PreviewEnvironment.State previewEnvironment)
        {
            setup.MapEvent<SolutionSelected>(e =>
            {
                e.Using(compileEnvironment).EnqueueCommand(CompileEnvironment.InitSolution, e.EventData.Solution.Path);
            });

            setup.MapEvent<LoadingStarted>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetLoading, true);
            });

            setup.MapEvent<RouteAdded>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddRoute, e.EventData.Route);
            });

            setup.MapEvent<HandlerAdded>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddHandler, e.EventData.Handler);
            });

            setup.MapEvent<RendererAdded>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddRenderer, e.EventData.Renderer);
            });

            setup.MapEvent<SolutionLoaded>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetLoading, false);
                //e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetRoutes, e.EventData.Routes);
                //e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetRenderers, e.EventData.Renderers);
                e.Using(previewEnvironment, ig).EnqueueCommand(PreviewEnvironment.Start, e.EventData.EmbeddedResources);
            });

            setup.MapEvent<RendererGenerated>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetLoading, false);
                e.Using(panelEnvironment).EnqueueCommand(async (cc, state, rendererJs) =>
                {

                }, e.EventData.Js);
            });

            setup.MapEvent<StartedProjectCompile>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetCurrentlyCompiling, e.EventData.ProjectName);
            });

            setup.MapEvent<FinishedProjectCompile>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddProject, e.EventData.Project);
            });

            setup.MapEvent<RendererSelected>(e =>
            {
                e.Using(compileEnvironment).EnqueueCommand(CompileEnvironment.SwitchRenderer, e.EventData.RendererName);
            });
        }
    }
}
