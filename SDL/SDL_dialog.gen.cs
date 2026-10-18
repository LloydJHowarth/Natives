using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal unsafe partial struct SDL_DialogFileFilter
    {
        private byte* name;

        private byte* pattern;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_DialogFileCallback(IntPtr userdata, byte** filelist, int filter);

    internal enum SDL_FileDialogType
    {
        SDL_FILEDIALOG_OPENFILE,
        SDL_FILEDIALOG_SAVEFILE,
        SDL_FILEDIALOG_OPENFOLDER,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFileDialog", ExactSpelling = true)]
        private static extern void iSDL_ShowOpenFileDialog(IntPtr callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter* filters, int nfilters, byte* default_location, SDL_Bool allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSaveFileDialog", ExactSpelling = true)]
        private static extern void iSDL_ShowSaveFileDialog(IntPtr callback, IntPtr userdata, SDL_Window* window, SDL_DialogFileFilter* filters, int nfilters, byte* default_location);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowOpenFolderDialog", ExactSpelling = true)]
        private static extern void iSDL_ShowOpenFolderDialog(IntPtr callback, IntPtr userdata, SDL_Window* window, byte* default_location, SDL_Bool allow_many);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowFileDialogWithProperties", ExactSpelling = true)]
        private static extern void iSDL_ShowFileDialogWithProperties(SDL_FileDialogType type, IntPtr callback, IntPtr userdata, uint props);

        public static string SDL_PROP_FILE_DIALOG_FILTERS_POINTER => "SDL.filedialog.filters";

        public static string SDL_PROP_FILE_DIALOG_NFILTERS_NUMBER => "SDL.filedialog.nfilters";

        public static string SDL_PROP_FILE_DIALOG_WINDOW_POINTER => "SDL.filedialog.window";

        public static string SDL_PROP_FILE_DIALOG_LOCATION_STRING => "SDL.filedialog.location";

        public static string SDL_PROP_FILE_DIALOG_MANY_BOOLEAN => "SDL.filedialog.many";

        public static string SDL_PROP_FILE_DIALOG_TITLE_STRING => "SDL.filedialog.title";

        public static string SDL_PROP_FILE_DIALOG_ACCEPT_STRING => "SDL.filedialog.accept";

        public static string SDL_PROP_FILE_DIALOG_CANCEL_STRING => "SDL.filedialog.cancel";
    }
}
