using Metapsi.Syntax;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class Alert
    {
        public class State
        {
            public string AlertCode { get; set; }
            public string Reference { get; set; }
            public string Text { get; set; }
            public int RemainingTicks { get; set; }
        }

        public static Var<HyperNode> RenderNotification(this BlockBuilder b, Var<State> props)
        {
            var container = b.Div("grid fixed top-5 left-0 w-screen place-items-center");
            var center = b.Add(container, b.Div("border border-solid border-red-300 bg-red-100 text-red-300 rounded w-1/2 p-2 drop-shadow"));
            b.Add(center, b.Text(b.Get(props, x => x.Text)));
            return container;
        }

        public static Var<HyperNode> RenderValidation(this BlockBuilder b, Var<State> props)
        {
            var center = b.Div("border border-solid border-red-300 bg-red-100 text-red-300 rounded w-full p-2 drop-shadow");
            b.Add(center, b.Text(b.Get(props, x => x.Text)));
            return center;
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> Notification(this BlockBuilder b, string text)
        {
            var t = b.Const(text);
            return b.Call(Hyperapp.Alert.RenderNotification, b.NewObj<Hyperapp.Alert.State>(b=> b.Set(x => x.Text, t)));
        }

        public static Var<HyperNode> Notification(this BlockBuilder b, Var<string> text)
        {
            return b.Call(Hyperapp.Alert.RenderNotification, b.NewObj<Hyperapp.Alert.State>(b => b.Set(x => x.Text, text)));
        }

        public static Var<HyperNode> ValidationPanel<TPage>(this BlockBuilder b, Var<TPage> page)
            where TPage : IHasValidationPanel
        {
            Var<string> validationMessage = b.Get(page, x => x.ValidationMessage);
            return b.If(
                b.HasValue(validationMessage),
                b =>
                {
                    var validationDiv = b.Div(
                        "border border-solid border-red-300 bg-red-100 text-red-300 rounded w-full p-2 mb-4 drop-shadow transition-all",
                        b => b.Text(validationMessage));
                    return validationDiv;
                },
                b =>
                {
                    var validationDiv = b.Div("w-0 h-0 transition-all");
                    return validationDiv;
                });
        }
    }

    public interface IHasValidationPanel
    {
        string ValidationMessage { get; set; }
    }
}

