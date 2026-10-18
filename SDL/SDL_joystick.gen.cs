using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Joystick
    {
    }

    internal enum SDL_JoystickType
    {
        SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMEPAD,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE,
        SDL_JOYSTICK_TYPE_COUNT,
    }

    internal enum SDL_JoystickConnectionState
    {
        SDL_JOYSTICK_CONNECTION_INVALID = -1,
        SDL_JOYSTICK_CONNECTION_UNKNOWN,
        SDL_JOYSTICK_CONNECTION_WIRED,
        SDL_JOYSTICK_CONNECTION_WIRELESS,
    }

    internal partial struct SDL_VirtualJoystickTouchpadDesc
    {
        private ushort nfingers;

        private _padding_e__FixedBuffer padding;

        [InlineArray(3)]
        public partial struct _padding_e__FixedBuffer
        {
            private ushort e0;
        }
    }

    internal partial struct SDL_VirtualJoystickSensorDesc
    {
        private SDL_SensorType type;

        private float rate;
    }

    internal unsafe partial struct SDL_VirtualJoystickDesc
    {
        private uint version;

        private ushort type;

        private ushort padding;

        private ushort vendor_id;

        private ushort product_id;

        private ushort naxes;

        private ushort nbuttons;

        private ushort nballs;

        private ushort nhats;

        private ushort ntouchpads;

        private ushort nsensors;

        private _padding2_e__FixedBuffer padding2;

        private uint button_mask;

        private uint axis_mask;

        private byte* name;

        private SDL_VirtualJoystickTouchpadDesc* touchpads;

        private SDL_VirtualJoystickSensorDesc* sensors;

        private IntPtr userdata;

        private IntPtr Update;

        private IntPtr SetPlayerIndex;

        private IntPtr Rumble;

        private IntPtr RumbleTriggers;

        private IntPtr SetLED;

        private IntPtr SendEffect;

        private IntPtr SetSensorsEnabled;

        private IntPtr Cleanup;

        [InlineArray(2)]
        public partial struct _padding2_e__FixedBuffer
        {
            private ushort e0;
        }
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockJoysticks", ExactSpelling = true)]
        private static extern void iSDL_LockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TryLockJoysticks", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TryLockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockJoysticks", ExactSpelling = true)]
        private static extern void iSDL_UnlockJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasJoystick", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasJoystick();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoysticks", ExactSpelling = true)]
        private static extern uint* iSDL_GetJoysticks(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickNameForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetJoystickNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPathForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetJoystickPathForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndexForID", ExactSpelling = true)]
        private static extern int iSDL_GetJoystickPlayerIndexForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDForID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_GetJoystickGUIDForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendorForID", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickVendorForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductForID", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickProductForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersionForID", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickProductVersionForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickTypeForID", ExactSpelling = true)]
        private static extern SDL_JoystickType iSDL_GetJoystickTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenJoystick", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_OpenJoystick(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromID", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_GetJoystickFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFromPlayerIndex", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_GetJoystickFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AttachVirtualJoystick", ExactSpelling = true)]
        private static extern uint iSDL_AttachVirtualJoystick(SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DetachVirtualJoystick", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_DetachVirtualJoystick(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickVirtual", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsJoystickVirtual(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualAxis", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickVirtualAxis(SDL_Joystick* joystick, int axis, short value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualBall", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickVirtualBall(SDL_Joystick* joystick, int ball, short xrel, short yrel);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualButton", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickVirtualButton(SDL_Joystick* joystick, int button, SDL_Bool down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualHat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickVirtualHat(SDL_Joystick* joystick, int hat, byte value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickVirtualTouchpad", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickVirtualTouchpad(SDL_Joystick* joystick, int touchpad, int finger, SDL_Bool down, float x, float y, float pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickVirtualSensorData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SendJoystickVirtualSensorData(SDL_Joystick* joystick, SDL_SensorType type, ulong sensor_timestamp, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetJoystickProperties(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickName", ExactSpelling = true)]
        private static extern byte* iSDL_GetJoystickName(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPath", ExactSpelling = true)]
        private static extern byte* iSDL_GetJoystickPath(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPlayerIndex", ExactSpelling = true)]
        private static extern int iSDL_GetJoystickPlayerIndex(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickPlayerIndex", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_GetJoystickGUID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickVendor", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickVendor(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProduct", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickProduct(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickProductVersion", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickProductVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickFirmwareVersion", ExactSpelling = true)]
        private static extern ushort iSDL_GetJoystickFirmwareVersion(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSerial", ExactSpelling = true)]
        private static extern byte* iSDL_GetJoystickSerial(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickType", ExactSpelling = true)]
        private static extern SDL_JoystickType iSDL_GetJoystickType(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickGUIDInfo", ExactSpelling = true)]
        private static extern void iSDL_GetJoystickGUIDInfo(SDL_GUID guid, ushort* vendor, ushort* product, ushort* version, ushort* crc16);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickConnected", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_JoystickConnected(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickID", ExactSpelling = true)]
        private static extern uint iSDL_GetJoystickID(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickAxes", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickAxes(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickBalls", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickBalls(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickHats", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickHats(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumJoystickButtons", ExactSpelling = true)]
        private static extern int iSDL_GetNumJoystickButtons(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickEventsEnabled", ExactSpelling = true)]
        private static extern void iSDL_SetJoystickEventsEnabled(SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickEventsEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_JoystickEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateJoysticks", ExactSpelling = true)]
        private static extern void iSDL_UpdateJoysticks();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxis", ExactSpelling = true)]
        private static extern short iSDL_GetJoystickAxis(SDL_Joystick* joystick, int axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickAxisInitialState", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetJoystickAxisInitialState(SDL_Joystick* joystick, int axis, short* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickBall", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickHat", ExactSpelling = true)]
        private static extern byte iSDL_GetJoystickHat(SDL_Joystick* joystick, int hat);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickButton", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetJoystickButton(SDL_Joystick* joystick, int button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickHasSensor", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_JoystickHasSensor(SDL_Joystick* joystick, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickSensorEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type, SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_JoystickSensorEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_JoystickSensorEnabled(SDL_Joystick* joystick, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSensorDataRate", ExactSpelling = true)]
        private static extern float iSDL_GetJoystickSensorDataRate(SDL_Joystick* joystick, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickSensorData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetJoystickSensorData(SDL_Joystick* joystick, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystick", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RumbleJoystick(SDL_Joystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleJoystickTriggers", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RumbleJoystickTriggers(SDL_Joystick* joystick, ushort left_rumble, ushort right_rumble, uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetJoystickLED", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetJoystickLED(SDL_Joystick* joystick, byte red, byte green, byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendJoystickEffect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SendJoystickEffect(SDL_Joystick* joystick, IntPtr data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseJoystick", ExactSpelling = true)]
        private static extern void iSDL_CloseJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickConnectionState", ExactSpelling = true)]
        private static extern SDL_JoystickConnectionState iSDL_GetJoystickConnectionState(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetJoystickPowerInfo", ExactSpelling = true)]
        private static extern SDL_PowerState iSDL_GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);

        public const int SDL_JOYSTICK_AXIS_MAX = 32767;

        public const int SDL_JOYSTICK_AXIS_MIN = -32768;

        public static string SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led";

        public static string SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led";

        public static string SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led";

        public static string SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble";

        public static string SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble";

        public const uint SDL_HAT_CENTERED = 0x00U;

        public const uint SDL_HAT_UP = 0x01U;

        public const uint SDL_HAT_RIGHT = 0x02U;

        public const uint SDL_HAT_DOWN = 0x04U;

        public const uint SDL_HAT_LEFT = 0x08U;

        public const uint SDL_HAT_RIGHTUP = (0x02U | 0x01U);

        public const uint SDL_HAT_RIGHTDOWN = (0x02U | 0x04U);

        public const uint SDL_HAT_LEFTUP = (0x08U | 0x01U);

        public const uint SDL_HAT_LEFTDOWN = (0x08U | 0x04U);
    }
}
