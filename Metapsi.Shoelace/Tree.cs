using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Shoelace;

public enum TreeSelection
{
    Single,
    Multiple,
    Leaf
}

public class Tree
{
    public TreeSelection Selection { get; set; }
}

public class TreeItem
{
    public bool Expanded { get; set; } = false;
    public bool Selected { get; set; } = false;
}

public static partial class Control
{
    public static Var<HyperNode> Tree(this LayoutBuilder b)
    {
        return b.SlNode("sl-tree");
    }

    public static Var<HyperNode> Tree(this LayoutBuilder b, Var<Tree> props)
    {
        var tree = b.SlNode("sl-tree");
        b.SetAttr(tree, new DynamicProperty<string>("selection"), b.EnumToLowercase(b.Get(props, x => x.Selection)));
        return tree;
    }

    public static Var<HyperNode> TreeItem(this LayoutBuilder b)
    {
        return b.SlNode("sl-tree-item");
    }

    public static Var<HyperNode> TreeItem(this LayoutBuilder b, System.Func<LayoutBuilder, Var<HyperNode>> content)
    {
        var treeItem = b.SlNode("sl-tree-item");
        b.Add(treeItem, b.Call(content));
        return treeItem;
    }
}
