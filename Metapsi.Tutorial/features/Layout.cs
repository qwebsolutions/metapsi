using Metapsi.Hyperapp;
using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;

namespace Metapsi.Tutorial;

public static class Tutorial
{
    public static DocumentTag Layout<TPageModel>(
        TPageModel model, 
        string pageTitle,
        IHtmlNode headerContent,
        IHtmlNode pageContent)
        where TPageModel : IHasTreeMenu

    {
        var style = StyleTag.Create();
        style.AddSelector("a").AddProperty("--tw-prose-links", "var(--sl-color-blue-600)");


        var document = DocumentTag.Create(pageTitle);
        document.Head.AddModuleStylesheet();
        document.Head.AddChild(style);
        document.Body.AddChild(DivTag.CreateStyled("flex flex-col w-full h-full pt-24 ", pageContent));
        document.Body.AddChild(Control.DrawerTreeMenu(model));
        document.Body.AddChild(Control.Header(model, headerContent));
        //document.Body.AddChild(new ExternalScriptTag("/codeflask.min.js", ""));

        document.AttachComponents();

        return document;
    }

    public class TutorialHyperAppNode<TDataModel> : HyperAppNode<TDataModel>
    {
        public override void Attach(DocumentTag document, IHtmlElement parentNode)
        {
            base.Attach(document, parentNode);
            WaitClientSideShoelaceTags(document, parentNode, this.ModuleBuilder.Module);
        }
    }

    public static HtmlTag ClientSide<TDataModel>(
        TDataModel model,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render = null,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
    {
        var mountDivId = $"id_{System.Guid.NewGuid()}";
        var appContainer = new DivTag().SetAttribute("id", mountDivId);

        var hyperApp = new TutorialHyperAppNode<TDataModel>()
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
        // sl-tooltip crashes for some reason
        var shoelaceTags = module.Consts.Where(x => x.Value is ShoelaceTag).Select(x => (x.Value as ShoelaceTag).tag).Where(x => x != "sl-tooltip").ToList();

        var head = document.Head;
        var body = document.Body;

        var workaroundDiv = body.AddChild(new HtmlTag() { Tag = "div" });
        workaroundDiv.SetAttribute("class", "hidden");

        var slAwaitScript = document.GetSlAwaitWhenDefinedScript();

        foreach (var shoelaceTag in shoelaceTags)
        {
            workaroundDiv.AddChild(new HtmlTag(shoelaceTag));
            slAwaitScript.SlTags.Add(shoelaceTag);
        }

        document.StartHidden();

        document.AddShoelace();
    }
}
