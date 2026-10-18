using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVersion", ExactSpelling = true)]
        private static extern int iSDL_GetVersion();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRevision", ExactSpelling = true)]
        private static extern byte* iSDL_GetRevision();

        public const int SDL_MAJOR_VERSION = 3;

        public const int SDL_MINOR_VERSION = 5;

        public const int SDL_MICRO_VERSION = 0;

        public const int SDL_VERSION = ((3) * 1000000 + (5) * 1000 + (0));
    }
}
