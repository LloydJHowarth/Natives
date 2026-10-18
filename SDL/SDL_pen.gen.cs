using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_PenAxis
    {
        SDL_PEN_AXIS_PRESSURE,
        SDL_PEN_AXIS_XTILT,
        SDL_PEN_AXIS_YTILT,
        SDL_PEN_AXIS_DISTANCE,
        SDL_PEN_AXIS_ROTATION,
        SDL_PEN_AXIS_SLIDER,
        SDL_PEN_AXIS_TANGENTIAL_PRESSURE,
        SDL_PEN_AXIS_COUNT,
    }

    internal enum SDL_PenDeviceType
    {
        SDL_PEN_DEVICE_TYPE_INVALID = -1,
        SDL_PEN_DEVICE_TYPE_UNKNOWN,
        SDL_PEN_DEVICE_TYPE_DIRECT,
        SDL_PEN_DEVICE_TYPE_INDIRECT,
    }

    internal static partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPenDeviceType", ExactSpelling = true)]
        private static extern SDL_PenDeviceType iSDL_GetPenDeviceType(uint instance_id);

        public const uint SDL_PEN_MOUSEID = unchecked((uint)(-2));

        public const ulong SDL_PEN_TOUCHID = unchecked((ulong)(-2));

        public const uint SDL_PEN_INPUT_DOWN = (1U << 0);

        public const uint SDL_PEN_INPUT_BUTTON_1 = (1U << 1);

        public const uint SDL_PEN_INPUT_BUTTON_2 = (1U << 2);

        public const uint SDL_PEN_INPUT_BUTTON_3 = (1U << 3);

        public const uint SDL_PEN_INPUT_BUTTON_4 = (1U << 4);

        public const uint SDL_PEN_INPUT_BUTTON_5 = (1U << 5);

        public const uint SDL_PEN_INPUT_ERASER_TIP = (1U << 30);

        public const uint SDL_PEN_INPUT_IN_PROXIMITY = (1U << 31);
    }
}
