using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumLogicalCPUCores", ExactSpelling = true)]
        private static extern int iSDL_GetNumLogicalCPUCores();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCPUCacheLineSize", ExactSpelling = true)]
        private static extern int iSDL_GetCPUCacheLineSize();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAltiVec", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasAltiVec();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasMMX", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasMMX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasSSE();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE2", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasSSE2();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE3", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasSSE3();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE41", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasSSE41();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSSE42", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasSSE42();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasAVX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX2", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasAVX2();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasAVX512F", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasAVX512F();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasARMSIMD", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasARMSIMD();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasNEON", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasNEON();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasSVE2", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasSVE2();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLSX", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasLSX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasLASX", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasLASX();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemRAM", ExactSpelling = true)]
        private static extern int iSDL_GetSystemRAM();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSIMDAlignment", ExactSpelling = true)]
        private static extern nuint iSDL_GetSIMDAlignment();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemPageSize", ExactSpelling = true)]
        private static extern int iSDL_GetSystemPageSize();

        public const int SDL_CACHELINE_SIZE = 128;
    }
}
