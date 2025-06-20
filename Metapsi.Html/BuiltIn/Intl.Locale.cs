using Metapsi.Syntax;

namespace Metapsi.Html;

/// <summary>
/// The Intl namespace object contains several constructors as well as functionality common to the internationalization constructors and other language sensitive functions.
/// </summary>
public static partial class Intl
{
    /// <summary>
    /// The Intl.Locale object is a standard built-in property of the Intl object that represents a Unicode locale identifier.
    /// </summary>
    public interface Locale
    {

    }

    /// <summary>
    /// An object that contains configuration for the Locale. Option values here take priority over extension keys in the locale identifier
    /// </summary>
    public class LocaleOptions
    {
        /// <summary>
        /// The language. Any syntactically valid string following the unicode_language_subtag grammar (2–3 or 5–8 letters) is accepted, but the implementation only recognizes certain kinds.
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// The script. Any syntactically valid string following the unicode_script_subtag grammar (4 letters) is accepted, but the implementation only recognizes certain kinds.
        /// </summary>
        public string script { get; set; }

        /// <summary>
        /// The region. Any syntactically valid string following the unicode_region_subtag grammar (either 2 letters or 3 digits) is accepted, but the implementation only recognizes certain kinds.
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// The calendar. Any syntactically valid string following the type grammar (one or more segments of 3–8 alphanumerals, joined by hyphens) is accepted, but the implementation only recognizes certain kinds, which are listed in Intl.supportedValuesOf().
        /// </summary>
        public string calendar { get; set; }

        /// <summary>
        /// The collation. Any syntactically valid string following the type grammar is accepted, but the implementation only recognizes certain kinds, which are listed in Intl.supportedValuesOf().
        /// </summary>
        public string collation { get; set; }


        /// <summary>
        /// The numbering system. Any syntactically valid string following the type grammar is accepted, but the implementation only recognizes certain kinds, which are listed in Intl.supportedValuesOf().
        /// </summary>
        public string numberingSystem { get; set; }

        /// <summary>
        /// The case-first sort option. Possible values are "upper", "lower", or "false".
        /// </summary>
        public string caseFirst { get; set; }

        /// <summary>
        /// The hour cycle. Possible values are "h23", "h12", "h11", or the practically unused "h24", which are explained in Intl.Locale.prototype.getHourCycles
        /// </summary>
        public string hourCycle { get; set; }

        /// <summary>
        /// The numeric sort option. A boolean.
        /// </summary>
        public bool numeric { get; set; }
    }

    public static Var<Locale> NewIntlLocale(this SyntaxBuilder b, Var<string> tag, Var<LocaleOptions> options)
    {
        return b.New<Locale>(tag, options);
    }
}