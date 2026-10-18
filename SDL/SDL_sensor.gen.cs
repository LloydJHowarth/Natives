using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Sensor
    {
    }

    internal enum SDL_SensorType
    {
        SDL_SENSOR_INVALID = -1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R,
        SDL_SENSOR_COUNT,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensors", ExactSpelling = true)]
        private static extern uint* iSDL_GetSensors(int* count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNameForID", ExactSpelling = true)]
        private static extern byte* iSDL_GetSensorNameForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorTypeForID", ExactSpelling = true)]
        private static extern SDL_SensorType iSDL_GetSensorTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableTypeForID", ExactSpelling = true)]
        private static extern int iSDL_GetSensorNonPortableTypeForID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_OpenSensor", ExactSpelling = true)]
        private static extern SDL_Sensor* iSDL_OpenSensor(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorFromID", ExactSpelling = true)]
        private static extern SDL_Sensor* iSDL_GetSensorFromID(uint instance_id);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetSensorProperties(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorName", ExactSpelling = true)]
        private static extern byte* iSDL_GetSensorName(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorType", ExactSpelling = true)]
        private static extern SDL_SensorType iSDL_GetSensorType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorNonPortableType", ExactSpelling = true)]
        private static extern int iSDL_GetSensorNonPortableType(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorID", ExactSpelling = true)]
        private static extern uint iSDL_GetSensorID(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetSensorData", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CloseSensor", ExactSpelling = true)]
        private static extern void iSDL_CloseSensor(SDL_Sensor* sensor);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateSensors", ExactSpelling = true)]
        private static extern void iSDL_UpdateSensors();

        public const float SDL_STANDARD_GRAVITY = 9.80665f;
    }
}
