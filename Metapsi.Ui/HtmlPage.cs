using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metapsi
{
    public abstract class HtmlPage<TDataModel> : IPageTemplate<TDataModel>
    {
        public abstract IHtmlNode GetHtml(TDataModel dataModel);

        public string Render(TDataModel model)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<!DOCTYPE html>");
            BuildHtml(builder, GetHtml(model));
            return builder.ToString();
        }

        private void BuildHtml(StringBuilder builder, IHtmlNode htmlNode)
        {
            switch (htmlNode)
            {
                case HtmlTag htmlTag:
                    HtmlWriters.HtmlTag(builder, htmlTag, BuildHtml);
                    break;
                case HtmlText textNode:
                    HtmlWriters.HtmlText(builder, textNode);
                    break;
            }
        }
    }

    public static class Template
    {
        public static IHtmlNode BlankPage(
            Action<HtmlTag> buildHead = null,
            Action<HtmlTag> buildBody = null)
        {
            var html = new HtmlTag("html");
            html.AddAttribute("lang", "en");
            var head = html.AddChild(new HtmlTag("head"));
            var metaCharset = head.AddChild(new HtmlTag("meta"));
            metaCharset.AddAttribute("charset", "utf-8");

            var metaViewport = head.AddChild(new HtmlTag("meta"));
            metaViewport.AddAttribute("name", "viewport");
            metaViewport.AddAttribute("content", "width=device-width,initial-scale=1");

            if (buildHead != null)
            {
                buildHead(head);
            }

            var body = html.AddChild(new HtmlTag("body"));

            if (buildBody != null)
            {
                buildBody(body);
            }

            return html;
        }
    }
}
