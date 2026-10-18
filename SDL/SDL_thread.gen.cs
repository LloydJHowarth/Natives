using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Thread
    {
    }

    internal enum SDL_ThreadPriority
    {
        SDL_THREAD_PRIORITY_LOW,
        SDL_THREAD_PRIORITY_NORMAL,
        SDL_THREAD_PRIORITY_HIGH,
        SDL_THREAD_PRIORITY_TIME_CRITICAL,
    }

    internal enum SDL_ThreadState
    {
        SDL_THREAD_UNKNOWN,
        SDL_THREAD_ALIVE,
        SDL_THREAD_DETACHED,
        SDL_THREAD_COMPLETE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int SDL_ThreadFunction(IntPtr data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_TLSDestructorCallback(IntPtr value);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadRuntime", ExactSpelling = true)]
        private static extern SDL_Thread* iSDL_CreateThreadRuntime(IntPtr fn, byte* name, IntPtr data, IntPtr pfnBeginThread, IntPtr pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateThreadWithPropertiesRuntime", ExactSpelling = true)]
        private static extern SDL_Thread* iSDL_CreateThreadWithPropertiesRuntime(uint props, IntPtr pfnBeginThread, IntPtr pfnEndThread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadName", ExactSpelling = true)]
        private static extern byte* iSDL_GetThreadName(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentThreadID", ExactSpelling = true)]
        private static extern ulong iSDL_GetCurrentThreadID();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadID", ExactSpelling = true)]
        private static extern ulong iSDL_GetThreadID(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetCurrentThreadPriority", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetCurrentThreadPriority(SDL_ThreadPriority priority);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitThread", ExactSpelling = true)]
        private static extern void iSDL_WaitThread(SDL_Thread* thread, int* status);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetThreadState", ExactSpelling = true)]
        private static extern SDL_ThreadState iSDL_GetThreadState(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachThread", ExactSpelling = true)]
        private static extern void iSDL_DetachThread(SDL_Thread* thread);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTLS", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetTLS(SDL_AtomicInt* id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTLS", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTLS(SDL_AtomicInt* id, IntPtr value, IntPtr destructor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CleanupTLS", ExactSpelling = true)]
        private static extern void iSDL_CleanupTLS();

        public const int SDL_BeginThreadFunction = 0;

        public const int SDL_EndThreadFunction = 0;

        public static string SDL_PROP_THREAD_CREATE_ENTRY_FUNCTION_POINTER => "SDL.thread.create.entry_function";

        public static string SDL_PROP_THREAD_CREATE_NAME_STRING => "SDL.thread.create.name";

        public static string SDL_PROP_THREAD_CREATE_USERDATA_POINTER => "SDL.thread.create.userdata";

        public static string SDL_PROP_THREAD_CREATE_STACKSIZE_NUMBER => "SDL.thread.create.stacksize";
    }
}
