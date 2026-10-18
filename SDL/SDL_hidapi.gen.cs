using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_hid_device
    {
    }

    internal enum SDL_hid_bus_type
    {
        SDL_HID_API_BUS_UNKNOWN = 0x00,
        SDL_HID_API_BUS_USB = 0x01,
        SDL_HID_API_BUS_BLUETOOTH = 0x02,
        SDL_HID_API_BUS_I2C = 0x03,
        SDL_HID_API_BUS_SPI = 0x04,
    }

    internal unsafe partial struct SDL_hid_device_info
    {
        private byte* path;

        private ushort vendor_id;

        private ushort product_id;

        private ushort* serial_number;

        private ushort release_number;

        private ushort* manufacturer_string;

        private ushort* product_string;

        private ushort usage_page;

        private ushort usage;

        private int interface_number;

        private int interface_class;

        private int interface_subclass;

        private int interface_protocol;

        private SDL_hid_bus_type bus_type;

        private SDL_hid_device_info* next;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_init", ExactSpelling = true)]
        private static extern int iSDL_hid_init();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_exit", ExactSpelling = true)]
        private static extern int iSDL_hid_exit();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_device_change_count", ExactSpelling = true)]
        private static extern uint iSDL_hid_device_change_count();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_enumerate", ExactSpelling = true)]
        private static extern SDL_hid_device_info* iSDL_hid_enumerate(ushort vendor_id, ushort product_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_free_enumeration", ExactSpelling = true)]
        private static extern void iSDL_hid_free_enumeration(SDL_hid_device_info* devs);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open", ExactSpelling = true)]
        private static extern SDL_hid_device* iSDL_hid_open(ushort vendor_id, ushort product_id, ushort* serial_number);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_open_path", ExactSpelling = true)]
        private static extern SDL_hid_device* iSDL_hid_open_path(byte* path);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_properties", ExactSpelling = true)]
        private static extern uint iSDL_hid_get_properties(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_write", ExactSpelling = true)]
        private static extern int iSDL_hid_write(SDL_hid_device* dev, byte* data, nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read_timeout", ExactSpelling = true)]
        private static extern int iSDL_hid_read_timeout(SDL_hid_device* dev, byte* data, nuint length, int milliseconds);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_read", ExactSpelling = true)]
        private static extern int iSDL_hid_read(SDL_hid_device* dev, byte* data, nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_set_nonblocking", ExactSpelling = true)]
        private static extern int iSDL_hid_set_nonblocking(SDL_hid_device* dev, int nonblock);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_send_feature_report", ExactSpelling = true)]
        private static extern int iSDL_hid_send_feature_report(SDL_hid_device* dev, byte* data, nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_feature_report", ExactSpelling = true)]
        private static extern int iSDL_hid_get_feature_report(SDL_hid_device* dev, byte* data, nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_input_report", ExactSpelling = true)]
        private static extern int iSDL_hid_get_input_report(SDL_hid_device* dev, byte* data, nuint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_close", ExactSpelling = true)]
        private static extern int iSDL_hid_close(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_manufacturer_string", ExactSpelling = true)]
        private static extern int iSDL_hid_get_manufacturer_string(SDL_hid_device* dev, ushort* @string, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_product_string", ExactSpelling = true)]
        private static extern int iSDL_hid_get_product_string(SDL_hid_device* dev, ushort* @string, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_serial_number_string", ExactSpelling = true)]
        private static extern int iSDL_hid_get_serial_number_string(SDL_hid_device* dev, ushort* @string, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_indexed_string", ExactSpelling = true)]
        private static extern int iSDL_hid_get_indexed_string(SDL_hid_device* dev, int string_index, ushort* @string, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_device_info", ExactSpelling = true)]
        private static extern SDL_hid_device_info* iSDL_hid_get_device_info(SDL_hid_device* dev);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_get_report_descriptor", ExactSpelling = true)]
        private static extern int iSDL_hid_get_report_descriptor(SDL_hid_device* dev, byte* buf, nuint buf_size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_hid_ble_scan", ExactSpelling = true)]
        private static extern void iSDL_hid_ble_scan(SDL_Bool active);

        public static string SDL_PROP_HIDAPI_LIBUSB_DEVICE_HANDLE_POINTER => "SDL.hidapi.libusb.device.handle";
    }
}
