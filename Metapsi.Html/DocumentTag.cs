using Metapsi.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Metapsi.Html;

public class ToHtmlOptions
{
    public ToJavaScriptOptions ToJavaScriptOptions { get; set; } = new ToJavaScriptOptions();
    public int Indent { get; set; } = 2;
}

public class HtmlDocument : HtmlTag
{
    public HtmlDocument() : base("html")
    {
        this.Children.Add(this.Head);
        this.Children.Add(this.Body);
    }

    public HtmlTag Head { get; } = new HtmlTag("head");
    public HtmlTag Body { get; } = new HtmlTag("body");

    public override string ToHtml(ToHtmlOptions options = null)
    {
        if (options == null) options = new ToHtmlOptions();
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("<!DOCTYPE html>");
        stringBuilder.AppendLine(base.ToHtml(options));
        return stringBuilder.ToString();
    }
}