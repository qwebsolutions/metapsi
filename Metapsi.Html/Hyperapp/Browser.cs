using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Browser
    {
        public static readonly EmbeddedResource BrowserJs = EmbeddedResource.Hashed(typeof(Browser).Assembly, "Browser.js");

        public static Var<bool> IsSafari(this SyntaxBuilder b)
        {
            var browserJsPath = b.ResolvePath(BrowserJs);
            var isSafari = b.ImportName<System.Func<bool>>(browserJsPath, "IsSafari");
            return b.Call(IsSafari);
        }
    }
}
