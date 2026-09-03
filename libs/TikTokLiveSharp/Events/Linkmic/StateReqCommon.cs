namespace TikTokLiveSharp.Events.Linkmic
{
    public sealed class StateReqCommon
    {
        public readonly int Scene;
        public readonly long AppId;
        public readonly long LiveId;
        public readonly Player Myself;
        public readonly long ChannelId;

        private StateReqCommon(Models.Protobuf.LinkmicCommon.StateReqCommon rtcVideoParam)
        {
            Scene = rtcVideoParam?.Scene ?? -1;
            AppId = rtcVideoParam?.AppId ?? -1;
            LiveId = rtcVideoParam?.LiveId ?? -1;
            Myself = rtcVideoParam?.Myself;
            ChannelId = rtcVideoParam?.ChannelId ?? -1;
        }

        public static implicit operator StateReqCommon(Models.Protobuf.LinkmicCommon.StateReqCommon rtcVideoParam) => new StateReqCommon(rtcVideoParam);
    }
}
