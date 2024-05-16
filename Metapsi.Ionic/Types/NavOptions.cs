namespace Metapsi.Ionic;

public class NavOptions : RouterOutletOptions 
{
    /// <summary>
    /// boolean
    /// </summary>
    public bool progressAnimation { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool updateURL { get; set; }
    /// <summary>
    /// FrameworkDelegate
    /// </summary>
    public FrameworkDelegate @delegate { get; set; }
    /// <summary>
    /// (enteringEl: HTMLElement) =&gt; Promise&lt;any&gt;
    /// </summary>
    public DynamicObject viewIsReady { get; set; }
}
