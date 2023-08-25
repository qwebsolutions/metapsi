using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class DocsModel : IHasTreeMenu
{
    public List<Route> Routes { get; set; } = new();
    public List<Doc> Docs { get; set; } = new();
    public bool MenuIsExpanded { get; set; }
    public Doc Doc { get; set; }
}

public class DocsHandler : Http.Get<Metapsi.Tutorial.Routes.Docs, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string docCode)
    {
        var parametersFullFilePath = Metapsi.RelativePath.SearchUpfolder(RelativePath.From.CurrentDir, "parameters.json");
        var dbFullPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(parametersFullFilePath), "Metapsi.Tutorial.db");


        DocsModel model = new DocsModel();
        await model.LoadRoutes();
        model.Doc = (await Sqlite.Db.Entities<Doc, string>(dbFullPath, x => x.Code, docCode)).SingleOrDefault();
        return Page.Result(model);
    }
}

public class DocsRenderer : ShoelaceHyperPage<DocsModel>
{
    public override Var<HyperNode> OnRender(BlockBuilder b, Var<DocsModel> model)
    {
        Metapsi.Shoelace.Import.Shoelace(b);
        b.AddModuleStylesheet();

        var breadcrumbs = b.Breadcrumb();
        b.Add(breadcrumbs, b.BreadcrumbButtonItem(b.Const("Docs")));
        b.Add(breadcrumbs, b.BreadcrumbButtonItemLast(b.Get(model, x => x.Doc.Title)));

        var container = b.Div();
        b.Add(container, b.Header(model, b => breadcrumbs));
        b.Add(container, b.DrawerTreeMenu(model));
        return container;
    }
}