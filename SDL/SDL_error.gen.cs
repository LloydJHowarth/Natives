using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetError", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetError(byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetErrorV", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetErrorV(byte* fmt, byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OutOfMemory", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_OutOfMemory();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetError", ExactSpelling = true)]
        private static extern byte* iSDL_GetError();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearError", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ClearError();
    }
}
