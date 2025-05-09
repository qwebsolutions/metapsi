using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Metapsi;

public static class EmbeddedFiles
{
    public interface ILoader
    {

    }

    public static ILoader Load { get; set; }

    static int updating = 0;

    private static ConcurrentDictionary<string, EmbeddedFile> embeddedResources = new();

    private static HashSet<string> assemblyName = new HashSet<string>();

    private static TaskQueue assembliesQueue { get; set; } = new TaskQueue();

    public static Task AddAssembly(string assemblyName)
    {
        Interlocked.Exchange(ref updating, 1);
        return assembliesQueue.Enqueue(async () =>
        {
            var added = EmbeddedFiles.assemblyName.Add(assemblyName);
            if (added)
            {
                var assembly = System.Reflection.Assembly.Load(assemblyName);

                foreach (var resourceName in assembly.GetManifestResourceNames())
                {
                    var stream = assembly.GetManifestResourceStream(resourceName);
                    if (stream == null)
                    {
                        throw new Exception($"Embedded resource {resourceName} not found");
                    }
                    var embeddedReference = CreateEmbeddedReference(assembly, stream, resourceName);
                    var lowerTrimmed = resourceName.ToLowerInvariant().Trim('/');
                    embeddedResources[lowerTrimmed] = embeddedReference;
                }
            }

            Interlocked.Exchange(ref updating, 0);
        });
    }


    public static async Task AddAssembly(Assembly assembly)
    {
        await AddAssembly(assembly.GetName().Name);
    }

    public static async Task<EmbeddedFile> GetAsync(string fileName)
    {
        // The file name is probably already lowercase, as it's generally requested by the web server
        fileName = fileName.ToLowerInvariant().Trim('/');

        // GetAsync should use the queue only as a last resort, otherwise all HTTP requests become sequential
        embeddedResources.TryGetValue(fileName, out var embeddedFile);

        if (embeddedFile != null)
            return embeddedFile;

        if (updating == 1)
        {
            return await assembliesQueue.Enqueue(async () =>
            {
                embeddedResources.TryGetValue(fileName, out EmbeddedFile existingStaticResource);

                if (existingStaticResource == null)
                {
                    return null;
                }

                return existingStaticResource;
            });
        }

        else return null;
    }

    private static EmbeddedFile CreateEmbeddedReference(Assembly assembly, Stream stream, string resourceName)
    {
        var lowercaseFileName = resourceName.ToLowerInvariant();

        var embeddedFile = new EmbeddedFile()
        {
            Assembly = assembly,
            LowerCaseFileName = lowercaseFileName,
            OriginalCaseResourceName = resourceName
        };

        using (var ms = new MemoryStream())
        {
            stream.CopyTo(ms);
            embeddedFile.Content = ms.ToArray();
        }
        embeddedFile.Hash = Hash(embeddedFile.Content);

        return embeddedFile;
    }


    public class EmbeddedFile
    {
        public string OriginalCaseResourceName { get; set; }
        public string LowerCaseFileName { get; set; }
        public Assembly Assembly { get; set; }
        public byte[] Content { get; set; }
        public string Hash { get; set; }
    }

    public static string Hash(byte[] bytes)
    {
        return System.IO.Hashing.XxHash32.HashToUInt32(bytes).ToString();
    }

    public static string Hash(string content)
    {
        return Hash(System.Text.Encoding.UTF8.GetBytes(content));
    }

    public static List<EmbeddedFile> GetAll()
    {
        return embeddedResources.Select(x => x.Value).ToList();
    }

    public static List<string> GetAllPaths()
    {
        return GetAll().Select(x => x.LowerCaseFileName).ToList();
    }
}