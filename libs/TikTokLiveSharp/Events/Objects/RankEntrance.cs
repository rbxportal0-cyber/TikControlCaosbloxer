using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class RankEntrance
    {
        public readonly RankViewType RankType;
        public readonly long Countdown;
        public readonly Text DefaultContent;
        public readonly RollCfg RollConfig;
        public readonly bool BlockMessage;
        public readonly long OwnerRankIdx;
        public readonly bool OwnerOnRank;
        public readonly RankViewType RelatedTabRankType;
        public readonly EntranceGroupType RequestFirstShowType;

        private RankEntrance(Models.Protobuf.Objects.RankEntrance entrance)
        {
            RankType = entrance?.RankType ?? RankViewType.Unknown;
            Countdown = entrance?.Countdown ?? -1;
            DefaultContent = entrance?.DefaultContent;
            RollConfig = entrance?.RollConfig;
            BlockMessage = entrance?.BlockMessage ?? false;
            OwnerRankIdx = entrance?.OwnerRankIdx ?? -1;
            OwnerOnRank = entrance?.OwnerOnRank ?? false;
            RelatedTabRankType = entrance?.RelatedTabRankType ?? RankViewType.Unknown;
            RequestFirstShowType = entrance?.RequestFirstShowType ?? EntranceGroupType.Entrance_Group_Type_Default;
        }

        public static implicit operator RankEntrance(Models.Protobuf.Objects.RankEntrance entrance) => new RankEntrance(entrance);
    }
}