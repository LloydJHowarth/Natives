using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPlatform", ExactSpelling = true)]
        private static extern byte* iSDL_GetPlatform();
    }
}
