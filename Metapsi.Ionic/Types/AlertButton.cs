namespace Metapsi.Ionic;

public class AlertButton 
{
    /// <summary>
    /// string
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// LiteralUnion&lt;'cancel' | 'destructive', string&gt;
    /// </summary>
    public string role { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public string cssClass { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public DynamicObject htmlAttributes { get; set; }
    /// <summary>
    /// (value: any) =&gt; AlertButtonOverlayHandler | Promise&lt;AlertButtonOverlayHandler&gt;
    /// </summary>
    public DynamicObject handler { get; set; }
}
