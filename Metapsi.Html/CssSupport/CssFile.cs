using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi.Html;

public class CssFile : IResource
{
    public CssFile(string package, string fileName)
    {
        this.Package = package;
        this.FileName = fileName;
    }

    public string Package { get; }
    public string FileName { get; }

    public List<CssFragment> Fragments { get; set; } = new();

    public List<string> ResolvesDependencyIds => Fragments.Select(x => x.DependencyId).ToList();

    public CssFile Add(CssFragment cssFragment)
    {
        if (!Fragments.Any(x => x.DependencyId == cssFragment.DependencyId))
        {
            this.Fragments.Add(cssFragment);
        }
        return this;
    }

    public string ToCss(ToCssOptions toCssOptions = null)
    {
        CssBuilder cssBuilder = new CssBuilder();
        foreach (var cssFragment in Fragments)
        {
            cssFragment.Builder(cssBuilder);
        }

        return cssBuilder.Rule.ToCss(toCssOptions);
    }
}
