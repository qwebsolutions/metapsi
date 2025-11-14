using System;

namespace Metapsi
{
    public static class MetapsiDateTime
    {
        public static string Roundtrip(this DateTime dateTime)
        {
            return dateTime.ToString("O", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string JsRoundtrip(this DateTime dateTime)
        {
            return dateTime.ToString("s");
        }

        public static DateTime FromRoundTrip(string roundtripDate)
        {
            return DateTime.Parse(roundtripDate, null, System.Globalization.DateTimeStyles.RoundtripKind);
        }

        public static string ItalianFormat(this DateTime dateTime)
        {
            return dateTime.ToString("G", new System.Globalization.CultureInfo("it-IT"));
        }
    }
}