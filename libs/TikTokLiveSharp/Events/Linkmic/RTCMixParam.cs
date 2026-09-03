namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCMixParam
    {
        public readonly int VideoBitrateKbps;

        private RTCMixParam(Models.Protobuf.LinkmicCommon.RTCMixParam rtcMixParam)
        {
            VideoBitrateKbps = rtcMixParam?.VideoBitrateKbps ?? -1;
        }

        public static implicit operator RTCMixParam(Models.Protobuf.LinkmicCommon.RTCMixParam rtcMixParam) => new RTCMixParam(rtcMixParam);
    }
}
