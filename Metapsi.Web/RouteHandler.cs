using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class Http
    {
        public abstract class Get<TRoute> where TRoute : Route.IGet
        {
            public abstract Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext);
        }

        public abstract class Get<TRoute, T1>
            where TRoute : Route.IGet<T1>
        {
            public abstract Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, T1 p1);
        }

        public abstract class Get<TRoute, T1, T2>
            where TRoute : Route.IGet<T1, T2>
        {
            public abstract Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, T1 p1, T2 p2);
        }

        public abstract class Post<TRoute, T1>
            where TRoute : Route.IPost<T1>
        {
            public abstract Task<IResult> OnPost(CommandContext commandContext, HttpContext httpContext, T1 p1);
        }
    }

    //public interface IRouteHandler
    //{
    //    Task<IResult> Get(CommandContext commandContext, HttpContext httpContext);
    //    //Task<IResult> Get(CommandContext commandContext, HttpContext httpContext, string param);
    //    Task<IResult> Post(CommandContext commandContext, HttpContext httpContext);
    //    Task<IResult> Post<TPayload>(CommandContext commandContext, HttpContext httpContext, TPayload payload);
    //}

    //public interface IGetHandler<T1>
    //{
    //    Task<IResult> Get(CommandContext commandContext, HttpContext httpContext, T1 p1);
    //}

    //public abstract class RouteHandler<TRoute> : IRouteHandler
    //    where TRoute : IMetapsiRoute
    //{
    //    public virtual async Task<IResult> Get(CommandContext commandContext, HttpContext httpContext)
    //    {
    //        return Results.NotFound();
    //    }

    //    //public virtual async Task<IResult> Get(CommandContext commandContext, HttpContext httpContext, string param)
    //    //{
    //    //    return Results.NotFound();
    //    //}

    //    public virtual async Task<IResult> Post(CommandContext commandContext, HttpContext httpContext)
    //    {
    //        return Results.NotFound();
    //    }

    //    public virtual async Task<IResult> Post<TPayload>(CommandContext commandContext, HttpContext httpContext, TPayload payload)
    //    {
    //        return Results.NotFound();
    //    }
    //}

    //public abstract class GetHandler<TRoute, T1>
    //    where TRoute: IGetHandler<T1>
    //{
    //    public abstract Task<IResult> Get(CommandContext commandContext, HttpContext httpContext, T1 p1);
    //}
}