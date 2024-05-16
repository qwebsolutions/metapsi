namespace Metapsi.Ionic;

public class AlertInput 
{
    /// <summary>
    /// TextFieldTypes | 'checkbox' | 'radio' | 'textarea'
    /// </summary>
    public DynamicObject type { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string placeholder { get; set; }
    /// <summary>
    /// any
    /// </summary>
    public DynamicObject value { get; set; }
    /// <summary>
    /// / The label text to display next to the input, if the input type is `radio` or `checkbox`./
    /// string
    /// </summary>
    public string label { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool @checked { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool disabled { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// (input: AlertInput) =&gt; void
    /// </summary>
    public DynamicObject handler { get; set; }
    /// <summary>
    /// string | number
    /// </summary>
    public DynamicObject min { get; set; }
    /// <summary>
    /// string | number
    /// </summary>
    public DynamicObject max { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public string cssClass { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public DynamicObject attributes { get; set; }
    /// <summary>
    /// number
    /// </summary>
    public int tabindex { get; set; }
}
