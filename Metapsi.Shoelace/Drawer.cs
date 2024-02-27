//using Metapsi.Hyperapp;
//using Metapsi.Syntax;

//namespace Metapsi.Shoelace;

//public enum DrawerPlacement
//{
//    Top,
//    End,
//    Bottom, 
//    Start
//}

//public class Drawer
//{
//    public bool Open { get; set; } = false;
//    public DrawerPlacement Placement { get; set; } = DrawerPlacement.End;
//    public string Label { get; set; } = string.Empty;
//}

//public static partial class Control
//{
//    public static Var<HyperNode> Drawer(this LayoutBuilder b, Var<Drawer> props)
//    {
//        var drawer = b.SlNode("sl-drawer");
//        b.SetAttr(drawer, new DynamicProperty<string>("label"), b.Get(props, x => x.Label));
//        b.SetAttr(drawer, new DynamicProperty<string>("placement"), b.EnumToFirstLowercase(b.Get(props, x => x.Placement)));
//        b.SetAttr(drawer, new DynamicProperty<bool>("open"), b.Get(props, x => x.Open));

//        return drawer;
//    }

//    public static Var<HyperNode> Drawer(this LayoutBuilder b, Var<Drawer> props,
//        System.Func<LayoutBuilder, Var<HyperNode>> content)
//    {
//        var drawer = b.Drawer(props);
//        b.Add(drawer, b.Call(content));
//        return drawer;
//    }

//    public static void SetOnDrawerHide<TState>(this LayoutBuilder b, Var<HyperNode> drawer, Var<HyperType.Action<TState>> onHide)
//    {
//        b.SetAttr(drawer, new DynamicProperty<HyperType.Action<TState>>("onsl-hide"), onHide);
//    }
//}