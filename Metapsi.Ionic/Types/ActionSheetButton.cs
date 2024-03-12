namespace Metapsi.Ionic;

public class ActionSheetButton 
{
    /// <summary>
    /// string
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// LiteralUnion&lt;'cancel' | 'destructive' | 'selected', string&gt;
    /// </summary>
    public object role { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string icon { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public object cssClass { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public object htmlAttributes { get; set; }
    /// <summary>
    /// () =&gt; boolean | void | Promise&lt;boolean | void&gt;
    /// </summary>
    public object handler { get; set; }
    /// <summary>
    /// T
    /// </summary>
    public object data { get; set; }
}
