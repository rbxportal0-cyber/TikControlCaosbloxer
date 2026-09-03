namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RtcInfo
    {
        public readonly string Info;
        public readonly string LinkMicId;

        private RtcInfo(Models.Protobuf.LinkmicCommon.RtcInfo rtcInfo)
        {
            Info = rtcInfo?.Info ?? string.Empty;
            LinkMicId = rtcInfo?.LinkMicId ?? string.Empty;
        }

        public static implicit operator RtcInfo(Models.Protobuf.LinkmicCommon.RtcInfo rtcInfo) => new RtcInfo(rtcInfo);
    }
}
