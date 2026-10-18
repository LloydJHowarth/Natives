using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_AsyncIO
    {
    }

    internal enum SDL_AsyncIOTaskType
    {
        SDL_ASYNCIO_TASK_READ,
        SDL_ASYNCIO_TASK_WRITE,
        SDL_ASYNCIO_TASK_CLOSE,
    }

    internal enum SDL_AsyncIOResult
    {
        SDL_ASYNCIO_COMPLETE,
        SDL_ASYNCIO_FAILURE,
        SDL_ASYNCIO_CANCELED,
    }

    internal unsafe partial struct SDL_AsyncIOOutcome
    {
        private SDL_AsyncIO* asyncio;

        private SDL_AsyncIOTaskType type;

        private SDL_AsyncIOResult result;

        private IntPtr buffer;

        private ulong offset;

        private ulong bytes_requested;

        private ulong bytes_transferred;

        private IntPtr userdata;
    }

    internal partial struct SDL_AsyncIOQueue
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AsyncIOFromFile", ExactSpelling = true)]
        private static extern SDL_AsyncIO* iSDL_AsyncIOFromFile(byte* file, byte* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAsyncIOSize", ExactSpelling = true)]
        private static extern long iSDL_GetAsyncIOSize(SDL_AsyncIO* asyncio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadAsyncIO", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReadAsyncIO(SDL_AsyncIO* asyncio, IntPtr ptr, ulong offset, ulong size, SDL_AsyncIOQueue* queue, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WriteAsyncIO", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WriteAsyncIO(SDL_AsyncIO* asyncio, IntPtr ptr, ulong offset, ulong size, SDL_AsyncIOQueue* queue, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseAsyncIO", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CloseAsyncIO(SDL_AsyncIO* asyncio, SDL_Bool flush, SDL_AsyncIOQueue* queue, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateAsyncIOQueue", ExactSpelling = true)]
        private static extern SDL_AsyncIOQueue* iSDL_CreateAsyncIOQueue();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyAsyncIOQueue", ExactSpelling = true)]
        private static extern void iSDL_DestroyAsyncIOQueue(SDL_AsyncIOQueue* queue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAsyncIOResult", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitAsyncIOResult", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WaitAsyncIOResult(SDL_AsyncIOQueue* queue, SDL_AsyncIOOutcome* outcome, int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalAsyncIOQueue", ExactSpelling = true)]
        private static extern void iSDL_SignalAsyncIOQueue(SDL_AsyncIOQueue* queue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LoadFileAsync", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_LoadFileAsync(byte* file, SDL_AsyncIOQueue* queue, IntPtr userdata);
    }
}
