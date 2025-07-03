using Metapsi.Html;
using Metapsi.Syntax;
using System;

namespace Metapsi.Ionic;

public partial class IonInput : IHasEditableValue { }
public partial class IonTextarea : IHasEditableValue { }
public partial class IonSelect : IHasEditableValue { }
public partial class IonPickerColumn : IHasEditableValue { }
public partial class IonDatetime : IHasEditableValue { }

/// <summary>
/// 
/// </summary>
public class IonInputBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public Type ControlType => typeof(IonInput);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<IonInput>((b, value) =>
        {
            b.SetValue(value.As<string>());
        },
        (b, e) => b.Get(e.As<CustomEvent<InputInputEventDetail>>(), x => x.detail.value).As<object>(),
        (b, updateAction) => b.OnIonInput(updateAction));
    }
}

/// <summary>
/// 
/// </summary>
public class IonTextAreaBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public Type ControlType => typeof(IonTextarea);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<IonTextarea>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<TextareaInputEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonInput(updateAction)
            );
    }
}

/// <summary>
/// 
/// </summary>
public class IonSelectBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public Type ControlType => typeof(IonSelect);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<IonSelect>(
            (b, value) =>
            {
                b.SetValue(value.As<object>());
            },
            (b, e) => b.Get(e.As<CustomEvent<SelectChangeEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}

/// <summary>
/// 
/// </summary>
public class IonPickerColumnBinding : IAutoRegisterBinding
{
    public Type ControlType => typeof(IonPickerColumn);

    public Binding GetBinding()
    {
        return Html.Binding.New<IonPickerColumn>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<PickerColumnChangeEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}

/// <summary>
/// 
/// </summary>
public class IonDatetimeBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public Type ControlType => typeof(IonDatetime);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Binding GetBinding()
    {
        return Html.Binding.New<IonDatetime>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<DatetimeChangeEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}