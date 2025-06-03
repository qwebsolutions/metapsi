namespace Metapsi.Shoelace;

/// <summary>
/// 
/// </summary>
public interface SlSlideChangeDetail
{
    public int index { get; }
    public SlCarouselItem slide { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlRequestCloseDetail
{
    /// <summary>
    /// 'close-button' | 'keyboard' | 'overlay'
    /// </summary>
    public string source { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlErrorDetail
{
    /// <summary>
    /// 
    /// </summary>
    public int status { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlSelectDetail
{
    /// <summary>
    /// 
    /// </summary>
    public SlMenuItem item { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlMutationDetail
{
    /// <summary>
    /// 
    /// </summary>
    public System.Collections.Generic.List<Metapsi.Html.MutationRecord> mutationList { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlHoverDetail
{
    /// <summary>
    ///  The phase property indicates when hovering starts, moves to a new value, or ends
    /// <para>'start' | 'move' | 'end'</para>
    /// </summary>
    public string phase { get; }
    /// <summary>
    /// The value property tells what the rating’s value would be if the user were to commit to the hovered value. 
    /// </summary>
    public decimal value { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlResizeDetail
{
    /// <summary>
    /// 
    /// </summary>
    public System.Collections.Generic.List<Metapsi.Html.ResizeObserverEntry> entries { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlTabShowDetail
{
    /// <summary>
    /// 
    /// </summary>
    public string name { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlTabHideDetail
{
    /// <summary>
    /// 
    /// </summary>
    public string name { get; }
}

/// <summary>
/// 
/// </summary>
public interface SlSelectionChangeDetail
{
    /// <summary>
    /// 
    /// </summary>
    public System.Collections.Generic.List<SlTreeItem> selection { get; }
}