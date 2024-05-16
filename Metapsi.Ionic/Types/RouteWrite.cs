namespace Metapsi.Ionic;

public class RouteWrite 
{
    /// <summary>
    /// boolean
    /// </summary>
    public bool changed { get; set; }
    /// <summary>
    /// HTMLElement | undefined
    /// </summary>
    public DynamicObject element { get; set; }
    /// <summary>
    /// () =&gt; void | Promise&lt;void&gt;
    /// </summary>
    public DynamicObject markVisible { get; set; }
}
