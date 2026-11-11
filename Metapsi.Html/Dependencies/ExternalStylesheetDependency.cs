namespace Metapsi.Html;

public class EmbeddedStylesheetDependency : IDependency, IDependencyDefaultImport
{
    private readonly EmbeddedResource embeddedResource;

    public EmbeddedStylesheetDependency(EmbeddedResource embeddedResource)
    {
        this.embeddedResource = embeddedResource;
    }

    public string DependencyId => embeddedResource.FileName;

    public void Import(HtmlBuilder b)
    {
        var path = b.ResolvePath(this.embeddedResource);
        b.HeadAppend(
            b.HtmlLink(
                b =>
                {
                    b.SetRel("stylesheet");
                    b.SetHref(path);
                }));
    }
}