using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_alignment_test
    {
        private byte a;

        private IntPtr b;
    }

    internal enum SDL_DUMMY_ENUM
    {
        DUMMY_ENUM_VALUE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr SDL_malloc_func(nuint size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr SDL_calloc_func(nuint nmemb, nuint size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate IntPtr SDL_realloc_func(IntPtr mem, nuint size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_free_func(IntPtr mem);

    internal partial struct SDL_Environment
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int SDL_CompareCallback(IntPtr a, IntPtr b);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int SDL_CompareCallback_r(IntPtr userdata, IntPtr a, IntPtr b);

    internal partial struct SDL_iconv_data_t
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void SDL_FunctionPointer();

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_malloc", ExactSpelling = true)]
        private static extern IntPtr iSDL_malloc(nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_calloc", ExactSpelling = true)]
        private static extern IntPtr iSDL_calloc(nuint nmemb, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_realloc", ExactSpelling = true)]
        private static extern IntPtr iSDL_realloc(IntPtr mem, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_free", ExactSpelling = true)]
        private static extern void iSDL_free(IntPtr mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetOriginalMemoryFunctions", ExactSpelling = true)]
        private static extern void iSDL_GetOriginalMemoryFunctions(IntPtr* malloc_func, IntPtr* calloc_func, IntPtr* realloc_func, IntPtr* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetMemoryFunctions", ExactSpelling = true)]
        private static extern void iSDL_GetMemoryFunctions(IntPtr* malloc_func, IntPtr* calloc_func, IntPtr* realloc_func, IntPtr* free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetMemoryFunctions", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetMemoryFunctions(IntPtr malloc_func, IntPtr calloc_func, IntPtr realloc_func, IntPtr free_func);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc", ExactSpelling = true)]
        private static extern IntPtr iSDL_aligned_alloc(nuint alignment, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_alloc_zero", ExactSpelling = true)]
        private static extern IntPtr iSDL_aligned_alloc_zero(nuint alignment, nuint size);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_aligned_free", ExactSpelling = true)]
        private static extern void iSDL_aligned_free(IntPtr mem);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumAllocations", ExactSpelling = true)]
        private static extern int iSDL_GetNumAllocations();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironment", ExactSpelling = true)]
        private static extern SDL_Environment* iSDL_GetEnvironment();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateEnvironment", ExactSpelling = true)]
        private static extern SDL_Environment* iSDL_CreateEnvironment(SDL_Bool populated);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariable", ExactSpelling = true)]
        private static extern byte* iSDL_GetEnvironmentVariable(SDL_Environment* env, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetEnvironmentVariables", ExactSpelling = true)]
        private static extern byte** iSDL_GetEnvironmentVariables(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetEnvironmentVariable", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetEnvironmentVariable(SDL_Environment* env, byte* name, byte* value, SDL_Bool overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnsetEnvironmentVariable", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UnsetEnvironmentVariable(SDL_Environment* env, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyEnvironment", ExactSpelling = true)]
        private static extern void iSDL_DestroyEnvironment(SDL_Environment* env);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv", ExactSpelling = true)]
        private static extern byte* iSDL_getenv(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_getenv_unsafe", ExactSpelling = true)]
        private static extern byte* iSDL_getenv_unsafe(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_setenv_unsafe", ExactSpelling = true)]
        private static extern int iSDL_setenv_unsafe(byte* name, byte* value, int overwrite);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_unsetenv_unsafe", ExactSpelling = true)]
        private static extern int iSDL_unsetenv_unsafe(byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort", ExactSpelling = true)]
        private static extern void iSDL_qsort(IntPtr @base, nuint nmemb, nuint size, IntPtr compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch", ExactSpelling = true)]
        private static extern IntPtr iSDL_bsearch(IntPtr key, IntPtr @base, nuint nmemb, nuint size, IntPtr compare);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_qsort_r", ExactSpelling = true)]
        private static extern void iSDL_qsort_r(IntPtr @base, nuint nmemb, nuint size, IntPtr compare, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_bsearch_r", ExactSpelling = true)]
        private static extern IntPtr iSDL_bsearch_r(IntPtr key, IntPtr @base, nuint nmemb, nuint size, IntPtr compare, IntPtr userdata);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_abs", ExactSpelling = true)]
        private static extern int iSDL_abs(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalpha", ExactSpelling = true)]
        private static extern int iSDL_isalpha(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isalnum", ExactSpelling = true)]
        private static extern int iSDL_isalnum(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isblank", ExactSpelling = true)]
        private static extern int iSDL_isblank(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iscntrl", ExactSpelling = true)]
        private static extern int iSDL_iscntrl(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isdigit", ExactSpelling = true)]
        private static extern int iSDL_isdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isxdigit", ExactSpelling = true)]
        private static extern int iSDL_isxdigit(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ispunct", ExactSpelling = true)]
        private static extern int iSDL_ispunct(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isspace", ExactSpelling = true)]
        private static extern int iSDL_isspace(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isupper", ExactSpelling = true)]
        private static extern int iSDL_isupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_islower", ExactSpelling = true)]
        private static extern int iSDL_islower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isprint", ExactSpelling = true)]
        private static extern int iSDL_isprint(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isgraph", ExactSpelling = true)]
        private static extern int iSDL_isgraph(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_toupper", ExactSpelling = true)]
        private static extern int iSDL_toupper(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tolower", ExactSpelling = true)]
        private static extern int iSDL_tolower(int x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc16", ExactSpelling = true)]
        private static extern ushort iSDL_crc16(ushort crc, IntPtr data, nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_crc32", ExactSpelling = true)]
        private static extern uint iSDL_crc32(uint crc, IntPtr data, nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_murmur3_32", ExactSpelling = true)]
        private static extern uint iSDL_murmur3_32(IntPtr data, nuint len, uint seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memset4", ExactSpelling = true)]
        private static extern IntPtr iSDL_memset4(IntPtr dst, uint val, nuint dwords);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_memcmp", ExactSpelling = true)]
        private static extern int iSDL_memcmp(IntPtr s1, IntPtr s2, nuint len);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslen", ExactSpelling = true)]
        private static extern nuint iSDL_wcslen(ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnlen", ExactSpelling = true)]
        private static extern nuint iSDL_wcsnlen(ushort* wstr, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcpy", ExactSpelling = true)]
        private static extern nuint iSDL_wcslcpy(ushort* dst, ushort* src, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcslcat", ExactSpelling = true)]
        private static extern nuint iSDL_wcslcat(ushort* dst, ushort* src, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsdup", ExactSpelling = true)]
        private static extern ushort* iSDL_wcsdup(ushort* wstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsstr", ExactSpelling = true)]
        private static extern ushort* iSDL_wcsstr(ushort* haystack, ushort* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsnstr", ExactSpelling = true)]
        private static extern ushort* iSDL_wcsnstr(ushort* haystack, ushort* needle, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscmp", ExactSpelling = true)]
        private static extern int iSDL_wcscmp(ushort* str1, ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncmp", ExactSpelling = true)]
        private static extern int iSDL_wcsncmp(ushort* str1, ushort* str2, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcscasecmp", ExactSpelling = true)]
        private static extern int iSDL_wcscasecmp(ushort* str1, ushort* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcsncasecmp", ExactSpelling = true)]
        private static extern int iSDL_wcsncasecmp(ushort* str1, ushort* str2, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstol", ExactSpelling = true)]
        private static extern int iSDL_wcstol(ushort* str, ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstoul", ExactSpelling = true)]
        private static extern uint iSDL_wcstoul(ushort* str, ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstoll", ExactSpelling = true)]
        private static extern long iSDL_wcstoll(ushort* str, ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_wcstoull", ExactSpelling = true)]
        private static extern ulong iSDL_wcstoull(ushort* str, ushort** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlen", ExactSpelling = true)]
        private static extern nuint iSDL_strlen(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnlen", ExactSpelling = true)]
        private static extern nuint iSDL_strnlen(byte* str, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcpy", ExactSpelling = true)]
        private static extern nuint iSDL_strlcpy(byte* dst, byte* src, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlcpy", ExactSpelling = true)]
        private static extern nuint iSDL_utf8strlcpy(byte* dst, byte* src, nuint dst_bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlcat", ExactSpelling = true)]
        private static extern nuint iSDL_strlcat(byte* dst, byte* src, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strdup", ExactSpelling = true)]
        private static extern byte* iSDL_strdup(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strndup", ExactSpelling = true)]
        private static extern byte* iSDL_strndup(byte* str, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrev", ExactSpelling = true)]
        private static extern byte* iSDL_strrev(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strupr", ExactSpelling = true)]
        private static extern byte* iSDL_strupr(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strlwr", ExactSpelling = true)]
        private static extern byte* iSDL_strlwr(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strchr", ExactSpelling = true)]
        private static extern byte* iSDL_strchr(byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strrchr", ExactSpelling = true)]
        private static extern byte* iSDL_strrchr(byte* str, int c);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strstr", ExactSpelling = true)]
        private static extern byte* iSDL_strstr(byte* haystack, byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strnstr", ExactSpelling = true)]
        private static extern byte* iSDL_strnstr(byte* haystack, byte* needle, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasestr", ExactSpelling = true)]
        private static extern byte* iSDL_strcasestr(byte* haystack, byte* needle);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtok_r", ExactSpelling = true)]
        private static extern byte* iSDL_strtok_r(byte* str, byte* delim, byte** saveptr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strlen", ExactSpelling = true)]
        private static extern nuint iSDL_utf8strlen(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_utf8strnlen", ExactSpelling = true)]
        private static extern nuint iSDL_utf8strnlen(byte* str, nuint bytes);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_itoa", ExactSpelling = true)]
        private static extern byte* iSDL_itoa(int value, byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_uitoa", ExactSpelling = true)]
        private static extern byte* iSDL_uitoa(uint value, byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ltoa", ExactSpelling = true)]
        private static extern byte* iSDL_ltoa(int value, byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ultoa", ExactSpelling = true)]
        private static extern byte* iSDL_ultoa(uint value, byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lltoa", ExactSpelling = true)]
        private static extern byte* iSDL_lltoa(long value, byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ulltoa", ExactSpelling = true)]
        private static extern byte* iSDL_ulltoa(ulong value, byte* str, int radix);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atoi", ExactSpelling = true)]
        private static extern int iSDL_atoi(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atof", ExactSpelling = true)]
        private static extern double iSDL_atof(byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtol", ExactSpelling = true)]
        private static extern int iSDL_strtol(byte* str, byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoul", ExactSpelling = true)]
        private static extern uint iSDL_strtoul(byte* str, byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoll", ExactSpelling = true)]
        private static extern long iSDL_strtoll(byte* str, byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtoull", ExactSpelling = true)]
        private static extern ulong iSDL_strtoull(byte* str, byte** endp, int @base);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strtod", ExactSpelling = true)]
        private static extern double iSDL_strtod(byte* str, byte** endp);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcmp", ExactSpelling = true)]
        private static extern int iSDL_strcmp(byte* str1, byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncmp", ExactSpelling = true)]
        private static extern int iSDL_strncmp(byte* str1, byte* str2, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strcasecmp", ExactSpelling = true)]
        private static extern int iSDL_strcasecmp(byte* str1, byte* str2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strncasecmp", ExactSpelling = true)]
        private static extern int iSDL_strncasecmp(byte* str1, byte* str2, nuint maxlen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_strpbrk", ExactSpelling = true)]
        private static extern byte* iSDL_strpbrk(byte* str, byte* breakset);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepUTF8", ExactSpelling = true)]
        private static extern uint iSDL_StepUTF8(byte** pstr, nuint* pslen);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_StepBackUTF8", ExactSpelling = true)]
        private static extern uint iSDL_StepBackUTF8(byte* start, byte** pstr);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UCS4ToUTF8", ExactSpelling = true)]
        private static extern byte* iSDL_UCS4ToUTF8(uint codepoint, byte* dst);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sscanf", ExactSpelling = true)]
        private static extern int iSDL_sscanf(byte* text, byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsscanf", ExactSpelling = true)]
        private static extern int iSDL_vsscanf(byte* text, byte* fmt, byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_snprintf", ExactSpelling = true)]
        private static extern int iSDL_snprintf(byte* text, nuint maxlen, byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_swprintf", ExactSpelling = true)]
        private static extern int iSDL_swprintf(ushort* text, nuint maxlen, ushort* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vsnprintf", ExactSpelling = true)]
        private static extern int iSDL_vsnprintf(byte* text, nuint maxlen, byte* fmt, byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vswprintf", ExactSpelling = true)]
        private static extern int iSDL_vswprintf(ushort* text, nuint maxlen, ushort* fmt, byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asprintf", ExactSpelling = true)]
        private static extern int iSDL_asprintf(byte** strp, byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_vasprintf", ExactSpelling = true)]
        private static extern int iSDL_vasprintf(byte** strp, byte* fmt, byte* ap);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_srand", ExactSpelling = true)]
        private static extern void iSDL_srand(ulong seed);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand", ExactSpelling = true)]
        private static extern int iSDL_rand(int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf", ExactSpelling = true)]
        private static extern float iSDL_randf();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits", ExactSpelling = true)]
        private static extern uint iSDL_rand_bits();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_r", ExactSpelling = true)]
        private static extern int iSDL_rand_r(ulong* state, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_randf_r", ExactSpelling = true)]
        private static extern float iSDL_randf_r(ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_rand_bits_r", ExactSpelling = true)]
        private static extern uint iSDL_rand_bits_r(ulong* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acos", ExactSpelling = true)]
        private static extern double iSDL_acos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_acosf", ExactSpelling = true)]
        private static extern float iSDL_acosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asin", ExactSpelling = true)]
        private static extern double iSDL_asin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_asinf", ExactSpelling = true)]
        private static extern float iSDL_asinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan", ExactSpelling = true)]
        private static extern double iSDL_atan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atanf", ExactSpelling = true)]
        private static extern float iSDL_atanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2", ExactSpelling = true)]
        private static extern double iSDL_atan2(double y, double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_atan2f", ExactSpelling = true)]
        private static extern float iSDL_atan2f(float y, float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceil", ExactSpelling = true)]
        private static extern double iSDL_ceil(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ceilf", ExactSpelling = true)]
        private static extern float iSDL_ceilf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysign", ExactSpelling = true)]
        private static extern double iSDL_copysign(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_copysignf", ExactSpelling = true)]
        private static extern float iSDL_copysignf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cos", ExactSpelling = true)]
        private static extern double iSDL_cos(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_cosf", ExactSpelling = true)]
        private static extern float iSDL_cosf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_exp", ExactSpelling = true)]
        private static extern double iSDL_exp(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_expf", ExactSpelling = true)]
        private static extern float iSDL_expf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabs", ExactSpelling = true)]
        private static extern double iSDL_fabs(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fabsf", ExactSpelling = true)]
        private static extern float iSDL_fabsf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floor", ExactSpelling = true)]
        private static extern double iSDL_floor(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_floorf", ExactSpelling = true)]
        private static extern float iSDL_floorf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_trunc", ExactSpelling = true)]
        private static extern double iSDL_trunc(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_truncf", ExactSpelling = true)]
        private static extern float iSDL_truncf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmod", ExactSpelling = true)]
        private static extern double iSDL_fmod(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_fmodf", ExactSpelling = true)]
        private static extern float iSDL_fmodf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isinf", ExactSpelling = true)]
        private static extern int iSDL_isinf(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isinff", ExactSpelling = true)]
        private static extern int iSDL_isinff(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isnan", ExactSpelling = true)]
        private static extern int iSDL_isnan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_isnanf", ExactSpelling = true)]
        private static extern int iSDL_isnanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log", ExactSpelling = true)]
        private static extern double iSDL_log(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_logf", ExactSpelling = true)]
        private static extern float iSDL_logf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10", ExactSpelling = true)]
        private static extern double iSDL_log10(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_log10f", ExactSpelling = true)]
        private static extern float iSDL_log10f(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_modf", ExactSpelling = true)]
        private static extern double iSDL_modf(double x, double* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_modff", ExactSpelling = true)]
        private static extern float iSDL_modff(float x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_pow", ExactSpelling = true)]
        private static extern double iSDL_pow(double x, double y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_powf", ExactSpelling = true)]
        private static extern float iSDL_powf(float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_round", ExactSpelling = true)]
        private static extern double iSDL_round(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_roundf", ExactSpelling = true)]
        private static extern float iSDL_roundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lround", ExactSpelling = true)]
        private static extern int iSDL_lround(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_lroundf", ExactSpelling = true)]
        private static extern int iSDL_lroundf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbn", ExactSpelling = true)]
        private static extern double iSDL_scalbn(double x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_scalbnf", ExactSpelling = true)]
        private static extern float iSDL_scalbnf(float x, int n);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sin", ExactSpelling = true)]
        private static extern double iSDL_sin(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sinf", ExactSpelling = true)]
        private static extern float iSDL_sinf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrt", ExactSpelling = true)]
        private static extern double iSDL_sqrt(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_sqrtf", ExactSpelling = true)]
        private static extern float iSDL_sqrtf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tan", ExactSpelling = true)]
        private static extern double iSDL_tan(double x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_tanf", ExactSpelling = true)]
        private static extern float iSDL_tanf(float x);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_open", ExactSpelling = true)]
        private static extern SDL_iconv_data_t* iSDL_iconv_open(byte* tocode, byte* fromcode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_close", ExactSpelling = true)]
        private static extern int iSDL_iconv_close(SDL_iconv_data_t* cd);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv", ExactSpelling = true)]
        private static extern nuint iSDL_iconv(SDL_iconv_data_t* cd, byte** inbuf, nuint* inbytesleft, byte** outbuf, nuint* outbytesleft);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_iconv_string", ExactSpelling = true)]
        private static extern byte* iSDL_iconv_string(byte* tocode, byte* fromcode, byte* inbuf, nuint inbytesleft);

        public const ulong SDL_SIZE_MAX = 0xffffffffffffffffUL;

        public const sbyte SDL_MAX_SINT8 = ((sbyte)(0x7F));

        public const sbyte SDL_MIN_SINT8 = ((sbyte)(~0x7F));

        public const byte SDL_MAX_UINT8 = ((byte)(0xFF));

        public const byte SDL_MIN_UINT8 = ((byte)(0x00));

        public const short SDL_MAX_SINT16 = ((short)(0x7FFF));

        public const short SDL_MIN_SINT16 = ((short)(~0x7FFF));

        public const ushort SDL_MAX_UINT16 = ((ushort)(0xFFFF));

        public const ushort SDL_MIN_UINT16 = ((ushort)(0x0000));

        public const int SDL_MAX_SINT32 = ((int)(0x7FFFFFFF));

        public const int SDL_MIN_SINT32 = ((int)(~0x7FFFFFFF));

        public const uint SDL_MAX_UINT32 = ((uint)(0xFFFFFFFFU));

        public const uint SDL_MIN_UINT32 = ((uint)(0x00000000));

        public const long SDL_MAX_SINT64 = (0x7FFFFFFFFFFFFFFFL);

        public const long SDL_MIN_SINT64 = ~(0x7FFFFFFFFFFFFFFFL);

        public const ulong SDL_MAX_UINT64 = (0xFFFFFFFFFFFFFFFFUL);

        public const ulong SDL_MIN_UINT64 = (0x0000000000000000UL);

        public const long SDL_MAX_TIME = (0x7FFFFFFFFFFFFFFFL);

        public const long SDL_MIN_TIME = ~(0x7FFFFFFFFFFFFFFFL);

        public const float SDL_FLT_EPSILON = 1.1920928955078125e-07F;

        public static string SDL_PRIs64 => "lld";

        public static string SDL_PRIu64 => "llu";

        public static string SDL_PRIx64 => "llx";

        public static string SDL_PRIX64 => "llX";

        public static string SDL_PRIs32 => "d";

        public static string SDL_PRIu32 => "u";

        public static string SDL_PRIx32 => "x";

        public static string SDL_PRIX32 => "X";

        public static string SDL_PRILL_PREFIX => "ll";

        public static string SDL_PRILLd => "lld";

        public static string SDL_PRILLu => "llu";

        public static string SDL_PRILLx => "llx";

        public static string SDL_PRILLX => "llX";

        public static string SDL_PRISZ_PREFIX => "I64";

        public static string SDL_PRISZu => "I64u";

        public static string SDL_PRISZx => "I64x";

        public static string SDL_PRISZX => "I64X";

        public const int SDL_INVALID_UNICODE_CODEPOINT = 0xFFFD;

        public const double SDL_PI_D = 3.141592653589793238462643383279502884;

        public const float SDL_PI_F = 3.141592653589793238462643383279502884F;

        public static readonly nuint SDL_ICONV_ERROR = unchecked((nuint)(-1));

        public static readonly nuint SDL_ICONV_E2BIG = unchecked((nuint)(-2));

        public static readonly nuint SDL_ICONV_EILSEQ = unchecked((nuint)(-3));

        public static readonly nuint SDL_ICONV_EINVAL = unchecked((nuint)(-4));
    }
}
