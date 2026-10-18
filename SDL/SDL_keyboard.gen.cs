using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_TextInputType
    {
        SDL_TEXTINPUT_TYPE_TEXT,
        SDL_TEXTINPUT_TYPE_TEXT_NAME,
        SDL_TEXTINPUT_TYPE_TEXT_EMAIL,
        SDL_TEXTINPUT_TYPE_TEXT_USERNAME,
        SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_HIDDEN,
        SDL_TEXTINPUT_TYPE_TEXT_PASSWORD_VISIBLE,
        SDL_TEXTINPUT_TYPE_NUMBER,
        SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_HIDDEN,
        SDL_TEXTINPUT_TYPE_NUMBER_PASSWORD_VISIBLE,
    }

    internal enum SDL_Capitalization
    {
        SDL_CAPITALIZE_NONE,
        SDL_CAPITALIZE_SENTENCES,
        SDL_CAPITALIZE_WORDS,
        SDL_CAPITALIZE_LETTERS,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasKeyboard", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboards", ExactSpelling = true)]
        private static extern uint* iSDL_GetKeyboards(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardNameForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetKeyboardNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardFocus", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetKeyboardFocus();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyboardState", ExactSpelling = true)]
        private static extern SDL_Bool* iSDL_GetKeyboardState(int* numkeys);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ResetKeyboard", ExactSpelling = true)]
        private static extern void iSDL_ResetKeyboard();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetModState", ExactSpelling = true)]
        private static extern ushort iSDL_GetModState();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetModState", ExactSpelling = true)]
        private static extern void iSDL_SetModState(ushort modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromScancode", ExactSpelling = true)]
        private static extern uint iSDL_GetKeyFromScancode(SDL_Scancode scancode, ushort modstate, SDL_Bool key_event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromKey", ExactSpelling = true)]
        private static extern SDL_Scancode iSDL_GetScancodeFromKey(uint key, ushort* modstate);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetScancodeName", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetScancodeName(SDL_Scancode scancode, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeName", ExactSpelling = true)]
        private static extern byte* iSDL_GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetScancodeFromName", ExactSpelling = true)]
        private static extern SDL_Scancode iSDL_GetScancodeFromName(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyName", ExactSpelling = true)]
        private static extern byte* iSDL_GetKeyName(uint key);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetKeyFromName", ExactSpelling = true)]
        private static extern uint iSDL_GetKeyFromName(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInput", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StartTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StartTextInputWithProperties", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StartTextInputWithProperties(SDL_Window* window, uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_TextInputActive", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_TextInputActive(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StopTextInput", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_StopTextInput(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClearComposition", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ClearComposition(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextInputArea", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextInputArea(SDL_Window* window, SDL_Rect* rect, int cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextInputArea", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextInputArea(SDL_Window* window, SDL_Rect* rect, int* cursor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasScreenKeyboardSupport", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasScreenKeyboardSupport();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenKeyboardShown", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ScreenKeyboardShown(SDL_Window* window);

        public static string SDL_PROP_TEXTINPUT_TYPE_NUMBER => "SDL.textinput.type";

        public static string SDL_PROP_TEXTINPUT_CAPITALIZATION_NUMBER => "SDL.textinput.capitalization";

        public static string SDL_PROP_TEXTINPUT_AUTOCORRECT_BOOLEAN => "SDL.textinput.autocorrect";

        public static string SDL_PROP_TEXTINPUT_MULTILINE_BOOLEAN => "SDL.textinput.multiline";

        public static string SDL_PROP_TEXTINPUT_TITLE_STRING => "SDL.textinput.title";

        public static string SDL_PROP_TEXTINPUT_PLACEHOLDER_STRING => "SDL.textinput.placeholder";

        public static string SDL_PROP_TEXTINPUT_DEFAULT_TEXT_STRING => "SDL.textinput.default_text";

        public static string SDL_PROP_TEXTINPUT_MAX_LENGTH_NUMBER => "SDL.textinput.max_length";

        public static string SDL_PROP_TEXTINPUT_ANDROID_INPUTTYPE_NUMBER => "SDL.textinput.android.inputtype";

        public static string SDL_PROP_TEXTINPUT_OPENHARMONY_INPUTTYPE_NUMBER => "SDL.textinput.openharmony.inputtype";
    }
}
