using Metapsi.Hyperapp;
using System.Collections.Generic;
using Metapsi.Ui;
using System;
using Metapsi.Syntax;
using Metapsi.Dom;

namespace Metapsi.Tutorial;

public class TutorialModel : IApiSupportState, IHasTreeMenu
{
    public List<MenuEntry> Menu { get; set; } = new();
    public MenuEntry CurrentEntry { get; set; } = new();
    public string MarkdownContent { get; set; }
    public ApiSupport ApiSupport { get; set; } = new();
}

public class TutorialPage : HtmlPage<TutorialModel>
{
    public override IHtmlNode GetHtmlTree(TutorialModel dataModel)
    {
        var page = Tutorial.Layout(
            dataModel,
            dataModel.CurrentEntry.Title,
            HtmlText.CreateTextNode(dataModel.CurrentEntry.Title),
            DivTag.CreateStyled(
                "p-12",
                DivTag.CreateStyled(
                    "flex flex-row gap-8 w-full",
                    DivTag.CreateStyled(
                        "flex flex-col items-center w-[60vw]",
                        DivTag.CreateStyled(
                            "flex flex-col max-w-[60vw]",
                            DivTag.CreateStyled(
                                "prose",
                                new TutorialArticleNode()
                                {
                                    Markdown = dataModel.MarkdownContent
                                }
                                )
                            )
                        ),
                    DivTag.CreateStyled(
                        "flex flex-col fixed w-[30vw] top-24 right-2 bottom-2 overflow-y-auto",
                        Control.SandboxApp()
                        )
                    )
                )
            );

        page.Head.AddStylesheet("prism.css");
        page.Head.AddChild(new ExternalScriptTag("/prism.js", ""));

        page.Body.AddJs(b =>
        {
            b.CallExternal("Metapsi.Tutorial", "HighlightWhenDefined");
        });

        return page;
    }
}