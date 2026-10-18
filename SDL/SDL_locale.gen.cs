using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal unsafe partial struct SDL_Locale
    {
        private byte* language;

        private byte* country;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPreferredLocales", ExactSpelling = true)]
        private static extern SDL_Locale** iSDL_GetPreferredLocales(int* count);
    }
}
