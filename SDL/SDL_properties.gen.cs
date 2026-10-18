using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_PropertyType
    {
        SDL_PROPERTY_TYPE_INVALID,
        SDL_PROPERTY_TYPE_POINTER,
        SDL_PROPERTY_TYPE_STRING,
        SDL_PROPERTY_TYPE_NUMBER,
        SDL_PROPERTY_TYPE_FLOAT,
        SDL_PROPERTY_TYPE_BOOLEAN,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_CleanupPropertyCallback(IntPtr userdata, IntPtr value);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_EnumeratePropertiesCallback(IntPtr userdata, uint props, byte* name);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGlobalProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetGlobalProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProperties", ExactSpelling = true)]
        private static extern uint iSDL_CreateProperties();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CopyProperties", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CopyProperties(uint src, uint dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockProperties", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_LockProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockProperties", ExactSpelling = true)]
        private static extern void iSDL_UnlockProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerPropertyWithCleanup", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetPointerPropertyWithCleanup(uint props, byte* name, IntPtr value, IntPtr cleanup, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetPointerProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetPointerProperty(uint props, byte* name, IntPtr value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetStringProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetStringProperty(uint props, byte* name, byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetNumberProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetNumberProperty(uint props, byte* name, long value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetFloatProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetFloatProperty(uint props, byte* name, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetBooleanProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetBooleanProperty(uint props, byte* name, SDL_Bool value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasProperty(uint props, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPropertyType", ExactSpelling = true)]
        private static extern SDL_PropertyType iSDL_GetPropertyType(uint props, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPointerProperty", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetPointerProperty(uint props, byte* name, IntPtr default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetStringProperty", ExactSpelling = true)]
        private static extern byte* iSDL_GetStringProperty(uint props, byte* name, byte* default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumberProperty", ExactSpelling = true)]
        private static extern long iSDL_GetNumberProperty(uint props, byte* name, long default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFloatProperty", ExactSpelling = true)]
        private static extern float iSDL_GetFloatProperty(uint props, byte* name, float default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetBooleanProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetBooleanProperty(uint props, byte* name, SDL_Bool default_value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ClearProperty(uint props, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumProperties", ExactSpelling = true)]
        private static extern int iSDL_GetNumProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnumerateProperties", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_EnumerateProperties(uint props, IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProperties", ExactSpelling = true)]
        private static extern void iSDL_DestroyProperties(uint props);

        public static string SDL_PROP_NAME_STRING => "SDL.name";
    }
}
