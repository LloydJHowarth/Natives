using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    [StructLayout(LayoutKind.Explicit)]
    internal partial struct _XEvent
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_Bool SDL_X11EventHook(IntPtr userdata, _XEvent* xevent);

    internal enum SDL_FormFactor
    {
        SDL_FORMFACTOR_UNKNOWN = 0,
        SDL_FORMFACTOR_DESKTOP,
        SDL_FORMFACTOR_LAPTOP,
        SDL_FORMFACTOR_PHONE,
        SDL_FORMFACTOR_TABLET,
        SDL_FORMFACTOR_CONSOLE,
        SDL_FORMFACTOR_HANDHELD,
        SDL_FORMFACTOR_WATCH,
        SDL_FORMFACTOR_TV,
        SDL_FORMFACTOR_HEADSET,
        SDL_FORMFACTOR_CAR,
    }

    internal enum SDL_Sandbox
    {
        SDL_SANDBOX_NONE = 0,
        SDL_SANDBOX_UNKNOWN_CONTAINER,
        SDL_SANDBOX_FLATPAK,
        SDL_SANDBOX_SNAP,
        SDL_SANDBOX_MACOS,
        SDL_SANDBOX_LOMIRI,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetX11EventHook", ExactSpelling = true)]
        private static extern void iSDL_SetX11EventHook(IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsPhone", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsPhone();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTablet", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsTablet();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsTV", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsTV();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDeviceFormFactor", ExactSpelling = true)]
        private static extern SDL_FormFactor iSDL_GetDeviceFormFactor();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDeviceFormFactorName", ExactSpelling = true)]
        private static extern byte* iSDL_GetDeviceFormFactorName(SDL_FormFactor form_factor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSandbox", ExactSpelling = true)]
        private static extern SDL_Sandbox iSDL_GetSandbox();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillTerminate", ExactSpelling = true)]
        private static extern void iSDL_OnApplicationWillTerminate();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidReceiveMemoryWarning", ExactSpelling = true)]
        private static extern void iSDL_OnApplicationDidReceiveMemoryWarning();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterBackground", ExactSpelling = true)]
        private static extern void iSDL_OnApplicationWillEnterBackground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterBackground", ExactSpelling = true)]
        private static extern void iSDL_OnApplicationDidEnterBackground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationWillEnterForeground", ExactSpelling = true)]
        private static extern void iSDL_OnApplicationWillEnterForeground();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OnApplicationDidEnterForeground", ExactSpelling = true)]
        private static extern void iSDL_OnApplicationDidEnterForeground();
    }
}
