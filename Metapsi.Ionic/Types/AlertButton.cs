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
    public object role { get; set; }
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
    /// (value: any) =&gt; AlertButtonOverlayHandler | Promise&lt;AlertButtonOverlayHandler&gt;
    /// </summary>
    public object handler { get; set; }
}
