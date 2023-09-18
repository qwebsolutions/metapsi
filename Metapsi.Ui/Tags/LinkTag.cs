namespace Metapsi.Ui;

public record LinkTag(string rel, string href) : DistinctTag
{
    public override HtmlTag GetTag()
    {
        return new HtmlTag("link")
            .SetAttribute("rel", rel)
            .SetAttribute("href", href);
    }
}

public static class LinkTagExtensions
{
    public static void AddStylesheet(this HeadTag into, string href)
    {
        if (!href.StartsWith("http"))
        {
            // If it is not absolute path, make it absolute
            href = $"/{href}".Replace("//", "/");
        }

        into.AddChild(new LinkTag("stylesheet", href));
    }

    public static void AddModuleStylesheet(this HeadTag into)
    {
        var assembly = System.Reflection.Assembly.GetCallingAssembly();
        var cssName = $"{assembly.GetName().Name}.css";

        into.AddStylesheet(cssName);
    }
}
