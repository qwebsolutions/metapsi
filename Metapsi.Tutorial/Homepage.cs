using Metapsi.Html;
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

public static class Homepage
{
    public static void Render(HtmlBuilder b, HomepageModel model)
    {
        b.Document.UseWebComponentsFadeIn();
        b.InitCommonLayout(
            model, 
            "Metapsi - The full stack C# framework", 
            b.HtmlHeader(b.Text("Metapsi")),
            b.HomepageContent());
    }

    public static IHtmlNode GithubLink(this HtmlBuilder b)
    {
        return b.HtmlA(
            b =>
            {
                b.SetHref("https://github.com/qwebsolutions/metapsi");
                b.SetTarget("_blank");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row items-center gap-4 opacity-75 hover:opacity-100 text-base font-sans text-blue-500 font-light");
                },
                b.SlIcon(
                    b =>
                    {
                        b.SetName("github");
                    }),
                b.HtmlSpan(b.Text("github.com/qwebsolutions/metapsi"))));
    }

    public static IHtmlNode TopSlogan(this HtmlBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col justify-center items-center text-gray-800 text-center");
                b.SetAttribute("style", " font-size: var(--sl-font-size-2x-large); font-family: var(--sl-font-serif); font-weight: var(--sl-font-weight-bold);");
            },
            b.SlAnimation(
                b =>
                {
                    b.SetName("fadeInDown");
                    b.SetIterations("1");
                    b.SetDuration("300");
                    b.SetDelay("500");
                    b.SetPlay();
                    b.SetFill("both");
                    b.SetEasing("easeOut");
                },
                b.HtmlSpan(
                    b.HtmlSpan(b.Text("The ")),
                    b.HtmlSpan(
                        b =>
                        {
                            b.SetClass("bg-blue-50");
                        },
                        b.Text("full stack C#")),
                    b.HtmlSpan(b.Text("framework")))),
            b.SlAnimation(
                b =>
                {
                    b.SetName("fadeIn");
                    b.SetIterations("1");
                    b.SetDelay("1000");
                    b.SetDuration("500");
                    b.SetPlay();
                    b.SetFill("both");
                    b.SetEasing("easeOut");
                },
                b.HtmlDiv(
                    b.HtmlSpan(b.Text("that ")),
                    b.SlTooltip(
                        b =>
                        {
                            b.SetPlacementBottom();
                        },
                        b.HtmlSpan(
                            b =>
                            {
                                b.SetClass("underline decoration-dashed");
                            },
                            b.Text("packs")),
                        b.SlIcon(
                            b =>
                            {
                                b.SetName("box-seam");
                                b.SetSlot(SlTooltip.Slot.Content);
                            })),
                    b.HtmlSpan(b.Text(" everything.")))));
    }

    public static IHtmlNode HomepageContent(this HtmlBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col mt-20");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-col justify-center items-center gap-12 py-16");
                },
                b.TopSlogan(),
                b.GithubLink()),
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-col bg-blue-50");
                },
                b.HomeFeature("wrench", "Your tools", "Stay inside VS Code/Visual Studio, just add nugets and you're ready to go.", "No node.js, no npm required."),
                b.Separator(),
                b.HomeFeature("arrow-left-right", "Your types, everywhere", "The client-side code speaks C#. One definition, shared"),
                b.Separator(),
                b.HomeFeature("box", "Your version, always", "Resources are embedded, allowing you to upgrade & downgrade atomically", "This applies to CSS, JS, images & more"),
                b.Separator(),
                b.HomeFeature("scissors", "Your solution & nothing else", "You don't use it? Then it's not included. Each HTML page knows exactly what JS files it needs."),
                b.Separator(),
                b.HomeFeature("layers", "Your level", "Nugets build on top of each other, allowing you to work as high or low level as you need"),
                b.Separator(),
                b.HomeFeature("file-text", "Open source", "MIT licensed, just like the great projects we build upon")));
    }

    public static IHtmlNode Separator(this HtmlBuilder b)
    {
        return b.HtmlDiv(b => b.SetClass("mx-4 lg:mx-12 bg-gray-200 h-px"));
    }

    public static IHtmlNode HomeFeature(this HtmlBuilder b, string iconName, string title, string subtitle = null, string details = null)
    {
        var featureDetails = b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-col gap-4 text-gray-700 lg:flex-1 lg:basis-2/3 ");
            },
            b.HtmlSpan(
                b =>
                {
                    b.SetClass("text-large font-semibold");
                },
                b.Text(title)),
            b.Optional(
                !string.IsNullOrEmpty(subtitle),
                b => b.HtmlSpan(b => b.SetClass("text-sm"), b.Text(subtitle))),
            b.Optional(
                !string.IsNullOrEmpty(details),
                b => b.HtmlSpan(b => b.SetClass("text-sm"), b.Text(details))));

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-row items-center justify-center gap-8 lg:gap-24 bg-blue-50 px-4 py-12 lg:p-16");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-row items-center justify-end lg:flex-1 lg:basis-1/3 ");
                },
                b.HtmlDiv(
                    b =>
                    {
                        b.SetClass("flex flex-row items-center justify-center w-16 h-16 text-3xl rounded-full bg-blue-400 text-white");
                    },
                    b.SlIcon(
                        b =>
                        {
                            b.SetName(iconName);
                        }))),
            featureDetails);
    }
}
