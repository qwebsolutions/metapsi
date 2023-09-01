using Markdig;
using Metapsi.Ui;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class MarkdownPage
{

}

public class MarkdownHandler : Http.Get<Metapsi.Tutorial.Routes.MTutorial, string>
{
    public override async Task<IResult> OnGet(CommandContext commandContext, HttpContext httpContext, string pageName)
    {
        return Page.Result(new MarkdownPage());
    }
}

public class MarkdownRenderer : MarkdownHtmlPage<MarkdownPage>
{
    public override IHtmlNode GetHtml(MarkdownPage dataModel)
    {
        return Template.BlankPage(
            head =>
            {
                head.AddChild(new ScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
                head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));

                head.AddChild(
                    StyleTag.Create(
                        CssSelector.Create("body").
                        AddProperty("font-family", "var(--sl-font-sans)")
                        .AddProperty("color", "var(--sl-color-gray-800)"),

                        CssSelector.Create("strong")
                        .AddProperty("font-weight", "var(--sl-font-weight-bold)")));

                // + Hyperapp node


            },
            buildBody: (body) =>
            {
                body.AddChild(new MarkdownNode()
                {
                    Markdown = "### Heading level 3 \nI just love **bold text**."
                });
            });
    }
}

public class MarkdownNode : IHtmlNode
{
    public string Markdown { get; set; } = string.Empty;
}

public abstract class MarkdownHtmlPage<TDataModel> : IPageTemplate<TDataModel>
{
    public abstract IHtmlNode GetHtml(TDataModel dataModel);

    public string Render(TDataModel model)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("<!DOCTYPE html>");
        BuildHtml(builder, GetHtml(model));
        var html = builder.ToString();
        return html;
    }

    private void BuildHtml(StringBuilder builder, IHtmlNode htmlNode)
    {
        switch (htmlNode)
        {
            case HtmlTag htmlTag:
                HtmlWriters.HtmlTag(builder, htmlTag, BuildHtml);
                break;
            case HtmlText textNode:
                HtmlWriters.HtmlText(builder, textNode);
                break;
            case MarkdownNode markdownNode:
                {
                    builder.Append(Markdown.ToHtml(markdownNode.Markdown));
                }
                break;
        }
    }
}