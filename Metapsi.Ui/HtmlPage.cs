using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metapsi
{
    public abstract class HtmlPage<TDataModel> : IPageTemplate<TDataModel>
    {
        public abstract IHtmlNode GetHtmlTree(TDataModel dataModel);

        public string Render(TDataModel model)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<!DOCTYPE html>");
            builder.AppendLine(GetHtmlTree(model).ToHtml());
            return builder.ToString();
        }
    }
}
