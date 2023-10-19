using System.Globalization;
using NetCoreCv.Core.Models;

namespace NetCoreCv.Core.Helpers;

public static class DateUtils
{
    /// <summary>
    /// TODO: Double check this isn't a threading concern.
    /// </summary>
    private static readonly CultureInfo Provider = new("en-GB");

    public static DateTime GetDateTime(string date) => DateTime.ParseExact(date, "MM/yyyy", Provider);

    public static IEnumerable<DateRange> GetDateRanges(string[] dates)
    {
        var hasRemainder = dates.Length % 2 != 0;
        var dateRanges = new List<DateRange>();

        if (hasRemainder) throw new InvalidDataException("Dates need to be provided in multiples of 2.");

        for (int i = 0; i < dates.Length - 1; i++)
        {
            int j = i + 1;

            dateRanges.Add(new DateRange() { StartDate = GetDateTime(dates[i]), EndDate = GetDateTime(dates[j]) });
        }

        return dateRanges;
    }
}