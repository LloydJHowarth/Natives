using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_NotificationPriority
    {
        SDL_NOTIFICATION_PRIORITY_LOW = -1,
        SDL_NOTIFICATION_PRIORITY_NORMAL = 0,
        SDL_NOTIFICATION_PRIORITY_HIGH = 1,
        SDL_NOTIFICATION_PRIORITY_CRITICAL = 2,
    }

    internal enum SDL_NotificationActionType
    {
        SDL_NOTIFICATION_ACTION_TYPE_BUTTON = 1,
    }

    [StructLayout(LayoutKind.Explicit)]
    internal partial struct SDL_NotificationAction
    {
        [FieldOffset(0)]
        private SDL_NotificationActionType type;

        [FieldOffset(0)]
        private _button_e__Struct button;

        [FieldOffset(0)]
        private _padding_e__FixedBuffer padding;

        internal unsafe partial struct _button_e__Struct
        {
            private SDL_NotificationActionType type;

            private byte* action_id;

            private byte* action_label;
        }

        [InlineArray(128)]
        public partial struct _padding_e__FixedBuffer
        {
            private byte e0;
        }
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RequestNotificationPermission", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RequestNotificationPermission();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowNotificationWithProperties", ExactSpelling = true)]
        private static extern uint iSDL_ShowNotificationWithProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowNotification", ExactSpelling = true)]
        private static extern uint iSDL_ShowNotification(byte* title, byte* message, SDL_Surface* image, SDL_NotificationAction* actions, int num_actions);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveNotification", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RemoveNotification(uint notification);

        public static string SDL_PROP_GLOBAL_NOTIFICATION_HEADER_ICON_STRING => "SDL.notification.header_icon";

        public static string SDL_PROP_NOTIFICATION_ACTIONS_POINTER => "SDL.notification.actions";

        public static string SDL_PROP_NOTIFICATION_ACTION_COUNT_NUMBER => "SDL.notification.action_count";

        public static string SDL_PROP_NOTIFICATION_IMAGE_POINTER => "SDL.notification.image";

        public static string SDL_PROP_NOTIFICATION_MESSAGE_STRING => "SDL.notification.message";

        public static string SDL_PROP_NOTIFICATION_PRIORITY_NUMBER => "SDL.notification.priority";

        public static string SDL_PROP_NOTIFICATION_REPLACES_NUMBER => "SDL.notification.replaces";

        public static string SDL_PROP_NOTIFICATION_SOUND_STRING => "SDL.notification.sound";

        public static string SDL_PROP_NOTIFICATION_TRANSIENT_BOOLEAN => "SDL.notification.transient";

        public static string SDL_PROP_NOTIFICATION_TITLE_STRING => "SDL.notification.title";
    }
}
