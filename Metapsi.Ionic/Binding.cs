using Metapsi.Html;
using Metapsi.Syntax;
using System;

namespace Metapsi.Ionic;

public partial class IonInput : IHasEditableValue { }
public partial class IonTextarea : IHasEditableValue { }
public partial class IonSelect : IHasEditableValue { }
public partial class IonPickerColumn : IHasEditableValue { }
public partial class IonDatetime : IHasEditableValue { }
public partial class IonSegment : IHasEditableValue { }
public partial class IonCheckbox: IHasEditableValue { }
public partial class IonInputOtp: IHasEditableValue { }
public partial class IonSearchbar: IHasEditableValue { }

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

/// <summary>
/// 
/// </summary>
public class IonSegmentBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public Type ControlType => typeof(IonSegment);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Binding GetBinding()
    {
        return Html.Binding.New<IonSegment>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<SegmentChangeEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}

public class IonCheckboxBinding : IAutoRegisterBinding
{
    public Type ControlType => typeof(IonCheckbox);

    public Binding GetBinding()
    {
        return Html.Binding.New<IonCheckbox>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<CheckboxChangeEventDetail>>(), x => x.detail.@checked).As<object>(),
            (b, updateAction) => b.OnIonChange(updateAction));
    }
}

public class IonInputOtpBinding: IAutoRegisterBinding
{
    public Type ControlType => typeof(IonInputOtp);

    public Binding GetBinding()
    {
        return Html.Binding.New<IonInputOtp>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<InputOtpInputEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonInput(updateAction));
    }
}

public class IonSearchbarBinding : IAutoRegisterBinding
{
    public Type ControlType => typeof(IonSearchbar);

    public Binding GetBinding()
    {
        return Html.Binding.New<IonSearchbar>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(e.As<CustomEvent<InputInputEventDetail>>(), x => x.detail.value).As<object>(),
            (b, updateAction) => b.OnIonInput(updateAction));
    }
}