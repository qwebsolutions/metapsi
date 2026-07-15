namespace Metapsi.Html;

public class ExternalJavaScriptDependency : IDependency, IDependencyDefaultImport
{
    public string JsPath { get; set; }
    public bool IsModule { get; set; }

    public string DependencyId => JsPath;

    public void Import(HtmlBuilder b)
    {
        b.HeadAppend(
            b.HtmlScript(
                b =>
                {
                    b.SetSrc(JsPath);
                    if (IsModule)
                    {
                        b.SetTypeModule();
                    }
                }));
    }
}