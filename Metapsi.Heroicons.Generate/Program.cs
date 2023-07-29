// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


GenerateIconClass("optimized\\24\\outline", "Outline");
GenerateIconClass("optimized\\24\\solid", "Solid");
GenerateIconClass("optimized\\20\\solid", "Mini");

static void GenerateIconClass(string inputFolder, string className)
{
    var csName = $"..\\Metapsi.Heroicons\\{className}.cs";

    var builder = new System.Text.StringBuilder();

    builder.AppendLine("namespace Metapsi.Heroicons;");

    builder.AppendLine($"public static class {className}");
    builder.AppendLine("{");

    foreach(var iconFile in System.IO.Directory.EnumerateFiles("optimized\\24\\outline"))
    {
        string iconName = string.Concat(System.IO.Path.GetFileNameWithoutExtension(iconFile).Split("-").Select(x=> Capitalize(x)));

        var content = System.IO.File.ReadAllText(iconFile);
        content = content.Replace("\"", "\\\"").Replace("\n", string.Empty).Replace("\r", string.Empty);

        builder.AppendLine($"    public static string {iconName} = \"{content}\";");
    }

    builder.AppendLine("}");

    System.IO.File.WriteAllText(csName, builder.ToString());
}

static string Capitalize(string s)
{
    if(s.Length>1)
    {
        return s.Substring(0,1).ToUpper()+s.Substring(1);
    }
    else return s.ToUpper();
}