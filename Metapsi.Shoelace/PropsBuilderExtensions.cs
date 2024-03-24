using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public static class PropsBuilderExtensions
{
    public static PropsBuilder SetSlot(this PropsBuilder b, Var<DynamicObject> props, Var<string> slotName)
    {
        b.SetDynamic(props, DynamicProperty.String("slot"), slotName);
        return b;
    }

    public static PropsBuilder SetSlot(this PropsBuilder b, Var<DynamicObject> props, string slotName)
    {
        return b.SetSlot(props, b.Const(slotName));
    }
}
