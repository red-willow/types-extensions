using System;

namespace RedWillow.Extensions
{
    public static class DateAndTimeExtensions
    {
        #region Extensions that return TimeSpan

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of days.
        /// </summary>
        /// <returns>TimeSpan of the specified number of days.</returns>
        public static TimeSpan Days(this int i)
        {
            return new TimeSpan(i, 0, 0, 0);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of days.
        /// </summary>
        /// <returns>TimeSpan of the specified number of days.</returns>
        public static TimeSpan Days(this short s)
        {
            return new TimeSpan(Convert.ToInt32(s), 0, 0, 0);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of hours.
        /// </summary>
        /// <returns>TimeSpan of the specified number of hours.</returns>
        public static TimeSpan Hours(this int i)
        {
            return new TimeSpan(i, 0, 0);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of hours.
        /// </summary>
        /// <returns>TimeSpan of the specified number of hours.</returns>
        public static TimeSpan Hours(this short s)
        {
            return new TimeSpan(Convert.ToInt32(s), 0, 0);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of minutes.
        /// </summary>
        /// <returns>TimeSpan of the specified number of minutes.</returns>
        public static TimeSpan Minutes(this int i)
        {
            return new TimeSpan(0, i, 0);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of minutes.
        /// </summary>
        /// <returns>TimeSpan of the specified number of minutes.</returns>
        public static TimeSpan Minutes(this short s)
        {
            return new TimeSpan(0, Convert.ToInt32(s), 0);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of seconds.
        /// </summary>
        /// <returns>TimeSpan of the specified number of seconds.</returns>
        public static TimeSpan Seconds(this int i)
        {
            return new TimeSpan(0, 0, i);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of seconds.
        /// </summary>
        /// <returns>TimeSpan of the specified number of seconds.</returns>
        public static TimeSpan Seconds(this short s)
        {
            return new TimeSpan(0, 0, Convert.ToInt32(s));
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of milliseconds.
        /// </summary>
        /// <returns>TimeSpan of the specified number of milliseconds.</returns>
        public static TimeSpan Milliseconds(this int i)
        {
            return new TimeSpan(0, 0, 0, 0, i);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of milliseconds.
        /// </summary>
        /// <returns>TimeSpan of the specified number of milliseconds.</returns>
        public static TimeSpan Milliseconds(this short s)
        {
            return new TimeSpan(0, 0, 0, 0, Convert.ToInt32(s));
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of ticks.
        /// </summary>
        /// <returns>TimeSpan of the specified number of ticks.</returns>
        public static TimeSpan Ticks(this long l)
        {
            return new TimeSpan(l);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of ticks.
        /// </summary>
        /// <returns>TimeSpan of the specified number of ticks.</returns>
        public static TimeSpan Ticks(this int i)
        {
            return new TimeSpan(i);
        }

        /// <summary>
        /// Converts this number into a TimeSpan of the same number of ticks.
        /// </summary>
        /// <returns>TimeSpan of the specified number of ticks.</returns>
        public static TimeSpan Ticks(this short s)
        {
            return new TimeSpan(s);
        }

        #endregion

        #region Extensions that return DateTime

        /// <summary>
        /// Adds this TimeSpan to the current local DateTime and returns the resulting
        /// DateTime.
        /// </summary>
        /// <returns>DateTime resulting from adding the TimeSpan to the current local DateTime.</returns>
        public static DateTime FromNow(this TimeSpan ts)
        {
            return DateTime.Now + ts;
        }

        /// <summary>
        /// Adds this TimeSpan to the current UTC DateTime and returns the resulting
        /// DateTime.
        /// </summary>
        /// <returns>DateTime resulting from adding the TimeSpan to the current UTC DateTime.</returns>
        public static DateTime FromNowUtc(this TimeSpan ts)
        {
            return DateTime.UtcNow + ts;
        }

        /// <summary>
        /// Subtracts this TimeSpan from the current local DateTime and returns the resulting
        /// DateTime.
        /// </summary>
        /// <returns>DateTime resulting from subtracting the TimeSpan from the current local DateTime.</returns>
        public static DateTime Ago(this TimeSpan ts)
        {
            return DateTime.Now - ts;
        }

        /// <summary>
        /// Subtracts this TimeSpan from the current UTC DateTime and returns the resulting
        /// DateTime.
        /// </summary>
        /// <returns>DateTime resulting from subtracting the TimeSpan from the current UTC DateTime.</returns>
        public static DateTime AgoUtc(this TimeSpan ts)
        {
            return DateTime.UtcNow - ts;
        }

        #endregion

        #region DateTime days of the week

        /// <summary>
        /// Indicates if this DateTime represents a Sunday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Sunday; otherwise, false</returns>
        public static bool IsSunday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Indicates if this DateTime represents a Monday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Monday; otherwise, false</returns>
        public static bool IsMonday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Monday;
        }

        /// <summary>
        /// Indicates if this DateTime represents a Tuesday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Tuesday; otherwise, false</returns>
        public static bool IsTuesday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Tuesday;
        }

        /// <summary>
        /// Indicates if this DateTime represents a Wednesday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Wednesday; otherwise, false</returns>
        public static bool IsWednesday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Wednesday;
        }

        /// <summary>
        /// Indicates if this DateTime represents a Thursday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Thursday; otherwise, false</returns>
        public static bool IsThursday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Thursday;
        }

        /// <summary>
        /// Indicates if this DateTime represents a Friday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Friday; otherwise, false</returns>
        public static bool IsFriday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Friday;
        }

        /// <summary>
        /// Indicates if this DateTime represents a Saturday.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>true if the date is a Saturday; otherwise, false</returns>
        public static bool IsSaturday(this DateTime dt)
        {
            return dt.DayOfWeek == DayOfWeek.Saturday;
        }

        #endregion

        #region DateTime tests

        /// <summary>
        /// Indicates if this DateTime is in the future with respect to current local time.
        /// </summary>
        /// <returns>true if the date and time are in the future; otherwise, false</returns>
        public static bool IsAfterNow(this DateTime dt)
        {
            return dt > DateTime.Now;
        }

        /// <summary>
        /// Indicates if this DateTime is in the future with respect to current UTC time.
        /// </summary>
        /// <returns>true if the date and time are in the future; otherwise, false</returns>
        public static bool IsAfterNowUtc(this DateTime dt)
        {
            return dt > DateTime.UtcNow;
        }

        /// <summary>
        /// Indicates if this DateTime is in the future with respect to the given DateTime object.
        /// </summary>
        /// <param name="dateTime">DateTime to compare to.</param>
        /// <returns>true if the date and time are after the given DateTime; otherwise, false</returns>
        public static bool IsAfter(this DateTime dt, DateTime dateTime)
        {
            return dt > dateTime;
        }

        /// <summary>
        /// Indicates if this DateTime is in the past with respect to current local time.
        /// </summary>
        /// <returns>true if the date and time are in the past; otherwise, false</returns>
        public static bool IsBeforeNow(this DateTime dt)
        {
            return dt < DateTime.Now;
        }

        /// <summary>
        /// Indicates if this DateTime is in the past with respect to current UTC time.
        /// </summary>
        /// <returns>true if the date and time are in the past; otherwise, false</returns>
        public static bool IsBeforeNowUtc(this DateTime dt)
        {
            return dt < DateTime.UtcNow;
        }

        /// <summary>
        /// Indicates if this DateTime is in the past with respect to the given DateTime object.
        /// </summary>
        /// <param name="dateTime">DateTime to compare to.</param>
        /// <returns>true if the date and time are before the given DateTime; otherwise, false</returns>
        public static bool IsBefore(this DateTime dt, DateTime dateTime)
        {
            return dt < dateTime;
        }

        #endregion
    }
}
