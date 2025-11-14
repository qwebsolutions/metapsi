namespace Metapsi.Html;

public static partial class Intl
{
    /// <summary>
    /// The Intl.RelativeTimeFormat object enables language-sensitive relative time formatting.
    /// </summary>
    public interface RelativeTimeFormat
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public class RelativeTimeFormatOptions
    {
        /// <summary>
        /// The locale matching algorithm to use. Possible values are "lookup" and "best fit"; the default is "best fit". For information about this option, see Locale identification and negotiation.
        /// </summary>
        public string localeMatcher { get; set; }

        /// <summary>
        /// The style of the formatted relative time.Possible values are:
        /// <para>"long" (default) E.g., "in 1 month"</para>
        /// <para>"short" E.g., "in 1 mo." </para>
        /// <para>"narrow" E.g., "in 1 mo.". The narrow style could be similar to the short style for some locales.</para>
        /// </summary>
        public string style { get; set; }

        /// <summary>
        /// Whether to use numeric values in the output. Possible values are "always" and "auto"; the default is "always". When set to "auto", the output may use more idiomatic phrasing such as "yesterday" instead of "1 day ago".
        /// </summary>
        public string numeric { get; set; }
    }
}