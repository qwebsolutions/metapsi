using Metapsi.Syntax;
using System;

namespace Metapsi.Html;

public class HtmlTextareaBinding : IAutoRegisterBinding
{
    public Type ControlType => typeof(HtmlTextarea);

    public Binding GetBinding()
    {
        return Binding.New<HtmlTextarea>((b, value) =>
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