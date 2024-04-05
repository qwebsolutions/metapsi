using Metapsi.Ui;
using System;
using System.Linq;

namespace Metapsi.Shoelace;

public class SlComponent : WebComponent
{
    public SlComponent(string tagName) : base(tagName) { }

    protected override void OnAttach(DocumentTag documentTag, IHtmlElement parentNode)
    {
        base.OnAttach(documentTag, parentNode);
        documentTag.Head.AddChild(new LinkTag("stylesheet", $"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/themes/light.css"));
        documentTag.Head.AddChild(new ExternalScriptTag($"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/{Cdn.ImportPaths[this.GetTag().Tag]}", "module"));
        documentTag.Head.AddChild(BasePathScript($"https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/"));
    }

    public static ScriptTag BasePathScript(string path)
    {
        return new ScriptTag($"import {{ setBasePath }} from 'https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@{Cdn.Version}/cdn/utilities/base-path.js';\r\n  setBasePath('{path}');\r\n", "module");
    }
}