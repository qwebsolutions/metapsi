using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Browser
    {
        public static Var<bool> IsSafari(this SyntaxBuilder b)
        {
            var browserJsPath = b.ResolvePath(new HashedEmbeddedResource()
            {
                Assembly = typeof(Browser).Assembly,
                LogicalName = "Browser.js"
            });
            var isSafari = b.ImportName<System.Func<bool>>(browserJsPath, "IsSafari");
            return b.Call(IsSafari);
        }
    }
}
