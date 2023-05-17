using Metapsi.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public interface IHasTabs
    {
        string FirstLevelSelectedTab { get; set; }
        string SecondLevelSelectedTab { get; set; }
    }

    public static partial class Tab
    {
        //public class TabPage
        //{
        //    public string Name { get; set; }
        //    public string Label { get; set; }
        //    public HyperNode TabContent { get; set; }
        //}

        //public class Props
        //{
        //    public string Name { get; set; }
        //    public List<TabPage> Pages { get; set; } = new List<TabPage>();
        //}

        //internal class TabState
        //{
        //    public string TabName { get; set; } = string.Empty;
        //    public string SelectedPageName { get; set; } = string.Empty;
        //}

        //internal class TabsState
        //{
        //    public List<TabState> AllTabs { get; set; } = new();
        //}

        internal static Var<HyperNode> RenderTab<TPage>(
            this BlockBuilder b, 
            Var<TPage> page, 
            Var<string> tabName,
            Var<HyperNode> toolbar,
            params Controls. TabRenderer[] tabPages)
            where TPage: IHasTabs
        {
            //var defaultPageName = b.Get(props, x => x.Pages.First().Name);
            //var selectedPageName = b.GetSelectedTabPage(tabName, defaultPageName);

            if (tabPages.Any())
            {
                var selectedTabPageCode = b.Get(page, x => x.FirstLevelSelectedTab);

                var selectedTabIsValidCode = b.Get(
                    selectedTabPageCode,
                    b.Const(tabPages.Select(x => x.TabPageCode).ToList()),
                    (selected, all) => all.Any(x => x == selected));

                b.If(
                    b.Not(selectedTabIsValidCode),
                    b => b.Set(page, x => x.FirstLevelSelectedTab, b.Const(tabPages.First().TabPageCode)));
            }

            var rootContainer = b.Div("bg-white rounded drop-shadow");

            var topArea = b.Add(rootContainer, b.Div("flex flex-row justify-between p-4"));

            var labels = b.Add(topArea, b.Div("flex flex-row gap-4"));

            var commands = b.Add(topArea, toolbar);

            //var commands = b.Add(topArea, b.Div("flex flex-row gap-4"));
            //b.Add(commands, b.Text("Commands here"));
            //b.Add(commands, b.Text("Commands here"));

            var contentContainer = b.Add(rootContainer, b.Div("flex flex-column p-8"));

            //var tabs = b.Get(props, x => x.Pages);

            foreach(var tab in tabPages)
            {
                var tabLabel = b.Div("p-4 cursor-pointer border-b rounded-t bg-white");
                var tabCode = b.Const(tab.TabPageCode);

                b.SetOnClick<TPage>(
                    tabLabel, 
                    b.MakeAction((BlockBuilder b, Var<TPage> state) =>
                    {
                        b.Call(SetSelectedTabPage, state, tabCode);
                        return b.Clone(state);
                    }));

                b.Add(tabLabel, b.Call(tab.TabHeader));

                b.Add(labels, tabLabel);

                var isSelected = b.AreEqual<string>(tabCode, b.Get(page, x => x.FirstLevelSelectedTab));

                b.If(isSelected, b =>
                {
                    b.AddClass(tabLabel, "border-b-2 border-sky-400");
                    b.Add(contentContainer, b.Call(tab.TabContent));
                }, b =>
                {
                    b.AddClass(tabLabel, "border-white hover:border-sky-400 hover:border-b-2");
                });
            }

            return rootContainer;
        }

        public static void SetSelectedTabPage<TPage>(this BlockBuilder b, Var<TPage> page, Var<string> tabName)
            where TPage: IHasTabs
        {
            b.Set(page, x => x.FirstLevelSelectedTab, tabName);
        }

        //internal static Var<string> GetSelectedTabPage(this BlockBuilder b, Var<string> tabName, Var<string> defaultPageName)
        //{
        //    var tabState= b.GetControlState<TabState>(tabName, b=>
        //    {
        //        b.Set(x => x.TabName, tabName);
        //        b.Set(x => x.SelectedPageName, defaultPageName);
        //    });

        //    return b.Get(tabState, x => x.SelectedPageName);

        //    //return b.If<string>(
        //    //    b.IsEmpty(selectedTabPage.As<object>()),
        //    //    b => defaultPageName,
        //    //    b => b.Get(selectedTabPage, x => x.SelectedPageName));
        //}

        //public static void AddTabPage(
        //    this BlockBuilder b,
        //    Var<Props> props,
        //    string tabPageName,
        //    string tabPageLabel,
        //    Var<HyperNode> content)
        //{
        //    b.Modify<Props, List<TabPage>>(props, x => x.Pages, b =>
        //    {
        //        b.Add(b =>
        //        {
        //            b.Set(x => x.Name, b.Const(tabPageName));
        //            b.Set(x => x.Label, b.Const(tabPageLabel));
        //            b.Set(x => x.TabContent, content);
        //        });
        //    });
        //}
    }
}

