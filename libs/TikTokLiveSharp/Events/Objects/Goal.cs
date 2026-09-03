using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Objects.Enums;

namespace TikTokLiveSharp.Events.Objects
{
    public sealed class Goal
    {
        public readonly long Id;
        public readonly GoalType Type;
        public readonly GoalStatus Status;
        public readonly IReadOnlyList<SubGoal> SubGoals;
        public readonly string Description;
        public readonly int AuditStatus;
        public readonly CycleType CycleType;
        public readonly long StartTime;
        public readonly long ExpireTime;
        public readonly long RealFinishTime;
        public readonly IReadOnlyList<GoalContributor> Contributors;
        public readonly int ContributorsLength;
        public readonly string IdString;
        public readonly string AuditDescription;
        public readonly GoalStats Stats;

        private Goal(Models.Protobuf.Objects.Goal goal)
        {
            Id = goal?.Id ?? -1;
            Type = goal?.Type ?? GoalType.GoalTypeUnknown;
            Status = goal?.Status ?? GoalStatus.GoalStatusUnknown;
            SubGoals = goal?.SubGoalsList?.Count > 0 ? goal.SubGoalsList.Select(g => (SubGoal)g).ToList().AsReadOnly() : new List<SubGoal>(0).AsReadOnly();
            Description = goal?.Description ?? string.Empty;
            AuditStatus = goal?.AuditStatus ?? -1;
            CycleType = goal?.CycleType ?? CycleType.CycleTypeUnknown;
            StartTime = goal?.StartTime ?? -1;
            ExpireTime = goal?.ExpireTime ?? -1;
            RealFinishTime = goal?.RealFinishTime ?? -1;
            Contributors = goal?.ContributorsList?.Count > 0 ? goal.ContributorsList.Select(c => (GoalContributor)c).ToList().AsReadOnly() : new List<GoalContributor>(0).AsReadOnly();
            ContributorsLength = goal?.ContributorsLength ?? 0;
            IdString = goal?.IdStr ?? string.Empty;
            AuditDescription = goal?.AuditDescription ?? string.Empty;
            Stats = goal?.Stats;
        }

        public static implicit operator Goal(Models.Protobuf.Objects.Goal goal) => new Goal(goal);
    }
}
