using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Browser
    {
        public static Var<bool> IsSafari(this SyntaxBuilder b)
        {
            b.AddEmbeddedResourceMetadata(typeof(Browser).Assembly, "Browser.js");
            var isSafari = b.ImportName<System.Func<bool>>("Browser.js", "IsSafari");
            return b.Call(IsSafari);
        }
    }
}
