using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_IOStatus
    {
        SDL_IO_STATUS_READY,
        SDL_IO_STATUS_ERROR,
        SDL_IO_STATUS_EOF,
        SDL_IO_STATUS_NOT_READY,
        SDL_IO_STATUS_READONLY,
        SDL_IO_STATUS_WRITEONLY,
    }

    internal enum SDL_IOWhence
    {
        SDL_IO_SEEK_SET,
        SDL_IO_SEEK_CUR,
        SDL_IO_SEEK_END,
    }

    internal partial struct SDL_IOStreamInterface
    {
        private uint version;

        private IntPtr size;

        private IntPtr seek;

        private IntPtr read;

        private IntPtr write;

        private IntPtr flush;

        private IntPtr close;
    }

    internal partial struct SDL_IOStream
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromFile", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_IOFromFile(byte* file, byte* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromMem", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_IOFromMem(IntPtr mem, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromConstMem", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_IOFromConstMem(IntPtr mem, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOFromDynamicMem", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_IOFromDynamicMem();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenIO", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_OpenIO(SDL_IOStreamInterface* iface, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseIO", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CloseIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetIOProperties(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOStatus", ExactSpelling = true)]
        private static extern SDL_IOStatus iSDL_GetIOStatus(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetIOSize", ExactSpelling = true)]
        private static extern long iSDL_GetIOSize(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SeekIO", ExactSpelling = true)]
        private static extern long iSDL_SeekIO(SDL_IOStream* context, long offset, SDL_IOWhence whence);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TellIO", ExactSpelling = true)]
        private static extern long iSDL_TellIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadIO", ExactSpelling = true)]
        private static extern nuint iSDL_ReadIO(SDL_IOStream* context, IntPtr ptr, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteIO", ExactSpelling = true)]
        private static extern nuint iSDL_WriteIO(SDL_IOStream* context, IntPtr ptr, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOprintf", ExactSpelling = true)]
        private static extern nuint iSDL_IOprintf(SDL_IOStream* context, byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IOvprintf", ExactSpelling = true)]
        private static extern nuint iSDL_IOvprintf(SDL_IOStream* context, byte* fmt, byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushIO", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_FlushIO(SDL_IOStream* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile_IO", ExactSpelling = true)]
        private static extern IntPtr iSDL_LoadFile_IO(SDL_IOStream* src, nuint* datasize, SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFile", ExactSpelling = true)]
        private static extern IntPtr iSDL_LoadFile(byte* file, nuint* datasize);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile_IO", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SaveFile_IO(SDL_IOStream* src, IntPtr data, nuint datasize, SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SaveFile", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SaveFile(byte* file, IntPtr data, nuint datasize);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU8", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU8(SDL_IOStream* src, byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS8", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS8(SDL_IOStream* src, sbyte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU16LE(SDL_IOStream* src, ushort* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS16LE(SDL_IOStream* src, short* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU16BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU16BE(SDL_IOStream* src, ushort* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS16BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS16BE(SDL_IOStream* src, short* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU32LE(SDL_IOStream* src, uint* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS32LE(SDL_IOStream* src, int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU32BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU32BE(SDL_IOStream* src, uint* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS32BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS32BE(SDL_IOStream* src, int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU64LE(SDL_IOStream* src, ulong* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS64LE(SDL_IOStream* src, long* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadU64BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadU64BE(SDL_IOStream* src, ulong* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadS64BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadS64BE(SDL_IOStream* src, long* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU8", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU8(SDL_IOStream* dst, byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS8", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS8(SDL_IOStream* dst, sbyte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU16LE(SDL_IOStream* dst, ushort value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS16LE(SDL_IOStream* dst, short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU16BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU16BE(SDL_IOStream* dst, ushort value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS16BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS16BE(SDL_IOStream* dst, short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU32LE(SDL_IOStream* dst, uint value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS32LE(SDL_IOStream* dst, int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU32BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU32BE(SDL_IOStream* dst, uint value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS32BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS32BE(SDL_IOStream* dst, int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU64LE(SDL_IOStream* dst, ulong value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64LE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS64LE(SDL_IOStream* dst, long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteU64BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteU64BE(SDL_IOStream* dst, ulong value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteS64BE", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteS64BE(SDL_IOStream* dst, long value);

        public static string SDL_PROP_IOSTREAM_WINDOWS_HANDLE_POINTER => "SDL.iostream.windows.handle";

        public static string SDL_PROP_IOSTREAM_STDIO_FILE_POINTER => "SDL.iostream.stdio.file";

        public static string SDL_PROP_IOSTREAM_FILE_DESCRIPTOR_NUMBER => "SDL.iostream.file_descriptor";

        public static string SDL_PROP_IOSTREAM_ANDROID_AASSET_POINTER => "SDL.iostream.android.aasset";

        public static string SDL_PROP_IOSTREAM_OPENHARMONY_RAWFILE64_POINTER => "SDL.iostream.openharmony.rawfile64";

        public static string SDL_PROP_IOSTREAM_MEMORY_POINTER => "SDL.iostream.memory.base";

        public static string SDL_PROP_IOSTREAM_MEMORY_SIZE_NUMBER => "SDL.iostream.memory.size";

        public static string SDL_PROP_IOSTREAM_MEMORY_FREE_FUNC_POINTER => "SDL.iostream.memory.free";

        public static string SDL_PROP_IOSTREAM_DYNAMIC_MEMORY_POINTER => "SDL.iostream.dynamic.memory";

        public static string SDL_PROP_IOSTREAM_DYNAMIC_CHUNKSIZE_NUMBER => "SDL.iostream.dynamic.chunksize";
    }
}
