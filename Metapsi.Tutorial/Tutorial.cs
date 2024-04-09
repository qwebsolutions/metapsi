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

public class TutorialModel : IApiSupportState, IHasTreeMenu, IServerSideBreakpoint
{
    public List<MenuEntry> Menu { get; set; } = new();
    public MenuEntry CurrentEntry { get; set; } = new();
    public string MarkdownContent { get; set; }
    public ApiSupport ApiSupport { get; set; } = new();

    public string AssumedBreakpoint { get; set; }
}
public class TutorialPage : HtmlPage<TutorialModel>
{
    private IHtmlElement LargeDocsPanel(TutorialModel dataModel)
    {
        DivTag divTag = DivTag.CreateStyled("flex overflow-y-auto w-full h-full p-12 prose-a:text-blue-600", DivTag.CreateStyled("prose mx-auto", Metapsi.Tutorial.Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()), DivTag.CreateStyled("py-8", new TutorialArticleNode
        {
            Markdown = dataModel.MarkdownContent
        }), Metapsi.Tutorial.Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()), DivTag.CreateStyled("h-12")));
        divTag.SetAttribute("slot", "start");
        return divTag;
    }

    private IHtmlElement SmallDocsPanel(TutorialModel dataModel)
    {
        DivTag divTag = DivTag.CreateStyled("w-full overflow-y-auto h-full px-4 py-12 prose-a:text-blue-500", DivTag.CreateStyled("prose prose-sm mx-auto", Metapsi.Tutorial.Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()), DivTag.CreateStyled("py-8", new TutorialArticleNode
        {
            Markdown = dataModel.MarkdownContent
        }), Metapsi.Tutorial.Control.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()), DivTag.CreateStyled("h-12")));
        divTag.SetAttribute("slot", "start");
        return divTag;
    }

    private IHtmlElement DesktopSandbox()
    {
        return DivTag.CreateStyled("w-full h-full overflow-y-auto", Metapsi.Tutorial.Control.SandboxApp(Editor.Monaco)).SetAttribute("slot", "end");
    }

    public IHtmlElement MobileExpandCodeButton()
    {
        HtmlTag htmlTag = new HtmlTag("button");
        htmlTag.SetAttribute("class", "shows rounded bg-gray-100 w-10 h-10 flex flex-row items-center justify-center md:hidden");
        htmlTag.WithStyle("opacity", "1");
        htmlTag.SetAttribute("id", "MobileExpandCodeButton");
        htmlTag.AddChild(new SlIcon() { name = "braces" }).SetAttribute("id", "ToggleSandboxIcon");
        htmlTag.AddJs(delegate (SyntaxBuilder b)
        {
            Var<DomElement> elementById7 = b.GetElementById(b.Const("MobileExpandCodeButton"));
            b.AddEventListener(elementById7, b.Const("click"), b.Def(delegate (SyntaxBuilder b)
            {
                Var<DomElement> elementById8 = b.GetElementById(b.Const("MobileSandbox"));
                Var<bool> dynamic = b.GetDynamic(elementById8.As<DynamicObject>(), DynamicProperty.Bool("open"));
                b.SetDynamic(elementById8.As<DynamicObject>(), DynamicProperty.Bool("open"), b.Not(dynamic));
            }));
        });
        htmlTag.AddJs(delegate (SyntaxBuilder b)
        {
            b.AddEventListener(b.Window(), b.Const("ExploreSample"), b.Def(delegate (SyntaxBuilder b)
            {
                Var<DomElement> elementById6 = b.GetElementById(b.Const("MobileSandbox"));
                b.GetAttribute<bool>(elementById6, b.Const("open"));
                b.SetAttribute(elementById6, b.Const("open"), b.Const(constant: true));
            }));
        });
        htmlTag.AddJs(delegate (SyntaxBuilder b)
        {
            Var<DomElement> elementById = b.GetElementById(b.Const("MobileSandbox"));
            b.AddEventListener(elementById, b.Const("sl-after-show"), b.Def(delegate (SyntaxBuilder b)
            {
                Var<DomElement> elementById4 = b.GetElementById(b.Const("MobileExpandCodeButton"));
                b.SetStyle(elementById4, b.Const("opacity"), b.Const("0.5"));
                Var<DomElement> elementById5 = b.GetElementById(b.Const("ToggleSandboxIcon"));
                b.SetDynamic(elementById5.As<DynamicObject>(), DynamicProperty.String("name"), b.Const("x-lg"));
            }));
            b.AddEventListener(elementById, b.Const("sl-after-hide"), b.Def(delegate (SyntaxBuilder b)
            {
                Var<DomElement> elementById2 = b.GetElementById(b.Const("MobileExpandCodeButton"));
                b.SetStyle(elementById2, b.Const("opacity"), b.Const("1"));
                Var<DomElement> elementById3 = b.GetElementById(b.Const("ToggleSandboxIcon"));
                b.SetDynamic(elementById3.As<DynamicObject>(), DynamicProperty.String("name"), b.Const("braces"));
            }));
        });
        return htmlTag;
    }

    public IHtmlElement MobileSandbox()
    {
        var component = new SlDrawer()
        {
            placement = "end"
        }
        .WithChild(DivTag.CreateStyled("w-full h-full", Metapsi.Tutorial.Control.SandboxApp(Editor.CodeMirror)));
        component.SetAttribute("contained", "true");
        component.SetAttribute("class", "relative mobile-drawer");
        component.SetAttribute("id", "MobileSandbox");
        component.AddChild(HtmlText.Create("Metapsi sandbox").SetAttribute("slot", "label"));
        return component;
    }

    public override void FillHtml(TutorialModel dataModel, DocumentTag document)
    {
        document.UseWebComponentsFadeIn();
        document.WithBreakpointProbingPage(dataModel, delegate (TutorialModel dataModel)
        {
            if (!Tutorial.LargeBreakpoints.Contains(dataModel.AssumedBreakpoint))
            {
                // TODO: Investigate why I need to add this here, as it's added by the component as well
                document.Head.AddChild(SlComponent.BasePathScript($"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/"));

                Tutorial.InitSmallLayout(document, dataModel, dataModel.CurrentEntry.Title, DivTag.CreateStyled("w-full flex flex-row justify-between items-center", HtmlText.CreateTextNode(dataModel.CurrentEntry.Title), MobileExpandCodeButton()), DivTag.CreateStyled("fixed top-20 left-0 bottom-0 right-0", DivTag.CreateStyled("h-full", MobileSandbox(), SmallDocsPanel(dataModel))));
                document.Head.Children.Insert(0, new HtmlTag("script").SetAttribute("type", "importmap").WithChild(new HtmlText
                {
                    Text = "{\r\n\t\t\"imports\": {\r\n\t\t\t\"codemirror/\": \"https://deno.land/x/codemirror_esm@v6.0.1/esm/\"\r\n\t\t}\r\n\t}"
                }));
                document.Head.AddStylesheet("prism.css");
                document.Head.AddChild(new ExternalScriptTag("/prism.js", ""));
                return;
            }
            else
            Tutorial.InitLargeLayout(
                document, 
                dataModel, 
                dataModel.CurrentEntry.Title, 
                HtmlText.CreateTextNode(
                    dataModel.CurrentEntry.Title), 
                DivTag.CreateStyled(
                    "fixed top-20 left-0 bottom-0 right-0", 
                    new SlSplitPanel()
                    {
                        position = 40,
                        primary = "end"
                    }.WithChild(LargeDocsPanel(dataModel))
                    .WithChild(DesktopSandbox()).SetAttribute("class", " w-full h-full")));
            document.Head.AddStylesheet("prism.css");
            document.Head.AddChild(new ExternalScriptTag("/prism.js", ""));
        });
    }
}
