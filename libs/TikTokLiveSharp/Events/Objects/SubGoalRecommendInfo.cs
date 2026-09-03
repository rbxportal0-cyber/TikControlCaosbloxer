using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class SubGoalRecommendInfo
    {
        public readonly SubGoalType Type;
        public readonly IReadOnlyList<SubGoal> ItemsList;
        public readonly string Description;
        public readonly SubscriptionGoalRecExtra SubscriptionRecExtra;
        public readonly StreamGoalRecExtra StreamGoalRecExtra;

        private SubGoalRecommendInfo(Models.Protobuf.Objects.SubGoalRecommendInfo info)
        {
            Type = info?.Type ?? SubGoalType.SubGoalTypeUnknown;
            ItemsList = info?.ItemsList?.Count > 0 ? info.ItemsList.Select(g => (SubGoal)g).ToList().AsReadOnly() : new List<SubGoal>(0).AsReadOnly();
            Description = info?.Description ?? string.Empty;
            SubscriptionRecExtra = info?.SubscriptionRecExtra;
            StreamGoalRecExtra = info?.StreamGoalRecExtra;
        }

        public static implicit operator SubGoalRecommendInfo(Models.Protobuf.Objects.SubGoalRecommendInfo info) => new SubGoalRecommendInfo(info);
    }
}
