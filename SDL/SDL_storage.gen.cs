using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_StorageInterface
    {
        private uint version;

        private IntPtr close;

        private IntPtr ready;

        private IntPtr enumerate;

        private IntPtr info;

        private IntPtr read_file;

        private IntPtr write_file;

        private IntPtr mkdir;

        private IntPtr remove;

        private IntPtr rename;

        private IntPtr copy;

        private IntPtr space_remaining;
    }

    internal partial struct SDL_Storage
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenTitleStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenTitleStorage(byte* @override, uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenUserStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenUserStorage(byte* org, byte* app, uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenFileStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenFileStorage(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenStorage", ExactSpelling = true)]
        private static extern SDL_Storage* iSDL_OpenStorage(SDL_StorageInterface* iface, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseStorage", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CloseStorage(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StorageReady", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StorageReady(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageFileSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetStorageFileSize(SDL_Storage* storage, byte* path, ulong* length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadStorageFile", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadStorageFile(SDL_Storage* storage, byte* path, IntPtr destination, ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteStorageFile", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteStorageFile(SDL_Storage* storage, byte* path, IntPtr source, ulong length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateStorageDirectory", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CreateStorageDirectory(SDL_Storage* storage, byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateStorageDirectory", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_EnumerateStorageDirectory(SDL_Storage* storage, byte* path, IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveStoragePath", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RemoveStoragePath(SDL_Storage* storage, byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenameStoragePath", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenameStoragePath(SDL_Storage* storage, byte* oldpath, byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyStorageFile", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CopyStorageFile(SDL_Storage* storage, byte* oldpath, byte* newpath);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStoragePathInfo", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetStoragePathInfo(SDL_Storage* storage, byte* path, SDL_PathInfo* info);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStorageSpaceRemaining", ExactSpelling = true)]
        private static extern ulong iSDL_GetStorageSpaceRemaining(SDL_Storage* storage);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GlobStorageDirectory", ExactSpelling = true)]
        private static extern byte** iSDL_GlobStorageDirectory(SDL_Storage* storage, byte* path, byte* pattern, uint flags, int* count);
    }
}
