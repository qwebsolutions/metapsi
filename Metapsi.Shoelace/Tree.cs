using Metapsi.Hyperapp;
using Metapsi.Syntax;
using System.Collections.Generic;

namespace Metapsi.Shoelace;

public class Tree
{ 
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

    public static Var<HyperNode> TreeItem(this BlockBuilder b)
    {
        return b.Node("sl-tree-item");
    }

    public static Var<HyperNode> TreeItem(this BlockBuilder b, System.Func<BlockBuilder, Var<HyperNode>> content)
    {
        return b.Node("sl-tree-item", "", content);
    }
}
