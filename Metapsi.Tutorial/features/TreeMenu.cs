using Metapsi.Hyperapp;
using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public interface IHasTreeMenu
{
    List<Route> Routes { get; set; }
    List<Doc> Docs { get; set; }
}

public static partial class Control
{
    private const string MenuDrawerId = "menuDrawerId";
    private const string BtnToggleTreeId = "btnToggleTree";

    public static IHtmlElement TreeMenu<TModel>(TModel model)
        where TModel : IHasTreeMenu
    {
        var tree = Component.Create(
            "sl-tree",
            new Tree() { Selection = TreeSelection.Leaf });

        FillRecursiveRoute(model, string.Empty, tree);

        return tree;
    }



    //public static Var<HyperNode> TreeMenu<TModel>(this BlockBuilder b, Var<TModel> model)
    //    where TModel : IHasTreeMenu
    //{
    //    var tree = b.Tree(b.Const(new Tree() { Selection = TreeSelection.Leaf }));
    //    b.Call(FillRecursiveRoute, model, b.Const(""), tree);
    //    return tree;
    //}

    private static void FillRecursiveRoute<TModel>(TModel model, string currentRouteCode, IHtmlElement currentNode)
        where TModel : IHasTreeMenu
    {
        var childrenRoutes = model.Routes.Where(x => x.ParentCode == currentRouteCode).OrderBy(x => x.OrderIndex);
        foreach (var childRoute in childrenRoutes)
        {
            string url = string.Empty;
            var doc = model.Docs.SingleOrDefault(x => x.Code == childRoute.DocCode);
            if (doc != null)
            {
                switch(doc.Type)
                {
                    case "tutorial":
                        url = WebServer.Url<Routes.Tutorial, string>(childRoute.DocCode);
                        break;
                    case "docs":
                        url = WebServer.Url<Routes.Docs, string>(childRoute.DocCode);
                        break;
                    default:
                        url = "/" + childRoute.DocCode;
                        break;

                }
            }

            IHtmlNode menuEntry =
                !string.IsNullOrEmpty(url) ?
                new HtmlTag("a").WithChild(HtmlText.CreateTextNode(childRoute.Title)).SetAttribute("href", url) :
                new HtmlText(childRoute.Title);



            var treeItem = currentNode.AddChild(Component.Create<TreeItem>(
                "sl-tree-item",
                new TreeItem(),
                menuEntry));

            FillRecursiveRoute(model, childRoute.Code, treeItem);
        }
    }

    //private static void FillRecursiveRoute<TModel>(BlockBuilder b, Var<TModel> model, Var<string> currentRouteCode, Var<HyperNode> currentNode)
    //    where TModel : IHasTreeMenu
    //{
    //    var childrenRoutes = b.Get(model, currentRouteCode, (model, current) => model.Routes.Where(x => x.ParentCode == current).OrderBy(x => x.OrderIndex).ToList());
    //    b.Foreach(childrenRoutes, (b, childRoute) =>
    //    {
    //        var itemText = b.TextNode(b.Get(childRoute, x => x.Title));
    //        var docCode = b.Get(childRoute, x => x.DocCode);

    //        var doc = b.Get(model, docCode, (model, docCode) => model.Docs.SingleOrDefault(x => x.Code == docCode));

    //        var url = b.If<string>(
    //            b.HasObject(doc),
    //            b =>
    //            {
    //                return b.Switch<string, string>(
    //                    b.Get(doc, x => x.Type),
    //                    b => b.Concat(b.Const("/"), docCode),
    //                    ("tutorial", (BlockBuilder b) => b.Url<Routes.Tutorial, string>(docCode)),
    //                    ("docs", (BlockBuilder b) => b.Url<Routes.Docs, string>(docCode)));
    //            },
    //            b => b.Const(string.Empty));

    //        var itemContent = b.If(
    //            b.HasValue(url),
    //            b =>
    //            {
    //                var link = b.Node("a", "", b => itemText);
    //                b.SetAttr(link, Html.href, url);
    //                return link;
    //            },
    //            b => itemText);

    //        var treeItem = b.Add(currentNode, b.TreeItem(b => itemContent));
    //        b.Call(FillRecursiveRoute, model, b.Get(childRoute, x => x.Code), treeItem);
    //    });
    //}

    public static IHtmlElement DrawerTreeMenu<TModel>(TModel model)
        where TModel: IHasTreeMenu
    {
        var drawer = Component.Create(
            "sl-drawer",
            new Drawer()
            {
                Placement = DrawerPlacement.Start
            },
            TreeMenu(model));
        drawer.SetAttribute("id", MenuDrawerId);

        drawer.AddChild(
            DivTag.CreateStyled(
                "flex flex-col gap-2",
                HtmlText.CreateTextNode("Metapsi"),
                HtmlText.Create("The fullstack C# framework").WithClass("text-sm"))
            .SetAttribute("slot", "label"));

        return drawer;
    }

    //public static Var<HyperNode> DrawerTreeMenu<TModel>(this BlockBuilder b, Var<TModel> model)
    //    where TModel : IHasTreeMenu
    //{
    //    var menuDrawerProps = b.NewObj<Drawer>();
    //    b.Set(menuDrawerProps, x => x.Placement, DrawerPlacement.Start);
    //    b.Set(menuDrawerProps, x => x.Open, b.Get(model, x => x.MenuIsExpanded));
    //    var drawer = b.Drawer(menuDrawerProps, b => b.TreeMenu(model));
    //    b.SetOnDrawerHide(drawer, b.MakeAction((BlockBuilder b, Var<TModel> model) =>
    //    {
    //        b.Set(model, x => x.MenuIsExpanded, false);
    //        return b.BroadcastModelUpdate(model);
    //    }));

    //    var drawerTitle =
    //        b.Add(
    //            drawer,
    //            b.Div(
    //                "flex flex-col gap-2",
    //                b => b.Text("Metapsi"),
    //                b => b.Text("The fullstack C# framework", "text-sm")));
    //    b.SetAttr(drawerTitle, DynamicProperty.String("slot"), "label");
    //    return drawer;
    //}

    //public static Var<HyperNode> Header<TModel>(this BlockBuilder b, Var<TModel> model, Func<BlockBuilder, Var<HyperNode>> headerContent)
    //    where TModel: IHasTreeMenu
    //{
    //    var header = b.Div(
    //        "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl",
    //        b =>
    //        {
    //            var showMenuButton = b.IconButton("list");
    //            b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TModel> model) =>
    //            {
    //                b.Set(model, x => x.MenuIsExpanded, true);
    //                return b.BroadcastModelUpdate(model);
    //            }));

    //            return showMenuButton;
    //        },
    //        headerContent);

    //    return header;
    //}

    //public static HtmlTag Header<TModel>(TModel model, IHtmlElement headerContent)
    //    where TModel: IHasTreeMenu
    //{
    //    var header = DivTag.CreateStyled(
    //        "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl",
    //        Tutorial.ClientSide(
    //            model,
    //            (b, model) =>
    //            {
    //                var showMenuButton = b.IconButton("list");
    //                b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TModel> model) =>
    //                {
    //                    b.Set(model, x => x.MenuIsExpanded, true);
    //                    return b.BroadcastModelUpdate(model);
    //                }));

    //                return showMenuButton;
    //            }),
    //        headerContent);

    //    return header;
    //}

    public static HtmlTag Header<TModel>(TModel model, IHtmlElement headerContent)
        where TModel : IHasTreeMenu
    {
        var onClickScript = new HtmlTag("script").SetAttribute("type", "module");
        var moduleBuilder = new ModuleBuilder();
        var toggleMenuDrawer = moduleBuilder.Define("toggleMenuDrawer", (b) =>
        {
            var treeMenu = b.GetElementById(b.Const(MenuDrawerId));
            var isOpen = b.GetAttribute<bool>(treeMenu, b.Const("open"));
            b.SetAttribute(treeMenu, b.Const("open"), b.Not(isOpen));
        });

        moduleBuilder.Define("attachToggleClick", (b) =>
        {
            var btnToggleTree = b.GetElementById(b.Const(BtnToggleTreeId));
            b.AddEventListener(btnToggleTree, b.Const("click"), toggleMenuDrawer);
        });     

        var scriptContent = Metapsi.JavaScript.PrettyBuilder.Generate(moduleBuilder.Module, "0.1");

        scriptContent += "attachToggleClick()";

        onClickScript.AddText(scriptContent);

        var header = DivTag.CreateStyled(
            "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl",
            onClickScript,
            Component.Create(
                "sl-icon-button",
                new IconButton() { Name = "list" })
            .SetAttribute("id", BtnToggleTreeId)
            //.SetAttribute("onclick", $"(()=>{{ var tree = getElementById('{TreeMenuId}'); console.log(tree.getAttribute('open')); }})()")

            );


        

        return header;
    }
}

public static class Tutorial
{
    public static DocumentTag Layout<TPageModel>(
        TPageModel model, 
        string pageTitle,
        IHtmlElement headerContent,
        IHtmlElement pageContent)
        where TPageModel : IHasTreeMenu

    {
        var document = DocumentTag.Create(pageTitle);
        document.Head.AddModuleStylesheet();

        document.Body.AddChild(pageContent);

        //document.Body.AddChild(Tutorial.ClientSide(model, (b, model) => b.DrawerTreeMenu(model)));
        //document.Body.AddChild(Control.Header(model, headerContent));
        document.Body.AddChild(Control.DrawerTreeMenu(model));
        document.Body.AddChild(Control.Header(model, headerContent));

        document.AttachComponents();

        return document;
    }

    public static HtmlTag ClientSide<TDataModel>(
        TDataModel model,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperNode>> render = null,
        System.Func<BlockBuilder, Var<TDataModel>, Var<HyperType.StateWithEffects>> init = null)
    {
        return Metapsi.Hyperapp.ClientSide.Create(model, render, init, WaitClientSideShoelaceTags);
    }

    private static void WaitClientSideShoelaceTags(DocumentTag document, IHtmlElement parentElement, Module module)
    {
        // sl-tooltip crashes for some reason
        var shoelaceTags = module.Consts.Where(x => x.Value is ShoelaceTag).Select(x => (x.Value as ShoelaceTag).tag).Where(x => x != "sl-tooltip").ToList();

        var head = document.Head;
        //var style = head.AddChild(new HtmlTag("style"));
        //style.AddChild(new HtmlText() { Text = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }" });

        var body = document.Body;

        var workaroundDiv = body.AddChild(new HtmlTag() { Tag = "div" });
        workaroundDiv.SetAttribute("class", "hidden");

        var slAwaitScript = document.Head.Children.OfType<SlAwaitScript>().SingleOrDefault();
        if (slAwaitScript == null)
        {
            slAwaitScript = document.Head.AddChild(new SlAwaitScript());
        }

        foreach (var shoelaceTag in shoelaceTags)
        {
            workaroundDiv.AddChild(new HtmlTag(shoelaceTag));
            slAwaitScript.SlTags.Add(shoelaceTag);
        }

        document.StartHidden();

        document.Head.AddChild(new ExternalScriptTag("https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/shoelace-autoloader.js", "module"));
        document.Head.AddChild(new LinkTag("stylesheet", "https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.6.0/cdn/themes/light.css"));
    }
}

public static class TreeMenuExtensions
{
    public static async Task LoadRoutes(this IHasTreeMenu model)
    {
        var dbFullPath = await Arguments.FullDbPath();
        model.Routes.AddRange(await Sqlite.Db.Entities<Route>(dbFullPath));
        model.Docs.AddRange(await Sqlite.Db.Entities<Doc>(dbFullPath));
    }
}