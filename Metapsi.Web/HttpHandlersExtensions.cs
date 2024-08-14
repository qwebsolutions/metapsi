using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class HttpHandlersExtensions
    {
        public static RouteHandlerBuilder MapGetCommand<TIn>(this IEndpointRouteBuilder endpoint, Command<TIn> request, System.Func<CommandContext, HttpContext, TIn, Task> handler)
        {
            return endpoint.MapGet(request.Name + "/{p1}", (CommandContext commandContext, HttpContext httpContext, TIn p1) =>
            {
                return HandleException(commandContext, httpContext, handler(commandContext, httpContext, p1));
            });
        }

        public static RouteHandlerBuilder MapPostCommand<TIn>(this IEndpointRouteBuilder endpoint, Command<TIn> request, System.Func<CommandContext, HttpContext, TIn, Task> handler)
        {
            return endpoint.MapPost(request.Name, (CommandContext commandContext, HttpContext httpContext, TIn p1) =>
            {
                return HandleException(commandContext, httpContext, handler(commandContext, httpContext, p1));
            });
        }

        public static RouteHandlerBuilder MapGetRequest<TOut>(this IEndpointRouteBuilder endpoint, Request<TOut> request, System.Func<CommandContext, HttpContext, Task<TOut>> handler)
        {
            return endpoint.MapGet(request.Name, (CommandContext commandContext, HttpContext httpContext) =>
            {
                return HandleException(commandContext, httpContext, handler(commandContext, httpContext));
            });
        }

        public static RouteHandlerBuilder MapGetRequest<TOut>(this IEndpointRouteBuilder endpoint, Request<TOut, string> request, System.Func<CommandContext, HttpContext, string, Task<TOut>> handler)
        {
            return endpoint.MapGet(request.Name + "/{p1}", (CommandContext commandContext, HttpContext httpContext, string p1) => HandleException(commandContext, httpContext, handler(commandContext, httpContext, p1)));
        }

        public static RouteHandlerBuilder MapGetRequest<TOut>(this IEndpointRouteBuilder endpoint, Request<TOut, Guid> request, System.Func<CommandContext, HttpContext, Guid, Task<TOut>> handler)
        {
            return endpoint.MapGet(request.Name + "/{p1}", (CommandContext commandContext, HttpContext httpContext, Guid p1) => HandleException(commandContext, httpContext, handler(commandContext, httpContext, p1)));
        }

        public static RouteHandlerBuilder MapPostRequest<TIn, TOut>(this IEndpointRouteBuilder endpoint, Request<TOut, TIn> request, System.Func<CommandContext, HttpContext, TIn, Task<TOut>> handler)
        {
            return endpoint.MapPost(request.Name, (CommandContext commandContext, HttpContext httpContext, [FromBody] TIn input) =>
            {
                return HandleException(commandContext, httpContext, handler(commandContext, httpContext, input));
            });
        }

        public static RouteHandlerBuilder MapPostRequest<TOut>(this IEndpointRouteBuilder endpoint, Request<TOut> request, System.Func<CommandContext, HttpContext, Task<TOut>> handler)
        {
            return endpoint.MapPost(request.Name, (CommandContext commandContext, HttpContext httpContext) =>
            {
                return HandleException(commandContext, httpContext, handler(commandContext, httpContext));
            });
        }

        public static async Task<IResult> HandleException<T>(CommandContext commandContext, HttpContext httpContext, Task<T> handlerTask)
        {
            try
            {
                var result = await handlerTask;
                return Results.Ok(result);
            }
            catch (Exception ex)
            {
                commandContext.Logger.LogException(ex);
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsync(ex.Message);
                return Results.Json(ex.Message, statusCode: 500);
            }
        }

        public static async Task<IResult> HandleException(CommandContext commandContext, HttpContext httpContext, Task handlerTask)
        {
            try
            {
                await handlerTask;
                return Results.Ok();
            }
            catch (Exception ex)
            {
                commandContext.Logger.LogException(ex);
                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await httpContext.Response.WriteAsync(ex.Message);
                return Results.Json(ex.Message, statusCode: 500);
            }
        }
    }
}