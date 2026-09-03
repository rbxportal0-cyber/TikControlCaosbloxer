namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCMixBase
    {
        public readonly int Bitrate;

        private RTCMixBase(Models.Protobuf.LinkmicCommon.RTCMixBase rtcMixBase)
        {
            Bitrate = rtcMixBase?.Bitrate ?? -1;
        }

        public static implicit operator RTCMixBase(Models.Protobuf.LinkmicCommon.RTCMixBase rtcMixBase) => new RTCMixBase(rtcMixBase);
    }
}
