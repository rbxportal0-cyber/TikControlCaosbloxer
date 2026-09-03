using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class HourlyRankEntrance
    {
        public readonly bool ShowEntrance;
        public readonly IReadOnlyList<HourlyRankSlidePage> Slides;
        public readonly long Countdown;
        public readonly Text DefaultContent;
        public readonly HourlyRankSprintPrompt SprintPrompt;
        public readonly RankViewType RankType;
        public readonly bool AnchorOnList;
        public readonly long RollDuration;
        public readonly bool BlockMessage;
        public readonly bool ShowEntranceAnimation;

        private HourlyRankEntrance(Models.Protobuf.Objects.HourlyRankEntrance rankEntrance)
        {
            ShowEntrance = rankEntrance?.ShowEntrance ?? false;
            Slides = rankEntrance?.SlidesList?.Count > 0 ? rankEntrance.SlidesList.Select(p => (HourlyRankSlidePage)p).ToList().AsReadOnly() : new List<HourlyRankSlidePage>(0).AsReadOnly();
            Countdown = rankEntrance?.Countdown ?? -1;
            DefaultContent = rankEntrance?.DefaultContent;
            SprintPrompt = rankEntrance?.SprintPrompt;
            RankType = rankEntrance?.RankType ?? RankViewType.Unknown;
            AnchorOnList = rankEntrance?.AnchorOnList ?? false;
            RollDuration = rankEntrance?.RollDuration ?? -1;
            BlockMessage = rankEntrance?.BlockMessage ?? false;
            ShowEntranceAnimation = rankEntrance?.ShowEntranceAnimation ?? false;
        }

        public static implicit operator HourlyRankEntrance(Models.Protobuf.Objects.HourlyRankEntrance rankEntrance) => new HourlyRankEntrance(rankEntrance);
    }
}
