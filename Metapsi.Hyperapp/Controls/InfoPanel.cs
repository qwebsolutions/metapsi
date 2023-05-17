using Metapsi.Syntax;
using System;

namespace Metapsi.Hyperapp
{
    public static partial class Panel
    {
        public enum Style
        {
            Info,
            Ok,
            Warning,
            Error
        }
    }

    public static partial class Controls
    {
        public static Var<HyperNode> InfoPanel(
            this BlockBuilder b,
            Var<Panel.Style> style,
            Func<BlockBuilder, Var<HyperNode>> header,
            Func<BlockBuilder, Var<HyperNode>> body)
        {
            string basePanelStyle = "flex flex-col rounded-md p-4 shadow-md border border-gray-100 ";
            var infoPanelStyle = b.Const(basePanelStyle + "bg-white text-gray-800");
            var errorPanelStyle = b.Const(basePanelStyle + "bg-red-500 text-white");
            var warningPanelStyle = b.Const(basePanelStyle + "bg-yellow-500 text-white");
            var okPanelStyle = b.Const(basePanelStyle + "bg-green-500 text-white");

            Var<bool> isOk = b.AreEqual(style, b.Const(Panel.Style.Ok));
            Var<bool> isError = b.AreEqual(style, b.Const(Panel.Style.Error));
            Var<bool> isWarning = b.AreEqual(style, b.Const(Panel.Style.Warning));

            var panel = b.Div(infoPanelStyle);

            b.If(isOk, b => b.SetAttr(panel, Html.@class, okPanelStyle));
            b.If(isError, b => b.SetAttr(panel, Html.@class, errorPanelStyle));
            b.If(isWarning, b => b.SetAttr(panel, Html.@class, warningPanelStyle));

            var headerDiv = b.Add(panel, b.Div("pb-2"));
            b.Add(headerDiv, header(b));

            var contentDiv = b.Add(panel, b.Div("justify-self-end"));
            b.Add(contentDiv, body(b));

            return panel;
        }

        public static Var<HyperNode> InfoPanel(
            this BlockBuilder b,
            Panel.Style style,
            string header,
            string body,
            Var<string> infoLink = null)
        {
            string info = "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 24 24\" fill=\"currentColor\">\r\n  <path fill-rule=\"evenodd\" d=\"M2.25 12c0-5.385 4.365-9.75 9.75-9.75s9.75 4.365 9.75 9.75-4.365 9.75-9.75 9.75S2.25 17.385 2.25 12zm8.706-1.442c1.146-.573 2.437.463 2.126 1.706l-.709 2.836.042-.02a.75.75 0 01.67 1.34l-.04.022c-1.147.573-2.438-.463-2.127-1.706l.71-2.836-.042.02a.75.75 0 11-.671-1.34l.041-.022zM12 9a.75.75 0 100-1.5.75.75 0 000 1.5z\" clip-rule=\"evenodd\" />\r\n</svg>\r\n";

            return b.InfoPanel(
                b.Const(style),
                b =>
                {
                    if (infoLink == null)
                    {
                        return b.Bold(header);
                    }
                    else
                    {
                        var headerDiv = b.Div("flex flex-row");
                        var serviceNameSpan = b.Add(headerDiv, b.Bold(header));
                        b.AddClass(serviceNameSpan, "w-full");

                        var a = b.Add(headerDiv, b.Node("a", "flex flex-row justify-end text-gray-100 w-6 h-6 hover:text-white"));
                        b.SetAttr(a, Html.href, infoLink);
                        b.Add(a, b.Svg(info, "w-full h-full"));
                        return headerDiv;
                    }
                },
                b => b.Text(b.Const(body)));
        }

        public static Var<HyperNode> PanelsContainer(this BlockBuilder b, int columns)
        {
            // tw import
            // lg:grid-cols-4
            return b.Div($"grid grid-cols-1 lg:grid-cols-{columns} gap-4");
        }

        public static Var<HyperNode> Bold(this BlockBuilder b, string text)
        {
            var r = b.Text(text);
            b.AddClass(r, "font-bold");
            return r;
        }

        public static Var<HyperNode> Bold(this BlockBuilder b, Var<string> text)
        {
            var r = b.Text(text);
            b.AddClass(r, "font-bold");
            return r;
        }
    }
}

