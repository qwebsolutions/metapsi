﻿using Metapsi.Hyperapp;
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

    public static HtmlTag Header<TModel>(TModel model, IHtmlElement headerContent)
        where TModel : IHasTreeMenu
    {
        var onClickScript = new InlineModuleScript();

        var toggleMenuDrawer = onClickScript.ModuleBuilder.Define("toggleMenuDrawer", (b) =>
        {
            var treeMenu = b.GetElementById(b.Const(MenuDrawerId));
            var isOpen = b.GetAttribute<bool>(treeMenu, b.Const("open"));
            b.SetAttribute(treeMenu, b.Const("open"), b.Not(isOpen));
        });

        onClickScript.CallAction(onClickScript.ModuleBuilder.Define("attachToggleClick", (b) =>
        {
            var btnToggleTree = b.GetElementById(b.Const(BtnToggleTreeId));
            b.AddEventListener(btnToggleTree, b.Const("click"), toggleMenuDrawer);
        }));

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