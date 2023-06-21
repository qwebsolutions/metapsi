using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Metapsi.Hyperapp;
//using Metapsi.JavaScript;
using Metapsi;
using Metapsi.Hyperapp;
using Metapsi.Live.Db;
using Microsoft.AspNetCore.Http;

public static partial class Handler
{
    public enum View
    {
        ListSolutions,
        WaitingCompile,
        SolutionSummary,
        ListRenderers,
        FocusRenderer
    }


    public class Home: Http.Get<Metapsi.Live.Route.Home>
    {
        public class Model : IApiSupportState
        {
            public View CurrentView { get; set; } = View.ListSolutions;
            public List<Solution> Solutions { get; set; }
            public Guid SelectedSolutionId { get; set; }
            public List<Backend.Renderer> Renderers { get; set; } = new();
            public Backend.Renderer SelectedRenderer { get; set; }

            public List<Metapsi.Live.Db.Input> Inputs { get; set; } = new();
            public Guid SelectedInputId { get; set; }

            public ApiSupport ApiSupport { get; set; } = new();

            public List<string> CompiledProjects { get; set; } = new();
            public string CurrentlyCompiling { get; set; } = string.Empty;
        }

        public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
        {
            var solutions = await commandContext.Do(Backend.GetSolutions);
            return Page.Result(new Model()
            {
                Solutions = solutions.Solutions
            });
        }
    }

}