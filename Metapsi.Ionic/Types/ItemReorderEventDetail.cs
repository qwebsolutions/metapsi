namespace Metapsi.Ionic;

public class ItemReorderEventDetail 
{
    /// <summary>
    /// number
    /// </summary>
    public int from { get; set; }
    /// <summary>
    /// number
    /// </summary>
    public int to { get; set; }
    /// <summary>
    /// (data?: boolean | any[]) =&gt; any
    /// </summary>
    public object complete { get; set; }
}
