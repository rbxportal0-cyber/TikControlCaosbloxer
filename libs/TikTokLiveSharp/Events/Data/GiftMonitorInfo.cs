namespace TikTokLiveSharp.Events.Data
{
    public sealed class GiftMonitorInfo
    {
        public readonly long HostId;
        public readonly long ProfitApiMessageDuration;
        public readonly long SendGiftProfitApiStartMs;
        public readonly long SendGiftProfitCoreStartMs;
        public readonly long SendGiftRequestStartMs;
        public readonly long SendGiftSendMessageSuccessMs;
        public readonly long SendProfitApiDuration;
        public readonly long ToUserId;
        public readonly long SendGiftStartClientLocalMs;
        public readonly string FromPlatform;
        public readonly string FromVersion;

        private GiftMonitorInfo(Models.Protobuf.Messages.GiftMonitorInfo gmi)
        {
            HostId = gmi?.AnchorId ?? -1;
            ProfitApiMessageDuration = gmi?.ProfitApiMessageDur ?? -1;
            SendGiftProfitApiStartMs = gmi?.SendGiftProfitApiStartMs ?? -1;
            SendGiftProfitCoreStartMs = gmi?.SendGiftProfitCoreStartMs ?? -1;
            SendGiftRequestStartMs = gmi?.SendGiftReqStartMs ?? -1;
            SendGiftSendMessageSuccessMs = gmi?.SendGiftSendMessageSuccessMs ?? -1;
            SendProfitApiDuration = gmi?.SendProfitApiDur ?? -1;
            ToUserId = gmi?.ToUserId ?? -1;
            SendGiftStartClientLocalMs = gmi?.SendGiftStartClientLocalMs ?? -1;
            FromPlatform = gmi?.FromPlatform ?? string.Empty;
            FromVersion = gmi?.FromVersion ?? string.Empty;
        }

        public static implicit operator GiftMonitorInfo(Models.Protobuf.Messages.GiftMonitorInfo gmi) => new GiftMonitorInfo(gmi);
    }
}
