using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_AppResult
    {
        SDL_APP_CONTINUE,
        SDL_APP_SUCCESS,
        SDL_APP_FAILURE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AppResult SDL_AppInit_func(IntPtr* appstate, int argc, byte** argv);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate SDL_AppResult SDL_AppIterate_func(IntPtr appstate);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_AppResult SDL_AppEvent_func(IntPtr appstate, SDL_Event* @event);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_AppQuit_func(IntPtr appstate, SDL_AppResult result);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_MainThreadCallback(IntPtr userdata);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Init", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_Init(uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitSubSystem", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_InitSubSystem(uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_QuitSubSystem", ExactSpelling = true)]
        private static extern void iSDL_QuitSubSystem(uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WasInit", ExactSpelling = true)]
        private static extern uint iSDL_WasInit(uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_Quit", ExactSpelling = true)]
        private static extern void iSDL_Quit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMainThread", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsMainThread();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunOnMainThread", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RunOnMainThread(IntPtr callback, IntPtr userdata, SDL_Bool wait_complete);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadata", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetAppMetadata(byte* appname, byte* appversion, byte* appidentifier);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetAppMetadataProperty", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetAppMetadataProperty(byte* name, byte* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetAppMetadataProperty", ExactSpelling = true)]
        private static extern byte* iSDL_GetAppMetadataProperty(byte* name);

        public const uint SDL_INIT_AUDIO = 0x00000010U;

        public const uint SDL_INIT_VIDEO = 0x00000020U;

        public const uint SDL_INIT_JOYSTICK = 0x00000200U;

        public const uint SDL_INIT_HAPTIC = 0x00001000U;

        public const uint SDL_INIT_GAMEPAD = 0x00002000U;

        public const uint SDL_INIT_EVENTS = 0x00004000U;

        public const uint SDL_INIT_SENSOR = 0x00008000U;

        public const uint SDL_INIT_CAMERA = 0x00010000U;

        public static string SDL_PROP_APP_METADATA_NAME_STRING => "SDL.app.metadata.name";

        public static string SDL_PROP_APP_METADATA_VERSION_STRING => "SDL.app.metadata.version";

        public static string SDL_PROP_APP_METADATA_IDENTIFIER_STRING => "SDL.app.metadata.identifier";

        public static string SDL_PROP_APP_METADATA_CREATOR_STRING => "SDL.app.metadata.creator";

        public static string SDL_PROP_APP_METADATA_COPYRIGHT_STRING => "SDL.app.metadata.copyright";

        public static string SDL_PROP_APP_METADATA_URL_STRING => "SDL.app.metadata.url";

        public static string SDL_PROP_APP_METADATA_TYPE_STRING => "SDL.app.metadata.type";
    }
}
