using Metapsi.Html;

namespace Metapsi.Ionic;

public class InputChangeEventDetail 
{
    /// <summary>
    /// string | null
    /// </summary>
    public object value { get; set; }
    /// <summary>
    /// Event
    /// </summary>
    public Event @event { get; set; }
}
