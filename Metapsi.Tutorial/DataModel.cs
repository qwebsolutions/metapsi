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

}

public class CodeSample
{
    public string SampleId { get; set; } = string.Empty;
    public string SampleLabel { get; set; } = string.Empty;
    public string CSharpModel { get; set; } = " ";
    public string CSharpCode { get; set; } = " ";
    public string JsonModel { get; set; } = "{}";
}

