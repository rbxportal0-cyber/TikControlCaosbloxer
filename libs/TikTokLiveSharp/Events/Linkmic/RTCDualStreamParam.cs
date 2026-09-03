namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class RTCDualStreamParam
    {
        public readonly int RemoteDefaultStreamType;
        public readonly int IsAutoSwitch;
        public readonly int AutoSwitchUserNum;
        public readonly RTCVideoParam HdVideoParam;
        public readonly RTCVideoParam SdVideoParam;

        private RTCDualStreamParam(Models.Protobuf.LinkmicCommon.RTCDualStreamParam rtcDualStreamParam)
        {
            RemoteDefaultStreamType = rtcDualStreamParam?.RemoteDefaultStreamType ?? -1;
            IsAutoSwitch = rtcDualStreamParam?.IsAutoSwitch ?? -1;
            AutoSwitchUserNum = rtcDualStreamParam?.AutoSwitchUserNum ?? -1;
            HdVideoParam = rtcDualStreamParam?.HdVideoParam;
            SdVideoParam = rtcDualStreamParam?.SdVideoParam;
        }

        public static implicit operator RTCDualStreamParam(Models.Protobuf.LinkmicCommon.RTCDualStreamParam rtcDualStreamParam) => new RTCDualStreamParam(rtcDualStreamParam);
    }
}
