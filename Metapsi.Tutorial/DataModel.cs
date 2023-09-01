namespace Metapsi.Tutorial;

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

public class CodeSample
{
    public string SampleId { get; set; } = string.Empty;
    public string SampleLabel { get; set; } = string.Empty;
    public string CSharpModel { get; set; } = " "; // because model is not always mandatory & code sample span collapses if there is no text
    public string CSharpCode { get; set; } = string.Empty; // because code is always mandatory & compile button is disabled if there's none
    public string JsonModel { get; set; } = "{}";
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