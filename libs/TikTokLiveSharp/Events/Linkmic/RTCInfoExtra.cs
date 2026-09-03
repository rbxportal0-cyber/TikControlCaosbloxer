namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCInfoExtra
    {
        public readonly string Version;

        private RTCInfoExtra(Models.Protobuf.LinkmicCommon.RTCInfoExtra rtcInfoExtra)
        {
            Version = rtcInfoExtra?.Version ?? string.Empty;
        }

        public static implicit operator RTCInfoExtra(Models.Protobuf.LinkmicCommon.RTCInfoExtra rtcInfoExtra) => new RTCInfoExtra(rtcInfoExtra);
    }
}
