using Metapsi.Hyperapp;
using System.Collections.Generic;
using Metapsi.Ui;
using System;
using Metapsi.Syntax;
using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Html;
using System.IO;

namespace Metapsi.Tutorial;



public interface IHasPrevNext
{
    MenuEntry Prev { get; set; }
    MenuEntry Next { get; set; }
}

public class TutorialModel : IHasTreeMenu, IServerSideBreakpoint
{
    public List<MenuEntry> Menu { get; set; } = new();
    public MenuEntry CurrentEntry { get; set; } = new();
    public string MarkdownContent { get; set; }

    public string AssumedBreakpoint { get; set; }
}
public static class TutorialPage
{
    private static IHtmlNode LargeDocsPanel(this HtmlBuilder b, TutorialModel dataModel)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex overflow-y-auto w-full h-full p-12 prose-a:text-blue-600");
                b.SetSlot("start");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("prose mx-auto");
                },
                b.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()),
                b.HtmlDiv(
                    b =>
                    {
                        b.SetClass("py-8");
                    },
                    new TutorialArticleNode()
                    {
                        Markdown = dataModel.MarkdownContent
                    }),
                b.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry())));
    }

    private static IHtmlNode SmallDocsPanel(this HtmlBuilder b, TutorialModel dataModel)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("w-full overflow-y-auto h-full px-4 py-12 prose-a:text-blue-500");
                b.SetSlot("start");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("prose prose-sm mx-auto");
                },
                b.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry()),
                b.HtmlDiv(
                    b =>
                    {
                        b.SetClass("py-8");
                    },
                    new TutorialArticleNode() { Markdown = dataModel.MarkdownContent }),
                b.NavigatorArrows(dataModel.GetPreviousMenuEntry(), dataModel.GetNextMenuEntry())));
    }

    private static IHtmlNode DesktopSandbox(this HtmlBuilder b)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("w-full h-full overflow-y-auto");
                b.SetSlot("end");
            },
            b.SandboxApp(Editor.Monaco));
    }

    public static IHtmlNode MobileExpandCodeButton(this HtmlBuilder b)
    {
        return b.HtmlButton(
            b =>
            {
                b.SetClass("shows rounded bg-gray-100 w-10 h-10 flex flex-row items-center justify-center md:hidden");
                b.SetStyle("opacity: 1");
                b.SetId("MobileExpandCodeButton");
            },
            b.SlIcon(
                b =>
                {
                    b.SetId("ToggleSandboxIcon");
                    b.SetName("braces");
                }),
            b.HtmlScriptModule(delegate (SyntaxBuilder b)
            {
                Var<DomElement> elementById7 = b.GetElementById(b.Const("MobileExpandCodeButton"));
                b.AddEventListener(elementById7, b.Const("click"), b.Def(delegate (SyntaxBuilder b)
                {
                    Var<DomElement> elementById8 = b.GetElementById(b.Const("MobileSandbox"));
                    Var<bool> dynamic = b.GetDynamic(elementById8.As<DynamicObject>(), DynamicProperty.Bool("open"));
                    b.SetDynamic(elementById8.As<DynamicObject>(), DynamicProperty.Bool("open"), b.Not(dynamic));
                }));
            }),
            b.HtmlScriptModule(delegate (SyntaxBuilder b)
            {
                b.AddEventListener(b.Window(), b.Const("ExploreSample"), b.Def(delegate (SyntaxBuilder b)
                {
                    Var<DomElement> elementById6 = b.GetElementById(b.Const("MobileSandbox"));
                    b.GetAttribute<bool>(elementById6, b.Const("open"));
                    b.SetAttribute(elementById6, b.Const("open"), b.Const(constant: true));
                }));
            }),
            b.HtmlScriptModule(delegate (SyntaxBuilder b)
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
            }));
    }

    public static IHtmlNode MobileSandbox(this HtmlBuilder b)
    {
        return b.SlDrawer(
            b =>
            {
                b.SetPlacementEnd();
                b.SetContained();
                b.SetClass("relative mobile-drawer");
                b.SetId("MobileSandbox");
            },
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("w-full h-full");
                },
                b.SandboxApp(Editor.CodeMirror)),
            b.HtmlSpan(
                b =>
                {
                    b.SetSlot(SlDrawer.Slot.Label);
                },
                b.Text("Metapsi sandbox")));
    }

    public static void Render(this HtmlBuilder b, TutorialModel dataModel)
    {
        b.Document.UseWebComponentsFadeIn();
        StaticFiles.AddAll(typeof(TutorialPage).Assembly);
        b.AddModuleStylesheet();
        b.AddStylesheet("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.14.0/cdn/themes/light.css");
        b.AddScriptModule("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.14.0/cdn/shoelace-autoloader.js");
        b.WithBreakpointProbingPage(dataModel, delegate (TutorialModel dataModel)
        {
            b.AddStylesheet("prism.css");
            b.AddScript("/prism.js");

            if (!Tutorial.LargeBreakpoints.Contains(dataModel.AssumedBreakpoint))
            {
                var basePath = $"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/";

                b.HeadAppend(
                    b.HtmlScript(
                        b =>
                        {
                            b.SetTypeModule();
                        },
                        b.Text($"import {{ setBasePath }} from 'https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/utilities/base-path.js';\r\n  setBasePath('{basePath}');\r\n")));

                b.HeadAppend(
                    b.HtmlScript(
                        b =>
                        {
                            b.SetType("importmap");
                        },
                        b.Text("{\r\n\t\t\"imports\": {\r\n\t\t\t\"codemirror/\": \"https://deno.land/x/codemirror_esm@v6.0.1/esm/\"\r\n\t\t}\r\n\t}")));

                b.InitSmallLayout(
                    dataModel,
                    dataModel.CurrentEntry.Title,
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass("w-full flex flex-row justify-between items-center");
                        },
                        b.Text(dataModel.CurrentEntry.Title),
                        b.MobileExpandCodeButton()),
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass("fixed top-20 left-0 bottom-0 right-0");
                        },
                        b.HtmlDiv(
                            b =>
                            {
                                b.SetClass("h-full");
                            },
                            b.MobileSandbox(),
                            b.SmallDocsPanel(dataModel))));
            }
            else
            {
                b.InitLargeLayout(
                    dataModel,
                    dataModel.CurrentEntry.Title,
                    b.Text(dataModel.CurrentEntry.Title),
                    b.HtmlDiv(
                        b =>
                        {
                            b.SetClass("fixed top-20 left-0 bottom-0 right-0");
                        },
                        b.SlSplitPanel(
                            b =>
                            {
                                b.SetPosition("40");
                                b.SetPrimaryEnd();
                                b.SetClass("w-full h-full");
                            },
                            b.LargeDocsPanel(dataModel),
                            b.DesktopSandbox())));
            }
        });
    }
}
