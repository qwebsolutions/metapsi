using Metapsi.Html;

namespace Metapsi.Web;

public class AutoRegister : IAutoRegisterModule
{
    public void Register(WebResourceProvider webResourceProvider)
    {
        var assembly = typeof(AutoRegister).Assembly;
        foreach (var rn in assembly.GetManifestResourceNames())
        {
            webResourceProvider.RegisterEmbeddedResource(EmbeddedResource.Hashed(assembly, rn));
        }
    }
}