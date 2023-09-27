using System.Collections.Generic;

namespace Metapsi.Tutorial;

public class MenuEntry
{
    public string Title { get; set; }
    public string Url { get; set; }
    public List<MenuEntry> Children { get; set; } = new();
}

public class Route
{
    public string Code { get; set; } = string.Empty;
    public string ParentCode { get; set; } = string.Empty;
    public int OrderIndex { get; set; }
    public string Title { get; set; } = string.Empty;
    public string DocCode { get; set; } = string.Empty;
}

public class Doc
{
    public string Type { get; set; }
    public string Code { get; set; }
    public string Title { get; set; }
}

public class DocSlice
{
    public string ParentDoc { get; set; }
    public int OrderIndex { get; set; }
    public string SliceType { get; set; }
    public string SliceCode { get; set; }
}



public class Header
{
    public string Code { get; set; }
    public string Content { get; set; }
}

public class Paragraph
{
    public string Code { get; set; }
    public string Content { get; set; }
}