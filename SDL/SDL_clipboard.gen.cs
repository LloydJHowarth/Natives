using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate IntPtr SDL_ClipboardDataCallback(IntPtr userdata, byte* mime_type, nuint* size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_ClipboardCleanupCallback(IntPtr userdata);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardText", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetClipboardText(byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardText", ExactSpelling = true)]
        private static extern byte* iSDL_GetClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardText", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasClipboardText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPrimarySelectionText", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetPrimarySelectionText(byte* text);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimarySelectionText", ExactSpelling = true)]
        private static extern byte* iSDL_GetPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasPrimarySelectionText", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasPrimarySelectionText();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetClipboardData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetClipboardData(IntPtr callback, IntPtr cleanup, IntPtr userdata, byte** mime_types, nuint num_mime_types);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearClipboardData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ClearClipboardData();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardData", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetClipboardData(byte* mime_type, nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasClipboardData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasClipboardData(byte* mime_type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClipboardMimeTypes", ExactSpelling = true)]
        private static extern byte** iSDL_GetClipboardMimeTypes(nuint* num_mime_types);
    }
}
