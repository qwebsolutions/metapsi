using Metapsi.Syntax;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System;

namespace Metapsi.Hyperapp
{
    public static class Button
    {
        public enum Style
        {
            None,
            Primary,
            Light,
            Danger
        }
    }

    public static class SubmitButton
    {
        public class Props<TPayload>
        {
            public string Label { get; set; }
            public string Href { get; set; }
            public bool Enabled { get; set; } = true;
            public TPayload Payload { get; set; }
            public Button.Style Style { get; set; } = Button.Style.Primary;
            public string SvgIcon { get; set; }
            public string ButtonClass { get; set; } = "button-button";
            public string LabelClass { get; set; } = "button-label";
        }

        public static Var<HyperNode> Render<TPayload>(this BlockBuilder b, Var<Props<TPayload>> props)
            //where TPayload: new()
        {
            var form = b.Node("form", "inline");
            var button = b.Add(form, b.Node("button", b.Get(props, x=>x.ButtonClass)));
            var buttonContent = b.Add(button, b.Div("flex flex-row space-x-2 items-center"));
            b.If(b.HasValue(b.Get(props, x => x.SvgIcon)), b =>
            {
                var iconContainer = b.Add(buttonContent, b.Div("h-5 w-5"));
                b.SetInnerHtml(iconContainer, b.Get(props, x => x.SvgIcon));
            });

            b.If(b.HasValue(b.Get(props, x => x.Label)), b =>
            {
                b.Add(buttonContent, b.Text(b.Get(props, x => x.Label)));
                b.AddClass(button, b.Get(props, x=>x.LabelClass));
            },
            b =>
            {
                b.AddClass(button, "p-1 shadow");
            });

            b.If(b.Get(props, x => x.Enabled), b =>
            {
                //var href = b.Concat(b.RootPath(), b.Get(props, x => x.Href));
                var href = b.Get(props, x => x.Href);

                b.SetAttr(form, Html.action, b.Get(props, command => command.Href));
                b.SetAttr(form, Html.method, "POST");
                var hiddenPayload = b.Add(form, b.Node("input"));
                b.SetAttr(hiddenPayload, Html.name, "payload");
                b.SetAttr(hiddenPayload, Html.id, "payload");
                b.SetAttr(hiddenPayload, Html.type, "hidden");

                b.If(b.HasObject(b.Get(props, x => x.Payload)), b =>
                {
                    b.SetAttr(hiddenPayload, Html.value, b.Serialize(b.Get(props, x => x.Payload)));
                });

                //var hiddenUiState = b.Add(form, b.Node("input"));
                //b.SetAttr(hiddenUiState, Html.name, "uistate");
                //b.SetAttr(hiddenUiState, Html.id, "uistate");
                //b.SetAttr(hiddenUiState, Html.type, "hidden");

                //b.SetAttr(hiddenUiState, Html.value, b.Serialize(UiState.GetState(b)));

                b.SetAttr(button, Html.type, "submit");

                var bgClass = b.Switch(
                    b.Get(props, x => x.Style),
                    b => b.Const(""),
                    (Button.Style.Primary, b => b.Const("button-primary")),
                    (Button.Style.Danger, b => b.Const("button-danger")),
                    (Button.Style.Light, b => b.Const("button-light")));

                b.If(b.HasValue(bgClass), b =>
                {
                    b.AddClass(button, bgClass);
                });
            },
            b =>
            {
                // if disabled
                b.SetAttr(button, Html.disabled, true);
                b.AddClass(button, "bg-gray-300");
            });
            return form;
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> NavigateButton(this BlockBuilder b, Var<Hyperapp.NavigateButton.Props> props)
        {
            return b.Call(Hyperapp.NavigateButton.Render, props);
        }

        public static Var<HyperNode> NavigateButton(this BlockBuilder b, Action<Modifier<NavigateButton.Props>> updateDefaults)
        {
            return b.FromDefault(Hyperapp.NavigateButton.Render, updateDefaults);
        }

        public static Var<HyperNode> SubmitButton<TPayload>(this BlockBuilder b, Var<Hyperapp.SubmitButton.Props<TPayload>> props)
        {
            return b.Call(Hyperapp.SubmitButton.Render, props);
        }

        public static Var<HyperNode> SubmitButton<TPayload>(this BlockBuilder b, Action<Modifier<SubmitButton.Props<TPayload>>> updateDefaults)
        {
            return b.SubmitButton(b.NewObj(updateDefaults));
        }

        public static Var<HyperNode> FromDefault<TProps>(this BlockBuilder b, Func<BlockBuilder, Var<TProps>, Var<HyperNode>> control, Action<Modifier<TProps>> updateDefaults)
            where TProps : new()
        {
            var modifiedProps = b.NewObj<TProps>(updateDefaults);
            return b.Call(control, modifiedProps);
        }

        public static Var<HyperNode> FromProps<TProps>(this BlockBuilder b, Func<BlockBuilder, Var<TProps>, Var<HyperNode>> control, TProps props)
            where TProps : new()
        {
            return b.Call(control, b.NewObj(props));
        }
    }
}
