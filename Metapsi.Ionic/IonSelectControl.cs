using Metapsi.Syntax;

namespace Metapsi.Ionic;

public static partial class IonSelectControl
{
    public static void SetValue<TControl, TValue>(this PropsBuilder<TControl> b, Var<TValue> value)
        where TControl : IonSelect
    {
        IonSelectControl.SetValue<TControl>(b, value.As<object>());
    }
}

public static partial class IonSelectOptionControl
{
    public static void SetValue<TControl, TValue>(this PropsBuilder<TControl> b, Var<TValue> value)
        where TControl : IonSelectOption
    {
        IonSelectOptionControl.SetValue<TControl>(b, value.As<object>());
    }
}
