using TikTokLiveSharp.Models.Protobuf.Messages.Enums;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubInfo
    {
        public readonly string UserId;
        public readonly string HostId;
        public readonly long SubStartTime;
        public readonly long SubEndTime;
        public readonly long NextRenewTime;
        public readonly int SubscribedMonth;
        public readonly bool IsSubscribing;
        public readonly SubLevel SubLevel;
        public readonly SubscribingStatus Status;
        public readonly bool SubInfoNotFound;
        public readonly string SKUName;
        public readonly PayChannel PayChannel;
        public readonly GraceInfo GraceInfo;
        public readonly SubStatisticsData StatisticsInfo;
        public readonly int SubscribedDays;
        public readonly PriceChangeInfo PriceChangeInfo;

        private SubInfo(Models.Protobuf.Objects.SubInfo subInfo)
        {
            UserId = subInfo?.UserId ?? string.Empty;
            HostId = subInfo?.AnchorId ?? string.Empty;
            SubStartTime = subInfo?.SubStartTime ?? -1;
            SubEndTime = subInfo?.SubEndTime ?? -1;
            NextRenewTime = subInfo?.NextRenewTime ?? -1;
            SubscribedMonth = subInfo?.SubscribedMonth ?? -1;
            IsSubscribing = subInfo?.IsSubscribing ?? false;
            SubLevel = subInfo?.SubLevel;
            Status = subInfo?.Status ?? SubscribingStatus.SubscribingStatus_Unknown;
            SubInfoNotFound = subInfo?.SubInfoNotFound ?? false;
            SKUName = subInfo?.SKUName ?? string.Empty;
            PayChannel = subInfo?.PayChannel ?? PayChannel.PayChan_Unknown;
            GraceInfo = subInfo?.GraceInfo;
            StatisticsInfo = subInfo?.StatisticsInfo;
            SubscribedDays = subInfo?.SubscribedDays ?? -1;
            PriceChangeInfo = subInfo?.PriceChangeInfo;
        }

        public static implicit operator SubInfo(Models.Protobuf.Objects.SubInfo subInfo) => new SubInfo(subInfo);
    }
}
