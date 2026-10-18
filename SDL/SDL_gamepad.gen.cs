using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Gamepad
    {
    }

    internal enum SDL_GamepadType
    {
        SDL_GAMEPAD_TYPE_UNKNOWN = 0,
        SDL_GAMEPAD_TYPE_STANDARD,
        SDL_GAMEPAD_TYPE_XBOX360,
        SDL_GAMEPAD_TYPE_XBOXONE,
        SDL_GAMEPAD_TYPE_PS3,
        SDL_GAMEPAD_TYPE_PS4,
        SDL_GAMEPAD_TYPE_PS5,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_GAMEPAD_TYPE_GAMECUBE,
        SDL_GAMEPAD_TYPE_STEAM,
        SDL_GAMEPAD_TYPE_COUNT,
    }

    internal enum SDL_GamepadButton
    {
        SDL_GAMEPAD_BUTTON_INVALID = -1,
        SDL_GAMEPAD_BUTTON_SOUTH,
        SDL_GAMEPAD_BUTTON_EAST,
        SDL_GAMEPAD_BUTTON_WEST,
        SDL_GAMEPAD_BUTTON_NORTH,
        SDL_GAMEPAD_BUTTON_BACK,
        SDL_GAMEPAD_BUTTON_GUIDE,
        SDL_GAMEPAD_BUTTON_START,
        SDL_GAMEPAD_BUTTON_LEFT_STICK,
        SDL_GAMEPAD_BUTTON_RIGHT_STICK,
        SDL_GAMEPAD_BUTTON_LEFT_SHOULDER,
        SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER,
        SDL_GAMEPAD_BUTTON_DPAD_UP,
        SDL_GAMEPAD_BUTTON_DPAD_DOWN,
        SDL_GAMEPAD_BUTTON_DPAD_LEFT,
        SDL_GAMEPAD_BUTTON_DPAD_RIGHT,
        SDL_GAMEPAD_BUTTON_MISC1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE1,
        SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2,
        SDL_GAMEPAD_BUTTON_LEFT_PADDLE2,
        SDL_GAMEPAD_BUTTON_TOUCHPAD,
        SDL_GAMEPAD_BUTTON_MISC2,
        SDL_GAMEPAD_BUTTON_MISC3,
        SDL_GAMEPAD_BUTTON_MISC4,
        SDL_GAMEPAD_BUTTON_MISC5,
        SDL_GAMEPAD_BUTTON_MISC6,
        SDL_GAMEPAD_BUTTON_COUNT,
    }

    internal enum SDL_GamepadButtonLabel
    {
        SDL_GAMEPAD_BUTTON_LABEL_UNKNOWN,
        SDL_GAMEPAD_BUTTON_LABEL_A,
        SDL_GAMEPAD_BUTTON_LABEL_B,
        SDL_GAMEPAD_BUTTON_LABEL_X,
        SDL_GAMEPAD_BUTTON_LABEL_Y,
        SDL_GAMEPAD_BUTTON_LABEL_CROSS,
        SDL_GAMEPAD_BUTTON_LABEL_CIRCLE,
        SDL_GAMEPAD_BUTTON_LABEL_SQUARE,
        SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE,
    }

    internal enum SDL_GamepadAxis
    {
        SDL_GAMEPAD_AXIS_INVALID = -1,
        SDL_GAMEPAD_AXIS_LEFTX,
        SDL_GAMEPAD_AXIS_LEFTY,
        SDL_GAMEPAD_AXIS_RIGHTX,
        SDL_GAMEPAD_AXIS_RIGHTY,
        SDL_GAMEPAD_AXIS_LEFT_TRIGGER,
        SDL_GAMEPAD_AXIS_RIGHT_TRIGGER,
        SDL_GAMEPAD_AXIS_COUNT,
    }

    internal enum SDL_GamepadCapSenseType
    {
        SDL_GAMEPAD_CAPSENSE_INVALID = -1,
        SDL_GAMEPAD_CAPSENSE_LEFT_STICK,
        SDL_GAMEPAD_CAPSENSE_RIGHT_STICK,
        SDL_GAMEPAD_CAPSENSE_LEFT_GRIP,
        SDL_GAMEPAD_CAPSENSE_RIGHT_GRIP,
        SDL_GAMEPAD_CAPSENSE_COUNT,
    }

    internal enum SDL_GamepadBindingType
    {
        SDL_GAMEPAD_BINDTYPE_NONE = 0,
        SDL_GAMEPAD_BINDTYPE_BUTTON,
        SDL_GAMEPAD_BINDTYPE_AXIS,
        SDL_GAMEPAD_BINDTYPE_HAT,
    }

    internal partial struct SDL_GamepadBinding
    {
        private SDL_GamepadBindingType input_type;

        private _input_e__Union input;

        private SDL_GamepadBindingType output_type;

        private _output_e__Union output;

        [StructLayout(LayoutKind.Explicit)]
        internal partial struct _input_e__Union
        {
            [FieldOffset(0)]
            private int button;

            [FieldOffset(0)]
            private _axis_e__Struct axis;

            [FieldOffset(0)]
            private _hat_e__Struct hat;

            internal partial struct _axis_e__Struct
            {
                private int axis;

                private int axis_min;

                private int axis_max;
            }

            internal partial struct _hat_e__Struct
            {
                private int hat;

                private int hat_mask;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        internal partial struct _output_e__Union
        {
            [FieldOffset(0)]
            private SDL_GamepadButton button;

            [FieldOffset(0)]
            private _axis_e__Struct axis;

            internal partial struct _axis_e__Struct
            {
                private SDL_GamepadAxis axis;

                private int axis_min;

                private int axis_max;
            }
        }
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMapping", ExactSpelling = true)]
        private static extern int iSDL_AddGamepadMapping(byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromIO", ExactSpelling = true)]
        private static extern int iSDL_AddGamepadMappingsFromIO(SDL_IOStream* src, SDL_Bool closeio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddGamepadMappingsFromFile", ExactSpelling = true)]
        private static extern int iSDL_AddGamepadMappingsFromFile(byte* file);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReloadGamepadMappings", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ReloadGamepadMappings();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappings", ExactSpelling = true)]
        private static extern byte** iSDL_GetGamepadMappings(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForGUID", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadMappingForGUID(SDL_GUID guid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMapping", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadMapping(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadMapping", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGamepadMapping(uint instance_id, byte* mapping);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasGamepad", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasGamepad();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepads", ExactSpelling = true)]
        private static extern uint* iSDL_GetGamepads(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsGamepad", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsGamepad(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadNameForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPathForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadPathForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndexForID", ExactSpelling = true)]
        private static extern int iSDL_GetGamepadPlayerIndexForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadGUIDForID", ExactSpelling = true)]
        private static extern SDL_GUID iSDL_GetGamepadGUIDForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendorForID", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadVendorForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductForID", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadProductForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersionForID", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadProductVersionForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeForID", ExactSpelling = true)]
        private static extern SDL_GamepadType iSDL_GetGamepadTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadTypeForID", ExactSpelling = true)]
        private static extern SDL_GamepadType iSDL_GetRealGamepadTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadMappingForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadMappingForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenGamepad", ExactSpelling = true)]
        private static extern SDL_Gamepad* iSDL_OpenGamepad(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromID", ExactSpelling = true)]
        private static extern SDL_Gamepad* iSDL_GetGamepadFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFromPlayerIndex", ExactSpelling = true)]
        private static extern SDL_Gamepad* iSDL_GetGamepadFromPlayerIndex(int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetGamepadProperties(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadID", ExactSpelling = true)]
        private static extern uint iSDL_GetGamepadID(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadName", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadName(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPath", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadPath(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadType", ExactSpelling = true)]
        private static extern SDL_GamepadType iSDL_GetGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRealGamepadType", ExactSpelling = true)]
        private static extern SDL_GamepadType iSDL_GetRealGamepadType(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPlayerIndex", ExactSpelling = true)]
        private static extern int iSDL_GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadPlayerIndex", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadVendor", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadVendor(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProduct", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadProduct(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadProductVersion", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadProductVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadFirmwareVersion", ExactSpelling = true)]
        private static extern ushort iSDL_GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSerial", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadSerial(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSteamHandle", ExactSpelling = true)]
        private static extern ulong iSDL_GetGamepadSteamHandle(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadConnectionState", ExactSpelling = true)]
        private static extern SDL_JoystickConnectionState iSDL_GetGamepadConnectionState(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadPowerInfo", ExactSpelling = true)]
        private static extern SDL_PowerState iSDL_GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadConnected", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadConnected(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadJoystick", ExactSpelling = true)]
        private static extern SDL_Joystick* iSDL_GetGamepadJoystick(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadEventsEnabled", ExactSpelling = true)]
        private static extern void iSDL_SetGamepadEventsEnabled(SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadEventsEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadEventsEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadBindings", ExactSpelling = true)]
        private static extern SDL_GamepadBinding** iSDL_GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateGamepads", ExactSpelling = true)]
        private static extern void iSDL_UpdateGamepads();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTypeFromString", ExactSpelling = true)]
        private static extern SDL_GamepadType iSDL_GetGamepadTypeFromString(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForType", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadStringForType(SDL_GamepadType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxisFromString", ExactSpelling = true)]
        private static extern SDL_GamepadAxis iSDL_GetGamepadAxisFromString(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForAxis", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadStringForAxis(SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasAxis", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadHasAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAxis", ExactSpelling = true)]
        private static extern short iSDL_GetGamepadAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonFromString", ExactSpelling = true)]
        private static extern SDL_GamepadButton iSDL_GetGamepadButtonFromString(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadStringForButton", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadStringForButton(SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasButton", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadHasButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButton", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetGamepadButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonLabelForType", ExactSpelling = true)]
        private static extern SDL_GamepadButtonLabel iSDL_GetGamepadButtonLabelForType(SDL_GamepadType type, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadButtonLabel", ExactSpelling = true)]
        private static extern SDL_GamepadButtonLabel iSDL_GetGamepadButtonLabel(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpads", ExactSpelling = true)]
        private static extern int iSDL_GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumGamepadTouchpadFingers", ExactSpelling = true)]
        private static extern int iSDL_GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadTouchpadFinger", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetGamepadTouchpadFinger(SDL_Gamepad* gamepad, int touchpad, int finger, SDL_Bool* down, float* x, float* y, float* pressure);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasSensor", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadHasSensor(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadSensorEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type, SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadSensorEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadSensorEnabled(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorDataRate", ExactSpelling = true)]
        private static extern float iSDL_GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SDL_SensorType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadSensorData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetGamepadSensorData(SDL_Gamepad* gamepad, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GamepadHasCapSense", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GamepadHasCapSense(SDL_Gamepad* gamepad, SDL_GamepadCapSenseType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadCapSense", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetGamepadCapSense(SDL_Gamepad* gamepad, SDL_GamepadCapSenseType type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepad", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RumbleGamepad(SDL_Gamepad* gamepad, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RumbleGamepadTriggers", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RumbleGamepadTriggers(SDL_Gamepad* gamepad, ushort left_rumble, ushort right_rumble, uint duration_ms);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGamepadLED", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGamepadLED(SDL_Gamepad* gamepad, byte red, byte green, byte blue);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SendGamepadEffect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SendGamepadEffect(SDL_Gamepad* gamepad, IntPtr data, int size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseGamepad", ExactSpelling = true)]
        private static extern void iSDL_CloseGamepad(SDL_Gamepad* gamepad);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForButton", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadAppleSFSymbolsNameForButton(SDL_Gamepad* gamepad, SDL_GamepadButton button);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGamepadAppleSFSymbolsNameForAxis", ExactSpelling = true)]
        private static extern byte* iSDL_GetGamepadAppleSFSymbolsNameForAxis(SDL_Gamepad* gamepad, SDL_GamepadAxis axis);

        public static string SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN => "SDL.joystick.cap.mono_led";

        public static string SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN => "SDL.joystick.cap.rgb_led";

        public static string SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN => "SDL.joystick.cap.player_led";

        public static string SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN => "SDL.joystick.cap.rumble";

        public static string SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN => "SDL.joystick.cap.trigger_rumble";
    }
}
