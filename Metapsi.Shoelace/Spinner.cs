using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public class Spinner
{

}

public static partial class Control
{
    public static Var<HyperNode> Spinner(this BlockBuilder b)
    {
        return b.Node("sl-spinner");
    }
}
