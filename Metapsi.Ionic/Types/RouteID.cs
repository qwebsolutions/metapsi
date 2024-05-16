namespace Metapsi.Ionic;

public class RouteID 
{
    /// <summary>
    /// string
    /// </summary>
    public string id { get; set; }
    /// <summary>
    /// HTMLElement | undefined
    /// </summary>
    public DynamicObject element { get; set; }
    /// <summary>
    /// { [key: string]: any }
    /// </summary>
    public DynamicObject @params { get; set; }
}
