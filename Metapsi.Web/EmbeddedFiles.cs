using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Metapsi;

public static class EmbeddedFiles
{
    private static ConcurrentDictionary<string, EmbeddedFile> embeddedResources = new();

    public class EmbeddedFile
    {
        public string OriginalCaseResourceName { get; set; }
        public string LowerCaseFileName { get; set; }
        public Assembly Assembly { get; set; }
        public byte[] Content { get; set; }
        public string Hash { get; set; }
    }

    private static TaskQueue<ConcurrentDictionary<string, EmbeddedFile>> taskQueue = new(embeddedResources);

    public static async Task AddAllAsync(Assembly assembly, string pattern = null)
    {
        foreach (var resourceName in assembly.GetManifestResourceNames())
        {
            bool include = true;
            if (pattern != null)
            {
                if (!resourceName.Contains(pattern))
                {
                    include = false;
                }
            }
            if (include)
            {
                await AddAsync(assembly, resourceName);
            }
        }
    }

    public static void AddAll(Assembly assembly, string pattern = null)
    {
        foreach (var resourceName in assembly.GetManifestResourceNames())
        {
            bool include = true;
            if (pattern != null)
            {
                if (!resourceName.Contains(pattern))
                {
                    include = false;
                }
            }
            if (include)
            {
                Add(assembly, resourceName);
            }
        }
    }

    public static async Task AutoAdd(string byPrefix = "Metapsi")
    {
        foreach (Assembly assembly in System.AppDomain.CurrentDomain.GetAssemblies())
        {
            if (assembly.GetName().Name.StartsWith(byPrefix))
            {
                await AddAllAsync(assembly);
            }
        }
    }

    public static async Task<EmbeddedFile> AddAsync(Assembly assembly, string resourceName)
    {
        return await taskQueue.Enqueue(async (embeddedResources) =>
        {
            var embeddedFile = GetEmbeddedFileReference(assembly, resourceName);
            embeddedResources[embeddedFile.LowerCaseFileName] = embeddedFile;
            return embeddedFile;
        });
    }

    public static async Task AddAsync(EmbeddedFile embeddedFile)
    {
        await taskQueue.Enqueue(async (embeddedResources) =>
        {
            embeddedResources[embeddedFile.LowerCaseFileName] = embeddedFile;
        });
    }

    public static EmbeddedFile GetEmbeddedFileReference(Assembly assembly, string resourceName)
    {
        var lowercaseFileName = resourceName.ToLowerInvariant();

        embeddedResources.TryGetValue(lowercaseFileName, out EmbeddedFile embeddedFile);

        if (embeddedFile != null)
        {
            if (embeddedFile.Assembly != assembly)
            {
                Console.Error.WriteLine($"Embedded resource conflict! {lowercaseFileName} is included in multiple assemblies!");
                throw new Exception($"Embedded resource conflict! {lowercaseFileName} is included in multiple assemblies!");
            }
            return embeddedFile;
        }

        var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            throw new Exception($"Embedded resource {resourceName} not found");
        }

        embeddedFile = new EmbeddedFile()
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

    public static string Hash(byte[] bytes)
    {
        return System.IO.Hashing.XxHash32.HashToUInt32(bytes).ToString();
    }

    public static string Hash(string content)
    {
        return Hash(System.Text.Encoding.UTF8.GetBytes(content));
    }

    public static async Task<EmbeddedFile> GetAsync(string fileName)
    {
        // The file name is probably already lowercase, as it's generally requested by the web server
        fileName = fileName.ToLower();

        return await taskQueue.Enqueue(async embeddedResources =>
        {
            embeddedResources.TryGetValue(fileName, out EmbeddedFile existingStaticResource);

            if (existingStaticResource == null)
            {
                return null;
            }

            return existingStaticResource;
        });
    }

    // This might get executed multiple times after application start, when first requesting a page referencing this resource
    // It's a byproduct of needing the view to be sync

    public static EmbeddedFile Add(Assembly assembly, string resourceName)
    {
        var embeddedFile = GetEmbeddedFileReference(assembly, resourceName);
        embeddedResources[embeddedFile.LowerCaseFileName] = embeddedFile;
        return embeddedFile;
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