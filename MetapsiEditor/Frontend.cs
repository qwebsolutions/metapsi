//using Metapsi;
//using Metapsi.Hyperapp;
//using Microsoft.AspNetCore.Routing;
//using System;

//public static class Frontend
//{
//    public static Request<ApiResponse, string> SelectProject { get; set; } = new(nameof(SelectProject));
//    public static Request<ApiResponse, string> SelectRenderer { get; set; } = new(nameof(SelectRenderer));

//    public static void MapFrontend(this IEndpointRouteBuilder routeBuilder)
//    {
//        routeBuilder.MapRequest(Frontend.SelectProject, async (cc, http, projectName) =>
//        {
//            cc.PostEvent(new VisualEnvironment.ProjectSelected()
//            {
//                ProjectName = projectName
//            });

//            return new ApiResponse
//            {
//                ResultCode = ApiResultCode.Ok
//            };
//        },
//        WebServer.Authorization.Public);

//        routeBuilder.MapRequest(Frontend.SelectRenderer, async (cc, http, renderer) =>
//        {
//            cc.PostEvent(new VisualEnvironment.RendererSelected()
//            {
//                RendererName = renderer
//            });

//            return new ApiResponse
//            {
//                ResultCode = ApiResultCode.Ok
//            };
//        },
//        WebServer.Authorization.Public);
//    }
//}
