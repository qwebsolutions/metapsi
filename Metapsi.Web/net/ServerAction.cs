using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


namespace Metapsi;

public static partial class ServerAction
{
    public static RouteHandlerBuilder MapServerActions(this WebApplication webApplication, string path = null)
    {
        if (path != null)
        {
            ServerAction.PostPath = path;
        }

        return webApplication.MapPost(ServerAction.PostPath, async (HttpContext httpContext, ServerAction.Call serverCall) =>
        {
            try
            {
                var result = await Run(serverCall);

                if (result != null)
                {
                    return Results.Ok(result);
                }
                else
                {
                    return Results.Ok();
                }
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        });
    }
}