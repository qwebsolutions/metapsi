using Metapsi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;
using static Metapsi.WebServer;

namespace Metapsi;

public static class ApiHandler
{
    // Command 0

    public static void MapCommand(this IEndpointRouteBuilder app, Command command, Func<CommandContext, HttpContext, Task> task, Authorization authorization, SwaggerTryout allowSwaggerTryout = SwaggerTryout.Block)
    {
        app.MapGet($"/{command.Name}", async (CommandContext commandContext, HttpContext httpContext) =>
        {
            try
            {
                ThrowSwaggerException(httpContext, allowSwaggerTryout);
                await task(commandContext, httpContext);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                commandContext.Logger.LogException(ex);
                throw;
            }
        }).With(authorization);
    }

    // Request 0

    public static void MapRequest<TOut>(this IEndpointRouteBuilder app, Request<TOut> request, Func<CommandContext, HttpContext, Task<TOut>> task, Authorization authorization, SwaggerTryout allowSwaggerTryout = SwaggerTryout.Block)
    {
        app.MapGet($"/{request.Name}", async (CommandContext commandContext, HttpContext httpContext) =>
        {
            try
            {
                ThrowSwaggerException(httpContext, allowSwaggerTryout);
                return await task(commandContext, httpContext);
            }
            catch (Exception ex)
            {
                commandContext.Logger.LogException(ex);
                throw;
            }
        }).With(authorization);
    }

    // Command 1

    public static void MapCommand<T1>(this IEndpointRouteBuilder app, Command<T1> command, Func<CommandContext, HttpContext, T1, Task> task, Authorization authorization, SwaggerTryout allowSwaggerTryout = SwaggerTryout.Block)
    {
        if (Api.AreScalarTypes(typeof(T1)))
        {
            app.MapGet($"/{command.Name}/{{p1}}", async (CommandContext commandContext, HttpContext httpContext, [FromRoute] T1 p1) =>
            {
                try
                {
                    ThrowSwaggerException(httpContext, allowSwaggerTryout);
                    await task(commandContext, httpContext, Unescape(p1));
                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    commandContext.Logger.LogException(ex);
                    throw;
                }
            }).With(authorization);
        }
        else
        {
            app.MapPost($"/{command.Name}", async (CommandContext commandContext, HttpContext httpContext, [FromBody] Api.PostBody<T1> body) =>
            {
                try
                {
                    ThrowSwaggerException(httpContext, allowSwaggerTryout);
                    await task(commandContext, httpContext, body.P1);
                    return Results.Ok();
                }
                catch (Exception ex)
                {
                    commandContext.Logger.LogException(ex);
                    throw;
                }
            }).With(authorization);
        }
    }

    // Request 1

    public static void MapRequest<T1, TOut>(this IEndpointRouteBuilder app, Request<TOut, T1> request, Func<CommandContext, HttpContext, T1, Task<TOut>> task, Authorization authorization, SwaggerTryout allowSwaggerTryout = SwaggerTryout.Block)
    {
        if (Api.AreScalarTypes(typeof(T1)))
        {
            app.MapGet($"/{request.Name}/{{p1}}", async (CommandContext commandContext, HttpContext httpContext, [FromRoute] T1 p1) =>
            {
                try
                {
                    ThrowSwaggerException(httpContext, allowSwaggerTryout);
                    return await task(commandContext, httpContext, Unescape(p1));
                }
                catch (Exception ex)
                {
                    commandContext.Logger.LogException(ex);
                    throw;
                }
            }).With(authorization);
        }
        else
        {
            app.MapPost($"/{request.Name}", async (CommandContext commandContext, HttpContext httpContext, [FromBody] Api.PostBody<T1> body) =>
            {
                try
                {
                    var p1 = body == null ? default(T1) : body.P1;

                    ThrowSwaggerException(httpContext, allowSwaggerTryout);
                    return await task(commandContext, httpContext, p1);
                }
                catch (Exception ex)
                {
                    commandContext.Logger.LogException(ex);
                    throw;
                }
            }).With(authorization);
        }
    }

    private static RouteHandlerBuilder With(this RouteHandlerBuilder builder, Authorization authorization)
    {
        if (authorization == Authorization.Require)
        {
            return builder.RequireAuthorization();
        }
        else
        {
            return builder.AllowAnonymous();
        }
    }
}

public static class ApiExtensions
{
    public static void On<T>(this IEndpointRouteBuilder builder, System.Func<CommandContext, HttpContext, T, Task<IResult>> handler)
    {
        builder.MapPost($"/{typeof(T).Name}", handler);
    }
}