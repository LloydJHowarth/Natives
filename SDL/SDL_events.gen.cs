using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum SDL_EventType
    {
        SDL_EVENT_FIRST = 0,
        SDL_EVENT_QUIT = 0x100,
        SDL_EVENT_TERMINATING,
        SDL_EVENT_LOW_MEMORY,
        SDL_EVENT_WILL_ENTER_BACKGROUND,
        SDL_EVENT_DID_ENTER_BACKGROUND,
        SDL_EVENT_WILL_ENTER_FOREGROUND,
        SDL_EVENT_DID_ENTER_FOREGROUND,
        SDL_EVENT_LOCALE_CHANGED,
        SDL_EVENT_SYSTEM_THEME_CHANGED,
        SDL_EVENT_DISPLAY_ORIENTATION = 0x151,
        SDL_EVENT_DISPLAY_ADDED,
        SDL_EVENT_DISPLAY_REMOVED,
        SDL_EVENT_DISPLAY_MOVED,
        SDL_EVENT_DISPLAY_DESKTOP_MODE_CHANGED,
        SDL_EVENT_DISPLAY_CURRENT_MODE_CHANGED,
        SDL_EVENT_DISPLAY_CONTENT_SCALE_CHANGED,
        SDL_EVENT_DISPLAY_USABLE_BOUNDS_CHANGED,
        SDL_EVENT_DISPLAY_FIRST = SDL_EVENT_DISPLAY_ORIENTATION,
        SDL_EVENT_DISPLAY_LAST = SDL_EVENT_DISPLAY_USABLE_BOUNDS_CHANGED,
        SDL_EVENT_WINDOW_SHOWN = 0x202,
        SDL_EVENT_WINDOW_HIDDEN,
        SDL_EVENT_WINDOW_EXPOSED,
        SDL_EVENT_WINDOW_MOVED,
        SDL_EVENT_WINDOW_RESIZED,
        SDL_EVENT_WINDOW_PIXEL_SIZE_CHANGED,
        SDL_EVENT_WINDOW_METAL_VIEW_RESIZED,
        SDL_EVENT_WINDOW_MINIMIZED,
        SDL_EVENT_WINDOW_MAXIMIZED,
        SDL_EVENT_WINDOW_RESTORED,
        SDL_EVENT_WINDOW_MOUSE_ENTER,
        SDL_EVENT_WINDOW_MOUSE_LEAVE,
        SDL_EVENT_WINDOW_FOCUS_GAINED,
        SDL_EVENT_WINDOW_FOCUS_LOST,
        SDL_EVENT_WINDOW_CLOSE_REQUESTED,
        SDL_EVENT_WINDOW_HIT_TEST,
        SDL_EVENT_WINDOW_ICCPROF_CHANGED,
        SDL_EVENT_WINDOW_DISPLAY_CHANGED,
        SDL_EVENT_WINDOW_DISPLAY_SCALE_CHANGED,
        SDL_EVENT_WINDOW_SAFE_AREA_CHANGED,
        SDL_EVENT_WINDOW_OCCLUDED,
        SDL_EVENT_WINDOW_ENTER_FULLSCREEN,
        SDL_EVENT_WINDOW_LEAVE_FULLSCREEN,
        SDL_EVENT_WINDOW_DESTROYED,
        SDL_EVENT_WINDOW_HDR_STATE_CHANGED,
        SDL_EVENT_WINDOW_SETTINGS_CHANGED,
        SDL_EVENT_WINDOW_FIRST = SDL_EVENT_WINDOW_SHOWN,
        SDL_EVENT_WINDOW_LAST = SDL_EVENT_WINDOW_SETTINGS_CHANGED,
        SDL_EVENT_KEY_DOWN = 0x300,
        SDL_EVENT_KEY_UP,
        SDL_EVENT_TEXT_EDITING,
        SDL_EVENT_TEXT_INPUT,
        SDL_EVENT_KEYMAP_CHANGED,
        SDL_EVENT_KEYBOARD_ADDED,
        SDL_EVENT_KEYBOARD_REMOVED,
        SDL_EVENT_TEXT_EDITING_CANDIDATES,
        SDL_EVENT_SCREEN_KEYBOARD_SHOWN,
        SDL_EVENT_SCREEN_KEYBOARD_HIDDEN,
        SDL_EVENT_KEYBOARD_FIRST = SDL_EVENT_KEY_DOWN,
        SDL_EVENT_KEYBOARD_LAST = SDL_EVENT_SCREEN_KEYBOARD_HIDDEN,
        SDL_EVENT_MOUSE_MOTION = 0x400,
        SDL_EVENT_MOUSE_BUTTON_DOWN,
        SDL_EVENT_MOUSE_BUTTON_UP,
        SDL_EVENT_MOUSE_WHEEL,
        SDL_EVENT_MOUSE_ADDED,
        SDL_EVENT_MOUSE_REMOVED,
        SDL_EVENT_MOUSE_FIRST = SDL_EVENT_MOUSE_MOTION,
        SDL_EVENT_MOUSE_LAST = SDL_EVENT_MOUSE_REMOVED,
        SDL_EVENT_JOYSTICK_AXIS_MOTION = 0x600,
        SDL_EVENT_JOYSTICK_BALL_MOTION,
        SDL_EVENT_JOYSTICK_HAT_MOTION,
        SDL_EVENT_JOYSTICK_BUTTON_DOWN,
        SDL_EVENT_JOYSTICK_BUTTON_UP,
        SDL_EVENT_JOYSTICK_ADDED,
        SDL_EVENT_JOYSTICK_REMOVED,
        SDL_EVENT_JOYSTICK_BATTERY_UPDATED,
        SDL_EVENT_JOYSTICK_UPDATE_COMPLETE,
        SDL_EVENT_JOYSTICK_FIRST = SDL_EVENT_JOYSTICK_AXIS_MOTION,
        SDL_EVENT_JOYSTICK_LAST = SDL_EVENT_JOYSTICK_UPDATE_COMPLETE,
        SDL_EVENT_GAMEPAD_AXIS_MOTION = 0x650,
        SDL_EVENT_GAMEPAD_BUTTON_DOWN,
        SDL_EVENT_GAMEPAD_BUTTON_UP,
        SDL_EVENT_GAMEPAD_ADDED,
        SDL_EVENT_GAMEPAD_REMOVED,
        SDL_EVENT_GAMEPAD_REMAPPED,
        SDL_EVENT_GAMEPAD_TOUCHPAD_DOWN,
        SDL_EVENT_GAMEPAD_TOUCHPAD_MOTION,
        SDL_EVENT_GAMEPAD_TOUCHPAD_UP,
        SDL_EVENT_GAMEPAD_SENSOR_UPDATE,
        SDL_EVENT_GAMEPAD_UPDATE_COMPLETE,
        SDL_EVENT_GAMEPAD_STEAM_HANDLE_UPDATED,
        SDL_EVENT_GAMEPAD_CAPSENSE_TOUCH,
        SDL_EVENT_GAMEPAD_CAPSENSE_RELEASE,
        SDL_EVENT_GAMEPAD_FIRST = SDL_EVENT_GAMEPAD_AXIS_MOTION,
        SDL_EVENT_GAMEPAD_LAST = SDL_EVENT_GAMEPAD_CAPSENSE_RELEASE,
        SDL_EVENT_FINGER_DOWN = 0x700,
        SDL_EVENT_FINGER_UP,
        SDL_EVENT_FINGER_MOTION,
        SDL_EVENT_FINGER_CANCELED,
        SDL_EVENT_FINGER_FIRST = SDL_EVENT_FINGER_DOWN,
        SDL_EVENT_FINGER_LAST = SDL_EVENT_FINGER_CANCELED,
        SDL_EVENT_PINCH_BEGIN = 0x710,
        SDL_EVENT_PINCH_UPDATE,
        SDL_EVENT_PINCH_END,
        SDL_EVENT_PINCH_FIRST = SDL_EVENT_PINCH_BEGIN,
        SDL_EVENT_PINCH_LAST = SDL_EVENT_PINCH_END,
        SDL_EVENT_CLIPBOARD_UPDATE = 0x900,
        SDL_EVENT_CLIPBOARD_FIRST = SDL_EVENT_CLIPBOARD_UPDATE,
        SDL_EVENT_CLIPBOARD_LAST = SDL_EVENT_CLIPBOARD_UPDATE,
        SDL_EVENT_DROP_FILE = 0x1000,
        SDL_EVENT_DROP_TEXT,
        SDL_EVENT_DROP_BEGIN,
        SDL_EVENT_DROP_COMPLETE,
        SDL_EVENT_DROP_POSITION,
        SDL_EVENT_DROP_FIRST = SDL_EVENT_DROP_FILE,
        SDL_EVENT_DROP_LAST = SDL_EVENT_DROP_POSITION,
        SDL_EVENT_AUDIO_DEVICE_ADDED = 0x1100,
        SDL_EVENT_AUDIO_DEVICE_REMOVED,
        SDL_EVENT_AUDIO_DEVICE_FORMAT_CHANGED,
        SDL_EVENT_AUDIO_DEVICE_FIRST = SDL_EVENT_AUDIO_DEVICE_ADDED,
        SDL_EVENT_AUDIO_DEVICE_LAST = SDL_EVENT_AUDIO_DEVICE_FORMAT_CHANGED,
        SDL_EVENT_SENSOR_UPDATE = 0x1200,
        SDL_EVENT_SENSOR_FIRST = SDL_EVENT_SENSOR_UPDATE,
        SDL_EVENT_SENSOR_LAST = SDL_EVENT_SENSOR_UPDATE,
        SDL_EVENT_PEN_PROXIMITY_IN = 0x1300,
        SDL_EVENT_PEN_PROXIMITY_OUT,
        SDL_EVENT_PEN_DOWN,
        SDL_EVENT_PEN_UP,
        SDL_EVENT_PEN_BUTTON_DOWN,
        SDL_EVENT_PEN_BUTTON_UP,
        SDL_EVENT_PEN_MOTION,
        SDL_EVENT_PEN_AXIS,
        SDL_EVENT_PEN_FIRST = SDL_EVENT_PEN_PROXIMITY_IN,
        SDL_EVENT_PEN_LAST = SDL_EVENT_PEN_AXIS,
        SDL_EVENT_CAMERA_DEVICE_ADDED = 0x1400,
        SDL_EVENT_CAMERA_DEVICE_REMOVED,
        SDL_EVENT_CAMERA_DEVICE_APPROVED,
        SDL_EVENT_CAMERA_DEVICE_DENIED,
        SDL_EVENT_CAMERA_DEVICE_FIRST = SDL_EVENT_CAMERA_DEVICE_ADDED,
        SDL_EVENT_CAMERA_DEVICE_LAST = SDL_EVENT_CAMERA_DEVICE_DENIED,
        SDL_EVENT_NOTIFICATION_ACTION_INVOKED = 0x1500,
        SDL_EVENT_NOTIFICATION_FIRST = SDL_EVENT_NOTIFICATION_ACTION_INVOKED,
        SDL_EVENT_NOTIFICATION_LAST = SDL_EVENT_NOTIFICATION_ACTION_INVOKED,
        SDL_EVENT_RENDER_TARGETS_RESET = 0x2000,
        SDL_EVENT_RENDER_DEVICE_RESET,
        SDL_EVENT_RENDER_DEVICE_LOST,
        SDL_EVENT_RENDER_FIRST = SDL_EVENT_RENDER_TARGETS_RESET,
        SDL_EVENT_RENDER_LAST = SDL_EVENT_RENDER_DEVICE_LOST,
        SDL_EVENT_PRIVATE0 = 0x4000,
        SDL_EVENT_PRIVATE1,
        SDL_EVENT_PRIVATE2,
        SDL_EVENT_PRIVATE3,
        SDL_EVENT_POLL_SENTINEL = 0x7F00,
        SDL_EVENT_USER = 0x8000,
        SDL_EVENT_LAST = 0xFFFF,
        SDL_EVENT_ENUM_PADDING = 0x7FFFFFFF,
    }

    internal partial struct SDL_CommonEvent
    {
        private uint type;

        private uint reserved;

        private ulong timestamp;
    }

    internal partial struct SDL_DisplayEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint displayID;

        private int data1;

        private int data2;
    }

    internal partial struct SDL_WindowEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private int data1;

        private int data2;
    }

    internal partial struct SDL_KeyboardDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;
    }

    internal partial struct SDL_KeyboardEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private SDL_Scancode scancode;

        private uint key;

        private ushort mod;

        private ushort raw;

        private SDL_Bool down;

        private SDL_Bool repeat;
    }

    internal unsafe partial struct SDL_TextEditingEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private byte* text;

        private int start;

        private int length;
    }

    internal unsafe partial struct SDL_TextEditingCandidatesEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private byte** candidates;

        private int num_candidates;

        private int selected_candidate;

        private SDL_Bool horizontal;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }

    internal unsafe partial struct SDL_TextInputEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private byte* text;
    }

    internal partial struct SDL_MouseDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;
    }

    internal partial struct SDL_MouseMotionEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint state;

        private float x;

        private float y;

        private float xrel;

        private float yrel;
    }

    internal partial struct SDL_MouseButtonEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private byte button;

        private SDL_Bool down;

        private byte clicks;

        private byte padding;

        private float x;

        private float y;
    }

    internal partial struct SDL_MouseWheelEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private float x;

        private float y;

        private SDL_MouseWheelDirection direction;

        private float mouse_x;

        private float mouse_y;

        private int integer_x;

        private int integer_y;
    }

    internal partial struct SDL_JoyAxisEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte axis;

        private byte padding1;

        private byte padding2;

        private byte padding3;

        private short value;

        private ushort padding4;
    }

    internal partial struct SDL_JoyBallEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte ball;

        private byte padding1;

        private byte padding2;

        private byte padding3;

        private short xrel;

        private short yrel;
    }

    internal partial struct SDL_JoyHatEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte hat;

        private byte value;

        private byte padding1;

        private byte padding2;
    }

    internal partial struct SDL_JoyButtonEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte button;

        private SDL_Bool down;

        private byte padding1;

        private byte padding2;
    }

    internal partial struct SDL_JoyDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;
    }

    internal partial struct SDL_JoyBatteryEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private SDL_PowerState state;

        private int percent;
    }

    internal partial struct SDL_GamepadAxisEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte axis;

        private byte padding1;

        private byte padding2;

        private byte padding3;

        private short value;

        private ushort padding4;
    }

    internal partial struct SDL_GamepadButtonEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte button;

        private SDL_Bool down;

        private byte padding1;

        private byte padding2;
    }

    internal partial struct SDL_GamepadDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;
    }

    internal partial struct SDL_GamepadTouchpadEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private int touchpad;

        private int finger;

        private float x;

        private float y;

        private float pressure;
    }

    internal partial struct SDL_GamepadSensorEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private int sensor;

        private _data_e__FixedBuffer data;

        private ulong sensor_timestamp;

        [InlineArray(3)]
        public partial struct _data_e__FixedBuffer
        {
            private float e0;
        }
    }

    internal partial struct SDL_GamepadCapSenseEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte capsense;

        private SDL_Bool down;

        private byte padding1;

        private byte padding2;
    }

    internal partial struct SDL_AudioDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private SDL_Bool recording;

        private byte padding1;

        private byte padding2;

        private byte padding3;
    }

    internal partial struct SDL_CameraDeviceEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;
    }

    internal unsafe partial struct SDL_NotificationEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private byte* action_id;
    }

    internal partial struct SDL_RenderEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;
    }

    internal partial struct SDL_TouchFingerEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private ulong touchID;

        private ulong fingerID;

        private float x;

        private float y;

        private float dx;

        private float dy;

        private float pressure;

        private uint windowID;
    }

    internal partial struct SDL_PinchFingerEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private float scale;

        private uint windowID;

        private float span_x;

        private float span_y;

        private float focus_x;

        private float focus_y;
    }

    internal partial struct SDL_PenProximityEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint pen_state;

        private SDL_PenDeviceType device_type;
    }

    internal partial struct SDL_PenMotionEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint pen_state;

        private float x;

        private float y;

        private SDL_PenDeviceType device_type;
    }

    internal partial struct SDL_PenTouchEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint pen_state;

        private float x;

        private float y;

        private SDL_Bool eraser;

        private SDL_Bool down;

        private SDL_PenDeviceType device_type;
    }

    internal partial struct SDL_PenButtonEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint pen_state;

        private float x;

        private float y;

        private byte button;

        private SDL_Bool down;

        private SDL_PenDeviceType device_type;
    }

    internal partial struct SDL_PenAxisEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private uint which;

        private uint pen_state;

        private float x;

        private float y;

        private SDL_PenAxis axis;

        private float value;

        private SDL_PenDeviceType device_type;
    }

    internal unsafe partial struct SDL_DropEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private float x;

        private float y;

        private byte* source;

        private byte* data;
    }

    internal unsafe partial struct SDL_ClipboardEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private SDL_Bool owner;

        private int num_mime_types;

        private byte** mime_types;
    }

    internal partial struct SDL_SensorEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;

        private uint which;

        private _data_e__FixedBuffer data;

        private ulong sensor_timestamp;

        [InlineArray(6)]
        public partial struct _data_e__FixedBuffer
        {
            private float e0;
        }
    }

    internal partial struct SDL_QuitEvent
    {
        private SDL_EventType type;

        private uint reserved;

        private ulong timestamp;
    }

    internal partial struct SDL_UserEvent
    {
        private uint type;

        private uint reserved;

        private ulong timestamp;

        private uint windowID;

        private int code;

        private IntPtr data1;

        private IntPtr data2;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal partial struct SDL_Event
    {
        [FieldOffset(0)]
        private uint type;

        [FieldOffset(0)]
        private SDL_CommonEvent common;

        [FieldOffset(0)]
        private SDL_DisplayEvent display;

        [FieldOffset(0)]
        private SDL_WindowEvent window;

        [FieldOffset(0)]
        private SDL_KeyboardDeviceEvent kdevice;

        [FieldOffset(0)]
        private SDL_KeyboardEvent key;

        [FieldOffset(0)]
        private SDL_TextEditingEvent edit;

        [FieldOffset(0)]
        private SDL_TextEditingCandidatesEvent edit_candidates;

        [FieldOffset(0)]
        private SDL_TextInputEvent text;

        [FieldOffset(0)]
        private SDL_MouseDeviceEvent mdevice;

        [FieldOffset(0)]
        private SDL_MouseMotionEvent motion;

        [FieldOffset(0)]
        private SDL_MouseButtonEvent button;

        [FieldOffset(0)]
        private SDL_MouseWheelEvent wheel;

        [FieldOffset(0)]
        private SDL_JoyDeviceEvent jdevice;

        [FieldOffset(0)]
        private SDL_JoyAxisEvent jaxis;

        [FieldOffset(0)]
        private SDL_JoyBallEvent jball;

        [FieldOffset(0)]
        private SDL_JoyHatEvent jhat;

        [FieldOffset(0)]
        private SDL_JoyButtonEvent jbutton;

        [FieldOffset(0)]
        private SDL_JoyBatteryEvent jbattery;

        [FieldOffset(0)]
        private SDL_GamepadDeviceEvent gdevice;

        [FieldOffset(0)]
        private SDL_GamepadAxisEvent gaxis;

        [FieldOffset(0)]
        private SDL_GamepadButtonEvent gbutton;

        [FieldOffset(0)]
        private SDL_GamepadTouchpadEvent gtouchpad;

        [FieldOffset(0)]
        private SDL_GamepadSensorEvent gsensor;

        [FieldOffset(0)]
        private SDL_GamepadCapSenseEvent gcapsense;

        [FieldOffset(0)]
        private SDL_AudioDeviceEvent adevice;

        [FieldOffset(0)]
        private SDL_CameraDeviceEvent cdevice;

        [FieldOffset(0)]
        private SDL_SensorEvent sensor;

        [FieldOffset(0)]
        private SDL_QuitEvent quit;

        [FieldOffset(0)]
        private SDL_UserEvent user;

        [FieldOffset(0)]
        private SDL_TouchFingerEvent tfinger;

        [FieldOffset(0)]
        private SDL_PinchFingerEvent pinch;

        [FieldOffset(0)]
        private SDL_PenProximityEvent pproximity;

        [FieldOffset(0)]
        private SDL_PenTouchEvent ptouch;

        [FieldOffset(0)]
        private SDL_PenMotionEvent pmotion;

        [FieldOffset(0)]
        private SDL_PenButtonEvent pbutton;

        [FieldOffset(0)]
        private SDL_PenAxisEvent paxis;

        [FieldOffset(0)]
        private SDL_RenderEvent render;

        [FieldOffset(0)]
        private SDL_DropEvent drop;

        [FieldOffset(0)]
        private SDL_ClipboardEvent clipboard;

        [FieldOffset(0)]
        private SDL_NotificationEvent notification;

        [FieldOffset(0)]
        private _padding_e__FixedBuffer padding;

        [InlineArray(128)]
        public partial struct _padding_e__FixedBuffer
        {
            private byte e0;
        }
    }

    internal enum SDL_EventAction
    {
        SDL_ADDEVENT,
        SDL_PEEKEVENT,
        SDL_GETEVENT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate SDL_Bool SDL_EventFilter(IntPtr userdata, SDL_Event* @event);

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PumpEvents", ExactSpelling = true)]
        private static extern void iSDL_PumpEvents();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PeepEvents", ExactSpelling = true)]
        private static extern int iSDL_PeepEvents(SDL_Event* events, int numevents, SDL_EventAction action, uint minType, uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasEvent(uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvents", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasEvents(uint minType, uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvent", ExactSpelling = true)]
        private static extern void iSDL_FlushEvent(uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushEvents", ExactSpelling = true)]
        private static extern void iSDL_FlushEvents(uint minType, uint maxType);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PollEvent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_PollEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEvent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WaitEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitEventTimeout", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WaitEventTimeout(SDL_Event* @event, int timeoutMS);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_PushEvent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_PushEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventFilter", ExactSpelling = true)]
        private static extern void iSDL_SetEventFilter(IntPtr filter, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEventFilter", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetEventFilter(IntPtr* filter, IntPtr* userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddEventWatch", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_AddEventWatch(IntPtr filter, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RemoveEventWatch", ExactSpelling = true)]
        private static extern void iSDL_RemoveEventWatch(IntPtr filter, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FilterEvents", ExactSpelling = true)]
        private static extern void iSDL_FilterEvents(IntPtr filter, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEventEnabled", ExactSpelling = true)]
        private static extern void iSDL_SetEventEnabled(uint type, SDL_Bool enabled);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_EventEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_EventEnabled(uint type);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RegisterEvents", ExactSpelling = true)]
        private static extern uint iSDL_RegisterEvents(int numevents);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetWindowFromEvent", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetWindowFromEvent(SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEventDescription", ExactSpelling = true)]
        private static extern int iSDL_GetEventDescription(SDL_Event* @event, byte* buf, int buflen);
    }
}
