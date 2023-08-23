using Metapsi.Hyperapp;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class DocsModel
{

}

public class DocsHandler : Http.Get<Metapsi.Tutorial.Routes.Docs, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string docCode)
    {
        return Page.Result(new DocsModel());
    }
}


public class DocsRenderer : HyperPage<DocsModel>
{
    public override Var<HyperNode> OnRender(BlockBuilder b, Var<DocsModel> model)
    {
        return b.Text("Doc here");
    }
}