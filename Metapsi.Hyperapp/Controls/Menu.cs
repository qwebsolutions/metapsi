using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Hyperapp
{
    public static class Menu
    {
        public class Props
        {
            public List<Metapsi.Ui.Menu.Entry> Entries { get; set; }
            public string ActiveCode { get; set; }
        }

        public static Var<HyperNode> Render(this BlockBuilder b, Var<Props> props)
        {
            var isEmptyString = b.Def<string,bool>(Native.IsEmpty);
            var missingIcons = b.Get(props, isEmptyString, (props, empty) => props.Entries.Any(x => empty(x.SvgIcon)));
            
            var selectedCode = b.Get(props, x => x.ActiveCode);
            var menuDiv = b.Node("div", "flex flex-col p-4 h-full border-r shadow-md group");

            var entries = b.Get(props, x => x.Entries);
            b.Foreach(entries, (b, menuEntry) =>
            {
                var link = b.Add(menuDiv, b.Node("a", "flex flex-row items-center p-4 rounded hover:bg-gray-100 text-clip whitespace-nowrap overflow-hidden"));

                b.If(b.HasValue(b.Get(menuEntry, x => x.SvgIcon)), b =>
                {
                    var iconBackground = b.Add(link, b.Div("bg-sky-600 rounded-full w-6 h-6 flex items-center justify-center"));
                    var iconContainer = b.Add(iconBackground, b.Div("w-4 h-4 text-gray-50"));
                    b.SetInnerHtml(iconContainer, b.Get(menuEntry, x => x.SvgIcon));
                });

                var isActive = b.AreEqual(b.Get(menuEntry, x => x.Code), selectedCode);
                b.If(isActive,
                    b => b.AddClass(link, "text-sky-600"),
                    b => b.AddClass(link, "text-gray-800"));
                b.SetAttr(link, Html.href, b.Get(menuEntry, x => x.Href));

                var menuLabel = b.Add(link, b.Text(b.Get(menuEntry, x => x.Label)));

                // If general hover behavior
                b.If(missingIcons, b =>
                {
                    // Layout if this particular item is missing icon
                    b.If(b.IsEmpty(b.Get(menuEntry, x => x.SvgIcon)), b =>
                    {
                        b.AddClass(menuLabel, "w-48 pl-8");
                    },
                    b =>
                    {
                        b.AddClass(menuLabel, "w-48 pl-2");
                    });
                },
                b =>
                {
                    b.AddClass(menuLabel, "group-hover:pl-4 opacity-0 w-0 group-hover:w-48 group-hover:opacity-100 transition-all delay-1000");
                });
            });

            return menuDiv;
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> Menu(this BlockBuilder v,Var<Menu.Props> entries)
        {
            return v.Call(Hyperapp.Menu.Render, entries);
        }
    }
}

