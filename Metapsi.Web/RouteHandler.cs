using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Metapsi
{
    public interface IRouteHandler
    {
        Task<IResult> Get(CommandContext commandContext, HttpContext httpContext);
        Task<IResult> Post(CommandContext commandContext, HttpContext httpContext);
        Task<IResult> Post<TPayload>(CommandContext commandContext, HttpContext httpContext, TPayload payload);
    }

    public abstract class RouteHandler<TRoute> : IRouteHandler
        where TRoute : IMetapsiRoute
    {
        public virtual async Task<IResult> Get(CommandContext commandContext, HttpContext httpContext)
        {
            return Results.NotFound();
        }

        public virtual async Task<IResult> Post(CommandContext commandContext, HttpContext httpContext)
        {
            return Results.NotFound();
        }

        public virtual async Task<IResult> Post<TPayload>(CommandContext commandContext, HttpContext httpContext, TPayload payload)
        {
            return Results.NotFound();
        }
    }
}