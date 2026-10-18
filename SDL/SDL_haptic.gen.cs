using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Haptic
    {
    }

    internal partial struct SDL_HapticDirection
    {
        private byte type;

        private _dir_e__FixedBuffer dir;

        [InlineArray(3)]
        public partial struct _dir_e__FixedBuffer
        {
            private int e0;
        }
    }

    internal partial struct SDL_HapticConstant
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private short level;

        private ushort attack_length;

        private ushort attack_level;

        private ushort fade_length;

        private ushort fade_level;
    }

    internal partial struct SDL_HapticPeriodic
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private ushort period;

        private short magnitude;

        private short offset;

        private ushort phase;

        private ushort attack_length;

        private ushort attack_level;

        private ushort fade_length;

        private ushort fade_level;
    }

    internal partial struct SDL_HapticCondition
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private _right_sat_e__FixedBuffer right_sat;

        private _left_sat_e__FixedBuffer left_sat;

        private _right_coeff_e__FixedBuffer right_coeff;

        private _left_coeff_e__FixedBuffer left_coeff;

        private _deadband_e__FixedBuffer deadband;

        private _center_e__FixedBuffer center;

        [InlineArray(3)]
        public partial struct _right_sat_e__FixedBuffer
        {
            private ushort e0;
        }

        [InlineArray(3)]
        public partial struct _left_sat_e__FixedBuffer
        {
            private ushort e0;
        }

        [InlineArray(3)]
        public partial struct _right_coeff_e__FixedBuffer
        {
            private short e0;
        }

        [InlineArray(3)]
        public partial struct _left_coeff_e__FixedBuffer
        {
            private short e0;
        }

        [InlineArray(3)]
        public partial struct _deadband_e__FixedBuffer
        {
            private ushort e0;
        }

        [InlineArray(3)]
        public partial struct _center_e__FixedBuffer
        {
            private short e0;
        }
    }

    internal partial struct SDL_HapticRamp
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private short start;

        private short end;

        private ushort attack_length;

        private ushort attack_level;

        private ushort fade_length;

        private ushort fade_level;
    }

    internal partial struct SDL_HapticLeftRight
    {
        private ushort type;

        private uint length;

        private ushort large_magnitude;

        private ushort small_magnitude;
    }

    internal unsafe partial struct SDL_HapticCustom
    {
        private ushort type;

        private SDL_HapticDirection direction;

        private uint length;

        private ushort delay;

        private ushort button;

        private ushort interval;

        private byte channels;

        private ushort period;

        private ushort samples;

        private ushort* data;

        private ushort attack_length;

        private ushort attack_level;

        private ushort fade_length;

        private ushort fade_level;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]
        private ushort type;

        [FieldOffset(0)]
        private SDL_HapticConstant constant;

        [FieldOffset(0)]
        private SDL_HapticPeriodic periodic;

        [FieldOffset(0)]
        private SDL_HapticCondition condition;

        [FieldOffset(0)]
        private SDL_HapticRamp ramp;

        [FieldOffset(0)]
        private SDL_HapticLeftRight leftright;

        [FieldOffset(0)]
        private SDL_HapticCustom custom;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHaptics", ExactSpelling = true)]
        private static extern uint* iSDL_GetHaptics(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticNameForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetHapticNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHaptic", ExactSpelling = true)]
        private static extern SDL_Haptic* iSDL_OpenHaptic(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFromID", ExactSpelling = true)]
        private static extern SDL_Haptic* iSDL_GetHapticFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticID", ExactSpelling = true)]
        private static extern uint iSDL_GetHapticID(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticName", ExactSpelling = true)]
        private static extern byte* iSDL_GetHapticName(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsMouseHaptic", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsMouseHaptic();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromMouse", ExactSpelling = true)]
        private static extern SDL_Haptic* iSDL_OpenHapticFromMouse();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_IsJoystickHaptic", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_IsJoystickHaptic(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenHapticFromJoystick", ExactSpelling = true)]
        private static extern SDL_Haptic* iSDL_OpenHapticFromJoystick(SDL_Joystick* joystick);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseHaptic", ExactSpelling = true)]
        private static extern void iSDL_CloseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMaxHapticEffects", ExactSpelling = true)]
        private static extern int iSDL_GetMaxHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMaxHapticEffectsPlaying", ExactSpelling = true)]
        private static extern int iSDL_GetMaxHapticEffectsPlaying(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticFeatures", ExactSpelling = true)]
        private static extern uint iSDL_GetHapticFeatures(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumHapticAxes", ExactSpelling = true)]
        private static extern int iSDL_GetNumHapticAxes(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticEffectSupported", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HapticEffectSupported(SDL_Haptic* haptic, SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateHapticEffect", ExactSpelling = true)]
        private static extern int iSDL_CreateHapticEffect(SDL_Haptic* haptic, SDL_HapticEffect* effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateHapticEffect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UpdateHapticEffect(SDL_Haptic* haptic, int effect, SDL_HapticEffect* data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RunHapticEffect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RunHapticEffect(SDL_Haptic* haptic, int effect, uint iterations);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StopHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyHapticEffect", ExactSpelling = true)]
        private static extern void iSDL_DestroyHapticEffect(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetHapticEffectStatus", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetHapticEffectStatus(SDL_Haptic* haptic, int effect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticGain", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetHapticGain(SDL_Haptic* haptic, int gain);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetHapticAutocenter", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PauseHaptic", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_PauseHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResumeHaptic", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ResumeHaptic(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticEffects", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StopHapticEffects(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HapticRumbleSupported", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HapticRumbleSupported(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InitHapticRumble", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_InitHapticRumble(SDL_Haptic* haptic);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PlayHapticRumble", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_PlayHapticRumble(SDL_Haptic* haptic, float strength, uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopHapticRumble", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StopHapticRumble(SDL_Haptic* haptic);

        public const uint SDL_HAPTIC_INFINITY = 4294967295U;

        public const uint SDL_HAPTIC_CONSTANT = (1U << 0);

        public const uint SDL_HAPTIC_SINE = (1U << 1);

        public const uint SDL_HAPTIC_SQUARE = (1U << 2);

        public const uint SDL_HAPTIC_TRIANGLE = (1U << 3);

        public const uint SDL_HAPTIC_SAWTOOTHUP = (1U << 4);

        public const uint SDL_HAPTIC_SAWTOOTHDOWN = (1U << 5);

        public const uint SDL_HAPTIC_RAMP = (1U << 6);

        public const uint SDL_HAPTIC_SPRING = (1U << 7);

        public const uint SDL_HAPTIC_DAMPER = (1U << 8);

        public const uint SDL_HAPTIC_INERTIA = (1U << 9);

        public const uint SDL_HAPTIC_FRICTION = (1U << 10);

        public const uint SDL_HAPTIC_LEFTRIGHT = (1U << 11);

        public const uint SDL_HAPTIC_RESERVED1 = (1U << 12);

        public const uint SDL_HAPTIC_RESERVED2 = (1U << 13);

        public const uint SDL_HAPTIC_RESERVED3 = (1U << 14);

        public const uint SDL_HAPTIC_CUSTOM = (1U << 15);

        public const uint SDL_HAPTIC_GAIN = (1U << 16);

        public const uint SDL_HAPTIC_AUTOCENTER = (1U << 17);

        public const uint SDL_HAPTIC_STATUS = (1U << 18);

        public const uint SDL_HAPTIC_PAUSE = (1U << 19);

        public const int SDL_HAPTIC_POLAR = 0;

        public const int SDL_HAPTIC_CARTESIAN = 1;

        public const int SDL_HAPTIC_SPHERICAL = 2;

        public const int SDL_HAPTIC_STEERING_AXIS = 3;
    }
}
