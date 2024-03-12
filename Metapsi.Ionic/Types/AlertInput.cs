namespace Metapsi.Ionic;

public class AlertInput 
{
    /// <summary>
    /// TextFieldTypes | 'checkbox' | 'radio' | 'textarea'
    /// </summary>
    public object type { get; set; }
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
    public object value { get; set; }
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
    public object handler { get; set; }
    /// <summary>
    /// string | number
    /// </summary>
    public object min { get; set; }
    /// <summary>
    /// string | number
    /// </summary>
    public object max { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public object cssClass { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public object attributes { get; set; }
    /// <summary>
    /// number
    /// </summary>
    public int tabindex { get; set; }
}
