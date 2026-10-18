using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_AssertState
    {
        SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE,
    }

    internal unsafe partial struct SDL_AssertData
    {
        private SDL_Bool always_ignore;

        private uint trigger_count;

        private byte* condition;

        private byte* filename;

        private int linenum;

        private byte* function;

        private SDL_AssertData* next;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AssertState SDL_AssertionHandler(SDL_AssertData* data, IntPtr userdata);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReportAssertion", ExactSpelling = true)]
        private static extern SDL_AssertState iSDL_ReportAssertion(SDL_AssertData* data, byte* func, byte* file, int line);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAssertionHandler", ExactSpelling = true)]
        private static extern void iSDL_SetAssertionHandler(IntPtr handler, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultAssertionHandler", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetDefaultAssertionHandler();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionHandler", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetAssertionHandler(IntPtr* puserdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAssertionReport", ExactSpelling = true)]
        private static extern SDL_AssertData* iSDL_GetAssertionReport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetAssertionReport", ExactSpelling = true)]
        private static extern void iSDL_ResetAssertionReport();

        public const int SDL_ASSERT_LEVEL = 1;

        public static string SDL_FILE => "SDL_assert.h";

        public static string SDL_ASSERT_FILE => "SDL_assert.h";

        public const int SDL_LINE = 718;

        public const int SDL_NULL_WHILE_LOOP_CONDITION = (0);
    }
}
