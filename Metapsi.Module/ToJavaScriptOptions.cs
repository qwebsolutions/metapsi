using System.Linq;

namespace Metapsi.Syntax
{
    public class ToJavaScriptOptions
    {
        public System.Func<Module, ResourceMetadata, string> ResolveResource { get; set; } = (module, resource) =>
        {
            return resource.GetDefaultHttpPath();
        };

        public int IndentLevel { get; set; }
        public bool OutputTypes { get; set; }

        //private static string GetEmbeddedFileHashMetadata(Module moduleDefinition, string fileName)
        //{
        //    var isKnownResource = moduleDefinition.Metadata.Contains(new Metadata()
        //    {
        //        Type = "embedded-resource-name",
        //        Value = fileName.ToLowerInvariant()
        //    });

        //    if (!isKnownResource)
        //        return string.Empty;

        //    var allEmbeddedResources = moduleDefinition.Metadata.Where(x => x.Type == "embedded-resource");
        //    foreach (var resource in allEmbeddedResources)
        //    {
        //        var r = Metapsi.Serialize.FromJson<ResourceMetadata>(resource.Value);
        //        if (r.RelativePath == fileName)
        //            return r.FileHash;
        //    }

        //    return string.Empty;
        //}
    }
}