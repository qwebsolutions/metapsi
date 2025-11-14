namespace Metapsi.Html;

/// <summary>
/// The AnimationTimeline interface of the Web Animations API represents the timeline of an animation. This interface exists to define timeline features, inherited by other timeline types:
/// <para>DocumentTimeline</para>
/// <para>ScrollTimeline</para>
/// <para>ViewTimeline</para>
/// </summary>
public interface AnimationTimeline
{
    /// <summary>
    /// The currentTime read-only property of the Web Animations API's AnimationTimeline interface returns the timeline's current time in milliseconds, or null if the timeline is inactive.
    /// </summary>
    decimal currentTime { get; }
}
