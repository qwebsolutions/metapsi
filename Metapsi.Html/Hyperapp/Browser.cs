using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Browser
    {
        public static Var<bool> IsSafari(this SyntaxBuilder b)
        {
            var resource = b.AddEmbeddedResourceMetadata(typeof(Browser).Assembly, "Browser.js");
            var isSafari = b.ImportName<System.Func<bool>>(resource, "IsSafari");
            return b.Call(IsSafari);
        }
    }
}
