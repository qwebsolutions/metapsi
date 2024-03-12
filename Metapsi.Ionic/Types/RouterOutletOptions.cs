namespace Metapsi.Ionic;

public class RouterOutletOptions 
{
    /// <summary>
    /// boolean
    /// </summary>
    public bool animated { get; set; }
    /// <summary>
    /// AnimationBuilder
    /// </summary>
    public AnimationBuilder animationBuilder { get; set; }
    /// <summary>
    /// number
    /// </summary>
    public int duration { get; set; }
    /// <summary>
    /// string
    /// </summary>
    public string easing { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool showGoBack { get; set; }
    /// <summary>
    /// NavDirection
    /// </summary>
    public NavDirection direction { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool deepWait { get; set; }
    /// <summary>
    /// Mode
    /// </summary>
    public Mode mode { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool keyboardClose { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool skipIfBusy { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool progressAnimation { get; set; }
}
