using Metapsi.Syntax;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Metapsi.Hyperapp
{
    //public interface IHasTabs
    //{
    //    string FirstLevelSelectedTab { get; set; }
    //    string SecondLevelSelectedTab { get; set; }
    //}

    public static partial class Tab
    {
        private const string FeatureName = "Tabs";
        //private const string SelectedTabKey = "SelectedTab";

        //private static string GetTabKey(string tabName)
        //{
        //    return $"{FeatureName}.{tabName}";
        //}

        internal static Var<HyperNode> RenderTab<TPage>(
            this BlockBuilder b, 
            Var<TPage> page, 
            Var<string> tabName,
            Var<HyperNode> toolbar,
            params Controls.TabRenderer[] tabPages)
        {
            var rootContainer = b.Div("bg-white rounded drop-shadow");

            if (tabPages.Any())
            {
                var selectedTabPageCode = b.GetVar(page, FeatureName, tabName, b.Const(tabPages.First().TabPageCode));

                var topArea = b.Add(rootContainer, b.Div("flex flex-row justify-between p-4"));

                var labels = b.Add(topArea, b.Div("flex flex-row gap-4"));

                var commands = b.Add(topArea, toolbar);

                var contentContainer = b.Add(rootContainer, b.Div("flex flex-column p-8"));

                foreach (var tab in tabPages)
                {
                    var tabLabel = b.Div("p-4 cursor-pointer border-b rounded-t bg-white");
                    var tabCode = b.Const(tab.TabPageCode);

                    b.SetOnClick<TPage>(
                        tabLabel,
                        b.MakeAction((BlockBuilder b, Var<TPage> state) =>
                        {
                            b.SetSelectedTabPage(state, tabName, b.Const(tab.TabPageCode));
                            return b.Clone(state);
                        }));

                    b.Add(tabLabel, b.Call(tab.TabHeader));

                    b.Add(labels, tabLabel);

                    var isSelected = b.AreEqual<string>(tabCode, selectedTabPageCode);

                    b.If(isSelected, b =>
                    {
                        b.AddClass(tabLabel, "border-b-2 border-sky-400");
                        b.Add(contentContainer, b.Call(tab.TabContent));
                    }, b =>
                    {
                        b.AddClass(tabLabel, "border-white hover:border-sky-400 hover:border-b-2");
                    });
                }
            }
            return rootContainer;
        }

        public static void SetSelectedTabPage<TPage>(this BlockBuilder b, Var<TPage> page, Var<string> tabName, Var<string> tabPageCode)
        {
            b.SetVar(page, FeatureName, tabName, tabPageCode);
        }
    }
}

