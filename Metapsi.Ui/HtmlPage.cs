using Metapsi.Ui;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metapsi
{
    public abstract class HtmlPage<TDataModel> : IPageTemplate<TDataModel>
    {
        public abstract void FillHtml(TDataModel dataModel, DocumentTag document);

        public string Render(TDataModel model)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<!DOCTYPE html>");
            var document = new DocumentTag();
            FillHtml(model, document);
            document.AttachComponents();
            builder.AppendLine(document.ToHtml());
            return builder.ToString();
        }
    }
}
