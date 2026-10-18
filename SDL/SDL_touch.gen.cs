using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_TouchDeviceType
    {
        SDL_TOUCH_DEVICE_INVALID = -1,
        SDL_TOUCH_DEVICE_DIRECT,
        SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE,
        SDL_TOUCH_DEVICE_INDIRECT_RELATIVE,
    }

    internal partial struct SDL_Finger
    {
        private ulong id;

        private float x;

        private float y;

        private float pressure;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDevices", ExactSpelling = true)]
        private static extern ulong* iSDL_GetTouchDevices(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceName", ExactSpelling = true)]
        private static extern byte* iSDL_GetTouchDeviceName(ulong touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchDeviceType", ExactSpelling = true)]
        private static extern SDL_TouchDeviceType iSDL_GetTouchDeviceType(ulong touchID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTouchFingers", ExactSpelling = true)]
        private static extern SDL_Finger** iSDL_GetTouchFingers(ulong touchID, int* count);

        public const uint SDL_TOUCH_MOUSEID = unchecked((uint)(-1));

        public const ulong SDL_MOUSE_TOUCHID = unchecked((ulong)(-1));
    }
}
