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
            builder.AppendLine(GetHtml(model).ToHtml());
            return builder.ToString();
        }
    }

    public static class Template
    {
        public static IHtmlNode BlankPage(
            Action<HeadTag, BodyTag> build)
        {
            var html = new HtmlTag("html");
            html.AddAttribute("lang", "en");
            var head = html.AddChild(new HeadTag());
            var metaCharset = head.AddChild(new HtmlTag("meta"));
            metaCharset.AddAttribute("charset", "utf-8");

            var metaViewport = head.AddChild(new HtmlTag("meta"));
            metaViewport.AddAttribute("name", "viewport");
            metaViewport.AddAttribute("content", "width=device-width,initial-scale=1");


            var body = html.AddChild(new BodyTag());

            build(head, body);

            return html;
        }
    }
}
