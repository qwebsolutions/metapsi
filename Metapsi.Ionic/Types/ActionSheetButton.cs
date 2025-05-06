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
    public string role { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string icon { get; set; }
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
    public object htmlAttributes { get; set; }
    /// <summary>
    /// () =&gt; boolean | void | Promise&lt;boolean | void&gt;
    /// </summary>
    public object handler { get; set; }
    /// <summary>
    /// T
    /// </summary>
    public object data { get; set; }
    /// <summary>
    /// / When `disabled` is `true` the action sheet button will not be interactive. Note that buttons with a 'cancel' role cannot be disabled as that would make it difficult for users to dismiss the action sheet./
    /// boolean
    /// </summary>
    public bool disabled { get; set; }
}
