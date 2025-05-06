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
    public object element { get; set; }
    /// <summary>
    /// () =&gt; void | Promise&lt;void&gt;
    /// </summary>
    public object markVisible { get; set; }
}
