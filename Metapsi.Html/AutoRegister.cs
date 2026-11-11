namespace Metapsi.Html;

internal class AutoRegister : IAutoRegisterModule
{
    public void Register(WebResourceProvider webResourceProvider)
    {
        var assembly = typeof(AutoRegister).Assembly;
        foreach (var rn in assembly.GetManifestResourceNames())
        {
            webResourceProvider.RegisterEmbeddedResource(EmbeddedResource.Hashed(assembly, rn));
        }

        webResourceProvider.RegisterEmbeddedResource(Metapsi.Syntax.Core.MetapsiCoreJs);
        webResourceProvider.RegisterEmbeddedResource(Metapsi.Syntax.Core.LinqJsResource);
        webResourceProvider.RegisterEmbeddedResource(Metapsi.Syntax.Core.UuidJs);
    }
}
