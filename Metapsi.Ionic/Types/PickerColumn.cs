namespace Metapsi.Ionic;

public class PickerColumn 
{
    /// <summary>
    /// string
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string align { get; set; }
    /// <summary>
    /// / Changing this value allows the initial value of a picker column to be set./
    /// number
    /// </summary>
    public int selectedIndex { get; set; }
    /// <summary>
    /// number
    /// </summary>
    public int prevSelected { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string prefix { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string suffix { get; set; }
    /// <summary>
    /// PickerColumnOption[]
    /// </summary>
    public System.Collections.Generic.List<PickerColumnOption> options { get; set; }
    /// <summary>
    /// string | string[]
    /// </summary>
    public object cssClass { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string columnWidth { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string prefixWidth { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string suffixWidth { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string optionsWidth { get; set; }
}
