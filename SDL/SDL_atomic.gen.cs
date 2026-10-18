using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_AtomicInt
    {
        private int value;
    }

    internal partial struct SDL_AtomicU32
    {
        private uint value;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockSpinlock", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TryLockSpinlock(int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockSpinlock", ExactSpelling = true)]
        private static extern void iSDL_LockSpinlock(int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockSpinlock", ExactSpelling = true)]
        private static extern void iSDL_UnlockSpinlock(int* @lock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierReleaseFunction", ExactSpelling = true)]
        private static extern void iSDL_MemoryBarrierReleaseFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MemoryBarrierAcquireFunction", ExactSpelling = true)]
        private static extern void iSDL_MemoryBarrierAcquireFunction();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicInt", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CompareAndSwapAtomicInt(SDL_AtomicInt* a, int oldval, int newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicInt", ExactSpelling = true)]
        private static extern int iSDL_SetAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicInt", ExactSpelling = true)]
        private static extern int iSDL_GetAtomicInt(SDL_AtomicInt* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddAtomicInt", ExactSpelling = true)]
        private static extern int iSDL_AddAtomicInt(SDL_AtomicInt* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicU32", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CompareAndSwapAtomicU32(SDL_AtomicU32* a, uint oldval, uint newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicU32", ExactSpelling = true)]
        private static extern uint iSDL_SetAtomicU32(SDL_AtomicU32* a, uint v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicU32", ExactSpelling = true)]
        private static extern uint iSDL_GetAtomicU32(SDL_AtomicU32* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddAtomicU32", ExactSpelling = true)]
        private static extern uint iSDL_AddAtomicU32(SDL_AtomicU32* a, int v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CompareAndSwapAtomicPointer", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CompareAndSwapAtomicPointer(IntPtr* a, IntPtr oldval, IntPtr newval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAtomicPointer", ExactSpelling = true)]
        private static extern IntPtr iSDL_SetAtomicPointer(IntPtr* a, IntPtr v);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAtomicPointer", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetAtomicPointer(IntPtr* a);
    }
}
