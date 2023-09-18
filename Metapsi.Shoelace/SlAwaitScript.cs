using Metapsi.Ui;
using System.Collections.Generic;
using System.Linq;

namespace Metapsi.Shoelace;

public class SlAwaitScript : BaseTag
{
    public HashSet<string> SlTags { get; set; } = new();

    public override HtmlTag GetTag()
    {
        var scriptTag = new HtmlTag("script");
        scriptTag.SetAttribute("type", "module");

        var whenDefinedArray = string.Join(",\n", SlTags.Select(x => $"customElements.whenDefined('{x}')"));

        scriptTag.AddChild(new HtmlText()
        {
            Text = $" await Promise.allSettled([{whenDefinedArray}]);document.body.classList.add('ready');console.log('document ready');"
        });

        return scriptTag;
    }
}
