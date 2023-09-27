using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public interface IHasTreeMenu
{
    MenuEntry CurrentEntry { get; set; }
    List<MenuEntry> Menu { get; set; }
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

        FillMenuEntries(model.Menu, tree);
        return tree;
    }

    private static void FillMenuEntries(List<MenuEntry> currentEntries, IHtmlElement currentNode)
    {
        foreach (var entry in currentEntries)
        {
            IHtmlNode menuEntry =
                !string.IsNullOrEmpty(entry.Url) ?
                new HtmlTag("a").WithChild(HtmlText.CreateTextNode(entry.Title)).SetAttribute("href", entry.Url) :
                new HtmlText(entry.Title);

            var treeItem = currentNode.AddChild(Component.Create<TreeItem>(
                "sl-tree-item",
                new TreeItem(),
                menuEntry));

            FillMenuEntries(entry.Children, treeItem);
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

    public static HtmlTag Header<TModel>(TModel model, IHtmlNode headerContent)
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
            .SetAttribute("id", BtnToggleTreeId),
            headerContent);

        return header;
    }
}

public static class TreeMenuExtensions
{
    public static async Task LoadMenu(this IHasTreeMenu model)
    {
        var menuJson = await System.Reflection.Assembly.GetAssembly(typeof(TutorialHandler)).GetEmbeddedTextFile("menu.json");
        model.Menu = Metapsi.Serialize.FromJson<List<MenuEntry>>(menuJson);
    }

    public static void SetCurrentEntry(this IHasTreeMenu model, string requestPath)
    {
        TraverseMenu(model.Menu, (entry) =>
        {
            if (requestPath == entry.Url)
            {
                model.CurrentEntry = entry;
            }
        });
    }

    public static void TraverseMenu(List<MenuEntry> menuEntries, Action<MenuEntry> onEntry)
    {
        foreach(var menuEntry in menuEntries)
        {
            onEntry(menuEntry);
            TraverseMenu(menuEntry.Children, onEntry);
        }
    }
}