using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;


public class HomeModel : IHasTreeMenu
{
    public List<Route> Routes { get; set; } = new();
    public bool MenuIsExpanded { get; set; }
}

public class HomeHandler : Http.Get<Metapsi.Tutorial.Routes.Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        HomeModel model = new HomeModel();
        await model.LoadRoutes();
        return Page.Result(model);
    }
}

public class HomeRenderer : ShoelaceHyperPage<HomeModel>
{
    public override Var<HyperNode> OnRender(BlockBuilder b, Var<HomeModel> model)
    {
        Metapsi.Shoelace.Import.Shoelace(b);
        b.AddModuleStylesheet();

        var container = b.Div();
        b.Add(container, b.Header(model, b => b.VoidNode()));
        b.Add(container, b.DrawerTreeMenu(model));

        b.Add(
            container,
            b.Animation(b.Const(new Animation()
            {
                Name = "fadeIn",
                Iterations = 1,
                Delay = 1500,
                Play = true,
                Fill = "both"
            }),
            b => b.Div(
                "flex flex-col w-screen h-screen items-center justify-center",
                b =>
                {
                    var text = b.Text("Metapsi - The fullstack C# framework");

                    b.AddStyle(text, "font-size", "var(--sl-font-size-2x-large)");

                    return text;
                })));


        return container;
    }
}

public abstract class ShoelaceHyperPage<TDataModel> : HyperPage<TDataModel>
{
    public override IHtmlNode ModifyHtml(IHtmlNode root, Module module)
    {
        var shoelaceTags = module.Consts.Where(x => x.Value is ShoelaceTag).Select(x => (x.Value as ShoelaceTag).tag).ToList();

        var head = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "head");
        var style = head.AddChild(new HtmlTag("style"));
        style.AddChild(new HtmlText() { Text = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }" });

        var body = (root as HtmlTag).Children.Cast<HtmlTag>().Single(x => x.Tag == "body");

        var scriptTag = body.AddChild(new HtmlTag("script"));
        scriptTag.AddAttribute("type", "module");

        var whenDefinedArray = string.Join(",\n", shoelaceTags.Select(x => $"customElements.whenDefined('{x}')"));

        scriptTag.AddChild(new HtmlText()
        {
            Text = $" await Promise.allSettled([{whenDefinedArray}]);document.body.classList.add('ready');"
        });

        return root;
    }
}