namespace Metapsi.Html;

public class ExternalJavaScriptDependency : IDependency
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

//public class CustomElementDependency : IDependency
//{
//    public string Package { get; set; }
//    public string Version { get; set; }
//    public string Tag { get; set; }

//    public string DependencyId => $"custom-element/{Package}/version/{Tag}";
//}