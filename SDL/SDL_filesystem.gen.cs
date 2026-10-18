using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_Folder
    {
        SDL_FOLDER_HOME,
        SDL_FOLDER_DESKTOP,
        SDL_FOLDER_DOCUMENTS,
        SDL_FOLDER_DOWNLOADS,
        SDL_FOLDER_MUSIC,
        SDL_FOLDER_PICTURES,
        SDL_FOLDER_PUBLICSHARE,
        SDL_FOLDER_SAVEDGAMES,
        SDL_FOLDER_SCREENSHOTS,
        SDL_FOLDER_TEMPLATES,
        SDL_FOLDER_VIDEOS,
        SDL_FOLDER_COUNT,
    }

    internal enum SDL_PathType
    {
        SDL_PATHTYPE_NONE,
        SDL_PATHTYPE_FILE,
        SDL_PATHTYPE_DIRECTORY,
        SDL_PATHTYPE_OTHER,
    }

    internal partial struct SDL_PathInfo
    {
        private SDL_PathType type;

        private ulong size;

        private long create_time;

        private long modify_time;

        private long access_time;
    }

    internal enum SDL_EnumerationResult
    {
        SDL_ENUM_CONTINUE,
        SDL_ENUM_SUCCESS,
        SDL_ENUM_FAILURE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_EnumerationResult SDL_EnumerateDirectoryCallback(IntPtr userdata, byte* dirname, byte* fname);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBasePath", ExactSpelling = true)]
        private static extern byte* iSDL_GetBasePath();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrefPath", ExactSpelling = true)]
        private static extern byte* iSDL_GetPrefPath(byte* org, byte* app);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetUserFolder", ExactSpelling = true)]
        private static extern byte* iSDL_GetUserFolder(SDL_Folder folder);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateDirectory", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CreateDirectory(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateDirectory", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_EnumerateDirectory(byte* path, IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemovePath", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RemovePath(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenamePath", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenamePath(byte* oldpath, byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyFile", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CopyFile(byte* oldpath, byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPathInfo", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetPathInfo(byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobDirectory", ExactSpelling = true)]
        private static extern byte** iSDL_GlobDirectory(byte* path, byte* pattern, uint flags, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDirectory", ExactSpelling = true)]
        private static extern byte* iSDL_GetCurrentDirectory();

        public const uint SDL_GLOB_CASEINSENSITIVE = (1U << 0);
    }
}
