﻿using System.Collections.Generic;

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
        public string ProjectName { get; set; }
    }

    public class SolutionParsed : IData
    {
        public int TotalProjects { get; set; }
    }

    public class CompilationError
    {
        public string ProjectName { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
    }

    public class SolutionCompiled : IData
    {
        public SolutionEntities SolutionEntities { get; set; }
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

            //setup.MapEvent<RouteAdded>(e =>
            //{
            //    e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddRoute, e.EventData.Route);
            //});

            //setup.MapEvent<HandlerAdded>(e =>
            //{
            //    e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddHandler, e.EventData.Handler);
            //});

            //setup.MapEvent<RendererAdded>(e =>
            //{
            //    e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddRenderer, e.EventData.Renderer);
            //});

            setup.MapEvent<SolutionParsed>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(async (cc, state) => state.TotalProjects = e.EventData.TotalProjects);
            });

            setup.MapEvent<SolutionCompiled>(e =>
            {
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.SetLoading, false);
                e.Using(panelEnvironment, ig).EnqueueCommand(PanelEnvironment.SetSolutionEntities, e.EventData.SolutionEntities);
                e.Using(previewEnvironment, ig).EnqueueCommand(PreviewEnvironment.Start, e.EventData.SolutionEntities);
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
                e.Using(panelEnvironment).EnqueueCommand(PanelEnvironment.AddAlreadyCompiled, e.EventData.ProjectName);
            });

            setup.MapEvent<RendererSelected>(e =>
            {
                e.Using(compileEnvironment).EnqueueCommand(CompileEnvironment.SwitchRenderer, e.EventData.RendererName);
            });

            setup.MapEvent<CompileEnvironment.FileChanged>(e =>
            {
                e.Using(compileEnvironment).EnqueueCommand(async (commandContext, state) =>
                {
                    state.ChangedSinceLastCompilation.Add(e.EventData);
                });
            });
        }
    }
}
