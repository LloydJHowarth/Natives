using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate uint SDL_TimerCallback(IntPtr userdata, uint timerID, uint interval);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate ulong SDL_NSTimerCallback(IntPtr userdata, uint timerID, ulong interval);

    internal static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicks", ExactSpelling = true)]
        private static extern ulong iSDL_GetTicks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTicksNS", ExactSpelling = true)]
        private static extern ulong iSDL_GetTicksNS();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceCounter", ExactSpelling = true)]
        private static extern ulong iSDL_GetPerformanceCounter();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPerformanceFrequency", ExactSpelling = true)]
        private static extern ulong iSDL_GetPerformanceFrequency();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Delay", ExactSpelling = true)]
        private static extern void iSDL_Delay(uint ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayNS", ExactSpelling = true)]
        private static extern void iSDL_DelayNS(ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DelayPrecise", ExactSpelling = true)]
        private static extern void iSDL_DelayPrecise(ulong ns);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimer", ExactSpelling = true)]
        private static extern uint iSDL_AddTimer(uint interval, IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddTimerNS", ExactSpelling = true)]
        private static extern uint iSDL_AddTimerNS(ulong interval, IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTimer", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RemoveTimer(uint id);

        public const int SDL_MS_PER_SECOND = 1000;

        public const int SDL_US_PER_SECOND = 1000000;

        public const long SDL_NS_PER_SECOND = 1000000000L;

        public const int SDL_NS_PER_MS = 1000000;

        public const int SDL_NS_PER_US = 1000;
    }
}
