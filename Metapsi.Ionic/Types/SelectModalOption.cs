namespace Metapsi.Ionic;

public class SelectModalOption 
{
    /// <summary>
    /// string
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string value { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool disabled { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool @checked { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public string cssClass { get; set; }
    /// <summary>
    /// (value: any) =&gt; boolean | void | { [key: string]: any }
    /// </summary>
    public DynamicObject handler { get; set; }
}
