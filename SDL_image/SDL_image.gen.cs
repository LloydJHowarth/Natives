using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal unsafe partial struct IMG_Animation
    {
        private int w;

        private int h;

        private int count;

        private SDL_Surface** frames;

        private int* delays;
    }

    internal partial struct IMG_AnimationEncoder
    {
    }

    internal enum IMG_AnimationDecoderStatus
    {
        IMG_DECODER_STATUS_INVALID = -1,
        IMG_DECODER_STATUS_OK,
        IMG_DECODER_STATUS_FAILED,
        IMG_DECODER_STATUS_COMPLETE,
    }

    internal partial struct IMG_AnimationDecoder
    {
    }

    internal static unsafe partial class IMG
    {
        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Version", ExactSpelling = true)]
        private static extern int iIMG_Version();

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_Load(byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_Load_IO(SDL_IOStream* src, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTyped_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadTyped_IO(SDL_IOStream* src, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture", ExactSpelling = true)]
        private static extern SDL_Texture* iIMG_LoadTexture(SDL_Renderer* renderer, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture_IO", ExactSpelling = true)]
        private static extern SDL_Texture* iIMG_LoadTexture_IO(SDL_Renderer* renderer, SDL_IOStream* src, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTextureTyped_IO", ExactSpelling = true)]
        private static extern SDL_Texture* iIMG_LoadTextureTyped_IO(SDL_Renderer* renderer, SDL_IOStream* src, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGPUTexture", ExactSpelling = true)]
        private static extern SDL_GPUTexture* iIMG_LoadGPUTexture(SDL_GPUDevice* device, SDL_GPUCopyPass* copy_pass, byte* file, int* width, int* height);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGPUTexture_IO", ExactSpelling = true)]
        private static extern SDL_GPUTexture* iIMG_LoadGPUTexture_IO(SDL_GPUDevice* device, SDL_GPUCopyPass* copy_pass, SDL_IOStream* src, SDL_Bool closeio, int* width, int* height);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGPUTextureTyped_IO", ExactSpelling = true)]
        private static extern SDL_GPUTexture* iIMG_LoadGPUTextureTyped_IO(SDL_GPUDevice* device, SDL_GPUCopyPass* copy_pass, SDL_IOStream* src, SDL_Bool closeio, byte* type, int* width, int* height);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_GetClipboardImage", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_GetClipboardImage();

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isANI", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isANI(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isAVIF", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isAVIF(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isCUR", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isCUR(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isBMP", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isBMP(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isGIF", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isGIF(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isICO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isICO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isJPG", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isJPG(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isJXL", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isJXL(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isLBM", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isLBM(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isPCX", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isPCX(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isPNG", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isPNG(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isPNM", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isPNM(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isQOI", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isQOI(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isSVG", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isSVG(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isTIF", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isTIF(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isWEBP", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isWEBP(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isXCF", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isXCF(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isXPM", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isXPM(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_isXV", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_isXV(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAVIF_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadAVIF_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadBMP_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadBMP_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadCUR_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadCUR_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGIF_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadGIF_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadICO_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadICO_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadJPG_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadJPG_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadJXL_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadJXL_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadLBM_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadLBM_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadPCX_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadPCX_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadPNG_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadPNG_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadPNM_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadPNM_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadSVG_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadSVG_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadSizedSVG_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadSizedSVG_IO(SDL_IOStream* src, int width, int height);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadQOI_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadQOI_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTGA_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadTGA_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTIF_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadTIF_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadWEBP_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadWEBP_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadXCF_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadXCF_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadXPM_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadXPM_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadXV_IO", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_LoadXV_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ReadXPMFromArray", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_ReadXPMFromArray(byte** xpm);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ReadXPMFromArrayToRGB888", ExactSpelling = true)]
        private static extern SDL_Surface* iIMG_ReadXPMFromArrayToRGB888(byte** xpm);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Save", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_Save(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveTyped_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveTyped_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveAVIF", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveAVIF(SDL_Surface* surface, byte* file, int quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveAVIF_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveAVIF_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio, int quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveBMP", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveBMP(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveBMP_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveBMP_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveCUR", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveCUR(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveCUR_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveCUR_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveGIF", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveGIF(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveGIF_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveGIF_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveICO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveICO(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveICO_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveICO_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveJPG(SDL_Surface* surface, byte* file, int quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveJPG_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio, int quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SavePNG(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SavePNG_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveTGA", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveTGA(SDL_Surface* surface, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveTGA_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveTGA_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveWEBP", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveWEBP(SDL_Surface* surface, byte* file, float quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveWEBP_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveWEBP_IO(SDL_Surface* surface, SDL_IOStream* dst, SDL_Bool closeio, float quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadAnimation(byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimation_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadAnimation_IO(SDL_IOStream* src, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAnimationTyped_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadAnimationTyped_IO(SDL_IOStream* src, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadANIAnimation_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadANIAnimation_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAPNGAnimation_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadAPNGAnimation_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadAVIFAnimation_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadAVIFAnimation_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadGIFAnimation_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadGIFAnimation_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadWEBPAnimation_IO", ExactSpelling = true)]
        private static extern IMG_Animation* iIMG_LoadWEBPAnimation_IO(SDL_IOStream* src);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveAnimation", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveAnimation(IMG_Animation* anim, byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveAnimationTyped_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveAnimationTyped_IO(IMG_Animation* anim, SDL_IOStream* dst, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveANIAnimation_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveANIAnimation_IO(IMG_Animation* anim, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveAPNGAnimation_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveAPNGAnimation_IO(IMG_Animation* anim, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveAVIFAnimation_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveAVIFAnimation_IO(IMG_Animation* anim, SDL_IOStream* dst, SDL_Bool closeio, int quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveGIFAnimation_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveGIFAnimation_IO(IMG_Animation* anim, SDL_IOStream* dst, SDL_Bool closeio);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveWEBPAnimation_IO", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_SaveWEBPAnimation_IO(IMG_Animation* anim, SDL_IOStream* dst, SDL_Bool closeio, int quality);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimatedCursor", ExactSpelling = true)]
        private static extern SDL_Cursor* iIMG_CreateAnimatedCursor(IMG_Animation* anim, int hot_x, int hot_y);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_FreeAnimation", ExactSpelling = true)]
        private static extern void iIMG_FreeAnimation(IMG_Animation* anim);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimationEncoder", ExactSpelling = true)]
        private static extern IMG_AnimationEncoder* iIMG_CreateAnimationEncoder(byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimationEncoder_IO", ExactSpelling = true)]
        private static extern IMG_AnimationEncoder* iIMG_CreateAnimationEncoder_IO(SDL_IOStream* dst, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimationEncoderWithProperties", ExactSpelling = true)]
        private static extern IMG_AnimationEncoder* iIMG_CreateAnimationEncoderWithProperties(uint props);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_AddAnimationEncoderFrame", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_AddAnimationEncoderFrame(IMG_AnimationEncoder* encoder, SDL_Surface* surface, ulong duration);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CloseAnimationEncoder", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_CloseAnimationEncoder(IMG_AnimationEncoder* encoder);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimationDecoder", ExactSpelling = true)]
        private static extern IMG_AnimationDecoder* iIMG_CreateAnimationDecoder(byte* file);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimationDecoder_IO", ExactSpelling = true)]
        private static extern IMG_AnimationDecoder* iIMG_CreateAnimationDecoder_IO(SDL_IOStream* src, SDL_Bool closeio, byte* type);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CreateAnimationDecoderWithProperties", ExactSpelling = true)]
        private static extern IMG_AnimationDecoder* iIMG_CreateAnimationDecoderWithProperties(uint props);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_GetAnimationDecoderProperties", ExactSpelling = true)]
        private static extern uint iIMG_GetAnimationDecoderProperties(IMG_AnimationDecoder* decoder);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_GetAnimationDecoderFrame", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_GetAnimationDecoderFrame(IMG_AnimationDecoder* decoder, SDL_Surface** frame, ulong* duration);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_GetAnimationDecoderStatus", ExactSpelling = true)]
        private static extern IMG_AnimationDecoderStatus iIMG_GetAnimationDecoderStatus(IMG_AnimationDecoder* decoder);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ResetAnimationDecoder", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_ResetAnimationDecoder(IMG_AnimationDecoder* decoder);

        [DllImport("SDL3_image", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_CloseAnimationDecoder", ExactSpelling = true)]
        private static extern SDL_Bool iIMG_CloseAnimationDecoder(IMG_AnimationDecoder* decoder);

        public const int SDL_IMAGE_MAJOR_VERSION = 3;

        public const int SDL_IMAGE_MINOR_VERSION = 5;

        public const int SDL_IMAGE_MICRO_VERSION = 0;

        public const int SDL_IMAGE_VERSION = ((3) * 1000000 + (5) * 1000 + (0));

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_FILENAME_STRING => "SDL_image.animation_encoder.create.filename";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_IOSTREAM_POINTER => "SDL_image.animation_encoder.create.iostream";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_IOSTREAM_AUTOCLOSE_BOOLEAN => "SDL_image.animation_encoder.create.iostream.autoclose";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_TYPE_STRING => "SDL_image.animation_encoder.create.type";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_QUALITY_NUMBER => "SDL_image.animation_encoder.create.quality";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_TIMEBASE_NUMERATOR_NUMBER => "SDL_image.animation_encoder.create.timebase.numerator";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_TIMEBASE_DENOMINATOR_NUMBER => "SDL_image.animation_encoder.create.timebase.denominator";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_AVIF_MAX_THREADS_NUMBER => "SDL_image.animation_encoder.create.avif.max_threads";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_AVIF_KEYFRAME_INTERVAL_NUMBER => "SDL_image.animation_encoder.create.avif.keyframe_interval";

        public static string IMG_PROP_ANIMATION_ENCODER_CREATE_GIF_USE_LUT_BOOLEAN => "SDL_image.animation_encoder.create.gif.use_lut";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_FILENAME_STRING => "SDL_image.animation_decoder.create.filename";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_IOSTREAM_POINTER => "SDL_image.animation_decoder.create.iostream";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_IOSTREAM_AUTOCLOSE_BOOLEAN => "SDL_image.animation_decoder.create.iostream.autoclose";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_TYPE_STRING => "SDL_image.animation_decoder.create.type";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_TIMEBASE_NUMERATOR_NUMBER => "SDL_image.animation_decoder.create.timebase.numerator";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_TIMEBASE_DENOMINATOR_NUMBER => "SDL_image.animation_decoder.create.timebase.denominator";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_AVIF_MAX_THREADS_NUMBER => "SDL_image.animation_decoder.create.avif.max_threads";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_AVIF_ALLOW_INCREMENTAL_BOOLEAN => "SDL_image.animation_decoder.create.avif.allow_incremental";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_AVIF_ALLOW_PROGRESSIVE_BOOLEAN => "SDL_image.animation_decoder.create.avif.allow_progressive";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_GIF_TRANSPARENT_COLOR_INDEX_NUMBER => "SDL_image.animation_encoder.create.gif.transparent_color_index";

        public static string IMG_PROP_ANIMATION_DECODER_CREATE_GIF_NUM_COLORS_NUMBER => "SDL_image.animation_encoder.create.gif.num_colors";

        public static string IMG_PROP_METADATA_IGNORE_PROPS_BOOLEAN => "SDL_image.metadata.ignore_props";

        public static string IMG_PROP_METADATA_DESCRIPTION_STRING => "SDL_image.metadata.description";

        public static string IMG_PROP_METADATA_COPYRIGHT_STRING => "SDL_image.metadata.copyright";

        public static string IMG_PROP_METADATA_TITLE_STRING => "SDL_image.metadata.title";

        public static string IMG_PROP_METADATA_AUTHOR_STRING => "SDL_image.metadata.author";

        public static string IMG_PROP_METADATA_CREATION_TIME_STRING => "SDL_image.metadata.creation_time";

        public static string IMG_PROP_METADATA_FRAME_COUNT_NUMBER => "SDL_image.metadata.frame_count";

        public static string IMG_PROP_METADATA_LOOP_COUNT_NUMBER => "SDL_image.metadata.loop_count";
    }
}
