using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Process
    {
    }

    internal enum SDL_ProcessIO
    {
        SDL_PROCESS_STDIO_INHERITED,
        SDL_PROCESS_STDIO_NULL,
        SDL_PROCESS_STDIO_APP,
        SDL_PROCESS_STDIO_REDIRECT,
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcess", ExactSpelling = true)]
        private static extern SDL_Process* iSDL_CreateProcess(byte** args, SDL_Bool pipe_stdio);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateProcessWithProperties", ExactSpelling = true)]
        private static extern SDL_Process* iSDL_CreateProcessWithProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetProcessProperties(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ReadProcess", ExactSpelling = true)]
        private static extern IntPtr iSDL_ReadProcess(SDL_Process* process, nuint* datasize, int* exitcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessInput", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_GetProcessInput(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetProcessOutput", ExactSpelling = true)]
        private static extern SDL_IOStream* iSDL_GetProcessOutput(SDL_Process* process);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_KillProcess", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_KillProcess(SDL_Process* process, SDL_Bool force);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_WaitProcess", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_WaitProcess(SDL_Process* process, SDL_Bool block, int* exitcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyProcess", ExactSpelling = true)]
        private static extern void iSDL_DestroyProcess(SDL_Process* process);

        public static string SDL_PROP_PROCESS_CREATE_ARGS_POINTER => "SDL.process.create.args";

        public static string SDL_PROP_PROCESS_CREATE_ENVIRONMENT_POINTER => "SDL.process.create.environment";

        public static string SDL_PROP_PROCESS_CREATE_WORKING_DIRECTORY_STRING => "SDL.process.create.working_directory";

        public static string SDL_PROP_PROCESS_CREATE_STDIN_NUMBER => "SDL.process.create.stdin_option";

        public static string SDL_PROP_PROCESS_CREATE_STDIN_POINTER => "SDL.process.create.stdin_source";

        public static string SDL_PROP_PROCESS_CREATE_STDOUT_NUMBER => "SDL.process.create.stdout_option";

        public static string SDL_PROP_PROCESS_CREATE_STDOUT_POINTER => "SDL.process.create.stdout_source";

        public static string SDL_PROP_PROCESS_CREATE_STDERR_NUMBER => "SDL.process.create.stderr_option";

        public static string SDL_PROP_PROCESS_CREATE_STDERR_POINTER => "SDL.process.create.stderr_source";

        public static string SDL_PROP_PROCESS_CREATE_STDERR_TO_STDOUT_BOOLEAN => "SDL.process.create.stderr_to_stdout";

        public static string SDL_PROP_PROCESS_CREATE_BACKGROUND_BOOLEAN => "SDL.process.create.background";

        public static string SDL_PROP_PROCESS_CREATE_CMDLINE_STRING => "SDL.process.create.cmdline";

        public static string SDL_PROP_PROCESS_PID_NUMBER => "SDL.process.pid";

        public static string SDL_PROP_PROCESS_STDIN_POINTER => "SDL.process.stdin";

        public static string SDL_PROP_PROCESS_STDOUT_POINTER => "SDL.process.stdout";

        public static string SDL_PROP_PROCESS_STDERR_POINTER => "SDL.process.stderr";

        public static string SDL_PROP_PROCESS_BACKGROUND_BOOLEAN => "SDL.process.background";
    }
}
