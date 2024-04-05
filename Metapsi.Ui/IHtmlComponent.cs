using System.Collections.Generic;

namespace Metapsi.Ui;

/// <summary>
/// A component is a complex control that needs additional operations when used, like importing external js/css etc
/// </summary>
public interface IHtmlComponent
{
    void Attach(DocumentTag document, IHtmlElement parentNode);
}