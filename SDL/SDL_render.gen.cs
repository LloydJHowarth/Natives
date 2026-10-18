using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct SDL_Vertex
    {
        private SDL_FPoint position;

        private SDL_FColor color;

        private SDL_FPoint tex_coord;
    }

    internal enum SDL_TextureAccess
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }

    internal enum SDL_TextureAddressMode
    {
        SDL_TEXTURE_ADDRESS_INVALID = -1,
        SDL_TEXTURE_ADDRESS_AUTO,
        SDL_TEXTURE_ADDRESS_CLAMP,
        SDL_TEXTURE_ADDRESS_WRAP,
    }

    internal enum SDL_RendererLogicalPresentation
    {
        SDL_LOGICAL_PRESENTATION_DISABLED,
        SDL_LOGICAL_PRESENTATION_STRETCH,
        SDL_LOGICAL_PRESENTATION_LETTERBOX,
        SDL_LOGICAL_PRESENTATION_OVERSCAN,
        SDL_LOGICAL_PRESENTATION_INTEGER_SCALE,
    }

    internal partial struct SDL_Renderer
    {
    }

    internal partial struct SDL_Texture
    {
        private SDL_PixelFormat format;

        private int w;

        private int h;

        private int refcount;
    }

    internal unsafe partial struct SDL_GPURenderStateCreateInfo
    {
        private SDL_GPUShader* fragment_shader;

        private int num_sampler_bindings;

        private SDL_GPUTextureSamplerBinding* sampler_bindings;

        private int num_storage_textures;

        private SDL_GPUTexture** storage_textures;

        private int num_storage_buffers;

        private SDL_GPUBuffer** storage_buffers;

        private uint props;
    }

    internal partial struct SDL_GPURenderState
    {
    }

    internal static unsafe partial class SDL
    {
        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetNumRenderDrivers", ExactSpelling = true)]
        private static extern int iSDL_GetNumRenderDrivers();

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDriver", ExactSpelling = true)]
        private static extern byte* iSDL_GetRenderDriver(int index);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateWindowAndRenderer", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_CreateWindowAndRenderer(byte* title, int width, int height, ulong window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateRenderer(SDL_Window* window, byte* name);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateRendererWithProperties", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateRendererWithProperties(uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPURenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateGPURenderer(SDL_GPUDevice* device, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetGPURendererDevice", ExactSpelling = true)]
        private static extern SDL_GPUDevice* iSDL_GetGPURendererDevice(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateSoftwareRenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSoftwareRendererWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetSoftwareRendererWindow(SDL_Renderer* renderer, SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetSoftwareRendererSurface", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetSoftwareRendererSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderer", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_GetRenderer(SDL_Window* window);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderWindow", ExactSpelling = true)]
        private static extern SDL_Window* iSDL_GetRenderWindow(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererName", ExactSpelling = true)]
        private static extern byte* iSDL_GetRendererName(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetRendererProperties(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderOutputSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetCurrentRenderOutputSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTexture", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int w, int h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureFromSurface", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateTextureWithProperties", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_CreateTextureWithProperties(SDL_Renderer* renderer, uint props);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureProperties", ExactSpelling = true)]
        private static extern uint iSDL_GetTextureProperties(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRendererFromTexture", ExactSpelling = true)]
        private static extern SDL_Renderer* iSDL_GetRendererFromTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureSize", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureSize(SDL_Texture* texture, float* w, float* h);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTexturePalette", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTexturePalette(SDL_Texture* texture, SDL_Palette* palette);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTexturePalette", ExactSpelling = true)]
        private static extern SDL_Palette* iSDL_GetTexturePalette(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorMod", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureColorModFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorMod", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureColorMod(SDL_Texture* texture, byte* r, byte* g, byte* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureColorModFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaMod", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextureAlphaMod(SDL_Texture* texture, byte alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureAlphaModFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaMod", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureAlphaMod(SDL_Texture* texture, byte* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureAlphaModFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureBlendMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextureBlendMode(SDL_Texture* texture, uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureBlendMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureBlendMode(SDL_Texture* texture, uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetTextureScaleMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetTextureScaleMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateTexture", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UpdateTexture(SDL_Texture* texture, SDL_Rect* rect, IntPtr pixels, int pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateYUVTexture", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UpdateYUVTexture(SDL_Texture* texture, SDL_Rect* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UpdateNVTexture", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_UpdateNVTexture(SDL_Texture* texture, SDL_Rect* rect, byte* Yplane, int Ypitch, byte* UVplane, int UVpitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTexture", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_LockTexture(SDL_Texture* texture, SDL_Rect* rect, IntPtr* pixels, int* pitch);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_LockTextureToSurface", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_LockTextureToSurface(SDL_Texture* texture, SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_UnlockTexture", ExactSpelling = true)]
        private static extern void iSDL_UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTarget", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTarget", ExactSpelling = true)]
        private static extern SDL_Texture* iSDL_GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderLogicalPresentation", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderLogicalPresentation(SDL_Renderer* renderer, int w, int h, SDL_RendererLogicalPresentation mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentation", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderLogicalPresentation(SDL_Renderer* renderer, int* w, int* h, SDL_RendererLogicalPresentation* mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderLogicalPresentationRect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesFromWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderCoordinatesFromWindow(SDL_Renderer* renderer, float window_x, float window_y, float* x, float* y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderCoordinatesToWindow", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* window_x, float* window_y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_ConvertEventToRenderCoordinates", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* @event);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderViewport", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderViewport", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderViewportFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderViewportFloat(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderViewportFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderViewportFloat(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderViewportSet", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderViewportSet(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderSafeArea", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderClipRect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderClipRect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderClipRectFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderClipRectFloat(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderClipRectFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderClipRectFloat(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClipEnabled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderScale", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderScale", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColor", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderDrawColor(SDL_Renderer* renderer, byte r, byte g, byte b, byte a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawColorFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColor", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderDrawColor(SDL_Renderer* renderer, byte* r, byte* g, byte* b, byte* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawColorFloat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderColorScale", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderColorScale(SDL_Renderer* renderer, float scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderColorScale", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderColorScale(SDL_Renderer* renderer, float* scale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderHDRHeadroom", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderHDRHeadroom(SDL_Renderer* renderer, float headroom);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderHDRHeadroom", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderHDRHeadroom(SDL_Renderer* renderer, float* headroom);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderDrawBlendMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, uint blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderDrawBlendMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, uint* blendMode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderClear", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoint", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderPoint(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPoints", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderPoints(SDL_Renderer* renderer, SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLine", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderLines", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderLines(SDL_Renderer* renderer, SDL_FPoint* points, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderRect(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderRects", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderRects(SDL_Renderer* renderer, SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRect", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderFillRect(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderFillRects", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderFillRects(SDL_Renderer* renderer, SDL_FRect* rects, int count);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureRotated", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FRect* dstrect, double angle, SDL_FPoint* center, SDL_FlipMode flip);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureAffine", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderTextureAffine(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, SDL_FPoint* origin, SDL_FPoint* right, SDL_FPoint* down);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTextureTiled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float scale, SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture9Grid", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, SDL_FRect* dstrect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderTexture9GridTiled", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderTexture9GridTiled(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcrect, float left_width, float right_width, float top_height, float bottom_height, float scale, SDL_FRect* dstrect, float tileScale);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometry", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Vertex* vertices, int num_vertices, int* indices, int num_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderGeometryRaw", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, float* xy, int xy_stride, SDL_FColor* color, int color_stride, float* uv, int uv_stride, int num_vertices, IntPtr indices, int num_indices, int size_indices);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderTextureAddressMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode u_mode, SDL_TextureAddressMode v_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderTextureAddressMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderTextureAddressMode(SDL_Renderer* renderer, SDL_TextureAddressMode* u_mode, SDL_TextureAddressMode* v_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderReadPixels", ExactSpelling = true)]
        private static extern SDL_Surface* iSDL_RenderReadPixels(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderPresent", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyTexture", ExactSpelling = true)]
        private static extern void iSDL_DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyRenderer", ExactSpelling = true)]
        private static extern void iSDL_DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_FlushRenderer", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_FlushRenderer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalLayer", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetRenderMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderMetalCommandEncoder", ExactSpelling = true)]
        private static extern IntPtr iSDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_AddVulkanRenderSemaphores", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, uint wait_stage_mask, long wait_semaphore, long signal_semaphore);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetRenderVSync", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetRenderVSync(SDL_Renderer* renderer, int vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetRenderVSync", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugText", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderDebugText(SDL_Renderer* renderer, float x, float y, byte* str);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_RenderDebugTextFormat", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_RenderDebugTextFormat(SDL_Renderer* renderer, float x, float y, byte* fmt);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetDefaultTextureScaleMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_GetDefaultTextureScaleMode", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_GetDefaultTextureScaleMode(SDL_Renderer* renderer, SDL_ScaleMode* scale_mode);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_CreateGPURenderState", ExactSpelling = true)]
        private static extern SDL_GPURenderState* iSDL_CreateGPURenderState(SDL_Renderer* renderer, SDL_GPURenderStateCreateInfo* createinfo);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateSamplerBindings", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGPURenderStateSamplerBindings(SDL_GPURenderState* state, int num_sampler_bindings, SDL_GPUTextureSamplerBinding* sampler_bindings);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateStorageTextures", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGPURenderStateStorageTextures(SDL_GPURenderState* state, int num_storage_textures, SDL_GPUTexture** storage_textures);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateStorageBuffers", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGPURenderStateStorageBuffers(SDL_GPURenderState* state, int num_storage_buffers, SDL_GPUBuffer** storage_buffers);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderStateFragmentUniforms", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGPURenderStateFragmentUniforms(SDL_GPURenderState* state, uint slot_index, IntPtr data, uint length);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_SetGPURenderState", ExactSpelling = true)]
        private static extern SDL_Bool iSDL_SetGPURenderState(SDL_Renderer* renderer, SDL_GPURenderState* state);

        [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_DestroyGPURenderState", ExactSpelling = true)]
        private static extern void iSDL_DestroyGPURenderState(SDL_GPURenderState* state);

        public static string SDL_SOFTWARE_RENDERER => "software";

        public static string SDL_GPU_RENDERER => "gpu";

        public static string SDL_PROP_RENDERER_CREATE_NAME_STRING => "SDL.renderer.create.name";

        public static string SDL_PROP_RENDERER_CREATE_WINDOW_POINTER => "SDL.renderer.create.window";

        public static string SDL_PROP_RENDERER_CREATE_SURFACE_POINTER => "SDL.renderer.create.surface";

        public static string SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER => "SDL.renderer.create.output_colorspace";

        public static string SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_NUMBER => "SDL.renderer.create.present_vsync";

        public static string SDL_PROP_RENDERER_CREATE_GPU_DEVICE_POINTER => "SDL.renderer.create.gpu.device";

        public static string SDL_PROP_RENDERER_CREATE_GPU_SHADERS_SPIRV_BOOLEAN => "SDL.renderer.create.gpu.shaders_spirv";

        public static string SDL_PROP_RENDERER_CREATE_GPU_SHADERS_DXIL_BOOLEAN => "SDL.renderer.create.gpu.shaders_dxil";

        public static string SDL_PROP_RENDERER_CREATE_GPU_SHADERS_MSL_BOOLEAN => "SDL.renderer.create.gpu.shaders_msl";

        public static string SDL_PROP_RENDERER_CREATE_METAL_DEVICE_POINTER => "SDL.renderer.create.metal.device";

        public static string SDL_PROP_RENDERER_CREATE_METAL_COMMAND_QUEUE_POINTER => "SDL.renderer.create.metal.command_queue";

        public static string SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER => "SDL.renderer.create.vulkan.instance";

        public static string SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER => "SDL.renderer.create.vulkan.surface";

        public static string SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER => "SDL.renderer.create.vulkan.physical_device";

        public static string SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER => "SDL.renderer.create.vulkan.device";

        public static string SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.create.vulkan.graphics_queue_family_index";

        public static string SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.create.vulkan.present_queue_family_index";

        public static string SDL_PROP_RENDERER_NAME_STRING => "SDL.renderer.name";

        public static string SDL_PROP_RENDERER_WINDOW_POINTER => "SDL.renderer.window";

        public static string SDL_PROP_RENDERER_SURFACE_POINTER => "SDL.renderer.surface";

        public static string SDL_PROP_RENDERER_VSYNC_NUMBER => "SDL.renderer.vsync";

        public static string SDL_PROP_RENDERER_MAX_TEXTURE_SIZE_NUMBER => "SDL.renderer.max_texture_size";

        public static string SDL_PROP_RENDERER_TEXTURE_FORMATS_POINTER => "SDL.renderer.texture_formats";

        public static string SDL_PROP_RENDERER_TEXTURE_WRAPPING_BOOLEAN => "SDL.renderer.texture_wrapping";

        public static string SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER => "SDL.renderer.output_colorspace";

        public static string SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN => "SDL.renderer.HDR_enabled";

        public static string SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT => "SDL.renderer.SDR_white_point";

        public static string SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT => "SDL.renderer.HDR_headroom";

        public static string SDL_PROP_RENDERER_D3D9_DEVICE_POINTER => "SDL.renderer.d3d9.device";

        public static string SDL_PROP_RENDERER_D3D11_DEVICE_POINTER => "SDL.renderer.d3d11.device";

        public static string SDL_PROP_RENDERER_D3D11_SWAPCHAIN_POINTER => "SDL.renderer.d3d11.swap_chain";

        public static string SDL_PROP_RENDERER_D3D12_DEVICE_POINTER => "SDL.renderer.d3d12.device";

        public static string SDL_PROP_RENDERER_D3D12_SWAPCHAIN_POINTER => "SDL.renderer.d3d12.swap_chain";

        public static string SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER => "SDL.renderer.d3d12.command_queue";

        public static string SDL_PROP_RENDERER_METAL_DEVICE_POINTER => "SDL.renderer.metal.device";

        public static string SDL_PROP_RENDERER_METAL_COMMAND_QUEUE_POINTER => "SDL.renderer.metal.command_queue";

        public static string SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER => "SDL.renderer.vulkan.instance";

        public static string SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER => "SDL.renderer.vulkan.surface";

        public static string SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER => "SDL.renderer.vulkan.physical_device";

        public static string SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER => "SDL.renderer.vulkan.device";

        public static string SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.vulkan.graphics_queue_family_index";

        public static string SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER => "SDL.renderer.vulkan.present_queue_family_index";

        public static string SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER => "SDL.renderer.vulkan.swapchain_image_count";

        public static string SDL_PROP_RENDERER_GPU_DEVICE_POINTER => "SDL.renderer.gpu.device";

        public static string SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER => "SDL.texture.create.colorspace";

        public static string SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER => "SDL.texture.create.format";

        public static string SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER => "SDL.texture.create.access";

        public static string SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER => "SDL.texture.create.width";

        public static string SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER => "SDL.texture.create.height";

        public static string SDL_PROP_TEXTURE_CREATE_PALETTE_POINTER => "SDL.texture.create.palette";

        public static string SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT => "SDL.texture.create.SDR_white_point";

        public static string SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT => "SDL.texture.create.HDR_headroom";

        public static string SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER => "SDL.texture.create.d3d11.texture";

        public static string SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER => "SDL.texture.create.d3d11.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER => "SDL.texture.create.d3d11.texture_v";

        public static string SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER => "SDL.texture.create.d3d12.texture";

        public static string SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER => "SDL.texture.create.d3d12.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER => "SDL.texture.create.d3d12.texture_v";

        public static string SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER => "SDL.texture.create.metal.pixelbuffer";

        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_POINTER => "SDL.texture.create.metal.texture";

        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_UV_POINTER => "SDL.texture.create.metal.texture_uv";

        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_U_POINTER => "SDL.texture.create.metal.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_V_POINTER => "SDL.texture.create.metal.texture_v";

        public static string SDL_PROP_TEXTURE_CREATE_METAL_TEXTURE_USAGE_NUMBER => "SDL.texture.create.metal.texture_usage";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER => "SDL.texture.create.opengl.texture";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER => "SDL.texture.create.opengl.texture_uv";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER => "SDL.texture.create.opengl.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER => "SDL.texture.create.opengl.texture_v";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER => "SDL.texture.create.opengles2.texture";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER => "SDL.texture.create.opengles2.texture_uv";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER => "SDL.texture.create.opengles2.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER => "SDL.texture.create.opengles2.texture_v";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER => "SDL.texture.create.vulkan.texture";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_U_NUMBER => "SDL.texture.create.vulkan.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_UV_NUMBER => "SDL.texture.create.vulkan.texture_uv";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_V_NUMBER => "SDL.texture.create.vulkan.texture_v";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_LAYOUT_NUMBER => "SDL.texture.create.vulkan.layout";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_USAGE_NUMBER => "SDL.texture.create.vulkan.usage";

        public static string SDL_PROP_TEXTURE_CREATE_VULKAN_ANDROID_HARDWARE_BUFFER_POINTER => "SDL.texture.create.vulkan.android_hardware_buffer";

        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_POINTER => "SDL.texture.create.gpu.texture";

        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_UV_POINTER => "SDL.texture.create.gpu.texture_uv";

        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_U_POINTER => "SDL.texture.create.gpu.texture_u";

        public static string SDL_PROP_TEXTURE_CREATE_GPU_TEXTURE_V_POINTER => "SDL.texture.create.gpu.texture_v";

        public static string SDL_PROP_TEXTURE_COLORSPACE_NUMBER => "SDL.texture.colorspace";

        public static string SDL_PROP_TEXTURE_FORMAT_NUMBER => "SDL.texture.format";

        public static string SDL_PROP_TEXTURE_ACCESS_NUMBER => "SDL.texture.access";

        public static string SDL_PROP_TEXTURE_WIDTH_NUMBER => "SDL.texture.width";

        public static string SDL_PROP_TEXTURE_HEIGHT_NUMBER => "SDL.texture.height";

        public static string SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT => "SDL.texture.SDR_white_point";

        public static string SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT => "SDL.texture.HDR_headroom";

        public static string SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER => "SDL.texture.d3d11.texture";

        public static string SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER => "SDL.texture.d3d11.texture_u";

        public static string SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER => "SDL.texture.d3d11.texture_v";

        public static string SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER => "SDL.texture.d3d12.texture";

        public static string SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER => "SDL.texture.d3d12.texture_u";

        public static string SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER => "SDL.texture.d3d12.texture_v";

        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_POINTER => "SDL.texture.metal.texture";

        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_UV_POINTER => "SDL.texture.metal.texture_uv";

        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_U_POINTER => "SDL.texture.metal.texture_u";

        public static string SDL_PROP_TEXTURE_METAL_TEXTURE_V_POINTER => "SDL.texture.metal.texture_v";

        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER => "SDL.texture.opengl.texture";

        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER => "SDL.texture.opengl.texture_uv";

        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER => "SDL.texture.opengl.texture_u";

        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER => "SDL.texture.opengl.texture_v";

        public static string SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER => "SDL.texture.opengl.target";

        public static string SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT => "SDL.texture.opengl.tex_w";

        public static string SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT => "SDL.texture.opengl.tex_h";

        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER => "SDL.texture.opengles2.texture";

        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER => "SDL.texture.opengles2.texture_uv";

        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER => "SDL.texture.opengles2.texture_u";

        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER => "SDL.texture.opengles2.texture_v";

        public static string SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER => "SDL.texture.opengles2.target";

        public static string SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER => "SDL.texture.vulkan.texture";

        public static string SDL_PROP_TEXTURE_VULKAN_TEXTURE_UV_NUMBER => "SDL.texture.vulkan.texture_uv";

        public static string SDL_PROP_TEXTURE_VULKAN_TEXTURE_U_NUMBER => "SDL.texture.vulkan.texture_u";

        public static string SDL_PROP_TEXTURE_VULKAN_TEXTURE_V_NUMBER => "SDL.texture.vulkan.texture_v";

        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_POINTER => "SDL.texture.gpu.texture";

        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_UV_POINTER => "SDL.texture.gpu.texture_uv";

        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_U_POINTER => "SDL.texture.gpu.texture_u";

        public static string SDL_PROP_TEXTURE_GPU_TEXTURE_V_POINTER => "SDL.texture.gpu.texture_v";

        public const int SDL_RENDERER_VSYNC_DISABLED = 0;

        public const int SDL_RENDERER_VSYNC_ADAPTIVE = (-1);

        public const int SDL_DEBUG_TEXT_FONT_CHARACTER_SIZE = 8;
    }
}
