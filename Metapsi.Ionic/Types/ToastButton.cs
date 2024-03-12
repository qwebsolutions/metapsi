namespace Metapsi.Ionic;

public class ToastButton 
{
    /// <summary>
    /// string
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string icon { get; set; }
    /// <summary>
    /// 'start' | 'end'
    /// </summary>
    public object side { get; set; }
    /// <summary>
    /// LiteralUnion&lt;'cancel', string&gt;
    /// </summary>
    public object role { get; set; }
    /// <summary>
    /// / @deprecated Use the toast button's CSS Shadow Parts instead./
    /// string | string[]
    /// </summary>
    public object cssClass { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public object htmlAttributes { get; set; }
    /// <summary>
    /// () =&gt; boolean | void | Promise&lt;boolean | void&gt;
    /// </summary>
    public object handler { get; set; }
}
