using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_SharedObject
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadObject", ExactSpelling = true)]
        private static extern SDL_SharedObject* iSDL_LoadObject(byte* sofile);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFunction", ExactSpelling = true)]
        private static extern IntPtr iSDL_LoadFunction(SDL_SharedObject* handle, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnloadObject", ExactSpelling = true)]
        private static extern void iSDL_UnloadObject(SDL_SharedObject* handle);
    }
}
