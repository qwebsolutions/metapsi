namespace Metapsi.Ionic;

public class RouterEventDetail 
{
    /// <summary>
    /// string | null
    /// </summary>
    public DynamicObject from { get; set; }
    /// <summary>
    /// string | null
    /// </summary>
    public DynamicObject redirectedFrom { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string to { get; set; }
}
