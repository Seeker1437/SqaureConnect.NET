using System;
using System.Globalization;

namespace SquareConnect.Util
{
    internal static class DateHelper
    {
        public static string ToIso(DateTime? dateTime)
        {
            if (dateTime == null) return null;

            return ((DateTime)dateTime).ToString("o");
        }

        public static DateTime FromIso(string isoTime)
        {
            return DateTime.Parse(isoTime, null, DateTimeStyles.RoundtripKind);
        }
    }
}
