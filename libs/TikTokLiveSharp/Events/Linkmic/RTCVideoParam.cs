namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCVideoParam
    {
        public readonly int Width;
        public readonly int Height;
        public readonly int Fps;
        public readonly int BitrateKbps;

        private RTCVideoParam(Models.Protobuf.LinkmicCommon.RTCVideoParam rtcVideoParam)
        {
            Width = rtcVideoParam?.Width ?? -1;
            Height = rtcVideoParam?.Height ?? -1;
            Fps = rtcVideoParam?.Fps ?? -1;
            BitrateKbps = rtcVideoParam?.BitrateKbps ?? -1;
        }

        public static implicit operator RTCVideoParam(Models.Protobuf.LinkmicCommon.RTCVideoParam rtcVideoParam) => new RTCVideoParam(rtcVideoParam);
    }
}
