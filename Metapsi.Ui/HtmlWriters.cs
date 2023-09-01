﻿using Metapsi.Ui;
using System;
using System.Text;

namespace Metapsi
{
    public static class HtmlWriters
    {
        public static void HtmlTag(StringBuilder builder, HtmlTag htmlTag, Action<StringBuilder, IHtmlNode> writeChild)
        {
            builder.Append($"<{htmlTag.Tag}");
            foreach (var attribute in htmlTag.Attributes)
            {
                builder.Append($" {attribute.Key}=\"{attribute.Value}\"");
            }
            builder.Append(">");
            foreach (var child in htmlTag.Children)
            {
                writeChild(builder, child);
            }
            builder.AppendLine($"</{htmlTag.Tag}>");
        }

        public static void HtmlText(StringBuilder builder, HtmlText htmlText)
        {
            builder.Append(htmlText.Text);
        }
    }
}
