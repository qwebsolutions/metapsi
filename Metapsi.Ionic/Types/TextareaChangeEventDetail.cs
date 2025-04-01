using Metapsi.Html;

namespace Metapsi.Ionic;

public class TextareaChangeEventDetail 
{
    /// <summary>
    /// string | null
    /// </summary>
    public DynamicObject value { get; set; }
    /// <summary>
    /// Event
    /// </summary>
    public Event @event { get; set; }
}
