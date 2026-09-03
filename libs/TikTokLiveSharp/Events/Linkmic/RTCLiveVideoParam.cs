namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCLiveVideoParam
    {
        public readonly int StrategyId;
        public readonly RTCVideoParam Params;

        private RTCLiveVideoParam(Models.Protobuf.LinkmicCommon.RTCLiveVideoParam rtcLiveVideoParam)
        {
            StrategyId = rtcLiveVideoParam?.StrategyId ?? -1;
            Params = rtcLiveVideoParam?.Params;
        }

        public static implicit operator RTCLiveVideoParam(Models.Protobuf.LinkmicCommon.RTCLiveVideoParam rtcLiveVideoParam) => new RTCLiveVideoParam(rtcLiveVideoParam);
    }
}
