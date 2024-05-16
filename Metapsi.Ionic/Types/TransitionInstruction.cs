namespace Metapsi.Ionic;

public class TransitionInstruction 
{
    /// <summary>
    /// NavOptions | undefined | null
    /// </summary>
    public DynamicObject opts { get; set; }
    /// <summary>
    /// / The index where to insert views. A negative number means at the end /
    /// number
    /// </summary>
    public int insertStart { get; set; }
    /// <summary>
    /// any[]
    /// </summary>
    public System.Collections.Generic.List<DynamicObject> insertViews { get; set; }
    /// <summary>
    /// ViewController
    /// </summary>
    public ViewController removeView { get; set; }
    /// <summary>
    /// / The index of the first view to remove. A negative number means the last view /
    /// number
    /// </summary>
    public int removeStart { get; set; }
    /// <summary>
    /// / The number of view to remove. A negative number means all views from removeStart /
    /// number
    /// </summary>
    public int removeCount { get; set; }
    /// <summary>
    /// (hasCompleted: boolean) =&gt; void
    /// </summary>
    public DynamicObject resolve { get; set; }
    /// <summary>
    /// (rejectReason: string) =&gt; void
    /// </summary>
    public DynamicObject reject { get; set; }
    /// <summary>
    /// TransitionDoneFn
    /// </summary>
    public TransitionDoneFn done { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool leavingRequiresTransition { get; set; }
    /// <summary>
    /// boolean
    /// </summary>
    public bool enteringRequiresTransition { get; set; }
}
