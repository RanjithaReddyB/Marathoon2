using System;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class containing DateTime helper methods.
    /// </summary>
    public static class DateTimeConverter
    {
        /// <summary>
        /// Helper method that converts local time to eastern time (-5:00:00 offset from UTC).
        /// </summary>
        /// <param name="currentTime">Current local time</param>
        /// <returns>Eastern time</returns>
        public static DateTime ToEasternTime(this DateTime currentTime)
        {
            //TimeZone localZone = TimeZone.CurrentTimeZone;
            //DateTime baseUTC = new DateTime(2000, 1, 1);
            //DateTime localTime = localZone.ToLocalTime(baseUTC);
            //TimeSpan offset = localZone.GetUtcOffset(localTime);
            //return currentTime.AddHours(-offset.Hours - 5);

            // This logic doesn't work if the date was pulled from a database in a
            // different time zone than the executing code - this is mainly designed
            // to convert from central so we'll just add an hour instead
            return currentTime.AddHours(1);
        }

        /// <summary>
        /// Helper method to round a time span.
        /// </summary>
        /// <param name="timeSpan">Time span</param>
        /// <param name="roundingInterval">Rounding interval</param>
        /// <returns>Rounded time span</returns>
        public static TimeSpan Round(this TimeSpan timeSpan, TimeSpan roundingInterval)
        {
            if (roundingInterval == TimeSpan.Zero)
                return timeSpan;

            return new TimeSpan(Convert.ToInt64(Math.Round(
                timeSpan.Ticks / (decimal)roundingInterval.Ticks)) * roundingInterval.Ticks);
        }

        /// <summary>
        /// Helper method to round a date.
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="roundingInterval">Rounding interval</param>
        /// <returns>Rounded date</returns>
        public static DateTime Round(this DateTime date, TimeSpan roundingInterval)
        {
            if (roundingInterval == TimeSpan.Zero)
                return date;

            return new DateTime((date - DateTime.MinValue).Round(roundingInterval).Ticks);
        }

        /// <summary>
        /// Helper method to truncate a date.
        /// </summary>
        /// <param name="date">Date</param>
        /// <param name="truncationInterval">Truncation interval</param>
        /// <returns>Truncated date</returns>
        public static DateTime Truncate(this DateTime date, TimeSpan truncationInterval)
        {
            if (truncationInterval == TimeSpan.Zero) 
                return date;

            return date.AddTicks(-(date.Ticks % truncationInterval.Ticks));
        }
    }
}
