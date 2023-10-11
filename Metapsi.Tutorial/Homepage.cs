using Metapsi.Shoelace;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class HomepageModel : IHasTreeMenu
{
    public List<MenuEntry> Menu { get; set; } = new List<MenuEntry>();
    public MenuEntry CurrentEntry { get; set; } = new();

    public bool MenuIsExpanded { get; set; }
}

public class HomepageHandler : Http.Get<Metapsi.Tutorial.Routes.Home>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext)
    {
        HomepageModel model = new HomepageModel();
        await model.LoadMenu();
        model.SetCurrentEntry(httpContext.Request.Path);
        return Page.Result(model);
    }
}

public class Homepage : HtmlPage<HomepageModel>
{
    public override IHtmlNode GetHtmlTree(HomepageModel dataModel)
    {
        return Tutorial.CommonLayout(dataModel, "Metapsi - The full stack C# framework", new HtmlTag("header").WithChild(new HtmlText("Metapsi")), HomepageContent());
    }

    public IHtmlElement GithubLink()
    {
        return new HtmlTag("a").SetAttribute("href", "https://github.com/qwebsolutions/metapsi").SetAttribute("target", "_blank").WithChild(DivTag.CreateStyled("flex flex-row items-center gap-4 opacity-75 hover:opacity-100 text-base font-sans text-blue-500 font-light", Component.Create("sl-icon", new Icon
        {
            Name = "github"
        }), HtmlText.Create("github.com/qwebsolutions/metapsi")));
    }

    public IHtmlElement TopSlogan()
    {
        return DivTag.CreateStyled("flex flex-col justify-center items-center text-gray-800 text-center", Component.Create("sl-animation", new Animation
        {
            Name = "fadeInDown",
            Iterations = 1,
            Duration = 300,
            Delay = 500,
            Play = true,
            Fill = "both",
            Easing = "easeOut"
        }, SpanTag.Create(HtmlText.Create("The "), HtmlText.Create("full stack C#").WithClass("bg-blue-50"), HtmlText.Create(" framework"))), Animation.Create(new Animation
        {
            Name = "fadeIn",
            Iterations = 1,
            Delay = 1000,
            Duration = 500,
            Play = true,
            Fill = "both",
            Easing = "easeOut"
        }, DivTag.Create(HtmlText.Create("that "), Tooltip.Create(new Tooltip
        {
            Placement = TooltipPlacement.Bottom
        }, HtmlText.Create("packs").WithClass("underline decoration-dashed"), Component.Create("sl-icon", new Icon
        {
            Name = "box-seam"
        })), HtmlText.Create(" everything.")))).WithStyle("font-size", "var(--sl-font-size-2x-large)").WithStyle("font-family", "var(--sl-font-serif)")
            .WithStyle("font-weight", "var(--sl-font-weight-bold)");
    }

    public HtmlTag HomepageContent()
    {
        DivTag pageContainer = DivTag.CreateStyled("flex flex-col mt-20", DivTag.CreateStyled("flex flex-col justify-center items-center gap-12 py-16", TopSlogan(), GithubLink()));
        pageContainer.AddChild(DivTag.CreateStyled("flex flex-col bg-blue-50", HomeFeature("wrench", "Your tools", "Stay inside VS Code/Visual Studio, just add nugets and you're ready to go.", "No node.js, no npm required."), Separator(), HomeFeature("arrow-left-right", "Your types, everywhere", "The client-side code speaks C#. One definition, shared"), Separator(), HomeFeature("box", "Your version, always", "Resources are embedded, allowing you to upgrade & downgrade atomically", "This applies to CSS, JS, images & more"), Separator(), HomeFeature("scissors", "Your solution & nothing else", "You don't use it? Then it's not included. Each HTML page knows exactly what JS files it needs."), Separator(), HomeFeature("layers", "Your level", "Nugets build on top of each other, allowing you to work as high or low level as you need"), Separator(), HomeFeature("file-text", "Open source", "MIT licensed, just like the great projects we build upon")));
        return pageContainer;
    }

    public HtmlTag Separator()
    {
        return DivTag.CreateStyled("mx-4 lg:mx-12 bg-gray-200 h-px");
    }

    public HtmlTag HomeFeature(string iconName, string title, string subtitle = null, string details = null)
    {
        DivTag featureDetails = DivTag.CreateStyled("flex flex-col gap-4 text-gray-700 lg:flex-1 lg:basis-2/3 ", HtmlText.Create(title).WithClass("text-large font-semibold"));
        if (!string.IsNullOrEmpty(subtitle))
        {
            featureDetails.AddChild(HtmlText.Create(subtitle).WithClass("text-sm"));
        }
        if (!string.IsNullOrEmpty(details))
        {
            featureDetails.AddChild(HtmlText.Create(details).WithClass("text-sm"));
        }
        return DivTag.CreateStyled("flex flex-row items-center justify-center gap-8 lg:gap-24 bg-blue-50 px-4 py-12 lg:p-16", DivTag.CreateStyled("flex flex-row items-center justify-end lg:flex-1 lg:basis-1/3 ", DivTag.CreateStyled("flex flex-row items-center justify-center w-16 h-16 text-3xl rounded-full bg-blue-400 text-white", Component.Create("sl-icon", new Icon
        {
            Name = iconName
        }))), featureDetails);
    }
}
