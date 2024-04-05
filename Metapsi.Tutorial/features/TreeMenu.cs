using Metapsi.Dom;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Tutorial;

public class MenuEntry
{
    public string Title { get; set; }
    public string Url { get; set; }
    public List<MenuEntry> Children { get; set; } = new();
}

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
        var tree = new SlTree()
        {
            selection = "leaf"
        };

        var expandedParents = model.GetExpandedParents();

        FillMenuEntries(model.Menu, tree, expandedParents, model.CurrentEntry);
        return tree;
    }

    private static void FillMenuEntries(
        List<MenuEntry> currentEntries,
        IHtmlElement currentNode,
        List<MenuEntry> expandedParents,
        MenuEntry selectedMenuItem)
    {
        foreach (var entry in currentEntries)
        {
            IHtmlNode menuEntry =
                !string.IsNullOrEmpty(entry.Url) ?
                new HtmlTag("a").WithChild(HtmlText.CreateTextNode(entry.Title)).SetAttribute("href", entry.Url) :
                new HtmlText(entry.Title);

            var treeItem = currentNode.AddChild(new SlTreeItem()
            {
                selected = entry == selectedMenuItem,
                expanded = expandedParents.Contains(entry)
            });
            treeItem.AddChild(menuEntry);

            FillMenuEntries(entry.Children, treeItem, expandedParents, selectedMenuItem);
        }
    }

    public static IHtmlElement DrawerTreeMenu<TModel>(TModel model)
        where TModel: IHasTreeMenu
    {
        var drawer = new SlDrawer()
        {
            placement = "start"
        };
        drawer.SetAttribute("id", MenuDrawerId);
        drawer.AddChild(TreeMenu(model));

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
            "flex flex-row gap-4 items-center w-full px-8 h-20 fixed top-0 shadow bg-gray-50 text-xl",
            onClickScript,
            new SlIconButton()
            {
                name = "list"
            }.SetAttribute("id", BtnToggleTreeId),
            headerContent);

        return header;
    }

    public static IHtmlElement NavigatorArrows(MenuEntry prevEntry, MenuEntry nextEntry)
    {
        var navigatorArrowsContainer = DivTag.CreateStyled(
            "flex flex-row justify-between");

        if (prevEntry != null)
        {
            var prev = new HtmlTag("a").SetAttribute("href", prevEntry.Url).WithClass("flex flex-row gap-4 items-center");
            prev.AddChild(new SlIcon() { name = "arrow-left-circle" });
            prev.AddChild(HtmlText.CreateTextNode(prevEntry.Title));

            navigatorArrowsContainer.AddChild(prev);
        }

        if (nextEntry != null)
        {
            var next = new HtmlTag("a").SetAttribute("href", nextEntry.Url).WithClass("flex flex-row gap-4 items-center");
            next.AddChild(HtmlText.CreateTextNode(nextEntry.Title));
            next.AddChild(new SlIcon() { name = "arrow-right-circle" });

            navigatorArrowsContainer.AddChild(next);
        }

        return navigatorArrowsContainer;
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

    public static MenuEntry GetParent(IHasTreeMenu page, MenuEntry childEntry)
    {
        var justParents = GetFlatMenuParents(page);
        return justParents.FirstOrDefault(x => x.Children.Contains(childEntry));
    }

    public static List<MenuEntry> GetExpandedParents(this IHasTreeMenu page)
    {
        List<MenuEntry> parents = new List<MenuEntry>();

        var currentItem = page.CurrentEntry;

        while (true)
        {
            if (currentItem == null)
                return parents;

            currentItem = GetParent(page, currentItem);
            parents.Add(currentItem);
        }
    }

    public static void TraverseMenu(List<MenuEntry> menuEntries, Action<MenuEntry> onEntry)
    {
        foreach(var menuEntry in menuEntries)
        {
            onEntry(menuEntry);
            TraverseMenu(menuEntry.Children, onEntry);
        }
    }

    public static List<MenuEntry> GetFlatMenuArticles(this IHasTreeMenu page)
    {
        List<MenuEntry> menuEntries = new List<MenuEntry>();
        TraverseMenu(page.Menu, entry =>
        {
            if(!string.IsNullOrEmpty(entry.Url))
            {
                menuEntries.Add(entry);
            }
        });

        return menuEntries;
    }

    public static List<MenuEntry> GetFlatMenuParents(this IHasTreeMenu page)
    {
        List<MenuEntry> menuEntries = new List<MenuEntry>();
        TraverseMenu(page.Menu, entry =>
        {
            if (string.IsNullOrEmpty(entry.Url))
            {
                menuEntries.Add(entry);
            }
        });

        return menuEntries;
    }

    public static MenuEntry GetPreviousMenuEntry<TModel>(this TModel model)
        where TModel : IHasTreeMenu
    {
        if (model.CurrentEntry == null)
            return null;

        var flatMenu = model.GetFlatMenuArticles();
        var currentIndex = flatMenu.IndexOf(model.CurrentEntry);
        if (currentIndex == 0)
            return null;

        return flatMenu[currentIndex - 1];
    }

    public static MenuEntry GetNextMenuEntry<TModel>(this TModel model)
        where TModel : IHasTreeMenu
    {
        if (model.CurrentEntry == null)
            return null;

        var flatMenu = model.GetFlatMenuArticles();
        var currentIndex = flatMenu.IndexOf(model.CurrentEntry);
        if (currentIndex <= 0)
            return null;

        if (currentIndex == flatMenu.Count - 1)
            return null;

        return flatMenu[currentIndex + 1];
    }
}