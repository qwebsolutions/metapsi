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
}