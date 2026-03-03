namespace Metapsi.Html;

/// <summary>
/// 
/// </summary>
public interface ResizeObserverSize
{
    /// <summary>
    /// The length of the observed element's border box in the block dimension. For boxes with a horizontal writing-mode, this is the vertical dimension, or height; if the writing-mode is vertical, this is the horizontal dimension, or width.
    /// </summary>
    decimal blockSize { get; }

    /// <summary>
    /// The length of the observed element's border box in the inline dimension. For boxes with a horizontal writing-mode, this is the horizontal dimension, or width; if the writing-mode is vertical, this is the vertical dimension, or height.
    /// </summary>
    decimal inlineSize { get; }
}