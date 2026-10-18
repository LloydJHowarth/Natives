using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Point
    {
        private int x;

        private int y;
    }

    internal partial struct SDL_FPoint
    {
        private float x;

        private float y;
    }

    internal partial struct SDL_Rect
    {
        private int x;

        private int y;

        private int w;

        private int h;
    }

    internal partial struct SDL_FRect
    {
        private float x;

        private float y;

        private float w;

        private float h;
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersection", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasRectIntersection(SDL_Rect* A, SDL_Rect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersection", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectIntersection(SDL_Rect* A, SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnion", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectUnion(SDL_Rect* A, SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPoints", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectEnclosingPoints(SDL_Point* points, int count, SDL_Rect* clip, SDL_Rect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersection", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectAndLineIntersection(SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasRectIntersectionFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_HasRectIntersectionFloat(SDL_FRect* A, SDL_FRect* B);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectIntersectionFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectIntersectionFloat(SDL_FRect* A, SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectUnionFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectUnionFloat(SDL_FRect* A, SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectEnclosingPointsFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectEnclosingPointsFloat(SDL_FPoint* points, int count, SDL_FRect* clip, SDL_FRect* result);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRectAndLineIntersectionFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRectAndLineIntersectionFloat(SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);
    }
}
