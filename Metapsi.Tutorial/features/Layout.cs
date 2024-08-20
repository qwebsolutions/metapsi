using Metapsi.Hyperapp;
using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System;
using Metapsi.Html;

namespace Metapsi.Tutorial;

public static class Tutorial
{
    public static List<string> SmallBreakpoints = new List<string> { "sm", "md" };

    public static List<string> LargeBreakpoints = new List<string> { "lg", "xl", "2xl" };

    public static void InitCommonLayout<TPageModel>(this HtmlBuilder b, TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        StyleTag style = StyleTag.Create();
        style.AddSelector("a").AddProperty("--tw-prose-links", "var(--sl-color-blue-600)");

        b.AddModuleStylesheet();
        b.HeadAppend(
            style,
            b.HtmlTitle(b.Text(pageTitle)),
            pageContent,
            b.DrawerTreeMenu(model),
            b.Header(model, headerContent));
    }

    public static void InitLargeLayout<TPageModel>(this HtmlBuilder b, TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        b.BodyAppend(b.RedirectMismatchedBreakpointScript(LargeBreakpoints));
        b.AddModuleStylesheet();
        b.BodyAppend(pageContent);
        b.HeadAppend(b.HtmlTitle(b.Text(pageTitle)));
        b.BodyAppend(b.DrawerTreeMenu(model));
        b.BodyAppend(b.Header(model, headerContent));
    }

    public static void InitSmallLayout<TPageModel>(this HtmlBuilder b, TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        b.HeadAppend(b.HtmlTitle(b.Text(pageTitle)));
        b.HeadAppend(b.RedirectMismatchedBreakpointScript(SmallBreakpoints));
        StyleTag style = StyleTag.Create();
        style.AddSelector(".cm-editor").AddProperty("height", "100%");
        style.AddSelector(".mobile-drawer::part(close-button)").AddProperty("display", "none");
        b.HeadAppend(style);
        b.AddModuleStylesheet();
        b.BodyAppend(pageContent);
        b.BodyAppend(b.DrawerTreeMenu(model));
        b.BodyAppend(b.Header(model, headerContent));
    }
}