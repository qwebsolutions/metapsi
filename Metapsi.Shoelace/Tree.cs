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

}

public static partial class Control
{
    public static Var<HyperNode> Tree(this BlockBuilder b)
    {
        return b.Node("sl-tree");
    }

    public static Var<HyperNode> Tree(this BlockBuilder b, Var<Tree> props)
    {
        var tree = b.Node("sl-tree");
        b.SetAttr(tree, new DynamicProperty<string>("selection"), b.EnumToLowercase(b.Get(props, x => x.Selection)));
        return tree;
    }

    public static Var<HyperNode> TreeItem(this BlockBuilder b)
    {
        return b.Node("sl-tree-item");
    }

    public static Var<HyperNode> TreeItem(this BlockBuilder b, System.Func<BlockBuilder, Var<HyperNode>> content)
    {
        return b.Node("sl-tree-item", "", content);
    }
}
