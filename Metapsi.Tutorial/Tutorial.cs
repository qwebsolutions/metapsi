using Metapsi.Hyperapp;
using System.Collections.Generic;
using Metapsi.Ui;
using System;
using Metapsi.Syntax;
using Metapsi.Dom;
using Metapsi.Shoelace;

namespace Metapsi.Tutorial;



public interface IHasPrevNext
{
    MenuEntry Prev { get; set; }
    MenuEntry Next { get; set; }
}

public class TutorialModel : IApiSupportState, IHasTreeMenu
{
    public List<MenuEntry> Menu { get; set; } = new();
    public MenuEntry CurrentEntry { get; set; } = new();
    public string MarkdownContent { get; set; }
    public ApiSupport ApiSupport { get; set; } = new();
}

public class TutorialPage : HtmlPage<TutorialModel>
{
    private IHtmlElement DocsPanel(TutorialModel dataModel)
    {
        var docsPanel = DivTag.CreateStyled(
            "flex overflow-y-auto w-full h-full p-12",
            DivTag.CreateStyled(
                "prose mx-auto",
                Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()),
                DivTag.CreateStyled(
                    "py-8",
                    new TutorialArticleNode()
                    {
                        Markdown = dataModel.MarkdownContent
                    }),
                Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()),
                DivTag.CreateStyled("h-12") // <- added because scrollbar does not take into consideration padding at end
                ));

        docsPanel.SetAttribute("slot", "start");

        return docsPanel;
    }

    private IHtmlElement SandboxPanel(TutorialModel dataModel)
    {
        return DivTag.CreateStyled(
            "w-full h-full overflow-y-auto",
            Control.SandboxApp()).SetAttribute("slot", "end");
    }

    public override IHtmlNode GetHtmlTree(TutorialModel dataModel)
    {
        var page = Tutorial.Layout(
            dataModel,
            dataModel.CurrentEntry.Title,
            HtmlText.CreateTextNode(dataModel.CurrentEntry.Title),
            DivTag.CreateStyled(
                "fixed top-20 left-0 bottom-0 right-0",
                Component.Create(
                    "sl-split-panel",
                    new SplitPanel()
                    {
                        Position = 40,
                        Primary = PrimaryPanel.End
                    },
                    DocsPanel(dataModel),
                    SandboxPanel(dataModel)).SetAttribute("class", " w-full h-full")
                ));

        page.Head.AddStylesheet("prism.css");
        page.Head.AddChild(new ExternalScriptTag("/prism.js", ""));

        page.GetSlAwaitWhenDefinedScript().ThenActions.Add(b =>
        {
            //b.SlAwaitWhenUpdated(b.Const(Control.TabPanelName(x => x.CSharpModel)), (b =>
            //{
            //    b.DispatchEvent(b.Const("ExploreSample"), b.Const(new CodeSample()));
            //}));
        });

        return page;
    }
}