namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCEngineConfig
    {
        public readonly string RTCAppId;
        public readonly string RTCUserId;
        public readonly string RTCToken;
        public readonly long RTCChannelId;

        private RTCEngineConfig(Models.Protobuf.LinkmicCommon.RTCEngineConfig rtcEngineConfig)
        {
            RTCAppId = rtcEngineConfig?.RTCAppId ?? string.Empty;
            RTCUserId = rtcEngineConfig?.RTCUserId ?? string.Empty;
            RTCToken = rtcEngineConfig?.RTCToken ?? string.Empty;
            RTCChannelId = rtcEngineConfig?.RTCChannelId ?? -1;
        }

        public static implicit operator RTCEngineConfig(Models.Protobuf.LinkmicCommon.RTCEngineConfig rtcEngineConfig) => new RTCEngineConfig(rtcEngineConfig);
    }
}
