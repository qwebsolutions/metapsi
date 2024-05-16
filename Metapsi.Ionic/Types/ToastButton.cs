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
    public DynamicObject side { get; set; }
    /// <summary>
    /// LiteralUnion&lt;'cancel', string&gt;
    /// </summary>
    public DynamicObject role { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public DynamicObject htmlAttributes { get; set; }
    /// <summary>
    /// () =&gt; boolean | void | Promise&lt;boolean | void&gt;
    /// </summary>
    public DynamicObject handler { get; set; }
}
