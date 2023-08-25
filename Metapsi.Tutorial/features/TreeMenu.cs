using Metapsi.Hyperapp;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public interface IHasTreeMenu
{
    List<Route> Routes { get; set; }
    List<Doc> Docs { get; set; }
    bool MenuIsExpanded { get; set; }
}

public static partial class Control
{
    public static Var<HyperNode> TreeMenu<TModel>(this BlockBuilder b, Var<TModel> model)
        where TModel : IHasTreeMenu
    {
        var tree = b.Tree(b.Const(new Tree() { Selection = TreeSelection.Leaf }));
        b.Call(FillRecursiveRoute, model, b.Const(""), tree);
        return tree;
    }

    private static void FillRecursiveRoute<TModel>(BlockBuilder b, Var<TModel> model, Var<string> currentRouteCode, Var<HyperNode> currentNode)
        where TModel : IHasTreeMenu
    {
        var childrenRoutes = b.Get(model, currentRouteCode, (model, current) => model.Routes.Where(x => x.ParentCode == current).OrderBy(x => x.OrderIndex).ToList());
        b.Foreach(childrenRoutes, (b, childRoute) =>
        {
            var itemText = b.TextNode(b.Get(childRoute, x => x.Title));
            var docCode = b.Get(childRoute, x => x.DocCode);

            var doc = b.Get(model, docCode, (model, docCode) => model.Docs.SingleOrDefault(x => x.Code == docCode));

            var url = b.If<string>(
                b.HasObject(doc),
                b =>
                {
                    return b.Switch<string, string>(
                        b.Get(doc, x => x.Type),
                        b => b.Concat(b.Const("/"), docCode),
                        ("tutorial", (BlockBuilder b) => b.Url<Routes.Tutorial, string>(docCode)),
                        ("docs", (BlockBuilder b) => b.Url<Routes.Docs, string>(docCode)));
                },
                b => b.Const(string.Empty));

            var itemContent = b.If(
                b.HasValue(url),
                b =>
                {
                    var link = b.Node("a", "", b => itemText);
                    b.SetAttr(link, Html.href, url);
                    return link;
                },
                b => itemText);

            var treeItem = b.Add(currentNode, b.TreeItem(b => itemContent));
            b.Call(FillRecursiveRoute, model, b.Get(childRoute, x => x.Code), treeItem);
        });
    }

    public static Var<HyperNode> DrawerTreeMenu<TModel>(this BlockBuilder b, Var<TModel> model)
        where TModel : IHasTreeMenu
    {
        var menuDrawerProps = b.NewObj<Drawer>();
        b.Set(menuDrawerProps, x => x.Placement, DrawerPlacement.Start);
        b.Set(menuDrawerProps, x => x.Open, b.Get(model, x => x.MenuIsExpanded));
        var drawer = b.Drawer(menuDrawerProps, b => b.TreeMenu(model));
        b.SetOnDrawerHide(drawer, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
        {
            b.Set(model, x => x.MenuIsExpanded, false);
            return b.Clone(model);
        }));

        var drawerTitle =
            b.Add(
                drawer,
                b.Div(
                    "flex flex-col gap-2",
                    b => b.Text("Metapsi"),
                    b => b.Text("The fullstack C# framework", "text-sm")));
        b.SetAttr(drawerTitle, DynamicProperty.String("slot"), "label");
        return drawer;
    }

    public static Var<HyperNode> Header<TModel>(this BlockBuilder b, Var<TModel> model, Func<BlockBuilder, Var<HyperNode>> headerContent)
    {
        var header = b.Div(
            "flex flex-row gap-4 items-center w-full px-8 py-4 fixed top-0 shadow bg-gray-50 text-xl",
            b =>
            {
                var showMenuButton = b.IconButton("list");
                b.SetOnClick(showMenuButton, b.MakeAction((BlockBuilder b, Var<TutorialModel> model) =>
                {
                    b.Set(model, x => x.MenuIsExpanded, true);
                    return b.Clone(model);
                }));

                return showMenuButton;
            },
            headerContent);

        return header;
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