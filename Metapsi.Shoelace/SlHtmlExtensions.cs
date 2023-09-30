using Metapsi.Syntax;
using Metapsi.Ui;
using System.Linq;

namespace Metapsi.Shoelace;

public static class SlHtmlExtensions
{
    public static void StartHidden(this DocumentTag document)
    {
        const string hiddenStyle = "\r\nbody {\r\n    opacity: 0;\r\n}\r\n\r\n    body.ready {\r\n        opacity: 1;\r\n        transition: .25s opacity;\r\n    }";

        var style = document.Head.Descendants().OfType<StyleTag>().SingleOrDefault(x => x.StyleName == nameof(hiddenStyle));

        if (style == null)
        {
            var styleTag = document.Head.AddChild(new StyleTag()
            {
                StyleName = nameof(hiddenStyle),
            });

            styleTag.AddSelector("body").AddProperty("opacity", "0");
            styleTag.AddSelector("body.ready")
                .AddProperty("opacity", "1")
                .AddProperty("transition", ".25s opacity;");
        }

        document.GetSlAwaitWhenDefinedScript().ThenActions.Add(ShowOnLoaded);
    }

    private static void ShowOnLoaded(BlockBuilder b)
    {
        b.CallExternal("Metapsi.Shoelace", "ShowBodyWhenDefined");
    }
}
