using Metapsi.Syntax;

namespace Metapsi.Hyperapp
{
    public static class Browser
    {
        public static Var<bool> IsSafari(this BlockBuilder b)
        {
            return b.CallExternal<bool>(nameof(Browser), nameof(IsSafari));
        }
    }
}
