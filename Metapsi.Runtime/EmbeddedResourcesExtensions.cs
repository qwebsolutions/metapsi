using System.IO;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class EmbeddedResourcesExtensions
    {
        /// <summary>
        /// Finds resource ENDING with shortFileName
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="shortFileName"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static async Task<string> GetEmbeddedTextFile(this System.Reflection.Assembly assembly, string shortFileName)
        {
            var allResources = assembly.GetManifestResourceNames();

            foreach (var resourceName in allResources)
            {
                if (resourceName.EndsWith(shortFileName))
                {
                    var stream = assembly.GetManifestResourceStream(resourceName);
                    StreamReader streamReader = new StreamReader(stream);
                    var articleContent = await streamReader.ReadToEndAsync();

                    return articleContent;
                }
            }

            throw new FileNotFoundException($"Cannot find embedded {shortFileName}");
        }

        /// <summary>
        /// Finds resource ENDING with shortFileName
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="shortFileName"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static async Task<byte[]> GetEmbeddedBinaryFile(this System.Reflection.Assembly assembly, string shortFileName)
        {
            var allResources = assembly.GetManifestResourceNames();

            foreach (var resourceName in allResources)
            {
                if (resourceName.EndsWith(shortFileName))
                {
                    var stream = assembly.GetManifestResourceStream(resourceName);

                    using (var ms = new MemoryStream())
                    {
                        await stream.CopyToAsync(ms);
                        return ms.ToArray();
                    }
                }
            }

            throw new FileNotFoundException($"Cannot find embedded {shortFileName}");
        }
    }
}