using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_DateTime
    {
        private int year;

        private int month;

        private int day;

        private int hour;

        private int minute;

        private int second;

        private int nanosecond;

        private int day_of_week;

        private int utc_offset;
    }

    internal enum SDL_DateFormat
    {
        SDL_DATE_FORMAT_YYYYMMDD = 0,
        SDL_DATE_FORMAT_DDMMYYYY = 1,
        SDL_DATE_FORMAT_MMDDYYYY = 2,
    }

    internal enum SDL_TimeFormat
    {
        SDL_TIME_FORMAT_24HR = 0,
        SDL_TIME_FORMAT_12HR = 1,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDateTimeLocalePreferences", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetDateTimeLocalePreferences(SDL_DateFormat* dateFormat, SDL_TimeFormat* timeFormat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentTime", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetCurrentTime(long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToDateTime", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TimeToDateTime(long ticks, SDL_DateTime* dt, SDL_Bool localTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DateTimeToTime", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_DateTimeToTime(SDL_DateTime* dt, long* ticks);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeToWindows", ExactSpelling = true)]
        private static extern void iSDL_TimeToWindows(long ticks, uint* dwLowDateTime, uint* dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TimeFromWindows", ExactSpelling = true)]
        private static extern long iSDL_TimeFromWindows(uint dwLowDateTime, uint dwHighDateTime);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDaysInMonth", ExactSpelling = true)]
        private static extern int iSDL_GetDaysInMonth(int year, int month);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfYear", ExactSpelling = true)]
        private static extern int iSDL_GetDayOfYear(int year, int month, int day);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDayOfWeek", ExactSpelling = true)]
        private static extern int iSDL_GetDayOfWeek(int year, int month, int day);
    }
}
