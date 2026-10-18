using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Mutex
    {
    }

    internal partial struct SDL_RWLock
    {
    }

    internal partial struct SDL_Semaphore
    {
    }

    internal partial struct SDL_Condition
    {
    }

    internal enum SDL_InitStatus
    {
        SDL_INIT_STATUS_UNINITIALIZED,
        SDL_INIT_STATUS_INITIALIZING,
        SDL_INIT_STATUS_INITIALIZED,
        SDL_INIT_STATUS_UNINITIALIZING,
    }

    internal partial struct SDL_InitState
    {
        private SDL_AtomicInt status;

        private ulong thread;

        private IntPtr reserved;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateMutex", ExactSpelling = true)]
        private static extern SDL_Mutex* iSDL_CreateMutex();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockMutex", ExactSpelling = true)]
        private static extern void iSDL_LockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockMutex", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TryLockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockMutex", ExactSpelling = true)]
        private static extern void iSDL_UnlockMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyMutex", ExactSpelling = true)]
        private static extern void iSDL_DestroyMutex(SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRWLock", ExactSpelling = true)]
        private static extern SDL_RWLock* iSDL_CreateRWLock();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockRWLockForReading", ExactSpelling = true)]
        private static extern void iSDL_LockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockRWLockForWriting", ExactSpelling = true)]
        private static extern void iSDL_LockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockRWLockForReading", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TryLockRWLockForReading(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockRWLockForWriting", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TryLockRWLockForWriting(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockRWLock", ExactSpelling = true)]
        private static extern void iSDL_UnlockRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRWLock", ExactSpelling = true)]
        private static extern void iSDL_DestroyRWLock(SDL_RWLock* rwlock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSemaphore", ExactSpelling = true)]
        private static extern SDL_Semaphore* iSDL_CreateSemaphore(uint initial_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroySemaphore", ExactSpelling = true)]
        private static extern void iSDL_DestroySemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitSemaphore", ExactSpelling = true)]
        private static extern void iSDL_WaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryWaitSemaphore", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TryWaitSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitSemaphoreTimeout", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WaitSemaphoreTimeout(SDL_Semaphore* sem, int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalSemaphore", ExactSpelling = true)]
        private static extern void iSDL_SignalSemaphore(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSemaphoreValue", ExactSpelling = true)]
        private static extern uint iSDL_GetSemaphoreValue(SDL_Semaphore* sem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateCondition", ExactSpelling = true)]
        private static extern SDL_Condition* iSDL_CreateCondition();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyCondition", ExactSpelling = true)]
        private static extern void iSDL_DestroyCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SignalCondition", ExactSpelling = true)]
        private static extern void iSDL_SignalCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_BroadcastCondition", ExactSpelling = true)]
        private static extern void iSDL_BroadcastCondition(SDL_Condition* cond);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitCondition", ExactSpelling = true)]
        private static extern void iSDL_WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitConditionTimeout", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WaitConditionTimeout(SDL_Condition* cond, SDL_Mutex* mutex, int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShouldInit", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ShouldInit(SDL_InitState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShouldQuit", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ShouldQuit(SDL_InitState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetInitialized", ExactSpelling = true)]
        private static extern void iSDL_SetInitialized(SDL_InitState* state, SDL_Bool initialized);
    }
}
