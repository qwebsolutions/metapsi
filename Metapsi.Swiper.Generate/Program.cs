﻿using Metapsi.WebComponentGenerator;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var version = args[0];

        var projectFolder = Utils.SearchUpfolder(System.IO.Directory.GetCurrentDirectory(), "Metapsi.Swiper");

        if (string.IsNullOrEmpty(projectFolder))
        {
            Console.WriteLine("Project folder Metapsi.Swiper not found");
            return;
        }

        var registryTarGzPath = $"https://registry.npmjs.org/swiper/-/swiper-{version}.tgz";

        var tgzStream = await new HttpClient().GetStreamAsync(registryTarGzPath);

        var embeddedFilesFolder = System.IO.Path.Combine(projectFolder, "embedded");
        if (System.IO.Directory.Exists(embeddedFilesFolder))
        {
            System.IO.Directory.Delete(embeddedFilesFolder, true);
        }

        ExtractEmbeddedFiles(tgzStream, name =>
        {
            if (name.EndsWith(".mjs"))
            {
                var relativePath = name.Replace("package/", string.Empty);
                return System.IO.Path.Combine(embeddedFilesFolder, relativePath);
            }

            return string.Empty;
        },
        embeddedFilesFolder);

        var targetFileContent = EmbeddedResourcesGenerator.GetEmbeddedFilesTargetFile(
            embeddedFilesFolder,
            resource =>
            {
                resource.LogicalName = $"swiper@{version}/" + resource.LogicalName;
            });

        var targetFilePath = System.IO.Path.Combine(projectFolder, "embedded.target");

        await System.IO.File.WriteAllTextAsync(targetFilePath, targetFileContent);

        var csProjPath = System.IO.Path.Combine(projectFolder, "Metapsi.Swiper.csproj");
        var projectDescription = $"Use Swiper Element {version} with Metapsi for both server-side and client-side web pages (https://swiperjs.com/element)";
        Utils.SetCsProjDescription(csProjPath, projectDescription);

        StringBuilder cdnVersionBuilder = new StringBuilder();
        cdnVersionBuilder.AppendLine("// Autogenerated by Metapsi.Swiper.Generate. Do not edit!");
        cdnVersionBuilder.AppendLine("namespace Metapsi.Swiper;");
        cdnVersionBuilder.AppendLine();
        cdnVersionBuilder.AppendLine("public static partial class Cdn");
        cdnVersionBuilder.AppendLine("{");
        cdnVersionBuilder.AppendLine($"    public const string Version = \"{version}\";");
        cdnVersionBuilder.AppendLine("}");

        await System.IO.File.WriteAllTextAsync(System.IO.Path.Combine(projectFolder, $"Cdn.cs"), cdnVersionBuilder.ToString());
    }

    public static void ExtractEmbeddedFiles(
        Stream fromTarGzStream,
        Func<string, string> extractToPath,
        string intoEmbeddedFilesFolder)
    {
        using GZipStream gz = new(fromTarGzStream, CompressionMode.Decompress, leaveOpen: true);

        using var reader = new TarReader(gz, leaveOpen: true);

        while (reader.GetNextEntry() is TarEntry entry)
        {
            var outPath = extractToPath(entry.Name);
            if (!string.IsNullOrWhiteSpace(outPath))
            {
                var folder = Path.GetDirectoryName(outPath);
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }

                entry.ExtractToFile(outPath, overwrite: false);
            }
        }
    }
}