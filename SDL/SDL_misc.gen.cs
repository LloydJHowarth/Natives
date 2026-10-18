using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenURL", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_OpenURL(byte* url);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EncodeURL", ExactSpelling = true)]
        private static extern byte* iSDL_EncodeURL(byte* str, byte* no_encode_chars);
    }
}
