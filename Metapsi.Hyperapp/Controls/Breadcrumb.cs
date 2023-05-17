using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static partial class Controls
    {
        public static Var<HyperNode> Breadcrumb(
            this BlockBuilder b,
            Var<List<Breadcrumb.Link>> links,
            Var<string> currentPage,
            System.Action<Modifier<Metapsi.Hyperapp.Breadcrumb.Props>> optional = null)
        {
            var props = b.NewObj<Metapsi.Hyperapp.Breadcrumb.Props>(optional);
            b.Set(props, x => x.Links, links);
            b.Set(props, x => x.CurrentPage, currentPage);

            return Metapsi.Hyperapp.Breadcrumb.RenderBreadcrumb(b, props);
        }
    }

    public static partial class Breadcrumb
    {
        public class Link
        {
            public string Href { get; set; } = string.Empty;
            public string Label { get; set; } = string.Empty;
        }

        public class Props
        {
            public HyperNode Separator { get; set; }
            public List<Link> Links { get; set; } = new();
            public string CurrentPage { get; set; } = string.Empty;
            public string LinkCss { get; set; }
            public string CurrentPageCss { get; set; }
        }

        public static Var<HyperNode> RenderBreadcrumb(this BlockBuilder b, Var<Props> props)
        {
            b.SetIfEmpty<Props, string>(props, x => x.LinkCss, b.Const(""));
            b.SetIfEmpty<Props, string>(props, x => x.CurrentPageCss, b.Const(""));
            b.SetIfEmpty(props, x => x.Separator, b.Text("»"));

            var container = b.Div("flex flex-row flex-wrap gap-4 items-center");

            b.Foreach(b.Get(props, x => x.Links), (b, item) =>
            {
                var link = b.Add(container, b.Node("a", b.Get(props, x => x.LinkCss)));
                b.Add(link, b.TextNode(b.Get(item, x => x.Label)));
                b.SetAttr(link, Html.href, b.Get(item, x => x.Href));
                
                b.Add(container, b.Clone(b.Get(props, x => x.Separator)));
            });

            b.Add(container, b.Text(b.Get(props, x=>x.CurrentPage), b.Get(props, x => x.CurrentPageCss)));

            return container;
        }
    }
}

