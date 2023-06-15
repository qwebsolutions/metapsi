using System.Collections.Generic;
using System.Threading.Tasks;
//using Metapsi.Hyperapp;
//using Metapsi.JavaScript;
using Metapsi;
using Metapsi.Live.Db;
using Microsoft.AspNetCore.Http;

public static partial class Handler
{
    public class Home: Http.Get<Metapsi.Live.Route.Home>
    {
        public class Model
        {
            public List<Solution> Solutions { get; set; }
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