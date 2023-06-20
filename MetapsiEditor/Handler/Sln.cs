//using System;
//using System.Linq;
//using System.Threading.Tasks;
////using Metapsi.Hyperapp;
////using Metapsi.JavaScript;
//using Metapsi;
//using Microsoft.AspNetCore.Http;

//public static partial class Handler
//{
//    public class Sln : Http.Get<Metapsi.Live.Route.Sln, Guid>
//    {
//        public class Model
//        {
//            public Backend.ProjectsResponse Projects { get; set; }
//            public Backend.RoutesResponse Routes { get; set; }
//            public Backend.RenderersResponse Renderers { get; set; }
//            public Backend.RendererResponse Renderer { get; set; }
//        }

//        public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, Guid id)
//        {
//            var solutions = await commandContext.Do(Backend.GetSolutions);
//            var selectedSolution = solutions.Solutions.Single(x => x.Id == id);

//            commandContext.PostEvent(new CompileEnvironment.SolutionSelected()
//            {
//                Solution = selectedSolution
//            });

//            return Page.Result(new Model()
//            {
//                Projects = await commandContext.Do(Backend.GetProjects),
//                Routes = await commandContext.Do(Backend.GetRoutes),
//                Renderers = await commandContext.Do(Backend.GetRenderers),
//                //Renderer = await commandContext.Do(Backend.GetRenderer)
//            });
//        }
//    }
//}