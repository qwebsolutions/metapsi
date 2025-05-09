using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace Metapsi;

public static partial class MetadataExtensions
{
    public static async Task LoadMetadataResources(HashSet<Metapsi.Syntax.Metadata> metadata)
    {
        var embeddedFilesMetadata = metadata.Where(x => x.Key == "embedded-file");
        var assemblies = embeddedFilesMetadata.Select(x => x.Data.Single(x => x.Key == "source-assembly")).Select(x => x.Value).Distinct();

        foreach (var assemblyName in assemblies)
        {
            await EmbeddedFiles.AddAssembly(assemblyName);
        }
    }
}
