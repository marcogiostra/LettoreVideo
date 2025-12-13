using NAudio.CoreAudioApi;

namespace LettoreVideo.Classi
{
    public static class AudioManager
    {
        private static readonly MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

        private static MMDevice GetDefaultDevice()
        {
            return enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        }

        public static float GetMasterVolume()   // valore 0..1
        {
            return GetDefaultDevice().AudioEndpointVolume.MasterVolumeLevelScalar;
        }

        public static void SetMasterVolume(float value)  // valore 0..1
        {
            GetDefaultDevice().AudioEndpointVolume.MasterVolumeLevelScalar = value;
        }

        public static bool GetMute()
        {
            return GetDefaultDevice().AudioEndpointVolume.Mute;
        }

        public static void SetMute(bool mute)
        {
            GetDefaultDevice().AudioEndpointVolume.Mute = mute;
        }
    }
}
    
