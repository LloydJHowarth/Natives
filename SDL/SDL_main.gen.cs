using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int SDL_main_func(int argc, byte** argv);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_main", ExactSpelling = true)]
        private static extern int iSDL_main(int argc, byte** argv);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMainReady", ExactSpelling = true)]
        private static extern void iSDL_SetMainReady();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunApp", ExactSpelling = true)]
        private static extern int iSDL_RunApp(int argc, byte** argv, IntPtr mainFunction, IntPtr reserved);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnterAppMainCallbacks", ExactSpelling = true)]
        private static extern int iSDL_EnterAppMainCallbacks(int argc, byte** argv, IntPtr appinit, IntPtr appiter, IntPtr appevent, IntPtr appquit);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GDKSuspendComplete", ExactSpelling = true)]
        private static extern void iSDL_GDKSuspendComplete();
    }
}
