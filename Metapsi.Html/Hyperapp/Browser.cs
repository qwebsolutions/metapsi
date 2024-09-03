using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Browser
    {
        public static Var<bool> IsSafari(this SyntaxBuilder b)
        {
            StaticFiles.Add(typeof(Browser).Assembly, "Browser.js");
            return b.CallExternal<bool>(nameof(Browser), nameof(IsSafari));
        }
    }
}
