using Metapsi.Ui;
using System;
using System.Linq;

namespace Metapsi.Shoelace;

public class SlComponent : HtmlComponent
{
    public SlComponent(string tagName) : base(tagName) { }

    protected override void OnAttach(DocumentTag documentTag, IHtmlElement parentNode)
    {
        documentTag.AddShoelace();
    }
}