using System.Collections.Generic;

namespace Metapsi.Ui;

public interface IHtmlComponent
{
    void Attach(DocumentTag document, IHtmlElement parentNode);
}