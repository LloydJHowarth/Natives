using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal enum TTF_DrawCommand
    {
        TTF_DRAW_COMMAND_NOOP,
        TTF_DRAW_COMMAND_FILL,
        TTF_DRAW_COMMAND_COPY,
    }

    internal partial struct TTF_FillOperation
    {
        private TTF_DrawCommand cmd;

        private SDL_Rect rect;
    }

    internal unsafe partial struct TTF_CopyOperation
    {
        private TTF_DrawCommand cmd;

        private int text_offset;

        private TTF_Font* glyph_font;

        private uint glyph_index;

        private SDL_Rect src;

        private SDL_Rect dst;

        private IntPtr reserved;
    }

    [StructLayout(LayoutKind.Explicit)]
    internal partial struct TTF_DrawOperation
    {
        [FieldOffset(0)]
        private TTF_DrawCommand cmd;

        [FieldOffset(0)]
        private TTF_FillOperation fill;

        [FieldOffset(0)]
        private TTF_CopyOperation copy;
    }

    internal partial struct TTF_TextLayout
    {
    }

    internal unsafe partial struct TTF_TextData
    {
        private TTF_Font* font;

        private SDL_FColor color;

        private SDL_Bool needs_layout_update;

        private TTF_TextLayout* layout;

        private int x;

        private int y;

        private int w;

        private int h;

        private int num_ops;

        private TTF_DrawOperation* ops;

        private int num_clusters;

        private TTF_SubString* clusters;

        private uint props;

        private SDL_Bool needs_engine_update;

        private TTF_TextEngine* engine;

        private IntPtr engine_text;
    }

    internal partial struct TTF_TextEngine
    {
        private uint version;

        private IntPtr userdata;

        private IntPtr CreateText;

        private IntPtr DestroyText;
    }
}
