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
                                Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()),
                                new TutorialArticleNode()
                                {
                                    Markdown = dataModel.MarkdownContent
                                },
                                Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry())
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

        page.GetSlAwaitWhenDefinedScript().ThenActions.Add(b =>
        {
            b.DispatchEvent(b.Const("ExploreSample"), b.Const(new CodeSample()));
        });

        //page.Head.AddJs(b =>
        //{
        //    b.Log("adding sl await event listener");
        //    b.AddEventListener(b.Window(), b.Const("sl-await-loaded"), b.DefineAction(b =>
        //    {
        //        var tabIds = b.Const(new List<string>()
        //        {
        //            Control.TabPanelName(x => x.CSharpModel),
        //            Control.TabPanelName(x => x.JsonModel),
        //            Control.TabPanelName(x => x.CSharpCode)
        //        });

        //        b.CallExternal("Metapsi.Tutorial", "OnUpdateComplete", tabIds, b.DefineAction(b =>
        //        {
        //            b.DispatchEvent(b.Const("ExploreSample"), b.Const(new CodeSample()));
        //        }));
        //    }));

        //    b.CallExternal("Metapsi.Tutorial", "HighlightWhenDefined");
        //});

        return page;
    }
}