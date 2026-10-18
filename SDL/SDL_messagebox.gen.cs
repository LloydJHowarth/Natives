using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal unsafe partial struct SDL_MessageBoxButtonData
    {
        private uint flags;

        private int buttonID;

        private byte* text;
    }

    internal partial struct SDL_MessageBoxColor
    {
        private byte r;

        private byte g;

        private byte b;
    }

    internal enum SDL_MessageBoxColorType
    {
        SDL_MESSAGEBOX_COLOR_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_TEXT,
        SDL_MESSAGEBOX_COLOR_BUTTON_BORDER,
        SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED,
        SDL_MESSAGEBOX_COLOR_COUNT,
    }

    internal partial struct SDL_MessageBoxColorScheme
    {
        private _colors_e__FixedBuffer colors;

        [InlineArray(5)]
        public partial struct _colors_e__FixedBuffer
        {
            private SDL_MessageBoxColor e0;
        }
    }

    internal unsafe partial struct SDL_MessageBoxData
    {
        private uint flags;

        private SDL_Window* window;

        private byte* title;

        private byte* message;

        private int numbuttons;

        private SDL_MessageBoxButtonData* buttons;

        private SDL_MessageBoxColorScheme* colorScheme;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowMessageBox", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ShowMessageBox(SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowSimpleMessageBox", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ShowSimpleMessageBox(uint flags, byte* title, byte* message, SDL_Window* window);

        public const uint SDL_MESSAGEBOX_ERROR = 0x00000010U;

        public const uint SDL_MESSAGEBOX_WARNING = 0x00000020U;

        public const uint SDL_MESSAGEBOX_INFORMATION = 0x00000040U;

        public const uint SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = 0x00000080U;

        public const uint SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = 0x00000100U;

        public const uint SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = 0x00000001U;

        public const uint SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = 0x00000002U;
    }
}
