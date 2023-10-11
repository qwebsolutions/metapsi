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
    public class TutorialHyperAppNode<TDataModel> : HyperAppNode<TDataModel>
    {
        public override void Attach(DocumentTag document, IHtmlElement parentNode)
        {
            base.Attach(document, parentNode);
            WaitClientSideShoelaceTags(document, parentNode, base.ModuleBuilder.Module);
        }
    }

    public static List<string> SmallBreakpoints = new List<string> { "sm", "md" };

    public static List<string> LargeBreakpoints = new List<string> { "lg", "xl", "2xl" };

    public static DocumentTag CommonLayout<TPageModel>(TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        StyleTag style = StyleTag.Create();
        style.AddSelector("a").AddProperty("--tw-prose-links", "var(--sl-color-blue-600)");
        DocumentTag documentTag = DocumentTag.Create(pageTitle);
        documentTag.Head.AddModuleStylesheet();
        documentTag.Head.AddChild(style);
        documentTag.Body.AddChild(pageContent);
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.DrawerTreeMenu(model));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.Header(model, headerContent));
        documentTag.AttachComponents();
        return documentTag;
    }

    public static DocumentTag LargeLayout<TPageModel>(TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        DocumentTag documentTag = DocumentTag.Create(pageTitle);
        documentTag.AddRedirectMismatchedBreakpoint(LargeBreakpoints);
        documentTag.Head.AddModuleStylesheet();
        documentTag.Body.AddChild(pageContent);
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.DrawerTreeMenu(model));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.Header(model, headerContent));
        documentTag.AttachComponents();
        return documentTag;
    }

    public static DocumentTag SmallLayout<TPageModel>(TPageModel model, string pageTitle, IHtmlNode headerContent, IHtmlNode pageContent) where TPageModel : IHasTreeMenu
    {
        DocumentTag documentTag = DocumentTag.Create(pageTitle);
        documentTag.AddRedirectMismatchedBreakpoint(SmallBreakpoints);
        StyleTag style = StyleTag.Create();
        style.AddSelector(".cm-editor").AddProperty("height", "100%");
        style.AddSelector(".mobile-drawer::part(close-button)").AddProperty("display", "none");
        documentTag.Head.AddChild(style);
        documentTag.Head.AddModuleStylesheet();
        documentTag.Body.AddChild(pageContent);
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.DrawerTreeMenu(model));
        documentTag.Body.AddChild(Metapsi.Tutorial.Control.Header(model, headerContent));
        documentTag.AttachComponents();
        return documentTag;
    }

    public static HtmlTag ClientSide<TDataModel>(TDataModel model, Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render = null, Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
    {
        DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
        defaultInterpolatedStringHandler.AppendLiteral("id_");
        defaultInterpolatedStringHandler.AppendFormatted(Guid.NewGuid());
        string mountDivId = defaultInterpolatedStringHandler.ToStringAndClear();
        DivTag appContainer = new DivTag().SetAttribute("id", mountDivId);
        TutorialHyperAppNode<TDataModel> hyperApp = new TutorialHyperAppNode<TDataModel>
        {
            Model = model,
            Init = init,
            Render = render,
            TakeoverNode = appContainer
        };
        appContainer.AddChild(hyperApp);
        return appContainer;
    }

    private static void WaitClientSideShoelaceTags(DocumentTag document, IHtmlElement parentElement, Module module)
    {
        List<string> list = (from x in module.Consts
                             where x.Value is ShoelaceTag
                             select (x.Value as ShoelaceTag).tag into x
                             where x != "sl-tooltip"
                             select x).ToList();
        _ = document.Head;
        HtmlTag workaroundDiv = document.Body.AddChild(new HtmlTag
        {
            Tag = "div"
        });
        workaroundDiv.SetAttribute("class", "hidden");
        SlAwaitWhenDefinedScript slAwaitScript = document.GetSlAwaitWhenDefinedScript();
        foreach (string shoelaceTag in list)
        {
            workaroundDiv.AddChild(new HtmlTag(shoelaceTag));
            slAwaitScript.SlTags.Add(shoelaceTag);
        }
        document.StartHidden();
        document.AddShoelace();
    }
}