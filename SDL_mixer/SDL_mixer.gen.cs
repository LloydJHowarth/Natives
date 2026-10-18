using System;
using System.Runtime.InteropServices;

namespace Toolkit.SDL3
{
    internal partial struct MIX_Mixer
    {
    }

    internal partial struct MIX_Audio
    {
    }

    internal partial struct MIX_Track
    {
    }

    internal partial struct MIX_Group
    {
    }

    internal partial struct MIX_StereoGains
    {
        private float left;

        private float right;
    }

    internal partial struct MIX_Point3D
    {
        private float x;

        private float y;

        private float z;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void MIX_TrackStoppedCallback(IntPtr userdata, MIX_Track* track);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void MIX_TrackMixCallback(IntPtr userdata, MIX_Track* track, SDL_AudioSpec* spec, float* pcm, int samples);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void MIX_GroupMixCallback(IntPtr userdata, MIX_Group* group, SDL_AudioSpec* spec, float* pcm, int samples);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal unsafe delegate void MIX_PostMixCallback(IntPtr userdata, MIX_Mixer* mixer, SDL_AudioSpec* spec, float* pcm, int samples);

    internal partial struct MIX_AudioDecoder
    {
    }

    internal static unsafe partial class MIX
    {
        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_Version", ExactSpelling = true)]
        private static extern int iMIX_Version();

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_Init", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_Init();

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_Quit", ExactSpelling = true)]
        private static extern void iMIX_Quit();

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetNumAudioDecoders", ExactSpelling = true)]
        private static extern int iMIX_GetNumAudioDecoders();

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetAudioDecoder", ExactSpelling = true)]
        private static extern byte* iMIX_GetAudioDecoder(int index);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateMixerDevice", ExactSpelling = true)]
        private static extern MIX_Mixer* iMIX_CreateMixerDevice(uint devid, SDL_AudioSpec* spec);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateMixer", ExactSpelling = true)]
        private static extern MIX_Mixer* iMIX_CreateMixer(SDL_AudioSpec* spec);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_DestroyMixer", ExactSpelling = true)]
        private static extern void iMIX_DestroyMixer(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetMixerProperties", ExactSpelling = true)]
        private static extern uint iMIX_GetMixerProperties(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetMixerFormat", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_GetMixerFormat(MIX_Mixer* mixer, SDL_AudioSpec* spec);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LockMixer", ExactSpelling = true)]
        private static extern void iMIX_LockMixer(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_UnlockMixer", ExactSpelling = true)]
        private static extern void iMIX_UnlockMixer(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadAudio_IO", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadAudio_IO(MIX_Mixer* mixer, SDL_IOStream* io, SDL_Bool predecode, SDL_Bool closeio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadAudio", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadAudio(MIX_Mixer* mixer, byte* path, SDL_Bool predecode);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadAudioNoCopy", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadAudioNoCopy(MIX_Mixer* mixer, IntPtr data, nuint datalen, SDL_Bool free_when_done);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadAudioWithProperties", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadAudioWithProperties(uint props);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadRawAudio_IO", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadRawAudio_IO(MIX_Mixer* mixer, SDL_IOStream* io, SDL_AudioSpec* spec, SDL_Bool closeio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadRawAudio", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadRawAudio(MIX_Mixer* mixer, IntPtr data, nuint datalen, SDL_AudioSpec* spec);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_LoadRawAudioNoCopy", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_LoadRawAudioNoCopy(MIX_Mixer* mixer, IntPtr data, nuint datalen, SDL_AudioSpec* spec, SDL_Bool free_when_done);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateSineWaveAudio", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_CreateSineWaveAudio(MIX_Mixer* mixer, int hz, float amplitude, long ms);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetAudioProperties", ExactSpelling = true)]
        private static extern uint iMIX_GetAudioProperties(MIX_Audio* audio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetAudioDuration", ExactSpelling = true)]
        private static extern long iMIX_GetAudioDuration(MIX_Audio* audio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetAudioFormat", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_GetAudioFormat(MIX_Audio* audio, SDL_AudioSpec* spec);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_DestroyAudio", ExactSpelling = true)]
        private static extern void iMIX_DestroyAudio(MIX_Audio* audio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateTrack", ExactSpelling = true)]
        private static extern MIX_Track* iMIX_CreateTrack(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_DestroyTrack", ExactSpelling = true)]
        private static extern void iMIX_DestroyTrack(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackProperties", ExactSpelling = true)]
        private static extern uint iMIX_GetTrackProperties(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackMixer", ExactSpelling = true)]
        private static extern MIX_Mixer* iMIX_GetTrackMixer(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackAudio", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackAudio(MIX_Track* track, MIX_Audio* audio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackAudioStream", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackAudioStream(MIX_Track* track, SDL_AudioStream* stream);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackIOStream", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackIOStream(MIX_Track* track, SDL_IOStream* io, SDL_Bool closeio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackRawIOStream", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackRawIOStream(MIX_Track* track, SDL_IOStream* io, SDL_AudioSpec* spec, SDL_Bool closeio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_TagTrack", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_TagTrack(MIX_Track* track, byte* tag);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_UntagTrack", ExactSpelling = true)]
        private static extern void iMIX_UntagTrack(MIX_Track* track, byte* tag);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackTags", ExactSpelling = true)]
        private static extern byte** iMIX_GetTrackTags(MIX_Track* track, int* count);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTaggedTracks", ExactSpelling = true)]
        private static extern MIX_Track** iMIX_GetTaggedTracks(MIX_Mixer* mixer, byte* tag, int* count);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackPlaybackPosition", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackPlaybackPosition(MIX_Track* track, long frames);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackPlaybackPosition", ExactSpelling = true)]
        private static extern long iMIX_GetTrackPlaybackPosition(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackFadeFrames", ExactSpelling = true)]
        private static extern long iMIX_GetTrackFadeFrames(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackLoops", ExactSpelling = true)]
        private static extern int iMIX_GetTrackLoops(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackLoops", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackLoops(MIX_Track* track, int num_loops);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackAudio", ExactSpelling = true)]
        private static extern MIX_Audio* iMIX_GetTrackAudio(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackAudioStream", ExactSpelling = true)]
        private static extern SDL_AudioStream* iMIX_GetTrackAudioStream(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackRemaining", ExactSpelling = true)]
        private static extern long iMIX_GetTrackRemaining(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_TrackMSToFrames", ExactSpelling = true)]
        private static extern long iMIX_TrackMSToFrames(MIX_Track* track, long ms);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_TrackFramesToMS", ExactSpelling = true)]
        private static extern long iMIX_TrackFramesToMS(MIX_Track* track, long frames);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_AudioMSToFrames", ExactSpelling = true)]
        private static extern long iMIX_AudioMSToFrames(MIX_Audio* audio, long ms);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_AudioFramesToMS", ExactSpelling = true)]
        private static extern long iMIX_AudioFramesToMS(MIX_Audio* audio, long frames);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_MSToFrames", ExactSpelling = true)]
        private static extern long iMIX_MSToFrames(int sample_rate, long ms);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_FramesToMS", ExactSpelling = true)]
        private static extern long iMIX_FramesToMS(int sample_rate, long frames);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_PlayTrack", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_PlayTrack(MIX_Track* track, uint options);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_PlayTag", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_PlayTag(MIX_Mixer* mixer, byte* tag, uint options);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_PlayAudio", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_PlayAudio(MIX_Mixer* mixer, MIX_Audio* audio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_StopTrack", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_StopTrack(MIX_Track* track, long fade_out_frames);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_StopAllTracks", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_StopAllTracks(MIX_Mixer* mixer, long fade_out_ms);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_StopTag", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_StopTag(MIX_Mixer* mixer, byte* tag, long fade_out_ms);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_PauseTrack", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_PauseTrack(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_PauseAllTracks", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_PauseAllTracks(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_PauseTag", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_PauseTag(MIX_Mixer* mixer, byte* tag);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_ResumeTrack", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_ResumeTrack(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_ResumeAllTracks", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_ResumeAllTracks(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_ResumeTag", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_ResumeTag(MIX_Mixer* mixer, byte* tag);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_TrackPlaying", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_TrackPlaying(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_TrackPaused", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_TrackPaused(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetMixerGain", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetMixerGain(MIX_Mixer* mixer, float gain);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetMixerGain", ExactSpelling = true)]
        private static extern float iMIX_GetMixerGain(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackGain", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackGain(MIX_Track* track, float gain);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackGain", ExactSpelling = true)]
        private static extern float iMIX_GetTrackGain(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTagGain", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTagGain(MIX_Mixer* mixer, byte* tag, float gain);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetMixerFrequencyRatio", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetMixerFrequencyRatio(MIX_Mixer* mixer, float ratio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetMixerFrequencyRatio", ExactSpelling = true)]
        private static extern float iMIX_GetMixerFrequencyRatio(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackFrequencyRatio", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackFrequencyRatio(MIX_Track* track, float ratio);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrackFrequencyRatio", ExactSpelling = true)]
        private static extern float iMIX_GetTrackFrequencyRatio(MIX_Track* track);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackOutputChannelMap", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackOutputChannelMap(MIX_Track* track, int* chmap, int count);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackStereo", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackStereo(MIX_Track* track, MIX_StereoGains* gains);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrack3DPosition", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrack3DPosition(MIX_Track* track, MIX_Point3D* position);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetTrack3DPosition", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_GetTrack3DPosition(MIX_Track* track, MIX_Point3D* position);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateGroup", ExactSpelling = true)]
        private static extern MIX_Group* iMIX_CreateGroup(MIX_Mixer* mixer);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_DestroyGroup", ExactSpelling = true)]
        private static extern void iMIX_DestroyGroup(MIX_Group* group);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetGroupProperties", ExactSpelling = true)]
        private static extern uint iMIX_GetGroupProperties(MIX_Group* group);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetGroupMixer", ExactSpelling = true)]
        private static extern MIX_Mixer* iMIX_GetGroupMixer(MIX_Group* group);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackGroup", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackGroup(MIX_Track* track, MIX_Group* group);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackStoppedCallback", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackStoppedCallback(MIX_Track* track, IntPtr cb, IntPtr userdata);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackRawCallback", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackRawCallback(MIX_Track* track, IntPtr cb, IntPtr userdata);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetTrackCookedCallback", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetTrackCookedCallback(MIX_Track* track, IntPtr cb, IntPtr userdata);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetGroupPostMixCallback", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetGroupPostMixCallback(MIX_Group* group, IntPtr cb, IntPtr userdata);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_SetPostMixCallback", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_SetPostMixCallback(MIX_Mixer* mixer, IntPtr cb, IntPtr userdata);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_Generate", ExactSpelling = true)]
        private static extern int iMIX_Generate(MIX_Mixer* mixer, IntPtr buffer, int buflen);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateAudioDecoder", ExactSpelling = true)]
        private static extern MIX_AudioDecoder* iMIX_CreateAudioDecoder(byte* path, uint props);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_CreateAudioDecoder_IO", ExactSpelling = true)]
        private static extern MIX_AudioDecoder* iMIX_CreateAudioDecoder_IO(SDL_IOStream* io, SDL_Bool closeio, uint props);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_DestroyAudioDecoder", ExactSpelling = true)]
        private static extern void iMIX_DestroyAudioDecoder(MIX_AudioDecoder* audiodecoder);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetAudioDecoderProperties", ExactSpelling = true)]
        private static extern uint iMIX_GetAudioDecoderProperties(MIX_AudioDecoder* audiodecoder);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_GetAudioDecoderFormat", ExactSpelling = true)]
        private static extern SDL_Bool iMIX_GetAudioDecoderFormat(MIX_AudioDecoder* audiodecoder, SDL_AudioSpec* spec);

        [DllImport("SDL3_mixer", CallingConvention = CallingConvention.Cdecl, EntryPoint = "MIX_DecodeAudio", ExactSpelling = true)]
        private static extern int iMIX_DecodeAudio(MIX_AudioDecoder* audiodecoder, IntPtr buffer, int buflen, SDL_AudioSpec* spec);

        public const int SDL_MIXER_MAJOR_VERSION = 3;

        public const int SDL_MIXER_MINOR_VERSION = 3;

        public const int SDL_MIXER_MICRO_VERSION = 0;

        public const int SDL_MIXER_VERSION = ((3) * 1000000 + (3) * 1000 + (0));

        public static string MIX_PROP_MIXER_DEVICE_NUMBER => "SDL_mixer.mixer.device";

        public static string MIX_PROP_AUDIO_LOAD_IOSTREAM_POINTER => "SDL_mixer.audio.load.iostream";

        public static string MIX_PROP_AUDIO_LOAD_CLOSEIO_BOOLEAN => "SDL_mixer.audio.load.closeio";

        public static string MIX_PROP_AUDIO_LOAD_PREDECODE_BOOLEAN => "SDL_mixer.audio.load.predecode";

        public static string MIX_PROP_AUDIO_LOAD_PREFERRED_MIXER_POINTER => "SDL_mixer.audio.load.preferred_mixer";

        public static string MIX_PROP_AUDIO_LOAD_SKIP_METADATA_TAGS_BOOLEAN => "SDL_mixer.audio.load.skip_metadata_tags";

        public static string MIX_PROP_AUDIO_LOAD_IGNORE_LOOPS_BOOLEAN => "SDL_mixer.audio.load.ignore_loops";

        public static string MIX_PROP_AUDIO_DECODER_STRING => "SDL_mixer.audio.decoder";

        public static string MIX_PROP_METADATA_TITLE_STRING => "SDL_mixer.metadata.title";

        public static string MIX_PROP_METADATA_ARTIST_STRING => "SDL_mixer.metadata.artist";

        public static string MIX_PROP_METADATA_ALBUM_STRING => "SDL_mixer.metadata.album";

        public static string MIX_PROP_METADATA_COPYRIGHT_STRING => "SDL_mixer.metadata.copyright";

        public static string MIX_PROP_METADATA_TRACK_NUMBER => "SDL_mixer.metadata.track";

        public static string MIX_PROP_METADATA_TOTAL_TRACKS_NUMBER => "SDL_mixer.metadata.total_tracks";

        public static string MIX_PROP_METADATA_YEAR_NUMBER => "SDL_mixer.metadata.year";

        public static string MIX_PROP_METADATA_DURATION_FRAMES_NUMBER => "SDL_mixer.metadata.duration_frames";

        public static string MIX_PROP_METADATA_DURATION_INFINITE_BOOLEAN => "SDL_mixer.metadata.duration_infinite";

        public const int MIX_DURATION_UNKNOWN = -1;

        public const int MIX_DURATION_INFINITE = -2;

        public static string MIX_PROP_PLAY_LOOPS_NUMBER => "SDL_mixer.play.loops";

        public static string MIX_PROP_PLAY_MAX_FRAME_NUMBER => "SDL_mixer.play.max_frame";

        public static string MIX_PROP_PLAY_MAX_MILLISECONDS_NUMBER => "SDL_mixer.play.max_milliseconds";

        public static string MIX_PROP_PLAY_START_FRAME_NUMBER => "SDL_mixer.play.start_frame";

        public static string MIX_PROP_PLAY_START_MILLISECOND_NUMBER => "SDL_mixer.play.start_millisecond";

        public static string MIX_PROP_PLAY_START_ORDER_NUMBER => "SDL_mixer.play.start_order";

        public static string MIX_PROP_PLAY_LOOP_START_FRAME_NUMBER => "SDL_mixer.play.loop_start_frame";

        public static string MIX_PROP_PLAY_LOOP_START_MILLISECOND_NUMBER => "SDL_mixer.play.loop_start_millisecond";

        public static string MIX_PROP_PLAY_FADE_IN_FRAMES_NUMBER => "SDL_mixer.play.fade_in_frames";

        public static string MIX_PROP_PLAY_FADE_IN_MILLISECONDS_NUMBER => "SDL_mixer.play.fade_in_milliseconds";

        public static string MIX_PROP_PLAY_FADE_IN_START_GAIN_FLOAT => "SDL_mixer.play.fade_in_start_gain";

        public static string MIX_PROP_PLAY_APPEND_SILENCE_FRAMES_NUMBER => "SDL_mixer.play.append_silence_frames";

        public static string MIX_PROP_PLAY_APPEND_SILENCE_MILLISECONDS_NUMBER => "SDL_mixer.play.append_silence_milliseconds";

        public static string MIX_PROP_PLAY_HALT_WHEN_EXHAUSTED_BOOLEAN => "SDL_mixer.play.halt_when_exhausted";
    }
}
