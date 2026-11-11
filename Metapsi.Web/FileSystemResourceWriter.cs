using Metapsi.Html;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metapsi.Web;

/// <summary>
/// Stores built resources on disk in a readable layout and serves them from there.
/// <para>Layout under the base folder:</para>
/// <para>store/{package}/{version}/{fileName} - the resource content. Safe to inspect or delete manually.</para>
/// <para>allowed/{sha256(package|version|fileName)}.txt - written only by the server; contains the path of the content, relative to store/.</para>
/// <para>A request only ever influences the hash, never a path, so it cannot reach files outside the store.
/// Allowed entries outlive deployments, so older versions stay servable for as long as their files exist.</para>
/// </summary>
public class FileSystemResourceWriter : IResourceWriter
{
    private class StoreResult
    {
        public StoreResult(string filePath, WebResource webResource)
        {
            this.FilePath = filePath;
            this.WebResource = webResource;
        }

        /// <summary>Null if the content could not be stored</summary>
        public string FilePath { get; }
        public WebResource WebResource { get; }
    }

    private static readonly char[] invalidPathChars = new char[] { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };

    private readonly WebResourceProvider webResourceProvider;
    private readonly string storeFolder;
    private readonly string allowedFolder;

    // Concurrent requests for the same missing resource share a single build
    private readonly ConcurrentDictionary<string, Lazy<Task<StoreResult>>> pendingBuilds = new();

    public FileSystemResourceWriter(
        WebResourceProvider webResourceProvider,
        string baseFilePath)
    {
        this.webResourceProvider = webResourceProvider;
        var baseFullPath = Path.GetFullPath(baseFilePath);
        this.storeFolder = Path.Combine(baseFullPath, "store");
        this.allowedFolder = Path.Combine(baseFullPath, "allowed");
        Directory.CreateDirectory(this.storeFolder);
        Directory.CreateDirectory(this.allowedFolder);
    }

    public async Task WriteAsync(string package, string version, string fileName, CfHttpResponse response, IResourceResolver resourceResolver)
    {
        var key = CreateKey(package, version, fileName);

        var storedFilePath = TryGetStoredFile(key);
        if (storedFilePath != null)
        {
            await WriteFileResponse(response, fileName, storedFilePath);
            return;
        }

        // Only registered resources, at their current version, can create new entries
        var webResourceBuilder = webResourceProvider.GetWebResourceBuilder(package, fileName);
        if (webResourceBuilder == null)
        {
            await response.SetStatusCode(404);
            return;
        }

        var pending = pendingBuilds.GetOrAdd(
            key,
            k => new Lazy<Task<StoreResult>>(() => BuildAndStore(k, webResourceBuilder, version, resourceResolver)));

        StoreResult result;
        try
        {
            result = await pending.Value;
        }
        finally
        {
            // Once finished, the entry is on disk (or storing failed and the next request may retry)
            pendingBuilds.TryRemove(key, out _);
        }

        if (result == null)
        {
            // Version mismatch, for example a request for a version this instance cannot build
            await response.SetStatusCode(404);
            return;
        }

        if (result.FilePath != null)
        {
            await WriteFileResponse(response, fileName, result.FilePath);
        }
        else
        {
            response.SetContentTypeHeader(HttpExtensions.GetMimeTypeForFileExtension(fileName));
            response.SetCacheControlHeader("public,max-age=31536000");
            await result.WebResource.WriteAsync(response.BodyStream());
        }
    }

    private async Task<StoreResult> BuildAndStore(
        string key,
        WebResourceBuilder webResourceBuilder,
        string version,
        IResourceResolver resourceResolver)
    {
        var webResource = webResourceBuilder.BuildResource(resourceResolver);
        if (webResource.Version != version)
        {
            return null;
        }

        try
        {
            // The path comes from the registered resource and the built version, never from the request
            var relativePath = CreateRelativeStorePath(webResourceBuilder.Resource.Package, webResource.Version, webResourceBuilder.Resource.FileName);
            var filePath = ToStoreFullPath(relativePath);
            if (filePath == null)
            {
                throw new InvalidOperationException($"Resource path {relativePath} is outside of the store folder");
            }

            if (!System.IO.File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                await WriteAtomically(filePath, webResource.WriteAsync);
            }

            // The entry is written after the content, so it never points to an incomplete file
            var entryPath = Path.Combine(this.allowedFolder, key + ".txt");
            await WriteAtomically(entryPath, async stream =>
            {
                var bytes = Encoding.UTF8.GetBytes(relativePath);
                await stream.WriteAsync(bytes, 0, bytes.Length);
            });

            return new StoreResult(filePath, webResource);
        }
        catch (Exception ex)
        {
            // Storing is best effort. The built resource can still be served from memory
            Console.Error.WriteLine($"Could not store resource {key}: {ex}");
            return new StoreResult(null, webResource);
        }
    }

    private string TryGetStoredFile(string key)
    {
        var entryPath = Path.Combine(this.allowedFolder, key + ".txt");
        if (!System.IO.File.Exists(entryPath))
        {
            return null;
        }

        var relativePath = System.IO.File.ReadAllText(entryPath, Encoding.UTF8).Trim();
        var filePath = ToStoreFullPath(relativePath);

        // The entry was edited by hand, or its file was cleaned up. Either way, rebuild if possible
        if (filePath == null || !System.IO.File.Exists(filePath))
        {
            return null;
        }

        return filePath;
    }

    private static async Task WriteFileResponse(CfHttpResponse response, string fileName, string filePath)
    {
        response.SetContentTypeHeader(HttpExtensions.GetMimeTypeForFileExtension(fileName));
        response.SetCacheControlHeader("public,max-age=31536000");
        response.SetContentLengthHeader(new FileInfo(filePath).Length);
        await response.WriteFileAsync(filePath);
    }

    /// <summary>
    /// Writes to a temporary file first, then moves it into place, so a file is either complete or missing
    /// </summary>
    private static async Task WriteAtomically(string filePath, Func<Stream, Task> write)
    {
        var tempPath = filePath + "." + Guid.NewGuid().ToString("N") + ".tmp";
        try
        {
            using (var stream = new FileStream(tempPath, FileMode.CreateNew, FileAccess.Write, FileShare.None, 81920, FileOptions.Asynchronous))
            {
                await write(stream);
            }

            if (!System.IO.File.Exists(filePath))
            {
                System.IO.File.Move(tempPath, filePath);
            }
        }
        catch (IOException) when (System.IO.File.Exists(filePath))
        {
            // Another process stored the same content in the meantime
        }
        finally
        {
            if (System.IO.File.Exists(tempPath))
            {
                System.IO.File.Delete(tempPath);
            }
        }
    }

    /// <summary>
    /// Resolves a store-relative path and ensures it stays inside the store folder
    /// </summary>
    private string ToStoreFullPath(string relativePath)
    {
        if (string.IsNullOrEmpty(relativePath))
        {
            return null;
        }

        var segments = new List<string>() { this.storeFolder };
        segments.AddRange(relativePath.Split('/'));
        var fullPath = Path.GetFullPath(Path.Combine(segments.ToArray()));
        var storeRoot = this.storeFolder.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar) + Path.DirectorySeparatorChar;
        if (!fullPath.StartsWith(storeRoot, StringComparison.Ordinal))
        {
            return null;
        }

        return fullPath;
    }

    /// <summary>
    /// Builds a readable, '/' separated path. Names come from registered resources, so this only
    /// replaces characters that are not valid in file names on every platform
    /// </summary>
    private static string CreateRelativeStorePath(string package, string version, string fileName)
    {
        var segments = new List<string>() { package, version };
        segments.AddRange(fileName.Split('/'));
        return string.Join("/", segments.Select(SanitizeSegment));
    }

    private static string SanitizeSegment(string segment)
    {
        if (string.IsNullOrEmpty(segment) || segment == "." || segment == "..")
        {
            return "_";
        }

        var chars = segment.Select(c => c < 32 || invalidPathChars.Contains(c) ? '_' : c).ToArray();
        var sanitized = new string(chars);

        // Windows drops trailing dots and spaces
        if (sanitized.EndsWith(".") || sanitized.EndsWith(" "))
        {
            sanitized += "_";
        }

        return sanitized;
    }

    private static string CreateKey(string package, string version, string fileName)
    {
        using (var sha = SHA256.Create())
        {
            var hash = sha.ComputeHash(Encoding.UTF8.GetBytes($"{package}|{version}|{fileName}"));
            var hex = new StringBuilder(hash.Length * 2);
            foreach (var b in hash)
            {
                hex.Append(b.ToString("x2"));
            }
            return hex.ToString();
        }
    }
}