namespace Metapsi.Ionic;

public class PickerButton 
{
    /// <summary>
    /// string
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string role { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public object cssClass { get; set; }
    /// <summary>
    /// (value: any) =&gt; boolean | void
    /// </summary>
    public object handler { get; set; }
}
