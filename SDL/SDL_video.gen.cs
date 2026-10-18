using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_SystemTheme
    {
        SDL_SYSTEM_THEME_UNKNOWN,
        SDL_SYSTEM_THEME_LIGHT,
        SDL_SYSTEM_THEME_DARK,
    }

    internal partial struct SDL_DisplayModeData
    {
    }

    internal unsafe partial struct SDL_DisplayMode
    {
        private uint displayID;

        private SDL_PixelFormat format;

        private int w;

        private int h;

        private float pixel_density;

        private float refresh_rate;

        private int refresh_rate_numerator;

        private int refresh_rate_denominator;

        private SDL_DisplayModeData* @internal;
    }

    internal enum SDL_DisplayOrientation
    {
        SDL_ORIENTATION_UNKNOWN,
        SDL_ORIENTATION_LANDSCAPE,
        SDL_ORIENTATION_LANDSCAPE_FLIPPED,
        SDL_ORIENTATION_PORTRAIT,
        SDL_ORIENTATION_PORTRAIT_FLIPPED,
    }

    internal partial struct SDL_Window
    {
    }

    internal enum SDL_FlashOperation
    {
        SDL_FLASH_CANCEL,
        SDL_FLASH_BRIEFLY,
        SDL_FLASH_UNTIL_FOCUSED,
    }

    internal enum SDL_ProgressState
    {
        SDL_PROGRESS_STATE_INVALID = -1,
        SDL_PROGRESS_STATE_NONE,
        SDL_PROGRESS_STATE_INDETERMINATE,
        SDL_PROGRESS_STATE_NORMAL,
        SDL_PROGRESS_STATE_PAUSED,
        SDL_PROGRESS_STATE_ERROR,
    }

    internal partial struct SDL_GLContextState
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate nint* SDL_EGLAttribArrayCallback(IntPtr userdata);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate int* SDL_EGLIntArrayCallback(IntPtr userdata, IntPtr display, IntPtr config);

    internal enum SDL_GLAttr
    {
        SDL_GL_RED_SIZE,
        SDL_GL_GREEN_SIZE,
        SDL_GL_BLUE_SIZE,
        SDL_GL_ALPHA_SIZE,
        SDL_GL_BUFFER_SIZE,
        SDL_GL_DOUBLEBUFFER,
        SDL_GL_DEPTH_SIZE,
        SDL_GL_STENCIL_SIZE,
        SDL_GL_ACCUM_RED_SIZE,
        SDL_GL_ACCUM_GREEN_SIZE,
        SDL_GL_ACCUM_BLUE_SIZE,
        SDL_GL_ACCUM_ALPHA_SIZE,
        SDL_GL_STEREO,
        SDL_GL_MULTISAMPLEBUFFERS,
        SDL_GL_MULTISAMPLESAMPLES,
        SDL_GL_ACCELERATED_VISUAL,
        SDL_GL_RETAINED_BACKING,
        SDL_GL_CONTEXT_MAJOR_VERSION,
        SDL_GL_CONTEXT_MINOR_VERSION,
        SDL_GL_CONTEXT_FLAGS,
        SDL_GL_CONTEXT_PROFILE_MASK,
        SDL_GL_SHARE_WITH_CURRENT_CONTEXT,
        SDL_GL_FRAMEBUFFER_SRGB_CAPABLE,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR,
        SDL_GL_CONTEXT_RESET_NOTIFICATION,
        SDL_GL_CONTEXT_NO_ERROR,
        SDL_GL_FLOATBUFFERS,
        SDL_GL_EGL_PLATFORM,
    }

    internal enum SDL_HitTestResult
    {
        SDL_HITTEST_NORMAL,
        SDL_HITTEST_DRAGGABLE,
        SDL_HITTEST_RESIZE_TOPLEFT,
        SDL_HITTEST_RESIZE_TOP,
        SDL_HITTEST_RESIZE_TOPRIGHT,
        SDL_HITTEST_RESIZE_RIGHT,
        SDL_HITTEST_RESIZE_BOTTOMRIGHT,
        SDL_HITTEST_RESIZE_BOTTOM,
        SDL_HITTEST_RESIZE_BOTTOMLEFT,
        SDL_HITTEST_RESIZE_LEFT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_HitTestResult SDL_HitTest(SDL_Window* win, SDL_Point* area, IntPtr data);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumVideoDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumVideoDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetVideoDriver", ExactSpelling = true)]
        private static extern byte* iSDL_GetVideoDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentVideoDriver", ExactSpelling = true)]
        private static extern byte* iSDL_GetCurrentVideoDriver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSystemTheme", ExactSpelling = true)]
        private static extern SDL_SystemTheme iSDL_GetSystemTheme();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplays", ExactSpelling = true)]
        private static extern uint* iSDL_GetDisplays(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetPrimaryDisplay", ExactSpelling = true)]
        private static extern uint iSDL_GetPrimaryDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetDisplayProperties(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayName", ExactSpelling = true)]
        private static extern byte* iSDL_GetDisplayName(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayBounds", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetDisplayBounds(uint displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayUsableBounds", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetDisplayUsableBounds(uint displayID, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNaturalDisplayOrientation", ExactSpelling = true)]
        private static extern SDL_DisplayOrientation iSDL_GetNaturalDisplayOrientation(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayOrientation", ExactSpelling = true)]
        private static extern SDL_DisplayOrientation iSDL_GetCurrentDisplayOrientation(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayContentScale", ExactSpelling = true)]
        private static extern float iSDL_GetDisplayContentScale(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetFullscreenDisplayModes", ExactSpelling = true)]
        private static extern SDL_DisplayMode** iSDL_GetFullscreenDisplayModes(uint displayID, int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetClosestFullscreenDisplayMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetClosestFullscreenDisplayMode(uint displayID, int w, int h, float refresh_rate, SDL_Bool include_high_density_modes, SDL_DisplayMode* closest);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDesktopDisplayMode", ExactSpelling = true)]
        private static extern SDL_DisplayMode* iSDL_GetDesktopDisplayMode(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentDisplayMode", ExactSpelling = true)]
        private static extern SDL_DisplayMode* iSDL_GetCurrentDisplayMode(uint displayID);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForPoint", ExactSpelling = true)]
        private static extern uint iSDL_GetDisplayForPoint(SDL_Point* point);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForRect", ExactSpelling = true)]
        private static extern uint iSDL_GetDisplayForRect(SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDisplayForWindow", ExactSpelling = true)]
        private static extern uint iSDL_GetDisplayForWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelDensity", ExactSpelling = true)]
        private static extern float iSDL_GetWindowPixelDensity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowDisplayScale", ExactSpelling = true)]
        private static extern float iSDL_GetWindowDisplayScale(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreenMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowFullscreenMode(SDL_Window* window, SDL_DisplayMode* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFullscreenMode", ExactSpelling = true)]
        private static extern SDL_DisplayMode* iSDL_GetWindowFullscreenMode(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowICCProfile", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetWindowICCProfile(SDL_Window* window, nuint* size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPixelFormat", ExactSpelling = true)]
        private static extern SDL_PixelFormat iSDL_GetWindowPixelFormat(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindows", ExactSpelling = true)]
        private static extern SDL_Window** iSDL_GetWindows(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_CreateWindow(byte* title, int w, int h, ulong flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreatePopupWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_CreatePopupWindow(SDL_Window* parent, int offset_x, int offset_y, int w, int h, ulong flags);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowWithProperties", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_CreateWindowWithProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowID", ExactSpelling = true)]
        private static extern uint iSDL_GetWindowID(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromID", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetWindowFromID(uint id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowParent", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetWindowParent(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetWindowProperties(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFlags", ExactSpelling = true)]
        private static extern ulong iSDL_GetWindowFlags(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowTitle", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowTitle(SDL_Window* window, byte* title);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowTitle", ExactSpelling = true)]
        private static extern byte* iSDL_GetWindowTitle(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowIcon", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowPosition", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowPosition(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowPosition", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowPosition(SDL_Window* window, int* x, int* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowSize(SDL_Window* window, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSafeArea", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowSafeArea(SDL_Window* window, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAspectRatio", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowAspectRatio(SDL_Window* window, float min_aspect, float max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowAspectRatio", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowAspectRatio(SDL_Window* window, float* min_aspect, float* max_aspect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowBordersSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSizeInPixels", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMinimumSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMinimumSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMaximumSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMaximumSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowBordered", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowBordered(SDL_Window* window, SDL_Bool bordered);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowResizable", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowResizable(SDL_Window* window, SDL_Bool resizable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowAlwaysOnTop", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowAlwaysOnTop(SDL_Window* window, SDL_Bool on_top);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFillDocument", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowFillDocument(SDL_Window* window, SDL_Bool fill);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ShowWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HideWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HideWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RaiseWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RaiseWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MaximizeWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_MaximizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_MinimizeWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_MinimizeWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RestoreWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RestoreWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFullscreen", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowFullscreen(SDL_Window* window, SDL_Bool fullscreen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SyncWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SyncWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WindowHasSurface", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WindowHasSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurface", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowSurfaceVSync", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowSurfaceVSync(SDL_Window* window, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowSurfaceVSync", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowSurfaceVSync(SDL_Window* window, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurface", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UpdateWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateWindowSurfaceRects", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UpdateWindowSurfaceRects(SDL_Window* window, SDL_Rect* rects, int numrects);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindowSurface", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_DestroyWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowKeyboardGrab", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowKeyboardGrab(SDL_Window* window, SDL_Bool grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseGrab", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowMouseGrab(SDL_Window* window, SDL_Bool grabbed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowKeyboardGrab", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowKeyboardGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseGrab", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetWindowMouseGrab(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGrabbedWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetGrabbedWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowMouseRect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowMouseRect(SDL_Window* window, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowMouseRect", ExactSpelling = true)]
        private static extern SDL_Rect* iSDL_GetWindowMouseRect(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowOpacity", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowOpacity(SDL_Window* window, float opacity);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowOpacity", ExactSpelling = true)]
        private static extern float iSDL_GetWindowOpacity(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowParent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowParent(SDL_Window* window, SDL_Window* parent);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowModal", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowModal(SDL_Window* window, SDL_Bool modal);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowFocusable", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowFocusable(SDL_Window* window, SDL_Bool focusable);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ShowWindowSystemMenu", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ShowWindowSystemMenu(SDL_Window* window, int x, int y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowHitTest", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowHitTest(SDL_Window* window, IntPtr callback, IntPtr callback_data);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowShape", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlashWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowProgressState", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowProgressState(SDL_Window* window, SDL_ProgressState state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProgressState", ExactSpelling = true)]
        private static extern SDL_ProgressState iSDL_GetWindowProgressState(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetWindowProgressValue", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetWindowProgressValue(SDL_Window* window, float value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowProgressValue", ExactSpelling = true)]
        private static extern float iSDL_GetWindowProgressValue(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyWindow", ExactSpelling = true)]
        private static extern void iSDL_DestroyWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ScreenSaverEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ScreenSaverEnabled();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EnableScreenSaver", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_EnableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DisableScreenSaver", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_DisableScreenSaver();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_LoadLibrary", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_LoadLibrary(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetProcAddress", ExactSpelling = true)]
        private static extern IntPtr iSDL_GL_GetProcAddress(byte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetProcAddress", ExactSpelling = true)]
        private static extern IntPtr iSDL_EGL_GetProcAddress(byte* proc);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_UnloadLibrary", ExactSpelling = true)]
        private static extern void iSDL_GL_UnloadLibrary();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ExtensionSupported", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_ExtensionSupported(byte* extension);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_ResetAttributes", ExactSpelling = true)]
        private static extern void iSDL_GL_ResetAttributes();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetAttribute", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_SetAttribute(SDL_GLAttr attr, int value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetAttribute", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_GetAttribute(SDL_GLAttr attr, int* value);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_CreateContext", ExactSpelling = true)]
        private static extern SDL_GLContextState* iSDL_GL_CreateContext(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_MakeCurrent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_MakeCurrent(SDL_Window* window, SDL_GLContextState* context);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GL_GetCurrentWindow();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetCurrentContext", ExactSpelling = true)]
        private static extern SDL_GLContextState* iSDL_GL_GetCurrentContext();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentDisplay", ExactSpelling = true)]
        private static extern IntPtr iSDL_EGL_GetCurrentDisplay();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetCurrentConfig", ExactSpelling = true)]
        private static extern IntPtr iSDL_EGL_GetCurrentConfig();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_GetWindowSurface", ExactSpelling = true)]
        private static extern IntPtr iSDL_EGL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EGL_SetAttributeCallbacks", ExactSpelling = true)]
        private static extern void iSDL_EGL_SetAttributeCallbacks(IntPtr platformAttribCallback, IntPtr surfaceAttribCallback, IntPtr contextAttribCallback, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SetSwapInterval", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_SetSwapInterval(int interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_GetSwapInterval", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_GetSwapInterval(int* interval);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_SwapWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_SwapWindow(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GL_DestroyContext", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GL_DestroyContext(SDL_GLContextState* context);

        public static string SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER => "SDL.video.wayland.wl_display";

        public static string SDL_PROP_GLOBAL_VIDEO_WAYLAND_SESSION_ID_STRING => "SDL.video.wayland.session_id";

        public const ulong SDL_WINDOW_FULLSCREEN = (0x0000000000000001UL);

        public const ulong SDL_WINDOW_OPENGL = (0x0000000000000002UL);

        public const ulong SDL_WINDOW_OCCLUDED = (0x0000000000000004UL);

        public const ulong SDL_WINDOW_HIDDEN = (0x0000000000000008UL);

        public const ulong SDL_WINDOW_BORDERLESS = (0x0000000000000010UL);

        public const ulong SDL_WINDOW_RESIZABLE = (0x0000000000000020UL);

        public const ulong SDL_WINDOW_MINIMIZED = (0x0000000000000040UL);

        public const ulong SDL_WINDOW_MAXIMIZED = (0x0000000000000080UL);

        public const ulong SDL_WINDOW_MOUSE_GRABBED = (0x0000000000000100UL);

        public const ulong SDL_WINDOW_INPUT_FOCUS = (0x0000000000000200UL);

        public const ulong SDL_WINDOW_MOUSE_FOCUS = (0x0000000000000400UL);

        public const ulong SDL_WINDOW_EXTERNAL = (0x0000000000000800UL);

        public const ulong SDL_WINDOW_MODAL = (0x0000000000001000UL);

        public const ulong SDL_WINDOW_HIGH_PIXEL_DENSITY = (0x0000000000002000UL);

        public const ulong SDL_WINDOW_MOUSE_CAPTURE = (0x0000000000004000UL);

        public const ulong SDL_WINDOW_MOUSE_RELATIVE_MODE = (0x0000000000008000UL);

        public const ulong SDL_WINDOW_ALWAYS_ON_TOP = (0x0000000000010000UL);

        public const ulong SDL_WINDOW_UTILITY = (0x0000000000020000UL);

        public const ulong SDL_WINDOW_TOOLTIP = (0x0000000000040000UL);

        public const ulong SDL_WINDOW_POPUP_MENU = (0x0000000000080000UL);

        public const ulong SDL_WINDOW_KEYBOARD_GRABBED = (0x0000000000100000UL);

        public const ulong SDL_WINDOW_FILL_DOCUMENT = (0x0000000000200000UL);

        public const ulong SDL_WINDOW_VULKAN = (0x0000000010000000UL);

        public const ulong SDL_WINDOW_METAL = (0x0000000020000000UL);

        public const ulong SDL_WINDOW_TRANSPARENT = (0x0000000040000000UL);

        public const ulong SDL_WINDOW_NOT_FOCUSABLE = (0x0000000080000000UL);

        public const uint SDL_WINDOWPOS_UNDEFINED_MASK = 0x1FFF0000U;

        public const uint SDL_WINDOWPOS_UNDEFINED = (0x1FFF0000U | (0));

        public const uint SDL_WINDOWPOS_CENTERED_MASK = 0x2FFF0000U;

        public const uint SDL_WINDOWPOS_CENTERED = (0x2FFF0000U | (0));

        public const int SDL_GL_CONTEXT_PROFILE_CORE = 0x0001;

        public const int SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002;

        public const int SDL_GL_CONTEXT_PROFILE_ES = 0x0004;

        public const int SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001;

        public const int SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002;

        public const int SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004;

        public const int SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008;

        public const int SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000;

        public const int SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x0001;

        public const int SDL_GL_CONTEXT_RESET_NO_NOTIFICATION = 0x0000;

        public const int SDL_GL_CONTEXT_RESET_LOSE_CONTEXT = 0x0001;

        public static string SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN => "SDL.display.HDR_enabled";

        public static string SDL_PROP_DISPLAY_KMSDRM_PANEL_ORIENTATION_NUMBER => "SDL.display.KMSDRM.panel_orientation";

        public static string SDL_PROP_DISPLAY_WAYLAND_WL_OUTPUT_POINTER => "SDL.display.wayland.wl_output";

        public static string SDL_PROP_DISPLAY_WINDOWS_HMONITOR_POINTER => "SDL.display.windows.hmonitor";

        public static string SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN => "SDL.window.create.always_on_top";

        public static string SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN => "SDL.window.create.borderless";

        public static string SDL_PROP_WINDOW_CREATE_CONSTRAIN_POPUP_BOOLEAN => "SDL.window.create.constrain_popup";

        public static string SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN => "SDL.window.create.focusable";

        public static string SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN => "SDL.window.create.external_graphics_context";

        public static string SDL_PROP_WINDOW_CREATE_FLAGS_NUMBER => "SDL.window.create.flags";

        public static string SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN => "SDL.window.create.fullscreen";

        public static string SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER => "SDL.window.create.height";

        public static string SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN => "SDL.window.create.hidden";

        public static string SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN => "SDL.window.create.high_pixel_density";

        public static string SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN => "SDL.window.create.maximized";

        public static string SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN => "SDL.window.create.menu";

        public static string SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN => "SDL.window.create.metal";

        public static string SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN => "SDL.window.create.minimized";

        public static string SDL_PROP_WINDOW_CREATE_MODAL_BOOLEAN => "SDL.window.create.modal";

        public static string SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN => "SDL.window.create.mouse_grabbed";

        public static string SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN => "SDL.window.create.opengl";

        public static string SDL_PROP_WINDOW_CREATE_PARENT_POINTER => "SDL.window.create.parent";

        public static string SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN => "SDL.window.create.resizable";

        public static string SDL_PROP_WINDOW_CREATE_TITLE_STRING => "SDL.window.create.title";

        public static string SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN => "SDL.window.create.transparent";

        public static string SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN => "SDL.window.create.tooltip";

        public static string SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN => "SDL.window.create.utility";

        public static string SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN => "SDL.window.create.vulkan";

        public static string SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER => "SDL.window.create.width";

        public static string SDL_PROP_WINDOW_CREATE_X_NUMBER => "SDL.window.create.x";

        public static string SDL_PROP_WINDOW_CREATE_Y_NUMBER => "SDL.window.create.y";

        public static string SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER => "SDL.window.create.cocoa.window";

        public static string SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER => "SDL.window.create.cocoa.view";

        public static string SDL_PROP_WINDOW_CREATE_WINDOWSCENE_POINTER => "SDL.window.create.uikit.windowscene";

        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN => "SDL.window.create.wayland.surface_role_custom";

        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN => "SDL.window.create.wayland.create_egl_window";

        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_WINDOW_ID_STRING => "SDL.window.create.wayland.window_id";

        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER => "SDL.window.create.wayland.wl_surface";

        public static string SDL_PROP_WINDOW_CREATE_WAYLAND_ENABLE_INSETS_BOOLEAN => "SDL.window.create.wayland.enable_insets";

        public static string SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER => "SDL.window.create.win32.hwnd";

        public static string SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER => "SDL.window.create.win32.pixel_format_hwnd";

        public static string SDL_PROP_WINDOW_CREATE_WIN32_STYLE_EX_NUMBER => "SDL.window.create.win32.style_ex";

        public static string SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER => "SDL.window.create.x11.window";

        public static string SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_CANVAS_ID_STRING => "SDL.window.create.emscripten.canvas_id";

        public static string SDL_PROP_WINDOW_CREATE_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING => "SDL.window.create.emscripten.keyboard_element";

        public static string SDL_PROP_WINDOW_CREATE_VISIONOS_SETTINGS_STRING => "SDL.window.create.visionos.settings";

        public static string SDL_PROP_WINDOW_SHAPE_POINTER => "SDL.window.shape";

        public static string SDL_PROP_WINDOW_HDR_ENABLED_BOOLEAN => "SDL.window.HDR_enabled";

        public static string SDL_PROP_WINDOW_SDR_WHITE_LEVEL_FLOAT => "SDL.window.SDR_white_level";

        public static string SDL_PROP_WINDOW_HDR_HEADROOM_FLOAT => "SDL.window.HDR_headroom";

        public static string SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER => "SDL.window.android.window";

        public static string SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER => "SDL.window.android.surface";

        public static string SDL_PROP_WINDOW_OPENHARMONY_XCOMPONENT_POINTER => "SDL.window.openharmony.xcomponent";

        public static string SDL_PROP_WINDOW_OPENHARMONY_WINDOW_POINTER => "SDL.window.openharmony.window";

        public static string SDL_PROP_WINDOW_OPENHARMONY_SURFACE_POINTER => "SDL.window.openharmony.surface";

        public static string SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER => "SDL.window.uikit.window";

        public static string SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER => "SDL.window.uikit.metal_view_tag";

        public static string SDL_PROP_WINDOW_UIKIT_OPENGL_FRAMEBUFFER_NUMBER => "SDL.window.uikit.opengl.framebuffer";

        public static string SDL_PROP_WINDOW_UIKIT_OPENGL_RENDERBUFFER_NUMBER => "SDL.window.uikit.opengl.renderbuffer";

        public static string SDL_PROP_WINDOW_UIKIT_OPENGL_RESOLVE_FRAMEBUFFER_NUMBER => "SDL.window.uikit.opengl.resolve_framebuffer";

        public static string SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER => "SDL.window.kmsdrm.dev_index";

        public static string SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER => "SDL.window.kmsdrm.drm_fd";

        public static string SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER => "SDL.window.kmsdrm.gbm_dev";

        public static string SDL_PROP_WINDOW_COCOA_WINDOW_POINTER => "SDL.window.cocoa.window";

        public static string SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER => "SDL.window.cocoa.metal_view_tag";

        public static string SDL_PROP_WINDOW_OPENVR_OVERLAY_ID_NUMBER => "SDL.window.openvr.overlay_id";

        public static string SDL_PROP_WINDOW_QNX_WINDOW_POINTER => "SDL.window.qnx.window";

        public static string SDL_PROP_WINDOW_QNX_SURFACE_POINTER => "SDL.window.qnx.surface";

        public static string SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER => "SDL.window.vivante.display";

        public static string SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER => "SDL.window.vivante.window";

        public static string SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER => "SDL.window.vivante.surface";

        public static string SDL_PROP_WINDOW_WIN32_HWND_POINTER => "SDL.window.win32.hwnd";

        public static string SDL_PROP_WINDOW_WIN32_HDC_POINTER => "SDL.window.win32.hdc";

        public static string SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER => "SDL.window.win32.instance";

        public static string SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER => "SDL.window.wayland.display";

        public static string SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER => "SDL.window.wayland.surface";

        public static string SDL_PROP_WINDOW_WAYLAND_VIEWPORT_POINTER => "SDL.window.wayland.viewport";

        public static string SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER => "SDL.window.wayland.egl_window";

        public static string SDL_PROP_WINDOW_WAYLAND_WINDOW_ID_STRING => "SDL.window.wayland.window_id";

        public static string SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER => "SDL.window.wayland.xdg_surface";

        public static string SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER => "SDL.window.wayland.xdg_toplevel";

        public static string SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING => "SDL.window.wayland.xdg_toplevel_export_handle";

        public static string SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER => "SDL.window.wayland.xdg_popup";

        public static string SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER => "SDL.window.wayland.xdg_positioner";

        public static string SDL_PROP_WINDOW_WAYLAND_BORDER_INSET_LEFT_NUMBER => "SDL.window.wayland.border_inset_left";

        public static string SDL_PROP_WINDOW_WAYLAND_BORDER_INSET_TOP_NUMBER => "SDL.window.wayland.border_inset_top";

        public static string SDL_PROP_WINDOW_WAYLAND_BORDER_INSET_RIGHT_NUMBER => "SDL.window.wayland.border_inset_right";

        public static string SDL_PROP_WINDOW_WAYLAND_BORDER_INSET_BOTTOM_NUMBER => "SDL.window.wayland.border_inset_bottom";

        public static string SDL_PROP_WINDOW_X11_DISPLAY_POINTER => "SDL.window.x11.display";

        public static string SDL_PROP_WINDOW_X11_SCREEN_NUMBER => "SDL.window.x11.screen";

        public static string SDL_PROP_WINDOW_X11_WINDOW_NUMBER => "SDL.window.x11.window";

        public static string SDL_PROP_WINDOW_EMSCRIPTEN_CANVAS_ID_STRING => "SDL.window.emscripten.canvas_id";

        public static string SDL_PROP_WINDOW_EMSCRIPTEN_KEYBOARD_ELEMENT_STRING => "SDL.window.emscripten.keyboard_element";

        public static string SDL_PROP_WINDOW_VISIONOS_SETTINGS_STRING => "SDL.window.visionos.settings";

        public const int SDL_WINDOW_SURFACE_VSYNC_DISABLED = 0;

        public const int SDL_WINDOW_SURFACE_VSYNC_ADAPTIVE = (-1);
    }
}
