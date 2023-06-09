using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class NavigateButton
    {
        public class Props
        {
            public string Label { get; set; }
            public string Href { get; set; }
            public bool Enabled { get; set; } = true;
            public Button.Style Style { get; set; } = Button.Style.Primary;
            public string SvgIcon { get; set; }
        }

        public static Var<HyperNode> Render(this BlockBuilder b, Var<Props> props)
        {
            var link = b.Node("a");
            var button = b.Add(link, b.Node("button", "rounded"));
            var buttonContent = b.Add(button, b.Div("flex flex-row space-x-2 items-center"));
            b.If(b.HasValue(b.Get(props, x => x.SvgIcon)), b =>
            {
                var iconContainer = b.Add(buttonContent, b.Div("h-5 w-5"));
                b.SetInnerHtml(iconContainer, b.Get(props, x => x.SvgIcon));
            });

            b.If(b.HasValue(b.Get(props, x => x.Label)), b =>
            {
                b.Add(buttonContent, b.Text(b.Get(props, x => x.Label)));
                b.AddClass(button, "text-white py-2 px-4 shadow");
            },
            b =>
            {
                b.AddClass(button, "p-1 shadow");
            });

            b.If(b.Get(props, x => x.Enabled), b =>
            {
                //var href = b.Concat(b.RootPath(), b.Get(props, x => x.Href));
                var href = b.Get(props, x => x.Href);
                b.SetAttr(link, Html.href, b.Get(props, x => x.Href));

                var bgClass = b.Switch(
                    b.Get(props, x => x.Style),
                    b => b.Const(""),
                    (Button.Style.Primary, b => b.Const("bg-sky-500")),
                    (Button.Style.Danger, b => b.Const("bg-red-500")),
                    (Button.Style.Light, b => b.Const("bg-white")));

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
            return link;
        }
    }
}
