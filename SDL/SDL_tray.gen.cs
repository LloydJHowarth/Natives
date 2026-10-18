using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Tray
    {
    }

    internal partial struct SDL_TrayMenu
    {
    }

    internal partial struct SDL_TrayEntry
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void SDL_TrayCallback(IntPtr userdata, SDL_TrayEntry* entry);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_Bool SDL_TrayClickCallback(IntPtr userdata, SDL_Tray* tray);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTray", ExactSpelling = true)]
        private static extern SDL_Tray* iSDL_CreateTray(SDL_Surface* icon, byte* tooltip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTrayWithProperties", ExactSpelling = true)]
        private static extern SDL_Tray* iSDL_CreateTrayWithProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayIcon", ExactSpelling = true)]
        private static extern void iSDL_SetTrayIcon(SDL_Tray* tray, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayTooltip", ExactSpelling = true)]
        private static extern void iSDL_SetTrayTooltip(SDL_Tray* tray, byte* tooltip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTrayMenu", ExactSpelling = true)]
        private static extern SDL_TrayMenu* iSDL_CreateTrayMenu(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTraySubmenu", ExactSpelling = true)]
        private static extern SDL_TrayMenu* iSDL_CreateTraySubmenu(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayMenu", ExactSpelling = true)]
        private static extern SDL_TrayMenu* iSDL_GetTrayMenu(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTraySubmenu", ExactSpelling = true)]
        private static extern SDL_TrayMenu* iSDL_GetTraySubmenu(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntries", ExactSpelling = true)]
        private static extern SDL_TrayEntry** iSDL_GetTrayEntries(SDL_TrayMenu* menu, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveTrayEntry", ExactSpelling = true)]
        private static extern void iSDL_RemoveTrayEntry(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_InsertTrayEntryAt", ExactSpelling = true)]
        private static extern SDL_TrayEntry* iSDL_InsertTrayEntryAt(SDL_TrayMenu* menu, int pos, byte* label, uint flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryLabel", ExactSpelling = true)]
        private static extern void iSDL_SetTrayEntryLabel(SDL_TrayEntry* entry, byte* label);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryLabel", ExactSpelling = true)]
        private static extern byte* iSDL_GetTrayEntryLabel(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryChecked", ExactSpelling = true)]
        private static extern void iSDL_SetTrayEntryChecked(SDL_TrayEntry* entry, SDL_Bool @checked);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryChecked", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTrayEntryChecked(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryEnabled", ExactSpelling = true)]
        private static extern void iSDL_SetTrayEntryEnabled(SDL_TrayEntry* entry, SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTrayEntryEnabled(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTrayEntryCallback", ExactSpelling = true)]
        private static extern void iSDL_SetTrayEntryCallback(SDL_TrayEntry* entry, IntPtr callback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ClickTrayEntry", ExactSpelling = true)]
        private static extern void iSDL_ClickTrayEntry(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTray", ExactSpelling = true)]
        private static extern void iSDL_DestroyTray(SDL_Tray* tray);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayEntryParent", ExactSpelling = true)]
        private static extern SDL_TrayMenu* iSDL_GetTrayEntryParent(SDL_TrayEntry* entry);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayMenuParentEntry", ExactSpelling = true)]
        private static extern SDL_TrayEntry* iSDL_GetTrayMenuParentEntry(SDL_TrayMenu* menu);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTrayMenuParentTray", ExactSpelling = true)]
        private static extern SDL_Tray* iSDL_GetTrayMenuParentTray(SDL_TrayMenu* menu);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTrays", ExactSpelling = true)]
        private static extern void iSDL_UpdateTrays();

        public const uint SDL_TRAYENTRY_BUTTON = 0x00000001U;

        public const uint SDL_TRAYENTRY_CHECKBOX = 0x00000002U;

        public const uint SDL_TRAYENTRY_SUBMENU = 0x00000004U;

        public const uint SDL_TRAYENTRY_DISABLED = 0x80000000U;

        public const uint SDL_TRAYENTRY_CHECKED = 0x40000000U;

        public static string SDL_PROP_TRAY_CREATE_ICON_POINTER => "SDL.tray.create.icon";

        public static string SDL_PROP_TRAY_CREATE_TOOLTIP_STRING => "SDL.tray.create.tooltip";

        public static string SDL_PROP_TRAY_CREATE_USERDATA_POINTER => "SDL.tray.create.userdata";

        public static string SDL_PROP_TRAY_CREATE_LEFTCLICK_CALLBACK_POINTER => "SDL.tray.create.leftclick_callback";

        public static string SDL_PROP_TRAY_CREATE_RIGHTCLICK_CALLBACK_POINTER => "SDL.tray.create.rightclick_callback";

        public static string SDL_PROP_TRAY_CREATE_MIDDLECLICK_CALLBACK_POINTER => "SDL.tray.create.middleclick_callback";
    }
}
