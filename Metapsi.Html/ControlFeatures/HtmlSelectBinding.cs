using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

public class HtmlSelectBinding : IAutoRegisterBinding
{
    public Type ControlType => typeof(HtmlSelect);

    public Binding GetBinding()
    {
        return Binding.New<HtmlSelect>((b, value) =>
        {
            b.Set(x => x.value, value.As<string>());
        },
        (b, e) =>
        {
            return b.GetTargetValue(e).As<object>();
        },
        (b, action) =>
        {
            b.OnEventAction("input", action);
        });
    }
}