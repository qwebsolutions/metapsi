//using System.Linq;
//using System.Threading.Tasks;
////using Metapsi.Hyperapp;
////using Metapsi.JavaScript;
//using Metapsi;
//using Microsoft.AspNetCore.Http;

//public class PreviewHandler : RouteHandler<Route.Preview>
//{
//    public class Model
//    {
//        public string Result { get; set; } = string.Empty;
//        //public Backend.ProjectsResponse Projects { get; set; }
//        //public Backend.RoutesResponse Routes { get; set; }
//        //public Backend.RenderersResponse Renderers { get; set; }
//        //public Backend.RendererResponse Renderer { get; set; }
//    }

//    public override async Task<IResult> Get(CommandContext commandContext, HttpContext httpContext)
//    {
//        var preview = await commandContext.Do(Backend.PreviewFocusedRenderer);

//        //string rendererName = httpContext.Request.Path.Value.Split("/").Last();

//        //await commandContext.Do(Backend.SetFocusedRenderer, rendererName);

//        return Page.Result(new Model()
//        {
//            Result = preview
//            //Projects = await commandContext.Do(Backend.GetProjects),
//            //Routes = await commandContext.Do(Backend.GetRoutes),
//            //Renderers = await commandContext.Do(Backend.GetRenderers),
//            //Renderer = 
//        });
//    }
//}  