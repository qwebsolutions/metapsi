using Metapsi.Html;
using Metapsi.Hyperapp;
using Metapsi.Syntax;

namespace Metapsi.Shoelace;


public partial class SlCheckbox : IHasEditableValue
{
    public bool @checked { get; set; }
}

public partial class SlInput : IHasEditableValue
{
    public string value { get; set; }
}

public partial class SlSelect : IHasEditableValue
{
    public string value { get; set; }
}

public partial class SlTextarea : IHasEditableValue
{
    public string value { get; set; }
}

/// <summary>
/// 
/// </summary>
public class SlInputBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public System.Type ControlType => typeof(SlInput);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<SlInput>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value).As<object>(),
            SlInputControl.OnSlInput);
    }
}

/// <summary>
/// 
/// </summary>
public class SlSelectBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public System.Type ControlType => typeof(SlSelect);
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<SlSelect>((b, value) =>
        {
            b.SetValue(value.As<string>());
        },
        (b, e) => b.Get(b.Get(e, x => x.target).As<SlSelect>(), x => x.value).As<object>(),
        (b, updateAction) =>
        {
            b.OnSlChange(updateAction);
        });
    }
}

/// <summary>
/// 
/// </summary>
public class SlCheckboxBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public System.Type ControlType => typeof(SlCheckbox);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<SlCheckbox>((b, value) =>
        {
            b.SetChecked(value.As<bool>());
        },
        (b, e) => b.Get(b.Get(e, x => x.target).As<SlCheckbox>(), x => x.@checked).As<object>(),
        (b, updateAction) =>
        {
            b.OnSlChange(updateAction);
        });
    }
}

/// <summary>
/// 
/// </summary>
public class SlTextareaBinding : IAutoRegisterBinding
{
    /// <summary>
    /// 
    /// </summary>
    public System.Type ControlType => typeof(SlTextarea);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Html.Binding GetBinding()
    {
        return Html.Binding.New<SlTextarea>(
            (b, value) =>
            {
                b.SetValue(value.As<string>());
            },
            (b, e) => b.GetTargetValue(e).As<object>(),
            SlTextareaControl.OnSlInput);
    }
}