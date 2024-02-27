using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;

public static class PropsBuilderExtensions
{
    public static PropsBuilder<TProps> SetSlot<TProps>(this PropsBuilder<TProps> b, Var<string> slotName)
        where TProps : new()
    {
        b.SetDynamic(b.Props, DynamicProperty.String("slot"), slotName);
        return b;
    }

    public static PropsBuilder<TProps> SetSlot<TProps>(this PropsBuilder<TProps> b, string slotName)
        where TProps : new()
    {
        b.SetSlot(b.Const(slotName));
        return b;
    }
}
