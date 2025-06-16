//using Metapsi.Syntax;

//namespace Metapsi.Html;

//public partial class HtmlInput : IAllowsBinding<HtmlInput>
//{
//    public ControlBinder<HtmlInput> GetControlBinder() => Binding.GetHtmlDefaultBinder<HtmlInput>();
//}

//public partial class HtmlTextarea : IAllowsBinding<HtmlInput>
//{
//    public ControlBinder<HtmlInput> GetControlBinder() => Binding.GetHtmlDefaultBinder<HtmlInput>();
//}

//public partial class HtmlSelect : IAllowsBinding<HtmlInput>
//{
//    public ControlBinder<HtmlInput> GetControlBinder() => Binding.GetHtmlDefaultBinder<HtmlInput>();
//}

//public partial class HtmlInput : IHasInputTextEvent<HtmlInput>
//{
//    InputTextEventDescription<HtmlInput> IHasInputTextEvent<HtmlInput>.GetInputTextEventDescription()
//    {
//        return InputTextEvent.GetHtmlDefaultInputTextEvent<HtmlInput>();
//    }
//}
//public partial class HtmlTextarea : IHasInputTextEvent<HtmlTextarea>
//{
//    InputTextEventDescription<HtmlTextarea> IHasInputTextEvent<HtmlTextarea>.GetInputTextEventDescription()
//    {
//        return InputTextEvent.GetHtmlDefaultInputTextEvent<HtmlTextarea>();
//    }
//}

//public partial class HtmlSelect : IHasInputTextEvent<HtmlSelect>
//{
//    InputTextEventDescription<HtmlSelect> IHasInputTextEvent<HtmlSelect>.GetInputTextEventDescription()
//    {
//        return InputTextEvent.GetHtmlDefaultInputTextEvent<HtmlSelect>();
//    }
//}

//public class AllowsBinding
//{
//    public string NewValueEventName { get; }
//    public System.Func<SyntaxBuilder, Var<object>, Var<string>> GetValue { get; }
//    public System.Action<PropsBuilder<AllowsBinding>, Var<string>> SetValue { get; }
//}


//public static class HtmlInputEventExtensions
//{
    
//}