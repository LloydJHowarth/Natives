using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct TTF_Font
    {
    }

    internal enum TTF_HintingFlags
    {
        TTF_HINTING_INVALID = -1,
        TTF_HINTING_NORMAL,
        TTF_HINTING_LIGHT,
        TTF_HINTING_MONO,
        TTF_HINTING_NONE,
        TTF_HINTING_LIGHT_SUBPIXEL,
    }

    internal enum TTF_HorizontalAlignment
    {
        TTF_HORIZONTAL_ALIGN_INVALID = -1,
        TTF_HORIZONTAL_ALIGN_LEFT,
        TTF_HORIZONTAL_ALIGN_CENTER,
        TTF_HORIZONTAL_ALIGN_RIGHT,
    }

    internal enum TTF_Direction
    {
        TTF_DIRECTION_INVALID = 0,
        TTF_DIRECTION_LTR = 4,
        TTF_DIRECTION_RTL,
        TTF_DIRECTION_TTB,
        TTF_DIRECTION_BTT,
    }

    internal enum TTF_ImageType
    {
        TTF_IMAGE_INVALID,
        TTF_IMAGE_ALPHA,
        TTF_IMAGE_COLOR,
        TTF_IMAGE_SDF,
    }

    internal partial struct TTF_TextEngine
    {
    }

    internal partial struct TTF_TextData
    {
    }

    internal unsafe partial struct TTF_Text
    {
        private byte* text;

        private int num_lines;

        private int refcount;

        private TTF_TextData* @internal;
    }

    internal unsafe partial struct TTF_GPUAtlasDrawSequence
    {
        private SDL_GPUTexture* atlas_texture;

        private SDL_FPoint* xy;

        private SDL_FPoint* uv;

        private int num_vertices;

        private int* indices;

        private int num_indices;

        private TTF_ImageType image_type;

        private TTF_GPUAtlasDrawSequence* next;
    }

    internal enum TTF_GPUTextEngineWinding
    {
        TTF_GPU_TEXTENGINE_WINDING_INVALID = -1,
        TTF_GPU_TEXTENGINE_WINDING_CLOCKWISE,
        TTF_GPU_TEXTENGINE_WINDING_COUNTER_CLOCKWISE,
    }

    internal partial struct TTF_GLAtlasDrawVertex
    {
        private SDL_FPoint position;

        private SDL_FPoint texcoord;
    }

    internal unsafe partial struct TTF_GLAtlasDrawSequence
    {
        private uint atlas_texture;

        private TTF_GLAtlasDrawVertex* vertices;

        private int num_vertices;

        private ushort* indices;

        private int num_indices;

        private TTF_ImageType image_type;

        private TTF_GLAtlasDrawSequence* next;
    }

    internal enum TTF_GLTextEngineWinding
    {
        TTF_GL_TEXTENGINE_WINDING_INVALID = -1,
        TTF_GL_TEXTENGINE_WINDING_CLOCKWISE,
        TTF_GL_TEXTENGINE_WINDING_COUNTER_CLOCKWISE,
    }

    internal partial struct TTF_SubString
    {
        private uint flags;

        private int offset;

        private int length;

        private int line_index;

        private int cluster_index;

        private SDL_Rect rect;
    }

    internal static unsafe partial class TTF
    {
        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_Version", ExactSpelling = true)]
        private static extern int iTTF_Version();

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFreeTypeVersion", ExactSpelling = true)]
        private static extern void iTTF_GetFreeTypeVersion(int* major, int* minor, int* patch);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetHarfBuzzVersion", ExactSpelling = true)]
        private static extern void iTTF_GetHarfBuzzVersion(int* major, int* minor, int* patch);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_Init", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_Init();

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFont", ExactSpelling = true)]
        private static extern TTF_Font* iTTF_OpenFont(byte* file, float ptsize);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontIO", ExactSpelling = true)]
        private static extern TTF_Font* iTTF_OpenFontIO(SDL_IOStream* src, SDL_Bool closeio, float ptsize);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_OpenFontWithProperties", ExactSpelling = true)]
        private static extern TTF_Font* iTTF_OpenFontWithProperties(uint props);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CopyFont", ExactSpelling = true)]
        private static extern TTF_Font* iTTF_CopyFont(TTF_Font* existing_font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontProperties", ExactSpelling = true)]
        private static extern uint iTTF_GetFontProperties(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontGeneration", ExactSpelling = true)]
        private static extern uint iTTF_GetFontGeneration(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_AddFallbackFont", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_AddFallbackFont(TTF_Font* font, TTF_Font* fallback);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RemoveFallbackFont", ExactSpelling = true)]
        private static extern void iTTF_RemoveFallbackFont(TTF_Font* font, TTF_Font* fallback);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_ClearFallbackFonts", ExactSpelling = true)]
        private static extern void iTTF_ClearFallbackFonts(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontSize", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontSize(TTF_Font* font, float ptsize);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontSizeDPI", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontSizeDPI(TTF_Font* font, float ptsize, int hdpi, int vdpi);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontSize", ExactSpelling = true)]
        private static extern float iTTF_GetFontSize(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontDPI", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetFontDPI(TTF_Font* font, int* hdpi, int* vdpi);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontStyle", ExactSpelling = true)]
        private static extern void iTTF_SetFontStyle(TTF_Font* font, uint style);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontStyle", ExactSpelling = true)]
        private static extern uint iTTF_GetFontStyle(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontOutline", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontOutline(TTF_Font* font, int outline);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontOutline", ExactSpelling = true)]
        private static extern int iTTF_GetFontOutline(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontHinting", ExactSpelling = true)]
        private static extern void iTTF_SetFontHinting(TTF_Font* font, TTF_HintingFlags hinting);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetNumFontFaces", ExactSpelling = true)]
        private static extern int iTTF_GetNumFontFaces(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontHinting", ExactSpelling = true)]
        private static extern TTF_HintingFlags iTTF_GetFontHinting(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontSDF", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontSDF(TTF_Font* font, SDL_Bool enabled);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontSDF", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetFontSDF(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontWeight", ExactSpelling = true)]
        private static extern int iTTF_GetFontWeight(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontWrapAlignment", ExactSpelling = true)]
        private static extern void iTTF_SetFontWrapAlignment(TTF_Font* font, TTF_HorizontalAlignment align);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontWrapAlignment", ExactSpelling = true)]
        private static extern TTF_HorizontalAlignment iTTF_GetFontWrapAlignment(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontHeight", ExactSpelling = true)]
        private static extern int iTTF_GetFontHeight(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontAscent", ExactSpelling = true)]
        private static extern int iTTF_GetFontAscent(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontDescent", ExactSpelling = true)]
        private static extern int iTTF_GetFontDescent(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontLineSkip", ExactSpelling = true)]
        private static extern void iTTF_SetFontLineSkip(TTF_Font* font, int lineskip);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontLineSkip", ExactSpelling = true)]
        private static extern int iTTF_GetFontLineSkip(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontKerning", ExactSpelling = true)]
        private static extern void iTTF_SetFontKerning(TTF_Font* font, SDL_Bool enabled);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontKerning", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetFontKerning(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontIsFixedWidth", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_FontIsFixedWidth(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontIsScalable", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_FontIsScalable(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontFamilyName", ExactSpelling = true)]
        private static extern byte* iTTF_GetFontFamilyName(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontStyleName", ExactSpelling = true)]
        private static extern byte* iTTF_GetFontStyleName(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontDirection", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontDirection(TTF_Font* font, TTF_Direction direction);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontDirection", ExactSpelling = true)]
        private static extern TTF_Direction iTTF_GetFontDirection(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontCharSpacing", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontCharSpacing(TTF_Font* font, int spacing);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontCharSpacing", ExactSpelling = true)]
        private static extern int iTTF_GetFontCharSpacing(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_StringToTag", ExactSpelling = true)]
        private static extern uint iTTF_StringToTag(byte* @string);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_TagToString", ExactSpelling = true)]
        private static extern void iTTF_TagToString(uint tag, byte* @string, nuint size);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontScript", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontScript(TTF_Font* font, uint script);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetFontScript", ExactSpelling = true)]
        private static extern uint iTTF_GetFontScript(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGlyphScript", ExactSpelling = true)]
        private static extern uint iTTF_GetGlyphScript(uint ch);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetFontLanguage", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetFontLanguage(TTF_Font* font, byte* language_bcp47);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_FontHasGlyph", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_FontHasGlyph(TTF_Font* font, uint ch);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGlyphImage", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_GetGlyphImage(TTF_Font* font, uint ch, TTF_ImageType* image_type);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGlyphImageForIndex", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_GetGlyphImageForIndex(TTF_Font* font, uint glyph_index, TTF_ImageType* image_type);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGlyphMetrics", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetGlyphMetrics(TTF_Font* font, uint ch, int* minx, int* maxx, int* miny, int* maxy, int* advance);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGlyphKerning", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetGlyphKerning(TTF_Font* font, uint previous_ch, uint ch, int* kerning);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetStringSize", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetStringSize(TTF_Font* font, byte* text, nuint length, int* w, int* h);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetStringSizeWrapped", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetStringSizeWrapped(TTF_Font* font, byte* text, nuint length, int wrap_width, int* w, int* h);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_MeasureString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_MeasureString(TTF_Font* font, byte* text, nuint length, int max_width, int* measured_width, nuint* measured_length);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Solid", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_Solid(TTF_Font* font, byte* text, nuint length, SDL_Color fg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Solid_Wrapped", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_Solid_Wrapped(TTF_Font* font, byte* text, nuint length, SDL_Color fg, int wrapLength);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_Solid", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderGlyph_Solid(TTF_Font* font, uint ch, SDL_Color fg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Shaded", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_Shaded(TTF_Font* font, byte* text, nuint length, SDL_Color fg, SDL_Color bg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Shaded_Wrapped", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_Shaded_Wrapped(TTF_Font* font, byte* text, nuint length, SDL_Color fg, SDL_Color bg, int wrap_width);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_Shaded", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderGlyph_Shaded(TTF_Font* font, uint ch, SDL_Color fg, SDL_Color bg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Blended", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_Blended(TTF_Font* font, byte* text, nuint length, SDL_Color fg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_Blended_Wrapped", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_Blended_Wrapped(TTF_Font* font, byte* text, nuint length, SDL_Color fg, int wrap_width);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_Blended", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderGlyph_Blended(TTF_Font* font, uint ch, SDL_Color fg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_LCD", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_LCD(TTF_Font* font, byte* text, nuint length, SDL_Color fg, SDL_Color bg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderText_LCD_Wrapped", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderText_LCD_Wrapped(TTF_Font* font, byte* text, nuint length, SDL_Color fg, SDL_Color bg, int wrap_width);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_RenderGlyph_LCD", ExactSpelling = true)]
        private static extern SDL_Surface* iTTF_RenderGlyph_LCD(TTF_Font* font, uint ch, SDL_Color fg, SDL_Color bg);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateSurfaceTextEngine", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateSurfaceTextEngine();

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DrawSurfaceText", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_DrawSurfaceText(TTF_Text* text, int x, int y, SDL_Surface* surface);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DestroySurfaceTextEngine", ExactSpelling = true)]
        private static extern void iTTF_DestroySurfaceTextEngine(TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateRendererTextEngine", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateRendererTextEngine(SDL_Renderer* renderer);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateRendererTextEngineWithProperties", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateRendererTextEngineWithProperties(uint props);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DrawRendererText", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_DrawRendererText(TTF_Text* text, float x, float y);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DestroyRendererTextEngine", ExactSpelling = true)]
        private static extern void iTTF_DestroyRendererTextEngine(TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateGPUTextEngine", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateGPUTextEngine(SDL_GPUDevice* device);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateGPUTextEngineWithProperties", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateGPUTextEngineWithProperties(uint props);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGPUTextDrawData", ExactSpelling = true)]
        private static extern TTF_GPUAtlasDrawSequence* iTTF_GetGPUTextDrawData(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DestroyGPUTextEngine", ExactSpelling = true)]
        private static extern void iTTF_DestroyGPUTextEngine(TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetGPUTextEngineWinding", ExactSpelling = true)]
        private static extern void iTTF_SetGPUTextEngineWinding(TTF_TextEngine* engine, TTF_GPUTextEngineWinding winding);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGPUTextEngineWinding", ExactSpelling = true)]
        private static extern TTF_GPUTextEngineWinding iTTF_GetGPUTextEngineWinding(TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateGLTextEngine", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateGLTextEngine();

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateGLTextEngineWithProperties", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_CreateGLTextEngineWithProperties(uint props);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGLTextDrawData", ExactSpelling = true)]
        private static extern TTF_GLAtlasDrawSequence* iTTF_GetGLTextDrawData(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DestroyGLTextEngine", ExactSpelling = true)]
        private static extern void iTTF_DestroyGLTextEngine(TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetGLTextEngineWinding", ExactSpelling = true)]
        private static extern void iTTF_SetGLTextEngineWinding(TTF_TextEngine* engine, TTF_GLTextEngineWinding winding);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetGLTextEngineWinding", ExactSpelling = true)]
        private static extern TTF_GLTextEngineWinding iTTF_GetGLTextEngineWinding(TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CreateText", ExactSpelling = true)]
        private static extern TTF_Text* iTTF_CreateText(TTF_TextEngine* engine, TTF_Font* font, byte* text, nuint length);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextProperties", ExactSpelling = true)]
        private static extern uint iTTF_GetTextProperties(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextEngine", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextEngine(TTF_Text* text, TTF_TextEngine* engine);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextEngine", ExactSpelling = true)]
        private static extern TTF_TextEngine* iTTF_GetTextEngine(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextFont", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextFont(TTF_Text* text, TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextFont", ExactSpelling = true)]
        private static extern TTF_Font* iTTF_GetTextFont(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextDirection", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextDirection(TTF_Text* text, TTF_Direction direction);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextDirection", ExactSpelling = true)]
        private static extern TTF_Direction iTTF_GetTextDirection(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextScript", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextScript(TTF_Text* text, uint script);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextScript", ExactSpelling = true)]
        private static extern uint iTTF_GetTextScript(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextColor", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextColor(TTF_Text* text, byte r, byte g, byte b, byte a);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextColorFloat", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextColorFloat(TTF_Text* text, float r, float g, float b, float a);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextColor", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextColor(TTF_Text* text, byte* r, byte* g, byte* b, byte* a);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextColorFloat", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextColorFloat(TTF_Text* text, float* r, float* g, float* b, float* a);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextPosition", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextPosition(TTF_Text* text, int x, int y);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextPosition", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextPosition(TTF_Text* text, int* x, int* y);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextWrapWidth", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextWrapWidth(TTF_Text* text, int wrap_width);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextWrapWidth", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextWrapWidth(TTF_Text* text, int* wrap_width);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextWrapWhitespaceVisible", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextWrapWhitespaceVisible(TTF_Text* text, SDL_Bool visible);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_TextWrapWhitespaceVisible", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_TextWrapWhitespaceVisible(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_SetTextString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_SetTextString(TTF_Text* text, byte* @string, nuint length);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_InsertTextString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_InsertTextString(TTF_Text* text, int offset, byte* @string, nuint length);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_AppendTextString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_AppendTextString(TTF_Text* text, byte* @string, nuint length);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DeleteTextString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_DeleteTextString(TTF_Text* text, int offset, int length);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextSize", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextSize(TTF_Text* text, int* w, int* h);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextSubString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextSubString(TTF_Text* text, int offset, TTF_SubString* substring);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextSubStringForLine", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextSubStringForLine(TTF_Text* text, int line, TTF_SubString* substring);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextSubStringsForRange", ExactSpelling = true)]
        private static extern TTF_SubString** iTTF_GetTextSubStringsForRange(TTF_Text* text, int offset, int length, int* count);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetTextSubStringForPoint", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetTextSubStringForPoint(TTF_Text* text, int x, int y, TTF_SubString* substring);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetPreviousTextSubString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetPreviousTextSubString(TTF_Text* text, TTF_SubString* substring, TTF_SubString* previous);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_GetNextTextSubString", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_GetNextTextSubString(TTF_Text* text, TTF_SubString* substring, TTF_SubString* next);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_UpdateText", ExactSpelling = true)]
        private static extern SDL_Bool iTTF_UpdateText(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_DestroyText", ExactSpelling = true)]
        private static extern void iTTF_DestroyText(TTF_Text* text);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_CloseFont", ExactSpelling = true)]
        private static extern void iTTF_CloseFont(TTF_Font* font);

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_Quit", ExactSpelling = true)]
        private static extern void iTTF_Quit();

        [DllImport("SDL3_ttf", CallingConvention = CallingConvention.Cdecl, EntryPoint = "TTF_WasInit", ExactSpelling = true)]
        private static extern int iTTF_WasInit();

        public const int SDL_TTF_MAJOR_VERSION = 3;

        public const int SDL_TTF_MINOR_VERSION = 3;

        public const int SDL_TTF_MICRO_VERSION = 0;

        public const int SDL_TTF_VERSION = ((3) * 1000000 + (3) * 1000 + (0));

        public static string TTF_PROP_FONT_CREATE_FILENAME_STRING => "SDL_ttf.font.create.filename";

        public static string TTF_PROP_FONT_CREATE_IOSTREAM_POINTER => "SDL_ttf.font.create.iostream";

        public static string TTF_PROP_FONT_CREATE_IOSTREAM_OFFSET_NUMBER => "SDL_ttf.font.create.iostream.offset";

        public static string TTF_PROP_FONT_CREATE_IOSTREAM_AUTOCLOSE_BOOLEAN => "SDL_ttf.font.create.iostream.autoclose";

        public static string TTF_PROP_FONT_CREATE_SIZE_FLOAT => "SDL_ttf.font.create.size";

        public static string TTF_PROP_FONT_CREATE_FACE_NUMBER => "SDL_ttf.font.create.face";

        public static string TTF_PROP_FONT_CREATE_HORIZONTAL_DPI_NUMBER => "SDL_ttf.font.create.hdpi";

        public static string TTF_PROP_FONT_CREATE_VERTICAL_DPI_NUMBER => "SDL_ttf.font.create.vdpi";

        public static string TTF_PROP_FONT_CREATE_EXISTING_FONT_POINTER => "SDL_ttf.font.create.existing_font";

        public static string TTF_PROP_FONT_OUTLINE_LINE_CAP_NUMBER => "SDL_ttf.font.outline.line_cap";

        public static string TTF_PROP_FONT_OUTLINE_LINE_JOIN_NUMBER => "SDL_ttf.font.outline.line_join";

        public static string TTF_PROP_FONT_OUTLINE_MITER_LIMIT_NUMBER => "SDL_ttf.font.outline.miter_limit";

        public const int TTF_STYLE_NORMAL = 0x00;

        public const int TTF_STYLE_BOLD = 0x01;

        public const int TTF_STYLE_ITALIC = 0x02;

        public const int TTF_STYLE_UNDERLINE = 0x04;

        public const int TTF_STYLE_STRIKETHROUGH = 0x08;

        public const int TTF_FONT_WEIGHT_THIN = 100;

        public const int TTF_FONT_WEIGHT_EXTRA_LIGHT = 200;

        public const int TTF_FONT_WEIGHT_LIGHT = 300;

        public const int TTF_FONT_WEIGHT_NORMAL = 400;

        public const int TTF_FONT_WEIGHT_MEDIUM = 500;

        public const int TTF_FONT_WEIGHT_SEMI_BOLD = 600;

        public const int TTF_FONT_WEIGHT_BOLD = 700;

        public const int TTF_FONT_WEIGHT_EXTRA_BOLD = 800;

        public const int TTF_FONT_WEIGHT_BLACK = 900;

        public const int TTF_FONT_WEIGHT_EXTRA_BLACK = 950;

        public static string TTF_PROP_RENDERER_TEXT_ENGINE_RENDERER_POINTER => "SDL_ttf.renderer_text_engine.create.renderer";

        public static string TTF_PROP_RENDERER_TEXT_ENGINE_ATLAS_TEXTURE_SIZE_NUMBER => "SDL_ttf.renderer_text_engine.create.atlas_texture_size";

        public static string TTF_PROP_GPU_TEXT_ENGINE_DEVICE_POINTER => "SDL_ttf.gpu_text_engine.create.device";

        public static string TTF_PROP_GPU_TEXT_ENGINE_ATLAS_TEXTURE_SIZE_NUMBER => "SDL_ttf.gpu_text_engine.create.atlas_texture_size";

        public static string TTF_PROP_GL_TEXT_ENGINE_ATLAS_TEXTURE_SIZE_NUMBER => "SDL_ttf.gl_text_engine.create.atlas_texture_size";

        public const int TTF_SUBSTRING_DIRECTION_MASK = 0x000000FF;

        public const int TTF_SUBSTRING_TEXT_START = 0x00000100;

        public const int TTF_SUBSTRING_LINE_START = 0x00000200;

        public const int TTF_SUBSTRING_LINE_END = 0x00000400;

        public const int TTF_SUBSTRING_TEXT_END = 0x00000800;
    }
}
