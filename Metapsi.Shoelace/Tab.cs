using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public enum TabPlacement
{
    Top,
    Bottom,
    Start,
    End
}

public enum TabActivation
{
    Auto,
    Manual
}

public class TabGroup
{
    public TabPlacement Placement { get; set; }
    public TabActivation Activation { get; set; }
    public bool NoScrollControls { get; set; }
}

public class Tab
{
    public string Panel { get; set; } = string.Empty;
    //public bool Active { get; set; }
    public bool Closable { get; set; }
    public bool Disabled { get; set; }
}

public class TabPanel
{
    public string Name { get; set; } = string.Empty;
    //public bool Active { get; set; }
}

public static partial class Control
{


    public static Var<HyperNode> TabGroup(this BlockBuilder b, Var<TabGroup> props)
    {
        var group = b.Node("sl-tab-group");

        b.SetAttr(group, new DynamicProperty<string>("placement"), b.EnumToFirstLowercase(b.Get(props, x => x.Placement)));
        b.SetAttr(group, new DynamicProperty<string>("activation"), b.EnumToFirstLowercase(b.Get(props, x => x.Activation)));
        b.SetAttr(group, new DynamicProperty<bool>("noScrollControls"), b.Get(props, x => x.NoScrollControls));

        return group;
    }

    public static Var<HyperNode> TabGroup(this BlockBuilder b)
    {
        return b.TabGroup(b.NewObj<TabGroup>());
    }

    public static Var<HyperNode> Tab(this BlockBuilder b, Var<Tab> props)
    {
        var tab = b.Node("sl-tab");

        b.SetAttr(tab, new DynamicProperty<string>("slot"), "nav");

        b.SetAttr(tab, new DynamicProperty<string>("panel"), b.Get(props, x=>x.Panel));
        //b.SetAttr(tab, new DynamicProperty<bool>("active"), b.Get(props, x => x.Active));
        b.SetAttr(tab, new DynamicProperty<bool>("closable"), b.Get(props, x => x.Closable));
        b.SetAttr(tab, new DynamicProperty<bool>("disabled"), b.Get(props, x => x.Disabled));

        return tab;
    }

    public static Var<HyperNode> TabPanel(this BlockBuilder b, Var<TabPanel> props)
    {
        var tabPanel = b.Node("sl-tab-panel");

        b.SetAttr(tabPanel, new DynamicProperty<string>("name"), b.Get(props, x => x.Name));
        //b.SetAttr(tabPanel, new DynamicProperty<bool>("active"), b.Get(props, x => x.Active));

        return tabPanel;
    }

    public static void TabPage(this BlockBuilder b, Var<HyperNode> tabGroup, Var<string> name, Var<HyperNode> tab, Var<HyperNode> panel)
    {
        var tabControl = b.Tab(b.NewObj<Tab>(b =>
        {
            b.Set(x => x.Panel, name);
        }));

        b.Add(tabControl, tab);


        var tabPanelControl = b.TabPanel(b.NewObj<TabPanel>(b =>
        {
            b.Set(x => x.Name, name);
        }));

        b.Add(tabPanelControl, panel);

        b.Add(tabGroup, tabControl);
        b.Add(tabGroup, tabPanelControl);
    }

    public static void TabPage(this BlockBuilder b, Var<HyperNode> tabGroup, Var<string> name, Var<string> tabLabel, Var<HyperNode> panel)
    {
        b.TabPage(tabGroup, name, b.Text(tabLabel), panel);
    }
}
