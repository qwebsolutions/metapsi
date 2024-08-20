using Metapsi.Dom;
using Metapsi.Html;
using Metapsi.Shoelace;
using Metapsi.Syntax;
using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Metapsi.Ui.Menu;

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

    public static IHtmlNode TreeMenu<TModel>(this HtmlBuilder b, TModel model)
        where TModel : IHasTreeMenu
    {
        var expandedParents = model.GetExpandedParents();

        return b.SlTree(
            b =>
            {
                b.SetSelectionLeaf();
            },
            b.MenuEntries(model.Menu, expandedParents, model.CurrentEntry));
    }

    private static List<IHtmlNode> MenuEntries(
        this HtmlBuilder b,
        List<MenuEntry> currentEntries,
        List<MenuEntry> expandedParents,
        MenuEntry selectedMenuItem)
    {
        return currentEntries.Select(entry =>
        {
            var nodes = new List<IHtmlNode>();

            if (!string.IsNullOrEmpty(entry.Url))
            {
                nodes.Add(b.HtmlA(
                    b =>
                    {
                        b.SetHref(entry.Url);
                    },
                    b.Text(entry.Title)));
            }
            else
            {
                nodes.Add(b.Text(entry.Title));
            }

            nodes.AddRange(b.MenuEntries(entry.Children, expandedParents, selectedMenuItem));

            return b.SlTreeItem(
                b =>
                {
                    b.SetSelected(entry == selectedMenuItem);
                    b.SetExpanded(expandedParents.Contains(entry));
                },
                nodes);
                

        }).ToList();
    }

    public static IHtmlNode DrawerTreeMenu<TModel>(this HtmlBuilder b, TModel model)
        where TModel: IHasTreeMenu
    {
        return b.SlDrawer(
            b =>
            {
                b.SetPlacementStart();
                b.SetAttribute("id", MenuDrawerId);
            },
            b.TreeMenu(model),
            b.HtmlDiv(
                b =>
                {
                    b.SetClass("flex flex-col gap-2");
                    b.SetAttribute("slot", SlDrawer.Slot.Label);
                },
                b.Text("Metapsi"),
                b.HtmlSpan(
                    b =>
                    {
                        b.SetClass("text-sm");
                    },
                    b.Text("The fullstack C# framework"))
                ));
    }

    public static IHtmlNode Header<TModel>(this HtmlBuilder b, TModel model, IHtmlNode headerContent)
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

        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-row gap-4 items-center w-full px-8 h-20 fixed top-0 shadow bg-gray-50 text-xl");
            },
            onClickScript,
            b.SlIconButton(
                b =>
                {
                    b.SetName("list");
                    b.SetAttribute("id", BtnToggleTreeId);
                },
                headerContent));
    }

    public static IHtmlNode NavigatorArrows(this HtmlBuilder b, MenuEntry prevEntry, MenuEntry nextEntry)
    {
        return b.HtmlDiv(
            b =>
            {
                b.SetClass("flex flex-row justify-between");
            },
            b.Optional(
                prevEntry != null,
                b =>
                {
                    return b.HtmlA(
                        b =>
                        {
                            b.SetHref(prevEntry.Url);
                            b.SetClass("flex flex-row gap-4 items-center");
                        });
                }),
            b.Optional(
                nextEntry != null,
                b =>
                {
                    return b.HtmlA(
                        b =>
                        {
                            b.SetHref(nextEntry.Url);
                            b.SetClass("flex flex-row gap-4 items-center");
                        },
                        b.Text(nextEntry.Title),
                        b.SlIcon(b => b.SetName("arrow-right-circle")));
                }));
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