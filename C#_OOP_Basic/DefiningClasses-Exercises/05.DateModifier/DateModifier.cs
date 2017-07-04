
using System;
using System.Globalization;

public static class DateModifier
{
    public static long GetDaysDifferent(string firstDate, string secondDate)
    {
        var first = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var secnd = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((first - secnd).Days);
    }
}

