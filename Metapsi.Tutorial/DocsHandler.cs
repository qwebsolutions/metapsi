using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class DocsModel : IHasTreeMenu
{
    public List<Route> Routes { get; set; } = new();
    public bool MenuIsExpanded { get; set; }
}

public class DocsHandler : Http.Get<Metapsi.Tutorial.Routes.Docs, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string docCode)
    {
        DocsModel model = new DocsModel();
        await model.LoadRoutes();
        return Page.Result(model);
    }
}

public class DocsRenderer : HyperPage<DocsModel>
{
    public override Var<HyperNode> OnRender(BlockBuilder b, Var<DocsModel> model)
    {
        Metapsi.Shoelace.Import.Shoelace(b);
        b.AddModuleStylesheet();

        var container = b.Div();
        b.Add(container, b.Header(model, b => b.VoidNode()));
        b.Add(container, b.DrawerTreeMenu(model));
        return container;
    }
}