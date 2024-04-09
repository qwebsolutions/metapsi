using Metapsi.Hyperapp;
using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System;

namespace Metapsi.Tutorial;

public static class Tutorial
{
    public static List<string> SmallBreakpoints = new List<string> { "sm", "md" };

    public static List<string> LargeBreakpoints = new List<string> { "lg", "xl", "2xl" };

    public static void InitCommonLayout<TPageModel>(DocumentTag documentTag, TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        StyleTag style = StyleTag.Create();
        style.AddSelector("a").AddProperty("--tw-prose-links", "var(--sl-color-blue-600)");
        documentTag.Head.AddModuleStylesheet();
        documentTag.Head.AddChild(style);
        documentTag.Head.AddChild(new HtmlTag("title").WithChild(new HtmlText(pageTitle)));
        documentTag.Body.AddChild(pageContent);
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.DrawerTreeMenu(model));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.Header(model, headerContent));
    }

    public static void InitLargeLayout<TPageModel>(DocumentTag documentTag, TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        documentTag.AddRedirectMismatchedBreakpoint(LargeBreakpoints);
        documentTag.Head.AddModuleStylesheet();
        documentTag.Body.AddChild(pageContent);
        documentTag.Head.AddChild(new HtmlTag("title").WithChild(new HtmlText(pageTitle)));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.DrawerTreeMenu(model));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.Header(model, headerContent));
    }

    public static void InitSmallLayout<TPageModel>(DocumentTag documentTag, TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        documentTag.AddChild(new HtmlTag("title").WithChild(new HtmlText() { Text = pageTitle }));
        documentTag.AddRedirectMismatchedBreakpoint(SmallBreakpoints);
        StyleTag style = StyleTag.Create();
        style.AddSelector(".cm-editor").AddProperty("height", "100%");
        style.AddSelector(".mobile-drawer::part(close-button)").AddProperty("display", "none");
        documentTag.Head.AddChild(style);
        documentTag.Head.AddModuleStylesheet();
        documentTag.Body.AddChild(pageContent);
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.DrawerTreeMenu(model));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.Header(model, headerContent));
    }
}