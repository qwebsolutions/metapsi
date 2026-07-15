namespace Metapsi.Html;

public class ExternalStylesheetDependency : IDependency, IDependencyDefaultImport
{
    public string StylesheetPath { get; set; }

    public string DependencyId => StylesheetPath;

    public void Import(HtmlBuilder b)
    {
        b.HeadAppend(
            b.HtmlLink(
                b =>
                {
                    b.SetRel("stylesheet");
                    b.SetHref(StylesheetPath);
                }));
    }
}